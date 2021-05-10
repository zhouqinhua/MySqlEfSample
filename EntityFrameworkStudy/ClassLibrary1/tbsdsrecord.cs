namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dws_cs5.tbsdsrecord")]
    public partial class tbsdsrecord
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(32)]
        public string Sender { get; set; }

        [StringLength(256)]
        public string SenderAlias { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(32)]
        public string Receiver { get; set; }

        [StringLength(256)]
        public string ReceiverAlias { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MsgType { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1024)]
        public string Content { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(64)]
        public string TimeStamp { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(64)]
        public string Writer { get; set; }
    }
}
