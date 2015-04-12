namespace SpectrumAnalyser.Models.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_33_ObjectsPhoto
    {
        public tbl_33_ObjectsPhoto()
        {
            tbl_32_PlotFocus = new HashSet<tbl_32_PlotFocus>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ObjectsPhotoId { get; set; }

        public int? ResearchObjectId { get; set; }

        public int? tbl_ResearchObjectId { get; set; }

        [Column(TypeName = "image")]
        public byte[] ObjectsPhotoFile { get; set; }

        public DateTime? ObjectsPhotoDate { get; set; }

        public virtual tbl_28_Works_of_Art_objects tbl_28_Works_of_Art_objects { get; set; }

        public virtual tbl_29_Icons_objects tbl_29_Icons_objects { get; set; }

        public virtual ICollection<tbl_32_PlotFocus> tbl_32_PlotFocus { get; set; }
    }
}
