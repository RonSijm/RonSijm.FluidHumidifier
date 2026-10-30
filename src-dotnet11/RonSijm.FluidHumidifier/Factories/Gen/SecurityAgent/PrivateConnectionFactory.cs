// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityAgent;

public class PrivateConnectionFactory(string resourceName = null, Action<Humidifier.SecurityAgent.PrivateConnection> factoryAction = null) : ResourceFactory<Humidifier.SecurityAgent.PrivateConnection>(resourceName)
{

    internal InnerPrivateConnectionModeFactory ModeFactory { get; set; }

    protected override Humidifier.SecurityAgent.PrivateConnection Create()
    {
        var privateConnectionResult = CreatePrivateConnection();
        factoryAction?.Invoke(privateConnectionResult);

        return privateConnectionResult;
    }

    private Humidifier.SecurityAgent.PrivateConnection CreatePrivateConnection()
    {
        var privateConnectionResult = new Humidifier.SecurityAgent.PrivateConnection
        {
            GivenName = InputResourceName,
        };

        return privateConnectionResult;
    }
    public override void CreateChildren(Humidifier.SecurityAgent.PrivateConnection result)
    {
        base.CreateChildren(result);

        result.Mode ??= ModeFactory?.Build();
    }

} // End Of Class

public static class PrivateConnectionFactoryExtensions
{
    public static CombinedResult<PrivateConnectionFactory, InnerPrivateConnectionModeFactory> WithMode(this PrivateConnectionFactory parentFactory, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.Mode> subFactoryAction = null)
    {
        parentFactory.ModeFactory = new InnerPrivateConnectionModeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ModeFactory);
    }

    public static CombinedResult<PrivateConnectionFactory, T1, InnerPrivateConnectionModeFactory> WithMode<T1>(this CombinedResult<PrivateConnectionFactory, T1> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.Mode> subFactoryAction = null) => new (combinedResult, combinedResult, WithMode(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PrivateConnectionFactory, InnerPrivateConnectionModeFactory> WithMode<T1>(this CombinedResult<T1, PrivateConnectionFactory> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.Mode> subFactoryAction = null) => new (combinedResult, combinedResult, WithMode(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<PrivateConnectionFactory, T1, T2, InnerPrivateConnectionModeFactory> WithMode<T1, T2>(this CombinedResult<PrivateConnectionFactory, T1, T2> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.Mode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMode(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PrivateConnectionFactory, T2, InnerPrivateConnectionModeFactory> WithMode<T1, T2>(this CombinedResult<T1, PrivateConnectionFactory, T2> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.Mode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMode(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PrivateConnectionFactory, InnerPrivateConnectionModeFactory> WithMode<T1, T2>(this CombinedResult<T1, T2, PrivateConnectionFactory> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.Mode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMode(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<PrivateConnectionFactory, T1, T2, T3, InnerPrivateConnectionModeFactory> WithMode<T1, T2, T3>(this CombinedResult<PrivateConnectionFactory, T1, T2, T3> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.Mode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMode(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PrivateConnectionFactory, T2, T3, InnerPrivateConnectionModeFactory> WithMode<T1, T2, T3>(this CombinedResult<T1, PrivateConnectionFactory, T2, T3> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.Mode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMode(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PrivateConnectionFactory, T3, InnerPrivateConnectionModeFactory> WithMode<T1, T2, T3>(this CombinedResult<T1, T2, PrivateConnectionFactory, T3> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.Mode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMode(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PrivateConnectionFactory, InnerPrivateConnectionModeFactory> WithMode<T1, T2, T3>(this CombinedResult<T1, T2, T3, PrivateConnectionFactory> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.Mode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMode(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<PrivateConnectionFactory, T1, T2, T3, T4, InnerPrivateConnectionModeFactory> WithMode<T1, T2, T3, T4>(this CombinedResult<PrivateConnectionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.Mode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMode(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PrivateConnectionFactory, T2, T3, T4, InnerPrivateConnectionModeFactory> WithMode<T1, T2, T3, T4>(this CombinedResult<T1, PrivateConnectionFactory, T2, T3, T4> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.Mode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMode(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PrivateConnectionFactory, T3, T4, InnerPrivateConnectionModeFactory> WithMode<T1, T2, T3, T4>(this CombinedResult<T1, T2, PrivateConnectionFactory, T3, T4> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.Mode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMode(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PrivateConnectionFactory, T4, InnerPrivateConnectionModeFactory> WithMode<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PrivateConnectionFactory, T4> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.Mode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMode(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, PrivateConnectionFactory, InnerPrivateConnectionModeFactory> WithMode<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PrivateConnectionFactory> combinedResult, Action<Humidifier.SecurityAgent.PrivateConnectionTypes.Mode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMode(combinedResult.T5, subFactoryAction).T2);
}
