namespace SpectrumAnalyser.Models.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_45_FingerPrint
    {
        public tbl_45_FingerPrint()
        {
            tbl_32_PlotFocus = new HashSet<tbl_32_PlotFocus>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FingerPrintId { get; set; }

        public int? PlotFocusId { get; set; }

        public int? WavelenghtFinger { get; set; }

        public int? IntensityFinger { get; set; }

        public virtual ICollection<tbl_32_PlotFocus> tbl_32_PlotFocus { get; set; }

        public virtual tbl_32_PlotFocus tbl_32_PlotFocus1 { get; set; }
    }
}
