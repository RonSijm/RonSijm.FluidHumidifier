// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.M2;

public class EnvironmentFactory(string resourceName = null, Action<Humidifier.M2.Environment> factoryAction = null) : ResourceFactory<Humidifier.M2.Environment>(resourceName)
{

    internal List<InnerEnvironmentStorageConfigurationFactory> StorageConfigurationsFactories { get; set; } = [];

    internal InnerEnvironmentHighAvailabilityConfigFactory HighAvailabilityConfigFactory { get; set; }

    protected override Humidifier.M2.Environment Create()
    {
        var environmentResult = CreateEnvironment();
        factoryAction?.Invoke(environmentResult);

        return environmentResult;
    }

    private Humidifier.M2.Environment CreateEnvironment()
    {
        var environmentResult = new Humidifier.M2.Environment
        {
            GivenName = InputResourceName,
        };

        return environmentResult;
    }
    public override void CreateChildren(Humidifier.M2.Environment result)
    {
        base.CreateChildren(result);

        result.StorageConfigurations = StorageConfigurationsFactories.Any() ? StorageConfigurationsFactories.Select(x => x.Build()).ToList() : null;
        result.HighAvailabilityConfig ??= HighAvailabilityConfigFactory?.Build();
    }

} // End Of Class

public static class EnvironmentFactoryExtensions
{
    public static CombinedResult<EnvironmentFactory, InnerEnvironmentStorageConfigurationFactory> WithStorageConfigurations(this EnvironmentFactory parentFactory, Action<Humidifier.M2.EnvironmentTypes.StorageConfiguration> subFactoryAction = null)
    {
        var factory = new InnerEnvironmentStorageConfigurationFactory(subFactoryAction);
        parentFactory.StorageConfigurationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<EnvironmentFactory, InnerEnvironmentHighAvailabilityConfigFactory> WithHighAvailabilityConfig(this EnvironmentFactory parentFactory, Action<Humidifier.M2.EnvironmentTypes.HighAvailabilityConfig> subFactoryAction = null)
    {
        parentFactory.HighAvailabilityConfigFactory = new InnerEnvironmentHighAvailabilityConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HighAvailabilityConfigFactory);
    }

