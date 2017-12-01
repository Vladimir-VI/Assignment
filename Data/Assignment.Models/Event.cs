using System;
using System.ComponentModel.DataAnnotations;
using Assignment.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Models
{
    public class Event : IHasID
    {
        private string name;
        [Key]
        public int Id { get; set; }

        [MaxLength(150)]
        [Required]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public Status Status { get; set; }
        [NotMapped]
        public bool Changed { get; set; }
    }
}
