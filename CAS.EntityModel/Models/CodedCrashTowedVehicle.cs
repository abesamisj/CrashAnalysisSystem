namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CodedCrashTowedVehicle")]
    public partial class CodedCrashTowedVehicle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CodedCrashTowedVehicle()
        {
            CodedCrashTowedVehicle1 = new HashSet<CodedCrashTowedVehicle>();
        }

        public int codedCrashTowedVehicleid { get; set; }

        public int codedCrashid { get; set; }

        public DateTime createdDateTime { get; set; }

        [StringLength(20)]
        public string make { get; set; }

        [StringLength(20)]
        public string model { get; set; }

        public short? yearOfManufacture { get; set; }

        public DateTime? wofCofExpiryDate { get; set; }

        public int hasWofCofYesNoUnknownTypeid { get; set; }

        public int hasNoRegistrationPlatesYesNoUnknownTypeid { get; set; }

        public bool isRegistrationPlateUnknown { get; set; }

        [StringLength(6)]
        public string registrationNumber { get; set; }

        public short? policeVehicleIdentifier { get; set; }

        public short? towedByPoliceVehicleIdentifier { get; set; }

        public int damageSeverityTypeid { get; set; }

        public int hasUnderunProtectionYesNoUnknownTypeid { get; set; }

        public int wasNoUnderRunProtectionContributorYesNoUnknownTypeid { get; set; }

        public int isLoadSecuredYesNoUnknownTypeid { get; set; }

        [StringLength(100)]
        public string loadDescription { get; set; }

        public double? loadHeight { get; set; }

        public int damageAreaTypeid { get; set; }

        [StringLength(50)]
        public string primaryColour { get; set; }

        public int hasModificationsYesNoUnknownTypeid { get; set; }

        public int towedVehicleTypeTypeid { get; set; }

        [StringLength(100)]
        public string otherTowedVehicleTypeDesc { get; set; }

        public int? towedByVehicleid { get; set; }

        public int? towedByTowedVehicleid { get; set; }

        public int? vehicleLoadTypeid { get; set; }

        public virtual CodedCrash CodedCrash { get; set; }

        public virtual CodedCrashVehicle CodedCrashVehicle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashTowedVehicle> CodedCrashTowedVehicle1 { get; set; }

        public virtual CodedCrashTowedVehicle CodedCrashTowedVehicle2 { get; set; }

        public virtual DamageAreaType DamageAreaType { get; set; }

        public virtual DamageSeverityType DamageSeverityType { get; set; }

        public virtual TowedVehicleTypeType TowedVehicleTypeType { get; set; }

        public virtual VehicleLoadType VehicleLoadType { get; set; }

        public virtual YesNoUnknownType YesNoUnknownType { get; set; }

        public virtual YesNoUnknownType YesNoUnknownType1 { get; set; }

        public virtual YesNoUnknownType YesNoUnknownType2 { get; set; }

        public virtual YesNoUnknownType YesNoUnknownType3 { get; set; }

        public virtual YesNoUnknownType YesNoUnknownType4 { get; set; }

        public virtual YesNoUnknownType YesNoUnknownType5 { get; set; }
    }
}
