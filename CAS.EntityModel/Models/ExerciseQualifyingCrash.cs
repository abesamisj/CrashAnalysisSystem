namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExerciseQualifyingCrash")]
    public partial class ExerciseQualifyingCrash
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExerciseQualifyingCrash()
        {
            UsersCompletedCrashInExercises = new HashSet<UsersCompletedCrashInExercise>();
        }

        public int exerciseQualifyingCrashid { get; set; }

        public int? exerciseid { get; set; }

        public int? codedCrashid { get; set; }

        public virtual CodedCrash CodedCrash { get; set; }

        public virtual Exercise Exercise { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersCompletedCrashInExercise> UsersCompletedCrashInExercises { get; set; }
    }
}
