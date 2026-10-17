// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVS;

public class InnerCompositionLayoutConfigurationFactory(Action<Humidifier.IVS.CompositionTypes.LayoutConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IVS.CompositionTypes.LayoutConfiguration>
{

    internal InnerCompositionPipConfigurationFactory PipFactory { get; set; }

    internal InnerCompositionGridConfigurationFactory GridFactory { get; set; }

    protected override Humidifier.IVS.CompositionTypes.LayoutConfiguration Create()
    {
        var layoutConfigurationResult = CreateLayoutConfiguration();
        factoryAction?.Invoke(layoutConfigurationResult);

        return layoutConfigurationResult;
    }

    private Humidifier.IVS.CompositionTypes.LayoutConfiguration CreateLayoutConfiguration()
    {
        var layoutConfigurationResult = new Humidifier.IVS.CompositionTypes.LayoutConfiguration();

        return layoutConfigurationResult;
    }
    public override void CreateChildren(Humidifier.IVS.CompositionTypes.LayoutConfiguration result)
    {
        base.CreateChildren(result);

        result.Pip ??= PipFactory?.Build();
        result.Grid ??= GridFactory?.Build();
    }

} // End Of Class

public static class InnerCompositionLayoutConfigurationFactoryExtensions
{
    public static CombinedResult<InnerCompositionLayoutConfigurationFactory, InnerCompositionPipConfigurationFactory> WithPip(this InnerCompositionLayoutConfigurationFactory parentFactory, Action<Humidifier.IVS.CompositionTypes.PipConfiguration> subFactoryAction = null)
    {
        parentFactory.PipFactory = new InnerCompositionPipConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PipFactory);
    }

    public static CombinedResult<InnerCompositionLayoutConfigurationFactory, InnerCompositionGridConfigurationFactory> WithGrid(this InnerCompositionLayoutConfigurationFactory parentFactory, Action<Humidifier.IVS.CompositionTypes.GridConfiguration> subFactoryAction = null)
    {
        parentFactory.GridFactory = new InnerCompositionGridConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GridFactory);
    }

    public static CombinedResult<InnerCompositionLayoutConfigurationFactory, T1, InnerCompositionPipConfigurationFactory> WithPip<T1>(this CombinedResult<InnerCompositionLayoutConfigurationFactory, T1> combinedResult, Action<Humidifier.IVS.CompositionTypes.PipConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPip(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCompositionLayoutConfigurationFactory, InnerCompositionPipConfigurationFactory> WithPip<T1>(this CombinedResult<T1, InnerCompositionLayoutConfigurationFactory> combinedResult, Action<Humidifier.IVS.CompositionTypes.PipConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPip(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerCompositionLayoutConfigurationFactory, T1, T2, InnerCompositionPipConfigurationFactory> WithPip<T1, T2>(this CombinedResult<InnerCompositionLayoutConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.IVS.CompositionTypes.PipConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPip(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCompositionLayoutConfigurationFactory, T2, InnerCompositionPipConfigurationFactory> WithPip<T1, T2>(this CombinedResult<T1, InnerCompositionLayoutConfigurationFactory, T2> combinedResult, Action<Humidifier.IVS.CompositionTypes.PipConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPip(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCompositionLayoutConfigurationFactory, InnerCompositionPipConfigurationFactory> WithPip<T1, T2>(this CombinedResult<T1, T2, InnerCompositionLayoutConfigurationFactory> combinedResult, Action<Humidifier.IVS.CompositionTypes.PipConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPip(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerCompositionLayoutConfigurationFactory, T1, T2, T3, InnerCompositionPipConfigurationFactory> WithPip<T1, T2, T3>(this CombinedResult<InnerCompositionLayoutConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.IVS.CompositionTypes.PipConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPip(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCompositionLayoutConfigurationFactory, T2, T3, InnerCompositionPipConfigurationFactory> WithPip<T1, T2, T3>(this CombinedResult<T1, InnerCompositionLayoutConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.IVS.CompositionTypes.PipConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPip(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCompositionLayoutConfigurationFactory, T3, InnerCompositionPipConfigurationFactory> WithPip<T1, T2, T3>(this CombinedResult<T1, T2, InnerCompositionLayoutConfigurationFactory, T3> combinedResult, Action<Humidifier.IVS.CompositionTypes.PipConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPip(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCompositionLayoutConfigurationFactory, InnerCompositionPipConfigurationFactory> WithPip<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCompositionLayoutConfigurationFactory> combinedResult, Action<Humidifier.IVS.CompositionTypes.PipConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPip(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerCompositionLayoutConfigurationFactory, T1, T2, T3, T4, InnerCompositionPipConfigurationFactory> WithPip<T1, T2, T3, T4>(this CombinedResult<InnerCompositionLayoutConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IVS.CompositionTypes.PipConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPip(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCompositionLayoutConfigurationFactory, T2, T3, T4, InnerCompositionPipConfigurationFactory> WithPip<T1, T2, T3, T4>(this CombinedResult<T1, InnerCompositionLayoutConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.IVS.CompositionTypes.PipConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPip(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCompositionLayoutConfigurationFactory, T3, T4, InnerCompositionPipConfigurationFactory> WithPip<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCompositionLayoutConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.IVS.CompositionTypes.PipConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPip(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCompositionLayoutConfigurationFactory, T4, InnerCompositionPipConfigurationFactory> WithPip<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCompositionLayoutConfigurationFactory, T4> combinedResult, Action<Humidifier.IVS.CompositionTypes.PipConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPip(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerCompositionLayoutConfigurationFactory, InnerCompositionPipConfigurationFactory> WithPip<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCompositionLayoutConfigurationFactory> combinedResult, Action<Humidifier.IVS.CompositionTypes.PipConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPip(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerCompositionLayoutConfigurationFactory, T1, InnerCompositionGridConfigurationFactory> WithGrid<T1>(this CombinedResult<InnerCompositionLayoutConfigurationFactory, T1> combinedResult, Action<Humidifier.IVS.CompositionTypes.GridConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithGrid(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCompositionLayoutConfigurationFactory, InnerCompositionGridConfigurationFactory> WithGrid<T1>(this CombinedResult<T1, InnerCompositionLayoutConfigurationFactory> combinedResult, Action<Humidifier.IVS.CompositionTypes.GridConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithGrid(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerCompositionLayoutConfigurationFactory, T1, T2, InnerCompositionGridConfigurationFactory> WithGrid<T1, T2>(this CombinedResult<InnerCompositionLayoutConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.IVS.CompositionTypes.GridConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGrid(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCompositionLayoutConfigurationFactory, T2, InnerCompositionGridConfigurationFactory> WithGrid<T1, T2>(this CombinedResult<T1, InnerCompositionLayoutConfigurationFactory, T2> combinedResult, Action<Humidifier.IVS.CompositionTypes.GridConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGrid(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCompositionLayoutConfigurationFactory, InnerCompositionGridConfigurationFactory> WithGrid<T1, T2>(this CombinedResult<T1, T2, InnerCompositionLayoutConfigurationFactory> combinedResult, Action<Humidifier.IVS.CompositionTypes.GridConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGrid(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerCompositionLayoutConfigurationFactory, T1, T2, T3, InnerCompositionGridConfigurationFactory> WithGrid<T1, T2, T3>(this CombinedResult<InnerCompositionLayoutConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.IVS.CompositionTypes.GridConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGrid(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCompositionLayoutConfigurationFactory, T2, T3, InnerCompositionGridConfigurationFactory> WithGrid<T1, T2, T3>(this CombinedResult<T1, InnerCompositionLayoutConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.IVS.CompositionTypes.GridConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGrid(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCompositionLayoutConfigurationFactory, T3, InnerCompositionGridConfigurationFactory> WithGrid<T1, T2, T3>(this CombinedResult<T1, T2, InnerCompositionLayoutConfigurationFactory, T3> combinedResult, Action<Humidifier.IVS.CompositionTypes.GridConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGrid(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCompositionLayoutConfigurationFactory, InnerCompositionGridConfigurationFactory> WithGrid<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCompositionLayoutConfigurationFactory> combinedResult, Action<Humidifier.IVS.CompositionTypes.GridConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGrid(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerCompositionLayoutConfigurationFactory, T1, T2, T3, T4, InnerCompositionGridConfigurationFactory> WithGrid<T1, T2, T3, T4>(this CombinedResult<InnerCompositionLayoutConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IVS.CompositionTypes.GridConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGrid(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCompositionLayoutConfigurationFactory, T2, T3, T4, InnerCompositionGridConfigurationFactory> WithGrid<T1, T2, T3, T4>(this CombinedResult<T1, InnerCompositionLayoutConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.IVS.CompositionTypes.GridConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGrid(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCompositionLayoutConfigurationFactory, T3, T4, InnerCompositionGridConfigurationFactory> WithGrid<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCompositionLayoutConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.IVS.CompositionTypes.GridConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGrid(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCompositionLayoutConfigurationFactory, T4, InnerCompositionGridConfigurationFactory> WithGrid<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCompositionLayoutConfigurationFactory, T4> combinedResult, Action<Humidifier.IVS.CompositionTypes.GridConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGrid(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerCompositionLayoutConfigurationFactory, InnerCompositionGridConfigurationFactory> WithGrid<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCompositionLayoutConfigurationFactory> combinedResult, Action<Humidifier.IVS.CompositionTypes.GridConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGrid(combinedResult.T5, subFactoryAction).T2);
}
