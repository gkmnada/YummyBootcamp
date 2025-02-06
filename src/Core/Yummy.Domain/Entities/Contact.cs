namespace Yummy.Domain.Entities
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string Location { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string OpenHours { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
    }
}