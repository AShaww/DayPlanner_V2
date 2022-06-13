using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DayPlanner_V2.Models
{
    [Table("TableLayout")]
    public class TableSchema
    {
        [Key]
        public int Id { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedAt { get; set; }
        public string TopPriorities1 { get; set; }
        public string TopPriorities2 { get; set; }
        public string TopPriorities3 { get; set; }
        public string BrainDump { get; set; }
        public string? FiveAM00 { get; set; } = null;
        public string? FiveAM30 { get; set; } = null;
        public string? SixAM00 { get; set; } = null;
        public string? SixAM30 { get; set; } = null;
        public string? SevenAM00 { get; set; } = null;
        public string? SevenAM30 { get; set; } = null;
        public string? EightAM00 { get; set; } = null;
        public string? EightAM30 { get; set; } = null;
        public string? NineAM00 { get; set; } = null;
        public string? NineAM30 { get; set; } = null;
        public string? TenAM00 { get; set; } = null;
        public string? TenAM30 { get; set; } = null;
        public string? ElevenAM00 { get; set; } = null;
        public string? ElevenAM30 { get; set; } = null;
        public string? TwelveAM00 { get; set; } = null;
        public string? TwelveAM30 { get; set; } = null;
        public string? OnePM00 { get; set; } = null;
        public string? OnePM30 { get; set; } = null;
        public string? TwoPM00 { get; set; } = null;
        public string? TwoPM30 { get; set; } = null;
        public string? ThreePM00 { get; set; } = null;
        public string? ThreePM30 { get; set; } = null;
        public string? FourPM00 { get; set; } = null;
        public string? FourPM30 { get; set; } = null;
        public string? FivePM00 { get; set; } = null;
        public string? FivePM30 { get; set; } = null;
        public string? SixPM00 { get; set; } = null;
        public string? SixPM30 { get; set; } = null;
        public string? SevenPM00 { get; set; } = null;
        public string? SevenPM30 { get; set; } = null;
        public string? EightPM00 { get; set; } = null;
        public string? EightPM30 { get; set; } = null;
        public string? NinePM00 { get; set; } = null;
        public string? NinePM30 { get; set; } = null;
        public string? TenPM00 { get; set; } = null;
        public string? TenPM30 { get; set; } = null;
        public string? ElevenPM00 { get; set; } = null;
        public string? ElevenPM30 { get; set; } = null;
    }
}

