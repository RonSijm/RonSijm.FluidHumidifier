// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolEumsSmsConfigurationFactory(Action<Humidifier.Cognito.UserPoolTypes.EumsSmsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolTypes.EumsSmsConfiguration>
{

    protected override Humidifier.Cognito.UserPoolTypes.EumsSmsConfiguration Create()
    {
        var eumsSmsConfigurationResult = CreateEumsSmsConfiguration();
        factoryAction?.Invoke(eumsSmsConfigurationResult);

        return eumsSmsConfigurationResult;
    }

    private Humidifier.Cognito.UserPoolTypes.EumsSmsConfiguration CreateEumsSmsConfiguration()
    {
        var eumsSmsConfigurationResult = new Humidifier.Cognito.UserPoolTypes.EumsSmsConfiguration();

        return eumsSmsConfigurationResult;
    }

} // End Of Class

public static class InnerUserPoolEumsSmsConfigurationFactoryExtensions
{
}
