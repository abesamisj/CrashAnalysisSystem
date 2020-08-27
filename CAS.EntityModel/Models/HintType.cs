namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HintType")]
    public partial class HintType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HintType()
        {
            ContributingFactorHints = new HashSet<ContributingFactorHint>();
            HintBreaches = new HashSet<HintBreach>();
            MovementCodeHints = new HashSet<MovementCodeHint>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int hintTypeid { get; set; }

        [StringLength(50)]
        public string hintTypeName { get; set; }

        [StringLength(100)]
        public string hintTypeCode { get; set; }

        [StringLength(1000)]
        public string hintTypeDescription { get; set; }

        public DateTime? whenEffective { get; set; }

        public DateTime? whenIneffective { get; set; }

        public DateTime? whenWritten { get; set; }

        public int? displaySequence { get; set; }

        [StringLength(2048)]
        public string expression { get; set; }

        public int? expressionRoot { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContributingFactorHint> ContributingFactorHints { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HintBreach> HintBreaches { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MovementCodeHint> MovementCodeHints { get; set; }
    }
}
