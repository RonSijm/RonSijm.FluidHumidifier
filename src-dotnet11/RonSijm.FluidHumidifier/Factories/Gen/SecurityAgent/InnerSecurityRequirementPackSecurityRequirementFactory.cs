// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityAgent;

public class InnerSecurityRequirementPackSecurityRequirementFactory(Action<Humidifier.SecurityAgent.SecurityRequirementPackTypes.SecurityRequirement> factoryAction = null) : SubResourceFactory<Humidifier.SecurityAgent.SecurityRequirementPackTypes.SecurityRequirement>
{

    protected override Humidifier.SecurityAgent.SecurityRequirementPackTypes.SecurityRequirement Create()
    {
        var securityRequirementResult = CreateSecurityRequirement();
        factoryAction?.Invoke(securityRequirementResult);

        return securityRequirementResult;
    }

    private Humidifier.SecurityAgent.SecurityRequirementPackTypes.SecurityRequirement CreateSecurityRequirement()
    {
        var securityRequirementResult = new Humidifier.SecurityAgent.SecurityRequirementPackTypes.SecurityRequirement();

        return securityRequirementResult;
    }

} // End Of Class

public static class InnerSecurityRequirementPackSecurityRequirementFactoryExtensions
{
}
