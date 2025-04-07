using HMS_API.Dtos;

namespace HMS_API.HelperFunctions
{
    public static class AppointmentExtensions
    {
        public static string GetSummary(this AppointmentDto appointment)
        {
            return $"-> Appointment ID: {appointment.EventId}\n" +
                   $"-> Patient: {appointment.PatientFullname}\n" +
                   $"-> Doctor: {appointment.DoctorFullname}\n" +
                   $"-> Date: {appointment.AppointmentDate:yyyy-MM-dd HH:mm}\n" +
                   $"-> Receptionist: {appointment.ReceptionistFullname}\n" +
                   $"-> Issue Field: {appointment.doctorSpecialization}\n" +
                   $"-> Status: {appointment.Status}";
        }
    }


    public static class UtilitiesAndExtensions
    {
        public sealed class RecordFormatter
        {
            public static string Format(MedicalRecordsDto record)
            {
                return $"-> Record ID: {record.RecordId}\n" +
                       $"-> Patient ID: {record.PatientId}\n" +
                       $"-> Patient Name: {record.PatientName}\n" +
                       $"-> Type: {record.RecordType}\n" +
                       $"-> Created On: {record.RecordCreatedOn:yyyy-MM-dd}\n" +
                       $"-> Data: {record.RecordData}";
            }
        }

        public sealed class PrescriptionFormatter
        {
            public static string Format(PrescriptionDto prescription)
            {
                return $"-> Prescription ID: {prescription.PrescriptionId}\n" +
                       $"-> Doctor ID: {prescription.DoctorId}\n" +
                       $"-> Doctor Name: {prescription.DoctorName}\n" +
                       $"-> Patient ID: {prescription.PatientId}\n" +
                       $"-> Patient Name: {prescription.PatientName}\n" +
                       $"-> Medicine Details: {prescription.MedicineDetails}\n" +
                       $"-> Notes: {prescription.Notes}\n" +
                       $"-> Prescribed On: {prescription.PrescribedOn:yyyy-MM-dd}";
            }
        }


        public static class FilterHelper
        {
            public static List<T> Filter<T>(List<T> items, Func<T, bool> predicate)
            {

                return items.Where(predicate).ToList();

            }
        }





    }
}
