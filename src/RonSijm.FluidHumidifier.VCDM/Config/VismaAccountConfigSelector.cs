using RonSijm.FluidHumidifier.Features.Consumer;

namespace RonSijm.FluidHumidifier.VCDM.Config
{
    public static class VismaAccountConfigSelector
    {
        public static EnvironmentConfig GetVismaAccountConfig(EnvironmentConfig env)
        {
            return env.EnvironmentName == "prod" ? VismaAccountConfig.ProdAccount : VismaAccountConfig.StagingAccount;
        }
    }
}