namespace SDP_EntityModels
{
    public class Customer : IUser
    {
        public int customerID { get; set; }
        public string? customerName { get; set; }
        public string? customerPassword { get; set; }

        string IUser.Username => customerName;
        string IUser.Password => customerPassword;
    }
}