using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAppTechAnJS.Controllers.WebAPI
{
    public class JsonDataController : ApiController
    {
        // GET api/<controller>
        public List<DailyData> Get()
        {
            List<DailyData> lst = new List<DailyData>();
            var item = new DailyData()
            {
                Date = "9-Jun-14",
                Open = "62.40",
                High = "63.34",
                Low = "61.79",
                Close = "62.88",
                Volume = "37617413"
            };

            var item1 = new DailyData()
            {
                Date = "6-Jun-14",
                Open = "63.37",
                High = "63.48",
                Low = "62.15",
                Close = "62.50",
                Volume = "42442096"
            };

            lst.Add(item);
            lst.Add(item1);

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