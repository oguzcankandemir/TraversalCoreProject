using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _KonserPartial: ViewComponent
    {
        KonserManager konserManager = new KonserManager(new EfKonserDal());
        public IViewComponentResult Invoke()
        {
            var values = konserManager.TGetList();
            return View(values);
        }
    }
}
