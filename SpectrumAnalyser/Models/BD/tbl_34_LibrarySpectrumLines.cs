namespace SpectrumAnalyser.Models.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_34_LibrarySpectrumLines
    {
        public tbl_34_LibrarySpectrumLines()
        {
            tbl_21_SpectrumLine = new HashSet<tbl_21_SpectrumLine>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LibraryId { get; set; }

        [StringLength(50)]
        public string LibraryName { get; set; }

        [StringLength(500)]
        public string LibraryCooment { get; set; }

        public virtual ICollection<tbl_21_SpectrumLine> tbl_21_SpectrumLine { get; set; }
    }
}
