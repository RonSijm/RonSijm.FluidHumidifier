// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolKeyConfigurationFactory(Action<Humidifier.Cognito.UserPoolTypes.KeyConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolTypes.KeyConfiguration>
{

    protected override Humidifier.Cognito.UserPoolTypes.KeyConfiguration Create()
    {
        var keyConfigurationResult = CreateKeyConfiguration();
        factoryAction?.Invoke(keyConfigurationResult);

        return keyConfigurationResult;
    }

    private Humidifier.Cognito.UserPoolTypes.KeyConfiguration CreateKeyConfiguration()
    {
        var keyConfigurationResult = new Humidifier.Cognito.UserPoolTypes.KeyConfiguration();

        return keyConfigurationResult;
    }

} // End Of Class

public static class InnerUserPoolKeyConfigurationFactoryExtensions
{
}
