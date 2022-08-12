/// <summary>
/// Represents the build parameters and properties.
/// </summary>
internal partial class Navigator
{
    [Parameter("Configuration to build")] public Configuration Configuration { get; } = Configuration.Release;

    [OptionalGitRepository] public GitRepository? GitRepository { get; }

    /// <inheritdoc/>
    [ComputedGitVersion] public GitVersion GitVersion { get; } = null!;
}