// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VpcLattice;

public class InnerResourceConfigurationResourceConfigurationDefinitionFactory(Action<Humidifier.VpcLattice.ResourceConfigurationTypes.ResourceConfigurationDefinition> factoryAction = null) : SubResourceFactory<Humidifier.VpcLattice.ResourceConfigurationTypes.ResourceConfigurationDefinition>
{

    internal InnerResourceConfigurationDnsResourceFactory DnsResourceFactory { get; set; }

    protected override Humidifier.VpcLattice.ResourceConfigurationTypes.ResourceConfigurationDefinition Create()
    {
        var resourceConfigurationDefinitionResult = CreateResourceConfigurationDefinition();
        factoryAction?.Invoke(resourceConfigurationDefinitionResult);

        return resourceConfigurationDefinitionResult;
    }

    private Humidifier.VpcLattice.ResourceConfigurationTypes.ResourceConfigurationDefinition CreateResourceConfigurationDefinition()
    {
        var resourceConfigurationDefinitionResult = new Humidifier.VpcLattice.ResourceConfigurationTypes.ResourceConfigurationDefinition();

        return resourceConfigurationDefinitionResult;
    }
    public override void CreateChildren(Humidifier.VpcLattice.ResourceConfigurationTypes.ResourceConfigurationDefinition result)
    {
        base.CreateChildren(result);

        result.DnsResource ??= DnsResourceFactory?.Build();
    }

} // End Of Class

public static class InnerResourceConfigurationResourceConfigurationDefinitionFactoryExtensions
{
    public static CombinedResult<InnerResourceConfigurationResourceConfigurationDefinitionFactory, InnerResourceConfigurationDnsResourceFactory> WithDnsResource(this InnerResourceConfigurationResourceConfigurationDefinitionFactory parentFactory, Action<Humidifier.VpcLattice.ResourceConfigurationTypes.DnsResource> subFactoryAction = null)
    {
        parentFactory.DnsResourceFactory = new InnerResourceConfigurationDnsResourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DnsResourceFactory);
    }

    public static CombinedResult<InnerResourceConfigurationResourceConfigurationDefinitionFactory, T1, InnerResourceConfigurationDnsResourceFactory> WithDnsResource<T1>(this CombinedResult<InnerResourceConfigurationResourceConfigurationDefinitionFactory, T1> combinedResult, Action<Humidifier.VpcLattice.ResourceConfigurationTypes.DnsResource> subFactoryAction = null) => new (combinedResult, combinedResult, WithDnsResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceConfigurationResourceConfigurationDefinitionFactory, InnerResourceConfigurationDnsResourceFactory> WithDnsResource<T1>(this CombinedResult<T1, InnerResourceConfigurationResourceConfigurationDefinitionFactory> combinedResult, Action<Humidifier.VpcLattice.ResourceConfigurationTypes.DnsResource> subFactoryAction = null) => new (combinedResult, combinedResult, WithDnsResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerResourceConfigurationResourceConfigurationDefinitionFactory, T1, T2, InnerResourceConfigurationDnsResourceFactory> WithDnsResource<T1, T2>(this CombinedResult<InnerResourceConfigurationResourceConfigurationDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.VpcLattice.ResourceConfigurationTypes.DnsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDnsResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceConfigurationResourceConfigurationDefinitionFactory, T2, InnerResourceConfigurationDnsResourceFactory> WithDnsResource<T1, T2>(this CombinedResult<T1, InnerResourceConfigurationResourceConfigurationDefinitionFactory, T2> combinedResult, Action<Humidifier.VpcLattice.ResourceConfigurationTypes.DnsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDnsResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceConfigurationResourceConfigurationDefinitionFactory, InnerResourceConfigurationDnsResourceFactory> WithDnsResource<T1, T2>(this CombinedResult<T1, T2, InnerResourceConfigurationResourceConfigurationDefinitionFactory> combinedResult, Action<Humidifier.VpcLattice.ResourceConfigurationTypes.DnsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDnsResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerResourceConfigurationResourceConfigurationDefinitionFactory, T1, T2, T3, InnerResourceConfigurationDnsResourceFactory> WithDnsResource<T1, T2, T3>(this CombinedResult<InnerResourceConfigurationResourceConfigurationDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.VpcLattice.ResourceConfigurationTypes.DnsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceConfigurationResourceConfigurationDefinitionFactory, T2, T3, InnerResourceConfigurationDnsResourceFactory> WithDnsResource<T1, T2, T3>(this CombinedResult<T1, InnerResourceConfigurationResourceConfigurationDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.VpcLattice.ResourceConfigurationTypes.DnsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceConfigurationResourceConfigurationDefinitionFactory, T3, InnerResourceConfigurationDnsResourceFactory> WithDnsResource<T1, T2, T3>(this CombinedResult<T1, T2, InnerResourceConfigurationResourceConfigurationDefinitionFactory, T3> combinedResult, Action<Humidifier.VpcLattice.ResourceConfigurationTypes.DnsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResourceConfigurationResourceConfigurationDefinitionFactory, InnerResourceConfigurationDnsResourceFactory> WithDnsResource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerResourceConfigurationResourceConfigurationDefinitionFactory> combinedResult, Action<Humidifier.VpcLattice.ResourceConfigurationTypes.DnsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsResource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerResourceConfigurationResourceConfigurationDefinitionFactory, T1, T2, T3, T4, InnerResourceConfigurationDnsResourceFactory> WithDnsResource<T1, T2, T3, T4>(this CombinedResult<InnerResourceConfigurationResourceConfigurationDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.ResourceConfigurationTypes.DnsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceConfigurationResourceConfigurationDefinitionFactory, T2, T3, T4, InnerResourceConfigurationDnsResourceFactory> WithDnsResource<T1, T2, T3, T4>(this CombinedResult<T1, InnerResourceConfigurationResourceConfigurationDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.ResourceConfigurationTypes.DnsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceConfigurationResourceConfigurationDefinitionFactory, T3, T4, InnerResourceConfigurationDnsResourceFactory> WithDnsResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerResourceConfigurationResourceConfigurationDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.VpcLattice.ResourceConfigurationTypes.DnsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResourceConfigurationResourceConfigurationDefinitionFactory, T4, InnerResourceConfigurationDnsResourceFactory> WithDnsResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerResourceConfigurationResourceConfigurationDefinitionFactory, T4> combinedResult, Action<Humidifier.VpcLattice.ResourceConfigurationTypes.DnsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsResource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerResourceConfigurationResourceConfigurationDefinitionFactory, InnerResourceConfigurationDnsResourceFactory> WithDnsResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerResourceConfigurationResourceConfigurationDefinitionFactory> combinedResult, Action<Humidifier.VpcLattice.ResourceConfigurationTypes.DnsResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsResource(combinedResult.T5, subFactoryAction));
}
