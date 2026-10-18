// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class PrivateConnectionFactory(string resourceName = null, Action<Humidifier.DevOpsAgent.PrivateConnection> factoryAction = null) : ResourceFactory<Humidifier.DevOpsAgent.PrivateConnection>(resourceName)
{

    internal InnerPrivateConnectionConnectionConfigurationFactory ConnectionConfigurationFactory { get; set; }

    protected override Humidifier.DevOpsAgent.PrivateConnection Create()
    {
        var privateConnectionResult = CreatePrivateConnection();
        factoryAction?.Invoke(privateConnectionResult);

        return privateConnectionResult;
    }

    private Humidifier.DevOpsAgent.PrivateConnection CreatePrivateConnection()
    {
        var privateConnectionResult = new Humidifier.DevOpsAgent.PrivateConnection
        {
            GivenName = InputResourceName,
        };

        return privateConnectionResult;
    }
    public override void CreateChildren(Humidifier.DevOpsAgent.PrivateConnection result)
    {
        base.CreateChildren(result);

        result.ConnectionConfiguration ??= ConnectionConfigurationFactory?.Build();
    }

} // End Of Class

public static class PrivateConnectionFactoryExtensions
{
    public static CombinedResult<PrivateConnectionFactory, InnerPrivateConnectionConnectionConfigurationFactory> WithConnectionConfiguration(this PrivateConnectionFactory parentFactory, Action<Humidifier.DevOpsAgent.PrivateConnectionTypes.ConnectionConfiguration> subFactoryAction = null)
    {
        parentFactory.ConnectionConfigurationFactory = new InnerPrivateConnectionConnectionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConnectionConfigurationFactory);
    }

    public static CombinedResult<PrivateConnectionFactory, T1, InnerPrivateConnectionConnectionConfigurationFactory> WithConnectionConfiguration<T1>(this CombinedResult<PrivateConnectionFactory, T1> combinedResult, Action<Humidifier.DevOpsAgent.PrivateConnectionTypes.ConnectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PrivateConnectionFactory, InnerPrivateConnectionConnectionConfigurationFactory> WithConnectionConfiguration<T1>(this CombinedResult<T1, PrivateConnectionFactory> combinedResult, Action<Humidifier.DevOpsAgent.PrivateConnectionTypes.ConnectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<PrivateConnectionFactory, T1, T2, InnerPrivateConnectionConnectionConfigurationFactory> WithConnectionConfiguration<T1, T2>(this CombinedResult<PrivateConnectionFactory, T1, T2> combinedResult, Action<Humidifier.DevOpsAgent.PrivateConnectionTypes.ConnectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PrivateConnectionFactory, T2, InnerPrivateConnectionConnectionConfigurationFactory> WithConnectionConfiguration<T1, T2>(this CombinedResult<T1, PrivateConnectionFactory, T2> combinedResult, Action<Humidifier.DevOpsAgent.PrivateConnectionTypes.ConnectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PrivateConnectionFactory, InnerPrivateConnectionConnectionConfigurationFactory> WithConnectionConfiguration<T1, T2>(this CombinedResult<T1, T2, PrivateConnectionFactory> combinedResult, Action<Humidifier.DevOpsAgent.PrivateConnectionTypes.ConnectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<PrivateConnectionFactory, T1, T2, T3, InnerPrivateConnectionConnectionConfigurationFactory> WithConnectionConfiguration<T1, T2, T3>(this CombinedResult<PrivateConnectionFactory, T1, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.PrivateConnectionTypes.ConnectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PrivateConnectionFactory, T2, T3, InnerPrivateConnectionConnectionConfigurationFactory> WithConnectionConfiguration<T1, T2, T3>(this CombinedResult<T1, PrivateConnectionFactory, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.PrivateConnectionTypes.ConnectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PrivateConnectionFactory, T3, InnerPrivateConnectionConnectionConfigurationFactory> WithConnectionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, PrivateConnectionFactory, T3> combinedResult, Action<Humidifier.DevOpsAgent.PrivateConnectionTypes.ConnectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PrivateConnectionFactory, InnerPrivateConnectionConnectionConfigurationFactory> WithConnectionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, PrivateConnectionFactory> combinedResult, Action<Humidifier.DevOpsAgent.PrivateConnectionTypes.ConnectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<PrivateConnectionFactory, T1, T2, T3, T4, InnerPrivateConnectionConnectionConfigurationFactory> WithConnectionConfiguration<T1, T2, T3, T4>(this CombinedResult<PrivateConnectionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.PrivateConnectionTypes.ConnectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PrivateConnectionFactory, T2, T3, T4, InnerPrivateConnectionConnectionConfigurationFactory> WithConnectionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, PrivateConnectionFactory, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.PrivateConnectionTypes.ConnectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PrivateConnectionFactory, T3, T4, InnerPrivateConnectionConnectionConfigurationFactory> WithConnectionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, PrivateConnectionFactory, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.PrivateConnectionTypes.ConnectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PrivateConnectionFactory, T4, InnerPrivateConnectionConnectionConfigurationFactory> WithConnectionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PrivateConnectionFactory, T4> combinedResult, Action<Humidifier.DevOpsAgent.PrivateConnectionTypes.ConnectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, PrivateConnectionFactory, InnerPrivateConnectionConnectionConfigurationFactory> WithConnectionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PrivateConnectionFactory> combinedResult, Action<Humidifier.DevOpsAgent.PrivateConnectionTypes.ConnectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionConfiguration(combinedResult.T5, subFactoryAction).T2);
}
