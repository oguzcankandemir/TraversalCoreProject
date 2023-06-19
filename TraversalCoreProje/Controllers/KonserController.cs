using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class KonserController : Controller
    {
        KonserManager konserManager = new KonserManager(new EfKonserDal());
        public IActionResult Index()
        {
            var values = konserManager.TGetList();
            return View(values);
        }
    }
}
