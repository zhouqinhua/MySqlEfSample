namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dws_cs5.tbsdscodeinfopair")]
    public partial class tbsdscodeinfopair
    {
        [Key]
        [Column(Order = 0)]
        public string Code { get; set; }

        [StringLength(128)]
        public string DWSSendMean { get; set; }

        [StringLength(128)]
        public string DWSReceiveMean { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Type { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Function { get; set; }
    }
}
