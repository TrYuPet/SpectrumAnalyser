namespace SpectrumAnalyser.Models.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_10_ChemicalElement
    {
        public tbl_10_ChemicalElement()
        {
            tbl_22_Spektr = new HashSet<tbl_22_Spektr>();
            tbl_25_Isotop_ChemicalElement = new HashSet<tbl_25_Isotop_ChemicalElement>();
            tbl_9_SpektrumLines_ChemicalElement = new HashSet<tbl_9_SpektrumLines_ChemicalElement>();
            tbl_23_StatesOfMatter_ChemicalElement = new HashSet<tbl_23_StatesOfMatter_ChemicalElement>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ChemicalElementId { get; set; }

        public int CrystalStructureId { get; set; }

        [StringLength(100)]
        public string ChemicalElementDescription { get; set; }

        public int? ChemicalElementAtomicNumber { get; set; }

        public double? ChemicalElementAtomicWeight { get; set; }

        public int? ChemicalElementNucleusCharge { get; set; }

        public int? ChemicalElementIonCharge { get; set; }

        public virtual tbl_24_CrystalStructures_ChemicalElement tbl_24_CrystalStructures_ChemicalElement { get; set; }

        public virtual ICollection<tbl_22_Spektr> tbl_22_Spektr { get; set; }

        public virtual ICollection<tbl_25_Isotop_ChemicalElement> tbl_25_Isotop_ChemicalElement { get; set; }

        public virtual ICollection<tbl_9_SpektrumLines_ChemicalElement> tbl_9_SpektrumLines_ChemicalElement { get; set; }

        public virtual ICollection<tbl_23_StatesOfMatter_ChemicalElement> tbl_23_StatesOfMatter_ChemicalElement { get; set; }
    }
}
