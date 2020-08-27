namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MovementCodeType")]
    public partial class MovementCodeType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MovementCodeType()
        {
            CodedCrashes = new HashSet<CodedCrash>();
            MovementCodeHints = new HashSet<MovementCodeHint>();
            MovementCodesInExercises = new HashSet<MovementCodesInExercise>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int movementCodeTypeid { get; set; }

        [StringLength(50)]
        public string movementCodeTypeName { get; set; }

        [StringLength(100)]
        public string movementCodeTypeCode { get; set; }

        [StringLength(1000)]
        public string movementCodeTypeDescription { get; set; }

        public DateTime? whenEffective { get; set; }

        public DateTime? whenIneffective { get; set; }

        public DateTime? whenWritten { get; set; }

        [StringLength(50)]
        public string displaySequence { get; set; }

        public int? movementGroupTypeid { get; set; }

        [StringLength(50)]
        public string rsrGroupName { get; set; }

        public byte[] icon { get; set; }

        public bool? isNullPlaceholder { get; set; }

        public byte[] invertIcon { get; set; }

        public byte[] fullIcon { get; set; }

        public byte[] fullInvertIcon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrash> CodedCrashes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MovementCodeHint> MovementCodeHints { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MovementCodesInExercise> MovementCodesInExercises { get; set; }

        public virtual MovementGroupType MovementGroupType { get; set; }
    }
}
