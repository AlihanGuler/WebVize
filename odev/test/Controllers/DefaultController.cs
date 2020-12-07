using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Takım()
        {
            return View(Models.Class1.NBAtakımları);
        }
        public ActionResult Edit(int Id)
        {
            var nba = Models.Class1.NBAtakımları.Where(b => b.Id == Id).FirstOrDefault();
            return View(nba);
        }
        [HttpPost]

        public ActionResult Edit(Models.Class1 nbaa)
        {
            var nba = Models.Class1.NBAtakımları.Where(b => b.Id == nbaa.Id).FirstOrDefault();
            nba.Id = nbaa.Id;
            nba.TakımAdı = nbaa.TakımAdı;
            nba.Fiyat = nbaa.Fiyat;
            return RedirectToAction("Takım");
        }
        public ActionResult Delete(int Id)

        {

            var takımtakım = Models.Class1.NBAtakımları.Where(b => b.Id == Id).FirstOrDefault();

            return View(takımtakım);

        }
        [HttpPost]
        public ActionResult Delete(Models.Class1 tkm)

        {

            var szz = Models.Class1.NBAtakımları.Where(b => b.Id == tkm.Id).FirstOrDefault();
            Models.Class1.NBAtakımları.Remove(szz);
            return RedirectToAction("Takım");

        }



    }
}