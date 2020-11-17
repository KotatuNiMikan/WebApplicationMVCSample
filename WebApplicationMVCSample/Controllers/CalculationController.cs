using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationMVCSample.Models.Calculation;

namespace WebApplicationMVCSample.Controllers
{
    /// <summary>
    /// 四則演算コントローラーです。
    /// </summary>
    public class CalculationController : Controller
    {
        /// <summary>
        /// 四則演算画面の初期化処理です。
        /// </summary>
        /// <returns>アクションリザルトです。</returns>
        public ActionResult Index()
        {
            return this.View(new IndexModel());
        }

        /// <summary>
        /// 四則演算の計算ボタン押下処理です。
        /// </summary>
        /// <param name="model">ビューモデルです。</param>
        /// <returns>アクションリザルトです。</returns>
        public ActionResult Calculate(IndexModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View("Index", model); 
            }

            return this.View(null, null, model.GetResult());
        }
    }
}