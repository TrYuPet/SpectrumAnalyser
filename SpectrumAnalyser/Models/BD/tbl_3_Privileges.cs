namespace SpectrumAnalyser.Models.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_3_Privileges
    {
        public tbl_3_Privileges()
        {
            tbl_1_User = new HashSet<tbl_1_User>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PrivilegeId { get; set; }

        public int? Privilege { get; set; }

        [StringLength(256)]
        public string PrivilegeDescription { get; set; }

        public virtual ICollection<tbl_1_User> tbl_1_User { get; set; }
    }
}
