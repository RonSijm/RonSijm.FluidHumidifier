// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ManagedBlockchain;

public class MemberFactory(string resourceName = null, Action<Humidifier.ManagedBlockchain.Member> factoryAction = null) : ResourceFactory<Humidifier.ManagedBlockchain.Member>(resourceName)
{

    internal InnerMemberMemberConfigurationFactory MemberConfigurationFactory { get; set; }

    internal InnerMemberNetworkConfigurationFactory NetworkConfigurationFactory { get; set; }

    protected override Humidifier.ManagedBlockchain.Member Create()
    {
        var memberResult = CreateMember();
        factoryAction?.Invoke(memberResult);

        return memberResult;
    }

    private Humidifier.ManagedBlockchain.Member CreateMember()
    {
        var memberResult = new Humidifier.ManagedBlockchain.Member
        {
            GivenName = InputResourceName,
        };

        return memberResult;
    }
    public override void CreateChildren(Humidifier.ManagedBlockchain.Member result)
    {
        base.CreateChildren(result);

        result.MemberConfiguration ??= MemberConfigurationFactory?.Build();
        result.NetworkConfiguration ??= NetworkConfigurationFactory?.Build();
    }

} // End Of Class

public static class MemberFactoryExtensions
{
    public static CombinedResult<MemberFactory, InnerMemberMemberConfigurationFactory> WithMemberConfiguration(this MemberFactory parentFactory, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberConfiguration> subFactoryAction = null)
    {
        parentFactory.MemberConfigurationFactory = new InnerMemberMemberConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MemberConfigurationFactory);
    }

    public static CombinedResult<MemberFactory, InnerMemberNetworkConfigurationFactory> WithNetworkConfiguration(this MemberFactory parentFactory, Action<Humidifier.ManagedBlockchain.MemberTypes.NetworkConfiguration> subFactoryAction = null)
    {
        parentFactory.NetworkConfigurationFactory = new InnerMemberNetworkConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NetworkConfigurationFactory);
    }

    public static CombinedResult<MemberFactory, T1, InnerMemberMemberConfigurationFactory> WithMemberConfiguration<T1>(this CombinedResult<MemberFactory, T1> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithMemberConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MemberFactory, InnerMemberMemberConfigurationFactory> WithMemberConfiguration<T1>(this CombinedResult<T1, MemberFactory> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithMemberConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<MemberFactory, T1, T2, InnerMemberMemberConfigurationFactory> WithMemberConfiguration<T1, T2>(this CombinedResult<MemberFactory, T1, T2> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMemberConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MemberFactory, T2, InnerMemberMemberConfigurationFactory> WithMemberConfiguration<T1, T2>(this CombinedResult<T1, MemberFactory, T2> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMemberConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MemberFactory, InnerMemberMemberConfigurationFactory> WithMemberConfiguration<T1, T2>(this CombinedResult<T1, T2, MemberFactory> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMemberConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<MemberFactory, T1, T2, T3, InnerMemberMemberConfigurationFactory> WithMemberConfiguration<T1, T2, T3>(this CombinedResult<MemberFactory, T1, T2, T3> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemberConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MemberFactory, T2, T3, InnerMemberMemberConfigurationFactory> WithMemberConfiguration<T1, T2, T3>(this CombinedResult<T1, MemberFactory, T2, T3> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemberConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MemberFactory, T3, InnerMemberMemberConfigurationFactory> WithMemberConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, MemberFactory, T3> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemberConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MemberFactory, InnerMemberMemberConfigurationFactory> WithMemberConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, MemberFactory> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemberConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<MemberFactory, T1, T2, T3, T4, InnerMemberMemberConfigurationFactory> WithMemberConfiguration<T1, T2, T3, T4>(this CombinedResult<MemberFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemberConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MemberFactory, T2, T3, T4, InnerMemberMemberConfigurationFactory> WithMemberConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, MemberFactory, T2, T3, T4> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemberConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MemberFactory, T3, T4, InnerMemberMemberConfigurationFactory> WithMemberConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, MemberFactory, T3, T4> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemberConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MemberFactory, T4, InnerMemberMemberConfigurationFactory> WithMemberConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MemberFactory, T4> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemberConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, MemberFactory, InnerMemberMemberConfigurationFactory> WithMemberConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MemberFactory> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemberConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<MemberFactory, T1, InnerMemberNetworkConfigurationFactory> WithNetworkConfiguration<T1>(this CombinedResult<MemberFactory, T1> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MemberFactory, InnerMemberNetworkConfigurationFactory> WithNetworkConfiguration<T1>(this CombinedResult<T1, MemberFactory> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<MemberFactory, T1, T2, InnerMemberNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2>(this CombinedResult<MemberFactory, T1, T2> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MemberFactory, T2, InnerMemberNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2>(this CombinedResult<T1, MemberFactory, T2> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MemberFactory, InnerMemberNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2>(this CombinedResult<T1, T2, MemberFactory> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<MemberFactory, T1, T2, T3, InnerMemberNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3>(this CombinedResult<MemberFactory, T1, T2, T3> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MemberFactory, T2, T3, InnerMemberNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3>(this CombinedResult<T1, MemberFactory, T2, T3> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MemberFactory, T3, InnerMemberNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, MemberFactory, T3> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MemberFactory, InnerMemberNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, MemberFactory> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<MemberFactory, T1, T2, T3, T4, InnerMemberNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3, T4>(this CombinedResult<MemberFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MemberFactory, T2, T3, T4, InnerMemberNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, MemberFactory, T2, T3, T4> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MemberFactory, T3, T4, InnerMemberNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, MemberFactory, T3, T4> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MemberFactory, T4, InnerMemberNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MemberFactory, T4> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, MemberFactory, InnerMemberNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MemberFactory> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T5, subFactoryAction));
}
