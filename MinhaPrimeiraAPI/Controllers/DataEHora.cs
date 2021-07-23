using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaPrimeiraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataEHora : ControllerBase
    {
        public string dataEHoraLocalString;
        public int dataEHoraLocalInteiro;

        [HttpGet]
        [Route("get1")]

        public IEnumerable<DateTime> Get()
        {
            TimeZoneInfo localZone = TimeZoneInfo.Local;
            switch (localZone.DisplayName)
            {
                case "UTC":
                    {
                        break;
                    }
                case "UTC+1":
                    {
                        dataEHoraLocalInteiro = Convert.ToInt32(DateTime.Now) - 1;
                        dataEHoraLocalString += Convert.ToString(dataEHoraLocalInteiro);
                        break;
                    }
                case "UTC+2":
                    {
                        dataEHoraLocalInteiro = Convert.ToInt32(DateTime.Now) - 2;
                        dataEHoraLocalString += Convert.ToString(dataEHoraLocalInteiro);
                        break;
                    }
                case "UTC+3":
                    {
                        dataEHoraLocalInteiro = Convert.ToInt32(DateTime.Now) - 3;
                        dataEHoraLocalString += Convert.ToString(dataEHoraLocalInteiro);
                        break;
                    }
                case "UTC+4":
                    {
                        dataEHoraLocalInteiro = Convert.ToInt32(DateTime.Now) - 4;
                        dataEHoraLocalString += Convert.ToString(dataEHoraLocalInteiro);
                        break;
                    }
                case "UTC+5":
                    {
                        dataEHoraLocalInteiro = Convert.ToInt32(DateTime.Now) - 5;
                        dataEHoraLocalString += Convert.ToString(dataEHoraLocalInteiro);
                        break;
                    }
                case "UTC+6":
                    {
                        dataEHoraLocalInteiro = Convert.ToInt32(DateTime.Now) - 6;
                        dataEHoraLocalString += Convert.ToString(dataEHoraLocalInteiro);
                        break;
                    }
                case "UTC+7":
                    {
                        dataEHoraLocalInteiro = Convert.ToInt32(DateTime.Now) - 7;
                        dataEHoraLocalString += Convert.ToString(dataEHoraLocalInteiro);
                        break;
                    }
                case "UTC+8":
                    {
                        dataEHoraLocalInteiro = Convert.ToInt32(DateTime.Now) - 8;
                        dataEHoraLocalString += Convert.ToString(dataEHoraLocalInteiro);
                        break;
                    }
                case "UTC+9":
                    {
                        dataEHoraLocalInteiro = Convert.ToInt32(DateTime.Now) - 9;
                        dataEHoraLocalString += Convert.ToString(dataEHoraLocalInteiro);
                        break;
                    }
                case "UTC+10":
                    {
                        dataEHoraLocalInteiro = Convert.ToInt32(DateTime.Now) - 10;
                        dataEHoraLocalString += Convert.ToString(dataEHoraLocalInteiro);
                        break;
                    }
                case "UTC+11":
                    {
                        dataEHoraLocalInteiro = Convert.ToInt32(DateTime.Now) - 11;
                        dataEHoraLocalString += Convert.ToString(dataEHoraLocalInteiro);
                        break;
                    }
                case "UTC+12":
                    {
                        dataEHoraLocalInteiro = Convert.ToInt32(DateTime.Now) - 12;
                        dataEHoraLocalString += Convert.ToString(dataEHoraLocalInteiro);
                        break;
                    }
            }

            yield return DateTime.Now;
        }
    }
}
