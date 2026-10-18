// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerSourceLocationSecretsManagerAccessTokenConfigurationFactory(Action<Humidifier.MediaTailor.SourceLocationTypes.SecretsManagerAccessTokenConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.SourceLocationTypes.SecretsManagerAccessTokenConfiguration>
{

    protected override Humidifier.MediaTailor.SourceLocationTypes.SecretsManagerAccessTokenConfiguration Create()
    {
        var secretsManagerAccessTokenConfigurationResult = CreateSecretsManagerAccessTokenConfiguration();
        factoryAction?.Invoke(secretsManagerAccessTokenConfigurationResult);

        return secretsManagerAccessTokenConfigurationResult;
    }

    private Humidifier.MediaTailor.SourceLocationTypes.SecretsManagerAccessTokenConfiguration CreateSecretsManagerAccessTokenConfiguration()
    {
        var secretsManagerAccessTokenConfigurationResult = new Humidifier.MediaTailor.SourceLocationTypes.SecretsManagerAccessTokenConfiguration();

        return secretsManagerAccessTokenConfigurationResult;
    }

} // End Of Class

public static class InnerSourceLocationSecretsManagerAccessTokenConfigurationFactoryExtensions
{
}
