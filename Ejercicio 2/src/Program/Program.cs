using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient paciente1 = new Patient("Steven Jhonson", "986782342", "5555-555-555");
            AppointmentService cita1 = new AppointmentService(paciente1, DateTime.Now, "Wall Street", "Armand");

            Patient paciente2 = new Patient("Ralf Manson", "", "5555-555-555");
            AppointmentService cita2 = new AppointmentService(paciente2, DateTime.Now, "Queen Street", "");
        }
    }
}
