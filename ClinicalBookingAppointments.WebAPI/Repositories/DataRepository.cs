using System.Collections.Generic;
using System.Linq;
using ClinicalBookingAppointments.WebAPI.Data;
using ClinicalBookingAppointments.WebAPI.Modals;

namespace ClinicalBookingAppointments.WebAPI.Repositories
{
    public class DataRepository 
    {
        //private List<Doctor> data = new List<Doctor>();

        private DataContext _dataContext;

        public DataRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IEnumerable<Doctor> Doctors => _dataContext.Doctors.ToArray();

        public Doctor GetDoctor(int key) => _dataContext.Doctors.Find(key);

        public void AddDoctor(Doctor doctor)
        {
            this._dataContext.Doctors.Add(doctor);
            this._dataContext.SaveChanges();
        }

        public void DeleteDoctor(int id)
        {
            var myDoctor = _dataContext.Doctors.Find(id);

            _dataContext.Doctors.Remove(myDoctor);
            _dataContext.SaveChanges();
        }

        // PUT api/Doctors/5
        
        public void UpdateDoctor(Doctor doctor)
        {
            _dataContext.Doctors.Update(doctor);
            _dataContext.SaveChanges();
        }
        
        //public Doctor PutDoctor(int id, [FromBody]Doctor value)
        //{

        //    var entity = _dataContext.Doctors.Find(id);

        //    entity.FirstName = value.FirstName;
        //    entity.LastName = value.LastName;
        //    entity.Specialty = value.Specialty;

        //    _dataContext.Doctors.Update(value);

        //    return value;
           
        //}
    }
}

