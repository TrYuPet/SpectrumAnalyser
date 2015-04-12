namespace SpectrumAnalyser.Models.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_25_Isotop_ChemicalElement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IsotopId { get; set; }

        public int ChemicalElementId { get; set; }

        public int? IsotopMassValue { get; set; }

        public virtual tbl_10_ChemicalElement tbl_10_ChemicalElement { get; set; }
    }
}
