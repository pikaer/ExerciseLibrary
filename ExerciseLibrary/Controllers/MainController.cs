using EFBLL.DTO.Sys;
using EFUltilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExerciseLibrary.Controllers
{
    public class MainController : MyBaseController
    {
        // GET: Main
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string GetMenuJson(int id)
        {
            List<OAFuncDTO> menus = RoleFunc.Children(id);
            string str = menus.ToJsonIgnoreLoop(false);
            return str;
        }
        [HttpPost]
        public string GetFirstMenuJson()
        {
            List<OAFuncDTO> menus = RoleFunc.FirstChildren();
            string str = menus.ToJsonIgnoreLoop(false);
            return str;
        }

        [HttpPost]
        public string GetTopMenuJson()
        {
            var menus = RoleFunc.Modules();
            string str = menus.ToJsonIgnoreLoop(false);
            return str;
        }
    }
}