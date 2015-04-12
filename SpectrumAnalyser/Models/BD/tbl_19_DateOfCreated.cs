namespace SpectrumAnalyser.Models.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_19_DateOfCreated
    {
        public tbl_19_DateOfCreated()
        {
            tbl_18_RemarkOfDate = new HashSet<tbl_18_RemarkOfDate>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DateOfCreatedId { get; set; }

        public DateTime? DateOfCreated { get; set; }

        public virtual ICollection<tbl_18_RemarkOfDate> tbl_18_RemarkOfDate { get; set; }
    }
}
