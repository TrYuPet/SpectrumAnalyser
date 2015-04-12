namespace SpectrumAnalyser.Models.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_9_SpektrumLines_ChemicalElement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SpektrumLineChEId { get; set; }

        public int PlotFocusId { get; set; }

        public int? ChemicalElementId { get; set; }

        public double? SpektrumLineChEWavelength { get; set; }

        public double? SpektrumLineChEIntensity { get; set; }

        public virtual tbl_10_ChemicalElement tbl_10_ChemicalElement { get; set; }

        public virtual tbl_32_PlotFocus tbl_32_PlotFocus { get; set; }
    }
}
