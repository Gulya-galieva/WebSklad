﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using WebSklad.Models;
using Microsoft.AspNetCore.Authorization;
using DbManager;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Cryptography;
using System.Text;

namespace WebSklad.Controllers
{
    public class AccountController : Controller
    {
        StoreContext db;
        public AccountController(StoreContext context)
        {
            db = context;
        }
        [HttpGet]
        [Authorize(Roles = "administrator")]
        public IActionResult Register()
        {
            List<string> roles = new List<string>();
            foreach (Role r in db.Roles)
                roles.Add(r.Name);
            ViewBag.roles = roles;
            return View();
        }

        [HttpGet]
        [Authorize(Roles = "administrator")]
        public IActionResult RegisterMounter()
        {
            List<DropDownItem> dropDownWorkerItems = new List<DropDownItem>();
            foreach (var item in db.Workers.Where(w => w.WorkerType.Description == "монтажник" || w.WorkerType.Description == "пнр"))
            {
                dropDownWorkerItems.Add(new DropDownItem { Name = item.Surname + " " + item.Name + " " + item.MIddlename, Id = item.Id });
            }
            SelectList workerList = new SelectList(dropDownWorkerItems, "Id", "Name");
            ViewBag.Workers = workerList;
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        [Authorize (Roles ="administrator")]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await db.Users.FirstOrDefaultAsync(u => u.Login == model.Login);
                if (user == null)
                {
                    // добавляем пользователя в бд
                    using (MD5 md5hash = MD5.Create())
                    {
                        user = new User { Login = model.Login, Email = model.Email, Password = GetMd5Hash(md5hash, model.Password) };
                    }
                    if (model.WorkerId != 0)
                    {
                        Worker worker = db.Workers.Find(model.WorkerId);
                        if (worker != null)
                        {
                            user.Name = worker.Surname + " " + worker.Name + " " + worker.MIddlename;
                            user.WorkerID = model.WorkerId;
                        }
                    }
                    else
                        user.Name = model.Name;
                    Role userRole = db.Roles.FirstOrDefault(r => r.Name == model.Role);
                    if (userRole != null)
                        user.Role = userRole;
                    
                    db.Users.Add(user);
                    await db.SaveChangesAsync();

                   // await Authenticate(user); // аутентификация

                    return RedirectToAction("Index", "Home");
                }
                else
                    ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                User user = new User();
                using (MD5 md5hash = MD5.Create())
                {
                    user = await db.Users
                    .Include(u => u.Role)
                    .FirstOrDefaultAsync(u => u.Login == model.Login && u.Password == GetMd5Hash(md5hash, model.Password));
                }
                if (user != null && user.Role.Name != "mounter")
                {
                    await Authenticate(user); // аутентификация

                    return RedirectToAction("Index", "Home");
                }
                ViewData["Error"] =  "Некорректные логин и(или) пароль";
            }
            return View(model);
        }
        private async Task Authenticate(User user)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Login),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role?.Name),
                //new Claim(ClaimsIdentity.)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("~/Home/Index");
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}