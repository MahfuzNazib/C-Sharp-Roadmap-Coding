using System;
namespace TeamA.ProjectA
{
    public class ProjectSubmission
    {
        public string projectName { get; set; } = "";
        public int numberOfMember { get; set; }
        public string projectCategory { get; set; } = "";

        public static void ProjectInformation()
        {
            ProjectSubmission projectSubmission = new ProjectSubmission();

            Console.WriteLine("Enter Project Name : ");
            projectSubmission.projectName = Console.ReadLine();

            Console.WriteLine("Enter Project Category : ");
            projectSubmission.projectCategory = Console.ReadLine();

            Console.WriteLine("Number of Member : ");
            projectSubmission.numberOfMember = Convert.ToInt32(Console.ReadLine());

            ShowProjectDetail(projectSubmission);
        }

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