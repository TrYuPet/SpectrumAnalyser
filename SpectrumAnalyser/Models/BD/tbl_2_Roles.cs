namespace SpectrumAnalyser.Models.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_2_Roles
    {
        public tbl_2_Roles()
        {
            tbl_1_User = new HashSet<tbl_1_User>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoleId { get; set; }

        [StringLength(50)]
        public string RoleName { get; set; }

        public virtual ICollection<tbl_1_User> tbl_1_User { get; set; }
    }
}
