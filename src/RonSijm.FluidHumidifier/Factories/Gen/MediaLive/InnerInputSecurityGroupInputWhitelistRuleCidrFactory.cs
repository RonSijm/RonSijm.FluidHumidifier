// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerInputSecurityGroupInputWhitelistRuleCidrFactory(Action<Humidifier.MediaLive.InputSecurityGroupTypes.InputWhitelistRuleCidr> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.InputSecurityGroupTypes.InputWhitelistRuleCidr>
{

    protected override Humidifier.MediaLive.InputSecurityGroupTypes.InputWhitelistRuleCidr Create()
    {
        var inputWhitelistRuleCidrResult = CreateInputWhitelistRuleCidr();
        factoryAction?.Invoke(inputWhitelistRuleCidrResult);

        return inputWhitelistRuleCidrResult;
    }

    private Humidifier.MediaLive.InputSecurityGroupTypes.InputWhitelistRuleCidr CreateInputWhitelistRuleCidr()
    {
        var inputWhitelistRuleCidrResult = new Humidifier.MediaLive.InputSecurityGroupTypes.InputWhitelistRuleCidr();

        return inputWhitelistRuleCidrResult;
    }

} // End Of Class

public static class InnerInputSecurityGroupInputWhitelistRuleCidrFactoryExtensions
{
}
