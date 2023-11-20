using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_LAB6.Controllers
{
    public class HTMLController
    {
        private const string html = @"https://tpu.ru/university/schools/";

        public List<Models.TPUSchool> GetTPUSchools()
        {
            List<Models.TPUSchool> TPUSchools = new List<Models.TPUSchool>();
            HtmlWeb htmlWeb = new HtmlWeb();
            HtmlDocument htmlDoc = new HtmlDocument();
            try
            {
                htmlDoc = htmlWeb.Load(html);
            }
            catch
            {
                throw;
            }

            HtmlNodeCollection article = htmlDoc.DocumentNode.SelectNodes("//article[@class='school']");

            foreach (HtmlNode school in article)
            {
                string name = school.SelectNodes("./header/h2").First().InnerText;
                name = name.Replace("\n", "").Replace("\r", " ");
                string tel = school.SelectNodes(".//div[@class='school-contact__item']/a").First().InnerText;
                tel = tel.Replace(" ", "");
                string address = school.SelectNodes(".//div[@class='school-contact__item']/address").First().InnerText;
                address = address.Trim();
                Models.TPUSchool tpuSchool = new Models.TPUSchool
                {
                    Address = address,
                    Tel = tel,
                    Name = name
                };
                TPUSchools.Add(tpuSchool);
            }
            return TPUSchools;
        }
    }
}
