using examlast.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace examlast.ViewComponents
{
    [ViewComponent]
    public class xx:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context mydb=new Context();
            Pmodel p = new Pmodel();
            var headerlist = mydb.pmodels.OrderByDescending(p => p.Id).Take(5).ToList();
            return View(headerlist);
        }
    }
}
