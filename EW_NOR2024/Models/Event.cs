using System.ComponentModel.DataAnnotations;

namespace EW_NOR2024.Models
{
    public class Event
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime When { get; set; }

        public bool Protected { get; set; }
    }
}
