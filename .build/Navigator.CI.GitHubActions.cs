[GitHubActionsSteps(
    "ci",
    GitHubActionsImage.UbuntuLatest,
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
internal partial class Navigator
{
    public Target GitHubActions => _ => _.DependsOn(Default).Executes(() => { });
}