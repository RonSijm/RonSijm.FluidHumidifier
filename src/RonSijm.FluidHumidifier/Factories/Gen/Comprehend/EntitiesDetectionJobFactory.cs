// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Comprehend;

public class EntitiesDetectionJobFactory(string resourceName = null, Action<Humidifier.Comprehend.EntitiesDetectionJob> factoryAction = null) : ResourceFactory<Humidifier.Comprehend.EntitiesDetectionJob>(resourceName)
{

    internal InnerEntitiesDetectionJobInputDataConfigFactory InputDataConfigFactory { get; set; }

    protected override Humidifier.Comprehend.EntitiesDetectionJob Create()
    {
        var entitiesDetectionJobResult = CreateEntitiesDetectionJob();
        factoryAction?.Invoke(entitiesDetectionJobResult);

        return entitiesDetectionJobResult;
    }

    private Humidifier.Comprehend.EntitiesDetectionJob CreateEntitiesDetectionJob()
    {
        var entitiesDetectionJobResult = new Humidifier.Comprehend.EntitiesDetectionJob
        {
            GivenName = InputResourceName,
        };

        return entitiesDetectionJobResult;
    }
    public override void CreateChildren(Humidifier.Comprehend.EntitiesDetectionJob result)
    {
        base.CreateChildren(result);

        result.InputDataConfig ??= InputDataConfigFactory?.Build();
    }

} // End Of Class

public static class EntitiesDetectionJobFactoryExtensions
{
    public static CombinedResult<EntitiesDetectionJobFactory, InnerEntitiesDetectionJobInputDataConfigFactory> WithInputDataConfig(this EntitiesDetectionJobFactory parentFactory, Action<Humidifier.Comprehend.EntitiesDetectionJobTypes.InputDataConfig> subFactoryAction = null)
    {
        parentFactory.InputDataConfigFactory = new InnerEntitiesDetectionJobInputDataConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InputDataConfigFactory);
    }

    public static CombinedResult<EntitiesDetectionJobFactory, T1, InnerEntitiesDetectionJobInputDataConfigFactory> WithInputDataConfig<T1>(this CombinedResult<EntitiesDetectionJobFactory, T1> combinedResult, Action<Humidifier.Comprehend.EntitiesDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputDataConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EntitiesDetectionJobFactory, InnerEntitiesDetectionJobInputDataConfigFactory> WithInputDataConfig<T1>(this CombinedResult<T1, EntitiesDetectionJobFactory> combinedResult, Action<Humidifier.Comprehend.EntitiesDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputDataConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<EntitiesDetectionJobFactory, T1, T2, InnerEntitiesDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2>(this CombinedResult<EntitiesDetectionJobFactory, T1, T2> combinedResult, Action<Humidifier.Comprehend.EntitiesDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EntitiesDetectionJobFactory, T2, InnerEntitiesDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2>(this CombinedResult<T1, EntitiesDetectionJobFactory, T2> combinedResult, Action<Humidifier.Comprehend.EntitiesDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EntitiesDetectionJobFactory, InnerEntitiesDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2>(this CombinedResult<T1, T2, EntitiesDetectionJobFactory> combinedResult, Action<Humidifier.Comprehend.EntitiesDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<EntitiesDetectionJobFactory, T1, T2, T3, InnerEntitiesDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3>(this CombinedResult<EntitiesDetectionJobFactory, T1, T2, T3> combinedResult, Action<Humidifier.Comprehend.EntitiesDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EntitiesDetectionJobFactory, T2, T3, InnerEntitiesDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3>(this CombinedResult<T1, EntitiesDetectionJobFactory, T2, T3> combinedResult, Action<Humidifier.Comprehend.EntitiesDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EntitiesDetectionJobFactory, T3, InnerEntitiesDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3>(this CombinedResult<T1, T2, EntitiesDetectionJobFactory, T3> combinedResult, Action<Humidifier.Comprehend.EntitiesDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, EntitiesDetectionJobFactory, InnerEntitiesDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, EntitiesDetectionJobFactory> combinedResult, Action<Humidifier.Comprehend.EntitiesDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<EntitiesDetectionJobFactory, T1, T2, T3, T4, InnerEntitiesDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3, T4>(this CombinedResult<EntitiesDetectionJobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Comprehend.EntitiesDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EntitiesDetectionJobFactory, T2, T3, T4, InnerEntitiesDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3, T4>(this CombinedResult<T1, EntitiesDetectionJobFactory, T2, T3, T4> combinedResult, Action<Humidifier.Comprehend.EntitiesDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EntitiesDetectionJobFactory, T3, T4, InnerEntitiesDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, EntitiesDetectionJobFactory, T3, T4> combinedResult, Action<Humidifier.Comprehend.EntitiesDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, EntitiesDetectionJobFactory, T4, InnerEntitiesDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EntitiesDetectionJobFactory, T4> combinedResult, Action<Humidifier.Comprehend.EntitiesDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, EntitiesDetectionJobFactory, InnerEntitiesDetectionJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EntitiesDetectionJobFactory> combinedResult, Action<Humidifier.Comprehend.EntitiesDetectionJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T5, subFactoryAction).T2);
}
