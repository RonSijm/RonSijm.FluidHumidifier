// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class InnerDomainDataStoreFactory(Action<Humidifier.CustomerProfiles.DomainTypes.DataStore> factoryAction = null) : SubResourceFactory<Humidifier.CustomerProfiles.DomainTypes.DataStore>
{

    internal InnerDomainReadinessFactory ReadinessFactory { get; set; }

    protected override Humidifier.CustomerProfiles.DomainTypes.DataStore Create()
    {
        var dataStoreResult = CreateDataStore();
        factoryAction?.Invoke(dataStoreResult);

        return dataStoreResult;
    }

    private Humidifier.CustomerProfiles.DomainTypes.DataStore CreateDataStore()
    {
        var dataStoreResult = new Humidifier.CustomerProfiles.DomainTypes.DataStore();

        return dataStoreResult;
    }
    public override void CreateChildren(Humidifier.CustomerProfiles.DomainTypes.DataStore result)
    {
        base.CreateChildren(result);

        result.Readiness ??= ReadinessFactory?.Build();
    }

} // End Of Class

public static class InnerDomainDataStoreFactoryExtensions
{
    public static CombinedResult<InnerDomainDataStoreFactory, InnerDomainReadinessFactory> WithReadiness(this InnerDomainDataStoreFactory parentFactory, Action<Humidifier.CustomerProfiles.DomainTypes.Readiness> subFactoryAction = null)
    {
        parentFactory.ReadinessFactory = new InnerDomainReadinessFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ReadinessFactory);
    }

    public static CombinedResult<InnerDomainDataStoreFactory, T1, InnerDomainReadinessFactory> WithReadiness<T1>(this CombinedResult<InnerDomainDataStoreFactory, T1> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Readiness> subFactoryAction = null) => new (combinedResult, combinedResult, WithReadiness(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDomainDataStoreFactory, InnerDomainReadinessFactory> WithReadiness<T1>(this CombinedResult<T1, InnerDomainDataStoreFactory> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Readiness> subFactoryAction = null) => new (combinedResult, combinedResult, WithReadiness(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDomainDataStoreFactory, T1, T2, InnerDomainReadinessFactory> WithReadiness<T1, T2>(this CombinedResult<InnerDomainDataStoreFactory, T1, T2> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Readiness> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReadiness(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDomainDataStoreFactory, T2, InnerDomainReadinessFactory> WithReadiness<T1, T2>(this CombinedResult<T1, InnerDomainDataStoreFactory, T2> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Readiness> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReadiness(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDomainDataStoreFactory, InnerDomainReadinessFactory> WithReadiness<T1, T2>(this CombinedResult<T1, T2, InnerDomainDataStoreFactory> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Readiness> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReadiness(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDomainDataStoreFactory, T1, T2, T3, InnerDomainReadinessFactory> WithReadiness<T1, T2, T3>(this CombinedResult<InnerDomainDataStoreFactory, T1, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Readiness> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReadiness(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDomainDataStoreFactory, T2, T3, InnerDomainReadinessFactory> WithReadiness<T1, T2, T3>(this CombinedResult<T1, InnerDomainDataStoreFactory, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Readiness> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReadiness(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDomainDataStoreFactory, T3, InnerDomainReadinessFactory> WithReadiness<T1, T2, T3>(this CombinedResult<T1, T2, InnerDomainDataStoreFactory, T3> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Readiness> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReadiness(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDomainDataStoreFactory, InnerDomainReadinessFactory> WithReadiness<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDomainDataStoreFactory> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Readiness> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReadiness(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDomainDataStoreFactory, T1, T2, T3, T4, InnerDomainReadinessFactory> WithReadiness<T1, T2, T3, T4>(this CombinedResult<InnerDomainDataStoreFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Readiness> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReadiness(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDomainDataStoreFactory, T2, T3, T4, InnerDomainReadinessFactory> WithReadiness<T1, T2, T3, T4>(this CombinedResult<T1, InnerDomainDataStoreFactory, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Readiness> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReadiness(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDomainDataStoreFactory, T3, T4, InnerDomainReadinessFactory> WithReadiness<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDomainDataStoreFactory, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Readiness> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReadiness(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDomainDataStoreFactory, T4, InnerDomainReadinessFactory> WithReadiness<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDomainDataStoreFactory, T4> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Readiness> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReadiness(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDomainDataStoreFactory, InnerDomainReadinessFactory> WithReadiness<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDomainDataStoreFactory> combinedResult, Action<Humidifier.CustomerProfiles.DomainTypes.Readiness> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReadiness(combinedResult.T5, subFactoryAction).T2);
}
