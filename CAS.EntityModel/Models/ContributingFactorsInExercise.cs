namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContributingFactorsInExercise")]
    public partial class ContributingFactorsInExercise
    {
        public int contributingFactorsInExerciseid { get; set; }

        public int exerciseid { get; set; }

        public int contributingFactorTypeid { get; set; }

        public virtual ContributingFactorType ContributingFactorType { get; set; }

        public virtual Exercise Exercise { get; set; }
    }
}
