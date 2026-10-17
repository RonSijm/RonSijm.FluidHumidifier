// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SupportAuthZ;

public class InnerSupportPermitPermitFactory(Action<Humidifier.SupportAuthZ.SupportPermitTypes.Permit> factoryAction = null) : SubResourceFactory<Humidifier.SupportAuthZ.SupportPermitTypes.Permit>
{

    internal InnerSupportPermitActionSetFactory ActionsFactory { get; set; }

    internal InnerSupportPermitResourceSetFactory ResourcesFactory { get; set; }

    protected override Humidifier.SupportAuthZ.SupportPermitTypes.Permit Create()
    {
        var permitResult = CreatePermit();
        factoryAction?.Invoke(permitResult);

        return permitResult;
    }

    private Humidifier.SupportAuthZ.SupportPermitTypes.Permit CreatePermit()
    {
        var permitResult = new Humidifier.SupportAuthZ.SupportPermitTypes.Permit();

        return permitResult;
    }
    public override void CreateChildren(Humidifier.SupportAuthZ.SupportPermitTypes.Permit result)
    {
        base.CreateChildren(result);

        result.Actions ??= ActionsFactory?.Build();
        result.Resources ??= ResourcesFactory?.Build();
    }

} // End Of Class

public static class InnerSupportPermitPermitFactoryExtensions
{
    public static CombinedResult<InnerSupportPermitPermitFactory, InnerSupportPermitActionSetFactory> WithActions(this InnerSupportPermitPermitFactory parentFactory, Action<Humidifier.SupportAuthZ.SupportPermitTypes.ActionSet> subFactoryAction = null)
    {
        parentFactory.ActionsFactory = new InnerSupportPermitActionSetFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ActionsFactory);
    }

    public static CombinedResult<InnerSupportPermitPermitFactory, InnerSupportPermitResourceSetFactory> WithResources(this InnerSupportPermitPermitFactory parentFactory, Action<Humidifier.SupportAuthZ.SupportPermitTypes.ResourceSet> subFactoryAction = null)
    {
        parentFactory.ResourcesFactory = new InnerSupportPermitResourceSetFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ResourcesFactory);
    }

    public static CombinedResult<InnerSupportPermitPermitFactory, T1, InnerSupportPermitActionSetFactory> WithActions<T1>(this CombinedResult<InnerSupportPermitPermitFactory, T1> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.ActionSet> subFactoryAction = null) => new (combinedResult, combinedResult, WithActions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSupportPermitPermitFactory, InnerSupportPermitActionSetFactory> WithActions<T1>(this CombinedResult<T1, InnerSupportPermitPermitFactory> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.ActionSet> subFactoryAction = null) => new (combinedResult, combinedResult, WithActions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerSupportPermitPermitFactory, T1, T2, InnerSupportPermitActionSetFactory> WithActions<T1, T2>(this CombinedResult<InnerSupportPermitPermitFactory, T1, T2> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.ActionSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSupportPermitPermitFactory, T2, InnerSupportPermitActionSetFactory> WithActions<T1, T2>(this CombinedResult<T1, InnerSupportPermitPermitFactory, T2> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.ActionSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSupportPermitPermitFactory, InnerSupportPermitActionSetFactory> WithActions<T1, T2>(this CombinedResult<T1, T2, InnerSupportPermitPermitFactory> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.ActionSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerSupportPermitPermitFactory, T1, T2, T3, InnerSupportPermitActionSetFactory> WithActions<T1, T2, T3>(this CombinedResult<InnerSupportPermitPermitFactory, T1, T2, T3> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.ActionSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSupportPermitPermitFactory, T2, T3, InnerSupportPermitActionSetFactory> WithActions<T1, T2, T3>(this CombinedResult<T1, InnerSupportPermitPermitFactory, T2, T3> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.ActionSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSupportPermitPermitFactory, T3, InnerSupportPermitActionSetFactory> WithActions<T1, T2, T3>(this CombinedResult<T1, T2, InnerSupportPermitPermitFactory, T3> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.ActionSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerSupportPermitPermitFactory, InnerSupportPermitActionSetFactory> WithActions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSupportPermitPermitFactory> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.ActionSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerSupportPermitPermitFactory, T1, T2, T3, T4, InnerSupportPermitActionSetFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<InnerSupportPermitPermitFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.ActionSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSupportPermitPermitFactory, T2, T3, T4, InnerSupportPermitActionSetFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<T1, InnerSupportPermitPermitFactory, T2, T3, T4> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.ActionSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSupportPermitPermitFactory, T3, T4, InnerSupportPermitActionSetFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSupportPermitPermitFactory, T3, T4> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.ActionSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerSupportPermitPermitFactory, T4, InnerSupportPermitActionSetFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSupportPermitPermitFactory, T4> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.ActionSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerSupportPermitPermitFactory, InnerSupportPermitActionSetFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSupportPermitPermitFactory> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.ActionSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerSupportPermitPermitFactory, T1, InnerSupportPermitResourceSetFactory> WithResources<T1>(this CombinedResult<InnerSupportPermitPermitFactory, T1> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.ResourceSet> subFactoryAction = null) => new (combinedResult, combinedResult, WithResources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSupportPermitPermitFactory, InnerSupportPermitResourceSetFactory> WithResources<T1>(this CombinedResult<T1, InnerSupportPermitPermitFactory> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.ResourceSet> subFactoryAction = null) => new (combinedResult, combinedResult, WithResources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerSupportPermitPermitFactory, T1, T2, InnerSupportPermitResourceSetFactory> WithResources<T1, T2>(this CombinedResult<InnerSupportPermitPermitFactory, T1, T2> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.ResourceSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSupportPermitPermitFactory, T2, InnerSupportPermitResourceSetFactory> WithResources<T1, T2>(this CombinedResult<T1, InnerSupportPermitPermitFactory, T2> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.ResourceSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSupportPermitPermitFactory, InnerSupportPermitResourceSetFactory> WithResources<T1, T2>(this CombinedResult<T1, T2, InnerSupportPermitPermitFactory> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.ResourceSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerSupportPermitPermitFactory, T1, T2, T3, InnerSupportPermitResourceSetFactory> WithResources<T1, T2, T3>(this CombinedResult<InnerSupportPermitPermitFactory, T1, T2, T3> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.ResourceSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSupportPermitPermitFactory, T2, T3, InnerSupportPermitResourceSetFactory> WithResources<T1, T2, T3>(this CombinedResult<T1, InnerSupportPermitPermitFactory, T2, T3> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.ResourceSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSupportPermitPermitFactory, T3, InnerSupportPermitResourceSetFactory> WithResources<T1, T2, T3>(this CombinedResult<T1, T2, InnerSupportPermitPermitFactory, T3> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.ResourceSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerSupportPermitPermitFactory, InnerSupportPermitResourceSetFactory> WithResources<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSupportPermitPermitFactory> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.ResourceSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerSupportPermitPermitFactory, T1, T2, T3, T4, InnerSupportPermitResourceSetFactory> WithResources<T1, T2, T3, T4>(this CombinedResult<InnerSupportPermitPermitFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.ResourceSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSupportPermitPermitFactory, T2, T3, T4, InnerSupportPermitResourceSetFactory> WithResources<T1, T2, T3, T4>(this CombinedResult<T1, InnerSupportPermitPermitFactory, T2, T3, T4> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.ResourceSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSupportPermitPermitFactory, T3, T4, InnerSupportPermitResourceSetFactory> WithResources<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSupportPermitPermitFactory, T3, T4> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.ResourceSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerSupportPermitPermitFactory, T4, InnerSupportPermitResourceSetFactory> WithResources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSupportPermitPermitFactory, T4> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.ResourceSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerSupportPermitPermitFactory, InnerSupportPermitResourceSetFactory> WithResources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSupportPermitPermitFactory> combinedResult, Action<Humidifier.SupportAuthZ.SupportPermitTypes.ResourceSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T5, subFactoryAction).T2);
}
