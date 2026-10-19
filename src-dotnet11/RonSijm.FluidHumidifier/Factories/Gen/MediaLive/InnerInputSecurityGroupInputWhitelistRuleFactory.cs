// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerInputSecurityGroupInputWhitelistRuleFactory(Action<Humidifier.MediaLive.InputSecurityGroupTypes.InputWhitelistRule> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.InputSecurityGroupTypes.InputWhitelistRule>
{

    protected override Humidifier.MediaLive.InputSecurityGroupTypes.InputWhitelistRule Create()
    {
        var inputWhitelistRuleResult = CreateInputWhitelistRule();
        factoryAction?.Invoke(inputWhitelistRuleResult);

        return inputWhitelistRuleResult;
    }

    private Humidifier.MediaLive.InputSecurityGroupTypes.InputWhitelistRule CreateInputWhitelistRule()
    {
        var inputWhitelistRuleResult = new Humidifier.MediaLive.InputSecurityGroupTypes.InputWhitelistRule();

        return inputWhitelistRuleResult;
    }

} // End Of Class

public static class InnerInputSecurityGroupInputWhitelistRuleFactoryExtensions
{
}
