namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CodedCrashPerson")]
    public partial class CodedCrashPerson
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CodedCrashPerson()
        {
            CodedCrashContributingFactors = new HashSet<CodedCrashContributingFactor>();
            CodedCrashDrivers = new HashSet<CodedCrashDriver>();
            CodedCrashPassengers = new HashSet<CodedCrashPassenger>();
            CodedCrashPersonHitBies = new HashSet<CodedCrashPersonHitBy>();
            CodedCrashRoles = new HashSet<CodedCrashRole>();
        }

        public int codedCrashPersonid { get; set; }

        [StringLength(255)]
        public string city { get; set; }

        [StringLength(255)]
        public string country { get; set; }

        [StringLength(250)]
        public string forename { get; set; }

        public int genderTypeid { get; set; }

        public short? policePersonNumber { get; set; }

        public int roadUserTypeTypeid { get; set; }

        [StringLength(250)]
        public string streetAddress { get; set; }

        [StringLength(255)]
        public string suburb { get; set; }

        [StringLength(250)]
        public string surname { get; set; }

        public int? ageOnDateOfCrash { get; set; }

        public DateTime? dateOfBirth { get; set; }

        public bool isDobUnknown { get; set; }

        [StringLength(100)]
        public string ethnicityDescription { get; set; }

        public int ethnicityTypeid { get; set; }

        [StringLength(250)]
        public string injuryDescription { get; set; }

        public int injurySeverityTypeid { get; set; }

        public int hospitalisedYesNoUnknownTypeid { get; set; }

        [StringLength(250)]
        public string hospitalName { get; set; }

        public bool isPedestrian { get; set; }

        public int injuryCauseTypeid { get; set; }

        public int fatalityPreventableIfSafetyEquipmentUsedYesNoUnknownTypeid { get; set; }

        public int codedCrashid { get; set; }

        public bool? isImpactedInCrash { get; set; }

        public bool? isExternallyCreated { get; set; }

        public bool? isDeleted { get; set; }

        public virtual CodedCrash CodedCrash { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashContributingFactor> CodedCrashContributingFactors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashDriver> CodedCrashDrivers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashPassenger> CodedCrashPassengers { get; set; }

        public virtual EthnicityType EthnicityType { get; set; }

        public virtual GenderType GenderType { get; set; }

        public virtual InjuryCauseType InjuryCauseType { get; set; }

        public virtual InjurySeverityType InjurySeverityType { get; set; }

        public virtual RoadUserTypeType RoadUserTypeType { get; set; }

        public virtual YesNoUnknownType YesNoUnknownType { get; set; }

        public virtual YesNoUnknownType YesNoUnknownType1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashPersonHitBy> CodedCrashPersonHitBies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashRole> CodedCrashRoles { get; set; }
    }
}
