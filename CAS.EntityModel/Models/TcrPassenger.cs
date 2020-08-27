namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TcrPassenger")]
    public partial class TcrPassenger
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TcrPassenger()
        {
            TcrPassengerSupplementarySafetyDeviceUseds = new HashSet<TcrPassengerSupplementarySafetyDeviceUsed>();
        }

        public int tcrPassengerid { get; set; }

        public int tcrPersonid { get; set; }

        public int tcrVehicleid { get; set; }

        public short? policeVehicleIdentifier { get; set; }

        public int restraintUsedTypeid { get; set; }

        public short? policePersonNumber { get; set; }

        public int? otherPassengerLocationTypeid { get; set; }

        public int? seatLocationPositionTypeid { get; set; }

        public int? seatLocationRowTypeid { get; set; }

        public virtual OtherPassengerLocationType OtherPassengerLocationType { get; set; }

        public virtual RestraintUsedType RestraintUsedType { get; set; }

        public virtual SeatLocationPositionType SeatLocationPositionType { get; set; }

        public virtual SeatLocationRowType SeatLocationRowType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrPassengerSupplementarySafetyDeviceUsed> TcrPassengerSupplementarySafetyDeviceUseds { get; set; }

        public virtual TcrPerson TcrPerson { get; set; }

        public virtual TcrVehicle TcrVehicle { get; set; }
    }
}
