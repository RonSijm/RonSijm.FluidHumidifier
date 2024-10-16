// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerCodeSigningConfigCodeSigningPoliciesFactory(Action<Humidifier.Lambda.CodeSigningConfigTypes.CodeSigningPolicies> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.CodeSigningConfigTypes.CodeSigningPolicies>
{

    protected override Humidifier.Lambda.CodeSigningConfigTypes.CodeSigningPolicies Create()
    {
        var codeSigningPoliciesResult = CreateCodeSigningPolicies();
        factoryAction?.Invoke(codeSigningPoliciesResult);

        return codeSigningPoliciesResult;
    }

    private Humidifier.Lambda.CodeSigningConfigTypes.CodeSigningPolicies CreateCodeSigningPolicies()
    {
        var codeSigningPoliciesResult = new Humidifier.Lambda.CodeSigningConfigTypes.CodeSigningPolicies();

        return codeSigningPoliciesResult;
    }

} // End Of Class

public static class InnerCodeSigningConfigCodeSigningPoliciesFactoryExtensions
{
}
