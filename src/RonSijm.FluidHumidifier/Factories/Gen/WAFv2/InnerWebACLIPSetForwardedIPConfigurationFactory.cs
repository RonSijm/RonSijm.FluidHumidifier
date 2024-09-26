// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLIPSetForwardedIPConfigurationFactory(Action<Humidifier.WAFv2.WebACLTypes.IPSetForwardedIPConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.IPSetForwardedIPConfiguration>
{

    protected override Humidifier.WAFv2.WebACLTypes.IPSetForwardedIPConfiguration Create()
    {
        var iPSetForwardedIPConfigurationResult = CreateIPSetForwardedIPConfiguration();
        factoryAction?.Invoke(iPSetForwardedIPConfigurationResult);

        return iPSetForwardedIPConfigurationResult;
    }

    private Humidifier.WAFv2.WebACLTypes.IPSetForwardedIPConfiguration CreateIPSetForwardedIPConfiguration()
    {
        var iPSetForwardedIPConfigurationResult = new Humidifier.WAFv2.WebACLTypes.IPSetForwardedIPConfiguration();

        return iPSetForwardedIPConfigurationResult;
    }

} // End Of Class

public static class InnerWebACLIPSetForwardedIPConfigurationFactoryExtensions
{
}
