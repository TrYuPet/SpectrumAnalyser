namespace SpectrumAnalyser.Models.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_20_InstrumentalMethods
    {
        public tbl_20_InstrumentalMethods()
        {
            tbl_17_PassportResearch = new HashSet<tbl_17_PassportResearch>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InstrumentalMethodsId { get; set; }

        [Column(TypeName = "text")]
        public string InstrumentalMethodsName { get; set; }

        [Column(TypeName = "text")]
        public string InstrumentalMethodsDescription { get; set; }

        public virtual ICollection<tbl_17_PassportResearch> tbl_17_PassportResearch { get; set; }
    }
}
