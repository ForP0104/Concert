using System.ComponentModel.DataAnnotations;

namespace Concert.Models.Domain
{
    public class Ticket
    {
        [Key]
        public Guid Id { get; set; }
        public int NumberOfPeople { get; set;}

        public virtual User User { get; set; }
        public string UserId { get; set; }
        public Guid ConcertId { get; set; }

        public virtual Concerts Concert { get; set; }   
      
    }
}
