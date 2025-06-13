using System.ComponentModel.DataAnnotations;
namespace MWSProductApp.Model
{
    public class MWSUserRoles
    {
        [Key]
        public string? UserRoleId { get; set; }
        public ICollection<MWSRoles>? Roles { get; set; }
        public List<MWSUserRegister>? Users { get; set; }
        public string? UserId { get; set; }
        public string? RoleId { get; set; }
        public string? CreatedBy { get; set; }
    }
}