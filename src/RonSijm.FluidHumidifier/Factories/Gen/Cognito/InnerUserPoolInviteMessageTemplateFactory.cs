// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolInviteMessageTemplateFactory(Action<Humidifier.Cognito.UserPoolTypes.InviteMessageTemplate> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolTypes.InviteMessageTemplate>
{

    protected override Humidifier.Cognito.UserPoolTypes.InviteMessageTemplate Create()
    {
        var inviteMessageTemplateResult = CreateInviteMessageTemplate();
        factoryAction?.Invoke(inviteMessageTemplateResult);

        return inviteMessageTemplateResult;
    }

    private Humidifier.Cognito.UserPoolTypes.InviteMessageTemplate CreateInviteMessageTemplate()
    {
        var inviteMessageTemplateResult = new Humidifier.Cognito.UserPoolTypes.InviteMessageTemplate();

        return inviteMessageTemplateResult;
    }

} // End Of Class

public static class InnerUserPoolInviteMessageTemplateFactoryExtensions
{
}
