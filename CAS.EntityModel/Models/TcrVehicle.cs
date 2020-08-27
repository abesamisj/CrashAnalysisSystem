namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TcrVehicle")]
    public partial class TcrVehicle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TcrVehicle()
        {
            TcrDrivers = new HashSet<TcrDriver>();
            TcrPassengers = new HashSet<TcrPassenger>();
            TcrTowedVehicles = new HashSet<TcrTowedVehicle>();
            TcrVehicleDevices = new HashSet<TcrVehicleDevice>();
            TcrVehiclePermits = new HashSet<TcrVehiclePermit>();
        }

        public int tcrVehicleid { get; set; }

        public int tcrCrashIdentifierid { get; set; }

        public DateTime timestamp { get; set; }

        public short? ccRating { get; set; }

        [StringLength(20)]
        public string make { get; set; }

        [StringLength(20)]
        public string model { get; set; }

        public short? motorCycleWheelCount { get; set; }

        public short? totalPassengersFront { get; set; }

        public short? totalPassengersRear { get; set; }

        public short? totalPassengersOther { get; set; }

        [StringLength(255)]
        public string transportServicesLicense { get; set; }

        public short? yearOfManufacture { get; set; }

        public DateTime? wofCofExpiryDate { get; set; }

        public int hasWofCofYesNoUnknownTypeid { get; set; }

        public int hasNoRegistrationPlatesYesNoUnknownTypeid { get; set; }

        public bool isRegistrationPlateUnknown { get; set; }

        [StringLength(6)]
        public string registrationNumber { get; set; }

        public int crashRiskReducedByAdditionalReflectorYesNoUnknownTypeid { get; set; }

        public int directionTypeid { get; set; }

        public short? policeVehicleIdentifier { get; set; }

        [StringLength(250)]
        public string roadTravelledOn { get; set; }

        [StringLength(100)]
        public string otherVehicleTypeDescription { get; set; }

        public int vehicleTypeTypeid { get; set; }

        [StringLength(100)]
        public string workVehicleOrganisation { get; set; }

        public int damageSeverityTypeid { get; set; }

        public int hasUnderunProtectionYesNoUnknownTypeid { get; set; }

        public int wasNoUnderRunProtectionContributorYesNoUnknownTypeid { get; set; }

        public int isLoadSecuredYesNoUnknownTypeid { get; set; }

        [StringLength(100)]
        public string loadDescription { get; set; }

        public double? loadHeight { get; set; }

        public int vehicleLoadTypeid { get; set; }

        public int damageAreaTypeid { get; set; }

        public short? speedPriorInKph { get; set; }

        public int vehicleStateTypeid { get; set; }

        public int wasTooFastForConditionsYesNoUnknownTypeid { get; set; }

        public int? reasonForSpeedTooFastTypeid { get; set; }

        public int vehicleUsageTypeid { get; set; }

        [StringLength(50)]
        public string vehicleUsageTypeOtherDescription { get; set; }

        [StringLength(50)]
        public string primaryColour { get; set; }

        public int isOverDimensionYesNoUnknownTypeid { get; set; }

        public int towedVehicleTypeTypeid { get; set; }

        public virtual DamageAreaType DamageAreaType { get; set; }

        public virtual DamageSeverityType DamageSeverityType { get; set; }

        public virtual DirectionType DirectionType { get; set; }

        public virtual ReasonForSpeedTooFastType ReasonForSpeedTooFastType { get; set; }

        public virtual TcrCrash TcrCrash { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrDriver> TcrDrivers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrPassenger> TcrPassengers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrTowedVehicle> TcrTowedVehicles { get; set; }

        public virtual TowedVehicleTypeType TowedVehicleTypeType { get; set; }

        public virtual VehicleLoadType VehicleLoadType { get; set; }

        public virtual VehicleStateType VehicleStateType { get; set; }

        public virtual VehicleTypeType VehicleTypeType { get; set; }

        public virtual VehicleUsageType VehicleUsageType { get; set; }

        public virtual YesNoUnknownType YesNoUnknownType { get; set; }

        public virtual YesNoUnknownType YesNoUnknownType1 { get; set; }

        public virtual YesNoUnknownType YesNoUnknownType2 { get; set; }

        public virtual YesNoUnknownType YesNoUnknownType3 { get; set; }

        public virtual YesNoUnknownType YesNoUnknownType4 { get; set; }

        public virtual YesNoUnknownType YesNoUnknownType5 { get; set; }

        public virtual YesNoUnknownType YesNoUnknownType6 { get; set; }

        public virtual YesNoUnknownType YesNoUnknownType7 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrVehicleDevice> TcrVehicleDevices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrVehiclePermit> TcrVehiclePermits { get; set; }
    }
}
