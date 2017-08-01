using BetPortal.Entities;
using BetPortal.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BetPortal.Controllers
{
    public class RaceController : ApiController
    {
        [HttpGet]
        [Route("api/race/{id}")]
        public Race GetRaceInformation(int id)
        {
            return BetRespository.Races.FirstOrDefault(x => x.Id == id);
        }
    }

}
