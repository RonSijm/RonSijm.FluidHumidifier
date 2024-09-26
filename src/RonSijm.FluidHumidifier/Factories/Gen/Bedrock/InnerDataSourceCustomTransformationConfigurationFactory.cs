// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataSourceCustomTransformationConfigurationFactory(Action<Humidifier.Bedrock.DataSourceTypes.CustomTransformationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataSourceTypes.CustomTransformationConfiguration>
{

    internal InnerDataSourceIntermediateStorageFactory IntermediateStorageFactory { get; set; }

    protected override Humidifier.Bedrock.DataSourceTypes.CustomTransformationConfiguration Create()
    {
        var customTransformationConfigurationResult = CreateCustomTransformationConfiguration();
        factoryAction?.Invoke(customTransformationConfigurationResult);

        return customTransformationConfigurationResult;
    }

    private Humidifier.Bedrock.DataSourceTypes.CustomTransformationConfiguration CreateCustomTransformationConfiguration()
    {
        var customTransformationConfigurationResult = new Humidifier.Bedrock.DataSourceTypes.CustomTransformationConfiguration();

        return customTransformationConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.DataSourceTypes.CustomTransformationConfiguration result)
    {
        base.CreateChildren(result);

        result.IntermediateStorage ??= IntermediateStorageFactory?.Build();
    }

} // End Of Class

public static class InnerDataSourceCustomTransformationConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDataSourceCustomTransformationConfigurationFactory, InnerDataSourceIntermediateStorageFactory> WithIntermediateStorage(this InnerDataSourceCustomTransformationConfigurationFactory parentFactory, Action<Humidifier.Bedrock.DataSourceTypes.IntermediateStorage> subFactoryAction = null)
    {
        parentFactory.IntermediateStorageFactory = new InnerDataSourceIntermediateStorageFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IntermediateStorageFactory);
    }

    public static CombinedResult<InnerDataSourceCustomTransformationConfigurationFactory, T1, InnerDataSourceIntermediateStorageFactory> WithIntermediateStorage<T1>(this CombinedResult<InnerDataSourceCustomTransformationConfigurationFactory, T1> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.IntermediateStorage> subFactoryAction = null) => new (combinedResult, combinedResult, WithIntermediateStorage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceCustomTransformationConfigurationFactory, InnerDataSourceIntermediateStorageFactory> WithIntermediateStorage<T1>(this CombinedResult<T1, InnerDataSourceCustomTransformationConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.IntermediateStorage> subFactoryAction = null) => new (combinedResult, combinedResult, WithIntermediateStorage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataSourceCustomTransformationConfigurationFactory, T1, T2, InnerDataSourceIntermediateStorageFactory> WithIntermediateStorage<T1, T2>(this CombinedResult<InnerDataSourceCustomTransformationConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.IntermediateStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIntermediateStorage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceCustomTransformationConfigurationFactory, T2, InnerDataSourceIntermediateStorageFactory> WithIntermediateStorage<T1, T2>(this CombinedResult<T1, InnerDataSourceCustomTransformationConfigurationFactory, T2> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.IntermediateStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIntermediateStorage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceCustomTransformationConfigurationFactory, InnerDataSourceIntermediateStorageFactory> WithIntermediateStorage<T1, T2>(this CombinedResult<T1, T2, InnerDataSourceCustomTransformationConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.IntermediateStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIntermediateStorage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataSourceCustomTransformationConfigurationFactory, T1, T2, T3, InnerDataSourceIntermediateStorageFactory> WithIntermediateStorage<T1, T2, T3>(this CombinedResult<InnerDataSourceCustomTransformationConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.IntermediateStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIntermediateStorage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceCustomTransformationConfigurationFactory, T2, T3, InnerDataSourceIntermediateStorageFactory> WithIntermediateStorage<T1, T2, T3>(this CombinedResult<T1, InnerDataSourceCustomTransformationConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.IntermediateStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIntermediateStorage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceCustomTransformationConfigurationFactory, T3, InnerDataSourceIntermediateStorageFactory> WithIntermediateStorage<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSourceCustomTransformationConfigurationFactory, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.IntermediateStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIntermediateStorage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceCustomTransformationConfigurationFactory, InnerDataSourceIntermediateStorageFactory> WithIntermediateStorage<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSourceCustomTransformationConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.IntermediateStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIntermediateStorage(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataSourceCustomTransformationConfigurationFactory, T1, T2, T3, T4, InnerDataSourceIntermediateStorageFactory> WithIntermediateStorage<T1, T2, T3, T4>(this CombinedResult<InnerDataSourceCustomTransformationConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.IntermediateStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntermediateStorage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceCustomTransformationConfigurationFactory, T2, T3, T4, InnerDataSourceIntermediateStorageFactory> WithIntermediateStorage<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSourceCustomTransformationConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.IntermediateStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntermediateStorage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceCustomTransformationConfigurationFactory, T3, T4, InnerDataSourceIntermediateStorageFactory> WithIntermediateStorage<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSourceCustomTransformationConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.IntermediateStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntermediateStorage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceCustomTransformationConfigurationFactory, T4, InnerDataSourceIntermediateStorageFactory> WithIntermediateStorage<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSourceCustomTransformationConfigurationFactory, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.IntermediateStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntermediateStorage(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataSourceCustomTransformationConfigurationFactory, InnerDataSourceIntermediateStorageFactory> WithIntermediateStorage<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSourceCustomTransformationConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.IntermediateStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntermediateStorage(combinedResult.T5, subFactoryAction));
}
