using DoAn_NuocHoa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAn_NuocHoa.Controllers
{
    public class NuocHoaController : Controller
    {
        // GET: NuocHoa
        
        public ActionResult Index()
        {
            return View(SanPham.GetAll());
        }

        public ActionResult Create()
        {
            return View(new SanPham());
        }
        [HttpPost]
        public ActionResult Create(SanPham newSP)
        {
            if (ModelState.IsValid)
            {
                newSP.Insert(); 
                return View("Index", SanPham.GetAll());
            }
            else
            {
                return View("Create", newSP);
            }
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
                return HttpNotFound();
            SanPham find = SanPham.FindById(id.Value);
            if (find == null)
                return HttpNotFound();
            return View(find);
        }


    }
}