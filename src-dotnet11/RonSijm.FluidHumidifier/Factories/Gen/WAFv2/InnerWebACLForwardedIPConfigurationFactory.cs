// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLForwardedIPConfigurationFactory(Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration>
{

    protected override Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration Create()
    {
        var forwardedIPConfigurationResult = CreateForwardedIPConfiguration();
        factoryAction?.Invoke(forwardedIPConfigurationResult);

        return forwardedIPConfigurationResult;
    }

    private Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration CreateForwardedIPConfiguration()
    {
        var forwardedIPConfigurationResult = new Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration();

        return forwardedIPConfigurationResult;
    }

} // End Of Class

public static class InnerWebACLForwardedIPConfigurationFactoryExtensions
{
}
