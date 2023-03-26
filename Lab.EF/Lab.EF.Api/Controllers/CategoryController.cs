using Lab.EF.Api.Models;
using Lab.EF.Entities;
using Lab.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Lab.EF.Api.Controllers
{
    public class CategoryController : ApiController
    {
        readonly CategoriesLogic _CategoriesLogic = new CategoriesLogic();

        // GET: Shipper
        public IHttpActionResult Get()
        {
            try
            {
                var ret = _CategoriesLogic.GetAll().Select(c => new CategoryDto
                {
                    CategoryID = c.CategoryID,
                    CategoryName = c.CategoryName,
                    Description = c.Description,
                    ProductsCount = c.Products.Count
                });
                return Ok(ret);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET api/values/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                var aux = _CategoriesLogic.Find(id);
                var ret = new CategoryDto
                {
                    CategoryID = aux.CategoryID,
                    CategoryName = aux.CategoryName,
                    Description= aux.Description,
                    ProductsCount = aux.Products.Count
                };
                return Ok(ret);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // POST api/values
        public IHttpActionResult Post([FromBody] CategoryDto c)
        {
            try
            {
                var aux = new Category
                {
                    CategoryName = c.CategoryName,
                    Description = c.Description
                };
                _CategoriesLogic.Add(aux);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // PUT api/values/5
        public IHttpActionResult Put(int id, [FromBody] CategoryDto c)
        {
            try
            {
                var aux = new Category
                {
                    CategoryID = id,
                    CategoryName = c.CategoryName,
                    Description = c.Description
                };
                _CategoriesLogic.Update(aux);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // DELETE api/values/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                _CategoriesLogic.Remove(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}