// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkSecurityManager;

public class InnerPolicyWafConfigFactory(Action<Humidifier.NetworkSecurityManager.PolicyTypes.WafConfig> factoryAction = null) : SubResourceFactory<Humidifier.NetworkSecurityManager.PolicyTypes.WafConfig>
{

    protected override Humidifier.NetworkSecurityManager.PolicyTypes.WafConfig Create()
    {
        var wafConfigResult = CreateWafConfig();
        factoryAction?.Invoke(wafConfigResult);

        return wafConfigResult;
    }

    private Humidifier.NetworkSecurityManager.PolicyTypes.WafConfig CreateWafConfig()
    {
        var wafConfigResult = new Humidifier.NetworkSecurityManager.PolicyTypes.WafConfig();

        return wafConfigResult;
    }

} // End Of Class

public static class InnerPolicyWafConfigFactoryExtensions
{
}
