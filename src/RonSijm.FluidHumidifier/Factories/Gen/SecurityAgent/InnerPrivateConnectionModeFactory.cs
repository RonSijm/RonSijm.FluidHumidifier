// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityAgent;

public class InnerPrivateConnectionModeFactory(Action<Humidifier.SecurityAgent.PrivateConnectionTypes.Mode> factoryAction = null) : SubResourceFactory<Humidifier.SecurityAgent.PrivateConnectionTypes.Mode>
{

    internal InnerPrivateConnectionServiceManagedFactory ServiceManagedFactory { get; set; }

    internal InnerPrivateConnectionSelfManagedFactory SelfManagedFactory { get; set; }

    protected override Humidifier.SecurityAgent.PrivateConnectionTypes.Mode Create()
    {
        var modeResult = CreateMode();
        factoryAction?.Invoke(modeResult);

        return modeResult;
    }

    private Humidifier.SecurityAgent.PrivateConnectionTypes.Mode CreateMode()
    {
        var modeResult = new Humidifier.SecurityAgent.PrivateConnectionTypes.Mode();

        return modeResult;
    }
    public override void CreateChildren(Humidifier.SecurityAgent.PrivateConnectionTypes.Mode result)
    {
        base.CreateChildren(result);

        result.ServiceManaged ??= ServiceManagedFactory?.Build();
        result.SelfManaged ??= SelfManagedFactory?.Build();
    }

} // End Of Class

