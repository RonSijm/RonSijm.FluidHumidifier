// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLOnSourceDDoSProtectionConfigFactory(Action<Humidifier.WAFv2.WebACLTypes.OnSourceDDoSProtectionConfig> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.OnSourceDDoSProtectionConfig>
{

    protected override Humidifier.WAFv2.WebACLTypes.OnSourceDDoSProtectionConfig Create()
    {
        var onSourceDDoSProtectionConfigResult = CreateOnSourceDDoSProtectionConfig();
        factoryAction?.Invoke(onSourceDDoSProtectionConfigResult);

        return onSourceDDoSProtectionConfigResult;
    }

    private Humidifier.WAFv2.WebACLTypes.OnSourceDDoSProtectionConfig CreateOnSourceDDoSProtectionConfig()
    {
        var onSourceDDoSProtectionConfigResult = new Humidifier.WAFv2.WebACLTypes.OnSourceDDoSProtectionConfig();

        return onSourceDDoSProtectionConfigResult;
    }

} // End Of Class

public static class InnerWebACLOnSourceDDoSProtectionConfigFactoryExtensions
{
}
