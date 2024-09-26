// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class InnerDomainAutoMergingFactory(Action<Humidifier.CustomerProfiles.DomainTypes.AutoMerging> factoryAction = null) : SubResourceFactory<Humidifier.CustomerProfiles.DomainTypes.AutoMerging>
{

    internal InnerDomainConsolidationFactory ConsolidationFactory { get; set; }

    internal InnerDomainConflictResolutionFactory ConflictResolutionFactory { get; set; }

    protected override Humidifier.CustomerProfiles.DomainTypes.AutoMerging Create()
    {
        var autoMergingResult = CreateAutoMerging();
        factoryAction?.Invoke(autoMergingResult);

        return autoMergingResult;
    }

    private Humidifier.CustomerProfiles.DomainTypes.AutoMerging CreateAutoMerging()
    {
        var autoMergingResult = new Humidifier.CustomerProfiles.DomainTypes.AutoMerging();

        return autoMergingResult;
    }
    public override void CreateChildren(Humidifier.CustomerProfiles.DomainTypes.AutoMerging result)
    {
        base.CreateChildren(result);

        result.Consolidation ??= ConsolidationFactory?.Build();
        result.ConflictResolution ??= ConflictResolutionFactory?.Build();
    }

} // End Of Class

public static class InnerDomainAutoMergingFactoryExtensions
{
    public static CombinedResult<InnerDomainAutoMergingFactory, InnerDomainConsolidationFactory> WithConsolidation(this InnerDomainAutoMergingFactory parentFactory, Action<Humidifier.CustomerProfiles.DomainTypes.Consolidation> subFactoryAction = null)
    {
        parentFactory.ConsolidationFactory = new InnerDomainConsolidationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConsolidationFactory);
    }

    public static CombinedResult<InnerDomainAutoMergingFactory, InnerDomainConflictResolutionFactory> WithConflictResolution(this InnerDomainAutoMergingFactory parentFactory, Action<Humidifier.CustomerProfiles.DomainTypes.ConflictResolution> subFactoryAction = null)
    {
        parentFactory.ConflictResolutionFactory = new InnerDomainConflictResolutionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConflictResolutionFactory);
    }

    public static CombinedResult<InnerDomainAutoMergingFactory, T1, InnerDomainConsolidationFactory> WithConsolidation<T1>(this CombinedResult<InnerDomainAutoMergingFactory, T1> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Consolidation> subFactoryAction = null) => new (combinedResult, combinedResult, WithConsolidation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainAutoMergingFactory, InnerDomainConsolidationFactory> WithConsolidation<T1>(this CombinedResult<T1, InnerDomainAutoMergingFactory> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Consolidation> subFactoryAction = null) => new (combinedResult, combinedResult, WithConsolidation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDomainAutoMergingFactory, T1, T2, InnerDomainConsolidationFactory> WithConsolidation<T1, T2>(this CombinedResult<InnerDomainAutoMergingFactory, T1, T2> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Consolidation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConsolidation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainAutoMergingFactory, T2, InnerDomainConsolidationFactory> WithConsolidation<T1, T2>(this CombinedResult<T1, InnerDomainAutoMergingFactory, T2> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Consolidation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConsolidation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainAutoMergingFactory, InnerDomainConsolidationFactory> WithConsolidation<T1, T2>(this CombinedResult<T1, T2, InnerDomainAutoMergingFactory> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Consolidation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConsolidation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDomainAutoMergingFactory, T1, T2, T3, InnerDomainConsolidationFactory> WithConsolidation<T1, T2, T3>(this CombinedResult<InnerDomainAutoMergingFactory, T1, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Consolidation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConsolidation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainAutoMergingFactory, T2, T3, InnerDomainConsolidationFactory> WithConsolidation<T1, T2, T3>(this CombinedResult<T1, InnerDomainAutoMergingFactory, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Consolidation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConsolidation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainAutoMergingFactory, T3, InnerDomainConsolidationFactory> WithConsolidation<T1, T2, T3>(this CombinedResult<T1, T2, InnerDomainAutoMergingFactory, T3> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Consolidation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConsolidation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainAutoMergingFactory, InnerDomainConsolidationFactory> WithConsolidation<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDomainAutoMergingFactory> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Consolidation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConsolidation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDomainAutoMergingFactory, T1, T2, T3, T4, InnerDomainConsolidationFactory> WithConsolidation<T1, T2, T3, T4>(this CombinedResult<InnerDomainAutoMergingFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Consolidation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConsolidation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainAutoMergingFactory, T2, T3, T4, InnerDomainConsolidationFactory> WithConsolidation<T1, T2, T3, T4>(this CombinedResult<T1, InnerDomainAutoMergingFactory, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Consolidation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConsolidation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainAutoMergingFactory, T3, T4, InnerDomainConsolidationFactory> WithConsolidation<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDomainAutoMergingFactory, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Consolidation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConsolidation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainAutoMergingFactory, T4, InnerDomainConsolidationFactory> WithConsolidation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDomainAutoMergingFactory, T4> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Consolidation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConsolidation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDomainAutoMergingFactory, InnerDomainConsolidationFactory> WithConsolidation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDomainAutoMergingFactory> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Consolidation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConsolidation(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerDomainAutoMergingFactory, T1, InnerDomainConflictResolutionFactory> WithConflictResolution<T1>(this CombinedResult<InnerDomainAutoMergingFactory, T1> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.ConflictResolution> subFactoryAction = null) => new (combinedResult, combinedResult, WithConflictResolution(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainAutoMergingFactory, InnerDomainConflictResolutionFactory> WithConflictResolution<T1>(this CombinedResult<T1, InnerDomainAutoMergingFactory> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.ConflictResolution> subFactoryAction = null) => new (combinedResult, combinedResult, WithConflictResolution(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDomainAutoMergingFactory, T1, T2, InnerDomainConflictResolutionFactory> WithConflictResolution<T1, T2>(this CombinedResult<InnerDomainAutoMergingFactory, T1, T2> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.ConflictResolution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConflictResolution(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainAutoMergingFactory, T2, InnerDomainConflictResolutionFactory> WithConflictResolution<T1, T2>(this CombinedResult<T1, InnerDomainAutoMergingFactory, T2> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.ConflictResolution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConflictResolution(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainAutoMergingFactory, InnerDomainConflictResolutionFactory> WithConflictResolution<T1, T2>(this CombinedResult<T1, T2, InnerDomainAutoMergingFactory> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.ConflictResolution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConflictResolution(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDomainAutoMergingFactory, T1, T2, T3, InnerDomainConflictResolutionFactory> WithConflictResolution<T1, T2, T3>(this CombinedResult<InnerDomainAutoMergingFactory, T1, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.ConflictResolution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConflictResolution(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainAutoMergingFactory, T2, T3, InnerDomainConflictResolutionFactory> WithConflictResolution<T1, T2, T3>(this CombinedResult<T1, InnerDomainAutoMergingFactory, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.ConflictResolution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConflictResolution(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainAutoMergingFactory, T3, InnerDomainConflictResolutionFactory> WithConflictResolution<T1, T2, T3>(this CombinedResult<T1, T2, InnerDomainAutoMergingFactory, T3> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.ConflictResolution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConflictResolution(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainAutoMergingFactory, InnerDomainConflictResolutionFactory> WithConflictResolution<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDomainAutoMergingFactory> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.ConflictResolution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConflictResolution(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDomainAutoMergingFactory, T1, T2, T3, T4, InnerDomainConflictResolutionFactory> WithConflictResolution<T1, T2, T3, T4>(this CombinedResult<InnerDomainAutoMergingFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.ConflictResolution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConflictResolution(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainAutoMergingFactory, T2, T3, T4, InnerDomainConflictResolutionFactory> WithConflictResolution<T1, T2, T3, T4>(this CombinedResult<T1, InnerDomainAutoMergingFactory, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.ConflictResolution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConflictResolution(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainAutoMergingFactory, T3, T4, InnerDomainConflictResolutionFactory> WithConflictResolution<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDomainAutoMergingFactory, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.ConflictResolution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConflictResolution(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainAutoMergingFactory, T4, InnerDomainConflictResolutionFactory> WithConflictResolution<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDomainAutoMergingFactory, T4> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.ConflictResolution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConflictResolution(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDomainAutoMergingFactory, InnerDomainConflictResolutionFactory> WithConflictResolution<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDomainAutoMergingFactory> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.ConflictResolution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConflictResolution(combinedResult.T5, subFactoryAction));
}
