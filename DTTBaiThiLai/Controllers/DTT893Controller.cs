using DTTBaiThiLai.Models;
using Microsoft.AspNetCore.Mvc;

namespace DTTBaiThiLai.Controllers
{
    public class DTT893Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(DTT893 ps)
        {
            string strOutput ="Hello" + ps.HoTen + ps.ID + ps.Ngaysinh;
            ViewBag.ifPer=strOutput;
            return View();
        }

    }
    
}