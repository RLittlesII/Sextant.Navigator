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
    ExcludedTargets = new[] { nameof(ICanClean.Clean), nameof(ICanRestoreWithDotNetCore.DotnetToolRestore) }
)]
[PrintBuildVersion]
[PrintCIEnvironment]
[UploadLogs]
[TitleEvents]
internal partial class Navigator
{
    public Target GitHubActions => _ => _.DependsOn(Default).Executes(() => { });
}