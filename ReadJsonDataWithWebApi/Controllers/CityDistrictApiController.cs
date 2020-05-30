using Microsoft.Ajax.Utilities;
using ReadJsonDataWithWebApi.Models;
using System.Collections.Generic;
using System.IO;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace ReadJsonDataWithWebApi.Controllers
{
    public class CityDistrictApiController : ApiController
    {
        List<CityDistrict> personlist = new List<CityDistrict>();

        public void CityDistrict()
        {
            //deserialize JSON from file  
            string Json = File.ReadAllText(@"C:\Users\murat\source\repos\ReadJsonDataWithWebApi\ReadJsonDataWithWebApi\App_Data/il-ilce.json");
            JavaScriptSerializer ser = new JavaScriptSerializer();
            personlist = ser.Deserialize<List<CityDistrict>>(Json);
        }

        public IEnumerable<CityDistrict> GetCityDistricts()
        {
            CityDistrict();
            return personlist;
        }
    }
}
