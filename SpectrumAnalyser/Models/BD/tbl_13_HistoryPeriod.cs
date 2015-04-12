namespace SpectrumAnalyser.Models.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_13_HistoryPeriod
    {
        public tbl_13_HistoryPeriod()
        {
            tbl_11_AuthorPictures = new HashSet<tbl_11_AuthorPictures>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HistoryPeriodId { get; set; }

        [StringLength(100)]
        public string HistoryPeriodName { get; set; }

        [Column(TypeName = "text")]
        public string HistoryPeriodIdDescription { get; set; }

        public DateTime? HistoryPeriodIdDates { get; set; }

        public virtual ICollection<tbl_11_AuthorPictures> tbl_11_AuthorPictures { get; set; }
    }
}
