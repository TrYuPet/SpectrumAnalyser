namespace SpectrumAnalyser.Models.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_32_PlotFocus
    {
        public tbl_32_PlotFocus()
        {
            tbl_45_FingerPrint1 = new HashSet<tbl_45_FingerPrint>();
            tbl_9_SpektrumLines_ChemicalElement = new HashSet<tbl_9_SpektrumLines_ChemicalElement>();
            tbl_22_Spektr = new HashSet<tbl_22_Spektr>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PlotFocusId { get; set; }

        public int? ObjectsPhotoId { get; set; }

        public int UserId { get; set; }

        public int? FingerPrintId { get; set; }

        public int ResearchObjectId { get; set; }

        public int tbl_ResearchObjectId { get; set; }

        public DateTime? PlotFocusDate { get; set; }

        public DateTime? PlotFocusTime { get; set; }

        public int? LabelFocus { get; set; }

        public virtual tbl_1_User tbl_1_User { get; set; }

        public virtual tbl_28_Works_of_Art_objects tbl_28_Works_of_Art_objects { get; set; }

        public virtual tbl_29_Icons_objects tbl_29_Icons_objects { get; set; }

        public virtual tbl_45_FingerPrint tbl_45_FingerPrint { get; set; }

        public virtual tbl_33_ObjectsPhoto tbl_33_ObjectsPhoto { get; set; }

        public virtual ICollection<tbl_45_FingerPrint> tbl_45_FingerPrint1 { get; set; }

        public virtual ICollection<tbl_9_SpektrumLines_ChemicalElement> tbl_9_SpektrumLines_ChemicalElement { get; set; }

        public virtual ICollection<tbl_22_Spektr> tbl_22_Spektr { get; set; }
    }
}
