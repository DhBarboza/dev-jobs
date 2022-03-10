namespace Jobs.API.Entities
{
    public class JobApplication
    {
    public JobApplication(string applicantName, string applicantEmail, string idJobVacancy)
    {
      ApplicantName = applicantName;
      ApplicantEmail = applicantEmail;
      IdJobVacancy = idJobVacancy;
    }

    public int Id {get ; private set;}
        public string ApplicantName { get; private set; }
        public string ApplicantEmail { get; private set; }
        // Indentificador da vaga:
        public string IdJobVacancy { get; private set; }
    }
}