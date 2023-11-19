using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_LAB6
{
    class Program
    {
        static void Main(string[] args)
        {
            Controllers.DBController dBController = new Controllers.DBController();

            Controllers.HTMLController htmlController = new Controllers.HTMLController();

            List<Models.TPUSchool> tpuSchools;

            try
            {
                tpuSchools = htmlController.GetTPUSchools();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Для завершения нажмитие на любую кнопку");
                Console.ReadKey();
                return;
            }

            foreach (Models.TPUSchool school in tpuSchools)
            {
                Console.WriteLine(school.Name);
                Console.WriteLine(school.Address);
                Console.WriteLine(school.Tel);
                Console.WriteLine();

                dBController.Insert(school);
            }

            Console.WriteLine("Для завершения нажмитие на любую кнопку");
            Console.ReadKey();
        }
    }
}
