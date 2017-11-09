using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DataBase.Models
{
    public class CompanyDBInit:DropCreateDatabaseAlways<CompanyContext>
    {
        protected override void Seed(CompanyContext db)
        {
            db.Companies.Add(new Company {name = "РЖД", email = "@try.ru",phone = "551177",site = "domain.ru", industry = "Перевозки"});
            db.Companies.Add(new Company { name = "Мегафон", email = "@try.com", phone = "771456", site = "domain.com", industry = "Связь"});
            db.Companies.Add(new Company { name = "Билайн", email = "@try.com", phone = "771456", site = "domain2.com", industry = "Связь"});
            base.Seed(db);
        }
    }
}