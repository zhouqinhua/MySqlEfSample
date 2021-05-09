namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dws_cs5.tbeventrecord")]
    public partial class tbeventrecord
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DWS { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(32)]
        public string Level { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string Event { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string Time { get; set; }
    }
}
