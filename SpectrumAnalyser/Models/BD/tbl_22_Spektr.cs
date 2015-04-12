namespace SpectrumAnalyser.Models.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_22_Spektr
    {
        public tbl_22_Spektr()
        {
            tbl_32_PlotFocus = new HashSet<tbl_32_PlotFocus>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SpektrId { get; set; }

        public int SpectrumLineId { get; set; }

        public int? PigmentsId { get; set; }

        public int ChemicalElementId { get; set; }

        public double? SpektrWaveLenght { get; set; }

        [StringLength(100)]
        public string LineDescription { get; set; }

        [StringLength(100)]
        public string SpektrsBase { get; set; }

        public double? SpektrIntensity { get; set; }

        public double? PeakArea { get; set; }

        public virtual tbl_10_ChemicalElement tbl_10_ChemicalElement { get; set; }

        public virtual tbl_21_SpectrumLine tbl_21_SpectrumLine { get; set; }

        public virtual tbl_26_Pigments tbl_26_Pigments { get; set; }

        public virtual ICollection<tbl_32_PlotFocus> tbl_32_PlotFocus { get; set; }
    }
}
