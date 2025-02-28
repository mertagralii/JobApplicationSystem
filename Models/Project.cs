namespace JobApplicationSystem.Models
{
    public class Project
    {
        public int Id { get; set; }
        public int PersonalId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Personal? Personal { get; set; }
    }
}
