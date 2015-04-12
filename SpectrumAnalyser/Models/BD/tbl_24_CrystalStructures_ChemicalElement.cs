namespace SpectrumAnalyser.Models.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_24_CrystalStructures_ChemicalElement
    {
        public tbl_24_CrystalStructures_ChemicalElement()
        {
            tbl_10_ChemicalElement = new HashSet<tbl_10_ChemicalElement>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CrystalStructureId { get; set; }

        [StringLength(500)]
        public string CrystalStructureDescription { get; set; }

        public virtual ICollection<tbl_10_ChemicalElement> tbl_10_ChemicalElement { get; set; }
    }
}
