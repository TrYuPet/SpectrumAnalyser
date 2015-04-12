namespace SpectrumAnalyser.Models.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_12_GeografyPlace
    {
        public tbl_12_GeografyPlace()
        {
            tbl_11_AuthorPictures = new HashSet<tbl_11_AuthorPictures>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GeografyPlaceId { get; set; }

        public int CountryId { get; set; }

        [StringLength(100)]
        public string GeografyPlaceCity { get; set; }

        [StringLength(200)]
        public string Administrative_District_1 { get; set; }

        [StringLength(200)]
        public string Administrative_District_2 { get; set; }

        [StringLength(200)]
        public string Administrative_District_3 { get; set; }

        public virtual ICollection<tbl_11_AuthorPictures> tbl_11_AuthorPictures { get; set; }

        public virtual tbl_15_Country tbl_15_Country { get; set; }
    }
}
