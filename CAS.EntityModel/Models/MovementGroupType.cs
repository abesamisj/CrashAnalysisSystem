namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MovementGroupType")]
    public partial class MovementGroupType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MovementGroupType()
        {
            MovementCodeTypes = new HashSet<MovementCodeType>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int movementGroupTypeid { get; set; }

        [StringLength(50)]
        public string movementGroupTypeName { get; set; }

        [StringLength(100)]
        public string movementGroupTypeCode { get; set; }

        [StringLength(1000)]
        public string movementGroupTypeDescription { get; set; }

        public DateTime? whenEffective { get; set; }

        public DateTime? whenIneffective { get; set; }

        public DateTime? whenWritten { get; set; }

        public int? displaySequence { get; set; }

        public bool? isNullPlaceholder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MovementCodeType> MovementCodeTypes { get; set; }
    }
}
