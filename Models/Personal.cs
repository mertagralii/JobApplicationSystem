namespace JobApplicationSystem.Models
{
    public class Personal
    {
        public int Id { get; set; }
        public int WorkId { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Title { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string About { get; set; }

        public List<Certificate>? Certificates { get; set; }

        public List<Education> Educations { get; set; }

        public List<Experience>? Experiences { get; set; }

        public List<Language>? Languages { get; set; }

        public List<Link>? Links { get; set; }

        public List<Project>? Projects { get; set; }

        public List<Referance>? Referances { get; set; }

        public List<Skill>? Skills { get; set; }




    }
}
