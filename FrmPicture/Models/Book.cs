namespace FrmPicture.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        public int id { get; set; }

        [StringLength(50)]
        public string author { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [Column(TypeName = "image")]
        public byte[] image { get; set; }
    }
}
