namespace SpectrumAnalyser.Models.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_41_Content
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ContentId { get; set; }

        public int StatesOfMatterEAId { get; set; }

        public int SpektrumMeasurementId { get; set; }

        public int? IonId { get; set; }

        public int ElementAtomId { get; set; }

        public double? ContentWaveLenght { get; set; }

        [StringLength(100)]
        public string ContentName { get; set; }

        public virtual tbl_37_ElementAtom tbl_37_ElementAtom { get; set; }

        public virtual tbl_40_SpektrumMeasurement tbl_40_SpektrumMeasurement { get; set; }

        public virtual tbl_42_Ions tbl_42_Ions { get; set; }

        public virtual tbl_43_StatesOfMatter_Element_Atom tbl_43_StatesOfMatter_Element_Atom { get; set; }
    }
}
