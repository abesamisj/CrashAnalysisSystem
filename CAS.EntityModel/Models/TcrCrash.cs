namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TcrCrash")]
    public partial class TcrCrash
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TcrCrash()
        {
            CodedCrashes = new HashSet<CodedCrash>();
            TcrAdditionalRoadSurfaceConditions = new HashSet<TcrAdditionalRoadSurfaceCondition>();
            TcrBarriers = new HashSet<TcrBarrier>();
            TcrComments = new HashSet<TcrComment>();
            TcrCrashDiagrams = new HashSet<TcrCrashDiagram>();
            TcrLocations = new HashSet<TcrLocation>();
            TcrPersons = new HashSet<TcrPerson>();
            TcrProcessingStatus = new HashSet<TcrProcessingStatu>();
            TcrRoadMarkings = new HashSet<TcrRoadMarking>();
            TcrTowedVehicles = new HashSet<TcrTowedVehicle>();
            TcrVehicles = new HashSet<TcrVehicle>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tcrCrashIdentifierid { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime timestamp { get; set; }

        public int tcrPoliceStatusTypeid { get; set; }

        [StringLength(2500)]
        public string description { get; set; }

        public DateTime? crashDate { get; set; }

        public TimeSpan? crashTime { get; set; }

        public bool crashTimeUnknown { get; set; }

        [StringLength(1250)]
        public string environmentFactors { get; set; }

        [StringLength(1250)]
        public string roadFactors { get; set; }

        [StringLength(1250)]
        public string roadUserFactors { get; set; }

        [StringLength(1250)]
        public string speedFactors { get; set; }

        [StringLength(1250)]
        public string vehicleFactors { get; set; }

        public int naturalLightTypeTypeid { get; set; }

        public int streetLightStatusTypeid { get; set; }

        public int junctionTypeTypeid { get; set; }

        public int railCrossingTypeTypeid { get; set; }

        public int roadGradientTypeid { get; set; }

        public int roadTypeTypeid { get; set; }

        public int specialPurposeLaneTypeid { get; set; }

        public short? totalLanes { get; set; }

        public int trafficControlTypeid { get; set; }

        public int crashSeverityTypeid { get; set; }

        [StringLength(10)]
        public string policeEventid { get; set; }

        public short? numberOtherPartiesInvolved { get; set; }

        public short? numberVehiclesInvolved { get; set; }

        public int offRoadLocationTypeid { get; set; }

        [StringLength(100)]
        public string offRoadLocationOther { get; set; }

        [StringLength(250)]
        public string objectsHitDescription { get; set; }

        [StringLength(10)]
        public string reportingOfficer { get; set; }

        [StringLength(10)]
        public string transactionid { get; set; }

        public bool policeAttended { get; set; }

        public int primarySurfaceConditionTypeid { get; set; }

        public int roadCurvatureTypeid { get; set; }

        public int roadSurfaceTypeTypeid { get; set; }

        public short? recommendedSpeedLimit { get; set; }

        public short? speedLimit { get; set; }

        public short? tempSpeedLimit { get; set; }

        public int weatherConditionATypeid { get; set; }

        public int weatherConditionBTypeid { get; set; }

        public int? rejectionCategoryTypeid { get; set; }

        public int? disqualifiedReasonTypeid { get; set; }

        public DateTime? dateNotified4Weeks { get; set; }

        public DateTime? dateNotified6Weeks { get; set; }

        public int roadFeatureTypeid { get; set; }

        public bool isPeerReview { get; set; }

        public bool isExercise { get; set; }

        public int latestProcessingStatusTypeid { get; set; }

        public int? exerciseid { get; set; }

        public int? lastModifiedByid { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] objectVersion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrash> CodedCrashes { get; set; }

        public virtual CrashSeverityType CrashSeverityType { get; set; }

        public virtual DisqualifiedReasonType DisqualifiedReasonType { get; set; }

        public virtual Exercise Exercise { get; set; }

        public virtual JunctionTypeType JunctionTypeType { get; set; }

        public virtual NaturalLightTypeType NaturalLightTypeType { get; set; }

        public virtual OffRoadLocationType OffRoadLocationType { get; set; }

        public virtual PrimarySurfaceConditionType PrimarySurfaceConditionType { get; set; }

        public virtual RailCrossingTypeType RailCrossingTypeType { get; set; }

        public virtual RejectionCategoryType RejectionCategoryType { get; set; }

        public virtual RoadCurvatureType RoadCurvatureType { get; set; }

        public virtual RoadFeatureType RoadFeatureType { get; set; }

        public virtual RoadGradientType RoadGradientType { get; set; }

        public virtual RoadSurfaceTypeType RoadSurfaceTypeType { get; set; }

        public virtual RoadTypeType RoadTypeType { get; set; }

        public virtual SpecialPurposeLaneType SpecialPurposeLaneType { get; set; }

        public virtual StreetLightStatusType StreetLightStatusType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrAdditionalRoadSurfaceCondition> TcrAdditionalRoadSurfaceConditions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrBarrier> TcrBarriers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrComment> TcrComments { get; set; }

        public virtual UserProfile UserProfile { get; set; }

        public virtual TcrPoliceStatusType TcrPoliceStatusType { get; set; }

        public virtual TcrStatusType TcrStatusType { get; set; }

        public virtual TrafficControlType TrafficControlType { get; set; }

        public virtual WeatherConditionAType WeatherConditionAType { get; set; }

        public virtual WeatherConditionBType WeatherConditionBType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrCrashDiagram> TcrCrashDiagrams { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrLocation> TcrLocations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrPerson> TcrPersons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrProcessingStatu> TcrProcessingStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrRoadMarking> TcrRoadMarkings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrTowedVehicle> TcrTowedVehicles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrVehicle> TcrVehicles { get; set; }
    }
}
