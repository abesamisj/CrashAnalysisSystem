namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TcrDriver")]
    public partial class TcrDriver
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TcrDriver()
        {
            TcrDriverSupplementarySafetyDeviceUseds = new HashSet<TcrDriverSupplementarySafetyDeviceUsed>();
        }

        public int tcrDriverid { get; set; }

        public int tcrPersonid { get; set; }

        public int tcrVehicleid { get; set; }

        [StringLength(2500)]
        public string comments { get; set; }

        public bool isUnknown { get; set; }

        [StringLength(250)]
        public string occupation { get; set; }

        public int? overseasDriverStatusTypeid { get; set; }

        [StringLength(15)]
        public string phoneNumber { get; set; }

        public short? policeVehicleIdentifier { get; set; }

        public int restraintUsedTypeid { get; set; }

        public short? policePersonNumber { get; set; }

        [StringLength(250)]
        public string countryOfIssue { get; set; }

        public int licenseConditionsMetYesNoUnknownTypeid { get; set; }

        [StringLength(8)]
        public string licenseNo { get; set; }

        public int driverLicenseStatusTypeid { get; set; }

        public int driverLicenseTypeTypeid { get; set; }

        public int drugsInvolvedTypeid { get; set; }

        public int drugScreeningTestTypeid { get; set; }

        public int drugScreeningTestResultTypeid { get; set; }

        [StringLength(50)]
        public string drugsTypeDescription { get; set; }

        public int? drugTypeTypeid { get; set; }

        [StringLength(250)]
        public string cameFrom { get; set; }

        public TimeSpan? dayStartTime { get; set; }

        public short? hoursOfDriving { get; set; }

        public short? hoursOfSleep { get; set; }

        public short? hoursSince10HourRest { get; set; }

        public short? hoursWorkedLast10Hours { get; set; }

        public short? hoursWorkedLast24Hours { get; set; }

        [StringLength(250)]
        public string lastRestLocation { get; set; }

        public TimeSpan? lastRestTime { get; set; }

        public int alcoholInvolvedTypeid { get; set; }

        public int breathScreeningTestTypeid { get; set; }

        public int? breathTestReading { get; set; }

        public int evidentialBreathTestTypeid { get; set; }

        public int evidentialBloodTestTypeid { get; set; }

        public int? evidentialBloodReading { get; set; }

        public virtual AlcoholInvolvedType AlcoholInvolvedType { get; set; }

        public virtual BreathScreeningTestType BreathScreeningTestType { get; set; }

        public virtual DriverLicenseStatusType DriverLicenseStatusType { get; set; }

        public virtual DriverLicenseTypeType DriverLicenseTypeType { get; set; }

        public virtual DrugScreeningTestResultType DrugScreeningTestResultType { get; set; }

        public virtual DrugScreeningTestType DrugScreeningTestType { get; set; }

        public virtual DrugsInvolvedType DrugsInvolvedType { get; set; }

        public virtual DrugTypeType DrugTypeType { get; set; }

        public virtual EvidentialBloodTestType EvidentialBloodTestType { get; set; }

        public virtual EvidentialBreathTestType EvidentialBreathTestType { get; set; }

        public virtual OverseasDriverStatusType OverseasDriverStatusType { get; set; }

        public virtual RestraintUsedType RestraintUsedType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrDriverSupplementarySafetyDeviceUsed> TcrDriverSupplementarySafetyDeviceUseds { get; set; }

        public virtual TcrPerson TcrPerson { get; set; }

        public virtual TcrVehicle TcrVehicle { get; set; }

        public virtual YesNoUnknownType YesNoUnknownType { get; set; }
    }
}
