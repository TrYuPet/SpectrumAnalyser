namespace SpectrumAnalyser.Models.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_14_WorksOfArt
    {
        public tbl_14_WorksOfArt()
        {
            tbl_17_PassportResearch = new HashSet<tbl_17_PassportResearch>();
            tbl_18_RemarkOfDate = new HashSet<tbl_18_RemarkOfDate>();
            tbl_28_Works_of_Art_objects = new HashSet<tbl_28_Works_of_Art_objects>();
            tbl_29_Icons_objects = new HashSet<tbl_29_Icons_objects>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PictureId { get; set; }

        public int? AuthorPicturesId { get; set; }

        [StringLength(100)]
        public string PictureName { get; set; }

        [StringLength(10)]
        public string Size { get; set; }

        [Column(TypeName = "image")]
        public byte[] PicturePhoto { get; set; }

        [StringLength(40)]
        public string Material { get; set; }

        [StringLength(100)]
        public string Technique { get; set; }

        public DateTime? DateResearch { get; set; }

        [StringLength(200)]
        public string PurposeOfResearch { get; set; }

        [StringLength(400)]
        public string Conclusion { get; set; }

        [StringLength(50)]
        public string StatusWorks { get; set; }

        public virtual tbl_11_AuthorPictures tbl_11_AuthorPictures { get; set; }

        public virtual ICollection<tbl_17_PassportResearch> tbl_17_PassportResearch { get; set; }

        public virtual ICollection<tbl_18_RemarkOfDate> tbl_18_RemarkOfDate { get; set; }

        public virtual ICollection<tbl_28_Works_of_Art_objects> tbl_28_Works_of_Art_objects { get; set; }

        public virtual ICollection<tbl_29_Icons_objects> tbl_29_Icons_objects { get; set; }
    }
}
