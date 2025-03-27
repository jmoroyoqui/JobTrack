using JobTracker.API.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace JobTracker.API.Models
{
    public class Users : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "")]
        public string Name { get; set; }

        [Required(ErrorMessage = "")]
        public string Email { get; set; }

        [Required(ErrorMessage = "")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "")]
        public string Password { get; set; }
    }
}
