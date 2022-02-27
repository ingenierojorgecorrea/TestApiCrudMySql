using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiCrud_JorgeCorrea.Models;

namespace WebApiCrud_JorgeCorrea.Controllers
{
    public class EmployeesController : ApiController
    {
        private testjcEntities db = new testjcEntities();

        // GET: api/employees
        public IQueryable<employee> Getemployee()
        {
            return db.employee;
        }

        // GET: api/employees/5
        [ResponseType(typeof(employee))]
        public IHttpActionResult Getemployee(long id)
        {
            employee employee = db.employee.Find(id);
            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        // PUT: api/employees/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putemployee(long id, employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != employee.Id)
            {
                return BadRequest();
            }

            db.Entry(employee).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!employeeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/employees
        [ResponseType(typeof(employee))]
        public IHttpActionResult Postemployee(employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.employee.Add(employee);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = employee.Id }, employee);
        }

        // DELETE: api/employees/5
        [ResponseType(typeof(employee))]
        public IHttpActionResult Deleteemployee(long id)
        {
            employee employee = db.employee.Find(id);
            if (employee == null)
            {
                return NotFound();
            }

            db.employee.Remove(employee);
            db.SaveChanges();

            return Ok(employee);
        }

        private bool employeeExists(long id)
        {
            return db.employee.Count(e => e.Id == id) > 0;
        }
    }
}