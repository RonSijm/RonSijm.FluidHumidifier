// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class InnerDatastoreFileFormatConfigurationFactory(Action<Humidifier.IoTAnalytics.DatastoreTypes.FileFormatConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IoTAnalytics.DatastoreTypes.FileFormatConfiguration>
{

    internal InnerDatastoreParquetConfigurationFactory ParquetConfigurationFactory { get; set; }

    protected override Humidifier.IoTAnalytics.DatastoreTypes.FileFormatConfiguration Create()
    {
        var fileFormatConfigurationResult = CreateFileFormatConfiguration();
        factoryAction?.Invoke(fileFormatConfigurationResult);

        return fileFormatConfigurationResult;
    }

    private Humidifier.IoTAnalytics.DatastoreTypes.FileFormatConfiguration CreateFileFormatConfiguration()
    {
        var fileFormatConfigurationResult = new Humidifier.IoTAnalytics.DatastoreTypes.FileFormatConfiguration();

        return fileFormatConfigurationResult;
    }
    public override void CreateChildren(Humidifier.IoTAnalytics.DatastoreTypes.FileFormatConfiguration result)
    {
        base.CreateChildren(result);

        result.ParquetConfiguration ??= ParquetConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerDatastoreFileFormatConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDatastoreFileFormatConfigurationFactory, InnerDatastoreParquetConfigurationFactory> WithParquetConfiguration(this InnerDatastoreFileFormatConfigurationFactory parentFactory, Action<Humidifier.IoTAnalytics.DatastoreTypes.ParquetConfiguration> subFactoryAction = null)
    {
        parentFactory.ParquetConfigurationFactory = new InnerDatastoreParquetConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ParquetConfigurationFactory);
    }

    public static CombinedResult<InnerDatastoreFileFormatConfigurationFactory, T1, InnerDatastoreParquetConfigurationFactory> WithParquetConfiguration<T1>(this CombinedResult<InnerDatastoreFileFormatConfigurationFactory, T1> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.ParquetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithParquetConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatastoreFileFormatConfigurationFactory, InnerDatastoreParquetConfigurationFactory> WithParquetConfiguration<T1>(this CombinedResult<T1, InnerDatastoreFileFormatConfigurationFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.ParquetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithParquetConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDatastoreFileFormatConfigurationFactory, T1, T2, InnerDatastoreParquetConfigurationFactory> WithParquetConfiguration<T1, T2>(this CombinedResult<InnerDatastoreFileFormatConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.ParquetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParquetConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatastoreFileFormatConfigurationFactory, T2, InnerDatastoreParquetConfigurationFactory> WithParquetConfiguration<T1, T2>(this CombinedResult<T1, InnerDatastoreFileFormatConfigurationFactory, T2> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.ParquetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParquetConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatastoreFileFormatConfigurationFactory, InnerDatastoreParquetConfigurationFactory> WithParquetConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerDatastoreFileFormatConfigurationFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.ParquetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParquetConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDatastoreFileFormatConfigurationFactory, T1, T2, T3, InnerDatastoreParquetConfigurationFactory> WithParquetConfiguration<T1, T2, T3>(this CombinedResult<InnerDatastoreFileFormatConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.ParquetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParquetConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatastoreFileFormatConfigurationFactory, T2, T3, InnerDatastoreParquetConfigurationFactory> WithParquetConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerDatastoreFileFormatConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.ParquetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParquetConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatastoreFileFormatConfigurationFactory, T3, InnerDatastoreParquetConfigurationFactory> WithParquetConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerDatastoreFileFormatConfigurationFactory, T3> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.ParquetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParquetConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatastoreFileFormatConfigurationFactory, InnerDatastoreParquetConfigurationFactory> WithParquetConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDatastoreFileFormatConfigurationFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.ParquetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParquetConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDatastoreFileFormatConfigurationFactory, T1, T2, T3, T4, InnerDatastoreParquetConfigurationFactory> WithParquetConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerDatastoreFileFormatConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.ParquetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParquetConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatastoreFileFormatConfigurationFactory, T2, T3, T4, InnerDatastoreParquetConfigurationFactory> WithParquetConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerDatastoreFileFormatConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.ParquetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParquetConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatastoreFileFormatConfigurationFactory, T3, T4, InnerDatastoreParquetConfigurationFactory> WithParquetConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDatastoreFileFormatConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.ParquetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParquetConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatastoreFileFormatConfigurationFactory, T4, InnerDatastoreParquetConfigurationFactory> WithParquetConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDatastoreFileFormatConfigurationFactory, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.ParquetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParquetConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDatastoreFileFormatConfigurationFactory, InnerDatastoreParquetConfigurationFactory> WithParquetConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDatastoreFileFormatConfigurationFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.ParquetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParquetConfiguration(combinedResult.T5, subFactoryAction));
}
