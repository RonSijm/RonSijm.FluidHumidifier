// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RTBFabric;

public class InnerLinkOpenRtbAttributeModuleParametersFactory(Action<Humidifier.RTBFabric.LinkTypes.OpenRtbAttributeModuleParameters> factoryAction = null) : SubResourceFactory<Humidifier.RTBFabric.LinkTypes.OpenRtbAttributeModuleParameters>
{

    internal InnerLinkActionFactory ActionFactory { get; set; }

    protected override Humidifier.RTBFabric.LinkTypes.OpenRtbAttributeModuleParameters Create()
    {
        var openRtbAttributeModuleParametersResult = CreateOpenRtbAttributeModuleParameters();
        factoryAction?.Invoke(openRtbAttributeModuleParametersResult);

        return openRtbAttributeModuleParametersResult;
    }

    private Humidifier.RTBFabric.LinkTypes.OpenRtbAttributeModuleParameters CreateOpenRtbAttributeModuleParameters()
    {
        var openRtbAttributeModuleParametersResult = new Humidifier.RTBFabric.LinkTypes.OpenRtbAttributeModuleParameters();

        return openRtbAttributeModuleParametersResult;
    }
    public override void CreateChildren(Humidifier.RTBFabric.LinkTypes.OpenRtbAttributeModuleParameters result)
    {
        base.CreateChildren(result);

        result.Action ??= ActionFactory?.Build();
    }

} // End Of Class

public static class InnerLinkOpenRtbAttributeModuleParametersFactoryExtensions
{
    public static CombinedResult<InnerLinkOpenRtbAttributeModuleParametersFactory, InnerLinkActionFactory> WithAction(this InnerLinkOpenRtbAttributeModuleParametersFactory parentFactory, Action<Humidifier.RTBFabric.LinkTypes.Action> subFactoryAction = null)
    {
        parentFactory.ActionFactory = new InnerLinkActionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ActionFactory);
    }

    public static CombinedResult<InnerLinkOpenRtbAttributeModuleParametersFactory, T1, InnerLinkActionFactory> WithAction<T1>(this CombinedResult<InnerLinkOpenRtbAttributeModuleParametersFactory, T1> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLinkOpenRtbAttributeModuleParametersFactory, InnerLinkActionFactory> WithAction<T1>(this CombinedResult<T1, InnerLinkOpenRtbAttributeModuleParametersFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerLinkOpenRtbAttributeModuleParametersFactory, T1, T2, InnerLinkActionFactory> WithAction<T1, T2>(this CombinedResult<InnerLinkOpenRtbAttributeModuleParametersFactory, T1, T2> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLinkOpenRtbAttributeModuleParametersFactory, T2, InnerLinkActionFactory> WithAction<T1, T2>(this CombinedResult<T1, InnerLinkOpenRtbAttributeModuleParametersFactory, T2> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLinkOpenRtbAttributeModuleParametersFactory, InnerLinkActionFactory> WithAction<T1, T2>(this CombinedResult<T1, T2, InnerLinkOpenRtbAttributeModuleParametersFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerLinkOpenRtbAttributeModuleParametersFactory, T1, T2, T3, InnerLinkActionFactory> WithAction<T1, T2, T3>(this CombinedResult<InnerLinkOpenRtbAttributeModuleParametersFactory, T1, T2, T3> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLinkOpenRtbAttributeModuleParametersFactory, T2, T3, InnerLinkActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, InnerLinkOpenRtbAttributeModuleParametersFactory, T2, T3> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLinkOpenRtbAttributeModuleParametersFactory, T3, InnerLinkActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, T2, InnerLinkOpenRtbAttributeModuleParametersFactory, T3> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLinkOpenRtbAttributeModuleParametersFactory, InnerLinkActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLinkOpenRtbAttributeModuleParametersFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerLinkOpenRtbAttributeModuleParametersFactory, T1, T2, T3, T4, InnerLinkActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<InnerLinkOpenRtbAttributeModuleParametersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLinkOpenRtbAttributeModuleParametersFactory, T2, T3, T4, InnerLinkActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, InnerLinkOpenRtbAttributeModuleParametersFactory, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLinkOpenRtbAttributeModuleParametersFactory, T3, T4, InnerLinkActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLinkOpenRtbAttributeModuleParametersFactory, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLinkOpenRtbAttributeModuleParametersFactory, T4, InnerLinkActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLinkOpenRtbAttributeModuleParametersFactory, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerLinkOpenRtbAttributeModuleParametersFactory, InnerLinkActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLinkOpenRtbAttributeModuleParametersFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T5, subFactoryAction).T2);
}
