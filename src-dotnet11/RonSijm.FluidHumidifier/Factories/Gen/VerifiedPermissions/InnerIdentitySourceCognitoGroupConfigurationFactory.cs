// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VerifiedPermissions;

public class InnerIdentitySourceCognitoGroupConfigurationFactory(Action<Humidifier.VerifiedPermissions.IdentitySourceTypes.CognitoGroupConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.VerifiedPermissions.IdentitySourceTypes.CognitoGroupConfiguration>
{

    protected override Humidifier.VerifiedPermissions.IdentitySourceTypes.CognitoGroupConfiguration Create()
    {
        var cognitoGroupConfigurationResult = CreateCognitoGroupConfiguration();
        factoryAction?.Invoke(cognitoGroupConfigurationResult);

        return cognitoGroupConfigurationResult;
    }

    private Humidifier.VerifiedPermissions.IdentitySourceTypes.CognitoGroupConfiguration CreateCognitoGroupConfiguration()
    {
        var cognitoGroupConfigurationResult = new Humidifier.VerifiedPermissions.IdentitySourceTypes.CognitoGroupConfiguration();

        return cognitoGroupConfigurationResult;
    }

} // End Of Class

public static class InnerIdentitySourceCognitoGroupConfigurationFactoryExtensions
{
}
