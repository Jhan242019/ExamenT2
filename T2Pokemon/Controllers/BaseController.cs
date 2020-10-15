using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using T2Pokemon.Models;

namespace T2Pokemon.Controllers
{
    public abstract class BaseController : Controller
    {
        private readonly PokemonContext context;
        public BaseController(PokemonContext context)
        {
            this.context = context;
        }

        protected User LoggedUser()
        {
            var claim = HttpContext.User.Claims.FirstOrDefault();
            var user = context.Users.Where(o => o.Username == claim.Value).FirstOrDefault();
            return user;
        }
    }
}
