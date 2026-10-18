using RonSijm.FluidHumidifier.Features.Output;

namespace RonSijm.FluidHumidifier.Github
{
    public class CreateGithubActionConfig : CreateEnvironmentConfig
    {
        public Func<string, string> BranchName { get; set; }
        public bool AddManualDispatch { get; set; } = true;
        public bool UseIAM { get; set; } = false;
    }
}