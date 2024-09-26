// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class PluginFactory(string resourceName = null, Action<Humidifier.QBusiness.Plugin> factoryAction = null) : ResourceFactory<Humidifier.QBusiness.Plugin>(resourceName)
{

    internal InnerPluginCustomPluginConfigurationFactory CustomPluginConfigurationFactory { get; set; }

    internal InnerPluginPluginAuthConfigurationFactory AuthConfigurationFactory { get; set; }

    protected override Humidifier.QBusiness.Plugin Create()
    {
        var pluginResult = CreatePlugin();
        factoryAction?.Invoke(pluginResult);

        return pluginResult;
    }

    private Humidifier.QBusiness.Plugin CreatePlugin()
    {
        var pluginResult = new Humidifier.QBusiness.Plugin
        {
            GivenName = InputResourceName,
        };

        return pluginResult;
    }
    public override void CreateChildren(Humidifier.QBusiness.Plugin result)
    {
        base.CreateChildren(result);

        result.CustomPluginConfiguration ??= CustomPluginConfigurationFactory?.Build();
        result.AuthConfiguration ??= AuthConfigurationFactory?.Build();
    }

} // End Of Class

public static class PluginFactoryExtensions
{
    public static CombinedResult<PluginFactory, InnerPluginCustomPluginConfigurationFactory> WithCustomPluginConfiguration(this PluginFactory parentFactory, Action<Humidifier.QBusiness.PluginTypes.CustomPluginConfiguration> subFactoryAction = null)
    {
        parentFactory.CustomPluginConfigurationFactory = new InnerPluginCustomPluginConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CustomPluginConfigurationFactory);
    }

    public static CombinedResult<PluginFactory, InnerPluginPluginAuthConfigurationFactory> WithAuthConfiguration(this PluginFactory parentFactory, Action<Humidifier.QBusiness.PluginTypes.PluginAuthConfiguration> subFactoryAction = null)
    {
        parentFactory.AuthConfigurationFactory = new InnerPluginPluginAuthConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AuthConfigurationFactory);
    }

    public static CombinedResult<PluginFactory, T1, InnerPluginCustomPluginConfigurationFactory> WithCustomPluginConfiguration<T1>(this CombinedResult<PluginFactory, T1> combinedResult, Action<Humidifier.QBusiness.PluginTypes.CustomPluginConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomPluginConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PluginFactory, InnerPluginCustomPluginConfigurationFactory> WithCustomPluginConfiguration<T1>(this CombinedResult<T1, PluginFactory> combinedResult, Action<Humidifier.QBusiness.PluginTypes.CustomPluginConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomPluginConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PluginFactory, T1, T2, InnerPluginCustomPluginConfigurationFactory> WithCustomPluginConfiguration<T1, T2>(this CombinedResult<PluginFactory, T1, T2> combinedResult, Action<Humidifier.QBusiness.PluginTypes.CustomPluginConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomPluginConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PluginFactory, T2, InnerPluginCustomPluginConfigurationFactory> WithCustomPluginConfiguration<T1, T2>(this CombinedResult<T1, PluginFactory, T2> combinedResult, Action<Humidifier.QBusiness.PluginTypes.CustomPluginConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomPluginConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PluginFactory, InnerPluginCustomPluginConfigurationFactory> WithCustomPluginConfiguration<T1, T2>(this CombinedResult<T1, T2, PluginFactory> combinedResult, Action<Humidifier.QBusiness.PluginTypes.CustomPluginConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomPluginConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PluginFactory, T1, T2, T3, InnerPluginCustomPluginConfigurationFactory> WithCustomPluginConfiguration<T1, T2, T3>(this CombinedResult<PluginFactory, T1, T2, T3> combinedResult, Action<Humidifier.QBusiness.PluginTypes.CustomPluginConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomPluginConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PluginFactory, T2, T3, InnerPluginCustomPluginConfigurationFactory> WithCustomPluginConfiguration<T1, T2, T3>(this CombinedResult<T1, PluginFactory, T2, T3> combinedResult, Action<Humidifier.QBusiness.PluginTypes.CustomPluginConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomPluginConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PluginFactory, T3, InnerPluginCustomPluginConfigurationFactory> WithCustomPluginConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, PluginFactory, T3> combinedResult, Action<Humidifier.QBusiness.PluginTypes.CustomPluginConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomPluginConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PluginFactory, InnerPluginCustomPluginConfigurationFactory> WithCustomPluginConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, PluginFactory> combinedResult, Action<Humidifier.QBusiness.PluginTypes.CustomPluginConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomPluginConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PluginFactory, T1, T2, T3, T4, InnerPluginCustomPluginConfigurationFactory> WithCustomPluginConfiguration<T1, T2, T3, T4>(this CombinedResult<PluginFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.PluginTypes.CustomPluginConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomPluginConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PluginFactory, T2, T3, T4, InnerPluginCustomPluginConfigurationFactory> WithCustomPluginConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, PluginFactory, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.PluginTypes.CustomPluginConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomPluginConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PluginFactory, T3, T4, InnerPluginCustomPluginConfigurationFactory> WithCustomPluginConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, PluginFactory, T3, T4> combinedResult, Action<Humidifier.QBusiness.PluginTypes.CustomPluginConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomPluginConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PluginFactory, T4, InnerPluginCustomPluginConfigurationFactory> WithCustomPluginConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PluginFactory, T4> combinedResult, Action<Humidifier.QBusiness.PluginTypes.CustomPluginConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomPluginConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PluginFactory, InnerPluginCustomPluginConfigurationFactory> WithCustomPluginConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PluginFactory> combinedResult, Action<Humidifier.QBusiness.PluginTypes.CustomPluginConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomPluginConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<PluginFactory, T1, InnerPluginPluginAuthConfigurationFactory> WithAuthConfiguration<T1>(this CombinedResult<PluginFactory, T1> combinedResult, Action<Humidifier.QBusiness.PluginTypes.PluginAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PluginFactory, InnerPluginPluginAuthConfigurationFactory> WithAuthConfiguration<T1>(this CombinedResult<T1, PluginFactory> combinedResult, Action<Humidifier.QBusiness.PluginTypes.PluginAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PluginFactory, T1, T2, InnerPluginPluginAuthConfigurationFactory> WithAuthConfiguration<T1, T2>(this CombinedResult<PluginFactory, T1, T2> combinedResult, Action<Humidifier.QBusiness.PluginTypes.PluginAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PluginFactory, T2, InnerPluginPluginAuthConfigurationFactory> WithAuthConfiguration<T1, T2>(this CombinedResult<T1, PluginFactory, T2> combinedResult, Action<Humidifier.QBusiness.PluginTypes.PluginAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PluginFactory, InnerPluginPluginAuthConfigurationFactory> WithAuthConfiguration<T1, T2>(this CombinedResult<T1, T2, PluginFactory> combinedResult, Action<Humidifier.QBusiness.PluginTypes.PluginAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PluginFactory, T1, T2, T3, InnerPluginPluginAuthConfigurationFactory> WithAuthConfiguration<T1, T2, T3>(this CombinedResult<PluginFactory, T1, T2, T3> combinedResult, Action<Humidifier.QBusiness.PluginTypes.PluginAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PluginFactory, T2, T3, InnerPluginPluginAuthConfigurationFactory> WithAuthConfiguration<T1, T2, T3>(this CombinedResult<T1, PluginFactory, T2, T3> combinedResult, Action<Humidifier.QBusiness.PluginTypes.PluginAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PluginFactory, T3, InnerPluginPluginAuthConfigurationFactory> WithAuthConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, PluginFactory, T3> combinedResult, Action<Humidifier.QBusiness.PluginTypes.PluginAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PluginFactory, InnerPluginPluginAuthConfigurationFactory> WithAuthConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, PluginFactory> combinedResult, Action<Humidifier.QBusiness.PluginTypes.PluginAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PluginFactory, T1, T2, T3, T4, InnerPluginPluginAuthConfigurationFactory> WithAuthConfiguration<T1, T2, T3, T4>(this CombinedResult<PluginFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.PluginTypes.PluginAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PluginFactory, T2, T3, T4, InnerPluginPluginAuthConfigurationFactory> WithAuthConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, PluginFactory, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.PluginTypes.PluginAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PluginFactory, T3, T4, InnerPluginPluginAuthConfigurationFactory> WithAuthConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, PluginFactory, T3, T4> combinedResult, Action<Humidifier.QBusiness.PluginTypes.PluginAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PluginFactory, T4, InnerPluginPluginAuthConfigurationFactory> WithAuthConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PluginFactory, T4> combinedResult, Action<Humidifier.QBusiness.PluginTypes.PluginAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PluginFactory, InnerPluginPluginAuthConfigurationFactory> WithAuthConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PluginFactory> combinedResult, Action<Humidifier.QBusiness.PluginTypes.PluginAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T5, subFactoryAction));
}
