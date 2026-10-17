// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerConnectionTypeSecretConnectorPropertyFactory(Action<Humidifier.Glue.ConnectionTypeTypes.SecretConnectorProperty> factoryAction = null) : SubResourceFactory<Humidifier.Glue.ConnectionTypeTypes.SecretConnectorProperty>
{

    protected override Humidifier.Glue.ConnectionTypeTypes.SecretConnectorProperty Create()
    {
        var secretConnectorPropertyResult = CreateSecretConnectorProperty();
        factoryAction?.Invoke(secretConnectorPropertyResult);

        return secretConnectorPropertyResult;
    }

    private Humidifier.Glue.ConnectionTypeTypes.SecretConnectorProperty CreateSecretConnectorProperty()
    {
        var secretConnectorPropertyResult = new Humidifier.Glue.ConnectionTypeTypes.SecretConnectorProperty();

        return secretConnectorPropertyResult;
    }

} // End Of Class

public static class InnerConnectionTypeSecretConnectorPropertyFactoryExtensions
{
}
