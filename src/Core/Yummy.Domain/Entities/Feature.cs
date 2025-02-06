namespace Yummy.Domain.Entities
{
    public class Feature
    {
        public int FeatureID { get; set; }
        public string Title { get; set; } = string.Empty;
        public string SubTitle { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageURL { get; set; } = string.Empty;
        public string VideoURL { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
    }
}