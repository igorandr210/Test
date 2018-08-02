using System;
using System.Collections.Generic;
using System.Linq;
using Nethereum.Web3;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TXC.Controllers
{
    [Produces("application/json")]
    [Route("api/API")]
    public class APIController : Controller
    {
        [HttpPost]
        public string createPayment(int orderId,ulong value)
        {
            return "s";
        }
    }
}