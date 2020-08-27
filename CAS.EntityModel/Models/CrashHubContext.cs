namespace CAS.EntityModel.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CrashHubContext : DbContext
    {
        public CrashHubContext()
            : base("name=CrashHubContext")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<C__TransactionHistory> C__TransactionHistory { get; set; }
        public virtual DbSet<C2016idControl> C2016idControl { get; set; }
        public virtual DbSet<C2017idControl> C2017idControl { get; set; }
        public virtual DbSet<C2018idControl> C2018idControl { get; set; }
        public virtual DbSet<C2019idControl> C2019idControl { get; set; }
        public virtual DbSet<AdditionalRoadSurfaceConditionType> AdditionalRoadSurfaceConditionTypes { get; set; }
        public virtual DbSet<AlcoholInvolvedType> AlcoholInvolvedTypes { get; set; }
        public virtual DbSet<ApplicationConfiguration> ApplicationConfigurations { get; set; }
        public virtual DbSet<ArbitrationControl> ArbitrationControls { get; set; }
        public virtual DbSet<BarrierLocationType> BarrierLocationTypes { get; set; }
        public virtual DbSet<BarrierType> BarrierTypes { get; set; }
        public virtual DbSet<BreathScreeningTestType> BreathScreeningTestTypes { get; set; }
        public virtual DbSet<CodedCrash> CodedCrashes { get; set; }
        public virtual DbSet<CodedCrashAdditionalRoadSurfaceCondition> CodedCrashAdditionalRoadSurfaceConditions { get; set; }
        public virtual DbSet<CodedCrashBarrier> CodedCrashBarriers { get; set; }
        public virtual DbSet<CodedCrashComment> CodedCrashComments { get; set; }
        public virtual DbSet<CodedCrashContributingFactor> CodedCrashContributingFactors { get; set; }
        public virtual DbSet<CodedCrashDiagram> CodedCrashDiagrams { get; set; }
        public virtual DbSet<CodedCrashDocument> CodedCrashDocuments { get; set; }
        public virtual DbSet<CodedCrashDriver> CodedCrashDrivers { get; set; }
        public virtual DbSet<CodedCrashDriverSupplementarySafetyDeviceUsed> CodedCrashDriverSupplementarySafetyDeviceUseds { get; set; }
        public virtual DbSet<CodedCrashLocation> CodedCrashLocations { get; set; }
        public virtual DbSet<CodedCrashPassenger> CodedCrashPassengers { get; set; }
        public virtual DbSet<CodedCrashPassengerSupplementarySafetyDeviceUsed> CodedCrashPassengerSupplementarySafetyDeviceUseds { get; set; }
        public virtual DbSet<CodedCrashPerson> CodedCrashPersons { get; set; }
        public virtual DbSet<CodedCrashPersonHitBy> CodedCrashPersonHitBies { get; set; }
        public virtual DbSet<CodedCrashProcessingStatu> CodedCrashProcessingStatus { get; set; }
        public virtual DbSet<CodedCrashRoadMarking> CodedCrashRoadMarkings { get; set; }
        public virtual DbSet<CodedCrashRole> CodedCrashRoles { get; set; }
        public virtual DbSet<CodedCrashStatusType> CodedCrashStatusTypes { get; set; }
        public virtual DbSet<CodedCrashTowedVehicle> CodedCrashTowedVehicles { get; set; }
        public virtual DbSet<CodedCrashUpdateReasonType> CodedCrashUpdateReasonTypes { get; set; }
        public virtual DbSet<CodedCrashVehicle> CodedCrashVehicles { get; set; }
        public virtual DbSet<CodedCrashVehicleDevice> CodedCrashVehicleDevices { get; set; }
        public virtual DbSet<CodedCrashVehicleObjectsStruck> CodedCrashVehicleObjectsStrucks { get; set; }
        public virtual DbSet<CodedCrashVehiclePermit> CodedCrashVehiclePermits { get; set; }
        public virtual DbSet<CodingQueuePrioritySchemeType> CodingQueuePrioritySchemeTypes { get; set; }
        public virtual DbSet<ContributingFactorFamilyType> ContributingFactorFamilyTypes { get; set; }
        public virtual DbSet<ContributingFactorGroupType> ContributingFactorGroupTypes { get; set; }
        public virtual DbSet<ContributingFactorHint> ContributingFactorHints { get; set; }
        public virtual DbSet<ContributingFactorsInExercise> ContributingFactorsInExercises { get; set; }
        public virtual DbSet<ContributingFactorType> ContributingFactorTypes { get; set; }
        public virtual DbSet<CrashSeverityType> CrashSeverityTypes { get; set; }
        public virtual DbSet<DamageAreaType> DamageAreaTypes { get; set; }
        public virtual DbSet<DamageSeverityType> DamageSeverityTypes { get; set; }
        public virtual DbSet<DeleteAudit> DeleteAudits { get; set; }
        public virtual DbSet<DeleteAuditStaging> DeleteAuditStagings { get; set; }
        public virtual DbSet<DirectionType> DirectionTypes { get; set; }
        public virtual DbSet<DisqualifiedReasonType> DisqualifiedReasonTypes { get; set; }
        public virtual DbSet<DocumentTypeType> DocumentTypeTypes { get; set; }
        public virtual DbSet<DriverContributionType> DriverContributionTypes { get; set; }
        public virtual DbSet<DriverLicenseStatusType> DriverLicenseStatusTypes { get; set; }
        public virtual DbSet<DriverLicenseTypeType> DriverLicenseTypeTypes { get; set; }
        public virtual DbSet<DrugScreeningTestResultType> DrugScreeningTestResultTypes { get; set; }
        public virtual DbSet<DrugScreeningTestType> DrugScreeningTestTypes { get; set; }
        public virtual DbSet<DrugsInvolvedType> DrugsInvolvedTypes { get; set; }
        public virtual DbSet<DrugTypeType> DrugTypeTypes { get; set; }
        public virtual DbSet<EthnicityType> EthnicityTypes { get; set; }
        public virtual DbSet<EvidentialBloodTestType> EvidentialBloodTestTypes { get; set; }
        public virtual DbSet<EvidentialBreathTestType> EvidentialBreathTestTypes { get; set; }
        public virtual DbSet<Exercise> Exercises { get; set; }
        public virtual DbSet<ExerciseQualifyingCrash> ExerciseQualifyingCrashes { get; set; }
        public virtual DbSet<GenderType> GenderTypes { get; set; }
        public virtual DbSet<HintBreach> HintBreaches { get; set; }
        public virtual DbSet<HintType> HintTypes { get; set; }
        public virtual DbSet<Holiday> Holidays { get; set; }
        public virtual DbSet<InjuryCauseType> InjuryCauseTypes { get; set; }
        public virtual DbSet<InjurySeverityType> InjurySeverityTypes { get; set; }
        public virtual DbSet<IntersectionMidblockType> IntersectionMidblockTypes { get; set; }
        public virtual DbSet<JunctionTypeType> JunctionTypeTypes { get; set; }
        public virtual DbSet<KeywordToCfHelper> KeywordToCfHelpers { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<MovementCodeHint> MovementCodeHints { get; set; }
        public virtual DbSet<MovementCodesInExercise> MovementCodesInExercises { get; set; }
        public virtual DbSet<MovementCodeType> MovementCodeTypes { get; set; }
        public virtual DbSet<MovementGroupType> MovementGroupTypes { get; set; }
        public virtual DbSet<NaturalLightTypeType> NaturalLightTypeTypes { get; set; }
        public virtual DbSet<OffRoadLocationType> OffRoadLocationTypes { get; set; }
        public virtual DbSet<OtherPartyType> OtherPartyTypes { get; set; }
        public virtual DbSet<OtherPassengerLocationType> OtherPassengerLocationTypes { get; set; }
        public virtual DbSet<OverseasDriverStatusType> OverseasDriverStatusTypes { get; set; }
        public virtual DbSet<PeerReviewSetting> PeerReviewSettings { get; set; }
        public virtual DbSet<PrimarySurfaceConditionType> PrimarySurfaceConditionTypes { get; set; }
        public virtual DbSet<RailCrossingTypeType> RailCrossingTypeTypes { get; set; }
        public virtual DbSet<ReasonForSpeedTooFastType> ReasonForSpeedTooFastTypes { get; set; }
        public virtual DbSet<ReasonLicenseBreachedType> ReasonLicenseBreachedTypes { get; set; }
        public virtual DbSet<RecordedLocationTypeType> RecordedLocationTypeTypes { get; set; }
        public virtual DbSet<RejectionCategoryType> RejectionCategoryTypes { get; set; }
        public virtual DbSet<RestraintUsedType> RestraintUsedTypes { get; set; }
        public virtual DbSet<RoadCurvatureType> RoadCurvatureTypes { get; set; }
        public virtual DbSet<RoadFeatureType> RoadFeatureTypes { get; set; }
        public virtual DbSet<RoadGradientType> RoadGradientTypes { get; set; }
        public virtual DbSet<RoadMarkingTypeType> RoadMarkingTypeTypes { get; set; }
        public virtual DbSet<RoadSurfaceTypeType> RoadSurfaceTypeTypes { get; set; }
        public virtual DbSet<RoadTypeType> RoadTypeTypes { get; set; }
        public virtual DbSet<RoadUserTypeType> RoadUserTypeTypes { get; set; }
        public virtual DbSet<SeatLocationPositionType> SeatLocationPositionTypes { get; set; }
        public virtual DbSet<SeatLocationRowType> SeatLocationRowTypes { get; set; }
        public virtual DbSet<SocialCost> SocialCosts { get; set; }
        public virtual DbSet<SpecialPurposeLaneType> SpecialPurposeLaneTypes { get; set; }
        public virtual DbSet<StreetLightStatusType> StreetLightStatusTypes { get; set; }
        public virtual DbSet<StruckObjectType> StruckObjectTypes { get; set; }
        public virtual DbSet<StruckObjectTypeType> StruckObjectTypeTypes { get; set; }
        public virtual DbSet<SupplementarySafetyDeviceType> SupplementarySafetyDeviceTypes { get; set; }
        public virtual DbSet<SystemConfiguration> SystemConfigurations { get; set; }
        public virtual DbSet<TcrAdditionalRoadSurfaceCondition> TcrAdditionalRoadSurfaceConditions { get; set; }
        public virtual DbSet<TcrBarrier> TcrBarriers { get; set; }
        public virtual DbSet<TcrComment> TcrComments { get; set; }
        public virtual DbSet<TcrCrash> TcrCrashes { get; set; }
        public virtual DbSet<TcrCrashDiagram> TcrCrashDiagrams { get; set; }
        public virtual DbSet<TcrCrashIdentifier> TcrCrashIdentifiers { get; set; }
        public virtual DbSet<TcrDriver> TcrDrivers { get; set; }
        public virtual DbSet<TcrDriverSupplementarySafetyDeviceUsed> TcrDriverSupplementarySafetyDeviceUseds { get; set; }
        public virtual DbSet<TcrLocation> TcrLocations { get; set; }
        public virtual DbSet<TcrPassenger> TcrPassengers { get; set; }
        public virtual DbSet<TcrPassengerSupplementarySafetyDeviceUsed> TcrPassengerSupplementarySafetyDeviceUseds { get; set; }
        public virtual DbSet<TcrPdfPrintingConfiguration> TcrPdfPrintingConfigurations { get; set; }
        public virtual DbSet<TcrPerson> TcrPersons { get; set; }
        public virtual DbSet<TcrPoliceStatusType> TcrPoliceStatusTypes { get; set; }
        public virtual DbSet<TcrProcessingStatu> TcrProcessingStatus { get; set; }
        public virtual DbSet<TcrRoadMarking> TcrRoadMarkings { get; set; }
        public virtual DbSet<TcrStatusType> TcrStatusTypes { get; set; }
        public virtual DbSet<TcrTowedVehicle> TcrTowedVehicles { get; set; }
        public virtual DbSet<TcrVehicle> TcrVehicles { get; set; }
        public virtual DbSet<TcrVehicleDevice> TcrVehicleDevices { get; set; }
        public virtual DbSet<TcrVehiclePermit> TcrVehiclePermits { get; set; }
        public virtual DbSet<TowedVehicleTypeType> TowedVehicleTypeTypes { get; set; }
        public virtual DbSet<TrafficControlType> TrafficControlTypes { get; set; }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }
        public virtual DbSet<UsersCompletedCrashInExercise> UsersCompletedCrashInExercises { get; set; }
        public virtual DbSet<UsersInExercise> UsersInExercises { get; set; }
        public virtual DbSet<VehicleDeviceType> VehicleDeviceTypes { get; set; }
        public virtual DbSet<VehicleLoadType> VehicleLoadTypes { get; set; }
        public virtual DbSet<VehiclePermitTypeType> VehiclePermitTypeTypes { get; set; }
        public virtual DbSet<VehicleStateType> VehicleStateTypes { get; set; }
        public virtual DbSet<VehicleTypeType> VehicleTypeTypes { get; set; }
        public virtual DbSet<VehicleUsageType> VehicleUsageTypes { get; set; }
        public virtual DbSet<WeatherConditionAType> WeatherConditionATypes { get; set; }
        public virtual DbSet<WeatherConditionBType> WeatherConditionBTypes { get; set; }
        public virtual DbSet<YesNoUnknownType> YesNoUnknownTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdditionalRoadSurfaceConditionType>()
                .Property(e => e.additionalRoadSurfaceConditionTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<AdditionalRoadSurfaceConditionType>()
                .Property(e => e.additionalRoadSurfaceConditionTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<AdditionalRoadSurfaceConditionType>()
                .Property(e => e.additionalRoadSurfaceConditionTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<AdditionalRoadSurfaceConditionType>()
                .HasMany(e => e.CodedCrashAdditionalRoadSurfaceConditions)
                .WithRequired(e => e.AdditionalRoadSurfaceConditionType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AdditionalRoadSurfaceConditionType>()
                .HasMany(e => e.TcrAdditionalRoadSurfaceConditions)
                .WithRequired(e => e.AdditionalRoadSurfaceConditionType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AlcoholInvolvedType>()
                .HasMany(e => e.CodedCrashDrivers)
                .WithRequired(e => e.AlcoholInvolvedType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AlcoholInvolvedType>()
                .HasMany(e => e.TcrDrivers)
                .WithRequired(e => e.AlcoholInvolvedType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ApplicationConfiguration>()
                .Property(e => e.applicationConfigurationName)
                .IsUnicode(false);

            modelBuilder.Entity<ApplicationConfiguration>()
                .Property(e => e.applicationConfigurationValue)
                .IsUnicode(false);

            modelBuilder.Entity<ArbitrationControl>()
                .Property(e => e.comments)
                .IsUnicode(false);

            modelBuilder.Entity<BarrierLocationType>()
                .Property(e => e.barrierLocationTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<BarrierLocationType>()
                .Property(e => e.barrierLocationTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<BarrierLocationType>()
                .Property(e => e.barrierLocationTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<BarrierLocationType>()
                .HasMany(e => e.CodedCrashBarriers)
                .WithRequired(e => e.BarrierLocationType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BarrierLocationType>()
                .HasMany(e => e.TcrBarriers)
                .WithRequired(e => e.BarrierLocationType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BarrierType>()
                .Property(e => e.barrierTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<BarrierType>()
                .Property(e => e.barrierTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<BarrierType>()
                .Property(e => e.barrierTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<BarrierType>()
                .HasMany(e => e.CodedCrashBarriers)
                .WithRequired(e => e.BarrierType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BarrierType>()
                .HasMany(e => e.TcrBarriers)
                .WithRequired(e => e.BarrierType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BreathScreeningTestType>()
                .HasMany(e => e.CodedCrashDrivers)
                .WithRequired(e => e.BreathScreeningTestType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BreathScreeningTestType>()
                .HasMany(e => e.TcrDrivers)
                .WithRequired(e => e.BreathScreeningTestType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodedCrash>()
                .Property(e => e.calculatedCrashID)
                .IsUnicode(false);

            modelBuilder.Entity<CodedCrash>()
                .Property(e => e.objectVersion)
                .IsFixedLength();

            modelBuilder.Entity<CodedCrash>()
                .HasMany(e => e.ArbitrationControls)
                .WithRequired(e => e.CodedCrash)
                .HasForeignKey(e => e.originalCodedCrashid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodedCrash>()
                .HasMany(e => e.ArbitrationControls1)
                .WithRequired(e => e.CodedCrash1)
                .HasForeignKey(e => e.reviewCodedCrashid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodedCrash>()
                .HasMany(e => e.CodedCrashAdditionalRoadSurfaceConditions)
                .WithRequired(e => e.CodedCrash)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodedCrash>()
                .HasMany(e => e.CodedCrashBarriers)
                .WithRequired(e => e.CodedCrash)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodedCrash>()
                .HasMany(e => e.CodedCrashContributingFactors)
                .WithRequired(e => e.CodedCrash)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodedCrash>()
                .HasMany(e => e.CodedCrashDiagrams)
                .WithRequired(e => e.CodedCrash)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodedCrash>()
                .HasMany(e => e.CodedCrashDocuments)
                .WithRequired(e => e.CodedCrash)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodedCrash>()
                .HasMany(e => e.CodedCrashLocations)
                .WithRequired(e => e.CodedCrash)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodedCrash>()
                .HasMany(e => e.CodedCrashPersons)
                .WithRequired(e => e.CodedCrash)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodedCrash>()
                .HasMany(e => e.CodedCrashProcessingStatus)
                .WithRequired(e => e.CodedCrash)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodedCrash>()
                .HasMany(e => e.CodedCrashRoadMarkings)
                .WithRequired(e => e.CodedCrash)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodedCrash>()
                .HasMany(e => e.CodedCrashRoles)
                .WithRequired(e => e.CodedCrash)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodedCrash>()
                .HasMany(e => e.CodedCrashTowedVehicles)
                .WithRequired(e => e.CodedCrash)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodedCrash>()
                .HasMany(e => e.CodedCrashVehicles)
                .WithRequired(e => e.CodedCrash)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodedCrashComment>()
                .Property(e => e.codedCrashComment1)
                .IsUnicode(false);

            modelBuilder.Entity<CodedCrashComment>()
                .Property(e => e.codedCrashFieldName)
                .IsUnicode(false);

            modelBuilder.Entity<CodedCrashComment>()
                .Property(e => e.codedCrashEnclosingType)
                .IsUnicode(false);

            modelBuilder.Entity<CodedCrashDocument>()
                .Property(e => e.documentInfoHubURL)
                .IsUnicode(false);

            modelBuilder.Entity<CodedCrashDocument>()
                .Property(e => e.legacyCASImagePath)
                .IsUnicode(false);

            modelBuilder.Entity<CodedCrashDocument>()
                .Property(e => e.reviewComment)
                .IsUnicode(false);

            modelBuilder.Entity<CodedCrashDriver>()
                .HasMany(e => e.CodedCrashDriverSupplementarySafetyDeviceUseds)
                .WithRequired(e => e.CodedCrashDriver)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodedCrashDriverSupplementarySafetyDeviceUsed>()
                .Property(e => e.otherSupplementarySafetyDevice)
                .IsUnicode(false);

            modelBuilder.Entity<CodedCrashPassenger>()
                .HasMany(e => e.CodedCrashPassengerSupplementarySafetyDeviceUseds)
                .WithRequired(e => e.CodedCrashPassenger)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodedCrashPassengerSupplementarySafetyDeviceUsed>()
                .Property(e => e.otherSupplementarySafetyDevice)
                .IsUnicode(false);

            modelBuilder.Entity<CodedCrashPerson>()
                .HasMany(e => e.CodedCrashDrivers)
                .WithRequired(e => e.CodedCrashPerson)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodedCrashPerson>()
                .HasMany(e => e.CodedCrashPassengers)
                .WithRequired(e => e.CodedCrashPerson)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodedCrashPerson>()
                .HasMany(e => e.CodedCrashPersonHitBies)
                .WithRequired(e => e.CodedCrashPerson)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodedCrashStatusType>()
                .Property(e => e.codedCrashStatusTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<CodedCrashStatusType>()
                .Property(e => e.codedCrashStatusTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<CodedCrashStatusType>()
                .Property(e => e.codedCrashStatusTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<CodedCrashStatusType>()
                .HasMany(e => e.ArbitrationControls)
                .WithOptional(e => e.CodedCrashStatusType)
                .HasForeignKey(e => e.finalStatusTypeid);

            modelBuilder.Entity<CodedCrashStatusType>()
                .HasMany(e => e.CodedCrashes)
                .WithRequired(e => e.CodedCrashStatusType)
                .HasForeignKey(e => e.latestProcessingStatusTypeid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodedCrashStatusType>()
                .HasMany(e => e.CodedCrashProcessingStatus)
                .WithRequired(e => e.CodedCrashStatusType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodedCrashTowedVehicle>()
                .Property(e => e.primaryColour)
                .IsUnicode(false);

            modelBuilder.Entity<CodedCrashTowedVehicle>()
                .HasMany(e => e.CodedCrashTowedVehicle1)
                .WithOptional(e => e.CodedCrashTowedVehicle2)
                .HasForeignKey(e => e.towedByTowedVehicleid);

            modelBuilder.Entity<CodedCrashUpdateReasonType>()
                .Property(e => e.codedCrashUpdateReasonTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<CodedCrashUpdateReasonType>()
                .Property(e => e.codedCrashUpdateReasonTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<CodedCrashUpdateReasonType>()
                .Property(e => e.codedCrashUpdateReasonTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<CodedCrashVehicle>()
                .Property(e => e.vehicleUsageTypeOtherDescription)
                .IsUnicode(false);

            modelBuilder.Entity<CodedCrashVehicle>()
                .Property(e => e.primaryColour)
                .IsUnicode(false);

            modelBuilder.Entity<CodedCrashVehicle>()
                .HasMany(e => e.CodedCrashDrivers)
                .WithRequired(e => e.CodedCrashVehicle)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodedCrashVehicle>()
                .HasMany(e => e.CodedCrashPassengers)
                .WithRequired(e => e.CodedCrashVehicle)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodedCrashVehicle>()
                .HasMany(e => e.CodedCrashPersonHitBies)
                .WithRequired(e => e.CodedCrashVehicle)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodedCrashVehicle>()
                .HasMany(e => e.CodedCrashTowedVehicles)
                .WithOptional(e => e.CodedCrashVehicle)
                .HasForeignKey(e => e.towedByVehicleid);

            modelBuilder.Entity<CodedCrashVehicle>()
                .HasMany(e => e.CodedCrashVehicleDevices)
                .WithRequired(e => e.CodedCrashVehicle)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodedCrashVehicle>()
                .HasMany(e => e.CodedCrashVehicleObjectsStrucks)
                .WithRequired(e => e.CodedCrashVehicle)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodedCrashVehicle>()
                .HasMany(e => e.CodedCrashVehiclePermits)
                .WithRequired(e => e.CodedCrashVehicle)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodedCrashVehiclePermit>()
                .Property(e => e.vehiclePermitNumber)
                .IsUnicode(false);

            modelBuilder.Entity<CodingQueuePrioritySchemeType>()
                .Property(e => e.codingQueueTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<CodingQueuePrioritySchemeType>()
                .Property(e => e.codingQueueTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<CodingQueuePrioritySchemeType>()
                .Property(e => e.codingQueueTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<CodingQueuePrioritySchemeType>()
                .HasMany(e => e.UserProfiles)
                .WithRequired(e => e.CodingQueuePrioritySchemeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContributingFactorFamilyType>()
                .Property(e => e.contributingFactorFamilyTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<ContributingFactorFamilyType>()
                .Property(e => e.contributingFactorFamilyTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<ContributingFactorFamilyType>()
                .Property(e => e.contributingFactorFamilyTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<ContributingFactorFamilyType>()
                .HasMany(e => e.ContributingFactorTypes)
                .WithRequired(e => e.ContributingFactorFamilyType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContributingFactorGroupType>()
                .Property(e => e.contributingFactorGroupTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<ContributingFactorGroupType>()
                .Property(e => e.contributingFactorGroupTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<ContributingFactorGroupType>()
                .Property(e => e.contributingFactorGroupTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<ContributingFactorGroupType>()
                .HasMany(e => e.ContributingFactorTypes)
                .WithRequired(e => e.ContributingFactorGroupType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContributingFactorType>()
                .Property(e => e.contributingFactorTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<ContributingFactorType>()
                .Property(e => e.contributingFactorTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<ContributingFactorType>()
                .Property(e => e.contributingFactorTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<ContributingFactorType>()
                .Property(e => e.roadSafetyFactorGroupName)
                .IsUnicode(false);

            modelBuilder.Entity<ContributingFactorType>()
                .HasMany(e => e.CodedCrashContributingFactors)
                .WithRequired(e => e.ContributingFactorType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContributingFactorType>()
                .HasMany(e => e.ContributingFactorsInExercises)
                .WithRequired(e => e.ContributingFactorType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CrashSeverityType>()
                .HasMany(e => e.CodedCrashes)
                .WithRequired(e => e.CrashSeverityType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CrashSeverityType>()
                .HasMany(e => e.TcrCrashes)
                .WithRequired(e => e.CrashSeverityType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DamageAreaType>()
                .Property(e => e.vehicleClass)
                .IsUnicode(false);

            modelBuilder.Entity<DamageAreaType>()
                .HasMany(e => e.CodedCrashTowedVehicles)
                .WithRequired(e => e.DamageAreaType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DamageAreaType>()
                .HasMany(e => e.CodedCrashVehicles)
                .WithRequired(e => e.DamageAreaType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DamageAreaType>()
                .HasMany(e => e.TcrTowedVehicles)
                .WithRequired(e => e.DamageAreaType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DamageAreaType>()
                .HasMany(e => e.TcrVehicles)
                .WithRequired(e => e.DamageAreaType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DamageSeverityType>()
                .HasMany(e => e.CodedCrashTowedVehicles)
                .WithRequired(e => e.DamageSeverityType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DamageSeverityType>()
                .HasMany(e => e.CodedCrashVehicles)
                .WithRequired(e => e.DamageSeverityType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DamageSeverityType>()
                .HasMany(e => e.TcrTowedVehicles)
                .WithRequired(e => e.DamageSeverityType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DamageSeverityType>()
                .HasMany(e => e.TcrVehicles)
                .WithRequired(e => e.DamageSeverityType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DeleteAudit>()
                .Property(e => e.tableName)
                .IsUnicode(false);

            modelBuilder.Entity<DeleteAuditStaging>()
                .Property(e => e.tableName)
                .IsUnicode(false);

            modelBuilder.Entity<DirectionType>()
                .HasMany(e => e.CodedCrashLocations)
                .WithRequired(e => e.DirectionType)
                .HasForeignKey(e => e.directionTypeSideRoadid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DirectionType>()
                .HasMany(e => e.CodedCrashVehicles)
                .WithRequired(e => e.DirectionType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DirectionType>()
                .HasMany(e => e.TcrLocations)
                .WithRequired(e => e.DirectionType)
                .HasForeignKey(e => e.directionTypeSideRoadid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DirectionType>()
                .HasMany(e => e.TcrVehicles)
                .WithRequired(e => e.DirectionType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DisqualifiedReasonType>()
                .Property(e => e.disqualifiedReasonTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<DisqualifiedReasonType>()
                .Property(e => e.disqualifiedReasonTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<DisqualifiedReasonType>()
                .Property(e => e.disqualifiedReasonTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentTypeType>()
                .Property(e => e.documentTypeTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentTypeType>()
                .Property(e => e.documentTypeTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentTypeType>()
                .Property(e => e.documentTypeTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentTypeType>()
                .HasMany(e => e.CodedCrashDocuments)
                .WithRequired(e => e.DocumentTypeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DriverContributionType>()
                .Property(e => e.driverContributionTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<DriverContributionType>()
                .Property(e => e.driverContributionTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<DriverContributionType>()
                .Property(e => e.driverContributionTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<DriverContributionType>()
                .HasMany(e => e.CodedCrashDrivers)
                .WithRequired(e => e.DriverContributionType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DriverLicenseStatusType>()
                .Property(e => e.driverLicenseStatusTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<DriverLicenseStatusType>()
                .Property(e => e.driverLicenseStatusTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<DriverLicenseStatusType>()
                .Property(e => e.driverLicenseStatusTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<DriverLicenseStatusType>()
                .HasMany(e => e.CodedCrashDrivers)
                .WithRequired(e => e.DriverLicenseStatusType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DriverLicenseStatusType>()
                .HasMany(e => e.TcrDrivers)
                .WithRequired(e => e.DriverLicenseStatusType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DriverLicenseTypeType>()
                .Property(e => e.driverLicenseTypeTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<DriverLicenseTypeType>()
                .Property(e => e.driverLicenseTypeTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<DriverLicenseTypeType>()
                .Property(e => e.driverLicenseTypeTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<DriverLicenseTypeType>()
                .HasMany(e => e.CodedCrashDrivers)
                .WithRequired(e => e.DriverLicenseTypeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DriverLicenseTypeType>()
                .HasMany(e => e.TcrDrivers)
                .WithRequired(e => e.DriverLicenseTypeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DrugScreeningTestResultType>()
                .Property(e => e.drugScreeningTestResultTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<DrugScreeningTestResultType>()
                .Property(e => e.drugScreeningTestResultTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<DrugScreeningTestResultType>()
                .Property(e => e.drugScreeningTestResultTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<DrugScreeningTestResultType>()
                .HasMany(e => e.CodedCrashDrivers)
                .WithRequired(e => e.DrugScreeningTestResultType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DrugScreeningTestResultType>()
                .HasMany(e => e.TcrDrivers)
                .WithRequired(e => e.DrugScreeningTestResultType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DrugScreeningTestType>()
                .Property(e => e.drugScreeningTestTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<DrugScreeningTestType>()
                .Property(e => e.drugScreeningTestTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<DrugScreeningTestType>()
                .Property(e => e.drugScreeningTestTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<DrugScreeningTestType>()
                .HasMany(e => e.CodedCrashDrivers)
                .WithRequired(e => e.DrugScreeningTestType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DrugScreeningTestType>()
                .HasMany(e => e.TcrDrivers)
                .WithRequired(e => e.DrugScreeningTestType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DrugsInvolvedType>()
                .HasMany(e => e.CodedCrashDrivers)
                .WithRequired(e => e.DrugsInvolvedType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DrugsInvolvedType>()
                .HasMany(e => e.TcrDrivers)
                .WithRequired(e => e.DrugsInvolvedType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DrugTypeType>()
                .Property(e => e.drugTypeTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<DrugTypeType>()
                .Property(e => e.drugTypeTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<DrugTypeType>()
                .Property(e => e.drugTypeTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<EthnicityType>()
                .HasMany(e => e.CodedCrashPersons)
                .WithRequired(e => e.EthnicityType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EthnicityType>()
                .HasMany(e => e.TcrPersons)
                .WithRequired(e => e.EthnicityType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EvidentialBloodTestType>()
                .HasMany(e => e.CodedCrashDrivers)
                .WithRequired(e => e.EvidentialBloodTestType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EvidentialBloodTestType>()
                .HasMany(e => e.TcrDrivers)
                .WithRequired(e => e.EvidentialBloodTestType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EvidentialBreathTestType>()
                .HasMany(e => e.CodedCrashDrivers)
                .WithRequired(e => e.EvidentialBreathTestType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EvidentialBreathTestType>()
                .HasMany(e => e.TcrDrivers)
                .WithRequired(e => e.EvidentialBreathTestType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Exercise>()
                .Property(e => e.exerciseName)
                .IsUnicode(false);

            modelBuilder.Entity<Exercise>()
                .HasMany(e => e.ContributingFactorsInExercises)
                .WithRequired(e => e.Exercise)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Exercise>()
                .HasMany(e => e.MovementCodesInExercises)
                .WithRequired(e => e.Exercise)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Exercise>()
                .HasMany(e => e.UsersInExercises)
                .WithRequired(e => e.Exercise)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExerciseQualifyingCrash>()
                .HasMany(e => e.UsersCompletedCrashInExercises)
                .WithRequired(e => e.ExerciseQualifyingCrash)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GenderType>()
                .HasMany(e => e.CodedCrashPersons)
                .WithRequired(e => e.GenderType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GenderType>()
                .HasMany(e => e.TcrPersons)
                .WithRequired(e => e.GenderType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HintType>()
                .Property(e => e.hintTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<HintType>()
                .Property(e => e.hintTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<HintType>()
                .Property(e => e.hintTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Holiday>()
                .Property(e => e.holidayName)
                .IsUnicode(false);

            modelBuilder.Entity<InjuryCauseType>()
                .Property(e => e.injuryCauseTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<InjuryCauseType>()
                .Property(e => e.injuryCauseTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<InjuryCauseType>()
                .Property(e => e.injuryCauseTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<InjuryCauseType>()
                .HasMany(e => e.CodedCrashPersons)
                .WithRequired(e => e.InjuryCauseType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InjurySeverityType>()
                .HasMany(e => e.CodedCrashPersons)
                .WithRequired(e => e.InjurySeverityType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InjurySeverityType>()
                .HasMany(e => e.TcrPersons)
                .WithRequired(e => e.InjurySeverityType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IntersectionMidblockType>()
                .Property(e => e.intersectionMidblockTypename)
                .IsUnicode(false);

            modelBuilder.Entity<IntersectionMidblockType>()
                .Property(e => e.intersectionMidblockTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<IntersectionMidblockType>()
                .Property(e => e.intersectionMidblockTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<IntersectionMidblockType>()
                .HasMany(e => e.CodedCrashLocations)
                .WithRequired(e => e.IntersectionMidblockType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<JunctionTypeType>()
                .HasMany(e => e.CodedCrashes)
                .WithRequired(e => e.JunctionTypeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<JunctionTypeType>()
                .HasMany(e => e.TcrCrashes)
                .WithRequired(e => e.JunctionTypeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KeywordToCfHelper>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<MovementCodeType>()
                .Property(e => e.movementCodeTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<MovementCodeType>()
                .Property(e => e.movementCodeTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<MovementCodeType>()
                .Property(e => e.movementCodeTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<MovementCodeType>()
                .Property(e => e.displaySequence)
                .IsUnicode(false);

            modelBuilder.Entity<MovementCodeType>()
                .Property(e => e.rsrGroupName)
                .IsUnicode(false);

            modelBuilder.Entity<MovementCodeType>()
                .HasMany(e => e.CodedCrashes)
                .WithRequired(e => e.MovementCodeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MovementCodeType>()
                .HasMany(e => e.MovementCodesInExercises)
                .WithRequired(e => e.MovementCodeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MovementGroupType>()
                .Property(e => e.movementGroupTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<MovementGroupType>()
                .Property(e => e.movementGroupTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<MovementGroupType>()
                .Property(e => e.movementGroupTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<NaturalLightTypeType>()
                .HasMany(e => e.CodedCrashes)
                .WithRequired(e => e.NaturalLightTypeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NaturalLightTypeType>()
                .HasMany(e => e.TcrCrashes)
                .WithRequired(e => e.NaturalLightTypeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OffRoadLocationType>()
                .HasMany(e => e.TcrCrashes)
                .WithRequired(e => e.OffRoadLocationType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OtherPartyType>()
                .Property(e => e.otherPartyTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<OtherPartyType>()
                .Property(e => e.otherPartyTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<OtherPartyType>()
                .Property(e => e.otherPartyTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<OtherPassengerLocationType>()
                .Property(e => e.otherPassengerLocationTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<OtherPassengerLocationType>()
                .Property(e => e.otherPassengerLocationTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<OtherPassengerLocationType>()
                .Property(e => e.otherPassengerLocationTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<PeerReviewSetting>()
                .Property(e => e.reviewName)
                .IsUnicode(false);

            modelBuilder.Entity<PeerReviewSetting>()
                .HasMany(e => e.UserProfiles)
                .WithRequired(e => e.PeerReviewSetting)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PrimarySurfaceConditionType>()
                .HasMany(e => e.CodedCrashes)
                .WithRequired(e => e.PrimarySurfaceConditionType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PrimarySurfaceConditionType>()
                .HasMany(e => e.TcrCrashes)
                .WithRequired(e => e.PrimarySurfaceConditionType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RailCrossingTypeType>()
                .Property(e => e.railCrossingTypeTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<RailCrossingTypeType>()
                .Property(e => e.railCrossingTypeTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<RailCrossingTypeType>()
                .Property(e => e.railCrossingTypeTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<RailCrossingTypeType>()
                .HasMany(e => e.CodedCrashes)
                .WithRequired(e => e.RailCrossingTypeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RailCrossingTypeType>()
                .HasMany(e => e.TcrCrashes)
                .WithRequired(e => e.RailCrossingTypeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ReasonForSpeedTooFastType>()
                .Property(e => e.reasonForSpeedTooFastTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<ReasonForSpeedTooFastType>()
                .Property(e => e.reasonForSpeedTooFastTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<ReasonForSpeedTooFastType>()
                .Property(e => e.reasonForSpeedTooFastTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<ReasonLicenseBreachedType>()
                .Property(e => e.reasonLicenseBreachedTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<ReasonLicenseBreachedType>()
                .Property(e => e.reasonLicenseBreachedTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<ReasonLicenseBreachedType>()
                .Property(e => e.reasonLicenseBreachedTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<RecordedLocationTypeType>()
                .HasMany(e => e.CodedCrashLocations)
                .WithRequired(e => e.RecordedLocationTypeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RecordedLocationTypeType>()
                .HasMany(e => e.TcrLocations)
                .WithRequired(e => e.RecordedLocationTypeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RejectionCategoryType>()
                .Property(e => e.rejectionCategoryTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<RestraintUsedType>()
                .HasMany(e => e.CodedCrashDrivers)
                .WithRequired(e => e.RestraintUsedType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RestraintUsedType>()
                .HasMany(e => e.CodedCrashPassengers)
                .WithRequired(e => e.RestraintUsedType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RestraintUsedType>()
                .HasMany(e => e.TcrDrivers)
                .WithRequired(e => e.RestraintUsedType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RestraintUsedType>()
                .HasMany(e => e.TcrPassengers)
                .WithRequired(e => e.RestraintUsedType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoadCurvatureType>()
                .HasMany(e => e.CodedCrashes)
                .WithRequired(e => e.RoadCurvatureType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoadCurvatureType>()
                .HasMany(e => e.TcrCrashes)
                .WithRequired(e => e.RoadCurvatureType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoadFeatureType>()
                .HasMany(e => e.TcrCrashes)
                .WithRequired(e => e.RoadFeatureType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoadGradientType>()
                .HasMany(e => e.CodedCrashes)
                .WithRequired(e => e.RoadGradientType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoadGradientType>()
                .HasMany(e => e.TcrCrashes)
                .WithRequired(e => e.RoadGradientType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoadMarkingTypeType>()
                .HasMany(e => e.CodedCrashRoadMarkings)
                .WithRequired(e => e.RoadMarkingTypeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoadMarkingTypeType>()
                .HasMany(e => e.TcrRoadMarkings)
                .WithRequired(e => e.RoadMarkingTypeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoadSurfaceTypeType>()
                .HasMany(e => e.CodedCrashes)
                .WithRequired(e => e.RoadSurfaceTypeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoadSurfaceTypeType>()
                .HasMany(e => e.TcrCrashes)
                .WithRequired(e => e.RoadSurfaceTypeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoadTypeType>()
                .HasMany(e => e.CodedCrashes)
                .WithRequired(e => e.RoadTypeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoadTypeType>()
                .HasMany(e => e.TcrCrashes)
                .WithRequired(e => e.RoadTypeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoadUserTypeType>()
                .HasMany(e => e.CodedCrashPersons)
                .WithRequired(e => e.RoadUserTypeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoadUserTypeType>()
                .HasMany(e => e.TcrPersons)
                .WithRequired(e => e.RoadUserTypeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SeatLocationPositionType>()
                .Property(e => e.seatLocationPositionTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<SeatLocationPositionType>()
                .Property(e => e.seatLocationPositionTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<SeatLocationPositionType>()
                .Property(e => e.seatLocationPositionTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<SeatLocationRowType>()
                .Property(e => e.seatLocationRowTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<SeatLocationRowType>()
                .Property(e => e.seatLocationRowTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<SeatLocationRowType>()
                .Property(e => e.seatLocationRowTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<SocialCost>()
                .Property(e => e.averageUrbanCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SocialCost>()
                .Property(e => e.averageRuralCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SocialCost>()
                .Property(e => e.fatalUrbanCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SocialCost>()
                .Property(e => e.fatalRuralCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SocialCost>()
                .Property(e => e.seriousUrbanCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SocialCost>()
                .Property(e => e.seriousRuralCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SocialCost>()
                .Property(e => e.minorUrbanCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SocialCost>()
                .Property(e => e.minorRuralCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SocialCost>()
                .Property(e => e.nonInjuryUrbanCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SocialCost>()
                .Property(e => e.nonInjuryRuralCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SpecialPurposeLaneType>()
                .Property(e => e.specialPurposeLaneTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<SpecialPurposeLaneType>()
                .Property(e => e.specialPurposeLaneTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<SpecialPurposeLaneType>()
                .Property(e => e.specialPurposeLaneTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<SpecialPurposeLaneType>()
                .HasMany(e => e.CodedCrashes)
                .WithRequired(e => e.SpecialPurposeLaneType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SpecialPurposeLaneType>()
                .HasMany(e => e.TcrCrashes)
                .WithRequired(e => e.SpecialPurposeLaneType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StreetLightStatusType>()
                .HasMany(e => e.CodedCrashes)
                .WithRequired(e => e.StreetLightStatusType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StreetLightStatusType>()
                .HasMany(e => e.TcrCrashes)
                .WithRequired(e => e.StreetLightStatusType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StruckObjectType>()
                .Property(e => e.struckObjectTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<StruckObjectType>()
                .Property(e => e.struckObjectTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<StruckObjectType>()
                .Property(e => e.struckObjectTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<StruckObjectTypeType>()
                .Property(e => e.struckObjectTypeTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<StruckObjectTypeType>()
                .Property(e => e.struckObjectTypeTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<StruckObjectTypeType>()
                .Property(e => e.struckObjectTypeTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<SupplementarySafetyDeviceType>()
                .Property(e => e.supplementarySafetyDeviceTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<SupplementarySafetyDeviceType>()
                .Property(e => e.supplementarySafetyDeviceTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<SupplementarySafetyDeviceType>()
                .Property(e => e.supplementarySafetyDeviceTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<SupplementarySafetyDeviceType>()
                .HasMany(e => e.CodedCrashDriverSupplementarySafetyDeviceUseds)
                .WithRequired(e => e.SupplementarySafetyDeviceType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SupplementarySafetyDeviceType>()
                .HasMany(e => e.CodedCrashPassengerSupplementarySafetyDeviceUseds)
                .WithRequired(e => e.SupplementarySafetyDeviceType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SupplementarySafetyDeviceType>()
                .HasMany(e => e.TcrDriverSupplementarySafetyDeviceUseds)
                .WithRequired(e => e.SupplementarySafetyDeviceType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SupplementarySafetyDeviceType>()
                .HasMany(e => e.TcrPassengerSupplementarySafetyDeviceUseds)
                .WithRequired(e => e.SupplementarySafetyDeviceType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SystemConfiguration>()
                .Property(e => e.configurationName)
                .IsUnicode(false);

            modelBuilder.Entity<TcrComment>()
                .Property(e => e.tcrComment1)
                .IsUnicode(false);

            modelBuilder.Entity<TcrComment>()
                .Property(e => e.tcrFieldName)
                .IsUnicode(false);

            modelBuilder.Entity<TcrComment>()
                .Property(e => e.tcrEnclosingType)
                .IsUnicode(false);

            modelBuilder.Entity<TcrCrash>()
                .Property(e => e.objectVersion)
                .IsFixedLength();

            modelBuilder.Entity<TcrCrash>()
                .HasMany(e => e.CodedCrashes)
                .WithRequired(e => e.TcrCrash)
                .HasForeignKey(e => new { e.tcrCrashIdentifierid, e.tcrTimestamp })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TcrCrash>()
                .HasMany(e => e.TcrAdditionalRoadSurfaceConditions)
                .WithRequired(e => e.TcrCrash)
                .HasForeignKey(e => new { e.tcrCrashIdentifierid, e.timestamp })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TcrCrash>()
                .HasMany(e => e.TcrBarriers)
                .WithRequired(e => e.TcrCrash)
                .HasForeignKey(e => new { e.tcrCrashIdentifierid, e.timestamp })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TcrCrash>()
                .HasMany(e => e.TcrComments)
                .WithRequired(e => e.TcrCrash)
                .HasForeignKey(e => new { e.tcrCrashIdentifierid, e.timestamp })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TcrCrash>()
                .HasMany(e => e.TcrCrashDiagrams)
                .WithRequired(e => e.TcrCrash)
                .HasForeignKey(e => new { e.tcrCrashIdentifierid, e.timestamp })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TcrCrash>()
                .HasMany(e => e.TcrLocations)
                .WithRequired(e => e.TcrCrash)
                .HasForeignKey(e => new { e.tcrCrashIdentifierid, e.timestamp })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TcrCrash>()
                .HasMany(e => e.TcrPersons)
                .WithRequired(e => e.TcrCrash)
                .HasForeignKey(e => new { e.tcrCrashIdentifierid, e.timestamp })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TcrCrash>()
                .HasMany(e => e.TcrProcessingStatus)
                .WithRequired(e => e.TcrCrash)
                .HasForeignKey(e => new { e.tcrCrashIdentifierid, e.timestamp })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TcrCrash>()
                .HasMany(e => e.TcrRoadMarkings)
                .WithRequired(e => e.TcrCrash)
                .HasForeignKey(e => new { e.tcrCrashIdentifierid, e.timestamp })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TcrCrash>()
                .HasMany(e => e.TcrTowedVehicles)
                .WithRequired(e => e.TcrCrash)
                .HasForeignKey(e => new { e.tcrCrashIdentifierid, e.timestamp })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TcrCrash>()
                .HasMany(e => e.TcrVehicles)
                .WithRequired(e => e.TcrCrash)
                .HasForeignKey(e => new { e.tcrCrashIdentifierid, e.timestamp })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TcrCrashIdentifier>()
                .Property(e => e.computedCrashIdentifier)
                .IsUnicode(false);

            modelBuilder.Entity<TcrDriver>()
                .HasMany(e => e.TcrDriverSupplementarySafetyDeviceUseds)
                .WithRequired(e => e.TcrDriver)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TcrDriverSupplementarySafetyDeviceUsed>()
                .Property(e => e.otherSupplementaryDevice)
                .IsUnicode(false);

            modelBuilder.Entity<TcrPassenger>()
                .HasMany(e => e.TcrPassengerSupplementarySafetyDeviceUseds)
                .WithRequired(e => e.TcrPassenger)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TcrPassengerSupplementarySafetyDeviceUsed>()
                .Property(e => e.otherSupplementaryDevice)
                .IsUnicode(false);

            modelBuilder.Entity<TcrPerson>()
                .HasMany(e => e.TcrDrivers)
                .WithRequired(e => e.TcrPerson)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TcrPerson>()
                .HasMany(e => e.TcrPassengers)
                .WithRequired(e => e.TcrPerson)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TcrPoliceStatusType>()
                .Property(e => e.tcrpoliceStatusTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<TcrPoliceStatusType>()
                .Property(e => e.tcrpoliceStatusTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<TcrPoliceStatusType>()
                .Property(e => e.tcrpoliceStatusTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<TcrPoliceStatusType>()
                .HasMany(e => e.TcrCrashes)
                .WithRequired(e => e.TcrPoliceStatusType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TcrStatusType>()
                .Property(e => e.tcrStatusTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<TcrStatusType>()
                .Property(e => e.tcrStatusTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<TcrStatusType>()
                .Property(e => e.tcrStatusTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<TcrStatusType>()
                .HasMany(e => e.TcrCrashes)
                .WithRequired(e => e.TcrStatusType)
                .HasForeignKey(e => e.latestProcessingStatusTypeid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TcrStatusType>()
                .HasMany(e => e.TcrProcessingStatus)
                .WithRequired(e => e.TcrStatusType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TcrTowedVehicle>()
                .Property(e => e.primaryColour)
                .IsUnicode(false);

            modelBuilder.Entity<TcrTowedVehicle>()
                .HasMany(e => e.TcrTowedVehicle1)
                .WithOptional(e => e.TcrTowedVehicle2)
                .HasForeignKey(e => e.towedByTowedVehicleid);

            modelBuilder.Entity<TcrVehicle>()
                .Property(e => e.vehicleUsageTypeOtherDescription)
                .IsUnicode(false);

            modelBuilder.Entity<TcrVehicle>()
                .Property(e => e.primaryColour)
                .IsUnicode(false);

            modelBuilder.Entity<TcrVehicle>()
                .HasMany(e => e.TcrDrivers)
                .WithRequired(e => e.TcrVehicle)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TcrVehicle>()
                .HasMany(e => e.TcrPassengers)
                .WithRequired(e => e.TcrVehicle)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TcrVehicle>()
                .HasMany(e => e.TcrTowedVehicles)
                .WithOptional(e => e.TcrVehicle)
                .HasForeignKey(e => e.towedByVehicleid);

            modelBuilder.Entity<TcrVehicle>()
                .HasMany(e => e.TcrVehicleDevices)
                .WithRequired(e => e.TcrVehicle)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TcrVehicle>()
                .HasMany(e => e.TcrVehiclePermits)
                .WithRequired(e => e.TcrVehicle)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TcrVehiclePermit>()
                .Property(e => e.vehiclePermitNumber)
                .IsUnicode(false);

            modelBuilder.Entity<TowedVehicleTypeType>()
                .HasMany(e => e.CodedCrashTowedVehicles)
                .WithRequired(e => e.TowedVehicleTypeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TowedVehicleTypeType>()
                .HasMany(e => e.TcrTowedVehicles)
                .WithRequired(e => e.TowedVehicleTypeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TowedVehicleTypeType>()
                .HasMany(e => e.TcrVehicles)
                .WithRequired(e => e.TowedVehicleTypeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TrafficControlType>()
                .HasMany(e => e.CodedCrashes)
                .WithRequired(e => e.TrafficControlType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TrafficControlType>()
                .HasMany(e => e.TcrCrashes)
                .WithRequired(e => e.TrafficControlType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserProfile>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<UserProfile>()
                .Property(e => e.userReportName)
                .IsUnicode(false);

            modelBuilder.Entity<UserProfile>()
                .HasMany(e => e.ArbitrationControls)
                .WithOptional(e => e.UserProfile)
                .HasForeignKey(e => e.arbitratedByid);

            modelBuilder.Entity<UserProfile>()
                .HasMany(e => e.CodedCrashes)
                .WithOptional(e => e.UserProfile)
                .HasForeignKey(e => e.lastModifiedByid);

            modelBuilder.Entity<UserProfile>()
                .HasMany(e => e.CodedCrashes1)
                .WithRequired(e => e.UserProfile1)
                .HasForeignKey(e => e.createdBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserProfile>()
                .HasMany(e => e.CodedCrashes2)
                .WithOptional(e => e.UserProfile2)
                .HasForeignKey(e => e.arbitratedBy);

            modelBuilder.Entity<UserProfile>()
                .HasMany(e => e.CodedCrashProcessingStatus)
                .WithRequired(e => e.UserProfile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserProfile>()
                .HasMany(e => e.TcrCrashes)
                .WithOptional(e => e.UserProfile)
                .HasForeignKey(e => e.lastModifiedByid);

            modelBuilder.Entity<UserProfile>()
                .HasMany(e => e.TcrProcessingStatus)
                .WithRequired(e => e.UserProfile)
                .HasForeignKey(e => e.statusChangedByUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserProfile>()
                .HasMany(e => e.UsersCompletedCrashInExercises)
                .WithRequired(e => e.UserProfile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VehicleDeviceType>()
                .Property(e => e.vehicleDeviceTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleDeviceType>()
                .Property(e => e.vehicleDeviceTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleDeviceType>()
                .Property(e => e.vehicleDeviceTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleDeviceType>()
                .HasMany(e => e.TcrVehicleDevices)
                .WithRequired(e => e.VehicleDeviceType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VehicleLoadType>()
                .Property(e => e.vehicleLoadTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleLoadType>()
                .Property(e => e.vehicleLoadTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleLoadType>()
                .Property(e => e.vehicleLoadTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleLoadType>()
                .HasMany(e => e.CodedCrashVehicles)
                .WithRequired(e => e.VehicleLoadType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VehicleLoadType>()
                .HasMany(e => e.TcrVehicles)
                .WithRequired(e => e.VehicleLoadType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VehiclePermitTypeType>()
                .Property(e => e.vehiclePermitTypeTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<VehiclePermitTypeType>()
                .Property(e => e.vehiclePermitTypeTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<VehiclePermitTypeType>()
                .Property(e => e.vehiclePermitTypeTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<VehiclePermitTypeType>()
                .HasMany(e => e.CodedCrashVehiclePermits)
                .WithRequired(e => e.VehiclePermitTypeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VehiclePermitTypeType>()
                .HasMany(e => e.TcrVehiclePermits)
                .WithRequired(e => e.VehiclePermitTypeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VehicleStateType>()
                .HasMany(e => e.CodedCrashVehicles)
                .WithRequired(e => e.VehicleStateType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VehicleStateType>()
                .HasMany(e => e.TcrVehicles)
                .WithRequired(e => e.VehicleStateType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VehicleTypeType>()
                .Property(e => e.simplifedVehicleTypeTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleTypeType>()
                .HasMany(e => e.CodedCrashVehicles)
                .WithRequired(e => e.VehicleTypeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VehicleTypeType>()
                .HasMany(e => e.TcrVehicles)
                .WithRequired(e => e.VehicleTypeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VehicleUsageType>()
                .Property(e => e.vehicleUsageTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUsageType>()
                .Property(e => e.vehicleUsageTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUsageType>()
                .Property(e => e.vehicleUsageTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<VehicleUsageType>()
                .HasMany(e => e.CodedCrashVehicles)
                .WithRequired(e => e.VehicleUsageType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VehicleUsageType>()
                .HasMany(e => e.TcrVehicles)
                .WithRequired(e => e.VehicleUsageType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WeatherConditionAType>()
                .HasMany(e => e.CodedCrashes)
                .WithRequired(e => e.WeatherConditionAType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WeatherConditionAType>()
                .HasMany(e => e.TcrCrashes)
                .WithRequired(e => e.WeatherConditionAType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WeatherConditionBType>()
                .HasMany(e => e.CodedCrashes)
                .WithRequired(e => e.WeatherConditionBType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WeatherConditionBType>()
                .HasMany(e => e.TcrCrashes)
                .WithRequired(e => e.WeatherConditionBType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.CodedCrashes)
                .WithRequired(e => e.YesNoUnknownType)
                .HasForeignKey(e => e.cviuAttendedCrashYesNoUnknownTypeid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.CodedCrashDrivers)
                .WithOptional(e => e.YesNoUnknownType)
                .HasForeignKey(e => e.driverLocalYesNoUnknownTypeid);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.CodedCrashDrivers1)
                .WithRequired(e => e.YesNoUnknownType1)
                .HasForeignKey(e => e.licenseConditionsMetYesNoUnknownTypeid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.CodedCrashLocations)
                .WithOptional(e => e.YesNoUnknownType)
                .HasForeignKey(e => e.isStateHighwayYesNoUnknownTypeid);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.CodedCrashPersons)
                .WithRequired(e => e.YesNoUnknownType)
                .HasForeignKey(e => e.hospitalisedYesNoUnknownTypeid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.CodedCrashPersons1)
                .WithRequired(e => e.YesNoUnknownType1)
                .HasForeignKey(e => e.fatalityPreventableIfSafetyEquipmentUsedYesNoUnknownTypeid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.CodedCrashTowedVehicles)
                .WithRequired(e => e.YesNoUnknownType)
                .HasForeignKey(e => e.hasWofCofYesNoUnknownTypeid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.CodedCrashTowedVehicles1)
                .WithRequired(e => e.YesNoUnknownType1)
                .HasForeignKey(e => e.hasNoRegistrationPlatesYesNoUnknownTypeid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.CodedCrashTowedVehicles2)
                .WithRequired(e => e.YesNoUnknownType2)
                .HasForeignKey(e => e.hasUnderunProtectionYesNoUnknownTypeid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.CodedCrashTowedVehicles3)
                .WithRequired(e => e.YesNoUnknownType3)
                .HasForeignKey(e => e.wasNoUnderRunProtectionContributorYesNoUnknownTypeid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.CodedCrashTowedVehicles4)
                .WithRequired(e => e.YesNoUnknownType4)
                .HasForeignKey(e => e.isLoadSecuredYesNoUnknownTypeid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.CodedCrashTowedVehicles5)
                .WithRequired(e => e.YesNoUnknownType5)
                .HasForeignKey(e => e.hasModificationsYesNoUnknownTypeid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.CodedCrashVehicles)
                .WithOptional(e => e.YesNoUnknownType)
                .HasForeignKey(e => e.vehicleCrossedCentrelineTypeid);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.CodedCrashVehicles1)
                .WithRequired(e => e.YesNoUnknownType1)
                .HasForeignKey(e => e.hasWofCofYesNoUnknownTypeid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.CodedCrashVehicles2)
                .WithRequired(e => e.YesNoUnknownType2)
                .HasForeignKey(e => e.hasNoRegistrationPlatesYesNoUnknownTypeid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.CodedCrashVehicles3)
                .WithRequired(e => e.YesNoUnknownType3)
                .HasForeignKey(e => e.crashRiskReducedByAdditionalReflectorYesNoUnknownTypeid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.CodedCrashVehicles4)
                .WithRequired(e => e.YesNoUnknownType4)
                .HasForeignKey(e => e.hasUnderunProtectionYesNoUnknownTypeid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.CodedCrashVehicles5)
                .WithRequired(e => e.YesNoUnknownType5)
                .HasForeignKey(e => e.wasNoUnderRunProtectionContributorYesNoUnknownTypeid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.CodedCrashVehicles6)
                .WithRequired(e => e.YesNoUnknownType6)
                .HasForeignKey(e => e.isLoadSecuredYesNoUnknownTypeid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.CodedCrashVehicles7)
                .WithRequired(e => e.YesNoUnknownType7)
                .HasForeignKey(e => e.wasTooFastForConditionsYesNoUnknownTypeid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.CodedCrashVehicles8)
                .WithRequired(e => e.YesNoUnknownType8)
                .HasForeignKey(e => e.hasModificationsYesNoUnknownTypeid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.CodedCrashVehicles9)
                .WithRequired(e => e.YesNoUnknownType9)
                .HasForeignKey(e => e.isVehicleFaultyYesNoUnknownTypeid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.CodedCrashVehicles10)
                .WithRequired(e => e.YesNoUnknownType10)
                .HasForeignKey(e => e.isOverDimensionYesNoUnknownTypeid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.CodedCrashVehiclePermits)
                .WithRequired(e => e.YesNoUnknownType)
                .HasForeignKey(e => e.isCompliantYesNoUnknownTypeid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.TcrDrivers)
                .WithRequired(e => e.YesNoUnknownType)
                .HasForeignKey(e => e.licenseConditionsMetYesNoUnknownTypeid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.TcrPersons)
                .WithRequired(e => e.YesNoUnknownType)
                .HasForeignKey(e => e.hospitalisedYesNoUnknownTypeid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.TcrTowedVehicles)
                .WithRequired(e => e.YesNoUnknownType)
                .HasForeignKey(e => e.hasWofCofYesNoUnknownTypeid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.TcrTowedVehicles1)
                .WithRequired(e => e.YesNoUnknownType1)
                .HasForeignKey(e => e.hasNoRegistrationPlatesYesNoUnknownTypeid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.TcrTowedVehicles2)
                .WithRequired(e => e.YesNoUnknownType2)
                .HasForeignKey(e => e.hasUnderunProtectionYesNoUnknownTypeid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.TcrTowedVehicles3)
                .WithRequired(e => e.YesNoUnknownType3)
                .HasForeignKey(e => e.wasNoUnderRunProtectionContributorYesNoUnknownTypeid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.TcrTowedVehicles4)
                .WithRequired(e => e.YesNoUnknownType4)
                .HasForeignKey(e => e.isLoadSecuredYesNoUnknownTypeid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.TcrVehicles)
                .WithRequired(e => e.YesNoUnknownType)
                .HasForeignKey(e => e.hasNoRegistrationPlatesYesNoUnknownTypeid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.TcrVehicles1)
                .WithRequired(e => e.YesNoUnknownType1)
                .HasForeignKey(e => e.crashRiskReducedByAdditionalReflectorYesNoUnknownTypeid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.TcrVehicles2)
                .WithRequired(e => e.YesNoUnknownType2)
                .HasForeignKey(e => e.hasUnderunProtectionYesNoUnknownTypeid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.TcrVehicles3)
                .WithRequired(e => e.YesNoUnknownType3)
                .HasForeignKey(e => e.wasNoUnderRunProtectionContributorYesNoUnknownTypeid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.TcrVehicles4)
                .WithRequired(e => e.YesNoUnknownType4)
                .HasForeignKey(e => e.isLoadSecuredYesNoUnknownTypeid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.TcrVehicles5)
                .WithRequired(e => e.YesNoUnknownType5)
                .HasForeignKey(e => e.wasTooFastForConditionsYesNoUnknownTypeid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.TcrVehicles6)
                .WithRequired(e => e.YesNoUnknownType6)
                .HasForeignKey(e => e.hasWofCofYesNoUnknownTypeid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.TcrVehicles7)
                .WithRequired(e => e.YesNoUnknownType7)
                .HasForeignKey(e => e.isOverDimensionYesNoUnknownTypeid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YesNoUnknownType>()
                .HasMany(e => e.TcrVehiclePermits)
                .WithRequired(e => e.YesNoUnknownType)
                .HasForeignKey(e => e.isCompliantYesNoUnknownTypeid)
                .WillCascadeOnDelete(false);
        }
    }
}
