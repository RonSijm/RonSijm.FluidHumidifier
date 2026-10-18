// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RTBFabric;

public class InnerLinkModuleParametersFactory(Action<Humidifier.RTBFabric.LinkTypes.ModuleParameters> factoryAction = null) : SubResourceFactory<Humidifier.RTBFabric.LinkTypes.ModuleParameters>
{

    internal InnerLinkNoBidModuleParametersFactory NoBidFactory { get; set; }

    internal InnerLinkOpenRtbAttributeModuleParametersFactory OpenRtbAttributeFactory { get; set; }

    protected override Humidifier.RTBFabric.LinkTypes.ModuleParameters Create()
    {
        var moduleParametersResult = CreateModuleParameters();
        factoryAction?.Invoke(moduleParametersResult);

        return moduleParametersResult;
    }

    private Humidifier.RTBFabric.LinkTypes.ModuleParameters CreateModuleParameters()
    {
        var moduleParametersResult = new Humidifier.RTBFabric.LinkTypes.ModuleParameters();

        return moduleParametersResult;
    }
    public override void CreateChildren(Humidifier.RTBFabric.LinkTypes.ModuleParameters result)
    {
        base.CreateChildren(result);

        result.NoBid ??= NoBidFactory?.Build();
        result.OpenRtbAttribute ??= OpenRtbAttributeFactory?.Build();
    }

} // End Of Class

