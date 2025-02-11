using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using TaskDemo.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace TaskDemo.Controllers {

    [Route("api/[controller]")]
    public class SampleDataController : Controller {

        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions) {
            return DataSourceLoader.Load(SampleData.Orders, loadOptions);
        }

        [HttpGet("product")]
        public object GetProduct(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(SampleData.Products, loadOptions);
        }

    }
}