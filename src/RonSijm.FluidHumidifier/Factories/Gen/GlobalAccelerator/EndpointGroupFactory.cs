// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GlobalAccelerator;

public class EndpointGroupFactory(string resourceName = null, Action<Humidifier.GlobalAccelerator.EndpointGroup> factoryAction = null) : ResourceFactory<Humidifier.GlobalAccelerator.EndpointGroup>(resourceName)
{

    internal List<InnerEndpointGroupPortOverrideFactory> PortOverridesFactories { get; set; } = [];

    internal List<InnerEndpointGroupEndpointConfigurationFactory> EndpointConfigurationsFactories { get; set; } = [];

    protected override Humidifier.GlobalAccelerator.EndpointGroup Create()
    {
        var endpointGroupResult = CreateEndpointGroup();
        factoryAction?.Invoke(endpointGroupResult);

        return endpointGroupResult;
    }

    private Humidifier.GlobalAccelerator.EndpointGroup CreateEndpointGroup()
    {
        var endpointGroupResult = new Humidifier.GlobalAccelerator.EndpointGroup
        {
            GivenName = InputResourceName,
        };

        return endpointGroupResult;
    }
    public override void CreateChildren(Humidifier.GlobalAccelerator.EndpointGroup result)
    {
        base.CreateChildren(result);

        result.PortOverrides = PortOverridesFactories.Any() ? PortOverridesFactories.Select(x => x.Build()).ToList() : null;
        result.EndpointConfigurations = EndpointConfigurationsFactories.Any() ? EndpointConfigurationsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class EndpointGroupFactoryExtensions
{
    public static CombinedResult<EndpointGroupFactory, InnerEndpointGroupPortOverrideFactory> WithPortOverrides(this EndpointGroupFactory parentFactory, Action<Humidifier.GlobalAccelerator.EndpointGroupTypes.PortOverride> subFactoryAction = null)
    {
        var factory = new InnerEndpointGroupPortOverrideFactory(subFactoryAction);
        parentFactory.PortOverridesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<EndpointGroupFactory, InnerEndpointGroupEndpointConfigurationFactory> WithEndpointConfigurations(this EndpointGroupFactory parentFactory, Action<Humidifier.GlobalAccelerator.EndpointGroupTypes.EndpointConfiguration> subFactoryAction = null)
    {
        var factory = new InnerEndpointGroupEndpointConfigurationFactory(subFactoryAction);
        parentFactory.EndpointConfigurationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<EndpointGroupFactory, T1, InnerEndpointGroupPortOverrideFactory> WithPortOverrides<T1>(this CombinedResult<EndpointGroupFactory, T1> combinedResult, Action<Humidifier.GlobalAccelerator.EndpointGroupTypes.PortOverride> subFactoryAction = null) => new (combinedResult, combinedResult, WithPortOverrides(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EndpointGroupFactory, InnerEndpointGroupPortOverrideFactory> WithPortOverrides<T1>(this CombinedResult<T1, EndpointGroupFactory> combinedResult, Action<Humidifier.GlobalAccelerator.EndpointGroupTypes.PortOverride> subFactoryAction = null) => new (combinedResult, combinedResult, WithPortOverrides(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EndpointGroupFactory, T1, T2, InnerEndpointGroupPortOverrideFactory> WithPortOverrides<T1, T2>(this CombinedResult<EndpointGroupFactory, T1, T2> combinedResult, Action<Humidifier.GlobalAccelerator.EndpointGroupTypes.PortOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPortOverrides(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EndpointGroupFactory, T2, InnerEndpointGroupPortOverrideFactory> WithPortOverrides<T1, T2>(this CombinedResult<T1, EndpointGroupFactory, T2> combinedResult, Action<Humidifier.GlobalAccelerator.EndpointGroupTypes.PortOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPortOverrides(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EndpointGroupFactory, InnerEndpointGroupPortOverrideFactory> WithPortOverrides<T1, T2>(this CombinedResult<T1, T2, EndpointGroupFactory> combinedResult, Action<Humidifier.GlobalAccelerator.EndpointGroupTypes.PortOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPortOverrides(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EndpointGroupFactory, T1, T2, T3, InnerEndpointGroupPortOverrideFactory> WithPortOverrides<T1, T2, T3>(this CombinedResult<EndpointGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.GlobalAccelerator.EndpointGroupTypes.PortOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPortOverrides(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EndpointGroupFactory, T2, T3, InnerEndpointGroupPortOverrideFactory> WithPortOverrides<T1, T2, T3>(this CombinedResult<T1, EndpointGroupFactory, T2, T3> combinedResult, Action<Humidifier.GlobalAccelerator.EndpointGroupTypes.PortOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPortOverrides(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EndpointGroupFactory, T3, InnerEndpointGroupPortOverrideFactory> WithPortOverrides<T1, T2, T3>(this CombinedResult<T1, T2, EndpointGroupFactory, T3> combinedResult, Action<Humidifier.GlobalAccelerator.EndpointGroupTypes.PortOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPortOverrides(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EndpointGroupFactory, InnerEndpointGroupPortOverrideFactory> WithPortOverrides<T1, T2, T3>(this CombinedResult<T1, T2, T3, EndpointGroupFactory> combinedResult, Action<Humidifier.GlobalAccelerator.EndpointGroupTypes.PortOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPortOverrides(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EndpointGroupFactory, T1, T2, T3, T4, InnerEndpointGroupPortOverrideFactory> WithPortOverrides<T1, T2, T3, T4>(this CombinedResult<EndpointGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GlobalAccelerator.EndpointGroupTypes.PortOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortOverrides(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EndpointGroupFactory, T2, T3, T4, InnerEndpointGroupPortOverrideFactory> WithPortOverrides<T1, T2, T3, T4>(this CombinedResult<T1, EndpointGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.GlobalAccelerator.EndpointGroupTypes.PortOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortOverrides(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EndpointGroupFactory, T3, T4, InnerEndpointGroupPortOverrideFactory> WithPortOverrides<T1, T2, T3, T4>(this CombinedResult<T1, T2, EndpointGroupFactory, T3, T4> combinedResult, Action<Humidifier.GlobalAccelerator.EndpointGroupTypes.PortOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortOverrides(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EndpointGroupFactory, T4, InnerEndpointGroupPortOverrideFactory> WithPortOverrides<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EndpointGroupFactory, T4> combinedResult, Action<Humidifier.GlobalAccelerator.EndpointGroupTypes.PortOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortOverrides(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EndpointGroupFactory, InnerEndpointGroupPortOverrideFactory> WithPortOverrides<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EndpointGroupFactory> combinedResult, Action<Humidifier.GlobalAccelerator.EndpointGroupTypes.PortOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortOverrides(combinedResult.T5, subFactoryAction));
    public static CombinedResult<EndpointGroupFactory, T1, InnerEndpointGroupEndpointConfigurationFactory> WithEndpointConfigurations<T1>(this CombinedResult<EndpointGroupFactory, T1> combinedResult, Action<Humidifier.GlobalAccelerator.EndpointGroupTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEndpointConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EndpointGroupFactory, InnerEndpointGroupEndpointConfigurationFactory> WithEndpointConfigurations<T1>(this CombinedResult<T1, EndpointGroupFactory> combinedResult, Action<Humidifier.GlobalAccelerator.EndpointGroupTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEndpointConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EndpointGroupFactory, T1, T2, InnerEndpointGroupEndpointConfigurationFactory> WithEndpointConfigurations<T1, T2>(this CombinedResult<EndpointGroupFactory, T1, T2> combinedResult, Action<Humidifier.GlobalAccelerator.EndpointGroupTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndpointConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EndpointGroupFactory, T2, InnerEndpointGroupEndpointConfigurationFactory> WithEndpointConfigurations<T1, T2>(this CombinedResult<T1, EndpointGroupFactory, T2> combinedResult, Action<Humidifier.GlobalAccelerator.EndpointGroupTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndpointConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EndpointGroupFactory, InnerEndpointGroupEndpointConfigurationFactory> WithEndpointConfigurations<T1, T2>(this CombinedResult<T1, T2, EndpointGroupFactory> combinedResult, Action<Humidifier.GlobalAccelerator.EndpointGroupTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndpointConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EndpointGroupFactory, T1, T2, T3, InnerEndpointGroupEndpointConfigurationFactory> WithEndpointConfigurations<T1, T2, T3>(this CombinedResult<EndpointGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.GlobalAccelerator.EndpointGroupTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EndpointGroupFactory, T2, T3, InnerEndpointGroupEndpointConfigurationFactory> WithEndpointConfigurations<T1, T2, T3>(this CombinedResult<T1, EndpointGroupFactory, T2, T3> combinedResult, Action<Humidifier.GlobalAccelerator.EndpointGroupTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EndpointGroupFactory, T3, InnerEndpointGroupEndpointConfigurationFactory> WithEndpointConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, EndpointGroupFactory, T3> combinedResult, Action<Humidifier.GlobalAccelerator.EndpointGroupTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EndpointGroupFactory, InnerEndpointGroupEndpointConfigurationFactory> WithEndpointConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, T3, EndpointGroupFactory> combinedResult, Action<Humidifier.GlobalAccelerator.EndpointGroupTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointConfigurations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EndpointGroupFactory, T1, T2, T3, T4, InnerEndpointGroupEndpointConfigurationFactory> WithEndpointConfigurations<T1, T2, T3, T4>(this CombinedResult<EndpointGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GlobalAccelerator.EndpointGroupTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EndpointGroupFactory, T2, T3, T4, InnerEndpointGroupEndpointConfigurationFactory> WithEndpointConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, EndpointGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.GlobalAccelerator.EndpointGroupTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EndpointGroupFactory, T3, T4, InnerEndpointGroupEndpointConfigurationFactory> WithEndpointConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, EndpointGroupFactory, T3, T4> combinedResult, Action<Humidifier.GlobalAccelerator.EndpointGroupTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EndpointGroupFactory, T4, InnerEndpointGroupEndpointConfigurationFactory> WithEndpointConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EndpointGroupFactory, T4> combinedResult, Action<Humidifier.GlobalAccelerator.EndpointGroupTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointConfigurations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EndpointGroupFactory, InnerEndpointGroupEndpointConfigurationFactory> WithEndpointConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EndpointGroupFactory> combinedResult, Action<Humidifier.GlobalAccelerator.EndpointGroupTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointConfigurations(combinedResult.T5, subFactoryAction));
}
