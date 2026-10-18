// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolRegionalConfigurationAttachmentCustomSMSSenderFactory(Action<Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.CustomSMSSender> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.CustomSMSSender>
{

    protected override Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.CustomSMSSender Create()
    {
        var customSMSSenderResult = CreateCustomSMSSender();
        factoryAction?.Invoke(customSMSSenderResult);

        return customSMSSenderResult;
    }

    private Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.CustomSMSSender CreateCustomSMSSender()
    {
        var customSMSSenderResult = new Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.CustomSMSSender();

        return customSMSSenderResult;
    }

} // End Of Class

public static class InnerUserPoolRegionalConfigurationAttachmentCustomSMSSenderFactoryExtensions
{
}
