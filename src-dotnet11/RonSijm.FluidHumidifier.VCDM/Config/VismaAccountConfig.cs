using RonSijm.FluidHumidifier.Features.Consumer;

namespace RonSijm.FluidHumidifier.VCDM.Config
{
    public static class VismaAccountConfig
    {
        public static EnvironmentConfig StagingAccount = new("visma-security-logs-stage", "829546283600", "eu-central-1");
        public static EnvironmentConfig ProdAccount = new("visma-security-logs-prod", "438872507975", "eu-central-1");
    }
}