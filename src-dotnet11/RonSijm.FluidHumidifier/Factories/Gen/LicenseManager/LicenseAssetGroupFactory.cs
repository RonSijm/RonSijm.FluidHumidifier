// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LicenseManager;

public class LicenseAssetGroupFactory(string resourceName = null, Action<Humidifier.LicenseManager.LicenseAssetGroup> factoryAction = null) : ResourceFactory<Humidifier.LicenseManager.LicenseAssetGroup>(resourceName)
{

    internal List<InnerLicenseAssetGroupLicenseAssetGroupConfigurationFactory> LicenseAssetGroupConfigurationsFactories { get; set; } = [];

    internal List<InnerLicenseAssetGroupLicenseAssetGroupPropertyFactory> PropertiesFactories { get; set; } = [];

    protected override Humidifier.LicenseManager.LicenseAssetGroup Create()
    {
        var licenseAssetGroupResult = CreateLicenseAssetGroup();
        factoryAction?.Invoke(licenseAssetGroupResult);

        return licenseAssetGroupResult;
    }

    private Humidifier.LicenseManager.LicenseAssetGroup CreateLicenseAssetGroup()
    {
        var licenseAssetGroupResult = new Humidifier.LicenseManager.LicenseAssetGroup
        {
            GivenName = InputResourceName,
        };

        return licenseAssetGroupResult;
    }
    public override void CreateChildren(Humidifier.LicenseManager.LicenseAssetGroup result)
    {
        base.CreateChildren(result);

        result.LicenseAssetGroupConfigurations = LicenseAssetGroupConfigurationsFactories.Any() ? LicenseAssetGroupConfigurationsFactories.Select(x => x.Build()).ToList() : null;
        result.Properties = PropertiesFactories.Any() ? PropertiesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class LicenseAssetGroupFactoryExtensions
{
    public static CombinedResult<LicenseAssetGroupFactory, InnerLicenseAssetGroupLicenseAssetGroupConfigurationFactory> WithLicenseAssetGroupConfigurations(this LicenseAssetGroupFactory parentFactory, Action<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupConfiguration> subFactoryAction = null)
    {
        var factory = new InnerLicenseAssetGroupLicenseAssetGroupConfigurationFactory(subFactoryAction);
        parentFactory.LicenseAssetGroupConfigurationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<LicenseAssetGroupFactory, InnerLicenseAssetGroupLicenseAssetGroupPropertyFactory> WithProperties(this LicenseAssetGroupFactory parentFactory, Action<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupProperty> subFactoryAction = null)
    {
        var factory = new InnerLicenseAssetGroupLicenseAssetGroupPropertyFactory(subFactoryAction);
        parentFactory.PropertiesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<LicenseAssetGroupFactory, T1, InnerLicenseAssetGroupLicenseAssetGroupConfigurationFactory> WithLicenseAssetGroupConfigurations<T1>(this CombinedResult<LicenseAssetGroupFactory, T1> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLicenseAssetGroupConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LicenseAssetGroupFactory, InnerLicenseAssetGroupLicenseAssetGroupConfigurationFactory> WithLicenseAssetGroupConfigurations<T1>(this CombinedResult<T1, LicenseAssetGroupFactory> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLicenseAssetGroupConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<LicenseAssetGroupFactory, T1, T2, InnerLicenseAssetGroupLicenseAssetGroupConfigurationFactory> WithLicenseAssetGroupConfigurations<T1, T2>(this CombinedResult<LicenseAssetGroupFactory, T1, T2> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLicenseAssetGroupConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LicenseAssetGroupFactory, T2, InnerLicenseAssetGroupLicenseAssetGroupConfigurationFactory> WithLicenseAssetGroupConfigurations<T1, T2>(this CombinedResult<T1, LicenseAssetGroupFactory, T2> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLicenseAssetGroupConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LicenseAssetGroupFactory, InnerLicenseAssetGroupLicenseAssetGroupConfigurationFactory> WithLicenseAssetGroupConfigurations<T1, T2>(this CombinedResult<T1, T2, LicenseAssetGroupFactory> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLicenseAssetGroupConfigurations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<LicenseAssetGroupFactory, T1, T2, T3, InnerLicenseAssetGroupLicenseAssetGroupConfigurationFactory> WithLicenseAssetGroupConfigurations<T1, T2, T3>(this CombinedResult<LicenseAssetGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLicenseAssetGroupConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LicenseAssetGroupFactory, T2, T3, InnerLicenseAssetGroupLicenseAssetGroupConfigurationFactory> WithLicenseAssetGroupConfigurations<T1, T2, T3>(this CombinedResult<T1, LicenseAssetGroupFactory, T2, T3> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLicenseAssetGroupConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LicenseAssetGroupFactory, T3, InnerLicenseAssetGroupLicenseAssetGroupConfigurationFactory> WithLicenseAssetGroupConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, LicenseAssetGroupFactory, T3> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLicenseAssetGroupConfigurations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LicenseAssetGroupFactory, InnerLicenseAssetGroupLicenseAssetGroupConfigurationFactory> WithLicenseAssetGroupConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, T3, LicenseAssetGroupFactory> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLicenseAssetGroupConfigurations(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<LicenseAssetGroupFactory, T1, T2, T3, T4, InnerLicenseAssetGroupLicenseAssetGroupConfigurationFactory> WithLicenseAssetGroupConfigurations<T1, T2, T3, T4>(this CombinedResult<LicenseAssetGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLicenseAssetGroupConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LicenseAssetGroupFactory, T2, T3, T4, InnerLicenseAssetGroupLicenseAssetGroupConfigurationFactory> WithLicenseAssetGroupConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, LicenseAssetGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLicenseAssetGroupConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LicenseAssetGroupFactory, T3, T4, InnerLicenseAssetGroupLicenseAssetGroupConfigurationFactory> WithLicenseAssetGroupConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, LicenseAssetGroupFactory, T3, T4> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLicenseAssetGroupConfigurations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LicenseAssetGroupFactory, T4, InnerLicenseAssetGroupLicenseAssetGroupConfigurationFactory> WithLicenseAssetGroupConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LicenseAssetGroupFactory, T4> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLicenseAssetGroupConfigurations(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, LicenseAssetGroupFactory, InnerLicenseAssetGroupLicenseAssetGroupConfigurationFactory> WithLicenseAssetGroupConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LicenseAssetGroupFactory> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLicenseAssetGroupConfigurations(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<LicenseAssetGroupFactory, T1, InnerLicenseAssetGroupLicenseAssetGroupPropertyFactory> WithProperties<T1>(this CombinedResult<LicenseAssetGroupFactory, T1> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupProperty> subFactoryAction = null) => new (combinedResult, combinedResult, WithProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LicenseAssetGroupFactory, InnerLicenseAssetGroupLicenseAssetGroupPropertyFactory> WithProperties<T1>(this CombinedResult<T1, LicenseAssetGroupFactory> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupProperty> subFactoryAction = null) => new (combinedResult, combinedResult, WithProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<LicenseAssetGroupFactory, T1, T2, InnerLicenseAssetGroupLicenseAssetGroupPropertyFactory> WithProperties<T1, T2>(this CombinedResult<LicenseAssetGroupFactory, T1, T2> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LicenseAssetGroupFactory, T2, InnerLicenseAssetGroupLicenseAssetGroupPropertyFactory> WithProperties<T1, T2>(this CombinedResult<T1, LicenseAssetGroupFactory, T2> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LicenseAssetGroupFactory, InnerLicenseAssetGroupLicenseAssetGroupPropertyFactory> WithProperties<T1, T2>(this CombinedResult<T1, T2, LicenseAssetGroupFactory> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<LicenseAssetGroupFactory, T1, T2, T3, InnerLicenseAssetGroupLicenseAssetGroupPropertyFactory> WithProperties<T1, T2, T3>(this CombinedResult<LicenseAssetGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LicenseAssetGroupFactory, T2, T3, InnerLicenseAssetGroupLicenseAssetGroupPropertyFactory> WithProperties<T1, T2, T3>(this CombinedResult<T1, LicenseAssetGroupFactory, T2, T3> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LicenseAssetGroupFactory, T3, InnerLicenseAssetGroupLicenseAssetGroupPropertyFactory> WithProperties<T1, T2, T3>(this CombinedResult<T1, T2, LicenseAssetGroupFactory, T3> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LicenseAssetGroupFactory, InnerLicenseAssetGroupLicenseAssetGroupPropertyFactory> WithProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, LicenseAssetGroupFactory> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<LicenseAssetGroupFactory, T1, T2, T3, T4, InnerLicenseAssetGroupLicenseAssetGroupPropertyFactory> WithProperties<T1, T2, T3, T4>(this CombinedResult<LicenseAssetGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LicenseAssetGroupFactory, T2, T3, T4, InnerLicenseAssetGroupLicenseAssetGroupPropertyFactory> WithProperties<T1, T2, T3, T4>(this CombinedResult<T1, LicenseAssetGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LicenseAssetGroupFactory, T3, T4, InnerLicenseAssetGroupLicenseAssetGroupPropertyFactory> WithProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, LicenseAssetGroupFactory, T3, T4> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LicenseAssetGroupFactory, T4, InnerLicenseAssetGroupLicenseAssetGroupPropertyFactory> WithProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LicenseAssetGroupFactory, T4> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, LicenseAssetGroupFactory, InnerLicenseAssetGroupLicenseAssetGroupPropertyFactory> WithProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LicenseAssetGroupFactory> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T5, subFactoryAction).T2);
}
