namespace JobApplicationSystem.Models
{
    public class Referance
    {
        public int Id { get; set; }
        public int PersonalId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Personal? Personal { get; set; }
    }
}
