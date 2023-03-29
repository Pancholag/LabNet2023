using Lab.EF.Api.Models;
using Lab.EF.Entities;
using Lab.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace Lab.EF.Api.Controllers
{
    [EnableCors("*","*","*")]
    public class ShipperController : ApiController
    {
        readonly ShippersLogic _shippersLogic = new ShippersLogic();

        // GET: Shipper
        public IHttpActionResult Get()
        {
            try
            {
                var ret = _shippersLogic.GetAll().Select(s => new ShipperDto
                {
                    ShipperID = s.ShipperID,
                    CompanyName = s.CompanyName,
                    Phone = s.Phone,
                    OrdersCount = s.Orders.Count
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
                var aux = _shippersLogic.Find(id);
                var ret = new ShipperDto
                {
                    ShipperID = aux.ShipperID,
                    CompanyName = aux.CompanyName,
                    Phone = aux.Phone,
                    OrdersCount = aux.Orders.Count
                };
                return Ok(ret);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // POST api/values
        public IHttpActionResult Post([FromBody] ShipperDto s)
        {
            try
            {
                var aux = new Shipper
                {
                    CompanyName = s.CompanyName,
                    Phone = s.Phone
                };
                _shippersLogic.Add(aux);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // PUT api/values/5
        public IHttpActionResult Put(int id, [FromBody] ShipperDto s)
        {
            try
            {
                var aux = new Shipper
                {
                    ShipperID = id,
                    CompanyName = s.CompanyName,
                    Phone = s.Phone
                };
                _shippersLogic.Update(aux);
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
                _shippersLogic.Remove(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        
    }
}