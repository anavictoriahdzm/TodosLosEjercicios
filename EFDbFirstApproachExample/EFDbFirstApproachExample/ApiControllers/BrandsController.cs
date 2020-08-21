using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EFDbFirstApproachExample.Models;

namespace EFDbFirstApproachExample.ApiControllers
{
    public class BrandsController : ApiController
    {
        public List<Brand> Get()
        {
            EFDBFirstDatabaseEntities db = new EFDBFirstDatabaseEntities();
            List<Brand> brands = db.Brands.ToList();
            return brands;
        }
    }
}
