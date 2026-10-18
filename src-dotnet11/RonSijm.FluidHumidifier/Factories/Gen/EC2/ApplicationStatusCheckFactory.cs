// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class ApplicationStatusCheckFactory(string resourceName = null, Action<Humidifier.EC2.ApplicationStatusCheck> factoryAction = null) : ResourceFactory<Humidifier.EC2.ApplicationStatusCheck>(resourceName)
{

    internal List<InnerApplicationStatusCheckHealthCheckPathFactory> HealthCheckPathsFactories { get; set; } = [];

    protected override Humidifier.EC2.ApplicationStatusCheck Create()
    {
        var applicationStatusCheckResult = CreateApplicationStatusCheck();
        factoryAction?.Invoke(applicationStatusCheckResult);

        return applicationStatusCheckResult;
    }

    private Humidifier.EC2.ApplicationStatusCheck CreateApplicationStatusCheck()
    {
        var applicationStatusCheckResult = new Humidifier.EC2.ApplicationStatusCheck
        {
            GivenName = InputResourceName,
        };

        return applicationStatusCheckResult;
    }
    public override void CreateChildren(Humidifier.EC2.ApplicationStatusCheck result)
    {
        base.CreateChildren(result);

        result.HealthCheckPaths = HealthCheckPathsFactories.Any() ? HealthCheckPathsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ApplicationStatusCheckFactoryExtensions
{
    public static CombinedResult<ApplicationStatusCheckFactory, InnerApplicationStatusCheckHealthCheckPathFactory> WithHealthCheckPaths(this ApplicationStatusCheckFactory parentFactory, Action<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPath> subFactoryAction = null)
    {
        var factory = new InnerApplicationStatusCheckHealthCheckPathFactory(subFactoryAction);
        parentFactory.HealthCheckPathsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ApplicationStatusCheckFactory, T1, InnerApplicationStatusCheckHealthCheckPathFactory> WithHealthCheckPaths<T1>(this CombinedResult<ApplicationStatusCheckFactory, T1> combinedResult, Action<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPath> subFactoryAction = null) => new (combinedResult, combinedResult, WithHealthCheckPaths(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ApplicationStatusCheckFactory, InnerApplicationStatusCheckHealthCheckPathFactory> WithHealthCheckPaths<T1>(this CombinedResult<T1, ApplicationStatusCheckFactory> combinedResult, Action<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPath> subFactoryAction = null) => new (combinedResult, combinedResult, WithHealthCheckPaths(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ApplicationStatusCheckFactory, T1, T2, InnerApplicationStatusCheckHealthCheckPathFactory> WithHealthCheckPaths<T1, T2>(this CombinedResult<ApplicationStatusCheckFactory, T1, T2> combinedResult, Action<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPath> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHealthCheckPaths(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ApplicationStatusCheckFactory, T2, InnerApplicationStatusCheckHealthCheckPathFactory> WithHealthCheckPaths<T1, T2>(this CombinedResult<T1, ApplicationStatusCheckFactory, T2> combinedResult, Action<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPath> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHealthCheckPaths(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ApplicationStatusCheckFactory, InnerApplicationStatusCheckHealthCheckPathFactory> WithHealthCheckPaths<T1, T2>(this CombinedResult<T1, T2, ApplicationStatusCheckFactory> combinedResult, Action<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPath> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHealthCheckPaths(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ApplicationStatusCheckFactory, T1, T2, T3, InnerApplicationStatusCheckHealthCheckPathFactory> WithHealthCheckPaths<T1, T2, T3>(this CombinedResult<ApplicationStatusCheckFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPath> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckPaths(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ApplicationStatusCheckFactory, T2, T3, InnerApplicationStatusCheckHealthCheckPathFactory> WithHealthCheckPaths<T1, T2, T3>(this CombinedResult<T1, ApplicationStatusCheckFactory, T2, T3> combinedResult, Action<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPath> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckPaths(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ApplicationStatusCheckFactory, T3, InnerApplicationStatusCheckHealthCheckPathFactory> WithHealthCheckPaths<T1, T2, T3>(this CombinedResult<T1, T2, ApplicationStatusCheckFactory, T3> combinedResult, Action<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPath> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckPaths(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ApplicationStatusCheckFactory, InnerApplicationStatusCheckHealthCheckPathFactory> WithHealthCheckPaths<T1, T2, T3>(this CombinedResult<T1, T2, T3, ApplicationStatusCheckFactory> combinedResult, Action<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPath> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckPaths(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ApplicationStatusCheckFactory, T1, T2, T3, T4, InnerApplicationStatusCheckHealthCheckPathFactory> WithHealthCheckPaths<T1, T2, T3, T4>(this CombinedResult<ApplicationStatusCheckFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPath> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckPaths(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ApplicationStatusCheckFactory, T2, T3, T4, InnerApplicationStatusCheckHealthCheckPathFactory> WithHealthCheckPaths<T1, T2, T3, T4>(this CombinedResult<T1, ApplicationStatusCheckFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPath> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckPaths(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ApplicationStatusCheckFactory, T3, T4, InnerApplicationStatusCheckHealthCheckPathFactory> WithHealthCheckPaths<T1, T2, T3, T4>(this CombinedResult<T1, T2, ApplicationStatusCheckFactory, T3, T4> combinedResult, Action<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPath> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckPaths(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ApplicationStatusCheckFactory, T4, InnerApplicationStatusCheckHealthCheckPathFactory> WithHealthCheckPaths<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ApplicationStatusCheckFactory, T4> combinedResult, Action<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPath> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckPaths(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ApplicationStatusCheckFactory, InnerApplicationStatusCheckHealthCheckPathFactory> WithHealthCheckPaths<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ApplicationStatusCheckFactory> combinedResult, Action<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPath> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckPaths(combinedResult.T5, subFactoryAction).T2);
}
