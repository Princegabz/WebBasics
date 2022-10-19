using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;
using WebBasics.Models;

namespace WebBasics.Controllers
{
    public class StaffController : Controller
    {
        LectureContext db = new LectureContext(); 
        public IActionResult Index()
        {
            List<LectureDetails> list = LectureContext.staff;
            return View(list);
        }
        public IActionResult Edit(int id)
        {
            List<LectureDetails> list = LectureContext.staff;
            LectureDetails ld = list.Where(e=> e.ID1 == id).SingleOrDefault();   
            return View(ld);
        }
        public IActionResult Details(int id)
        {
            List<LectureDetails> list = LectureContext.staff;
            LectureDetails ld = list.Where(e => e.ID1 == id).SingleOrDefault();
            return View(ld);
        }
    }
}
