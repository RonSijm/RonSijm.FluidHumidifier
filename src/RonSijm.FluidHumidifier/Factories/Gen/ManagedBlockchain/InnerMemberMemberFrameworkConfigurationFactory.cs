// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ManagedBlockchain;

public class InnerMemberMemberFrameworkConfigurationFactory(Action<Humidifier.ManagedBlockchain.MemberTypes.MemberFrameworkConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ManagedBlockchain.MemberTypes.MemberFrameworkConfiguration>
{

    internal InnerMemberMemberFabricConfigurationFactory MemberFabricConfigurationFactory { get; set; }

    protected override Humidifier.ManagedBlockchain.MemberTypes.MemberFrameworkConfiguration Create()
    {
        var memberFrameworkConfigurationResult = CreateMemberFrameworkConfiguration();
        factoryAction?.Invoke(memberFrameworkConfigurationResult);

        return memberFrameworkConfigurationResult;
    }

    private Humidifier.ManagedBlockchain.MemberTypes.MemberFrameworkConfiguration CreateMemberFrameworkConfiguration()
    {
        var memberFrameworkConfigurationResult = new Humidifier.ManagedBlockchain.MemberTypes.MemberFrameworkConfiguration();

        return memberFrameworkConfigurationResult;
    }
    public override void CreateChildren(Humidifier.ManagedBlockchain.MemberTypes.MemberFrameworkConfiguration result)
    {
        base.CreateChildren(result);

        result.MemberFabricConfiguration ??= MemberFabricConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerMemberMemberFrameworkConfigurationFactoryExtensions
{
    public static CombinedResult<InnerMemberMemberFrameworkConfigurationFactory, InnerMemberMemberFabricConfigurationFactory> WithMemberFabricConfiguration(this InnerMemberMemberFrameworkConfigurationFactory parentFactory, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberFabricConfiguration> subFactoryAction = null)
    {
        parentFactory.MemberFabricConfigurationFactory = new InnerMemberMemberFabricConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MemberFabricConfigurationFactory);
    }

    public static CombinedResult<InnerMemberMemberFrameworkConfigurationFactory, T1, InnerMemberMemberFabricConfigurationFactory> WithMemberFabricConfiguration<T1>(this CombinedResult<InnerMemberMemberFrameworkConfigurationFactory, T1> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberFabricConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithMemberFabricConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMemberMemberFrameworkConfigurationFactory, InnerMemberMemberFabricConfigurationFactory> WithMemberFabricConfiguration<T1>(this CombinedResult<T1, InnerMemberMemberFrameworkConfigurationFactory> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberFabricConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithMemberFabricConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerMemberMemberFrameworkConfigurationFactory, T1, T2, InnerMemberMemberFabricConfigurationFactory> WithMemberFabricConfiguration<T1, T2>(this CombinedResult<InnerMemberMemberFrameworkConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberFabricConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMemberFabricConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMemberMemberFrameworkConfigurationFactory, T2, InnerMemberMemberFabricConfigurationFactory> WithMemberFabricConfiguration<T1, T2>(this CombinedResult<T1, InnerMemberMemberFrameworkConfigurationFactory, T2> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberFabricConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMemberFabricConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMemberMemberFrameworkConfigurationFactory, InnerMemberMemberFabricConfigurationFactory> WithMemberFabricConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerMemberMemberFrameworkConfigurationFactory> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberFabricConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMemberFabricConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerMemberMemberFrameworkConfigurationFactory, T1, T2, T3, InnerMemberMemberFabricConfigurationFactory> WithMemberFabricConfiguration<T1, T2, T3>(this CombinedResult<InnerMemberMemberFrameworkConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberFabricConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemberFabricConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMemberMemberFrameworkConfigurationFactory, T2, T3, InnerMemberMemberFabricConfigurationFactory> WithMemberFabricConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerMemberMemberFrameworkConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberFabricConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemberFabricConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMemberMemberFrameworkConfigurationFactory, T3, InnerMemberMemberFabricConfigurationFactory> WithMemberFabricConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerMemberMemberFrameworkConfigurationFactory, T3> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberFabricConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemberFabricConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMemberMemberFrameworkConfigurationFactory, InnerMemberMemberFabricConfigurationFactory> WithMemberFabricConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMemberMemberFrameworkConfigurationFactory> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberFabricConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemberFabricConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerMemberMemberFrameworkConfigurationFactory, T1, T2, T3, T4, InnerMemberMemberFabricConfigurationFactory> WithMemberFabricConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerMemberMemberFrameworkConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberFabricConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemberFabricConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMemberMemberFrameworkConfigurationFactory, T2, T3, T4, InnerMemberMemberFabricConfigurationFactory> WithMemberFabricConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerMemberMemberFrameworkConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberFabricConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemberFabricConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMemberMemberFrameworkConfigurationFactory, T3, T4, InnerMemberMemberFabricConfigurationFactory> WithMemberFabricConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMemberMemberFrameworkConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberFabricConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemberFabricConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMemberMemberFrameworkConfigurationFactory, T4, InnerMemberMemberFabricConfigurationFactory> WithMemberFabricConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMemberMemberFrameworkConfigurationFactory, T4> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberFabricConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemberFabricConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerMemberMemberFrameworkConfigurationFactory, InnerMemberMemberFabricConfigurationFactory> WithMemberFabricConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMemberMemberFrameworkConfigurationFactory> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberFabricConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemberFabricConfiguration(combinedResult.T5, subFactoryAction));
}
