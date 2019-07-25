using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Description;
using MatrixApp.Models;

namespace MatrixApp.Controllers
{
    [Authorize]
    
    public class ShopController : ApiController
    {

        private ApplicationDbContext db = new ApplicationDbContext();

            protected override void Dispose(bool disposing)
            {
                if (disposing)
                {
                    this.db.Dispose();
                }

                base.Dispose(disposing);
            }

        [HttpGet]
        [Route("api/GetAllproducts")]
        public IHttpActionResult GetAllProducts()
        {
            var products = db.Products.Select(c => c.Name);

            return Ok(products);

        }

        [HttpGet]
        [Route("api/GetProduct/{id}")]
        public IHttpActionResult GetProduct(int id)
        {
            var product = db.Products.Where(c => c.Id == id).ToList();
            if (product==null)
            {
                return NotFound();
            }
            else
            {
                return Ok(product);
            }
        }


        [HttpPost]
        [Route("api/InsertnewProduct/{newproduct}")]
        public IHttpActionResult InsertnewProduct(Product newproduct)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Products.Add(newproduct);
            db.SaveChanges();




            return Ok(newproduct);
        }


        [HttpPut]
        [Route("api/UpdateProductDetails/{updatedproduct}")]
        public IHttpActionResult UpdateProductDetails(Product updatedproduct)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }



            //EmployeeDetail objEmp = new EmployeeDetail();
            Product productToUpdtae = db.Products.SingleOrDefault(c=>c.Id==updatedproduct.Id);
                if (productToUpdtae != null)
            {
                productToUpdtae.Name = updatedproduct.Name;
                productToUpdtae.NoInStock = updatedproduct.NoInStock;
                productToUpdtae.Price = updatedproduct.Price;
                productToUpdtae.SubCategoryLv2 = updatedproduct.SubCategoryLv2;
                productToUpdtae.Supplier = updatedproduct.Supplier;


            }

            db.SaveChanges();



            return Ok(productToUpdtae); 
        }


        [HttpDelete]
        [Route("api/Deleteproduct/{id}")]
        public IHttpActionResult Deleteproduct(int id)
        {

            Product producttodelete = db.Products.SingleOrDefault(c => c.Id == id);
            if (producttodelete == null)
            {
                return NotFound();
            }

            db.Products.Remove(producttodelete);
            db.SaveChanges();

            return Ok();
        }
    }
}
