namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CodedCrashVehicle")]
    public partial class CodedCrashVehicle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CodedCrashVehicle()
        {
            CodedCrashContributingFactors = new HashSet<CodedCrashContributingFactor>();
            CodedCrashDrivers = new HashSet<CodedCrashDriver>();
            CodedCrashPassengers = new HashSet<CodedCrashPassenger>();
            CodedCrashPersonHitBies = new HashSet<CodedCrashPersonHitBy>();
            CodedCrashRoles = new HashSet<CodedCrashRole>();
            CodedCrashTowedVehicles = new HashSet<CodedCrashTowedVehicle>();
            CodedCrashVehicleDevices = new HashSet<CodedCrashVehicleDevice>();
            CodedCrashVehicleObjectsStrucks = new HashSet<CodedCrashVehicleObjectsStruck>();
            CodedCrashVehiclePermits = new HashSet<CodedCrashVehiclePermit>();
        }

        public int codedCrashVehicleid { get; set; }

        public int codedCrashid { get; set; }

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

        [StringLength(100)]
        public string vehicleUsageTypeOtherDescription { get; set; }

        [StringLength(50)]
        public string primaryColour { get; set; }

        public int hasModificationsYesNoUnknownTypeid { get; set; }

        public int isVehicleFaultyYesNoUnknownTypeid { get; set; }

        public int isOverDimensionYesNoUnknownTypeid { get; set; }

        public int? crashMultiLane { get; set; }

        public int? vehicleCrossedCentrelineTypeid { get; set; }

        public int? vehicleSafetyRating { get; set; }

        public int? towedVehicleTypeTypeid { get; set; }

        [StringLength(100)]
        public string otherTowedVehicleTypeDesc { get; set; }

        public bool isImpactedInCrash { get; set; }

        public bool? isExternallyCreated { get; set; }

        public bool? isDeleted { get; set; }

        public virtual CodedCrash CodedCrash { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashContributingFactor> CodedCrashContributingFactors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashDriver> CodedCrashDrivers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashPassenger> CodedCrashPassengers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashPersonHitBy> CodedCrashPersonHitBies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashRole> CodedCrashRoles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashTowedVehicle> CodedCrashTowedVehicles { get; set; }

        public virtual DamageAreaType DamageAreaType { get; set; }

        public virtual DamageSeverityType DamageSeverityType { get; set; }

        public virtual DirectionType DirectionType { get; set; }

        public virtual ReasonForSpeedTooFastType ReasonForSpeedTooFastType { get; set; }

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

        public virtual YesNoUnknownType YesNoUnknownType8 { get; set; }

        public virtual YesNoUnknownType YesNoUnknownType9 { get; set; }

        public virtual YesNoUnknownType YesNoUnknownType10 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashVehicleDevice> CodedCrashVehicleDevices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashVehicleObjectsStruck> CodedCrashVehicleObjectsStrucks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashVehiclePermit> CodedCrashVehiclePermits { get; set; }
    }
}
