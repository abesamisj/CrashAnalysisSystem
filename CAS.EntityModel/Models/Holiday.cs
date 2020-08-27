namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Holiday
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Holiday()
        {
            CodedCrashes = new HashSet<CodedCrash>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int holidayInstanceid { get; set; }

        [StringLength(50)]
        public string holidayName { get; set; }

        public DateTime? holidayPeriodStart { get; set; }

        public DateTime? holidayPeriodFinish { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodedCrash> CodedCrashes { get; set; }
    }
}
