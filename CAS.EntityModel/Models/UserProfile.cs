namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserProfile")]
    public partial class UserProfile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserProfile()
        {
            ArbitrationControls = new HashSet<ArbitrationControl>();
            CodedCrashes = new HashSet<CodedCrash>();
            CodedCrashes1 = new HashSet<CodedCrash>();
            CodedCrashes2 = new HashSet<CodedCrash>();
            CodedCrashProcessingStatus = new HashSet<CodedCrashProcessingStatu>();
            TcrCrashes = new HashSet<TcrCrash>();
            TcrProcessingStatus = new HashSet<TcrProcessingStatu>();
            UsersCompletedCrashInExercises = new HashSet<UsersCompletedCrashInExercise>();
            UsersInExercises = new HashSet<UsersInExercise>();
        }

        public int userProfileid { get; set; }

        [StringLength(100)]
        public string username { get; set; }

        public string uiPreferences { get; set; }

        public int peerReviewSettingid { get; set; }

        public int codingQueuePrioritySchemeTypeid { get; set; }

        public int? userCategory { get; set; }

        public bool inactiveUser { get; set; }

        public int? perDayKPI { get; set; }

        public bool isServiceAccount { get; set; }

        public bool isArbitrator { get; set; }

        [StringLength(100)]
        public string userReportName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArbitrationControl> ArbitrationControls { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrash> CodedCrashes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrash> CodedCrashes1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrash> CodedCrashes2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrashProcessingStatu> CodedCrashProcessingStatus { get; set; }

        public virtual CodingQueuePrioritySchemeType CodingQueuePrioritySchemeType { get; set; }

        public virtual PeerReviewSetting PeerReviewSetting { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrCrash> TcrCrashes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrProcessingStatu> TcrProcessingStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersCompletedCrashInExercise> UsersCompletedCrashInExercises { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersInExercise> UsersInExercises { get; set; }
    }
}
