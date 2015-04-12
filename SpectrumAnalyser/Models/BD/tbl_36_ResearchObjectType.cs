namespace SpectrumAnalyser.Models.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_36_ResearchObjectType
    {
        public tbl_36_ResearchObjectType()
        {
            tbl_28_Works_of_Art_objects = new HashSet<tbl_28_Works_of_Art_objects>();
            tbl_29_Icons_objects = new HashSet<tbl_29_Icons_objects>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ResearchObjectTypeId { get; set; }

        [StringLength(100)]
        public string ResearchObjectTypeName { get; set; }

        public virtual ICollection<tbl_28_Works_of_Art_objects> tbl_28_Works_of_Art_objects { get; set; }

        public virtual ICollection<tbl_29_Icons_objects> tbl_29_Icons_objects { get; set; }
    }
}
