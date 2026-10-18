// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerTrainingJobChannelFactory(Action<Humidifier.SageMaker.TrainingJobTypes.Channel> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.TrainingJobTypes.Channel>
{

    internal InnerTrainingJobShuffleConfigFactory ShuffleConfigFactory { get; set; }

    internal InnerTrainingJobDataSourceFactory DataSourceFactory { get; set; }

    protected override Humidifier.SageMaker.TrainingJobTypes.Channel Create()
    {
        var channelResult = CreateChannel();
        factoryAction?.Invoke(channelResult);

        return channelResult;
    }

    private Humidifier.SageMaker.TrainingJobTypes.Channel CreateChannel()
    {
        var channelResult = new Humidifier.SageMaker.TrainingJobTypes.Channel();

        return channelResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.TrainingJobTypes.Channel result)
    {
        base.CreateChildren(result);

        result.ShuffleConfig ??= ShuffleConfigFactory?.Build();
        result.DataSource ??= DataSourceFactory?.Build();
    }

} // End Of Class

public static class InnerTrainingJobChannelFactoryExtensions
{
    public static CombinedResult<InnerTrainingJobChannelFactory, InnerTrainingJobShuffleConfigFactory> WithShuffleConfig(this InnerTrainingJobChannelFactory parentFactory, Action<Humidifier.SageMaker.TrainingJobTypes.ShuffleConfig> subFactoryAction = null)
    {
        parentFactory.ShuffleConfigFactory = new InnerTrainingJobShuffleConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ShuffleConfigFactory);
    }

    public static CombinedResult<InnerTrainingJobChannelFactory, InnerTrainingJobDataSourceFactory> WithDataSource(this InnerTrainingJobChannelFactory parentFactory, Action<Humidifier.SageMaker.TrainingJobTypes.DataSource> subFactoryAction = null)
    {
        parentFactory.DataSourceFactory = new InnerTrainingJobDataSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DataSourceFactory);
    }

    public static CombinedResult<InnerTrainingJobChannelFactory, T1, InnerTrainingJobShuffleConfigFactory> WithShuffleConfig<T1>(this CombinedResult<InnerTrainingJobChannelFactory, T1> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.ShuffleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithShuffleConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTrainingJobChannelFactory, InnerTrainingJobShuffleConfigFactory> WithShuffleConfig<T1>(this CombinedResult<T1, InnerTrainingJobChannelFactory> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.ShuffleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithShuffleConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerTrainingJobChannelFactory, T1, T2, InnerTrainingJobShuffleConfigFactory> WithShuffleConfig<T1, T2>(this CombinedResult<InnerTrainingJobChannelFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.ShuffleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithShuffleConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTrainingJobChannelFactory, T2, InnerTrainingJobShuffleConfigFactory> WithShuffleConfig<T1, T2>(this CombinedResult<T1, InnerTrainingJobChannelFactory, T2> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.ShuffleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithShuffleConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTrainingJobChannelFactory, InnerTrainingJobShuffleConfigFactory> WithShuffleConfig<T1, T2>(this CombinedResult<T1, T2, InnerTrainingJobChannelFactory> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.ShuffleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithShuffleConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerTrainingJobChannelFactory, T1, T2, T3, InnerTrainingJobShuffleConfigFactory> WithShuffleConfig<T1, T2, T3>(this CombinedResult<InnerTrainingJobChannelFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.ShuffleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithShuffleConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTrainingJobChannelFactory, T2, T3, InnerTrainingJobShuffleConfigFactory> WithShuffleConfig<T1, T2, T3>(this CombinedResult<T1, InnerTrainingJobChannelFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.ShuffleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithShuffleConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTrainingJobChannelFactory, T3, InnerTrainingJobShuffleConfigFactory> WithShuffleConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerTrainingJobChannelFactory, T3> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.ShuffleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithShuffleConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTrainingJobChannelFactory, InnerTrainingJobShuffleConfigFactory> WithShuffleConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTrainingJobChannelFactory> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.ShuffleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithShuffleConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerTrainingJobChannelFactory, T1, T2, T3, T4, InnerTrainingJobShuffleConfigFactory> WithShuffleConfig<T1, T2, T3, T4>(this CombinedResult<InnerTrainingJobChannelFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.ShuffleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithShuffleConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTrainingJobChannelFactory, T2, T3, T4, InnerTrainingJobShuffleConfigFactory> WithShuffleConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerTrainingJobChannelFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.ShuffleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithShuffleConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTrainingJobChannelFactory, T3, T4, InnerTrainingJobShuffleConfigFactory> WithShuffleConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTrainingJobChannelFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.ShuffleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithShuffleConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTrainingJobChannelFactory, T4, InnerTrainingJobShuffleConfigFactory> WithShuffleConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTrainingJobChannelFactory, T4> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.ShuffleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithShuffleConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerTrainingJobChannelFactory, InnerTrainingJobShuffleConfigFactory> WithShuffleConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTrainingJobChannelFactory> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.ShuffleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithShuffleConfig(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerTrainingJobChannelFactory, T1, InnerTrainingJobDataSourceFactory> WithDataSource<T1>(this CombinedResult<InnerTrainingJobChannelFactory, T1> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTrainingJobChannelFactory, InnerTrainingJobDataSourceFactory> WithDataSource<T1>(this CombinedResult<T1, InnerTrainingJobChannelFactory> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerTrainingJobChannelFactory, T1, T2, InnerTrainingJobDataSourceFactory> WithDataSource<T1, T2>(this CombinedResult<InnerTrainingJobChannelFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTrainingJobChannelFactory, T2, InnerTrainingJobDataSourceFactory> WithDataSource<T1, T2>(this CombinedResult<T1, InnerTrainingJobChannelFactory, T2> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTrainingJobChannelFactory, InnerTrainingJobDataSourceFactory> WithDataSource<T1, T2>(this CombinedResult<T1, T2, InnerTrainingJobChannelFactory> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerTrainingJobChannelFactory, T1, T2, T3, InnerTrainingJobDataSourceFactory> WithDataSource<T1, T2, T3>(this CombinedResult<InnerTrainingJobChannelFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTrainingJobChannelFactory, T2, T3, InnerTrainingJobDataSourceFactory> WithDataSource<T1, T2, T3>(this CombinedResult<T1, InnerTrainingJobChannelFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTrainingJobChannelFactory, T3, InnerTrainingJobDataSourceFactory> WithDataSource<T1, T2, T3>(this CombinedResult<T1, T2, InnerTrainingJobChannelFactory, T3> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTrainingJobChannelFactory, InnerTrainingJobDataSourceFactory> WithDataSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTrainingJobChannelFactory> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerTrainingJobChannelFactory, T1, T2, T3, T4, InnerTrainingJobDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<InnerTrainingJobChannelFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTrainingJobChannelFactory, T2, T3, T4, InnerTrainingJobDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<T1, InnerTrainingJobChannelFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTrainingJobChannelFactory, T3, T4, InnerTrainingJobDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTrainingJobChannelFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTrainingJobChannelFactory, T4, InnerTrainingJobDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTrainingJobChannelFactory, T4> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerTrainingJobChannelFactory, InnerTrainingJobDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTrainingJobChannelFactory> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T5, subFactoryAction).T2);
}
