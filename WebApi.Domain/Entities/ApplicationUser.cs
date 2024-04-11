using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [Column("USR_DOCUMENT")]
        public string Document { get; set; }
    }
}
