// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class ThemeFactory(string resourceName = null, Action<Humidifier.QuickSight.Theme> factoryAction = null) : ResourceFactory<Humidifier.QuickSight.Theme>(resourceName)
{

    internal List<InnerThemeResourcePermissionFactory> PermissionsFactories { get; set; } = [];

    internal InnerThemeThemeConfigurationFactory ConfigurationFactory { get; set; }

    protected override Humidifier.QuickSight.Theme Create()
    {
        var themeResult = CreateTheme();
        factoryAction?.Invoke(themeResult);

        return themeResult;
    }

    private Humidifier.QuickSight.Theme CreateTheme()
    {
        var themeResult = new Humidifier.QuickSight.Theme
        {
            GivenName = InputResourceName,
        };

        return themeResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.Theme result)
    {
        base.CreateChildren(result);

        result.Permissions = PermissionsFactories.Any() ? PermissionsFactories.Select(x => x.Build()).ToList() : null;
        result.Configuration ??= ConfigurationFactory?.Build();
    }

} // End Of Class

public static class ThemeFactoryExtensions
{
    public static CombinedResult<ThemeFactory, InnerThemeResourcePermissionFactory> WithPermissions(this ThemeFactory parentFactory, Action<Humidifier.QuickSight.ThemeTypes.ResourcePermission> subFactoryAction = null)
    {
        var factory = new InnerThemeResourcePermissionFactory(subFactoryAction);
        parentFactory.PermissionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ThemeFactory, InnerThemeThemeConfigurationFactory> WithConfiguration(this ThemeFactory parentFactory, Action<Humidifier.QuickSight.ThemeTypes.ThemeConfiguration> subFactoryAction = null)
    {
        parentFactory.ConfigurationFactory = new InnerThemeThemeConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigurationFactory);
    }

    public static CombinedResult<ThemeFactory, T1, InnerThemeResourcePermissionFactory> WithPermissions<T1>(this CombinedResult<ThemeFactory, T1> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, WithPermissions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ThemeFactory, InnerThemeResourcePermissionFactory> WithPermissions<T1>(this CombinedResult<T1, ThemeFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, WithPermissions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ThemeFactory, T1, T2, InnerThemeResourcePermissionFactory> WithPermissions<T1, T2>(this CombinedResult<ThemeFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ThemeFactory, T2, InnerThemeResourcePermissionFactory> WithPermissions<T1, T2>(this CombinedResult<T1, ThemeFactory, T2> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ThemeFactory, InnerThemeResourcePermissionFactory> WithPermissions<T1, T2>(this CombinedResult<T1, T2, ThemeFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ThemeFactory, T1, T2, T3, InnerThemeResourcePermissionFactory> WithPermissions<T1, T2, T3>(this CombinedResult<ThemeFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ThemeFactory, T2, T3, InnerThemeResourcePermissionFactory> WithPermissions<T1, T2, T3>(this CombinedResult<T1, ThemeFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ThemeFactory, T3, InnerThemeResourcePermissionFactory> WithPermissions<T1, T2, T3>(this CombinedResult<T1, T2, ThemeFactory, T3> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ThemeFactory, InnerThemeResourcePermissionFactory> WithPermissions<T1, T2, T3>(this CombinedResult<T1, T2, T3, ThemeFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ThemeFactory, T1, T2, T3, T4, InnerThemeResourcePermissionFactory> WithPermissions<T1, T2, T3, T4>(this CombinedResult<ThemeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ThemeFactory, T2, T3, T4, InnerThemeResourcePermissionFactory> WithPermissions<T1, T2, T3, T4>(this CombinedResult<T1, ThemeFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ThemeFactory, T3, T4, InnerThemeResourcePermissionFactory> WithPermissions<T1, T2, T3, T4>(this CombinedResult<T1, T2, ThemeFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ThemeFactory, T4, InnerThemeResourcePermissionFactory> WithPermissions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ThemeFactory, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ThemeFactory, InnerThemeResourcePermissionFactory> WithPermissions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ThemeFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.ResourcePermission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ThemeFactory, T1, InnerThemeThemeConfigurationFactory> WithConfiguration<T1>(this CombinedResult<ThemeFactory, T1> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.ThemeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ThemeFactory, InnerThemeThemeConfigurationFactory> WithConfiguration<T1>(this CombinedResult<T1, ThemeFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.ThemeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ThemeFactory, T1, T2, InnerThemeThemeConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<ThemeFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.ThemeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ThemeFactory, T2, InnerThemeThemeConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, ThemeFactory, T2> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.ThemeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ThemeFactory, InnerThemeThemeConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, T2, ThemeFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.ThemeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ThemeFactory, T1, T2, T3, InnerThemeThemeConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<ThemeFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.ThemeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ThemeFactory, T2, T3, InnerThemeThemeConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, ThemeFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.ThemeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ThemeFactory, T3, InnerThemeThemeConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, ThemeFactory, T3> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.ThemeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ThemeFactory, InnerThemeThemeConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, ThemeFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.ThemeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ThemeFactory, T1, T2, T3, T4, InnerThemeThemeConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<ThemeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.ThemeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ThemeFactory, T2, T3, T4, InnerThemeThemeConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, ThemeFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.ThemeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ThemeFactory, T3, T4, InnerThemeThemeConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, ThemeFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.ThemeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ThemeFactory, T4, InnerThemeThemeConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ThemeFactory, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.ThemeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ThemeFactory, InnerThemeThemeConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ThemeFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.ThemeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T5, subFactoryAction));
}
