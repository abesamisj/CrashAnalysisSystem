namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CodedCrashLocation")]
    public partial class CodedCrashLocation
    {
        public int codedCrashLocationid { get; set; }

        public double? northing { get; set; }

        public double? easting { get; set; }

        public bool occuredAtIntersection { get; set; }

        public int directionTypeSideRoadid { get; set; }

        public double? distanceFromSideRoad { get; set; }

        [StringLength(255)]
        public string nameOfSideRoad { get; set; }

        [StringLength(255)]
        public string roadFeatureDescription { get; set; }

        public double? distanceFromRoadFeature { get; set; }

        [StringLength(255)]
        public string roadName { get; set; }

        public int recordedLocationTypeTypeid { get; set; }

        public bool isPrimary { get; set; }

        public int? intersectionid { get; set; }

        public int intersectionMidblockTypeid { get; set; }

        public int? isStateHighwayYesNoUnknownTypeid { get; set; }

        public int codedCrashid { get; set; }

        public DbGeometry locationGeometry { get; set; }

        public DbGeography locationGeography { get; set; }

        public double? latitude { get; set; }

        public double? longitude { get; set; }

        public virtual CodedCrash CodedCrash { get; set; }

        public virtual DirectionType DirectionType { get; set; }

        public virtual IntersectionMidblockType IntersectionMidblockType { get; set; }

        public virtual RecordedLocationTypeType RecordedLocationTypeType { get; set; }

        public virtual YesNoUnknownType YesNoUnknownType { get; set; }
    }
}
