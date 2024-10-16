// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ManagedBlockchain;

public class InnerMemberMemberConfigurationFactory(Action<Humidifier.ManagedBlockchain.MemberTypes.MemberConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ManagedBlockchain.MemberTypes.MemberConfiguration>
{

    internal InnerMemberMemberFrameworkConfigurationFactory MemberFrameworkConfigurationFactory { get; set; }

    protected override Humidifier.ManagedBlockchain.MemberTypes.MemberConfiguration Create()
    {
        var memberConfigurationResult = CreateMemberConfiguration();
        factoryAction?.Invoke(memberConfigurationResult);

        return memberConfigurationResult;
    }

    private Humidifier.ManagedBlockchain.MemberTypes.MemberConfiguration CreateMemberConfiguration()
    {
        var memberConfigurationResult = new Humidifier.ManagedBlockchain.MemberTypes.MemberConfiguration();

        return memberConfigurationResult;
    }
    public override void CreateChildren(Humidifier.ManagedBlockchain.MemberTypes.MemberConfiguration result)
    {
        base.CreateChildren(result);

        result.MemberFrameworkConfiguration ??= MemberFrameworkConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerMemberMemberConfigurationFactoryExtensions
{
    public static CombinedResult<InnerMemberMemberConfigurationFactory, InnerMemberMemberFrameworkConfigurationFactory> WithMemberFrameworkConfiguration(this InnerMemberMemberConfigurationFactory parentFactory, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberFrameworkConfiguration> subFactoryAction = null)
    {
        parentFactory.MemberFrameworkConfigurationFactory = new InnerMemberMemberFrameworkConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MemberFrameworkConfigurationFactory);
    }

    public static CombinedResult<InnerMemberMemberConfigurationFactory, T1, InnerMemberMemberFrameworkConfigurationFactory> WithMemberFrameworkConfiguration<T1>(this CombinedResult<InnerMemberMemberConfigurationFactory, T1> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberFrameworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithMemberFrameworkConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMemberMemberConfigurationFactory, InnerMemberMemberFrameworkConfigurationFactory> WithMemberFrameworkConfiguration<T1>(this CombinedResult<T1, InnerMemberMemberConfigurationFactory> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberFrameworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithMemberFrameworkConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerMemberMemberConfigurationFactory, T1, T2, InnerMemberMemberFrameworkConfigurationFactory> WithMemberFrameworkConfiguration<T1, T2>(this CombinedResult<InnerMemberMemberConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberFrameworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMemberFrameworkConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMemberMemberConfigurationFactory, T2, InnerMemberMemberFrameworkConfigurationFactory> WithMemberFrameworkConfiguration<T1, T2>(this CombinedResult<T1, InnerMemberMemberConfigurationFactory, T2> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberFrameworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMemberFrameworkConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMemberMemberConfigurationFactory, InnerMemberMemberFrameworkConfigurationFactory> WithMemberFrameworkConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerMemberMemberConfigurationFactory> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberFrameworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMemberFrameworkConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerMemberMemberConfigurationFactory, T1, T2, T3, InnerMemberMemberFrameworkConfigurationFactory> WithMemberFrameworkConfiguration<T1, T2, T3>(this CombinedResult<InnerMemberMemberConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberFrameworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemberFrameworkConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMemberMemberConfigurationFactory, T2, T3, InnerMemberMemberFrameworkConfigurationFactory> WithMemberFrameworkConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerMemberMemberConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberFrameworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemberFrameworkConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMemberMemberConfigurationFactory, T3, InnerMemberMemberFrameworkConfigurationFactory> WithMemberFrameworkConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerMemberMemberConfigurationFactory, T3> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberFrameworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemberFrameworkConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMemberMemberConfigurationFactory, InnerMemberMemberFrameworkConfigurationFactory> WithMemberFrameworkConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMemberMemberConfigurationFactory> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberFrameworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemberFrameworkConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerMemberMemberConfigurationFactory, T1, T2, T3, T4, InnerMemberMemberFrameworkConfigurationFactory> WithMemberFrameworkConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerMemberMemberConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberFrameworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemberFrameworkConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMemberMemberConfigurationFactory, T2, T3, T4, InnerMemberMemberFrameworkConfigurationFactory> WithMemberFrameworkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerMemberMemberConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberFrameworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemberFrameworkConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMemberMemberConfigurationFactory, T3, T4, InnerMemberMemberFrameworkConfigurationFactory> WithMemberFrameworkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMemberMemberConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberFrameworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemberFrameworkConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMemberMemberConfigurationFactory, T4, InnerMemberMemberFrameworkConfigurationFactory> WithMemberFrameworkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMemberMemberConfigurationFactory, T4> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberFrameworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemberFrameworkConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerMemberMemberConfigurationFactory, InnerMemberMemberFrameworkConfigurationFactory> WithMemberFrameworkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMemberMemberConfigurationFactory> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.MemberFrameworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemberFrameworkConfiguration(combinedResult.T5, subFactoryAction));
}
