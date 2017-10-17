using EFBLL.DTO.HR;
using ExerciseLibrary.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExerciseLibrary.Controllers
{
    [Export]
    public class MyBaseController : Controller
    {
        /// <summary>
        /// 当前登录的用户属性
        /// </summary>
        public StaffInfoDTO CurrentStraffInfo { get { return Session[CommonStr.SessionUserKey] as StaffInfoDTO; } }
        //当前用户权限信息
        public ArrRoleFunc RoleFunc { get { return Session[CommonStr.SessionRoleFuncKey] as ArrRoleFunc; } }
        protected override void OnException(ExceptionContext filterContext)
        {
            base.OnException(filterContext);

            //错误记录
            //WHC.Framework.Commons.LogTextHelper.Error(filterContext.Exception);

            // 当自定义显示错误 mode = On，显示友好错误页面
            if (filterContext.HttpContext.IsCustomErrorEnabled)
            {
                filterContext.ExceptionHandled = true;
                this.View("Error").ExecuteResult(this.ControllerContext);
            }
        }
    }
}