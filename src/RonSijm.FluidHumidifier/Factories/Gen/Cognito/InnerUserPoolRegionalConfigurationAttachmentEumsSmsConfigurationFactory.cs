// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolRegionalConfigurationAttachmentEumsSmsConfigurationFactory(Action<Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.EumsSmsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.EumsSmsConfiguration>
{

    protected override Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.EumsSmsConfiguration Create()
    {
        var eumsSmsConfigurationResult = CreateEumsSmsConfiguration();
        factoryAction?.Invoke(eumsSmsConfigurationResult);

        return eumsSmsConfigurationResult;
    }

    private Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.EumsSmsConfiguration CreateEumsSmsConfiguration()
    {
        var eumsSmsConfigurationResult = new Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.EumsSmsConfiguration();

        return eumsSmsConfigurationResult;
    }

} // End Of Class

public static class InnerUserPoolRegionalConfigurationAttachmentEumsSmsConfigurationFactoryExtensions
{
}
