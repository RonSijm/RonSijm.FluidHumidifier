// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ManagedBlockchain;

public class InnerMemberNetworkFrameworkConfigurationFactory(Action<Humidifier.ManagedBlockchain.MemberTypes.NetworkFrameworkConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ManagedBlockchain.MemberTypes.NetworkFrameworkConfiguration>
{

    internal InnerMemberNetworkFabricConfigurationFactory NetworkFabricConfigurationFactory { get; set; }

    protected override Humidifier.ManagedBlockchain.MemberTypes.NetworkFrameworkConfiguration Create()
    {
        var networkFrameworkConfigurationResult = CreateNetworkFrameworkConfiguration();
        factoryAction?.Invoke(networkFrameworkConfigurationResult);

        return networkFrameworkConfigurationResult;
    }

    private Humidifier.ManagedBlockchain.MemberTypes.NetworkFrameworkConfiguration CreateNetworkFrameworkConfiguration()
    {
        var networkFrameworkConfigurationResult = new Humidifier.ManagedBlockchain.MemberTypes.NetworkFrameworkConfiguration();

        return networkFrameworkConfigurationResult;
    }
    public override void CreateChildren(Humidifier.ManagedBlockchain.MemberTypes.NetworkFrameworkConfiguration result)
    {
        base.CreateChildren(result);

        result.NetworkFabricConfiguration ??= NetworkFabricConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerMemberNetworkFrameworkConfigurationFactoryExtensions
{
    public static CombinedResult<InnerMemberNetworkFrameworkConfigurationFactory, InnerMemberNetworkFabricConfigurationFactory> WithNetworkFabricConfiguration(this InnerMemberNetworkFrameworkConfigurationFactory parentFactory, Action<Humidifier.ManagedBlockchain.MemberTypes.NetworkFabricConfiguration> subFactoryAction = null)
    {
        parentFactory.NetworkFabricConfigurationFactory = new InnerMemberNetworkFabricConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NetworkFabricConfigurationFactory);
    }

    public static CombinedResult<InnerMemberNetworkFrameworkConfigurationFactory, T1, InnerMemberNetworkFabricConfigurationFactory> WithNetworkFabricConfiguration<T1>(this CombinedResult<InnerMemberNetworkFrameworkConfigurationFactory, T1> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.NetworkFabricConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkFabricConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMemberNetworkFrameworkConfigurationFactory, InnerMemberNetworkFabricConfigurationFactory> WithNetworkFabricConfiguration<T1>(this CombinedResult<T1, InnerMemberNetworkFrameworkConfigurationFactory> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.NetworkFabricConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkFabricConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerMemberNetworkFrameworkConfigurationFactory, T1, T2, InnerMemberNetworkFabricConfigurationFactory> WithNetworkFabricConfiguration<T1, T2>(this CombinedResult<InnerMemberNetworkFrameworkConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.NetworkFabricConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkFabricConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMemberNetworkFrameworkConfigurationFactory, T2, InnerMemberNetworkFabricConfigurationFactory> WithNetworkFabricConfiguration<T1, T2>(this CombinedResult<T1, InnerMemberNetworkFrameworkConfigurationFactory, T2> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.NetworkFabricConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkFabricConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMemberNetworkFrameworkConfigurationFactory, InnerMemberNetworkFabricConfigurationFactory> WithNetworkFabricConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerMemberNetworkFrameworkConfigurationFactory> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.NetworkFabricConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkFabricConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerMemberNetworkFrameworkConfigurationFactory, T1, T2, T3, InnerMemberNetworkFabricConfigurationFactory> WithNetworkFabricConfiguration<T1, T2, T3>(this CombinedResult<InnerMemberNetworkFrameworkConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.NetworkFabricConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkFabricConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMemberNetworkFrameworkConfigurationFactory, T2, T3, InnerMemberNetworkFabricConfigurationFactory> WithNetworkFabricConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerMemberNetworkFrameworkConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.NetworkFabricConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkFabricConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMemberNetworkFrameworkConfigurationFactory, T3, InnerMemberNetworkFabricConfigurationFactory> WithNetworkFabricConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerMemberNetworkFrameworkConfigurationFactory, T3> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.NetworkFabricConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkFabricConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMemberNetworkFrameworkConfigurationFactory, InnerMemberNetworkFabricConfigurationFactory> WithNetworkFabricConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMemberNetworkFrameworkConfigurationFactory> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.NetworkFabricConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkFabricConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerMemberNetworkFrameworkConfigurationFactory, T1, T2, T3, T4, InnerMemberNetworkFabricConfigurationFactory> WithNetworkFabricConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerMemberNetworkFrameworkConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.NetworkFabricConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkFabricConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMemberNetworkFrameworkConfigurationFactory, T2, T3, T4, InnerMemberNetworkFabricConfigurationFactory> WithNetworkFabricConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerMemberNetworkFrameworkConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.NetworkFabricConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkFabricConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMemberNetworkFrameworkConfigurationFactory, T3, T4, InnerMemberNetworkFabricConfigurationFactory> WithNetworkFabricConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMemberNetworkFrameworkConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.NetworkFabricConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkFabricConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMemberNetworkFrameworkConfigurationFactory, T4, InnerMemberNetworkFabricConfigurationFactory> WithNetworkFabricConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMemberNetworkFrameworkConfigurationFactory, T4> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.NetworkFabricConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkFabricConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerMemberNetworkFrameworkConfigurationFactory, InnerMemberNetworkFabricConfigurationFactory> WithNetworkFabricConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMemberNetworkFrameworkConfigurationFactory> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.NetworkFabricConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkFabricConfiguration(combinedResult.T5, subFactoryAction));
}
