namespace ClassLibrary1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
            this.Database.Initialize(false);
        }

        public virtual DbSet<list_station> list_station { get; set; }
        public virtual DbSet<list_station_2020_04_21_带停车场> list_station_2020_04_21_带停车场 { get; set; }
        public virtual DbSet<subscriber> subscriber { get; set; }
        public virtual DbSet<tbcallrecord> tbcallrecord { get; set; }
        public virtual DbSet<tbdgnaassignment> tbdgnaassignment { get; set; }
        public virtual DbSet<tbsdscodeinfopair> tbsdscodeinfopair { get; set; }
        public virtual DbSet<useraccount> useraccount { get; set; }
        public virtual DbSet<tbeventrecord> tbeventrecord { get; set; }
        public virtual DbSet<tbsdsrecord> tbsdsrecord { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<list_station>()
                .Property(e => e.StationID)
                .IsUnicode(false);

            modelBuilder.Entity<list_station>()
                .Property(e => e.LX)
                .IsUnicode(false);

            modelBuilder.Entity<list_station>()
                .Property(e => e.LY)
                .IsUnicode(false);

            modelBuilder.Entity<list_station>()
                .Property(e => e.Width)
                .IsUnicode(false);

            modelBuilder.Entity<list_station>()
                .Property(e => e.Height)
                .IsUnicode(false);

            modelBuilder.Entity<list_station>()
                .Property(e => e.StationName)
                .IsUnicode(false);

            modelBuilder.Entity<list_station>()
                .Property(e => e.StationGroup)
                .IsUnicode(false);

            modelBuilder.Entity<list_station>()
                .Property(e => e.TrainGroup)
                .IsUnicode(false);

            modelBuilder.Entity<list_station>()
                .Property(e => e.ISSI)
                .IsUnicode(false);

            modelBuilder.Entity<list_station>()
                .Property(e => e.LineNumber)
                .IsUnicode(false);

            modelBuilder.Entity<list_station>()
                .Property(e => e.LineName)
                .IsUnicode(false);

            modelBuilder.Entity<list_station>()
                .Property(e => e.ATS_LineIndex)
                .IsUnicode(false);

            modelBuilder.Entity<list_station>()
                .Property(e => e.ATS_StationIndex)
                .IsUnicode(false);

            modelBuilder.Entity<list_station>()
                .Property(e => e.SegID)
                .IsUnicode(false);

            modelBuilder.Entity<list_station>()
                .Property(e => e.OffSet)
                .IsUnicode(false);

            modelBuilder.Entity<list_station>()
                .Property(e => e.Length)
                .IsUnicode(false);

            modelBuilder.Entity<list_station_2020_04_21_带停车场>()
                .Property(e => e.StationID)
                .IsUnicode(false);

            modelBuilder.Entity<list_station_2020_04_21_带停车场>()
                .Property(e => e.LX)
                .IsUnicode(false);

            modelBuilder.Entity<list_station_2020_04_21_带停车场>()
                .Property(e => e.LY)
                .IsUnicode(false);

            modelBuilder.Entity<list_station_2020_04_21_带停车场>()
                .Property(e => e.Width)
                .IsUnicode(false);

            modelBuilder.Entity<list_station_2020_04_21_带停车场>()
                .Property(e => e.Height)
                .IsUnicode(false);

            modelBuilder.Entity<list_station_2020_04_21_带停车场>()
                .Property(e => e.StationName)
                .IsUnicode(false);

            modelBuilder.Entity<list_station_2020_04_21_带停车场>()
                .Property(e => e.StationGroup)
                .IsUnicode(false);

            modelBuilder.Entity<list_station_2020_04_21_带停车场>()
                .Property(e => e.TrainGroup)
                .IsUnicode(false);

            modelBuilder.Entity<list_station_2020_04_21_带停车场>()
                .Property(e => e.ISSI)
                .IsUnicode(false);

            modelBuilder.Entity<list_station_2020_04_21_带停车场>()
                .Property(e => e.LineNumber)
                .IsUnicode(false);

            modelBuilder.Entity<list_station_2020_04_21_带停车场>()
                .Property(e => e.LineName)
                .IsUnicode(false);

            modelBuilder.Entity<list_station_2020_04_21_带停车场>()
                .Property(e => e.ATS_LineIndex)
                .IsUnicode(false);

            modelBuilder.Entity<list_station_2020_04_21_带停车场>()
                .Property(e => e.ATS_StationIndex)
                .IsUnicode(false);

            modelBuilder.Entity<list_station_2020_04_21_带停车场>()
                .Property(e => e.SegID)
                .IsUnicode(false);

            modelBuilder.Entity<list_station_2020_04_21_带停车场>()
                .Property(e => e.OffSet)
                .IsUnicode(false);

            modelBuilder.Entity<list_station_2020_04_21_带停车场>()
                .Property(e => e.Length)
                .IsUnicode(false);

            modelBuilder.Entity<subscriber>()
                .Property(e => e.GENIDXTSISSI)
                .IsUnicode(false);

            modelBuilder.Entity<subscriber>()
                .Property(e => e.GENTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<subscriber>()
                .Property(e => e.SUBSCRIBERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<subscriber>()
                .Property(e => e.TYPEGROUP)
                .IsUnicode(false);

            modelBuilder.Entity<tbcallrecord>()
                .Property(e => e.CallID)
                .IsUnicode(false);

            modelBuilder.Entity<tbcallrecord>()
                .Property(e => e.Caller)
                .IsUnicode(false);

            modelBuilder.Entity<tbcallrecord>()
                .Property(e => e.CallerAlias)
                .IsUnicode(false);

            modelBuilder.Entity<tbcallrecord>()
                .Property(e => e.Callee)
                .IsUnicode(false);

            modelBuilder.Entity<tbcallrecord>()
                .Property(e => e.CalleeAlias)
                .IsUnicode(false);

            modelBuilder.Entity<tbcallrecord>()
                .Property(e => e.BeginTime)
                .IsUnicode(false);

            modelBuilder.Entity<tbcallrecord>()
                .Property(e => e.EndTime)
                .IsUnicode(false);

            modelBuilder.Entity<tbcallrecord>()
                .Property(e => e.Writer)
                .IsUnicode(false);

            modelBuilder.Entity<tbcallrecord>()
                .Property(e => e.BaseStationID)
                .IsUnicode(false);

            modelBuilder.Entity<tbdgnaassignment>()
                .Property(e => e.DWSType)
                .IsUnicode(false);

            modelBuilder.Entity<tbsdscodeinfopair>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<tbsdscodeinfopair>()
                .Property(e => e.DWSSendMean)
                .IsUnicode(false);

            modelBuilder.Entity<tbsdscodeinfopair>()
                .Property(e => e.DWSReceiveMean)
                .IsUnicode(false);

            modelBuilder.Entity<useraccount>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<useraccount>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<useraccount>()
                .Property(e => e.Usertype)
                .IsUnicode(false);

            modelBuilder.Entity<useraccount>()
                .Property(e => e.Funclist)
                .IsUnicode(false);

            modelBuilder.Entity<useraccount>()
                .Property(e => e.Line)
                .IsUnicode(false);

            modelBuilder.Entity<tbeventrecord>()
                .Property(e => e.Level)
                .IsUnicode(false);

            modelBuilder.Entity<tbeventrecord>()
                .Property(e => e.Event)
                .IsUnicode(false);

            modelBuilder.Entity<tbeventrecord>()
                .Property(e => e.Time)
                .IsUnicode(false);

            modelBuilder.Entity<tbsdsrecord>()
                .Property(e => e.Sender)
                .IsUnicode(false);

            modelBuilder.Entity<tbsdsrecord>()
                .Property(e => e.SenderAlias)
                .IsUnicode(false);

            modelBuilder.Entity<tbsdsrecord>()
                .Property(e => e.Receiver)
                .IsUnicode(false);

            modelBuilder.Entity<tbsdsrecord>()
                .Property(e => e.ReceiverAlias)
                .IsUnicode(false);

            modelBuilder.Entity<tbsdsrecord>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<tbsdsrecord>()
                .Property(e => e.TimeStamp)
                .IsUnicode(false);

            modelBuilder.Entity<tbsdsrecord>()
                .Property(e => e.Writer)
                .IsUnicode(false);
        }
    }
}
