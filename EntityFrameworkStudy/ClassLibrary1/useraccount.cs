namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dws_cs5.useraccount")]
    public partial class useraccount
    {
        [Key]
        [Column(TypeName = "char")]
        [StringLength(30)]
        public string Username { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(30)]
        public string Password { get; set; }

        [Required]
        [StringLength(64)]
        public string Usertype { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string Funclist { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string Line { get; set; }

        public int act { get; set; }
    }
}
