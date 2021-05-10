namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dws_cs5.tbcallrecord")]
    public partial class tbcallrecord
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string CallID { get; set; }

        [Required]
        [StringLength(32)]
        public string Caller { get; set; }

        [StringLength(256)]
        public string CallerAlias { get; set; }

        [Required]
        [StringLength(32)]
        public string Callee { get; set; }

        [StringLength(256)]
        public string CalleeAlias { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(64)]
        public string BeginTime { get; set; }

        [Required]
        [StringLength(64)]
        public string EndTime { get; set; }

        public int Priority { get; set; }

        public int CallType { get; set; }

        public int IsAnswer { get; set; }

        [Required]
        [StringLength(64)]
        public string Writer { get; set; }

        [StringLength(128)]
        public string BaseStationID { get; set; }
    }
}
