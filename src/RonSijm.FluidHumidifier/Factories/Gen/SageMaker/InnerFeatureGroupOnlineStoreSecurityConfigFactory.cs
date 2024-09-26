// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerFeatureGroupOnlineStoreSecurityConfigFactory(Action<Humidifier.SageMaker.FeatureGroupTypes.OnlineStoreSecurityConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.FeatureGroupTypes.OnlineStoreSecurityConfig>
{

    protected override Humidifier.SageMaker.FeatureGroupTypes.OnlineStoreSecurityConfig Create()
    {
        var onlineStoreSecurityConfigResult = CreateOnlineStoreSecurityConfig();
        factoryAction?.Invoke(onlineStoreSecurityConfigResult);

        return onlineStoreSecurityConfigResult;
    }

    private Humidifier.SageMaker.FeatureGroupTypes.OnlineStoreSecurityConfig CreateOnlineStoreSecurityConfig()
    {
        var onlineStoreSecurityConfigResult = new Humidifier.SageMaker.FeatureGroupTypes.OnlineStoreSecurityConfig();

        return onlineStoreSecurityConfigResult;
    }

} // End Of Class

public static class InnerFeatureGroupOnlineStoreSecurityConfigFactoryExtensions
{
}
