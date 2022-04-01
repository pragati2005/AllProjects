using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Helpers
{
    public class FileHelper : IFileHelper
    {
        public IWebHostEnvironment _env;
        public String fulfilename;
        public String filepath { get; set; }
        public FileHelper(IWebHostEnvironment env)
        {
            _env = env;
        }
        public  void DeleteFile(string imageUrl)
        {
            if (File.Exists(_env.WebRootPath + imageUrl))
            {
                File.Delete(_env.WebRootPath + imageUrl);
            }
        }

        public string GenerateFileName(string filename)
        {
           fulfilename = DateTime.Now.ToUniversalTime().ToString("yyyyMMdd\\THHmmssfff") + filename  ;

            return fulfilename;
        }

        public  string Uploadfile(IFormFile file)
        {
            var uploads= Path.Combine(_env.WebRootPath, "images");
            bool exists = Directory.Exists(uploads);
            if (!exists)

                Directory.CreateDirectory(uploads);
            var filename = GenerateFileName(file.FileName);
            var filestream = new FileStream(Path.Combine(uploads, filename), FileMode.Create);
            file.CopyToAsync(filestream);
            return "/images/" + filename;
        }
    }
}
