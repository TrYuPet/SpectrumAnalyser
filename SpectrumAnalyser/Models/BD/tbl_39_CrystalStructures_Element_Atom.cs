namespace SpectrumAnalyser.Models.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_39_CrystalStructures_Element_Atom
    {
        public tbl_39_CrystalStructures_Element_Atom()
        {
            tbl_37_ElementAtom = new HashSet<tbl_37_ElementAtom>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CrystalStructuresId { get; set; }

        [StringLength(100)]
        public string CrystalStructuresName { get; set; }

        [StringLength(500)]
        public string CrystalStructuresDescription { get; set; }

        [StringLength(4)]
        public string CrystalStructuresSymbol { get; set; }

        public virtual ICollection<tbl_37_ElementAtom> tbl_37_ElementAtom { get; set; }
    }
}
