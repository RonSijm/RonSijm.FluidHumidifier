// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAutoMLJobAutoMLJobChannelFactory(Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobChannel> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobChannel>
{

    internal InnerAutoMLJobAutoMLDataSourceFactory DataSourceFactory { get; set; }

    protected override Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobChannel Create()
    {
        var autoMLJobChannelResult = CreateAutoMLJobChannel();
        factoryAction?.Invoke(autoMLJobChannelResult);

        return autoMLJobChannelResult;
    }

    private Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobChannel CreateAutoMLJobChannel()
    {
        var autoMLJobChannelResult = new Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobChannel();

        return autoMLJobChannelResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobChannel result)
    {
        base.CreateChildren(result);

        result.DataSource ??= DataSourceFactory?.Build();
    }

} // End Of Class

public static class InnerAutoMLJobAutoMLJobChannelFactoryExtensions
{
    public static CombinedResult<InnerAutoMLJobAutoMLJobChannelFactory, InnerAutoMLJobAutoMLDataSourceFactory> WithDataSource(this InnerAutoMLJobAutoMLJobChannelFactory parentFactory, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLDataSource> subFactoryAction = null)
    {
        parentFactory.DataSourceFactory = new InnerAutoMLJobAutoMLDataSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DataSourceFactory);
    }

    public static CombinedResult<InnerAutoMLJobAutoMLJobChannelFactory, T1, InnerAutoMLJobAutoMLDataSourceFactory> WithDataSource<T1>(this CombinedResult<InnerAutoMLJobAutoMLJobChannelFactory, T1> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAutoMLJobAutoMLJobChannelFactory, InnerAutoMLJobAutoMLDataSourceFactory> WithDataSource<T1>(this CombinedResult<T1, InnerAutoMLJobAutoMLJobChannelFactory> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAutoMLJobAutoMLJobChannelFactory, T1, T2, InnerAutoMLJobAutoMLDataSourceFactory> WithDataSource<T1, T2>(this CombinedResult<InnerAutoMLJobAutoMLJobChannelFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAutoMLJobAutoMLJobChannelFactory, T2, InnerAutoMLJobAutoMLDataSourceFactory> WithDataSource<T1, T2>(this CombinedResult<T1, InnerAutoMLJobAutoMLJobChannelFactory, T2> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAutoMLJobAutoMLJobChannelFactory, InnerAutoMLJobAutoMLDataSourceFactory> WithDataSource<T1, T2>(this CombinedResult<T1, T2, InnerAutoMLJobAutoMLJobChannelFactory> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAutoMLJobAutoMLJobChannelFactory, T1, T2, T3, InnerAutoMLJobAutoMLDataSourceFactory> WithDataSource<T1, T2, T3>(this CombinedResult<InnerAutoMLJobAutoMLJobChannelFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAutoMLJobAutoMLJobChannelFactory, T2, T3, InnerAutoMLJobAutoMLDataSourceFactory> WithDataSource<T1, T2, T3>(this CombinedResult<T1, InnerAutoMLJobAutoMLJobChannelFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAutoMLJobAutoMLJobChannelFactory, T3, InnerAutoMLJobAutoMLDataSourceFactory> WithDataSource<T1, T2, T3>(this CombinedResult<T1, T2, InnerAutoMLJobAutoMLJobChannelFactory, T3> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAutoMLJobAutoMLJobChannelFactory, InnerAutoMLJobAutoMLDataSourceFactory> WithDataSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAutoMLJobAutoMLJobChannelFactory> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAutoMLJobAutoMLJobChannelFactory, T1, T2, T3, T4, InnerAutoMLJobAutoMLDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<InnerAutoMLJobAutoMLJobChannelFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAutoMLJobAutoMLJobChannelFactory, T2, T3, T4, InnerAutoMLJobAutoMLDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<T1, InnerAutoMLJobAutoMLJobChannelFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAutoMLJobAutoMLJobChannelFactory, T3, T4, InnerAutoMLJobAutoMLDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAutoMLJobAutoMLJobChannelFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAutoMLJobAutoMLJobChannelFactory, T4, InnerAutoMLJobAutoMLDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAutoMLJobAutoMLJobChannelFactory, T4> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAutoMLJobAutoMLJobChannelFactory, InnerAutoMLJobAutoMLDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAutoMLJobAutoMLJobChannelFactory> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T5, subFactoryAction).T2);
}
