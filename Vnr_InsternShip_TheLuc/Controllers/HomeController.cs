using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Vnr_InsternShip_TheLuc.Models;

namespace Vnr_InsternShip_TheLuc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Vnr_InsternShip_TheLucContext _context;
        public HomeController(ILogger<HomeController> logger, Vnr_InsternShip_TheLucContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            List<MonHoc> monhoc = _context.MonHoc.Include(i => i.KhoaHoc).OrderBy(o=>o.KhoaHocID).ToList();
            List<KhoaHoc> khoahoc = _context.KhoaHoc.ToList();



            Home home = new Home();
            home.listKhoaHoc = khoahoc;
            home.listMonHoc = monhoc;

            return View(home);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
