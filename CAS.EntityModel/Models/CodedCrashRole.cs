namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CodedCrashRole")]
    public partial class CodedCrashRole
    {
        public int codedCrashRoleid { get; set; }

        public int? codedCrashVehicleid { get; set; }

        public int? codedCrashPersonid { get; set; }

        public int? crashRole { get; set; }

        public bool isPrimaryVehicle { get; set; }

        public int codedCrashid { get; set; }

        public virtual CodedCrash CodedCrash { get; set; }

        public virtual CodedCrashPerson CodedCrashPerson { get; set; }

        public virtual CodedCrashVehicle CodedCrashVehicle { get; set; }
    }
}
