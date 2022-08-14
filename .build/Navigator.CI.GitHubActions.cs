[GitHubActionsSteps(
    "ci",
    GitHubActionsImage.WindowsLatest,
    AutoGenerate = true,
    On = new[] { GitHubActionsTrigger.Push },
    OnPushTags = new[] { "v*" },
    OnPushBranches = new[] { "main", "master" },
    OnPullRequestBranches = new[] { "main", "master" },
    InvokedTargets = new[] { nameof(GitHubActions) },
    NonEntryTargets = new[]
    {
        nameof(ICIEnvironment.CIEnvironment),
        nameof(Default)
    },
    ExcludedTargets = new[] { nameof(ICanClean.Clean), nameof(ICanRestoreWithDotNetCore.DotnetToolRestore) },
    Enhancements = new[] { nameof(CiMiddleware) }
)]
[PrintBuildVersion]
[PrintCIEnvironment]
[UploadLogs]
[TitleEvents]
[ContinuousIntegrationConventions]
internal partial class Navigator
{
    public Target GitHubActions => _ => _.DependsOn(Default).Executes(() => { });

    public static RocketSurgeonGitHubActionsConfiguration CiIgnoreMiddleware(RocketSurgeonGitHubActionsConfiguration configuration)
    {
        ( (RocketSurgeonsGithubActionsJob)configuration.Jobs[0] ).Steps = new List<GitHubActionsStep>
        {
            new RunStep("N/A")
            {
                Run = "echo \"No build required\""
            }
        };

        return configuration.IncludeRepositoryConfigurationFiles();
    }

    public static RocketSurgeonGitHubActionsConfiguration CiMiddleware(RocketSurgeonGitHubActionsConfiguration configuration)
    {
        configuration
            .ExcludeRepositoryConfigurationFiles()
            .AddNugetPublish()
            .Jobs.OfType<RocketSurgeonsGithubActionsJob>()
            .First(z => z.Name == "Build")
            .UseDotNetSdks("3.1", "6.0")
            .AddNuGetCache()
            // .ConfigureForGitVersion()
            .ConfigureStep<CheckoutStep>(step => step.FetchDepth = 0)
            .PublishLogs<Navigator>()
            .FailFast = false;

        return configuration;
    }
}