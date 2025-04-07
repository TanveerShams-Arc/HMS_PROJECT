namespace HMS_UI.HelperFunctions
{
    public static class DataFormatters
    {
        public static void FormatTransactionView(ref DataGridView transactionData)
        {
            transactionData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            transactionData.Columns["TransactionId"]!.HeaderText = "Transaction ID";
            transactionData.Columns["PatientName"]!.HeaderText = "Patient Name";
            transactionData.Columns["TransactionDate"]!.HeaderText = "Date";
            transactionData.Columns["Amount"]!.HeaderText = "Total Amount";
            transactionData.Columns["PaidAmount"]!.HeaderText = "Paid Amount";
            transactionData.Columns["Status"]!.HeaderText = "Status";


            transactionData.Columns["TransactionDate"]!.DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";


            transactionData.Columns["TransactionId"]!.Visible = false;
            transactionData.Columns["PatientId"]!.Visible = false;

            addDelete(ref transactionData);

        }

        private static void addDelete(ref DataGridView Data)
        {
            if (Data.Columns["Delete"] == null)
            {
                var deleteImageColumn = new DataGridViewImageColumn
                {
                    Name = "Delete",
                    HeaderText = "Actions",
                    Image = Image.FromFile(@"..\..\..\Resources\RedCross.png"),
                    ImageLayout = DataGridViewImageCellLayout.Zoom
                };

                Data.Columns.Add(deleteImageColumn);
                Data.Columns["Delete"]!.Width = 60;
            }
        }



        public static void FormatRecordView(ref DataGridView recordData)
        {
            recordData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            recordData.Columns["recordId"]!.HeaderText = "Record ID";
            recordData.Columns["patientId"]!.HeaderText = "Patient Id";
            recordData.Columns["patientName"]!.HeaderText = "Patient Name";
            recordData.Columns["recordType"]!.HeaderText = "Record Type";
            recordData.Columns["recordData"]!.HeaderText = "Record Data";
            recordData.Columns["recordCreatedOn"]!.HeaderText = "Record Created On";

            recordData.Columns["recordCreatedOn"]!.DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";

            recordData.Columns["recordId"]!.Visible = false;


            if (recordData.Columns["Details"] == null)
            {
                var DetailsColumn = new DataGridViewButtonColumn()
                {
                    Name = "DetailsButton",
                    HeaderText = "Get Detailed Data",
                    Text = "View Details",
                    UseColumnTextForButtonValue = true
                };

                recordData.Columns.Add(DetailsColumn);
                recordData.Columns["DetailsButton"]!.Width = 100;
            }


            addDelete(ref recordData);
        }

        public static void FormatDoctorView(ref DataGridView doctorData, Form currentForm)
        {
            doctorData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            doctorData.Columns["doctorId"]!.HeaderText = "ID";
            doctorData.Columns["fullName"]!.HeaderText = " Name";
            doctorData.Columns["doctorSpecialization"]!.HeaderText = "Specialization";
            doctorData.Columns["doctorExperience"]!.HeaderText = "Experience";
            doctorData.Columns["email"]!.HeaderText = "Email";
            doctorData.Columns["phoneNumber"]!.HeaderText = "Phone";

            doctorData.Columns["fullName"]!.DisplayIndex = 0;
            doctorData.Columns["doctorSpecialization"]!.DisplayIndex = 1;
            doctorData.Columns["doctorExperience"]!.DisplayIndex = 2;
            doctorData.Columns["email"]!.DisplayIndex = 3;
            doctorData.Columns["phoneNumber"]!.DisplayIndex = 4;
            doctorData.Columns["doctorId"]!.DisplayIndex = 5;


            doctorData.Columns["doctorId"]!.Visible = false;
            doctorData.BackgroundColor = Color.White;
            doctorData.DefaultCellStyle.BackColor = Color.White;
            doctorData.BorderStyle = BorderStyle.Fixed3D;
            doctorData.GridColor = Color.Black;

            if (currentForm is Doctors)
            {
                addDelete(ref doctorData);
            }
        }

        public static void FormatPatientView(ref DataGridView patientData)
        {
            patientData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            patientData.Columns["patientId"]!.HeaderText = "ID";
            patientData.Columns["fullName"]!.HeaderText = "Name";
            patientData.Columns["patientDOB"]!.HeaderText = " DOB";
            patientData.Columns["patientBloodGroup"]!.HeaderText = "Blood Group";
            patientData.Columns["patientAddress"]!.HeaderText = "Address";
            patientData.Columns["email"]!.HeaderText = "Email";
            patientData.Columns["phoneNumber"]!.HeaderText = "Phone";


            patientData.Columns["patientId"]!.Visible = false;
            patientData.Columns["patientDOB"]!.Visible = false;
            patientData.Columns["patientBloodGroup"]!.Visible = false;
            patientData.Columns["patientAddress"]!.Visible = false;

            patientData.BackgroundColor = Color.White;
            patientData.DefaultCellStyle.BackColor = Color.White;
            patientData.BorderStyle = BorderStyle.Fixed3D;
            patientData.GridColor = Color.Black;

        }

        public static void FormatAppointmenView(ref DataGridView appointmentData)
        {
            appointmentData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            appointmentData.Columns["EventId"]!.HeaderText = "Event ID";
            appointmentData.Columns["PatientFullname"]!.HeaderText = "Patient Name";
            appointmentData.Columns["AppointmentDate"]!.HeaderText = "Date";
            appointmentData.Columns["Status"]!.HeaderText = "Status";
            appointmentData.Columns["DoctorFullname"]!.HeaderText = "Doctor";
            appointmentData.Columns["ReceptionistFullname"]!.HeaderText = "Receptionist";
            appointmentData.Columns["DoctorSpecialization"]!.HeaderText = "Specialization";

            // Format Date Column
            appointmentData.Columns["AppointmentDate"]!.DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";

            //appointmentData.Columns["EventId"]!.Visible = false;

            addDelete(ref appointmentData);

        }

        public static void FormatInventoryView(ref DataGridView inventoryData)
        {
            inventoryData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            inventoryData.Columns["itemId"]!.HeaderText = "Item ID";
            inventoryData.Columns["medicine"]!.HeaderText = "Medicine Name";
            inventoryData.Columns["medicineQuantity"]!.HeaderText = "Quantity";
            inventoryData.Columns["manufacturer"]!.HeaderText = "Manufacturer";
            inventoryData.Columns["expiryDate"]!.HeaderText = "Expiray Date";
            inventoryData.Columns["lastUpdatedOn"]!.HeaderText = "Last Data Updated On";

            inventoryData.Columns["lastUpdatedOn"]!.DefaultCellStyle.Format = "yyyy-MM-dd";


            inventoryData.Columns["itemId"]!.Visible = false;

            addDelete(ref inventoryData);
        }
    }
}


