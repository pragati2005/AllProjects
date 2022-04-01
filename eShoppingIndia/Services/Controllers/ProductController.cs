using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repository.Abstraction;
using Repository.Implementation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Services.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public IUnitOfWork _unitofwork;
        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitofwork = unitOfWork;
        }
        // GET: api/<ProductController>
        [HttpGet]
        [Authorize(Roles="Admin")]
        [BasicAuth]
        public async Task<IEnumerable> GetProducts()
        {
            return  await _unitofwork.ProductRepository.GetAll();
        }
        [AllowAnonymous]
        public async Task<Product> GetProducts(int id)
        {
            return await _unitofwork.ProductRepository.GetById(id);
        }

    }
}
