namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dws_cs5.list_station")]
    public partial class list_station
    {
        [Key]
        [StringLength(100)]
        public string StationID { get; set; }

        [Required]
        [StringLength(100)]
        public string LX { get; set; }

        [Required]
        [StringLength(100)]
        public string LY { get; set; }

        [StringLength(100)]
        public string Width { get; set; }

        [StringLength(100)]
        public string Height { get; set; }

        [Required]
        [StringLength(100)]
        public string StationName { get; set; }

        [StringLength(100)]
        public string StationGroup { get; set; }

        [StringLength(100)]
        public string TrainGroup { get; set; }

        [Required]
        [StringLength(100)]
        public string ISSI { get; set; }

        [Required]
        [StringLength(100)]
        public string LineNumber { get; set; }

        [StringLength(100)]
        public string LineName { get; set; }

        [StringLength(100)]
        public string ATS_LineIndex { get; set; }

        [StringLength(100)]
        public string ATS_StationIndex { get; set; }

        [StringLength(100)]
        public string SegID { get; set; }

        [StringLength(100)]
        public string OffSet { get; set; }

        [StringLength(100)]
        public string Length { get; set; }

        public int? Type { get; set; }
    }
}
