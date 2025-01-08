// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VpcLattice;

public class ResourceConfigurationFactory(string resourceName = null, Action<Humidifier.VpcLattice.ResourceConfiguration> factoryAction = null) : ResourceFactory<Humidifier.VpcLattice.ResourceConfiguration>(resourceName)
{

    internal InnerResourceConfigurationResourceConfigurationDefinitionFactory ResourceConfigurationDefinitionFactory { get; set; }

    protected override Humidifier.VpcLattice.ResourceConfiguration Create()
    {
        var resourceConfigurationResult = CreateResourceConfiguration();
        factoryAction?.Invoke(resourceConfigurationResult);

        return resourceConfigurationResult;
    }

    private Humidifier.VpcLattice.ResourceConfiguration CreateResourceConfiguration()
    {
        var resourceConfigurationResult = new Humidifier.VpcLattice.ResourceConfiguration
        {
            GivenName = InputResourceName,
        };

        return resourceConfigurationResult;
    }
    public override void CreateChildren(Humidifier.VpcLattice.ResourceConfiguration result)
    {
        base.CreateChildren(result);

        result.ResourceConfigurationDefinition ??= ResourceConfigurationDefinitionFactory?.Build();
    }

} // End Of Class

public static class ResourceConfigurationFactoryExtensions
{
    public static CombinedResult<ResourceConfigurationFactory, InnerResourceConfigurationResourceConfigurationDefinitionFactory> WithResourceConfigurationDefinition(this ResourceConfigurationFactory parentFactory, Action<Humidifier.VpcLattice.ResourceConfigurationTypes.ResourceConfigurationDefinition> subFactoryAction = null)
    {
        parentFactory.ResourceConfigurationDefinitionFactory = new InnerResourceConfigurationResourceConfigurationDefinitionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ResourceConfigurationDefinitionFactory);
    }

    public static CombinedResult<ResourceConfigurationFactory, T1, InnerResourceConfigurationResourceConfigurationDefinitionFactory> WithResourceConfigurationDefinition<T1>(this CombinedResult<ResourceConfigurationFactory, T1> combinedResult, Action<Humidifier.VpcLattice.ResourceConfigurationTypes.ResourceConfigurationDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceConfigurationDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResourceConfigurationFactory, InnerResourceConfigurationResourceConfigurationDefinitionFactory> WithResourceConfigurationDefinition<T1>(this CombinedResult<T1, ResourceConfigurationFactory> combinedResult, Action<Humidifier.VpcLattice.ResourceConfigurationTypes.ResourceConfigurationDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceConfigurationDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ResourceConfigurationFactory, T1, T2, InnerResourceConfigurationResourceConfigurationDefinitionFactory> WithResourceConfigurationDefinition<T1, T2>(this CombinedResult<ResourceConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.VpcLattice.ResourceConfigurationTypes.ResourceConfigurationDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceConfigurationDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResourceConfigurationFactory, T2, InnerResourceConfigurationResourceConfigurationDefinitionFactory> WithResourceConfigurationDefinition<T1, T2>(this CombinedResult<T1, ResourceConfigurationFactory, T2> combinedResult, Action<Humidifier.VpcLattice.ResourceConfigurationTypes.ResourceConfigurationDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceConfigurationDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResourceConfigurationFactory, InnerResourceConfigurationResourceConfigurationDefinitionFactory> WithResourceConfigurationDefinition<T1, T2>(this CombinedResult<T1, T2, ResourceConfigurationFactory> combinedResult, Action<Humidifier.VpcLattice.ResourceConfigurationTypes.ResourceConfigurationDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceConfigurationDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ResourceConfigurationFactory, T1, T2, T3, InnerResourceConfigurationResourceConfigurationDefinitionFactory> WithResourceConfigurationDefinition<T1, T2, T3>(this CombinedResult<ResourceConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.VpcLattice.ResourceConfigurationTypes.ResourceConfigurationDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceConfigurationDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResourceConfigurationFactory, T2, T3, InnerResourceConfigurationResourceConfigurationDefinitionFactory> WithResourceConfigurationDefinition<T1, T2, T3>(this CombinedResult<T1, ResourceConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.VpcLattice.ResourceConfigurationTypes.ResourceConfigurationDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceConfigurationDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResourceConfigurationFactory, T3, InnerResourceConfigurationResourceConfigurationDefinitionFactory> WithResourceConfigurationDefinition<T1, T2, T3>(this CombinedResult<T1, T2, ResourceConfigurationFactory, T3> combinedResult, Action<Humidifier.VpcLattice.ResourceConfigurationTypes.ResourceConfigurationDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceConfigurationDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ResourceConfigurationFactory, InnerResourceConfigurationResourceConfigurationDefinitionFactory> WithResourceConfigurationDefinition<T1, T2, T3>(this CombinedResult<T1, T2, T3, ResourceConfigurationFactory> combinedResult, Action<Humidifier.VpcLattice.ResourceConfigurationTypes.ResourceConfigurationDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceConfigurationDefinition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ResourceConfigurationFactory, T1, T2, T3, T4, InnerResourceConfigurationResourceConfigurationDefinitionFactory> WithResourceConfigurationDefinition<T1, T2, T3, T4>(this CombinedResult<ResourceConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.ResourceConfigurationTypes.ResourceConfigurationDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceConfigurationDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResourceConfigurationFactory, T2, T3, T4, InnerResourceConfigurationResourceConfigurationDefinitionFactory> WithResourceConfigurationDefinition<T1, T2, T3, T4>(this CombinedResult<T1, ResourceConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.ResourceConfigurationTypes.ResourceConfigurationDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceConfigurationDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResourceConfigurationFactory, T3, T4, InnerResourceConfigurationResourceConfigurationDefinitionFactory> WithResourceConfigurationDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, ResourceConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.VpcLattice.ResourceConfigurationTypes.ResourceConfigurationDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceConfigurationDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ResourceConfigurationFactory, T4, InnerResourceConfigurationResourceConfigurationDefinitionFactory> WithResourceConfigurationDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ResourceConfigurationFactory, T4> combinedResult, Action<Humidifier.VpcLattice.ResourceConfigurationTypes.ResourceConfigurationDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceConfigurationDefinition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ResourceConfigurationFactory, InnerResourceConfigurationResourceConfigurationDefinitionFactory> WithResourceConfigurationDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ResourceConfigurationFactory> combinedResult, Action<Humidifier.VpcLattice.ResourceConfigurationTypes.ResourceConfigurationDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceConfigurationDefinition(combinedResult.T5, subFactoryAction));
}
