// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ResourceGroups;

public class GroupFactory(string resourceName = null, Action<Humidifier.ResourceGroups.Group> factoryAction = null) : ResourceFactory<Humidifier.ResourceGroups.Group>(resourceName)
{

    internal List<InnerGroupConfigurationItemFactory> ConfigurationFactories { get; set; } = [];

    internal InnerGroupResourceQueryFactory ResourceQueryFactory { get; set; }

    protected override Humidifier.ResourceGroups.Group Create()
    {
        var groupResult = CreateGroup();
        factoryAction?.Invoke(groupResult);

        return groupResult;
    }

    private Humidifier.ResourceGroups.Group CreateGroup()
    {
        var groupResult = new Humidifier.ResourceGroups.Group
        {
            GivenName = InputResourceName,
        };

        return groupResult;
    }
    public override void CreateChildren(Humidifier.ResourceGroups.Group result)
    {
        base.CreateChildren(result);

        result.Configuration = ConfigurationFactories.Any() ? ConfigurationFactories.Select(x => x.Build()).ToList() : null;
        result.ResourceQuery ??= ResourceQueryFactory?.Build();
    }

} // End Of Class

public static class GroupFactoryExtensions
{
    public static CombinedResult<GroupFactory, InnerGroupConfigurationItemFactory> WithConfiguration(this GroupFactory parentFactory, Action<Humidifier.ResourceGroups.GroupTypes.ConfigurationItem> subFactoryAction = null)
    {
        var factory = new InnerGroupConfigurationItemFactory(subFactoryAction);
        parentFactory.ConfigurationFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<GroupFactory, InnerGroupResourceQueryFactory> WithResourceQuery(this GroupFactory parentFactory, Action<Humidifier.ResourceGroups.GroupTypes.ResourceQuery> subFactoryAction = null)
    {
        parentFactory.ResourceQueryFactory = new InnerGroupResourceQueryFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ResourceQueryFactory);
    }

    public static CombinedResult<GroupFactory, T1, InnerGroupConfigurationItemFactory> WithConfiguration<T1>(this CombinedResult<GroupFactory, T1> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.ConfigurationItem> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GroupFactory, InnerGroupConfigurationItemFactory> WithConfiguration<T1>(this CombinedResult<T1, GroupFactory> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.ConfigurationItem> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<GroupFactory, T1, T2, InnerGroupConfigurationItemFactory> WithConfiguration<T1, T2>(this CombinedResult<GroupFactory, T1, T2> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.ConfigurationItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GroupFactory, T2, InnerGroupConfigurationItemFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, GroupFactory, T2> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.ConfigurationItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GroupFactory, InnerGroupConfigurationItemFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, T2, GroupFactory> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.ConfigurationItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<GroupFactory, T1, T2, T3, InnerGroupConfigurationItemFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<GroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.ConfigurationItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GroupFactory, T2, T3, InnerGroupConfigurationItemFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, GroupFactory, T2, T3> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.ConfigurationItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GroupFactory, T3, InnerGroupConfigurationItemFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, GroupFactory, T3> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.ConfigurationItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GroupFactory, InnerGroupConfigurationItemFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, GroupFactory> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.ConfigurationItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<GroupFactory, T1, T2, T3, T4, InnerGroupConfigurationItemFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<GroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.ConfigurationItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GroupFactory, T2, T3, T4, InnerGroupConfigurationItemFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, GroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.ConfigurationItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GroupFactory, T3, T4, InnerGroupConfigurationItemFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, GroupFactory, T3, T4> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.ConfigurationItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GroupFactory, T4, InnerGroupConfigurationItemFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, GroupFactory, T4> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.ConfigurationItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, GroupFactory, InnerGroupConfigurationItemFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, GroupFactory> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.ConfigurationItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<GroupFactory, T1, InnerGroupResourceQueryFactory> WithResourceQuery<T1>(this CombinedResult<GroupFactory, T1> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.ResourceQuery> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceQuery(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GroupFactory, InnerGroupResourceQueryFactory> WithResourceQuery<T1>(this CombinedResult<T1, GroupFactory> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.ResourceQuery> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceQuery(combinedResult.T2, subFactoryAction));
    public static CombinedResult<GroupFactory, T1, T2, InnerGroupResourceQueryFactory> WithResourceQuery<T1, T2>(this CombinedResult<GroupFactory, T1, T2> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.ResourceQuery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceQuery(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GroupFactory, T2, InnerGroupResourceQueryFactory> WithResourceQuery<T1, T2>(this CombinedResult<T1, GroupFactory, T2> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.ResourceQuery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceQuery(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GroupFactory, InnerGroupResourceQueryFactory> WithResourceQuery<T1, T2>(this CombinedResult<T1, T2, GroupFactory> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.ResourceQuery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceQuery(combinedResult.T3, subFactoryAction));
    public static CombinedResult<GroupFactory, T1, T2, T3, InnerGroupResourceQueryFactory> WithResourceQuery<T1, T2, T3>(this CombinedResult<GroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.ResourceQuery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceQuery(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GroupFactory, T2, T3, InnerGroupResourceQueryFactory> WithResourceQuery<T1, T2, T3>(this CombinedResult<T1, GroupFactory, T2, T3> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.ResourceQuery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceQuery(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GroupFactory, T3, InnerGroupResourceQueryFactory> WithResourceQuery<T1, T2, T3>(this CombinedResult<T1, T2, GroupFactory, T3> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.ResourceQuery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceQuery(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GroupFactory, InnerGroupResourceQueryFactory> WithResourceQuery<T1, T2, T3>(this CombinedResult<T1, T2, T3, GroupFactory> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.ResourceQuery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceQuery(combinedResult.T4, subFactoryAction));
    public static CombinedResult<GroupFactory, T1, T2, T3, T4, InnerGroupResourceQueryFactory> WithResourceQuery<T1, T2, T3, T4>(this CombinedResult<GroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.ResourceQuery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceQuery(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GroupFactory, T2, T3, T4, InnerGroupResourceQueryFactory> WithResourceQuery<T1, T2, T3, T4>(this CombinedResult<T1, GroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.ResourceQuery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceQuery(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GroupFactory, T3, T4, InnerGroupResourceQueryFactory> WithResourceQuery<T1, T2, T3, T4>(this CombinedResult<T1, T2, GroupFactory, T3, T4> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.ResourceQuery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceQuery(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GroupFactory, T4, InnerGroupResourceQueryFactory> WithResourceQuery<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, GroupFactory, T4> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.ResourceQuery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceQuery(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, GroupFactory, InnerGroupResourceQueryFactory> WithResourceQuery<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, GroupFactory> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.ResourceQuery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceQuery(combinedResult.T5, subFactoryAction));
}