public static class InnerLinkModuleParametersFactoryExtensions
{
    public static CombinedResult<InnerLinkModuleParametersFactory, InnerLinkNoBidModuleParametersFactory> WithNoBid(this InnerLinkModuleParametersFactory parentFactory, Action<Humidifier.RTBFabric.LinkTypes.NoBidModuleParameters> subFactoryAction = null)
    {
        parentFactory.NoBidFactory = new InnerLinkNoBidModuleParametersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NoBidFactory);
    }

    public static CombinedResult<InnerLinkModuleParametersFactory, InnerLinkOpenRtbAttributeModuleParametersFactory> WithOpenRtbAttribute(this InnerLinkModuleParametersFactory parentFactory, Action<Humidifier.RTBFabric.LinkTypes.OpenRtbAttributeModuleParameters> subFactoryAction = null)
    {
        parentFactory.OpenRtbAttributeFactory = new InnerLinkOpenRtbAttributeModuleParametersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OpenRtbAttributeFactory);
    }

    public static CombinedResult<InnerLinkModuleParametersFactory, T1, InnerLinkNoBidModuleParametersFactory> WithNoBid<T1>(this CombinedResult<InnerLinkModuleParametersFactory, T1> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.NoBidModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithNoBid(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLinkModuleParametersFactory, InnerLinkNoBidModuleParametersFactory> WithNoBid<T1>(this CombinedResult<T1, InnerLinkModuleParametersFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.NoBidModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithNoBid(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerLinkModuleParametersFactory, T1, T2, InnerLinkNoBidModuleParametersFactory> WithNoBid<T1, T2>(this CombinedResult<InnerLinkModuleParametersFactory, T1, T2> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.NoBidModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNoBid(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLinkModuleParametersFactory, T2, InnerLinkNoBidModuleParametersFactory> WithNoBid<T1, T2>(this CombinedResult<T1, InnerLinkModuleParametersFactory, T2> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.NoBidModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNoBid(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLinkModuleParametersFactory, InnerLinkNoBidModuleParametersFactory> WithNoBid<T1, T2>(this CombinedResult<T1, T2, InnerLinkModuleParametersFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.NoBidModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNoBid(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerLinkModuleParametersFactory, T1, T2, T3, InnerLinkNoBidModuleParametersFactory> WithNoBid<T1, T2, T3>(this CombinedResult<InnerLinkModuleParametersFactory, T1, T2, T3> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.NoBidModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNoBid(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLinkModuleParametersFactory, T2, T3, InnerLinkNoBidModuleParametersFactory> WithNoBid<T1, T2, T3>(this CombinedResult<T1, InnerLinkModuleParametersFactory, T2, T3> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.NoBidModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNoBid(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLinkModuleParametersFactory, T3, InnerLinkNoBidModuleParametersFactory> WithNoBid<T1, T2, T3>(this CombinedResult<T1, T2, InnerLinkModuleParametersFactory, T3> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.NoBidModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNoBid(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLinkModuleParametersFactory, InnerLinkNoBidModuleParametersFactory> WithNoBid<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLinkModuleParametersFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.NoBidModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNoBid(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerLinkModuleParametersFactory, T1, T2, T3, T4, InnerLinkNoBidModuleParametersFactory> WithNoBid<T1, T2, T3, T4>(this CombinedResult<InnerLinkModuleParametersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.NoBidModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNoBid(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLinkModuleParametersFactory, T2, T3, T4, InnerLinkNoBidModuleParametersFactory> WithNoBid<T1, T2, T3, T4>(this CombinedResult<T1, InnerLinkModuleParametersFactory, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.NoBidModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNoBid(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLinkModuleParametersFactory, T3, T4, InnerLinkNoBidModuleParametersFactory> WithNoBid<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLinkModuleParametersFactory, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.NoBidModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNoBid(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLinkModuleParametersFactory, T4, InnerLinkNoBidModuleParametersFactory> WithNoBid<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLinkModuleParametersFactory, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.NoBidModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNoBid(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerLinkModuleParametersFactory, InnerLinkNoBidModuleParametersFactory> WithNoBid<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLinkModuleParametersFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.NoBidModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNoBid(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerLinkModuleParametersFactory, T1, InnerLinkOpenRtbAttributeModuleParametersFactory> WithOpenRtbAttribute<T1>(this CombinedResult<InnerLinkModuleParametersFactory, T1> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.OpenRtbAttributeModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithOpenRtbAttribute(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLinkModuleParametersFactory, InnerLinkOpenRtbAttributeModuleParametersFactory> WithOpenRtbAttribute<T1>(this CombinedResult<T1, InnerLinkModuleParametersFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.OpenRtbAttributeModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithOpenRtbAttribute(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerLinkModuleParametersFactory, T1, T2, InnerLinkOpenRtbAttributeModuleParametersFactory> WithOpenRtbAttribute<T1, T2>(this CombinedResult<InnerLinkModuleParametersFactory, T1, T2> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.OpenRtbAttributeModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOpenRtbAttribute(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLinkModuleParametersFactory, T2, InnerLinkOpenRtbAttributeModuleParametersFactory> WithOpenRtbAttribute<T1, T2>(this CombinedResult<T1, InnerLinkModuleParametersFactory, T2> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.OpenRtbAttributeModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOpenRtbAttribute(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLinkModuleParametersFactory, InnerLinkOpenRtbAttributeModuleParametersFactory> WithOpenRtbAttribute<T1, T2>(this CombinedResult<T1, T2, InnerLinkModuleParametersFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.OpenRtbAttributeModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOpenRtbAttribute(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerLinkModuleParametersFactory, T1, T2, T3, InnerLinkOpenRtbAttributeModuleParametersFactory> WithOpenRtbAttribute<T1, T2, T3>(this CombinedResult<InnerLinkModuleParametersFactory, T1, T2, T3> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.OpenRtbAttributeModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOpenRtbAttribute(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLinkModuleParametersFactory, T2, T3, InnerLinkOpenRtbAttributeModuleParametersFactory> WithOpenRtbAttribute<T1, T2, T3>(this CombinedResult<T1, InnerLinkModuleParametersFactory, T2, T3> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.OpenRtbAttributeModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOpenRtbAttribute(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLinkModuleParametersFactory, T3, InnerLinkOpenRtbAttributeModuleParametersFactory> WithOpenRtbAttribute<T1, T2, T3>(this CombinedResult<T1, T2, InnerLinkModuleParametersFactory, T3> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.OpenRtbAttributeModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOpenRtbAttribute(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLinkModuleParametersFactory, InnerLinkOpenRtbAttributeModuleParametersFactory> WithOpenRtbAttribute<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLinkModuleParametersFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.OpenRtbAttributeModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOpenRtbAttribute(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerLinkModuleParametersFactory, T1, T2, T3, T4, InnerLinkOpenRtbAttributeModuleParametersFactory> WithOpenRtbAttribute<T1, T2, T3, T4>(this CombinedResult<InnerLinkModuleParametersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.OpenRtbAttributeModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOpenRtbAttribute(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLinkModuleParametersFactory, T2, T3, T4, InnerLinkOpenRtbAttributeModuleParametersFactory> WithOpenRtbAttribute<T1, T2, T3, T4>(this CombinedResult<T1, InnerLinkModuleParametersFactory, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.OpenRtbAttributeModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOpenRtbAttribute(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLinkModuleParametersFactory, T3, T4, InnerLinkOpenRtbAttributeModuleParametersFactory> WithOpenRtbAttribute<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLinkModuleParametersFactory, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.OpenRtbAttributeModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOpenRtbAttribute(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLinkModuleParametersFactory, T4, InnerLinkOpenRtbAttributeModuleParametersFactory> WithOpenRtbAttribute<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLinkModuleParametersFactory, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.OpenRtbAttributeModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOpenRtbAttribute(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerLinkModuleParametersFactory, InnerLinkOpenRtbAttributeModuleParametersFactory> WithOpenRtbAttribute<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLinkModuleParametersFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.OpenRtbAttributeModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOpenRtbAttribute(combinedResult.T5, subFactoryAction).T2);
}
