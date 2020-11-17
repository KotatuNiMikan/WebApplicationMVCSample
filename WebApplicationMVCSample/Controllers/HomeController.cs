using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationMVCSample.Controllers
{
    /// <summary>
    /// ホームコントローラーです。
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// ホーム画面初期化処理です。
        /// </summary>
        /// <returns>アクションリザルトです。</returns>
        public ActionResult Index()
        {
            return this.View();
        }

        /// <summary>
        /// 詳細リンク押下処理です。
        /// </summary>
        /// <returns>アクションリザルトです。</returns>
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return this.View();
        }

        /// <summary>
        /// 問い合わせリンク押下処理です。
        /// </summary>
        /// <returns>アクションリザルトです。</returns>
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return this.View();
        }
    }
}