// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolCustomEmailSenderFactory(Action<Humidifier.Cognito.UserPoolTypes.CustomEmailSender> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolTypes.CustomEmailSender>
{

    protected override Humidifier.Cognito.UserPoolTypes.CustomEmailSender Create()
    {
        var customEmailSenderResult = CreateCustomEmailSender();
        factoryAction?.Invoke(customEmailSenderResult);

        return customEmailSenderResult;
    }

    private Humidifier.Cognito.UserPoolTypes.CustomEmailSender CreateCustomEmailSender()
    {
        var customEmailSenderResult = new Humidifier.Cognito.UserPoolTypes.CustomEmailSender();

        return customEmailSenderResult;
    }

} // End Of Class

public static class InnerUserPoolCustomEmailSenderFactoryExtensions
{
}
