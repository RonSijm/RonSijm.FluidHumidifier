// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.XRay;

public class GroupFactory(string resourceName = null, Action<Humidifier.XRay.Group> factoryAction = null) : ResourceFactory<Humidifier.XRay.Group>(resourceName)
{

    internal InnerGroupInsightsConfigurationFactory InsightsConfigurationFactory { get; set; }

    protected override Humidifier.XRay.Group Create()
    {
        var groupResult = CreateGroup();
        factoryAction?.Invoke(groupResult);

        return groupResult;
    }

    private Humidifier.XRay.Group CreateGroup()
    {
        var groupResult = new Humidifier.XRay.Group
        {
            GivenName = InputResourceName,
        };

        return groupResult;
    }
    public override void CreateChildren(Humidifier.XRay.Group result)
    {
        base.CreateChildren(result);

        result.InsightsConfiguration ??= InsightsConfigurationFactory?.Build();
    }

} // End Of Class

public static class GroupFactoryExtensions
{
    public static CombinedResult<GroupFactory, InnerGroupInsightsConfigurationFactory> WithInsightsConfiguration(this GroupFactory parentFactory, Action<Humidifier.XRay.GroupTypes.InsightsConfiguration> subFactoryAction = null)
    {
        parentFactory.InsightsConfigurationFactory = new InnerGroupInsightsConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InsightsConfigurationFactory);
    }

    public static CombinedResult<GroupFactory, T1, InnerGroupInsightsConfigurationFactory> WithInsightsConfiguration<T1>(this CombinedResult<GroupFactory, T1> combinedResult, Action<Humidifier.XRay.GroupTypes.InsightsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithInsightsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GroupFactory, InnerGroupInsightsConfigurationFactory> WithInsightsConfiguration<T1>(this CombinedResult<T1, GroupFactory> combinedResult, Action<Humidifier.XRay.GroupTypes.InsightsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithInsightsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<GroupFactory, T1, T2, InnerGroupInsightsConfigurationFactory> WithInsightsConfiguration<T1, T2>(this CombinedResult<GroupFactory, T1, T2> combinedResult, Action<Humidifier.XRay.GroupTypes.InsightsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInsightsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GroupFactory, T2, InnerGroupInsightsConfigurationFactory> WithInsightsConfiguration<T1, T2>(this CombinedResult<T1, GroupFactory, T2> combinedResult, Action<Humidifier.XRay.GroupTypes.InsightsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInsightsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GroupFactory, InnerGroupInsightsConfigurationFactory> WithInsightsConfiguration<T1, T2>(this CombinedResult<T1, T2, GroupFactory> combinedResult, Action<Humidifier.XRay.GroupTypes.InsightsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInsightsConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<GroupFactory, T1, T2, T3, InnerGroupInsightsConfigurationFactory> WithInsightsConfiguration<T1, T2, T3>(this CombinedResult<GroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.XRay.GroupTypes.InsightsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInsightsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GroupFactory, T2, T3, InnerGroupInsightsConfigurationFactory> WithInsightsConfiguration<T1, T2, T3>(this CombinedResult<T1, GroupFactory, T2, T3> combinedResult, Action<Humidifier.XRay.GroupTypes.InsightsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInsightsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GroupFactory, T3, InnerGroupInsightsConfigurationFactory> WithInsightsConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, GroupFactory, T3> combinedResult, Action<Humidifier.XRay.GroupTypes.InsightsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInsightsConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GroupFactory, InnerGroupInsightsConfigurationFactory> WithInsightsConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, GroupFactory> combinedResult, Action<Humidifier.XRay.GroupTypes.InsightsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInsightsConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<GroupFactory, T1, T2, T3, T4, InnerGroupInsightsConfigurationFactory> WithInsightsConfiguration<T1, T2, T3, T4>(this CombinedResult<GroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.XRay.GroupTypes.InsightsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInsightsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GroupFactory, T2, T3, T4, InnerGroupInsightsConfigurationFactory> WithInsightsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, GroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.XRay.GroupTypes.InsightsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInsightsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GroupFactory, T3, T4, InnerGroupInsightsConfigurationFactory> WithInsightsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, GroupFactory, T3, T4> combinedResult, Action<Humidifier.XRay.GroupTypes.InsightsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInsightsConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GroupFactory, T4, InnerGroupInsightsConfigurationFactory> WithInsightsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, GroupFactory, T4> combinedResult, Action<Humidifier.XRay.GroupTypes.InsightsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInsightsConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, GroupFactory, InnerGroupInsightsConfigurationFactory> WithInsightsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, GroupFactory> combinedResult, Action<Humidifier.XRay.GroupTypes.InsightsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInsightsConfiguration(combinedResult.T5, subFactoryAction));
}
