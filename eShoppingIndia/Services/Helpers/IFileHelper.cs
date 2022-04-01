using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Helpers
{
 public  interface IFileHelper
    {

        public String GenerateFileName(string filename);
        public void DeleteFile(string imageUrl);
        public string Uploadfile(IFormFile file);
    }
}
