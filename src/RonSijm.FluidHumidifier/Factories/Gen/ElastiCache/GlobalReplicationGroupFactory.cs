// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElastiCache;

public class GlobalReplicationGroupFactory(string resourceName = null, Action<Humidifier.ElastiCache.GlobalReplicationGroup> factoryAction = null) : ResourceFactory<Humidifier.ElastiCache.GlobalReplicationGroup>(resourceName)
{

    internal List<InnerGlobalReplicationGroupRegionalConfigurationFactory> RegionalConfigurationsFactories { get; set; } = [];

    internal List<InnerGlobalReplicationGroupGlobalReplicationGroupMemberFactory> MembersFactories { get; set; } = [];

    protected override Humidifier.ElastiCache.GlobalReplicationGroup Create()
    {
        var globalReplicationGroupResult = CreateGlobalReplicationGroup();
        factoryAction?.Invoke(globalReplicationGroupResult);

        return globalReplicationGroupResult;
    }

    private Humidifier.ElastiCache.GlobalReplicationGroup CreateGlobalReplicationGroup()
    {
        var globalReplicationGroupResult = new Humidifier.ElastiCache.GlobalReplicationGroup
        {
            GivenName = InputResourceName,
        };

        return globalReplicationGroupResult;
    }
    public override void CreateChildren(Humidifier.ElastiCache.GlobalReplicationGroup result)
    {
        base.CreateChildren(result);

        result.RegionalConfigurations = RegionalConfigurationsFactories.Any() ? RegionalConfigurationsFactories.Select(x => x.Build()).ToList() : null;
        result.Members = MembersFactories.Any() ? MembersFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class GlobalReplicationGroupFactoryExtensions
{
    public static CombinedResult<GlobalReplicationGroupFactory, InnerGlobalReplicationGroupRegionalConfigurationFactory> WithRegionalConfigurations(this GlobalReplicationGroupFactory parentFactory, Action<Humidifier.ElastiCache.GlobalReplicationGroupTypes.RegionalConfiguration> subFactoryAction = null)
    {
        var factory = new InnerGlobalReplicationGroupRegionalConfigurationFactory(subFactoryAction);
        parentFactory.RegionalConfigurationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<GlobalReplicationGroupFactory, InnerGlobalReplicationGroupGlobalReplicationGroupMemberFactory> WithMembers(this GlobalReplicationGroupFactory parentFactory, Action<Humidifier.ElastiCache.GlobalReplicationGroupTypes.GlobalReplicationGroupMember> subFactoryAction = null)
    {
        var factory = new InnerGlobalReplicationGroupGlobalReplicationGroupMemberFactory(subFactoryAction);
        parentFactory.MembersFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<GlobalReplicationGroupFactory, T1, InnerGlobalReplicationGroupRegionalConfigurationFactory> WithRegionalConfigurations<T1>(this CombinedResult<GlobalReplicationGroupFactory, T1> combinedResult, Action<Humidifier.ElastiCache.GlobalReplicationGroupTypes.RegionalConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithRegionalConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GlobalReplicationGroupFactory, InnerGlobalReplicationGroupRegionalConfigurationFactory> WithRegionalConfigurations<T1>(this CombinedResult<T1, GlobalReplicationGroupFactory> combinedResult, Action<Humidifier.ElastiCache.GlobalReplicationGroupTypes.RegionalConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithRegionalConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<GlobalReplicationGroupFactory, T1, T2, InnerGlobalReplicationGroupRegionalConfigurationFactory> WithRegionalConfigurations<T1, T2>(this CombinedResult<GlobalReplicationGroupFactory, T1, T2> combinedResult, Action<Humidifier.ElastiCache.GlobalReplicationGroupTypes.RegionalConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRegionalConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GlobalReplicationGroupFactory, T2, InnerGlobalReplicationGroupRegionalConfigurationFactory> WithRegionalConfigurations<T1, T2>(this CombinedResult<T1, GlobalReplicationGroupFactory, T2> combinedResult, Action<Humidifier.ElastiCache.GlobalReplicationGroupTypes.RegionalConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRegionalConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GlobalReplicationGroupFactory, InnerGlobalReplicationGroupRegionalConfigurationFactory> WithRegionalConfigurations<T1, T2>(this CombinedResult<T1, T2, GlobalReplicationGroupFactory> combinedResult, Action<Humidifier.ElastiCache.GlobalReplicationGroupTypes.RegionalConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRegionalConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<GlobalReplicationGroupFactory, T1, T2, T3, InnerGlobalReplicationGroupRegionalConfigurationFactory> WithRegionalConfigurations<T1, T2, T3>(this CombinedResult<GlobalReplicationGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.ElastiCache.GlobalReplicationGroupTypes.RegionalConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRegionalConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GlobalReplicationGroupFactory, T2, T3, InnerGlobalReplicationGroupRegionalConfigurationFactory> WithRegionalConfigurations<T1, T2, T3>(this CombinedResult<T1, GlobalReplicationGroupFactory, T2, T3> combinedResult, Action<Humidifier.ElastiCache.GlobalReplicationGroupTypes.RegionalConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRegionalConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GlobalReplicationGroupFactory, T3, InnerGlobalReplicationGroupRegionalConfigurationFactory> WithRegionalConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, GlobalReplicationGroupFactory, T3> combinedResult, Action<Humidifier.ElastiCache.GlobalReplicationGroupTypes.RegionalConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRegionalConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GlobalReplicationGroupFactory, InnerGlobalReplicationGroupRegionalConfigurationFactory> WithRegionalConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, T3, GlobalReplicationGroupFactory> combinedResult, Action<Humidifier.ElastiCache.GlobalReplicationGroupTypes.RegionalConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRegionalConfigurations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<GlobalReplicationGroupFactory, T1, T2, T3, T4, InnerGlobalReplicationGroupRegionalConfigurationFactory> WithRegionalConfigurations<T1, T2, T3, T4>(this CombinedResult<GlobalReplicationGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ElastiCache.GlobalReplicationGroupTypes.RegionalConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegionalConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GlobalReplicationGroupFactory, T2, T3, T4, InnerGlobalReplicationGroupRegionalConfigurationFactory> WithRegionalConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, GlobalReplicationGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.ElastiCache.GlobalReplicationGroupTypes.RegionalConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegionalConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GlobalReplicationGroupFactory, T3, T4, InnerGlobalReplicationGroupRegionalConfigurationFactory> WithRegionalConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, GlobalReplicationGroupFactory, T3, T4> combinedResult, Action<Humidifier.ElastiCache.GlobalReplicationGroupTypes.RegionalConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegionalConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GlobalReplicationGroupFactory, T4, InnerGlobalReplicationGroupRegionalConfigurationFactory> WithRegionalConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, GlobalReplicationGroupFactory, T4> combinedResult, Action<Humidifier.ElastiCache.GlobalReplicationGroupTypes.RegionalConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegionalConfigurations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, GlobalReplicationGroupFactory, InnerGlobalReplicationGroupRegionalConfigurationFactory> WithRegionalConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, GlobalReplicationGroupFactory> combinedResult, Action<Humidifier.ElastiCache.GlobalReplicationGroupTypes.RegionalConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegionalConfigurations(combinedResult.T5, subFactoryAction));
    public static CombinedResult<GlobalReplicationGroupFactory, T1, InnerGlobalReplicationGroupGlobalReplicationGroupMemberFactory> WithMembers<T1>(this CombinedResult<GlobalReplicationGroupFactory, T1> combinedResult, Action<Humidifier.ElastiCache.GlobalReplicationGroupTypes.GlobalReplicationGroupMember> subFactoryAction = null) => new (combinedResult, combinedResult, WithMembers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GlobalReplicationGroupFactory, InnerGlobalReplicationGroupGlobalReplicationGroupMemberFactory> WithMembers<T1>(this CombinedResult<T1, GlobalReplicationGroupFactory> combinedResult, Action<Humidifier.ElastiCache.GlobalReplicationGroupTypes.GlobalReplicationGroupMember> subFactoryAction = null) => new (combinedResult, combinedResult, WithMembers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<GlobalReplicationGroupFactory, T1, T2, InnerGlobalReplicationGroupGlobalReplicationGroupMemberFactory> WithMembers<T1, T2>(this CombinedResult<GlobalReplicationGroupFactory, T1, T2> combinedResult, Action<Humidifier.ElastiCache.GlobalReplicationGroupTypes.GlobalReplicationGroupMember> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMembers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GlobalReplicationGroupFactory, T2, InnerGlobalReplicationGroupGlobalReplicationGroupMemberFactory> WithMembers<T1, T2>(this CombinedResult<T1, GlobalReplicationGroupFactory, T2> combinedResult, Action<Humidifier.ElastiCache.GlobalReplicationGroupTypes.GlobalReplicationGroupMember> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMembers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GlobalReplicationGroupFactory, InnerGlobalReplicationGroupGlobalReplicationGroupMemberFactory> WithMembers<T1, T2>(this CombinedResult<T1, T2, GlobalReplicationGroupFactory> combinedResult, Action<Humidifier.ElastiCache.GlobalReplicationGroupTypes.GlobalReplicationGroupMember> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMembers(combinedResult.T3, subFactoryAction));
    public static CombinedResult<GlobalReplicationGroupFactory, T1, T2, T3, InnerGlobalReplicationGroupGlobalReplicationGroupMemberFactory> WithMembers<T1, T2, T3>(this CombinedResult<GlobalReplicationGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.ElastiCache.GlobalReplicationGroupTypes.GlobalReplicationGroupMember> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMembers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GlobalReplicationGroupFactory, T2, T3, InnerGlobalReplicationGroupGlobalReplicationGroupMemberFactory> WithMembers<T1, T2, T3>(this CombinedResult<T1, GlobalReplicationGroupFactory, T2, T3> combinedResult, Action<Humidifier.ElastiCache.GlobalReplicationGroupTypes.GlobalReplicationGroupMember> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMembers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GlobalReplicationGroupFactory, T3, InnerGlobalReplicationGroupGlobalReplicationGroupMemberFactory> WithMembers<T1, T2, T3>(this CombinedResult<T1, T2, GlobalReplicationGroupFactory, T3> combinedResult, Action<Humidifier.ElastiCache.GlobalReplicationGroupTypes.GlobalReplicationGroupMember> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMembers(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GlobalReplicationGroupFactory, InnerGlobalReplicationGroupGlobalReplicationGroupMemberFactory> WithMembers<T1, T2, T3>(this CombinedResult<T1, T2, T3, GlobalReplicationGroupFactory> combinedResult, Action<Humidifier.ElastiCache.GlobalReplicationGroupTypes.GlobalReplicationGroupMember> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMembers(combinedResult.T4, subFactoryAction));
    public static CombinedResult<GlobalReplicationGroupFactory, T1, T2, T3, T4, InnerGlobalReplicationGroupGlobalReplicationGroupMemberFactory> WithMembers<T1, T2, T3, T4>(this CombinedResult<GlobalReplicationGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ElastiCache.GlobalReplicationGroupTypes.GlobalReplicationGroupMember> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMembers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GlobalReplicationGroupFactory, T2, T3, T4, InnerGlobalReplicationGroupGlobalReplicationGroupMemberFactory> WithMembers<T1, T2, T3, T4>(this CombinedResult<T1, GlobalReplicationGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.ElastiCache.GlobalReplicationGroupTypes.GlobalReplicationGroupMember> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMembers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GlobalReplicationGroupFactory, T3, T4, InnerGlobalReplicationGroupGlobalReplicationGroupMemberFactory> WithMembers<T1, T2, T3, T4>(this CombinedResult<T1, T2, GlobalReplicationGroupFactory, T3, T4> combinedResult, Action<Humidifier.ElastiCache.GlobalReplicationGroupTypes.GlobalReplicationGroupMember> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMembers(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GlobalReplicationGroupFactory, T4, InnerGlobalReplicationGroupGlobalReplicationGroupMemberFactory> WithMembers<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, GlobalReplicationGroupFactory, T4> combinedResult, Action<Humidifier.ElastiCache.GlobalReplicationGroupTypes.GlobalReplicationGroupMember> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMembers(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, GlobalReplicationGroupFactory, InnerGlobalReplicationGroupGlobalReplicationGroupMemberFactory> WithMembers<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, GlobalReplicationGroupFactory> combinedResult, Action<Humidifier.ElastiCache.GlobalReplicationGroupTypes.GlobalReplicationGroupMember> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMembers(combinedResult.T5, subFactoryAction));
}
