using Microsoft.AspNetCore.Identity;

namespace WorkManage.Data.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        //public Guid Id { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Patronymic { get; set; }
        public string? Rank { get; set; }
        public DateTime? HireDate { get; set; }
        public IEnumerable<Work>? Works { get; set; }
    }
}
