namespace SpectrumAnalyser.Models.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_43_StatesOfMatter_Element_Atom
    {
        public tbl_43_StatesOfMatter_Element_Atom()
        {
            tbl_41_Content = new HashSet<tbl_41_Content>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StatesOfMatterEAId { get; set; }

        public int? ElementAtomId { get; set; }

        [StringLength(100)]
        public string StateName { get; set; }

        [StringLength(5)]
        public string StateSymbol { get; set; }

        [StringLength(20)]
        public string StateRussianName { get; set; }

        [StringLength(20)]
        public string StateEnglishName { get; set; }

        public DateTime? StateYearOfDiscoveries { get; set; }

        [StringLength(400)]
        public string StateDescruprionDiscoveries { get; set; }

        public virtual tbl_37_ElementAtom tbl_37_ElementAtom { get; set; }

        public virtual ICollection<tbl_41_Content> tbl_41_Content { get; set; }
    }
}
