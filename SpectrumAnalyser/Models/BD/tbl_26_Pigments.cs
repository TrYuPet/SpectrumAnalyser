namespace SpectrumAnalyser.Models.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_26_Pigments
    {
        public tbl_26_Pigments()
        {
            tbl_22_Spektr = new HashSet<tbl_22_Spektr>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PigmentsId { get; set; }

        public int? GroupId { get; set; }

        [StringLength(40)]
        public string PigmentColor { get; set; }

        [StringLength(100)]
        public string PigmentChemicalFormula { get; set; }

        public DateTime? PigmentYearUsed { get; set; }

        [StringLength(100)]
        public string PigmentWhereUsed { get; set; }

        [StringLength(256)]
        public string PigmentLiterature { get; set; }

        public virtual ICollection<tbl_22_Spektr> tbl_22_Spektr { get; set; }

        public virtual tbl_27_Group tbl_27_Group { get; set; }
    }
}
