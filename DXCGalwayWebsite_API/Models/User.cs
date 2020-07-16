namespace DXCGalwayWebsite_API.Models
{
    public class User : BaseModel
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }
}