namespace JPLearningLib.models
{
    public class Users
    {
        public Users() { }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string ProfilePictureURL { get; set; }
        public DateTime LastLogin { get; set; }
        public string AccountStatus { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Roles RolesId { get; set; }

        //public int user_id { get; set; }
        //public string username { get; set; }
        //public string email { get; set; }
        //public string password_hash { get; set; }
        //public string profile_picture_url { get; set; }
        //public DateTime last_login { get; set; }
        //public string account_status { get; set; }
        //public DateTime created_at { get; set; }
        //public DateTime updated_at { get; set; }
        //public Roles roles_id { get; set; }
    }
}
