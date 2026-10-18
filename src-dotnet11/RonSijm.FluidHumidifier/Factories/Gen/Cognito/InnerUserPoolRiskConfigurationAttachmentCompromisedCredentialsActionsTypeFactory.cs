// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolRiskConfigurationAttachmentCompromisedCredentialsActionsTypeFactory(Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.CompromisedCredentialsActionsType> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.CompromisedCredentialsActionsType>
{

    protected override Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.CompromisedCredentialsActionsType Create()
    {
        var compromisedCredentialsActionsTypeResult = CreateCompromisedCredentialsActionsType();
        factoryAction?.Invoke(compromisedCredentialsActionsTypeResult);

        return compromisedCredentialsActionsTypeResult;
    }

    private Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.CompromisedCredentialsActionsType CreateCompromisedCredentialsActionsType()
    {
        var compromisedCredentialsActionsTypeResult = new Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.CompromisedCredentialsActionsType();

        return compromisedCredentialsActionsTypeResult;
    }

} // End Of Class

public static class InnerUserPoolRiskConfigurationAttachmentCompromisedCredentialsActionsTypeFactoryExtensions
{
}
