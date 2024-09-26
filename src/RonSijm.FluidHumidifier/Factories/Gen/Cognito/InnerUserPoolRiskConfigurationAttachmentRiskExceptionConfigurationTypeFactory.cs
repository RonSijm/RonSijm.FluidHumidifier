// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolRiskConfigurationAttachmentRiskExceptionConfigurationTypeFactory(Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.RiskExceptionConfigurationType> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.RiskExceptionConfigurationType>
{

    protected override Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.RiskExceptionConfigurationType Create()
    {
        var riskExceptionConfigurationTypeResult = CreateRiskExceptionConfigurationType();
        factoryAction?.Invoke(riskExceptionConfigurationTypeResult);

        return riskExceptionConfigurationTypeResult;
    }

    private Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.RiskExceptionConfigurationType CreateRiskExceptionConfigurationType()
    {
        var riskExceptionConfigurationTypeResult = new Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.RiskExceptionConfigurationType();

        return riskExceptionConfigurationTypeResult;
    }

} // End Of Class

public static class InnerUserPoolRiskConfigurationAttachmentRiskExceptionConfigurationTypeFactoryExtensions
{
}
