// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityAgent;

public class SecurityRequirementPackFactory(string resourceName = null, Action<Humidifier.SecurityAgent.SecurityRequirementPack> factoryAction = null) : ResourceFactory<Humidifier.SecurityAgent.SecurityRequirementPack>(resourceName)
{

    internal List<InnerSecurityRequirementPackSecurityRequirementFactory> SecurityRequirementsFactories { get; set; } = [];

    protected override Humidifier.SecurityAgent.SecurityRequirementPack Create()
    {
        var securityRequirementPackResult = CreateSecurityRequirementPack();
        factoryAction?.Invoke(securityRequirementPackResult);

        return securityRequirementPackResult;
    }

    private Humidifier.SecurityAgent.SecurityRequirementPack CreateSecurityRequirementPack()
    {
        var securityRequirementPackResult = new Humidifier.SecurityAgent.SecurityRequirementPack
        {
            GivenName = InputResourceName,
        };

        return securityRequirementPackResult;
    }
    public override void CreateChildren(Humidifier.SecurityAgent.SecurityRequirementPack result)
    {
        base.CreateChildren(result);

        result.SecurityRequirements = SecurityRequirementsFactories.Any() ? SecurityRequirementsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class SecurityRequirementPackFactoryExtensions
{
    public static CombinedResult<SecurityRequirementPackFactory, InnerSecurityRequirementPackSecurityRequirementFactory> WithSecurityRequirements(this SecurityRequirementPackFactory parentFactory, Action<Humidifier.SecurityAgent.SecurityRequirementPackTypes.SecurityRequirement> subFactoryAction = null)
    {
        var factory = new InnerSecurityRequirementPackSecurityRequirementFactory(subFactoryAction);
        parentFactory.SecurityRequirementsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<SecurityRequirementPackFactory, T1, InnerSecurityRequirementPackSecurityRequirementFactory> WithSecurityRequirements<T1>(this CombinedResult<SecurityRequirementPackFactory, T1> combinedResult, Action<Humidifier.SecurityAgent.SecurityRequirementPackTypes.SecurityRequirement> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecurityRequirements(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SecurityRequirementPackFactory, InnerSecurityRequirementPackSecurityRequirementFactory> WithSecurityRequirements<T1>(this CombinedResult<T1, SecurityRequirementPackFactory> combinedResult, Action<Humidifier.SecurityAgent.SecurityRequirementPackTypes.SecurityRequirement> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecurityRequirements(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<SecurityRequirementPackFactory, T1, T2, InnerSecurityRequirementPackSecurityRequirementFactory> WithSecurityRequirements<T1, T2>(this CombinedResult<SecurityRequirementPackFactory, T1, T2> combinedResult, Action<Humidifier.SecurityAgent.SecurityRequirementPackTypes.SecurityRequirement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecurityRequirements(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SecurityRequirementPackFactory, T2, InnerSecurityRequirementPackSecurityRequirementFactory> WithSecurityRequirements<T1, T2>(this CombinedResult<T1, SecurityRequirementPackFactory, T2> combinedResult, Action<Humidifier.SecurityAgent.SecurityRequirementPackTypes.SecurityRequirement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecurityRequirements(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SecurityRequirementPackFactory, InnerSecurityRequirementPackSecurityRequirementFactory> WithSecurityRequirements<T1, T2>(this CombinedResult<T1, T2, SecurityRequirementPackFactory> combinedResult, Action<Humidifier.SecurityAgent.SecurityRequirementPackTypes.SecurityRequirement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecurityRequirements(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<SecurityRequirementPackFactory, T1, T2, T3, InnerSecurityRequirementPackSecurityRequirementFactory> WithSecurityRequirements<T1, T2, T3>(this CombinedResult<SecurityRequirementPackFactory, T1, T2, T3> combinedResult, Action<Humidifier.SecurityAgent.SecurityRequirementPackTypes.SecurityRequirement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityRequirements(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SecurityRequirementPackFactory, T2, T3, InnerSecurityRequirementPackSecurityRequirementFactory> WithSecurityRequirements<T1, T2, T3>(this CombinedResult<T1, SecurityRequirementPackFactory, T2, T3> combinedResult, Action<Humidifier.SecurityAgent.SecurityRequirementPackTypes.SecurityRequirement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityRequirements(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SecurityRequirementPackFactory, T3, InnerSecurityRequirementPackSecurityRequirementFactory> WithSecurityRequirements<T1, T2, T3>(this CombinedResult<T1, T2, SecurityRequirementPackFactory, T3> combinedResult, Action<Humidifier.SecurityAgent.SecurityRequirementPackTypes.SecurityRequirement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityRequirements(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SecurityRequirementPackFactory, InnerSecurityRequirementPackSecurityRequirementFactory> WithSecurityRequirements<T1, T2, T3>(this CombinedResult<T1, T2, T3, SecurityRequirementPackFactory> combinedResult, Action<Humidifier.SecurityAgent.SecurityRequirementPackTypes.SecurityRequirement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityRequirements(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<SecurityRequirementPackFactory, T1, T2, T3, T4, InnerSecurityRequirementPackSecurityRequirementFactory> WithSecurityRequirements<T1, T2, T3, T4>(this CombinedResult<SecurityRequirementPackFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecurityAgent.SecurityRequirementPackTypes.SecurityRequirement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityRequirements(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SecurityRequirementPackFactory, T2, T3, T4, InnerSecurityRequirementPackSecurityRequirementFactory> WithSecurityRequirements<T1, T2, T3, T4>(this CombinedResult<T1, SecurityRequirementPackFactory, T2, T3, T4> combinedResult, Action<Humidifier.SecurityAgent.SecurityRequirementPackTypes.SecurityRequirement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityRequirements(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SecurityRequirementPackFactory, T3, T4, InnerSecurityRequirementPackSecurityRequirementFactory> WithSecurityRequirements<T1, T2, T3, T4>(this CombinedResult<T1, T2, SecurityRequirementPackFactory, T3, T4> combinedResult, Action<Humidifier.SecurityAgent.SecurityRequirementPackTypes.SecurityRequirement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityRequirements(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SecurityRequirementPackFactory, T4, InnerSecurityRequirementPackSecurityRequirementFactory> WithSecurityRequirements<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SecurityRequirementPackFactory, T4> combinedResult, Action<Humidifier.SecurityAgent.SecurityRequirementPackTypes.SecurityRequirement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityRequirements(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, SecurityRequirementPackFactory, InnerSecurityRequirementPackSecurityRequirementFactory> WithSecurityRequirements<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SecurityRequirementPackFactory> combinedResult, Action<Humidifier.SecurityAgent.SecurityRequirementPackTypes.SecurityRequirement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityRequirements(combinedResult.T5, subFactoryAction).T2);
}