public static class InnerPrivateConnectionModeFactoryExtensions
{
    public static CombinedResult<InnerPrivateConnectionModeFactory, InnerPrivateConnectionServiceManagedFactory> WithServiceManaged(this InnerPrivateConnectionModeFactory parentFactory, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.ServiceManaged> subFactoryAction = null)
    {
        parentFactory.ServiceManagedFactory = new InnerPrivateConnectionServiceManagedFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ServiceManagedFactory);
    }

    public static CombinedResult<InnerPrivateConnectionModeFactory, InnerPrivateConnectionSelfManagedFactory> WithSelfManaged(this InnerPrivateConnectionModeFactory parentFactory, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.SelfManaged> subFactoryAction = null)
    {
        parentFactory.SelfManagedFactory = new InnerPrivateConnectionSelfManagedFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SelfManagedFactory);
    }

    public static CombinedResult<InnerPrivateConnectionModeFactory, T1, InnerPrivateConnectionServiceManagedFactory> WithServiceManaged<T1>(this CombinedResult<InnerPrivateConnectionModeFactory, T1> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.ServiceManaged> subFactoryAction = null) => new (combinedResult, combinedResult, WithServiceManaged(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPrivateConnectionModeFactory, InnerPrivateConnectionServiceManagedFactory> WithServiceManaged<T1>(this CombinedResult<T1, InnerPrivateConnectionModeFactory> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.ServiceManaged> subFactoryAction = null) => new (combinedResult, combinedResult, WithServiceManaged(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerPrivateConnectionModeFactory, T1, T2, InnerPrivateConnectionServiceManagedFactory> WithServiceManaged<T1, T2>(this CombinedResult<InnerPrivateConnectionModeFactory, T1, T2> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.ServiceManaged> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServiceManaged(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPrivateConnectionModeFactory, T2, InnerPrivateConnectionServiceManagedFactory> WithServiceManaged<T1, T2>(this CombinedResult<T1, InnerPrivateConnectionModeFactory, T2> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.ServiceManaged> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServiceManaged(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPrivateConnectionModeFactory, InnerPrivateConnectionServiceManagedFactory> WithServiceManaged<T1, T2>(this CombinedResult<T1, T2, InnerPrivateConnectionModeFactory> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.ServiceManaged> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServiceManaged(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerPrivateConnectionModeFactory, T1, T2, T3, InnerPrivateConnectionServiceManagedFactory> WithServiceManaged<T1, T2, T3>(this CombinedResult<InnerPrivateConnectionModeFactory, T1, T2, T3> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.ServiceManaged> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceManaged(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPrivateConnectionModeFactory, T2, T3, InnerPrivateConnectionServiceManagedFactory> WithServiceManaged<T1, T2, T3>(this CombinedResult<T1, InnerPrivateConnectionModeFactory, T2, T3> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.ServiceManaged> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceManaged(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPrivateConnectionModeFactory, T3, InnerPrivateConnectionServiceManagedFactory> WithServiceManaged<T1, T2, T3>(this CombinedResult<T1, T2, InnerPrivateConnectionModeFactory, T3> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.ServiceManaged> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceManaged(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPrivateConnectionModeFactory, InnerPrivateConnectionServiceManagedFactory> WithServiceManaged<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPrivateConnectionModeFactory> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.ServiceManaged> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceManaged(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerPrivateConnectionModeFactory, T1, T2, T3, T4, InnerPrivateConnectionServiceManagedFactory> WithServiceManaged<T1, T2, T3, T4>(this CombinedResult<InnerPrivateConnectionModeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.ServiceManaged> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceManaged(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPrivateConnectionModeFactory, T2, T3, T4, InnerPrivateConnectionServiceManagedFactory> WithServiceManaged<T1, T2, T3, T4>(this CombinedResult<T1, InnerPrivateConnectionModeFactory, T2, T3, T4> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.ServiceManaged> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceManaged(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPrivateConnectionModeFactory, T3, T4, InnerPrivateConnectionServiceManagedFactory> WithServiceManaged<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPrivateConnectionModeFactory, T3, T4> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.ServiceManaged> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceManaged(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPrivateConnectionModeFactory, T4, InnerPrivateConnectionServiceManagedFactory> WithServiceManaged<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPrivateConnectionModeFactory, T4> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.ServiceManaged> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceManaged(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerPrivateConnectionModeFactory, InnerPrivateConnectionServiceManagedFactory> WithServiceManaged<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPrivateConnectionModeFactory> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.ServiceManaged> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceManaged(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerPrivateConnectionModeFactory, T1, InnerPrivateConnectionSelfManagedFactory> WithSelfManaged<T1>(this CombinedResult<InnerPrivateConnectionModeFactory, T1> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.SelfManaged> subFactoryAction = null) => new (combinedResult, combinedResult, WithSelfManaged(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPrivateConnectionModeFactory, InnerPrivateConnectionSelfManagedFactory> WithSelfManaged<T1>(this CombinedResult<T1, InnerPrivateConnectionModeFactory> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.SelfManaged> subFactoryAction = null) => new (combinedResult, combinedResult, WithSelfManaged(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerPrivateConnectionModeFactory, T1, T2, InnerPrivateConnectionSelfManagedFactory> WithSelfManaged<T1, T2>(this CombinedResult<InnerPrivateConnectionModeFactory, T1, T2> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.SelfManaged> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSelfManaged(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPrivateConnectionModeFactory, T2, InnerPrivateConnectionSelfManagedFactory> WithSelfManaged<T1, T2>(this CombinedResult<T1, InnerPrivateConnectionModeFactory, T2> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.SelfManaged> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSelfManaged(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPrivateConnectionModeFactory, InnerPrivateConnectionSelfManagedFactory> WithSelfManaged<T1, T2>(this CombinedResult<T1, T2, InnerPrivateConnectionModeFactory> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.SelfManaged> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSelfManaged(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerPrivateConnectionModeFactory, T1, T2, T3, InnerPrivateConnectionSelfManagedFactory> WithSelfManaged<T1, T2, T3>(this CombinedResult<InnerPrivateConnectionModeFactory, T1, T2, T3> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.SelfManaged> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSelfManaged(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPrivateConnectionModeFactory, T2, T3, InnerPrivateConnectionSelfManagedFactory> WithSelfManaged<T1, T2, T3>(this CombinedResult<T1, InnerPrivateConnectionModeFactory, T2, T3> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.SelfManaged> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSelfManaged(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPrivateConnectionModeFactory, T3, InnerPrivateConnectionSelfManagedFactory> WithSelfManaged<T1, T2, T3>(this CombinedResult<T1, T2, InnerPrivateConnectionModeFactory, T3> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.SelfManaged> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSelfManaged(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPrivateConnectionModeFactory, InnerPrivateConnectionSelfManagedFactory> WithSelfManaged<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPrivateConnectionModeFactory> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.SelfManaged> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSelfManaged(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerPrivateConnectionModeFactory, T1, T2, T3, T4, InnerPrivateConnectionSelfManagedFactory> WithSelfManaged<T1, T2, T3, T4>(this CombinedResult<InnerPrivateConnectionModeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.SelfManaged> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelfManaged(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPrivateConnectionModeFactory, T2, T3, T4, InnerPrivateConnectionSelfManagedFactory> WithSelfManaged<T1, T2, T3, T4>(this CombinedResult<T1, InnerPrivateConnectionModeFactory, T2, T3, T4> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.SelfManaged> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelfManaged(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPrivateConnectionModeFactory, T3, T4, InnerPrivateConnectionSelfManagedFactory> WithSelfManaged<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPrivateConnectionModeFactory, T3, T4> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.SelfManaged> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelfManaged(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPrivateConnectionModeFactory, T4, InnerPrivateConnectionSelfManagedFactory> WithSelfManaged<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPrivateConnectionModeFactory, T4> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.SelfManaged> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelfManaged(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerPrivateConnectionModeFactory, InnerPrivateConnectionSelfManagedFactory> WithSelfManaged<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPrivateConnectionModeFactory> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.SelfManaged> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelfManaged(combinedResult.T5, subFactoryAction).T2);
}
