// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerKeyGroupKeyGroupConfigFactory(Action<Humidifier.CloudFront.KeyGroupTypes.KeyGroupConfig> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.KeyGroupTypes.KeyGroupConfig>
{

    protected override Humidifier.CloudFront.KeyGroupTypes.KeyGroupConfig Create()
    {
        var keyGroupConfigResult = CreateKeyGroupConfig();
        factoryAction?.Invoke(keyGroupConfigResult);

        return keyGroupConfigResult;
    }

    private Humidifier.CloudFront.KeyGroupTypes.KeyGroupConfig CreateKeyGroupConfig()
    {
        var keyGroupConfigResult = new Humidifier.CloudFront.KeyGroupTypes.KeyGroupConfig();

        return keyGroupConfigResult;
    }

} // End Of Class

public static class InnerKeyGroupKeyGroupConfigFactoryExtensions
{
}
