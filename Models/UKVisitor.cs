
namespace ProAgricaTest.Models
{

    //need to split this and add new table for NonEU visitors(with last 6 fields) and add Id foriegn key to the new table

    public class UKVisitor
    {
        public Guid Id { get; set; } 
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Category VisitorCategory { get; set; }
        public string? PassportNumber { get; set; }
        public DateTime PassportValidFrom { get; set; }
        public DateTime PassportValidTo { get; set; }
        public string? CountryOfNationality { get; set; }
        public bool? EntryApproved { get; set; }
        public int? NoOfUKEntries { get; set; }
        public string? VisaNumber { get; set; }
        public DateTime? VisaValidFrom { get; set; }
        public DateTime? VisaValidTo { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? ExitDate { get; set; }
        public string? BiometricNumber { get; set; }
    }

    public enum Category
    {
        EUCitizen,
        NonEUCitizen
    }
}
