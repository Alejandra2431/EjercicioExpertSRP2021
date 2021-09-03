using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        private Patient patient;
        private DateTime date;
        private string appoinmentPlace;
        public string AppointmentPlace
        {
            set
            {
                if(!string.IsNullOrEmpty(appoinmentPlace)) this.appoinmentPlace = value;
                else Console.WriteLine("Error con el lugar.");
            }
        }
        private string doctorName;
        public string DoctorName
        {
            set
            {
                if(!string.IsNullOrEmpty(doctorName)) this.doctorName = value;
                else Console.WriteLine("Error con el lugar.");
            }
        }
        public AppointmentService(Patient paciente, DateTime date, string appoinmentPlace, string doctorName)
        {
            this.patient = paciente;
            this.date = date;
            this.appoinmentPlace = appoinmentPlace;
            this.doctorName = doctorName;
        }

    }
}
