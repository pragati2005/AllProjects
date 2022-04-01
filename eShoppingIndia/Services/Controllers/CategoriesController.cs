using Entities;
using Entities.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Abstraction;
using Repository.Implementation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Services.Helpers;
namespace Services.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        public IUnitOfWork _unitofwork;
        public IFileHelper _filehelper;

       
        public CategoriesController(IUnitOfWork unitOfWork,IFileHelper fileHelper)
        {
            _unitofwork =  unitOfWork;
            _filehelper = fileHelper;
            
        }
        // GET: api/<ProductController>
        [HttpGet]
        //[Authorize(Roles = "Admin")]
        //[BasicAuth]
        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await _unitofwork.CategoryRepository.GetAll();
        }

        // To Upload a file :
       
        [HttpPost]
        
        public IActionResult AddFile(IFormFile file)
        { 
        //    var file = item;
            IFormFile Itemfile = file;

            if (file.Length > 0)
            {
               var message= _filehelper.Uploadfile(file);
                return Ok(message);
            }
            return NotFound("File not found");
            //await _unitofwork.CategoryRepository.Add(Item);
           
           
            
        }

       
        [HttpPost]

        public async Task<IActionResult> AddCategory([FromForm]CategoryViewModel item)
        {
            //    var file = item;
            IFormFile Itemfile = item.File;
            
            if (item.File.Length > 0)
            {
                var message = _filehelper.Uploadfile(Itemfile);


                Category categoryitem = new Category()
                {
                    NAME = item.NAME,
                    CHILDID = int.Parse(item.CHILDID),
                    IMAGEURL = message
                };
               var result= await _unitofwork.CategoryRepository.Add(categoryitem);
                if (result>0)
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound("Object not saved");
                }
                
            }
            else
            {
                return NotFound("File not found");
            }

            //if (file.Length > 0)
            //{
            //    var message = _filehelper.Uploadfile(file);
            //    return Ok(message);
            //}
            //return NotFound("File not found");
            //await _unitofwork.CategoryRepository.Add(Item);


        }
    }
}
