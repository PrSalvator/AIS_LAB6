using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_LAB6.Controllers
{
    public class DBController
    {
        public void Insert(Models.TPUSchool school)
        {
            using (DataBase.DataBaseContext db = new DataBase.DataBaseContext())
            {
                db.TPUSchools.Add(school);
                db.SaveChanges();
            }
        }
        public List<Models.TPUSchool> SelectAll()
        {
            List<Models.TPUSchool> schools;
            using (DataBase.DataBaseContext db = new DataBase.DataBaseContext())
            {
                schools = db.TPUSchools.ToList();
            }
            return schools;
        }

    }
}
