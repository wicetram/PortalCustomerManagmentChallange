namespace PortalCustomerManagmentChallangeEntity.Concrete
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string TCKN { get; set; }
        public bool TCKNCheck { get; set; }
    }
}
