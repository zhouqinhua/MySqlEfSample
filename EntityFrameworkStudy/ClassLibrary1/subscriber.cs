namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dws_cs5.subscriber")]
    public partial class subscriber
    {
        [Key]
        [Column(Order = 0, TypeName = "char")]
        [StringLength(50)]
        public string GENIDXTSISSI { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "char")]
        [StringLength(50)]
        public string GENTYPE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(70)]
        public string SUBSCRIBERNAME { get; set; }

        [Column(TypeName = "char")]
        [StringLength(50)]
        public string TYPEGROUP { get; set; }
    }
}
