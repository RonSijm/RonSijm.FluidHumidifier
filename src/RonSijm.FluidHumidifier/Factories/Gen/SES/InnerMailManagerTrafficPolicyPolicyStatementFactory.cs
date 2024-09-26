// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerMailManagerTrafficPolicyPolicyStatementFactory(Action<Humidifier.SES.MailManagerTrafficPolicyTypes.PolicyStatement> factoryAction = null) : SubResourceFactory<Humidifier.SES.MailManagerTrafficPolicyTypes.PolicyStatement>
{

    protected override Humidifier.SES.MailManagerTrafficPolicyTypes.PolicyStatement Create()
    {
        var policyStatementResult = CreatePolicyStatement();
        factoryAction?.Invoke(policyStatementResult);

        return policyStatementResult;
    }

    private Humidifier.SES.MailManagerTrafficPolicyTypes.PolicyStatement CreatePolicyStatement()
    {
        var policyStatementResult = new Humidifier.SES.MailManagerTrafficPolicyTypes.PolicyStatement();

        return policyStatementResult;
    }

} // End Of Class

public static class InnerMailManagerTrafficPolicyPolicyStatementFactoryExtensions
{
}
