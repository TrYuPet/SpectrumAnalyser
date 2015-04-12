namespace SpectrumAnalyser.Models.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_37_ElementAtom
    {
        public tbl_37_ElementAtom()
        {
            tbl_21_SpectrumLine = new HashSet<tbl_21_SpectrumLine>();
            tbl_38_Isotope_ElementAtom = new HashSet<tbl_38_Isotope_ElementAtom>();
            tbl_41_Content = new HashSet<tbl_41_Content>();
            tbl_42_Ions = new HashSet<tbl_42_Ions>();
            tbl_43_StatesOfMatter_Element_Atom = new HashSet<tbl_43_StatesOfMatter_Element_Atom>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ElementAtomId { get; set; }

        public int CrystalStructuresId { get; set; }

        [StringLength(200)]
        public string ElementAtomDescription { get; set; }

        public int? AtomicNumber { get; set; }

        public double? AtomicWeight { get; set; }

        [StringLength(4)]
        public string SymbolAtom { get; set; }

        [StringLength(20)]
        public string AtomRussianName { get; set; }

        [StringLength(20)]
        public string AtomEnglishName { get; set; }

        public DateTime? AtomYearOfDiscovery { get; set; }

        [StringLength(200)]
        public string AtomDescriptionDiscoveries { get; set; }

        public virtual ICollection<tbl_21_SpectrumLine> tbl_21_SpectrumLine { get; set; }

        public virtual tbl_39_CrystalStructures_Element_Atom tbl_39_CrystalStructures_Element_Atom { get; set; }

        public virtual ICollection<tbl_38_Isotope_ElementAtom> tbl_38_Isotope_ElementAtom { get; set; }

        public virtual ICollection<tbl_41_Content> tbl_41_Content { get; set; }

        public virtual ICollection<tbl_42_Ions> tbl_42_Ions { get; set; }

        public virtual ICollection<tbl_43_StatesOfMatter_Element_Atom> tbl_43_StatesOfMatter_Element_Atom { get; set; }
    }
}
