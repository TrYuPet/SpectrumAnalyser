namespace SpectrumAnalyser.Models.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_38_Isotope_ElementAtom
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IsotopeId { get; set; }

        public int ElementAtomId { get; set; }

        public double? IsotopeMassValue { get; set; }

        [StringLength(300)]
        public string IsotopeDescription { get; set; }

        [StringLength(20)]
        public string IsotopeRussionName { get; set; }

        [StringLength(20)]
        public string IsotopeEnglishName { get; set; }

        public DateTime? IsotopeYearOfDiscovery { get; set; }

        [StringLength(300)]
        public string IsotopeDescriptionDiscovery { get; set; }

        public virtual tbl_37_ElementAtom tbl_37_ElementAtom { get; set; }
    }
}