    public static CombinedResult<EnvironmentFactory, T1, InnerEnvironmentStorageConfigurationFactory> WithStorageConfigurations<T1>(this CombinedResult<EnvironmentFactory, T1> combinedResult, Action<Humidifier.M2.EnvironmentTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithStorageConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, InnerEnvironmentStorageConfigurationFactory> WithStorageConfigurations<T1>(this CombinedResult<T1, EnvironmentFactory> combinedResult, Action<Humidifier.M2.EnvironmentTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithStorageConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EnvironmentFactory, T1, T2, InnerEnvironmentStorageConfigurationFactory> WithStorageConfigurations<T1, T2>(this CombinedResult<EnvironmentFactory, T1, T2> combinedResult, Action<Humidifier.M2.EnvironmentTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, T2, InnerEnvironmentStorageConfigurationFactory> WithStorageConfigurations<T1, T2>(this CombinedResult<T1, EnvironmentFactory, T2> combinedResult, Action<Humidifier.M2.EnvironmentTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentFactory, InnerEnvironmentStorageConfigurationFactory> WithStorageConfigurations<T1, T2>(this CombinedResult<T1, T2, EnvironmentFactory> combinedResult, Action<Humidifier.M2.EnvironmentTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EnvironmentFactory, T1, T2, T3, InnerEnvironmentStorageConfigurationFactory> WithStorageConfigurations<T1, T2, T3>(this CombinedResult<EnvironmentFactory, T1, T2, T3> combinedResult, Action<Humidifier.M2.EnvironmentTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, T2, T3, InnerEnvironmentStorageConfigurationFactory> WithStorageConfigurations<T1, T2, T3>(this CombinedResult<T1, EnvironmentFactory, T2, T3> combinedResult, Action<Humidifier.M2.EnvironmentTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentFactory, T3, InnerEnvironmentStorageConfigurationFactory> WithStorageConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, EnvironmentFactory, T3> combinedResult, Action<Humidifier.M2.EnvironmentTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EnvironmentFactory, InnerEnvironmentStorageConfigurationFactory> WithStorageConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, T3, EnvironmentFactory> combinedResult, Action<Humidifier.M2.EnvironmentTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageConfigurations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EnvironmentFactory, T1, T2, T3, T4, InnerEnvironmentStorageConfigurationFactory> WithStorageConfigurations<T1, T2, T3, T4>(this CombinedResult<EnvironmentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.M2.EnvironmentTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, T2, T3, T4, InnerEnvironmentStorageConfigurationFactory> WithStorageConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, EnvironmentFactory, T2, T3, T4> combinedResult, Action<Humidifier.M2.EnvironmentTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentFactory, T3, T4, InnerEnvironmentStorageConfigurationFactory> WithStorageConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, EnvironmentFactory, T3, T4> combinedResult, Action<Humidifier.M2.EnvironmentTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EnvironmentFactory, T4, InnerEnvironmentStorageConfigurationFactory> WithStorageConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EnvironmentFactory, T4> combinedResult, Action<Humidifier.M2.EnvironmentTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageConfigurations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EnvironmentFactory, InnerEnvironmentStorageConfigurationFactory> WithStorageConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EnvironmentFactory> combinedResult, Action<Humidifier.M2.EnvironmentTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageConfigurations(combinedResult.T5, subFactoryAction));
    public static CombinedResult<EnvironmentFactory, T1, InnerEnvironmentHighAvailabilityConfigFactory> WithHighAvailabilityConfig<T1>(this CombinedResult<EnvironmentFactory, T1> combinedResult, Action<Humidifier.M2.EnvironmentTypes.HighAvailabilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithHighAvailabilityConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, InnerEnvironmentHighAvailabilityConfigFactory> WithHighAvailabilityConfig<T1>(this CombinedResult<T1, EnvironmentFactory> combinedResult, Action<Humidifier.M2.EnvironmentTypes.HighAvailabilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithHighAvailabilityConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EnvironmentFactory, T1, T2, InnerEnvironmentHighAvailabilityConfigFactory> WithHighAvailabilityConfig<T1, T2>(this CombinedResult<EnvironmentFactory, T1, T2> combinedResult, Action<Humidifier.M2.EnvironmentTypes.HighAvailabilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHighAvailabilityConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, T2, InnerEnvironmentHighAvailabilityConfigFactory> WithHighAvailabilityConfig<T1, T2>(this CombinedResult<T1, EnvironmentFactory, T2> combinedResult, Action<Humidifier.M2.EnvironmentTypes.HighAvailabilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHighAvailabilityConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentFactory, InnerEnvironmentHighAvailabilityConfigFactory> WithHighAvailabilityConfig<T1, T2>(this CombinedResult<T1, T2, EnvironmentFactory> combinedResult, Action<Humidifier.M2.EnvironmentTypes.HighAvailabilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHighAvailabilityConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EnvironmentFactory, T1, T2, T3, InnerEnvironmentHighAvailabilityConfigFactory> WithHighAvailabilityConfig<T1, T2, T3>(this CombinedResult<EnvironmentFactory, T1, T2, T3> combinedResult, Action<Humidifier.M2.EnvironmentTypes.HighAvailabilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHighAvailabilityConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, T2, T3, InnerEnvironmentHighAvailabilityConfigFactory> WithHighAvailabilityConfig<T1, T2, T3>(this CombinedResult<T1, EnvironmentFactory, T2, T3> combinedResult, Action<Humidifier.M2.EnvironmentTypes.HighAvailabilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHighAvailabilityConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentFactory, T3, InnerEnvironmentHighAvailabilityConfigFactory> WithHighAvailabilityConfig<T1, T2, T3>(this CombinedResult<T1, T2, EnvironmentFactory, T3> combinedResult, Action<Humidifier.M2.EnvironmentTypes.HighAvailabilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHighAvailabilityConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EnvironmentFactory, InnerEnvironmentHighAvailabilityConfigFactory> WithHighAvailabilityConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, EnvironmentFactory> combinedResult, Action<Humidifier.M2.EnvironmentTypes.HighAvailabilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHighAvailabilityConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EnvironmentFactory, T1, T2, T3, T4, InnerEnvironmentHighAvailabilityConfigFactory> WithHighAvailabilityConfig<T1, T2, T3, T4>(this CombinedResult<EnvironmentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.M2.EnvironmentTypes.HighAvailabilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHighAvailabilityConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, T2, T3, T4, InnerEnvironmentHighAvailabilityConfigFactory> WithHighAvailabilityConfig<T1, T2, T3, T4>(this CombinedResult<T1, EnvironmentFactory, T2, T3, T4> combinedResult, Action<Humidifier.M2.EnvironmentTypes.HighAvailabilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHighAvailabilityConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentFactory, T3, T4, InnerEnvironmentHighAvailabilityConfigFactory> WithHighAvailabilityConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, EnvironmentFactory, T3, T4> combinedResult, Action<Humidifier.M2.EnvironmentTypes.HighAvailabilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHighAvailabilityConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EnvironmentFactory, T4, InnerEnvironmentHighAvailabilityConfigFactory> WithHighAvailabilityConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EnvironmentFactory, T4> combinedResult, Action<Humidifier.M2.EnvironmentTypes.HighAvailabilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHighAvailabilityConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EnvironmentFactory, InnerEnvironmentHighAvailabilityConfigFactory> WithHighAvailabilityConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EnvironmentFactory> combinedResult, Action<Humidifier.M2.EnvironmentTypes.HighAvailabilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHighAvailabilityConfig(combinedResult.T5, subFactoryAction));
}
