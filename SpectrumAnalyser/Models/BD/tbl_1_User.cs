namespace SpectrumAnalyser.Models.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_1_User
    {
        public tbl_1_User()
        {
            tbl_28_Works_of_Art_objects = new HashSet<tbl_28_Works_of_Art_objects>();
            tbl_29_Icons_objects = new HashSet<tbl_29_Icons_objects>();
            tbl_32_PlotFocus = new HashSet<tbl_32_PlotFocus>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        public int OrganizationId { get; set; }

        public int RoleId { get; set; }

        public int PrivilegeId { get; set; }

        public int CityId { get; set; }

        [StringLength(100)]
        public string UserFirstName { get; set; }

        [StringLength(100)]
        public string UserLastName { get; set; }

        [StringLength(100)]
        public string UserMiddleName { get; set; }

        [StringLength(50)]
        public string UserEmail { get; set; }

        [StringLength(20)]
        public string UserPhoneNumber { get; set; }

        [StringLength(20)]
        public string UserMobilePhoneNumber { get; set; }

        [StringLength(50)]
        public string Login { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public virtual tbl_5_Organization tbl_5_Organization { get; set; }

        public virtual tbl_2_Roles tbl_2_Roles { get; set; }

        public virtual tbl_3_Privileges tbl_3_Privileges { get; set; }

        public virtual tbl_6_City tbl_6_City { get; set; }

        public virtual ICollection<tbl_28_Works_of_Art_objects> tbl_28_Works_of_Art_objects { get; set; }

        public virtual ICollection<tbl_29_Icons_objects> tbl_29_Icons_objects { get; set; }

        public virtual ICollection<tbl_32_PlotFocus> tbl_32_PlotFocus { get; set; }
    }
}
