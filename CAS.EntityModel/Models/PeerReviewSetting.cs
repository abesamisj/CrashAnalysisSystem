namespace CAS.EntityModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PeerReviewSetting")]
    public partial class PeerReviewSetting
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PeerReviewSetting()
        {
            UserProfiles = new HashSet<UserProfile>();
        }

        public int peerReviewSettingid { get; set; }

        public double? reviewRatioForFatals { get; set; }

        public double? reviewRatioForSevere { get; set; }

        public double? reviewRatioForModerate { get; set; }

        public double? reviewRatioForNoInjury { get; set; }

        [StringLength(50)]
        public string reviewName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserProfile> UserProfiles { get; set; }
    }
}
