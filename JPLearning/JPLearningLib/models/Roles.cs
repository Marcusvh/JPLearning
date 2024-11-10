using System.ComponentModel.DataAnnotations;

namespace JPLearningLib.models
{
    public class Roles
    {
        public Roles()
        {
            RoleId = 0;
            RoleName = string.Empty;
            Description = string.Empty;
        }
        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
    }
}
