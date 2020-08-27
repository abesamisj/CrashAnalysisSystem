namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MovementCodesInExercise")]
    public partial class MovementCodesInExercise
    {
        public int movementCodesInExerciseid { get; set; }

        public int exerciseid { get; set; }

        public int movementCodeTypeid { get; set; }

        public virtual Exercise Exercise { get; set; }

        public virtual MovementCodeType MovementCodeType { get; set; }
    }
}
