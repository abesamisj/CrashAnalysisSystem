namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UsersInExercise")]
    public partial class UsersInExercise
    {
        public int usersInExerciseid { get; set; }

        public int exerciseid { get; set; }

        public int? currentGapCount { get; set; }

        public int? userProfileid { get; set; }

        public virtual Exercise Exercise { get; set; }

        public virtual UserProfile UserProfile { get; set; }
    }
}
