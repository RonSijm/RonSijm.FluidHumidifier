// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RTBFabric;

public class LinkFactory(string resourceName = null, Action<Humidifier.RTBFabric.Link> factoryAction = null) : ResourceFactory<Humidifier.RTBFabric.Link>(resourceName)
{

    internal List<InnerLinkModuleConfigurationFactory> ModuleConfigurationListFactories { get; set; } = [];

    internal InnerLinkLinkAttributesFactory LinkAttributesFactory { get; set; }

    internal InnerLinkLinkLogSettingsFactory LinkLogSettingsFactory { get; set; }

    protected override Humidifier.RTBFabric.Link Create()
    {
        var linkResult = CreateLink();
        factoryAction?.Invoke(linkResult);

        return linkResult;
    }

    private Humidifier.RTBFabric.Link CreateLink()
    {
        var linkResult = new Humidifier.RTBFabric.Link
        {
            GivenName = InputResourceName,
        };

        return linkResult;
    }
    public override void CreateChildren(Humidifier.RTBFabric.Link result)
    {
        base.CreateChildren(result);

        result.ModuleConfigurationList = ModuleConfigurationListFactories.Any() ? ModuleConfigurationListFactories.Select(x => x.Build()).ToList() : null;
        result.LinkAttributes ??= LinkAttributesFactory?.Build();
        result.LinkLogSettings ??= LinkLogSettingsFactory?.Build();
    }

} // End Of Class

public static class LinkFactoryExtensions
{
    public static CombinedResult<LinkFactory, InnerLinkModuleConfigurationFactory> WithModuleConfigurationList(this LinkFactory parentFactory, Action<Humidifier.RTBFabric.LinkTypes.ModuleConfiguration> subFactoryAction = null)
    {
        var factory = new InnerLinkModuleConfigurationFactory(subFactoryAction);
        parentFactory.ModuleConfigurationListFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<LinkFactory, InnerLinkLinkAttributesFactory> WithLinkAttributes(this LinkFactory parentFactory, Action<Humidifier.RTBFabric.LinkTypes.LinkAttributes> subFactoryAction = null)
    {
        parentFactory.LinkAttributesFactory = new InnerLinkLinkAttributesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LinkAttributesFactory);
    }

