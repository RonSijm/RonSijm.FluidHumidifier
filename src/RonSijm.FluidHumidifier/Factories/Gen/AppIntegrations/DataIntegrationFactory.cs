// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppIntegrations;

public class DataIntegrationFactory(string resourceName = null, Action<Humidifier.AppIntegrations.DataIntegration> factoryAction = null) : ResourceFactory<Humidifier.AppIntegrations.DataIntegration>(resourceName)
{

    internal InnerDataIntegrationScheduleConfigFactory ScheduleConfigFactory { get; set; }

    internal InnerDataIntegrationFileConfigurationFactory FileConfigurationFactory { get; set; }

    protected override Humidifier.AppIntegrations.DataIntegration Create()
    {
        var dataIntegrationResult = CreateDataIntegration();
        factoryAction?.Invoke(dataIntegrationResult);

        return dataIntegrationResult;
    }

    private Humidifier.AppIntegrations.DataIntegration CreateDataIntegration()
    {
        var dataIntegrationResult = new Humidifier.AppIntegrations.DataIntegration
        {
            GivenName = InputResourceName,
        };

        return dataIntegrationResult;
    }
    public override void CreateChildren(Humidifier.AppIntegrations.DataIntegration result)
    {
        base.CreateChildren(result);

        result.ScheduleConfig ??= ScheduleConfigFactory?.Build();
        result.FileConfiguration ??= FileConfigurationFactory?.Build();
    }

} // End Of Class

