namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CodedCrashContributingFactor")]
    public partial class CodedCrashContributingFactor
    {
        public int codedCrashContributingFactorid { get; set; }

        public int contributingFactorTypeid { get; set; }

        public int? codedCrashVehicleid { get; set; }

        public int? codedCrashPersonid { get; set; }

        public int codedCrashid { get; set; }

        public int? userProfileid { get; set; }

        public int? codingPanelGroup { get; set; }

        public virtual CodedCrash CodedCrash { get; set; }

        public virtual CodedCrashPerson CodedCrashPerson { get; set; }

        public virtual CodedCrashVehicle CodedCrashVehicle { get; set; }

        public virtual ContributingFactorType ContributingFactorType { get; set; }
    }
}
