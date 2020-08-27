namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CodedCrashPassenger")]
    public partial class CodedCrashPassenger
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CodedCrashPassenger()
        {
            CodedCrashPassengerSupplementarySafetyDeviceUseds = new HashSet<CodedCrashPassengerSupplementarySafetyDeviceUsed>();
        }

        public int codedCrashPassengerid { get; set; }

        public int codedCrashPersonid { get; set; }

        public int codedCrashVehicleid { get; set; }

        public short? policeVehicleIdentifier { get; set; }

        public int restraintUsedTypeid { get; set; }

        public short? policePersonNumber { get; set; }

        public int? otherPassengerLocationTypeid { get; set; }

        public int? seatLocationPositionTypeid { get; set; }

        public int? seatLocationRowTypeid { get; set; }

        public virtual CodedCrashPerson CodedCrashPerson { get; set; }

        public virtual CodedCrashVehicle CodedCrashVehicle { get; set; }

        public virtual OtherPassengerLocationType OtherPassengerLocationType { get; set; }

        public virtual RestraintUsedType RestraintUsedType { get; set; }

        public virtual SeatLocationPositionType SeatLocationPositionType { get; set; }

        public virtual SeatLocationRowType SeatLocationRowType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashPassengerSupplementarySafetyDeviceUsed> CodedCrashPassengerSupplementarySafetyDeviceUseds { get; set; }
    }
}
