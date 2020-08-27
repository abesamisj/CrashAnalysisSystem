namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TcrLocation")]
    public partial class TcrLocation
    {
        public int tcrLocationid { get; set; }

        public int tcrCrashIdentifierid { get; set; }

        public DateTime timestamp { get; set; }

        public double? latitude { get; set; }

        public double? longitude { get; set; }

        public bool occuredAtIntersection { get; set; }

        [StringLength(255)]
        public string roadName { get; set; }

        public int directionTypeSideRoadid { get; set; }

        public double? distanceFromSideRoad { get; set; }

        [StringLength(255)]
        public string nameOfSideRoad { get; set; }

        public int recordedLocationTypeTypeid { get; set; }

        public double? distanceFromRoadFeature { get; set; }

        [StringLength(255)]
        public string roadFeatureDescription { get; set; }

        public double? northing { get; set; }

        public double? easting { get; set; }

        public DbGeometry locationGeometry { get; set; }

        public DbGeography locationGeography { get; set; }

        public virtual DirectionType DirectionType { get; set; }

        public virtual RecordedLocationTypeType RecordedLocationTypeType { get; set; }

        public virtual TcrCrash TcrCrash { get; set; }
    }
}