public static class DataIntegrationFactoryExtensions
{
    public static CombinedResult<DataIntegrationFactory, InnerDataIntegrationScheduleConfigFactory> WithScheduleConfig(this DataIntegrationFactory parentFactory, Action<Humidifier.AppIntegrations.DataIntegrationTypes.ScheduleConfig> subFactoryAction = null)
    {
        parentFactory.ScheduleConfigFactory = new InnerDataIntegrationScheduleConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScheduleConfigFactory);
    }

    public static CombinedResult<DataIntegrationFactory, InnerDataIntegrationFileConfigurationFactory> WithFileConfiguration(this DataIntegrationFactory parentFactory, Action<Humidifier.AppIntegrations.DataIntegrationTypes.FileConfiguration> subFactoryAction = null)
    {
        parentFactory.FileConfigurationFactory = new InnerDataIntegrationFileConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FileConfigurationFactory);
    }

    public static CombinedResult<DataIntegrationFactory, T1, InnerDataIntegrationScheduleConfigFactory> WithScheduleConfig<T1>(this CombinedResult<DataIntegrationFactory, T1> combinedResult, Action<Humidifier.AppIntegrations.DataIntegrationTypes.ScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithScheduleConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataIntegrationFactory, InnerDataIntegrationScheduleConfigFactory> WithScheduleConfig<T1>(this CombinedResult<T1, DataIntegrationFactory> combinedResult, Action<Humidifier.AppIntegrations.DataIntegrationTypes.ScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithScheduleConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DataIntegrationFactory, T1, T2, InnerDataIntegrationScheduleConfigFactory> WithScheduleConfig<T1, T2>(this CombinedResult<DataIntegrationFactory, T1, T2> combinedResult, Action<Humidifier.AppIntegrations.DataIntegrationTypes.ScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScheduleConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataIntegrationFactory, T2, InnerDataIntegrationScheduleConfigFactory> WithScheduleConfig<T1, T2>(this CombinedResult<T1, DataIntegrationFactory, T2> combinedResult, Action<Humidifier.AppIntegrations.DataIntegrationTypes.ScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScheduleConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataIntegrationFactory, InnerDataIntegrationScheduleConfigFactory> WithScheduleConfig<T1, T2>(this CombinedResult<T1, T2, DataIntegrationFactory> combinedResult, Action<Humidifier.AppIntegrations.DataIntegrationTypes.ScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScheduleConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DataIntegrationFactory, T1, T2, T3, InnerDataIntegrationScheduleConfigFactory> WithScheduleConfig<T1, T2, T3>(this CombinedResult<DataIntegrationFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppIntegrations.DataIntegrationTypes.ScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataIntegrationFactory, T2, T3, InnerDataIntegrationScheduleConfigFactory> WithScheduleConfig<T1, T2, T3>(this CombinedResult<T1, DataIntegrationFactory, T2, T3> combinedResult, Action<Humidifier.AppIntegrations.DataIntegrationTypes.ScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataIntegrationFactory, T3, InnerDataIntegrationScheduleConfigFactory> WithScheduleConfig<T1, T2, T3>(this CombinedResult<T1, T2, DataIntegrationFactory, T3> combinedResult, Action<Humidifier.AppIntegrations.DataIntegrationTypes.ScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataIntegrationFactory, InnerDataIntegrationScheduleConfigFactory> WithScheduleConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, DataIntegrationFactory> combinedResult, Action<Humidifier.AppIntegrations.DataIntegrationTypes.ScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DataIntegrationFactory, T1, T2, T3, T4, InnerDataIntegrationScheduleConfigFactory> WithScheduleConfig<T1, T2, T3, T4>(this CombinedResult<DataIntegrationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppIntegrations.DataIntegrationTypes.ScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataIntegrationFactory, T2, T3, T4, InnerDataIntegrationScheduleConfigFactory> WithScheduleConfig<T1, T2, T3, T4>(this CombinedResult<T1, DataIntegrationFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppIntegrations.DataIntegrationTypes.ScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataIntegrationFactory, T3, T4, InnerDataIntegrationScheduleConfigFactory> WithScheduleConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, DataIntegrationFactory, T3, T4> combinedResult, Action<Humidifier.AppIntegrations.DataIntegrationTypes.ScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataIntegrationFactory, T4, InnerDataIntegrationScheduleConfigFactory> WithScheduleConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DataIntegrationFactory, T4> combinedResult, Action<Humidifier.AppIntegrations.DataIntegrationTypes.ScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DataIntegrationFactory, InnerDataIntegrationScheduleConfigFactory> WithScheduleConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DataIntegrationFactory> combinedResult, Action<Humidifier.AppIntegrations.DataIntegrationTypes.ScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<DataIntegrationFactory, T1, InnerDataIntegrationFileConfigurationFactory> WithFileConfiguration<T1>(this CombinedResult<DataIntegrationFactory, T1> combinedResult, Action<Humidifier.AppIntegrations.DataIntegrationTypes.FileConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithFileConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataIntegrationFactory, InnerDataIntegrationFileConfigurationFactory> WithFileConfiguration<T1>(this CombinedResult<T1, DataIntegrationFactory> combinedResult, Action<Humidifier.AppIntegrations.DataIntegrationTypes.FileConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithFileConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DataIntegrationFactory, T1, T2, InnerDataIntegrationFileConfigurationFactory> WithFileConfiguration<T1, T2>(this CombinedResult<DataIntegrationFactory, T1, T2> combinedResult, Action<Humidifier.AppIntegrations.DataIntegrationTypes.FileConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFileConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataIntegrationFactory, T2, InnerDataIntegrationFileConfigurationFactory> WithFileConfiguration<T1, T2>(this CombinedResult<T1, DataIntegrationFactory, T2> combinedResult, Action<Humidifier.AppIntegrations.DataIntegrationTypes.FileConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFileConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataIntegrationFactory, InnerDataIntegrationFileConfigurationFactory> WithFileConfiguration<T1, T2>(this CombinedResult<T1, T2, DataIntegrationFactory> combinedResult, Action<Humidifier.AppIntegrations.DataIntegrationTypes.FileConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFileConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DataIntegrationFactory, T1, T2, T3, InnerDataIntegrationFileConfigurationFactory> WithFileConfiguration<T1, T2, T3>(this CombinedResult<DataIntegrationFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppIntegrations.DataIntegrationTypes.FileConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFileConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataIntegrationFactory, T2, T3, InnerDataIntegrationFileConfigurationFactory> WithFileConfiguration<T1, T2, T3>(this CombinedResult<T1, DataIntegrationFactory, T2, T3> combinedResult, Action<Humidifier.AppIntegrations.DataIntegrationTypes.FileConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFileConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataIntegrationFactory, T3, InnerDataIntegrationFileConfigurationFactory> WithFileConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, DataIntegrationFactory, T3> combinedResult, Action<Humidifier.AppIntegrations.DataIntegrationTypes.FileConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFileConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataIntegrationFactory, InnerDataIntegrationFileConfigurationFactory> WithFileConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, DataIntegrationFactory> combinedResult, Action<Humidifier.AppIntegrations.DataIntegrationTypes.FileConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFileConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DataIntegrationFactory, T1, T2, T3, T4, InnerDataIntegrationFileConfigurationFactory> WithFileConfiguration<T1, T2, T3, T4>(this CombinedResult<DataIntegrationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppIntegrations.DataIntegrationTypes.FileConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataIntegrationFactory, T2, T3, T4, InnerDataIntegrationFileConfigurationFactory> WithFileConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, DataIntegrationFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppIntegrations.DataIntegrationTypes.FileConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataIntegrationFactory, T3, T4, InnerDataIntegrationFileConfigurationFactory> WithFileConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, DataIntegrationFactory, T3, T4> combinedResult, Action<Humidifier.AppIntegrations.DataIntegrationTypes.FileConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataIntegrationFactory, T4, InnerDataIntegrationFileConfigurationFactory> WithFileConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DataIntegrationFactory, T4> combinedResult, Action<Humidifier.AppIntegrations.DataIntegrationTypes.FileConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DataIntegrationFactory, InnerDataIntegrationFileConfigurationFactory> WithFileConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DataIntegrationFactory> combinedResult, Action<Humidifier.AppIntegrations.DataIntegrationTypes.FileConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileConfiguration(combinedResult.T5, subFactoryAction));
}
