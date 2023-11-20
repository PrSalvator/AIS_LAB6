using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_LAB6.Controllers
{
    public class ViewConroller
    {
        private DBController dBController = new DBController();
        public void PrintDirectionsOfSchool()
        {
            Console.WriteLine();
            Console.WriteLine("Выберите номер школы");
            
            Guid schoolId = new Guid();

            List<Models.TPUSchool> schools = dBController.SelectAllSchools();

            int index = 0;
            foreach(Models.TPUSchool school in schools)
            {
                Console.WriteLine();
                Console.WriteLine(index + " " + school.Name);
                Console.WriteLine();

                index++;
            }

            Console.WriteLine();
            string choose = Console.ReadLine();
            Console.WriteLine();

            try
            {
                index = int.Parse(choose);
                try
                {
                    schoolId = schools[index].Id;
                    List<Models.TPUDirectionOfTraining> directions = dBController.directionsOfSchool(schoolId);
                    foreach (Models.TPUDirectionOfTraining direction in directions)
                    {
                        Console.WriteLine();
                        Console.WriteLine(direction.Id + " " + direction.Name);
                        Console.WriteLine();
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
                Console.WriteLine();
            }
            
        }
        public void PrintDirections()
        {
            foreach (Models.TPUDirectionOfTraining direction in dBController.SelectAllDirections())
            {
                Console.WriteLine();
                Console.WriteLine(direction.Id + " " + direction.Name);
                Console.WriteLine();
            }
        }
        public void PrintSchools()
        {
            foreach (Models.TPUSchool school in dBController.SelectAllSchools())
            {
                Console.WriteLine();
                Console.WriteLine(school.Name);
                Console.WriteLine(school.Address);
                Console.WriteLine(school.Tel);
                Console.WriteLine();
            }
        }

    }
}
