namespace SpectrumAnalyser.Models.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_31_ResearchObjectsCategory
    {
        public tbl_31_ResearchObjectsCategory()
        {
            tbl_28_Works_of_Art_objects = new HashSet<tbl_28_Works_of_Art_objects>();
            tbl_29_Icons_objects = new HashSet<tbl_29_Icons_objects>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ResearchObjectsCategoryId { get; set; }

        [StringLength(200)]
        public string ResearchObjectsCategoryName { get; set; }

        [StringLength(500)]
        public string ResearchObjectsCategoryValue { get; set; }

        public virtual ICollection<tbl_28_Works_of_Art_objects> tbl_28_Works_of_Art_objects { get; set; }

        public virtual ICollection<tbl_29_Icons_objects> tbl_29_Icons_objects { get; set; }
    }
}
