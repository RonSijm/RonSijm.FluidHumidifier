// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EntityResolution;

public class PolicyStatementFactory(string resourceName = null, Action<Humidifier.EntityResolution.PolicyStatement> factoryAction = null) : ResourceFactory<Humidifier.EntityResolution.PolicyStatement>(resourceName)
{

    protected override Humidifier.EntityResolution.PolicyStatement Create()
    {
        var policyStatementResult = CreatePolicyStatement();
        factoryAction?.Invoke(policyStatementResult);

        return policyStatementResult;
    }

    private Humidifier.EntityResolution.PolicyStatement CreatePolicyStatement()
    {
        var policyStatementResult = new Humidifier.EntityResolution.PolicyStatement
        {
            GivenName = InputResourceName,
        };

        return policyStatementResult;
    }

} // End Of Class

public static class PolicyStatementFactoryExtensions
{
}
