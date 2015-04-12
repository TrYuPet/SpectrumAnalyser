namespace SpectrumAnalyser.Models.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_42_Ions
    {
        public tbl_42_Ions()
        {
            tbl_41_Content = new HashSet<tbl_41_Content>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IonId { get; set; }

        public int ElementAtomId { get; set; }

        [StringLength(400)]
        public string IonDescription { get; set; }

        [StringLength(20)]
        public string IonRussianName { get; set; }

        [StringLength(20)]
        public string IonEnglishName { get; set; }

        [StringLength(5)]
        public string IonCharge { get; set; }

        public virtual tbl_37_ElementAtom tbl_37_ElementAtom { get; set; }

        public virtual ICollection<tbl_41_Content> tbl_41_Content { get; set; }
    }
}
