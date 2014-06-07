using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using testWebApi2.Models;

namespace testWebApi2.Controllers
{
    public class MedicinesController : ApiController
    {
        private IEnumerable<Medicine> medicines = new List<Medicine>
        {
            new Medicine
            {
                Id = 1,
                Name = "Viagra"
            },
            new Medicine
            {
                Id = 2,
                Name = "Ibuprom"
            }
        };

        public IEnumerable<Medicine> GetMedicines()
        {
            return medicines.ToList();
        }
    }
}
