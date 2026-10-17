// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerServiceOAuthClientDetailsFactory(Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails>
{

    protected override Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails Create()
    {
        var oAuthClientDetailsResult = CreateOAuthClientDetails();
        factoryAction?.Invoke(oAuthClientDetailsResult);

        return oAuthClientDetailsResult;
    }

    private Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails CreateOAuthClientDetails()
    {
        var oAuthClientDetailsResult = new Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails();

        return oAuthClientDetailsResult;
    }

} // End Of Class

public static class InnerServiceOAuthClientDetailsFactoryExtensions
{
}
