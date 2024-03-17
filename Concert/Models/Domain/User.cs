using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Concert.Models.Domain
{
    public class User : IdentityUser
    {
        [Key]
        public Guid Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Addres {  get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
