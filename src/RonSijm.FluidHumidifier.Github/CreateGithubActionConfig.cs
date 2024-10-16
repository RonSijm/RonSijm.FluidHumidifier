using RonSijm.FluidHumidifier.Features.Output;

namespace RonSijm.FluidHumidifier.Github
{
    public class CreateGithubActionConfig : CreateEnvironmentConfig
    {
        public Func<string, string> BranchName { get; set; }
    }
}