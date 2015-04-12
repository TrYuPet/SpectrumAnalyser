namespace SpectrumAnalyser.Models.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_11_AuthorPictures
    {
        public tbl_11_AuthorPictures()
        {
            tbl_14_WorksOfArt = new HashSet<tbl_14_WorksOfArt>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AuthorPicturesId { get; set; }

        public int? GeografyPlaceId { get; set; }

        public int HistoryPeriodId { get; set; }

        [StringLength(50)]
        public string AuthorFirstName { get; set; }

        [StringLength(50)]
        public string AuthorLastName { get; set; }

        [StringLength(50)]
        public string AuthorMiddleName { get; set; }

        public DateTime? AuthorDate_of_birth { get; set; }

        public DateTime? AuthorOtherDates { get; set; }

        [StringLength(8000)]
        public string AuthorBiography { get; set; }

        public virtual tbl_12_GeografyPlace tbl_12_GeografyPlace { get; set; }

        public virtual tbl_13_HistoryPeriod tbl_13_HistoryPeriod { get; set; }

        public virtual ICollection<tbl_14_WorksOfArt> tbl_14_WorksOfArt { get; set; }
    }
}
