// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVS;

public class CompositionFactory(string resourceName = null, Action<Humidifier.IVS.Composition> factoryAction = null) : ResourceFactory<Humidifier.IVS.Composition>(resourceName)
{

    internal List<InnerCompositionDestinationConfigurationFactory> DestinationsFactories { get; set; } = [];

    internal InnerCompositionLayoutConfigurationFactory LayoutFactory { get; set; }

    protected override Humidifier.IVS.Composition Create()
    {
        var compositionResult = CreateComposition();
        factoryAction?.Invoke(compositionResult);

        return compositionResult;
    }

    private Humidifier.IVS.Composition CreateComposition()
    {
        var compositionResult = new Humidifier.IVS.Composition
        {
            GivenName = InputResourceName,
        };

        return compositionResult;
    }
    public override void CreateChildren(Humidifier.IVS.Composition result)
    {
        base.CreateChildren(result);

        result.Destinations = DestinationsFactories.Any() ? DestinationsFactories.Select(x => x.Build()).ToList() : null;
        result.Layout ??= LayoutFactory?.Build();
    }

} // End Of Class

public static class CompositionFactoryExtensions
{
    public static CombinedResult<CompositionFactory, InnerCompositionDestinationConfigurationFactory> WithDestinations(this CompositionFactory parentFactory, Action<Humidifier.IVS.CompositionTypes.DestinationConfiguration> subFactoryAction = null)
    {
        var factory = new InnerCompositionDestinationConfigurationFactory(subFactoryAction);
        parentFactory.DestinationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<CompositionFactory, InnerCompositionLayoutConfigurationFactory> WithLayout(this CompositionFactory parentFactory, Action<Humidifier.IVS.CompositionTypes.LayoutConfiguration> subFactoryAction = null)
    {
        parentFactory.LayoutFactory = new InnerCompositionLayoutConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LayoutFactory);
    }

