using ClinicalBookingAppointments.WebAPI.Data;
using ClinicalBookingAppointments.WebAPI.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalBookingAppointments.WebAPI.Repositories
{
    public class Repository
    {
        private DataContext dataContext;

        public Repository(DataContext _dataContext)
        {
            dataContext = _dataContext;
        }
        

        public List<Doctor> Get(int id)
        {
            return MyDoctors.Find(id);
        }

        public void Add(Doctor newTrip)
        {

            myDoctors.Add(newTrip);

        }

        public void Update(Doctor doctorToUpdate)
        {

            myDoctors.Remove(myDoctors.First(t => t.Id == doctorToUpdate.DoctorID));
            Add(doctorToUpdate);

        }

        public void Remove(int id)
        {
            myDoctors.Remove(myDoctors.First(t => t.Id == id));
        }
    }
}
