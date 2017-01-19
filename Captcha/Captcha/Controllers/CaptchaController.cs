using SRVTextToImage;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Drawing.Imaging;
using Captcha.Models;

namespace Captcha.Controllers
{
    public class CaptchaController : Controller
    {
        
        public ActionResult CaptchaForm()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CaptchaForm(FeedbackModel FM, string CaptchaText)
        {

            if(this.Session["CaptchaImageText"].ToString() == CaptchaText)
            {
                ViewBag.Message = "Captcha validation Is Sucessful !";
            }
            else
            {
                ViewBag.Message = "Captcha validation Is not Sucessful !";
            }
            return View( FM);
        }

        // GET: Captcha
        [HttpGet]
        [OutputCache(NoStore = true, Duration = 0, VaryByParam = "None")]
        public FileResult  GetCaptchaImage()
        {

            CaptchaRandomImage CI = new CaptchaRandomImage();
            this.Session["CaptchaImageText"] = CI.GetRandomString(5);
            CI.GenerateImage(this.Session["CaptchaImageText"].ToString(), 300, 75);
            CI.GenerateImage(this.Session["CaptchaImageText"].ToString(),300 , 75,  Color.DarkGray, Color.White);
            MemoryStream stream = new MemoryStream();
            CI.Image.Save(stream, ImageFormat.Png);
            stream.Seek(0, SeekOrigin.Begin);
            return new FileStreamResult(stream, "image/png");                 
        }
    }
}