    public static CombinedResult<LinkFactory, InnerLinkLinkLogSettingsFactory> WithLinkLogSettings(this LinkFactory parentFactory, Action<Humidifier.RTBFabric.LinkTypes.LinkLogSettings> subFactoryAction = null)
    {
        parentFactory.LinkLogSettingsFactory = new InnerLinkLinkLogSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LinkLogSettingsFactory);
    }

    public static CombinedResult<LinkFactory, T1, InnerLinkModuleConfigurationFactory> WithModuleConfigurationList<T1>(this CombinedResult<LinkFactory, T1> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ModuleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithModuleConfigurationList(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LinkFactory, InnerLinkModuleConfigurationFactory> WithModuleConfigurationList<T1>(this CombinedResult<T1, LinkFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ModuleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithModuleConfigurationList(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<LinkFactory, T1, T2, InnerLinkModuleConfigurationFactory> WithModuleConfigurationList<T1, T2>(this CombinedResult<LinkFactory, T1, T2> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ModuleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithModuleConfigurationList(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LinkFactory, T2, InnerLinkModuleConfigurationFactory> WithModuleConfigurationList<T1, T2>(this CombinedResult<T1, LinkFactory, T2> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ModuleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithModuleConfigurationList(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LinkFactory, InnerLinkModuleConfigurationFactory> WithModuleConfigurationList<T1, T2>(this CombinedResult<T1, T2, LinkFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ModuleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithModuleConfigurationList(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<LinkFactory, T1, T2, T3, InnerLinkModuleConfigurationFactory> WithModuleConfigurationList<T1, T2, T3>(this CombinedResult<LinkFactory, T1, T2, T3> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ModuleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModuleConfigurationList(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LinkFactory, T2, T3, InnerLinkModuleConfigurationFactory> WithModuleConfigurationList<T1, T2, T3>(this CombinedResult<T1, LinkFactory, T2, T3> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ModuleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModuleConfigurationList(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LinkFactory, T3, InnerLinkModuleConfigurationFactory> WithModuleConfigurationList<T1, T2, T3>(this CombinedResult<T1, T2, LinkFactory, T3> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ModuleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModuleConfigurationList(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LinkFactory, InnerLinkModuleConfigurationFactory> WithModuleConfigurationList<T1, T2, T3>(this CombinedResult<T1, T2, T3, LinkFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ModuleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModuleConfigurationList(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<LinkFactory, T1, T2, T3, T4, InnerLinkModuleConfigurationFactory> WithModuleConfigurationList<T1, T2, T3, T4>(this CombinedResult<LinkFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ModuleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModuleConfigurationList(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LinkFactory, T2, T3, T4, InnerLinkModuleConfigurationFactory> WithModuleConfigurationList<T1, T2, T3, T4>(this CombinedResult<T1, LinkFactory, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ModuleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModuleConfigurationList(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LinkFactory, T3, T4, InnerLinkModuleConfigurationFactory> WithModuleConfigurationList<T1, T2, T3, T4>(this CombinedResult<T1, T2, LinkFactory, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ModuleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModuleConfigurationList(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LinkFactory, T4, InnerLinkModuleConfigurationFactory> WithModuleConfigurationList<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LinkFactory, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ModuleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModuleConfigurationList(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, LinkFactory, InnerLinkModuleConfigurationFactory> WithModuleConfigurationList<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LinkFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ModuleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModuleConfigurationList(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<LinkFactory, T1, InnerLinkLinkAttributesFactory> WithLinkAttributes<T1>(this CombinedResult<LinkFactory, T1> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, WithLinkAttributes(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LinkFactory, InnerLinkLinkAttributesFactory> WithLinkAttributes<T1>(this CombinedResult<T1, LinkFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, WithLinkAttributes(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<LinkFactory, T1, T2, InnerLinkLinkAttributesFactory> WithLinkAttributes<T1, T2>(this CombinedResult<LinkFactory, T1, T2> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLinkAttributes(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LinkFactory, T2, InnerLinkLinkAttributesFactory> WithLinkAttributes<T1, T2>(this CombinedResult<T1, LinkFactory, T2> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLinkAttributes(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LinkFactory, InnerLinkLinkAttributesFactory> WithLinkAttributes<T1, T2>(this CombinedResult<T1, T2, LinkFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLinkAttributes(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<LinkFactory, T1, T2, T3, InnerLinkLinkAttributesFactory> WithLinkAttributes<T1, T2, T3>(this CombinedResult<LinkFactory, T1, T2, T3> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkAttributes(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LinkFactory, T2, T3, InnerLinkLinkAttributesFactory> WithLinkAttributes<T1, T2, T3>(this CombinedResult<T1, LinkFactory, T2, T3> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkAttributes(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LinkFactory, T3, InnerLinkLinkAttributesFactory> WithLinkAttributes<T1, T2, T3>(this CombinedResult<T1, T2, LinkFactory, T3> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkAttributes(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LinkFactory, InnerLinkLinkAttributesFactory> WithLinkAttributes<T1, T2, T3>(this CombinedResult<T1, T2, T3, LinkFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkAttributes(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<LinkFactory, T1, T2, T3, T4, InnerLinkLinkAttributesFactory> WithLinkAttributes<T1, T2, T3, T4>(this CombinedResult<LinkFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkAttributes(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LinkFactory, T2, T3, T4, InnerLinkLinkAttributesFactory> WithLinkAttributes<T1, T2, T3, T4>(this CombinedResult<T1, LinkFactory, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkAttributes(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LinkFactory, T3, T4, InnerLinkLinkAttributesFactory> WithLinkAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, LinkFactory, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkAttributes(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LinkFactory, T4, InnerLinkLinkAttributesFactory> WithLinkAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LinkFactory, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkAttributes(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, LinkFactory, InnerLinkLinkAttributesFactory> WithLinkAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LinkFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkAttributes(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<LinkFactory, T1, InnerLinkLinkLogSettingsFactory> WithLinkLogSettings<T1>(this CombinedResult<LinkFactory, T1> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LinkFactory, InnerLinkLinkLogSettingsFactory> WithLinkLogSettings<T1>(this CombinedResult<T1, LinkFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<LinkFactory, T1, T2, InnerLinkLinkLogSettingsFactory> WithLinkLogSettings<T1, T2>(this CombinedResult<LinkFactory, T1, T2> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LinkFactory, T2, InnerLinkLinkLogSettingsFactory> WithLinkLogSettings<T1, T2>(this CombinedResult<T1, LinkFactory, T2> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LinkFactory, InnerLinkLinkLogSettingsFactory> WithLinkLogSettings<T1, T2>(this CombinedResult<T1, T2, LinkFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<LinkFactory, T1, T2, T3, InnerLinkLinkLogSettingsFactory> WithLinkLogSettings<T1, T2, T3>(this CombinedResult<LinkFactory, T1, T2, T3> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LinkFactory, T2, T3, InnerLinkLinkLogSettingsFactory> WithLinkLogSettings<T1, T2, T3>(this CombinedResult<T1, LinkFactory, T2, T3> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LinkFactory, T3, InnerLinkLinkLogSettingsFactory> WithLinkLogSettings<T1, T2, T3>(this CombinedResult<T1, T2, LinkFactory, T3> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LinkFactory, InnerLinkLinkLogSettingsFactory> WithLinkLogSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, LinkFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<LinkFactory, T1, T2, T3, T4, InnerLinkLinkLogSettingsFactory> WithLinkLogSettings<T1, T2, T3, T4>(this CombinedResult<LinkFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LinkFactory, T2, T3, T4, InnerLinkLinkLogSettingsFactory> WithLinkLogSettings<T1, T2, T3, T4>(this CombinedResult<T1, LinkFactory, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LinkFactory, T3, T4, InnerLinkLinkLogSettingsFactory> WithLinkLogSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, LinkFactory, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LinkFactory, T4, InnerLinkLinkLogSettingsFactory> WithLinkLogSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LinkFactory, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, LinkFactory, InnerLinkLinkLogSettingsFactory> WithLinkLogSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LinkFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkLogSettings(combinedResult.T5, subFactoryAction).T2);
}
