using BetPortal.Services;
using BetPortal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BetPortal.Controllers
{
    public class CustomerController : ApiController
    {
        private BetPortalService betService;
        private BetRespository betRepository;

        public CustomerController()
        {
            this.betRepository = new BetRespository();
            this.betService = new BetPortalService(betRepository);
        }

        [HttpGet]
        [Route("api/customer/{id}")]
        public CustomerViewModel GetCustomerWithBetsById(int id)
        {
            CustomerViewModel vm = betService.GetCustomerBets().FirstOrDefault(x => x.CustomerId == id);
            return vm;            
        }

        [HttpGet]
        [Route("api/customer")]
        public List<CustomerViewModel> GetCustomersWithBets()
        {
            List<CustomerViewModel> vm = new List<CustomerViewModel>();
            vm = betService.GetCustomerBets();
            return vm;
        }

    }
}
