namespace JobApplicationSystem.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public int PersonalId { get; set; }
        public string Name { get; set; }

        public Personal? Personal { get; set; }
    }
}
