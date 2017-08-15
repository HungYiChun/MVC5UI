using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MVC5UI.Controllers
{
    public class EncryptionController : Controller
    {
        // GET: HashMD5
        public ActionResult HashMD5()
        {
            return View();
        }
        // POST: HashMD5
        [HttpPost]
        public ActionResult HashMD5(string txtString)
        {
            string result = "";
            if (txtString != null)
            {
                MD5 md5 = MD5.Create();
                result = Convert.ToBase64String(md5.ComputeHash(Encoding.Default.GetBytes(txtString)));
                ViewData["Result"] = "HashMD5: " + result;
            }

            return View();
        }

        // GET: HashSHA1
        public ActionResult HashSHA1()
        {
            return View();
        }
        // POST: HashSHA1
        [HttpPost]
        public ActionResult HashSHA1(string txtString)
        {
            string result = "";
            if (txtString != null)
            {
                SHA1 sha1 = new SHA1CryptoServiceProvider();
                result = Convert.ToBase64String(sha1.ComputeHash(Encoding.Default.GetBytes(txtString)));
                ViewData["Result"] = "HashSHA1: " + result;
            }

            return View();
        }

        // GET: HashSHA256
        public ActionResult HashSHA256()
        {
            return View();
        }
        // POST: HashSHA256
        [HttpPost]
        public ActionResult HashSHA256(string txtString)
        {
            string result = "";
            if (txtString != null)
            {
                SHA256 sha256 = new SHA256CryptoServiceProvider();
                result = Convert.ToBase64String(sha256.ComputeHash(Encoding.Default.GetBytes(txtString)));
                ViewData["Result"] = "HashSHA256: " + result;
            }

            return View();
        }

        // GET: HashSHA384
        public ActionResult HashSHA384()
        {
            return View();
        }
        // POST: HashSHA384
        [HttpPost]
        public ActionResult HashSHA384(string txtString)
        {
            string result = "";
            if (txtString != null)
            {
                SHA384 sha384 = new SHA384CryptoServiceProvider();
                result = Convert.ToBase64String(sha384.ComputeHash(Encoding.Default.GetBytes(txtString)));
                ViewData["Result"] = "HashSHA384: " + result;
            }

            return View();
        }

        // GET: HashSHA512
        public ActionResult HashSHA512()
        {
            return View();
        }
        // POST: HashSHA512
        [HttpPost]
        public ActionResult HashSHA512(string txtString)
        {
            string result = "";
            if (txtString != null)
            {
                SHA512 sha512 = new SHA512CryptoServiceProvider();
                result = Convert.ToBase64String(sha512.ComputeHash(Encoding.Default.GetBytes(txtString)));
                ViewData["Result"] = "HashSHA512: " + result;
            }

            return View();
        }
    }
}