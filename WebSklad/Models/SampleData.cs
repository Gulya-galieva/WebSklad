using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbManager;

namespace WebSklad.Models
{
    public static class SampleData
    {
        public static void Initialize(StoreContext context)
        {
            if(!context.Roles.Any())
            {
                context.Roles.AddRange(
                    new Role { Name = "administrator" },
                    new Role { Name = "storekeeper"},
                    new Role { Name = "tuner" },
                    new Role { Name = "engineer" },
                    new Role { Name = "mounter"},
                    new Role { Name = "curator"},
                    new Role { Name = "operator" },
                    new Role { Name = "ascuemaster" },
                    new Role { Name = "pnr" },
                    new Role { Name = "guest"}
                    );
                context.SaveChanges();
            }
            

            if (!context.Users.Any())
            {
                context.Users.Add(new User() { Login = "admin", Password = "123", RoleId = 1 } );
                context.SaveChanges();
            }
          

            if (!context.DeliveryTypes.Any())
            {
                context.DeliveryTypes.AddRange(
                    new DeliveryType() { Description = "прием на склад"},
                    new DeliveryType() { Description = "выдача на настройку" },
                    new DeliveryType() { Description = "выдача на сборку" },
                    new DeliveryType() { Description = "выдача со склада" },
                    new DeliveryType() { Description = "возврат на склад" },
                    new DeliveryType() { Description = "возврат производителю" },
                    new DeliveryType() { Description = "комплект" },
                    new DeliveryType() { Description = "брак"},
                    new DeliveryType() { Description = "удаление из брака" },
                    new DeliveryType() { Description = "возврат со сборки" },
                    new DeliveryType() { Description = "возврат с настройки" },
                    new DeliveryType() { Description = "прием инструмента и сиз" },
                    new DeliveryType() { Description = "выдача инструмента и сиз" }
                    );
                context.SaveChanges();
                // дополнительные статусы для ПУ
                // проверен куратором   привязан к ту
            }
           

            if (!context.DeliveryStates.Any())
            {
                context.DeliveryStates.AddRange(
                    new DeliveryState() { Description = "в работе" },
                    new DeliveryState() { Description = "проведен" }
                );
                context.SaveChanges();
            }

            if (!context.WorkerTypes.Any())
            {
                context.WorkerTypes.AddRange(
                    new WorkerType() { Description = "монтажник" },
                    new WorkerType() { Description = "сборщик" },
                    new WorkerType() { Description = "настройщик" },
                    new WorkerType() { Description = "пнр" }
                );
                context.SaveChanges();
            }

            if(!context.MaterialUnits.Any())
            {
                context.MaterialUnits.AddRange(
                    new MaterialUnit() { Name = "м" },
                    new MaterialUnit() { Name = "Км" },
                    new MaterialUnit() { Name = "г" },
                    new MaterialUnit() { Name = "Кг" },
                    new MaterialUnit() { Name = "шт" },
                    new MaterialUnit() { Name = "уп" }
                    );
                context.SaveChanges();
            }

            if(!context.DeviceStateTypes.Any())
            {
                context.DeviceStateTypes.AddRange(
                new DeviceStateType() { Description = "прием на склад" },
                new DeviceStateType() { Description = "выдача на настройку" },
                new DeviceStateType() { Description = "выдача на сборку" },
                new DeviceStateType() { Description = "выдача со склада" },
                new DeviceStateType() { Description = "возврат на склад" },
                new DeviceStateType() { Description = "возврат производителю" },
                new DeviceStateType() { Description = "брак" },
                new DeviceStateType() { Description = "удаление из брака" },
                new DeviceStateType() { Description = "возврат со сборки" },
                new DeviceStateType() { Description = "возврат с настройки" },
                new DeviceStateType() { Description = "включен в отчет" },
                new DeviceStateType() { Description = "удален из отчета" },
                new DeviceStateType() { Description = "принят куратором" },
                new DeviceStateType() { Description = "привязан к ту" },
                new DeviceStateType() { Description = "привязан к КДЕ" },
                new DeviceStateType() { Description = "удален из КДЕ" },
                new DeviceStateType() { Description = "отвязан от ту" }
                );
                context.SaveChanges();
            }
            if(!context.KDETypes.Any())
            {
                context.KDETypes.AddRange(
                    new KDEType() { Name = "КДЕ-1" },
                    new KDEType() { Name = "КДЕ-1 GSM" },
                    new KDEType() { Name = "КДЕ-3" },
                    new KDEType() { Name = "КДЕ-3 GSM" },
                    new KDEType() { Name = "КДЕ-3-1" },
                    new KDEType() { Name = "КДЕ-3-2" }
                    );
                context.SaveChanges();
            }

            if (!context.ReportStates.Any())
            {
                context.ReportStates.AddRange(
                    new ReportState { Description = "в работе"},
                    new ReportState { Description = "отправлен куратору" },
                    new ReportState { Description = "принят куратором" },
                    new ReportState { Description = "с замечаниями куратора" },
                    new ReportState { Description = "импортирован" }
                    );
                context.SaveChanges();
            }

            if (!context.ReportTypes.Any())
            {
                context.ReportTypes.AddRange(
                    new ReportType { Description = "ВЛ"},
                    new ReportType { Description = "ТП/РП" },
                    new ReportType { Description = "УСПД" }
                    );
                context.SaveChanges();
            }
            

          //  context.SaveChanges();
        }
    }
}
