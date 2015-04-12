namespace SpectrumAnalyser.Models.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_23_StatesOfMatter_ChemicalElement
    {
        public tbl_23_StatesOfMatter_ChemicalElement()
        {
            tbl_10_ChemicalElement = new HashSet<tbl_10_ChemicalElement>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StatesOfMatterId { get; set; }

        [StringLength(500)]
        public string StatesOfMatterIdDescription { get; set; }

        public virtual ICollection<tbl_10_ChemicalElement> tbl_10_ChemicalElement { get; set; }
    }
}