    public static CombinedResult<CompositionFactory, T1, InnerCompositionDestinationConfigurationFactory> WithDestinations<T1>(this CombinedResult<CompositionFactory, T1> combinedResult, Action<Humidifier.IVS.CompositionTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CompositionFactory, InnerCompositionDestinationConfigurationFactory> WithDestinations<T1>(this CombinedResult<T1, CompositionFactory> combinedResult, Action<Humidifier.IVS.CompositionTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<CompositionFactory, T1, T2, InnerCompositionDestinationConfigurationFactory> WithDestinations<T1, T2>(this CombinedResult<CompositionFactory, T1, T2> combinedResult, Action<Humidifier.IVS.CompositionTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CompositionFactory, T2, InnerCompositionDestinationConfigurationFactory> WithDestinations<T1, T2>(this CombinedResult<T1, CompositionFactory, T2> combinedResult, Action<Humidifier.IVS.CompositionTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CompositionFactory, InnerCompositionDestinationConfigurationFactory> WithDestinations<T1, T2>(this CombinedResult<T1, T2, CompositionFactory> combinedResult, Action<Humidifier.IVS.CompositionTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<CompositionFactory, T1, T2, T3, InnerCompositionDestinationConfigurationFactory> WithDestinations<T1, T2, T3>(this CombinedResult<CompositionFactory, T1, T2, T3> combinedResult, Action<Humidifier.IVS.CompositionTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CompositionFactory, T2, T3, InnerCompositionDestinationConfigurationFactory> WithDestinations<T1, T2, T3>(this CombinedResult<T1, CompositionFactory, T2, T3> combinedResult, Action<Humidifier.IVS.CompositionTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CompositionFactory, T3, InnerCompositionDestinationConfigurationFactory> WithDestinations<T1, T2, T3>(this CombinedResult<T1, T2, CompositionFactory, T3> combinedResult, Action<Humidifier.IVS.CompositionTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CompositionFactory, InnerCompositionDestinationConfigurationFactory> WithDestinations<T1, T2, T3>(this CombinedResult<T1, T2, T3, CompositionFactory> combinedResult, Action<Humidifier.IVS.CompositionTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinations(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<CompositionFactory, T1, T2, T3, T4, InnerCompositionDestinationConfigurationFactory> WithDestinations<T1, T2, T3, T4>(this CombinedResult<CompositionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IVS.CompositionTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CompositionFactory, T2, T3, T4, InnerCompositionDestinationConfigurationFactory> WithDestinations<T1, T2, T3, T4>(this CombinedResult<T1, CompositionFactory, T2, T3, T4> combinedResult, Action<Humidifier.IVS.CompositionTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CompositionFactory, T3, T4, InnerCompositionDestinationConfigurationFactory> WithDestinations<T1, T2, T3, T4>(this CombinedResult<T1, T2, CompositionFactory, T3, T4> combinedResult, Action<Humidifier.IVS.CompositionTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CompositionFactory, T4, InnerCompositionDestinationConfigurationFactory> WithDestinations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CompositionFactory, T4> combinedResult, Action<Humidifier.IVS.CompositionTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinations(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, CompositionFactory, InnerCompositionDestinationConfigurationFactory> WithDestinations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CompositionFactory> combinedResult, Action<Humidifier.IVS.CompositionTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinations(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<CompositionFactory, T1, InnerCompositionLayoutConfigurationFactory> WithLayout<T1>(this CombinedResult<CompositionFactory, T1> combinedResult, Action<Humidifier.IVS.CompositionTypes.LayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLayout(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CompositionFactory, InnerCompositionLayoutConfigurationFactory> WithLayout<T1>(this CombinedResult<T1, CompositionFactory> combinedResult, Action<Humidifier.IVS.CompositionTypes.LayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLayout(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<CompositionFactory, T1, T2, InnerCompositionLayoutConfigurationFactory> WithLayout<T1, T2>(this CombinedResult<CompositionFactory, T1, T2> combinedResult, Action<Humidifier.IVS.CompositionTypes.LayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLayout(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CompositionFactory, T2, InnerCompositionLayoutConfigurationFactory> WithLayout<T1, T2>(this CombinedResult<T1, CompositionFactory, T2> combinedResult, Action<Humidifier.IVS.CompositionTypes.LayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLayout(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CompositionFactory, InnerCompositionLayoutConfigurationFactory> WithLayout<T1, T2>(this CombinedResult<T1, T2, CompositionFactory> combinedResult, Action<Humidifier.IVS.CompositionTypes.LayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLayout(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<CompositionFactory, T1, T2, T3, InnerCompositionLayoutConfigurationFactory> WithLayout<T1, T2, T3>(this CombinedResult<CompositionFactory, T1, T2, T3> combinedResult, Action<Humidifier.IVS.CompositionTypes.LayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLayout(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CompositionFactory, T2, T3, InnerCompositionLayoutConfigurationFactory> WithLayout<T1, T2, T3>(this CombinedResult<T1, CompositionFactory, T2, T3> combinedResult, Action<Humidifier.IVS.CompositionTypes.LayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLayout(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CompositionFactory, T3, InnerCompositionLayoutConfigurationFactory> WithLayout<T1, T2, T3>(this CombinedResult<T1, T2, CompositionFactory, T3> combinedResult, Action<Humidifier.IVS.CompositionTypes.LayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLayout(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CompositionFactory, InnerCompositionLayoutConfigurationFactory> WithLayout<T1, T2, T3>(this CombinedResult<T1, T2, T3, CompositionFactory> combinedResult, Action<Humidifier.IVS.CompositionTypes.LayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLayout(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<CompositionFactory, T1, T2, T3, T4, InnerCompositionLayoutConfigurationFactory> WithLayout<T1, T2, T3, T4>(this CombinedResult<CompositionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IVS.CompositionTypes.LayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLayout(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CompositionFactory, T2, T3, T4, InnerCompositionLayoutConfigurationFactory> WithLayout<T1, T2, T3, T4>(this CombinedResult<T1, CompositionFactory, T2, T3, T4> combinedResult, Action<Humidifier.IVS.CompositionTypes.LayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLayout(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CompositionFactory, T3, T4, InnerCompositionLayoutConfigurationFactory> WithLayout<T1, T2, T3, T4>(this CombinedResult<T1, T2, CompositionFactory, T3, T4> combinedResult, Action<Humidifier.IVS.CompositionTypes.LayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLayout(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CompositionFactory, T4, InnerCompositionLayoutConfigurationFactory> WithLayout<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CompositionFactory, T4> combinedResult, Action<Humidifier.IVS.CompositionTypes.LayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLayout(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, CompositionFactory, InnerCompositionLayoutConfigurationFactory> WithLayout<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CompositionFactory> combinedResult, Action<Humidifier.IVS.CompositionTypes.LayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLayout(combinedResult.T5, subFactoryAction).T2);
}
