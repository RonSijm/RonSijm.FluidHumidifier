// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerTransformJobTransformInputFactory(Action<Humidifier.SageMaker.TransformJobTypes.TransformInput> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.TransformJobTypes.TransformInput>
{

    internal InnerTransformJobDataSourceFactory DataSourceFactory { get; set; }

    protected override Humidifier.SageMaker.TransformJobTypes.TransformInput Create()
    {
        var transformInputResult = CreateTransformInput();
        factoryAction?.Invoke(transformInputResult);

        return transformInputResult;
    }

    private Humidifier.SageMaker.TransformJobTypes.TransformInput CreateTransformInput()
    {
        var transformInputResult = new Humidifier.SageMaker.TransformJobTypes.TransformInput();

        return transformInputResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.TransformJobTypes.TransformInput result)
    {
        base.CreateChildren(result);

        result.DataSource ??= DataSourceFactory?.Build();
    }

} // End Of Class

public static class InnerTransformJobTransformInputFactoryExtensions
{
    public static CombinedResult<InnerTransformJobTransformInputFactory, InnerTransformJobDataSourceFactory> WithDataSource(this InnerTransformJobTransformInputFactory parentFactory, Action<Humidifier.SageMaker.TransformJobTypes.DataSource> subFactoryAction = null)
    {
        parentFactory.DataSourceFactory = new InnerTransformJobDataSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DataSourceFactory);
    }

    public static CombinedResult<InnerTransformJobTransformInputFactory, T1, InnerTransformJobDataSourceFactory> WithDataSource<T1>(this CombinedResult<InnerTransformJobTransformInputFactory, T1> combinedResult, Action<Humidifier.SageMaker.TransformJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTransformJobTransformInputFactory, InnerTransformJobDataSourceFactory> WithDataSource<T1>(this CombinedResult<T1, InnerTransformJobTransformInputFactory> combinedResult, Action<Humidifier.SageMaker.TransformJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerTransformJobTransformInputFactory, T1, T2, InnerTransformJobDataSourceFactory> WithDataSource<T1, T2>(this CombinedResult<InnerTransformJobTransformInputFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.TransformJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTransformJobTransformInputFactory, T2, InnerTransformJobDataSourceFactory> WithDataSource<T1, T2>(this CombinedResult<T1, InnerTransformJobTransformInputFactory, T2> combinedResult, Action<Humidifier.SageMaker.TransformJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTransformJobTransformInputFactory, InnerTransformJobDataSourceFactory> WithDataSource<T1, T2>(this CombinedResult<T1, T2, InnerTransformJobTransformInputFactory> combinedResult, Action<Humidifier.SageMaker.TransformJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerTransformJobTransformInputFactory, T1, T2, T3, InnerTransformJobDataSourceFactory> WithDataSource<T1, T2, T3>(this CombinedResult<InnerTransformJobTransformInputFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.TransformJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTransformJobTransformInputFactory, T2, T3, InnerTransformJobDataSourceFactory> WithDataSource<T1, T2, T3>(this CombinedResult<T1, InnerTransformJobTransformInputFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.TransformJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTransformJobTransformInputFactory, T3, InnerTransformJobDataSourceFactory> WithDataSource<T1, T2, T3>(this CombinedResult<T1, T2, InnerTransformJobTransformInputFactory, T3> combinedResult, Action<Humidifier.SageMaker.TransformJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTransformJobTransformInputFactory, InnerTransformJobDataSourceFactory> WithDataSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTransformJobTransformInputFactory> combinedResult, Action<Humidifier.SageMaker.TransformJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerTransformJobTransformInputFactory, T1, T2, T3, T4, InnerTransformJobDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<InnerTransformJobTransformInputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.TransformJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTransformJobTransformInputFactory, T2, T3, T4, InnerTransformJobDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<T1, InnerTransformJobTransformInputFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.TransformJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTransformJobTransformInputFactory, T3, T4, InnerTransformJobDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTransformJobTransformInputFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.TransformJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTransformJobTransformInputFactory, T4, InnerTransformJobDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTransformJobTransformInputFactory, T4> combinedResult, Action<Humidifier.SageMaker.TransformJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerTransformJobTransformInputFactory, InnerTransformJobDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTransformJobTransformInputFactory> combinedResult, Action<Humidifier.SageMaker.TransformJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T5, subFactoryAction).T2);
}
