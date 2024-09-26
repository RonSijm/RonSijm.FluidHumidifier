// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class ConfigurationFactory(string resourceName = null, Action<Humidifier.MSK.Configuration> factoryAction = null) : ResourceFactory<Humidifier.MSK.Configuration>(resourceName)
{

    internal InnerConfigurationLatestRevisionFactory LatestRevisionFactory { get; set; }

    protected override Humidifier.MSK.Configuration Create()
    {
        var configurationResult = CreateConfiguration();
        factoryAction?.Invoke(configurationResult);

        return configurationResult;
    }

    private Humidifier.MSK.Configuration CreateConfiguration()
    {
        var configurationResult = new Humidifier.MSK.Configuration
        {
            GivenName = InputResourceName,
        };

        return configurationResult;
    }
    public override void CreateChildren(Humidifier.MSK.Configuration result)
    {
        base.CreateChildren(result);

        result.LatestRevision ??= LatestRevisionFactory?.Build();
    }

} // End Of Class

public static class ConfigurationFactoryExtensions
{
    public static CombinedResult<ConfigurationFactory, InnerConfigurationLatestRevisionFactory> WithLatestRevision(this ConfigurationFactory parentFactory, Action<Humidifier.MSK.ConfigurationTypes.LatestRevision> subFactoryAction = null)
    {
        parentFactory.LatestRevisionFactory = new InnerConfigurationLatestRevisionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LatestRevisionFactory);
    }

    public static CombinedResult<ConfigurationFactory, T1, InnerConfigurationLatestRevisionFactory> WithLatestRevision<T1>(this CombinedResult<ConfigurationFactory, T1> combinedResult, Action<Humidifier.MSK.ConfigurationTypes.LatestRevision> subFactoryAction = null) => new (combinedResult, combinedResult, WithLatestRevision(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationFactory, InnerConfigurationLatestRevisionFactory> WithLatestRevision<T1>(this CombinedResult<T1, ConfigurationFactory> combinedResult, Action<Humidifier.MSK.ConfigurationTypes.LatestRevision> subFactoryAction = null) => new (combinedResult, combinedResult, WithLatestRevision(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ConfigurationFactory, T1, T2, InnerConfigurationLatestRevisionFactory> WithLatestRevision<T1, T2>(this CombinedResult<ConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ConfigurationTypes.LatestRevision> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLatestRevision(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationFactory, T2, InnerConfigurationLatestRevisionFactory> WithLatestRevision<T1, T2>(this CombinedResult<T1, ConfigurationFactory, T2> combinedResult, Action<Humidifier.MSK.ConfigurationTypes.LatestRevision> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLatestRevision(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigurationFactory, InnerConfigurationLatestRevisionFactory> WithLatestRevision<T1, T2>(this CombinedResult<T1, T2, ConfigurationFactory> combinedResult, Action<Humidifier.MSK.ConfigurationTypes.LatestRevision> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLatestRevision(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ConfigurationFactory, T1, T2, T3, InnerConfigurationLatestRevisionFactory> WithLatestRevision<T1, T2, T3>(this CombinedResult<ConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ConfigurationTypes.LatestRevision> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLatestRevision(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationFactory, T2, T3, InnerConfigurationLatestRevisionFactory> WithLatestRevision<T1, T2, T3>(this CombinedResult<T1, ConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ConfigurationTypes.LatestRevision> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLatestRevision(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigurationFactory, T3, InnerConfigurationLatestRevisionFactory> WithLatestRevision<T1, T2, T3>(this CombinedResult<T1, T2, ConfigurationFactory, T3> combinedResult, Action<Humidifier.MSK.ConfigurationTypes.LatestRevision> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLatestRevision(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfigurationFactory, InnerConfigurationLatestRevisionFactory> WithLatestRevision<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConfigurationFactory> combinedResult, Action<Humidifier.MSK.ConfigurationTypes.LatestRevision> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLatestRevision(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ConfigurationFactory, T1, T2, T3, T4, InnerConfigurationLatestRevisionFactory> WithLatestRevision<T1, T2, T3, T4>(this CombinedResult<ConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ConfigurationTypes.LatestRevision> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLatestRevision(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationFactory, T2, T3, T4, InnerConfigurationLatestRevisionFactory> WithLatestRevision<T1, T2, T3, T4>(this CombinedResult<T1, ConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ConfigurationTypes.LatestRevision> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLatestRevision(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigurationFactory, T3, T4, InnerConfigurationLatestRevisionFactory> WithLatestRevision<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ConfigurationTypes.LatestRevision> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLatestRevision(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfigurationFactory, T4, InnerConfigurationLatestRevisionFactory> WithLatestRevision<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConfigurationFactory, T4> combinedResult, Action<Humidifier.MSK.ConfigurationTypes.LatestRevision> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLatestRevision(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ConfigurationFactory, InnerConfigurationLatestRevisionFactory> WithLatestRevision<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConfigurationFactory> combinedResult, Action<Humidifier.MSK.ConfigurationTypes.LatestRevision> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLatestRevision(combinedResult.T5, subFactoryAction));
}
