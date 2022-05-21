using FarmerSchemeProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmerSchemeProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimInsuranceController : ControllerBase
    {
        private readonly FarmerSchemeProjectContext db;

        public ClaimInsuranceController(FarmerSchemeProjectContext context)
        {
            db = context;
        }

        [HttpGet]

        public IActionResult Get()
        { 
       var claiminsurance = db.ClaimInsurances.ToList();

            if (claiminsurance != null)
            {
                return Ok(claiminsurance);
            }
            else
            {
                return NotFound("data not found");
             }
    }
        #region Post
        [HttpPost]

        public IActionResult AddClaimInsurance([FromBody] ClaimInsurance claimInsurance)
        {
            try
            {
                if (claimInsurance == null)
                {
                    return BadRequest("Sellcrop is null");
                }

                else
                {
                    db.ClaimInsurances.Add(claimInsurance);
                    db.SaveChanges();
                    return Ok("Record Added!!");
                }
            }
            catch (Exception e)
            {
                return Ok("Some Error Occured!!!");
            }


        }
        #endregion
        
    }
}

