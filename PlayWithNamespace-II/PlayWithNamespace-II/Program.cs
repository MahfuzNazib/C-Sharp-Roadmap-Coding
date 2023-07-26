using TAPA = TeamA.ProjectA;
using TAPB = TeamA.ProjectB;

namespace PlayWithNamespace_II
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Play With C# Namespace - II");
            Console.WriteLine("---------------------------");

            Console.WriteLine();
            TAPA.ProjectSubmission.ProjectInformation();
            //TAPA.ProjectSubmission projectSubmissionTeamA = new TAPA.ProjectSubmission();
            //projectSubmissionTeamA.projectName = "Music Genere with AI";
            //projectSubmissionTeamA.projectCategory = "AI";
            //projectSubmissionTeamA.numberOfMember = 3;

            //TAPA.ProjectSubmission.ShowProjectDetail(projectSubmissionTeamA);

            TAPB.ProjectSubmission projectSubmissionTeamB = new TAPB.ProjectSubmission();
            projectSubmissionTeamB.projectName = "HRM Solutions";
            projectSubmissionTeamB.projectCategory = "Management";
            projectSubmissionTeamB.numberOfMember = 12;

            TAPB.ProjectSubmission.ShowProjectDetail(projectSubmissionTeamB);
        }
    }
}