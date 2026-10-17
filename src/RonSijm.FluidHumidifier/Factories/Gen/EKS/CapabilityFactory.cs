// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class CapabilityFactory(string resourceName = null, Action<Humidifier.EKS.Capability> factoryAction = null) : ResourceFactory<Humidifier.EKS.Capability>(resourceName)
{

    internal InnerCapabilityCapabilityConfigurationFactory ConfigurationFactory { get; set; }

    protected override Humidifier.EKS.Capability Create()
    {
        var capabilityResult = CreateCapability();
        factoryAction?.Invoke(capabilityResult);

        return capabilityResult;
    }

    private Humidifier.EKS.Capability CreateCapability()
    {
        var capabilityResult = new Humidifier.EKS.Capability
        {
            GivenName = InputResourceName,
        };

        return capabilityResult;
    }
    public override void CreateChildren(Humidifier.EKS.Capability result)
    {
        base.CreateChildren(result);

        result.Configuration ??= ConfigurationFactory?.Build();
    }

} // End Of Class

public static class CapabilityFactoryExtensions
{
    public static CombinedResult<CapabilityFactory, InnerCapabilityCapabilityConfigurationFactory> WithConfiguration(this CapabilityFactory parentFactory, Action<Humidifier.EKS.CapabilityTypes.CapabilityConfiguration> subFactoryAction = null)
    {
        parentFactory.ConfigurationFactory = new InnerCapabilityCapabilityConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigurationFactory);
    }

    public static CombinedResult<CapabilityFactory, T1, InnerCapabilityCapabilityConfigurationFactory> WithConfiguration<T1>(this CombinedResult<CapabilityFactory, T1> combinedResult, Action<Humidifier.EKS.CapabilityTypes.CapabilityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CapabilityFactory, InnerCapabilityCapabilityConfigurationFactory> WithConfiguration<T1>(this CombinedResult<T1, CapabilityFactory> combinedResult, Action<Humidifier.EKS.CapabilityTypes.CapabilityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<CapabilityFactory, T1, T2, InnerCapabilityCapabilityConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<CapabilityFactory, T1, T2> combinedResult, Action<Humidifier.EKS.CapabilityTypes.CapabilityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CapabilityFactory, T2, InnerCapabilityCapabilityConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, CapabilityFactory, T2> combinedResult, Action<Humidifier.EKS.CapabilityTypes.CapabilityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CapabilityFactory, InnerCapabilityCapabilityConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, T2, CapabilityFactory> combinedResult, Action<Humidifier.EKS.CapabilityTypes.CapabilityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<CapabilityFactory, T1, T2, T3, InnerCapabilityCapabilityConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<CapabilityFactory, T1, T2, T3> combinedResult, Action<Humidifier.EKS.CapabilityTypes.CapabilityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CapabilityFactory, T2, T3, InnerCapabilityCapabilityConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, CapabilityFactory, T2, T3> combinedResult, Action<Humidifier.EKS.CapabilityTypes.CapabilityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CapabilityFactory, T3, InnerCapabilityCapabilityConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, CapabilityFactory, T3> combinedResult, Action<Humidifier.EKS.CapabilityTypes.CapabilityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CapabilityFactory, InnerCapabilityCapabilityConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, CapabilityFactory> combinedResult, Action<Humidifier.EKS.CapabilityTypes.CapabilityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<CapabilityFactory, T1, T2, T3, T4, InnerCapabilityCapabilityConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<CapabilityFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EKS.CapabilityTypes.CapabilityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CapabilityFactory, T2, T3, T4, InnerCapabilityCapabilityConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, CapabilityFactory, T2, T3, T4> combinedResult, Action<Humidifier.EKS.CapabilityTypes.CapabilityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CapabilityFactory, T3, T4, InnerCapabilityCapabilityConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, CapabilityFactory, T3, T4> combinedResult, Action<Humidifier.EKS.CapabilityTypes.CapabilityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CapabilityFactory, T4, InnerCapabilityCapabilityConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CapabilityFactory, T4> combinedResult, Action<Humidifier.EKS.CapabilityTypes.CapabilityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, CapabilityFactory, InnerCapabilityCapabilityConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CapabilityFactory> combinedResult, Action<Humidifier.EKS.CapabilityTypes.CapabilityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T5, subFactoryAction).T2);
}
