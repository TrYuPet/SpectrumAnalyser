namespace SpectrumAnalyser.Models.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_40_SpektrumMeasurement
    {
        public tbl_40_SpektrumMeasurement()
        {
            tbl_41_Content = new HashSet<tbl_41_Content>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SpektrumMeasurementId { get; set; }

        [StringLength(50)]
        public string SpektrumMeasurementName { get; set; }

        [StringLength(500)]
        public string SpektrumMeasurementIdDescription { get; set; }

        public DateTime? DateOfMeasurement { get; set; }

        [StringLength(100)]
        public string SpektrumMeasurementPlace { get; set; }

        public virtual ICollection<tbl_41_Content> tbl_41_Content { get; set; }
    }
}
