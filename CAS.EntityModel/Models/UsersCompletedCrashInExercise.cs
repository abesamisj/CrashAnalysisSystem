namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UsersCompletedCrashInExercise")]
    public partial class UsersCompletedCrashInExercise
    {
        public int usersCompletedCrashInExerciseid { get; set; }

        public int userProfileid { get; set; }

        public int exerciseQualifyingCrashid { get; set; }

        public virtual ExerciseQualifyingCrash ExerciseQualifyingCrash { get; set; }

        public virtual UserProfile UserProfile { get; set; }
    }
}
