// File: Models/Student.cs
namespace EduWebsite.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Course { get; set; }
        public string Email { get; set; }
        
        // Concatenated Name for easier access
        public string Name => $"{FirstName} {LastName}";
    }
}
