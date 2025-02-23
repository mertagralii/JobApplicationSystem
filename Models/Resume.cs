namespace JobApplicationSystem.Models
{
    public class Resume
    {
        public int Id { get; set; }
        public int PersonalId { get; set; }
        public int? SkillsId { get; set; }
        public int? EducationId { get; set; }
        public int LinkId { get; set; }
        public int? ExperienceId { get; set; }
        public int? ReferanceId { get; set; }
        public int? ProjectsId { get; set; }
        public int? LanguagesId { get; set; }
        public int CertificateId { get; set; }
        public int WorkCategoryId { get; set; }

    }
}
