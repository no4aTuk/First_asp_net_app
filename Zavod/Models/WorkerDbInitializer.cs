using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Zavod.Models
{
    public class WorkerDbInitializer : DropCreateDatabaseAlways<WorkerContext>
    {
        protected override void Seed(WorkerContext db)
        {
            db.Workers.Add(new Worker { Name = "Иван", Last = "Петров", Place = "Цех-4" });
            db.Workers.Add(new Worker { Name = "Денис", Last = "Сидоров", Place = "КБ-1" });
            db.Workers.Add(new Worker { Name = "Алексей", Last = "Шевченко", Place = "Цех-1" });
            db.Workers.Add(new Worker { Name = "Геннадий", Last = "Овечкин", Place = "Цех-1" });
            db.Workers.Add(new Worker { Name = "Василий", Last = "Теркин", Place = "Цех-2" });
            db.Workers.Add(new Worker { Name = "Надежда", Last = "Бабкина", Place = "КБ-2" });
            db.Workers.Add(new Worker { Name = "Ирина", Last = "Магомедова", Place = "ЛИК" });
            db.Workers.Add(new Worker { Name = "Иван", Last = "Таранов", Place = "Цех-4" });
            db.Workers.Add(new Worker { Name = "Петр", Last = "Иванов", Place = "ЛИК" });
            db.Workers.Add(new Worker { Name = "Дмитрий", Last = "Медведев", Place = "Цех-6" });


            base.Seed(db);
        }
    }
}