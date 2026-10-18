// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerApplicationStatusCheckHealthCheckPathFactory(Action<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPath> factoryAction = null) : SubResourceFactory<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPath>
{

    internal InnerApplicationStatusCheckHealthCheckPathSourceFactory SourceFactory { get; set; }

    protected override Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPath Create()
    {
        var healthCheckPathResult = CreateHealthCheckPath();
        factoryAction?.Invoke(healthCheckPathResult);

        return healthCheckPathResult;
    }

    private Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPath CreateHealthCheckPath()
    {
        var healthCheckPathResult = new Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPath();

        return healthCheckPathResult;
    }
    public override void CreateChildren(Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPath result)
    {
        base.CreateChildren(result);

        result.Source ??= SourceFactory?.Build();
    }

} // End Of Class

public static class InnerApplicationStatusCheckHealthCheckPathFactoryExtensions
{
    public static CombinedResult<InnerApplicationStatusCheckHealthCheckPathFactory, InnerApplicationStatusCheckHealthCheckPathSourceFactory> WithSource(this InnerApplicationStatusCheckHealthCheckPathFactory parentFactory, Action<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPathSource> subFactoryAction = null)
    {
        parentFactory.SourceFactory = new InnerApplicationStatusCheckHealthCheckPathSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceFactory);
    }

    public static CombinedResult<InnerApplicationStatusCheckHealthCheckPathFactory, T1, InnerApplicationStatusCheckHealthCheckPathSourceFactory> WithSource<T1>(this CombinedResult<InnerApplicationStatusCheckHealthCheckPathFactory, T1> combinedResult, Action<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPathSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerApplicationStatusCheckHealthCheckPathFactory, InnerApplicationStatusCheckHealthCheckPathSourceFactory> WithSource<T1>(this CombinedResult<T1, InnerApplicationStatusCheckHealthCheckPathFactory> combinedResult, Action<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPathSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerApplicationStatusCheckHealthCheckPathFactory, T1, T2, InnerApplicationStatusCheckHealthCheckPathSourceFactory> WithSource<T1, T2>(this CombinedResult<InnerApplicationStatusCheckHealthCheckPathFactory, T1, T2> combinedResult, Action<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPathSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerApplicationStatusCheckHealthCheckPathFactory, T2, InnerApplicationStatusCheckHealthCheckPathSourceFactory> WithSource<T1, T2>(this CombinedResult<T1, InnerApplicationStatusCheckHealthCheckPathFactory, T2> combinedResult, Action<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPathSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerApplicationStatusCheckHealthCheckPathFactory, InnerApplicationStatusCheckHealthCheckPathSourceFactory> WithSource<T1, T2>(this CombinedResult<T1, T2, InnerApplicationStatusCheckHealthCheckPathFactory> combinedResult, Action<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPathSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerApplicationStatusCheckHealthCheckPathFactory, T1, T2, T3, InnerApplicationStatusCheckHealthCheckPathSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<InnerApplicationStatusCheckHealthCheckPathFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPathSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerApplicationStatusCheckHealthCheckPathFactory, T2, T3, InnerApplicationStatusCheckHealthCheckPathSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, InnerApplicationStatusCheckHealthCheckPathFactory, T2, T3> combinedResult, Action<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPathSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerApplicationStatusCheckHealthCheckPathFactory, T3, InnerApplicationStatusCheckHealthCheckPathSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, T2, InnerApplicationStatusCheckHealthCheckPathFactory, T3> combinedResult, Action<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPathSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerApplicationStatusCheckHealthCheckPathFactory, InnerApplicationStatusCheckHealthCheckPathSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerApplicationStatusCheckHealthCheckPathFactory> combinedResult, Action<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPathSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerApplicationStatusCheckHealthCheckPathFactory, T1, T2, T3, T4, InnerApplicationStatusCheckHealthCheckPathSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<InnerApplicationStatusCheckHealthCheckPathFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPathSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerApplicationStatusCheckHealthCheckPathFactory, T2, T3, T4, InnerApplicationStatusCheckHealthCheckPathSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, InnerApplicationStatusCheckHealthCheckPathFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPathSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerApplicationStatusCheckHealthCheckPathFactory, T3, T4, InnerApplicationStatusCheckHealthCheckPathSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerApplicationStatusCheckHealthCheckPathFactory, T3, T4> combinedResult, Action<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPathSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerApplicationStatusCheckHealthCheckPathFactory, T4, InnerApplicationStatusCheckHealthCheckPathSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerApplicationStatusCheckHealthCheckPathFactory, T4> combinedResult, Action<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPathSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerApplicationStatusCheckHealthCheckPathFactory, InnerApplicationStatusCheckHealthCheckPathSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerApplicationStatusCheckHealthCheckPathFactory> combinedResult, Action<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPathSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T5, subFactoryAction).T2);
}
