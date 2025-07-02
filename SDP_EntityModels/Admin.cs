namespace SDP_EntityModels
{
    public class Admin : IUser
    {
        public int adminID { get; set; }
        public string adminName { get; set; }
        public string adminPassword { get; set; }

        string IUser.Username => adminName;
        string IUser.Password => adminPassword;
    }
}