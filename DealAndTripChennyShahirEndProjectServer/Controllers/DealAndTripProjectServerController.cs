using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DealAndTripChennyShahirEndProjectServerBL.Models;
using System.IO;
namespace DealAndTripChennyShahirEndProjectServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DealAndTripProjectServerController : ControllerBase
    {
        #region Add connection to the db context using dependency injection
        DealAndTripDBContext context;
        public DealAndTripProjectServerController(DealAndTripDBContext context)
        {
            this.context = context;
        }
        #endregion
    }
}
