namespace SpectrumAnalyser.Models.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_29_Icons_objects
    {
        public tbl_29_Icons_objects()
        {
            tbl_32_PlotFocus = new HashSet<tbl_32_PlotFocus>();
            tbl_33_ObjectsPhoto = new HashSet<tbl_33_ObjectsPhoto>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ResearchObjectId { get; set; }

        public int? PictureId { get; set; }

        public int? ResearchObjectsCategoryId { get; set; }

        public int UserId { get; set; }

        public int ResearchObjectTypeId { get; set; }

        [StringLength(100)]
        public string ResearchObjectName { get; set; }

        public int? InertyPow { get; set; }

        public DateTime? DateFromOb { get; set; }

        public virtual tbl_1_User tbl_1_User { get; set; }

        public virtual tbl_14_WorksOfArt tbl_14_WorksOfArt { get; set; }

        public virtual tbl_31_ResearchObjectsCategory tbl_31_ResearchObjectsCategory { get; set; }

        public virtual tbl_36_ResearchObjectType tbl_36_ResearchObjectType { get; set; }

        public virtual ICollection<tbl_32_PlotFocus> tbl_32_PlotFocus { get; set; }

        public virtual ICollection<tbl_33_ObjectsPhoto> tbl_33_ObjectsPhoto { get; set; }
    }
}
