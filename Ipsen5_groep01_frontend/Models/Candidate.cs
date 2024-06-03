namespace Ipsen5_groep01_frontend.Models;

public class Candidate
{
    public Guid Id { get; set; } 

    public string FirstName { get; set; } 

    public string LastName { get; set; }

    public DateTime DateOfBirth { get; set; }

    public string BSN { get; set; }

    public DateTime CreatedDate { get; set; }
    
    public DateTime UpdatedDate { get; set; }
}