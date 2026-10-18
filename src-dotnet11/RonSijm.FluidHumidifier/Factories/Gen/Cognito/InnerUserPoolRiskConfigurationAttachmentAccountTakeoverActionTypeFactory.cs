// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolRiskConfigurationAttachmentAccountTakeoverActionTypeFactory(Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.AccountTakeoverActionType> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.AccountTakeoverActionType>
{

    protected override Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.AccountTakeoverActionType Create()
    {
        var accountTakeoverActionTypeResult = CreateAccountTakeoverActionType();
        factoryAction?.Invoke(accountTakeoverActionTypeResult);

        return accountTakeoverActionTypeResult;
    }

    private Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.AccountTakeoverActionType CreateAccountTakeoverActionType()
    {
        var accountTakeoverActionTypeResult = new Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.AccountTakeoverActionType();

        return accountTakeoverActionTypeResult;
    }

} // End Of Class

public static class InnerUserPoolRiskConfigurationAttachmentAccountTakeoverActionTypeFactoryExtensions
{
}
