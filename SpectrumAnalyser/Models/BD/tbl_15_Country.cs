namespace SpectrumAnalyser.Models.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_15_Country
    {
        public tbl_15_Country()
        {
            tbl_12_GeografyPlace = new HashSet<tbl_12_GeografyPlace>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CountryId { get; set; }

        [StringLength(100)]
        public string CountryName { get; set; }

        [StringLength(500)]
        public string CountryDescription { get; set; }

        public virtual ICollection<tbl_12_GeografyPlace> tbl_12_GeografyPlace { get; set; }
    }
}
