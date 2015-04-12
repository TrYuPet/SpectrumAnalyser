namespace SpectrumAnalyser.Models.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_6_City
    {
        public tbl_6_City()
        {
            tbl_1_User = new HashSet<tbl_1_User>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CityId { get; set; }

        [StringLength(100)]
        public string UserCity { get; set; }

        [StringLength(100)]
        public string Country { get; set; }

        [StringLength(100)]
        public string AdministrativeDevision { get; set; }

        [StringLength(100)]
        public string Region { get; set; }

        public virtual ICollection<tbl_1_User> tbl_1_User { get; set; }
    }
}
