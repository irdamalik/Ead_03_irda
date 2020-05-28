using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Linq.Mapping;
using tvseriesproject1.Models;

namespace tvseriesproject1.Controllers
{
    public class HomeController : Controller
    {
        DataClasses1DataContext tv = new DataClasses1DataContext();
        DataClasses2DataContext mov = new DataClasses2DataContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult showtvseries()
        {
            List<tvseries> lists = tv.tvseries.ToList<tvseries>();
            List<tvseries> list = new List<tvseries>();
            if (lists != null)
            {
                foreach (var serch in lists)
                {
                    list.Add(serch);
                }
            }
            if (list!=null)
                return View(list);
            else
                return View();
        }
        public ActionResult showmovies()
        {
            List<movie> listss = mov.movies.ToList<movie>();
            List<movie> listt = new List<movie>();
            if (listss != null)
            {
                foreach (var m in listss)
                {
                    listt.Add(m);
                }
            }
            if (listt != null)
                return View(listt);
            else
                return View();
        }
        public ActionResult addtvseries()
        {
            return View();
        }
        public ActionResult add()
        {
            String name = Request.Form["name"];
            String genre = Request.Form["genre"];
            String director = Request.Form["director"];
            String writer = Request.Form["writer"];
            String available_on = Request.Form["available_on"];
            tvseries tvser = new tvseries();
            tvser.name = name;
            tvser.genre = genre;
            tvser.director = director;
            tvser.writer = writer;
            tvser.available_on = available_on;
            tv.tvseries.InsertOnSubmit(tvser);
            tv.SubmitChanges();
            return RedirectToAction("showtvseries");
        }
        public ActionResult addmovies()
        {
            return View();
        }

        public ActionResult addmov()
        {
            String namee = Request.Form["namee"];
            String genree = Request.Form["genree"];
            String directorr = Request.Form["directorr"];
            String producerr = Request.Form["producerr"];
            String available_onn = Request.Form["available_onn"];
            movie movi = new movie();
            movi.namee = namee;
            movi.genree = genree;
            movi.directorr = directorr;
            movi.producerr = producerr;
            movi.available_onn = available_onn;
            mov.movies.InsertOnSubmit(movi);
            mov.SubmitChanges();
            return RedirectToAction("showmovies");
        }

      
        public ActionResult doupdation()
        {
            List<tvseries> rec = tv.tvseries.ToList<tvseries>();
            List<tvseries> catalogue = new List<tvseries>();
            String id = Request["Id"];
            int identification = Convert.ToInt32(id);
            foreach (var tvss in rec)
            {
                if (tvss.Id == identification)
                {
                    var varforupd = tvss;
                    catalogue.Add(varforupd);
                }
            }
            return View(catalogue);
        }

        public ActionResult finalupdate()
        {
            String tvname = Request["tvname"];
            String tvgenre = Request["tvgenre"];
            String tvdirector = Request["tvdirector"];
            String tvwriter = Request["tvwriter"];
            String tvavailable_on = Request["tvavailable_on"];
            String iden = Request["Id"];
            int Id = Convert.ToInt32(iden);
            tvseries tvser = tv.tvseries.First(num => num.Id.Equals(Id));
            tvser.Id = Id;
            tvser.name = tvname;
            tvser.genre = tvgenre;
            tvser.director = tvdirector;
            tvser.writer = tvwriter;
            tvser.available_on = tvavailable_on;
            tv.SubmitChanges();
            return RedirectToAction("showtvseries");
        }

        public ActionResult updatemovies()
        {
            List<movie> recs = mov.movies.ToList<movie>();
            List<movie> cate = new List<movie>();
            String id = Request["Id"];
            int ident = Convert.ToInt32(id);
            foreach (var moov in recs)
            {
                if (moov.Id == ident)
                {
                    var varfup = moov;
                    cate.Add(varfup);
                }
            }
            return View(cate);
        }

        
        public ActionResult lastmovupdate()
        {
            String movname = Request["movname"];
            String movgenre = Request["movgenre"];
            String movdirector = Request["movdirector"];
            String movproducer = Request["movproducer"];
            String movavailable_on = Request["movavailable_on"];
            String ident = Request["Id"];
            int Idd = Convert.ToInt32(ident);
            movie doccum = mov.movies.First(numm => numm.Id.Equals(Idd));
            doccum.Id = Idd;
            doccum.namee = movname;
            doccum.genree = movgenre;
            doccum.directorr = movdirector;
            doccum.producerr = movproducer;
            doccum.available_onn = movavailable_on;
            mov.SubmitChanges();
            return RedirectToAction("showmovies");
        }

        public ActionResult About()
        {
            ViewBag.Message = "This website is about the All time famous tv-series information!";
            return View();
        }      
        public ActionResult Contact()
        {
            ViewBag.Message = "Contact page is not complete yet.";
            return View();
        }


    }
}