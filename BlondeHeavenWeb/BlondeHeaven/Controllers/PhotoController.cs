using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace BlondeHeaven.Controllers
{
    public class PhotoController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;


        public PhotoController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        //--------------------------------------------------------------------------------//

        public IActionResult UploadFiles()
        {
            long size = 0;//文件大小
            var files = Request.Form.Files;//获取前端传过来的文件
            foreach (var file in files)
            {
                var fileName = file.FileName.Trim('"');//获取文件名
                fileName = _hostingEnvironment.WebRootPath + $@"\{fileName}";//指定文件上传的路径
                size += file.Length;
                using (FileStream fs = System.IO.File.Create(fileName))//创建文件流
                {
                    file.CopyTo(fs);//将上载文件的内容复制到目标流
                    fs.Flush();//清除此流的缓冲区并导致将任何缓冲数据写入
                }
            }
            return Json(new { message = $"{files.Count}个文件 /{size}字节上传成功!" });
        }


        //--------------------------------------------------------------------------------//













    }
}
