using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Hosting;
using System.Web.Http;

namespace WebAppTechAnJS.Controllers.WebAPI
{
    public class JsonDataController : ApiController
    {
        // GET api/<controller>
        public List<DailyData> Get()
        {
            List<DailyData> lst = new List<DailyData>();
            string path = Path.Combine(HostingEnvironment.ApplicationPhysicalPath, "data.csv");
            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    var splits = reader.ReadLine().Split(',');
                    if (splits[0] == "Date")
                        continue;

                    var item = new DailyData()
                    {
                        Date = splits[0],
                        Open = splits[1],
                        High = splits[2],
                        Low = splits[3],
                        Close = splits[4],
                        Volume = splits[5]
                    };
                    lst.Add(item);
                }
            }

            return lst;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }

    public class DailyData
    {
        public string Date { get; set; }
        public string Open { get; set; }
        public string High { get; set; }
        public string Low { get; set; }
        public string Close { get; set; }
        public string Volume { get; set; }
    }
}