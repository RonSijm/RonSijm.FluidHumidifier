// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerClusterLoggingFactory(Action<Humidifier.EKS.ClusterTypes.Logging> factoryAction = null) : SubResourceFactory<Humidifier.EKS.ClusterTypes.Logging>
{

    internal InnerClusterClusterLoggingFactory ClusterLoggingFactory { get; set; }

    protected override Humidifier.EKS.ClusterTypes.Logging Create()
    {
        var loggingResult = CreateLogging();
        factoryAction?.Invoke(loggingResult);

        return loggingResult;
    }

    private Humidifier.EKS.ClusterTypes.Logging CreateLogging()
    {
        var loggingResult = new Humidifier.EKS.ClusterTypes.Logging();

        return loggingResult;
    }
    public override void CreateChildren(Humidifier.EKS.ClusterTypes.Logging result)
    {
        base.CreateChildren(result);

        result.ClusterLogging ??= ClusterLoggingFactory?.Build();
    }

} // End Of Class

public static class InnerClusterLoggingFactoryExtensions
{
    public static CombinedResult<InnerClusterLoggingFactory, InnerClusterClusterLoggingFactory> WithClusterLogging(this InnerClusterLoggingFactory parentFactory, Action<Humidifier.EKS.ClusterTypes.ClusterLogging> subFactoryAction = null)
    {
        parentFactory.ClusterLoggingFactory = new InnerClusterClusterLoggingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ClusterLoggingFactory);
    }

    public static CombinedResult<InnerClusterLoggingFactory, T1, InnerClusterClusterLoggingFactory> WithClusterLogging<T1>(this CombinedResult<InnerClusterLoggingFactory, T1> combinedResult, Action<Humidifier.EKS.ClusterTypes.ClusterLogging> subFactoryAction = null) => new (combinedResult, combinedResult, WithClusterLogging(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterLoggingFactory, InnerClusterClusterLoggingFactory> WithClusterLogging<T1>(this CombinedResult<T1, InnerClusterLoggingFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.ClusterLogging> subFactoryAction = null) => new (combinedResult, combinedResult, WithClusterLogging(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterLoggingFactory, T1, T2, InnerClusterClusterLoggingFactory> WithClusterLogging<T1, T2>(this CombinedResult<InnerClusterLoggingFactory, T1, T2> combinedResult, Action<Humidifier.EKS.ClusterTypes.ClusterLogging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClusterLogging(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterLoggingFactory, T2, InnerClusterClusterLoggingFactory> WithClusterLogging<T1, T2>(this CombinedResult<T1, InnerClusterLoggingFactory, T2> combinedResult, Action<Humidifier.EKS.ClusterTypes.ClusterLogging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClusterLogging(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterLoggingFactory, InnerClusterClusterLoggingFactory> WithClusterLogging<T1, T2>(this CombinedResult<T1, T2, InnerClusterLoggingFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.ClusterLogging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClusterLogging(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterLoggingFactory, T1, T2, T3, InnerClusterClusterLoggingFactory> WithClusterLogging<T1, T2, T3>(this CombinedResult<InnerClusterLoggingFactory, T1, T2, T3> combinedResult, Action<Humidifier.EKS.ClusterTypes.ClusterLogging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClusterLogging(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterLoggingFactory, T2, T3, InnerClusterClusterLoggingFactory> WithClusterLogging<T1, T2, T3>(this CombinedResult<T1, InnerClusterLoggingFactory, T2, T3> combinedResult, Action<Humidifier.EKS.ClusterTypes.ClusterLogging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClusterLogging(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterLoggingFactory, T3, InnerClusterClusterLoggingFactory> WithClusterLogging<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterLoggingFactory, T3> combinedResult, Action<Humidifier.EKS.ClusterTypes.ClusterLogging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClusterLogging(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterLoggingFactory, InnerClusterClusterLoggingFactory> WithClusterLogging<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterLoggingFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.ClusterLogging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClusterLogging(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterLoggingFactory, T1, T2, T3, T4, InnerClusterClusterLoggingFactory> WithClusterLogging<T1, T2, T3, T4>(this CombinedResult<InnerClusterLoggingFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.ClusterLogging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterLogging(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterLoggingFactory, T2, T3, T4, InnerClusterClusterLoggingFactory> WithClusterLogging<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterLoggingFactory, T2, T3, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.ClusterLogging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterLogging(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterLoggingFactory, T3, T4, InnerClusterClusterLoggingFactory> WithClusterLogging<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterLoggingFactory, T3, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.ClusterLogging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterLogging(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterLoggingFactory, T4, InnerClusterClusterLoggingFactory> WithClusterLogging<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterLoggingFactory, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.ClusterLogging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterLogging(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterLoggingFactory, InnerClusterClusterLoggingFactory> WithClusterLogging<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterLoggingFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.ClusterLogging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterLogging(combinedResult.T5, subFactoryAction));
}
