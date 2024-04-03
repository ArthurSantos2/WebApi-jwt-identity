using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [Column("USR_DOCUMENT")]
        public string Document { get; set; }
    }
}
