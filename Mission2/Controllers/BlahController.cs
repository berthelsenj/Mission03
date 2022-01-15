using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mission2.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mission2.Controllers
{
    public class BlahController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("GradeCalcModel")]
        public IActionResult GradeCalc ()
        {
            return View();
        }

        [HttpPost("GradeCalcModel")]
        public IActionResult GradeCalc (GradeCalcModel model)
        {
            return View();
        }
    }
}
