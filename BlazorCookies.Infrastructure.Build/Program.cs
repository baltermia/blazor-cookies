using ADotNet.Clients;
using ADotNet.Models.Pipelines.GithubPipelines.DotNets;
using ADotNet.Models.Pipelines.GithubPipelines.DotNets.Tasks;
using ADotNet.Models.Pipelines.GithubPipelines.DotNets.Tasks.SetupDotNetTaskV1s;

GithubPipeline githubPipeline = new()
{
    Name = "BlazorCookies Build Pipeline",

    OnEvents = new Events
    {
        PullRequest = new PullRequestEvent
        {
            Branches = new string[] { "main" }
        },

        Push = new PushEvent
        {
            Branches = new string[] { "main" }
        },
    },

    Jobs = new Jobs
    {
        Build = new BuildJob
        {
            RunsOn = BuildMachines.Windows2022,

            Steps = new List<GithubTask>
            {
                new CheckoutTaskV2
                {
                    Name = "Checking Out Code"
                },

                new SetupDotNetTaskV1
                {
                    Name = "Installing .NET",

                    TargetDotNetVersion = new TargetDotNetVersion
                    {
                        DotNetVersion = "6.0.100-rc.2.21505.57",
                        IncludePrerelease = true
                    }
                },

                new RestoreTask
                {
                    Name = "Restoring Nuget Packages",
                },

                new DotNetBuildTask
                {
                    Name = "Builduing Project"
                },

                new TestTask
                {
                    Name = "Running Tests"
                }
            }
        }
    }
};

ADotNetClient client = new();

client.SerializeAndWriteToFile(
    adoPipeline: githubPipeline, 
    path: "../../../../.github/workflows/dotnet.yml"
);
