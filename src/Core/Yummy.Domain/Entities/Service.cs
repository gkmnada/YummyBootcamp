namespace Yummy.Domain.Entities
{
    public class Service
    {
        public int ServiceID { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string IconURL { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
    }
}