namespace SpectrumAnalyser.Models.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_17_PassportResearch
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PassportResearchId { get; set; }

        public int PictureId { get; set; }

        public int? InstrumentalMethodsId { get; set; }

        [StringLength(255)]
        public string Conclusion_the_method { get; set; }

        public virtual tbl_14_WorksOfArt tbl_14_WorksOfArt { get; set; }

        public virtual tbl_20_InstrumentalMethods tbl_20_InstrumentalMethods { get; set; }
    }
}
