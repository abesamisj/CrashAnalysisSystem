namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CodedCrash")]
    public partial class CodedCrash
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CodedCrash()
        {
            ArbitrationControls = new HashSet<ArbitrationControl>();
            ArbitrationControls1 = new HashSet<ArbitrationControl>();
            CodedCrashAdditionalRoadSurfaceConditions = new HashSet<CodedCrashAdditionalRoadSurfaceCondition>();
            CodedCrashBarriers = new HashSet<CodedCrashBarrier>();
            CodedCrashComments = new HashSet<CodedCrashComment>();
            CodedCrashContributingFactors = new HashSet<CodedCrashContributingFactor>();
            CodedCrashDiagrams = new HashSet<CodedCrashDiagram>();
            CodedCrashDocuments = new HashSet<CodedCrashDocument>();
            CodedCrashLocations = new HashSet<CodedCrashLocation>();
            CodedCrashPersons = new HashSet<CodedCrashPerson>();
            CodedCrashProcessingStatus = new HashSet<CodedCrashProcessingStatu>();
            CodedCrashRoadMarkings = new HashSet<CodedCrashRoadMarking>();
            CodedCrashRoles = new HashSet<CodedCrashRole>();
            CodedCrashTowedVehicles = new HashSet<CodedCrashTowedVehicle>();
            CodedCrashVehicles = new HashSet<CodedCrashVehicle>();
            ExerciseQualifyingCrashes = new HashSet<ExerciseQualifyingCrash>();
            HintBreaches = new HashSet<HintBreach>();
        }

        public int codedCrashid { get; set; }

        public int tcrCrashIdentifierid { get; set; }

        public DateTime tcrTimestamp { get; set; }

        public bool isPeerReview { get; set; }

        public bool isExercise { get; set; }

        public int createdBy { get; set; }

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

        public int? offRoadLocationTypeid { get; set; }

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

        public DateTime createdDateTime { get; set; }

        public DateTime? modifiedDateTime { get; set; }

        public int? lastModifiedByid { get; set; }

        public int movementCodeTypeid { get; set; }

        public int cviuAttendedCrashYesNoUnknownTypeid { get; set; }

        public DateTime? codingStarted { get; set; }

        public DateTime? codingFinished { get; set; }

        public TimeSpan? codingWorkingTime { get; set; }

        public bool isComplexCrash { get; set; }

        public int? holidayInstanceid { get; set; }

        public bool isWeekend { get; set; }

        public int? arbitratedBy { get; set; }

        public bool currentlyUnlocatable { get; set; }

        [StringLength(50)]
        public string calculatedCrashID { get; set; }

        public int? roadsegmentid { get; set; }

        public int? roadFeatureTypeid { get; set; }

        public bool isOrphaned { get; set; }

        public bool isLegacy { get; set; }

        public int latestProcessingStatusTypeid { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] objectVersion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArbitrationControl> ArbitrationControls { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArbitrationControl> ArbitrationControls1 { get; set; }

        public virtual CodedCrashStatusType CodedCrashStatusType { get; set; }

        public virtual CrashSeverityType CrashSeverityType { get; set; }

        public virtual Holiday Holiday { get; set; }

        public virtual JunctionTypeType JunctionTypeType { get; set; }

        public virtual UserProfile UserProfile { get; set; }

        public virtual MovementCodeType MovementCodeType { get; set; }

        public virtual NaturalLightTypeType NaturalLightTypeType { get; set; }

        public virtual OffRoadLocationType OffRoadLocationType { get; set; }

        public virtual PrimarySurfaceConditionType PrimarySurfaceConditionType { get; set; }

        public virtual RailCrossingTypeType RailCrossingTypeType { get; set; }

        public virtual RoadCurvatureType RoadCurvatureType { get; set; }

        public virtual RoadFeatureType RoadFeatureType { get; set; }

        public virtual RoadGradientType RoadGradientType { get; set; }

        public virtual RoadSurfaceTypeType RoadSurfaceTypeType { get; set; }

        public virtual RoadTypeType RoadTypeType { get; set; }

        public virtual SpecialPurposeLaneType SpecialPurposeLaneType { get; set; }

        public virtual StreetLightStatusType StreetLightStatusType { get; set; }

        public virtual TcrCrash TcrCrash { get; set; }

        public virtual TrafficControlType TrafficControlType { get; set; }

        public virtual UserProfile UserProfile1 { get; set; }

        public virtual UserProfile UserProfile2 { get; set; }

        public virtual WeatherConditionAType WeatherConditionAType { get; set; }

        public virtual WeatherConditionBType WeatherConditionBType { get; set; }

        public virtual YesNoUnknownType YesNoUnknownType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashAdditionalRoadSurfaceCondition> CodedCrashAdditionalRoadSurfaceConditions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashBarrier> CodedCrashBarriers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashComment> CodedCrashComments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashContributingFactor> CodedCrashContributingFactors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashDiagram> CodedCrashDiagrams { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashDocument> CodedCrashDocuments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashLocation> CodedCrashLocations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashPerson> CodedCrashPersons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashProcessingStatu> CodedCrashProcessingStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashRoadMarking> CodedCrashRoadMarkings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashRole> CodedCrashRoles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashTowedVehicle> CodedCrashTowedVehicles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashVehicle> CodedCrashVehicles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExerciseQualifyingCrash> ExerciseQualifyingCrashes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HintBreach> HintBreaches { get; set; }
    }
}
