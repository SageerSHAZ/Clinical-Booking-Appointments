using System.Collections.Generic;
using System.Linq;
using ClinicalBookingAppointments.WebAPI.Data;
using ClinicalBookingAppointments.WebAPI.Modals;
using Microsoft.AspNetCore.Mvc;

namespace ClinicalBookingAppointments.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Doctors")]
    public class DoctorsController : Controller
    {
        private DataContext context;
        

        public DoctorsController(DataContext ctx)
        {
            context = ctx;
        }

       
        [HttpGet]
        public IEnumerable<Doctor> Get()
        {
            return context.Doctors.ToList();
        }


        // GET api/doctors/5
        [HttpGet("{id}")]
        public Doctor Get(int id)
        {
            return context.Doctors.FirstOrDefault(e => e.DoctorID == id);
        }

        // POST api/Trips
        [HttpPost]
        public IActionResult Post([FromBody]Doctor value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);

            }
            context.Doctors.Add(value);
            context.SaveChanges();

            return Ok();
        }


        // PUT api/Doctors/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Doctor value)
        {
           
            var entity = context.Doctors.FirstOrDefault(d => d.DoctorID == id);

            entity.FirstName = value.FirstName;
            entity.LastName =  value.LastName;
            entity.Specialty = value.Specialty;

            context.SaveChanges();

            return Ok();
        }

        // DELETE api/Doctors/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var myDoctor = context.Doctors.Find(id);

            if (myDoctor == null)
            {
                return NotFound();
            }

            context.Doctors.Remove(myDoctor);
            context.SaveChanges();

            return NoContent();
        }
    }
 }
