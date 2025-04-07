using System.ComponentModel;

namespace HMS_UI.Enums
{
    public enum apStatus
    {
        All,
        Scheduled,
        Cancelled,
        Completed,
        Tested,
        Futuristic
    }


    public enum TransactionStatus
    {
        Complete,
        Pending,
        Partial
    }

    public enum Role
    {
        Doctor,
        Patient,
        Receptionist
    }

    public enum Manufacturer
    {
        [Description("Square Pharmaceuticals Ltd.")]
        SquarePharmaceuticals,

        [Description("Beximco Pharmaceuticals Ltd.")]
        BeximcoPharmaceuticals,

        [Description("Incepta Pharmaceuticals Ltd.")]
        InceptaPharmaceuticals,

        [Description("Renata Limited")]
        Renata,

        [Description("Eskayef Pharmaceuticals Ltd. (SK+F)")]
        EskayefPharmaceuticals,

        [Description("ACME Laboratories Ltd.")]
        ACME_Laboratories,

        [Description("Aristopharma Ltd.")]
        Aristopharma,

        [Description("Opsonin Pharma Ltd.")]
        OpsoninPharma,

        [Description("ACI Limited (Advanced Chemical Industries)")]
        ACI_Limited,

        [Description("Drug International Ltd.")]
        DrugInternational,

        [Description("Healthcare Pharmaceuticals Ltd.")]
        HealthcarePharmaceuticals,

        [Description("Radiant Pharmaceuticals Ltd.")]
        RadiantPharmaceuticals,

        [Description("Beacon Pharmaceuticals Ltd.")]
        BeaconPharmaceuticals,

        [Description("Ziska Pharmaceuticals Ltd.")]
        ZiskaPharmaceuticals,

        [Description("Navana Pharmaceuticals Ltd.")]
        NavanaPharmaceuticals
    }


    public enum BloodGroup
    {
        [Description("A+")] A_Positive,
        [Description("A-")] A_Negative,
        [Description("B+")] B_Positive,
        [Description("B-")] B_Negative,
        [Description("AB+")] AB_Positive,
        [Description("AB-")] AB_Negative,
        [Description("O+")] O_Positive,
        [Description("O-")] O_Negative
    }

    public enum DoctorSpecialization
    {
        General_Practitioner,
        Cardiologist,
        Dermatologist,
        Neurologist,
        Orthopedic_Surgeon,
        Pediatrician,
        Psychiatrist,
        Radiologist,
        Dentist,
        Gynecologist,
        Oncologist,
        Medicine
    }

    public enum MedicalRecordType
    {
        GeneralCheckup,
        LabTest,
        MedicalHistory
    }

    public enum TestName
    {
        CompleteBloodCount,
        HemoglobinA1C,
        BloodChemistry,
        PlateletCount,
        WhiteBloodCellCount,
        RedBloodCellCount,
        CoagulationProfile
    }

}
