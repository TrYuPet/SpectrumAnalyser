namespace SpectrumAnalyser.Models.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_21_SpectrumLine
    {
        public tbl_21_SpectrumLine()
        {
            tbl_22_Spektr = new HashSet<tbl_22_Spektr>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SpectrumLineId { get; set; }

        public int? ElementAtomId { get; set; }

        public int LibraryId { get; set; }

        public DateTime? SpectrumLineDate { get; set; }

        [StringLength(50)]
        public string SpectrumLinePersonName { get; set; }

        public double? SpectrumLineWavelLength { get; set; }

        [StringLength(300)]
        public string OtherOptions { get; set; }

        public virtual tbl_34_LibrarySpectrumLines tbl_34_LibrarySpectrumLines { get; set; }

        public virtual tbl_37_ElementAtom tbl_37_ElementAtom { get; set; }

        public virtual ICollection<tbl_22_Spektr> tbl_22_Spektr { get; set; }
    }
}
