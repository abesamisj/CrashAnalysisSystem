namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TcrPerson")]
    public partial class TcrPerson
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TcrPerson()
        {
            TcrDrivers = new HashSet<TcrDriver>();
            TcrPassengers = new HashSet<TcrPassenger>();
        }

        public int tcrPersonid { get; set; }

        public int tcrCrashIdentifierid { get; set; }

        public DateTime timestamp { get; set; }

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

        public virtual EthnicityType EthnicityType { get; set; }

        public virtual GenderType GenderType { get; set; }

        public virtual InjurySeverityType InjurySeverityType { get; set; }

        public virtual RoadUserTypeType RoadUserTypeType { get; set; }

        public virtual TcrCrash TcrCrash { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrDriver> TcrDrivers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrPassenger> TcrPassengers { get; set; }

        public virtual YesNoUnknownType YesNoUnknownType { get; set; }
    }
}
