﻿namespace JobApplicationSystem.Models
{
    public class Education
    {
        public int Id { get; set; }
        public int PersonalId { get; set; }
        public string School { get; set; }
        public string Degree { get; set; }
        public string Field { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Description { get; set; }

        public Personal Personal { get; set; }
    }
}
