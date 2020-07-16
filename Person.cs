namespace DXCGalwayWebsite.Domain.Models
{
    public class User : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string EmployeeId { get; set; }
        public string BadgeId { get; set; }
    }
}