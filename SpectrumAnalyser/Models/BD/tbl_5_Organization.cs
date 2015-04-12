namespace SpectrumAnalyser.Models.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_5_Organization
    {
        public tbl_5_Organization()
        {
            tbl_1_User = new HashSet<tbl_1_User>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrganizationId { get; set; }

        [StringLength(100)]
        public string OrganizationStatus { get; set; }

        [StringLength(100)]
        public string OrganizationType { get; set; }

        [StringLength(256)]
        public string OrganizationDescription { get; set; }

        [StringLength(100)]
        public string OrganizationAdress { get; set; }

        [StringLength(50)]
        public string OrganizationEmail { get; set; }

        [StringLength(20)]
        public string OrganizationPhoneNumbe { get; set; }

        public virtual ICollection<tbl_1_User> tbl_1_User { get; set; }
    }
}
