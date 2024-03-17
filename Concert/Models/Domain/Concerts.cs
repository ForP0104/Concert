using System.ComponentModel.DataAnnotations;

namespace Concert.Models.Domain
{
    public class Concerts
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public String ConcertName { get; set; }
        [Required]
        public DateTime ConcertDate { get; set; }
        [Required]
        public int ConcertPrice {  get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
