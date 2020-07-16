using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlondeHeaven.Controllers
{
    public class PhotoController : Controller
    {

        private IHostingEnvironment _hostingEnv;

        public PhotoController(IHostingEnvironment env)
        {
            _hostingEnv = env;
        }
        public IActionResult Index()
        {
            return View();

        }

        [HttpGet]
        public IActionResult UploadFiles()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UploadFiles(IList<IFormFile> files)
        {
            long size = 0;
            foreach (var file in files)
            {
                var filename = ContentDispositionHeaderValue
                                .Parse(file.ContentDisposition)
                               .FileName
                               .Trim('"');
                filename = _hostingEnv.WebRootPath + $@"\{filename}";
                size += file.Length;
                using (FileStream fs = System.IO.File.Create(filename))
                {
                    file.CopyTo(fs);
                    fs.Flush();
                }
            }
            return View();
        }




       




















    }
}

