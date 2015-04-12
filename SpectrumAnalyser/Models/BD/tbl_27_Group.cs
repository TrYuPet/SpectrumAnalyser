namespace SpectrumAnalyser.Models.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_27_Group
    {
        public tbl_27_Group()
        {
            tbl_26_Pigments = new HashSet<tbl_26_Pigments>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GroupId { get; set; }

        [StringLength(100)]
        public string GroupName { get; set; }

        public virtual ICollection<tbl_26_Pigments> tbl_26_Pigments { get; set; }
    }
}
