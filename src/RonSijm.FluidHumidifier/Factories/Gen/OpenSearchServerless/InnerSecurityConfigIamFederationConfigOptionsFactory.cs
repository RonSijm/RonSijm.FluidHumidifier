// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchServerless;

public class InnerSecurityConfigIamFederationConfigOptionsFactory(Action<Humidifier.OpenSearchServerless.SecurityConfigTypes.IamFederationConfigOptions> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearchServerless.SecurityConfigTypes.IamFederationConfigOptions>
{

    protected override Humidifier.OpenSearchServerless.SecurityConfigTypes.IamFederationConfigOptions Create()
    {
        var iamFederationConfigOptionsResult = CreateIamFederationConfigOptions();
        factoryAction?.Invoke(iamFederationConfigOptionsResult);

        return iamFederationConfigOptionsResult;
    }

    private Humidifier.OpenSearchServerless.SecurityConfigTypes.IamFederationConfigOptions CreateIamFederationConfigOptions()
    {
        var iamFederationConfigOptionsResult = new Humidifier.OpenSearchServerless.SecurityConfigTypes.IamFederationConfigOptions();

        return iamFederationConfigOptionsResult;
    }

} // End Of Class

public static class InnerSecurityConfigIamFederationConfigOptionsFactoryExtensions
{
}
