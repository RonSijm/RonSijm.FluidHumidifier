// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Braket;

public class InnerJobInputFileConfigFactory(Action<Humidifier.Braket.JobTypes.InputFileConfig> factoryAction = null) : SubResourceFactory<Humidifier.Braket.JobTypes.InputFileConfig>
{

    internal InnerJobDataSourceFactory DataSourceFactory { get; set; }

    protected override Humidifier.Braket.JobTypes.InputFileConfig Create()
    {
        var inputFileConfigResult = CreateInputFileConfig();
        factoryAction?.Invoke(inputFileConfigResult);

        return inputFileConfigResult;
    }

    private Humidifier.Braket.JobTypes.InputFileConfig CreateInputFileConfig()
    {
        var inputFileConfigResult = new Humidifier.Braket.JobTypes.InputFileConfig();

        return inputFileConfigResult;
    }
    public override void CreateChildren(Humidifier.Braket.JobTypes.InputFileConfig result)
    {
        base.CreateChildren(result);

        result.DataSource ??= DataSourceFactory?.Build();
    }

} // End Of Class

public static class InnerJobInputFileConfigFactoryExtensions
{
    public static CombinedResult<InnerJobInputFileConfigFactory, InnerJobDataSourceFactory> WithDataSource(this InnerJobInputFileConfigFactory parentFactory, Action<Humidifier.Braket.JobTypes.DataSource> subFactoryAction = null)
    {
        parentFactory.DataSourceFactory = new InnerJobDataSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DataSourceFactory);
    }

    public static CombinedResult<InnerJobInputFileConfigFactory, T1, InnerJobDataSourceFactory> WithDataSource<T1>(this CombinedResult<InnerJobInputFileConfigFactory, T1> combinedResult, Action<Humidifier.Braket.JobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobInputFileConfigFactory, InnerJobDataSourceFactory> WithDataSource<T1>(this CombinedResult<T1, InnerJobInputFileConfigFactory> combinedResult, Action<Humidifier.Braket.JobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerJobInputFileConfigFactory, T1, T2, InnerJobDataSourceFactory> WithDataSource<T1, T2>(this CombinedResult<InnerJobInputFileConfigFactory, T1, T2> combinedResult, Action<Humidifier.Braket.JobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobInputFileConfigFactory, T2, InnerJobDataSourceFactory> WithDataSource<T1, T2>(this CombinedResult<T1, InnerJobInputFileConfigFactory, T2> combinedResult, Action<Humidifier.Braket.JobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobInputFileConfigFactory, InnerJobDataSourceFactory> WithDataSource<T1, T2>(this CombinedResult<T1, T2, InnerJobInputFileConfigFactory> combinedResult, Action<Humidifier.Braket.JobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerJobInputFileConfigFactory, T1, T2, T3, InnerJobDataSourceFactory> WithDataSource<T1, T2, T3>(this CombinedResult<InnerJobInputFileConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Braket.JobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobInputFileConfigFactory, T2, T3, InnerJobDataSourceFactory> WithDataSource<T1, T2, T3>(this CombinedResult<T1, InnerJobInputFileConfigFactory, T2, T3> combinedResult, Action<Humidifier.Braket.JobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobInputFileConfigFactory, T3, InnerJobDataSourceFactory> WithDataSource<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobInputFileConfigFactory, T3> combinedResult, Action<Humidifier.Braket.JobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobInputFileConfigFactory, InnerJobDataSourceFactory> WithDataSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobInputFileConfigFactory> combinedResult, Action<Humidifier.Braket.JobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerJobInputFileConfigFactory, T1, T2, T3, T4, InnerJobDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<InnerJobInputFileConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Braket.JobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobInputFileConfigFactory, T2, T3, T4, InnerJobDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobInputFileConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Braket.JobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobInputFileConfigFactory, T3, T4, InnerJobDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobInputFileConfigFactory, T3, T4> combinedResult, Action<Humidifier.Braket.JobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobInputFileConfigFactory, T4, InnerJobDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobInputFileConfigFactory, T4> combinedResult, Action<Humidifier.Braket.JobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerJobInputFileConfigFactory, InnerJobDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobInputFileConfigFactory> combinedResult, Action<Humidifier.Braket.JobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T5, subFactoryAction).T2);
}
