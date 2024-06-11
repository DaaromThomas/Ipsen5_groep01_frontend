namespace Ipsen5_groep01_frontend.Models;

public class User
{
    public Guid Id { get; set; } 

    public string FirstName { get; set; } 

    public string LastName { get; set; }
    
    public string Email { get; set; }
    public bool IsActive { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }
    public DateTime createdDate { get; set; }
    public DateTime updatedDate { get; set; }
    public string Role { get; set; }
}