namespace LemondeStand
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    public partial class HighScore
    {
        [Key]
        [Column("High Scores")]
        public decimal High_Scores { get; set; }
    }
}
