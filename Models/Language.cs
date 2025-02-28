namespace JobApplicationSystem.Models
{
    public class Language
    {
        public int Id { get; set; }
        public int PersonalId { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }

        public Personal? Personal { get; set; }
    }
}
