namespace WindowsFormsApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("kvartir")]
    public partial class kvartir
    {
        [StringLength(200)]
        public string ID { get; set; }

        [StringLength(200)]
        public string Vladelec { get; set; }

        [StringLength(200)]
        public string Razmer { get; set; }

        [StringLength(200)]
        public string Vozrast { get; set; }
    }
}
