namespace TeamA.ProjectB
{
    public class ProjectSubmission
    {
        public string projectName { get; set; } = "";
        public int numberOfMember { get; set; }
        public string projectCategory { get; set; } = "";

        public static void ShowProjectDetail(ProjectSubmission projectSubmission)
        {
            Console.WriteLine("Project Details");
            Console.WriteLine("----------------");

            Console.WriteLine($"Project Name     : {projectSubmission.projectName}");
            Console.WriteLine($"Project Category : {projectSubmission.projectCategory}");
            Console.WriteLine($"Total Member     : {projectSubmission.numberOfMember}");
        }
    }
}