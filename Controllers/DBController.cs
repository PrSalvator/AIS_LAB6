using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace AIS_LAB6.Controllers
{
    public class DBController
    {
        public void InsertSchool(Models.TPUSchool school)
        {
            using (DataBase.DataBaseContext db = new DataBase.DataBaseContext())
            {
                db.TPUSchools.Add(school);
                db.SaveChanges();
            }
        }
        public List<Models.TPUDirectionOfTraining> directionsOfSchool(Guid schoolId)
        {
            List<Models.TPUDirectionOfTraining> directions;
            using (DataBase.DataBaseContext db = new DataBase.DataBaseContext())
            {
                directions = db.TPUSchools.Where(s => s.Id == schoolId)
                    .Include(s => s.DirectionsOfTraining)
                    .First().DirectionsOfTraining.ToList();
            }
            return directions;
        }
        public List<Models.TPUDirectionOfTraining> SelectAllDirections()
        {
            List<Models.TPUDirectionOfTraining> directions;
            using (DataBase.DataBaseContext db = new DataBase.DataBaseContext())
            {
                directions = db.TPUDirectionsOfTraining.ToList();
            }
            return directions;
        }
        public List<Models.TPUSchool> SelectAllSchools()
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
