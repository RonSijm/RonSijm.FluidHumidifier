// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolCustomSMSSenderFactory(Action<Humidifier.Cognito.UserPoolTypes.CustomSMSSender> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolTypes.CustomSMSSender>
{

    protected override Humidifier.Cognito.UserPoolTypes.CustomSMSSender Create()
    {
        var customSMSSenderResult = CreateCustomSMSSender();
        factoryAction?.Invoke(customSMSSenderResult);

        return customSMSSenderResult;
    }

    private Humidifier.Cognito.UserPoolTypes.CustomSMSSender CreateCustomSMSSender()
    {
        var customSMSSenderResult = new Humidifier.Cognito.UserPoolTypes.CustomSMSSender();

        return customSMSSenderResult;
    }

} // End Of Class

public static class InnerUserPoolCustomSMSSenderFactoryExtensions
{
}
