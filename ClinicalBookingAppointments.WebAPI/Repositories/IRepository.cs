using ClinicalBookingAppointments.WebAPI.Modals;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClinicalBookingAppointments.WebAPI.Repositories
{
    public interface IRepository {

        IEnumerable<Doctor> Doctors { get; }
        Doctor GetDoctor(int key);
        void AddDoctor(Doctor doctor);
        void UpdateDoctor(Doctor doctor);
        

    }
}
