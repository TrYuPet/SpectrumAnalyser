namespace SpectrumAnalyser.Models.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_18_RemarkOfDate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RemarkOfDateId { get; set; }

        public int? PictureId { get; set; }

        public int? DateOfCreatedId { get; set; }

        [StringLength(300)]
        public string RemarkOfDateCreate { get; set; }

        public virtual tbl_14_WorksOfArt tbl_14_WorksOfArt { get; set; }

        public virtual tbl_19_DateOfCreated tbl_19_DateOfCreated { get; set; }
    }
}
