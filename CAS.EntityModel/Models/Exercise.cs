namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Exercise")]
    public partial class Exercise
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Exercise()
        {
            ContributingFactorsInExercises = new HashSet<ContributingFactorsInExercise>();
            ExerciseQualifyingCrashes = new HashSet<ExerciseQualifyingCrash>();
            MovementCodesInExercises = new HashSet<MovementCodesInExercise>();
            TcrCrashes = new HashSet<TcrCrash>();
            UsersInExercises = new HashSet<UsersInExercise>();
        }

        public int exerciseid { get; set; }

        [StringLength(250)]
        public string exerciseName { get; set; }

        public bool exerciseActivated { get; set; }

        public DateTime? startDateOfExercise { get; set; }

        public DateTime? endDateOfExercise { get; set; }

        public int? processingGap { get; set; }

        public int? maxNumberOfCrashes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContributingFactorsInExercise> ContributingFactorsInExercises { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExerciseQualifyingCrash> ExerciseQualifyingCrashes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MovementCodesInExercise> MovementCodesInExercises { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TcrCrash> TcrCrashes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersInExercise> UsersInExercises { get; set; }
    }
}
