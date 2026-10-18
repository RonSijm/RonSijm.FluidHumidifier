// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRoomsML;

public class ConfiguredModelAlgorithmAssociationFactory(string resourceName = null, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociation> factoryAction = null) : ResourceFactory<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociation>(resourceName)
{

    internal InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory PrivacyConfigurationFactory { get; set; }

    protected override Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociation Create()
    {
        var configuredModelAlgorithmAssociationResult = CreateConfiguredModelAlgorithmAssociation();
        factoryAction?.Invoke(configuredModelAlgorithmAssociationResult);

        return configuredModelAlgorithmAssociationResult;
    }

    private Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociation CreateConfiguredModelAlgorithmAssociation()
    {
        var configuredModelAlgorithmAssociationResult = new Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociation
        {
            GivenName = InputResourceName,
        };

        return configuredModelAlgorithmAssociationResult;
    }
    public override void CreateChildren(Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociation result)
    {
        base.CreateChildren(result);

        result.PrivacyConfiguration ??= PrivacyConfigurationFactory?.Build();
    }

} // End Of Class

public static class ConfiguredModelAlgorithmAssociationFactoryExtensions
{
    public static CombinedResult<ConfiguredModelAlgorithmAssociationFactory, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory> WithPrivacyConfiguration(this ConfiguredModelAlgorithmAssociationFactory parentFactory, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfiguration> subFactoryAction = null)
    {
        parentFactory.PrivacyConfigurationFactory = new InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PrivacyConfigurationFactory);
    }

    public static CombinedResult<ConfiguredModelAlgorithmAssociationFactory, T1, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory> WithPrivacyConfiguration<T1>(this CombinedResult<ConfiguredModelAlgorithmAssociationFactory, T1> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrivacyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConfiguredModelAlgorithmAssociationFactory, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory> WithPrivacyConfiguration<T1>(this CombinedResult<T1, ConfiguredModelAlgorithmAssociationFactory> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrivacyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ConfiguredModelAlgorithmAssociationFactory, T1, T2, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory> WithPrivacyConfiguration<T1, T2>(this CombinedResult<ConfiguredModelAlgorithmAssociationFactory, T1, T2> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrivacyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConfiguredModelAlgorithmAssociationFactory, T2, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory> WithPrivacyConfiguration<T1, T2>(this CombinedResult<T1, ConfiguredModelAlgorithmAssociationFactory, T2> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrivacyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConfiguredModelAlgorithmAssociationFactory, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory> WithPrivacyConfiguration<T1, T2>(this CombinedResult<T1, T2, ConfiguredModelAlgorithmAssociationFactory> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrivacyConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ConfiguredModelAlgorithmAssociationFactory, T1, T2, T3, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory> WithPrivacyConfiguration<T1, T2, T3>(this CombinedResult<ConfiguredModelAlgorithmAssociationFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrivacyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConfiguredModelAlgorithmAssociationFactory, T2, T3, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory> WithPrivacyConfiguration<T1, T2, T3>(this CombinedResult<T1, ConfiguredModelAlgorithmAssociationFactory, T2, T3> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrivacyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConfiguredModelAlgorithmAssociationFactory, T3, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory> WithPrivacyConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, ConfiguredModelAlgorithmAssociationFactory, T3> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrivacyConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ConfiguredModelAlgorithmAssociationFactory, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory> WithPrivacyConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConfiguredModelAlgorithmAssociationFactory> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrivacyConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ConfiguredModelAlgorithmAssociationFactory, T1, T2, T3, T4, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory> WithPrivacyConfiguration<T1, T2, T3, T4>(this CombinedResult<ConfiguredModelAlgorithmAssociationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivacyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConfiguredModelAlgorithmAssociationFactory, T2, T3, T4, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory> WithPrivacyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, ConfiguredModelAlgorithmAssociationFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivacyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConfiguredModelAlgorithmAssociationFactory, T3, T4, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory> WithPrivacyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConfiguredModelAlgorithmAssociationFactory, T3, T4> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivacyConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ConfiguredModelAlgorithmAssociationFactory, T4, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory> WithPrivacyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConfiguredModelAlgorithmAssociationFactory, T4> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivacyConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ConfiguredModelAlgorithmAssociationFactory, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory> WithPrivacyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConfiguredModelAlgorithmAssociationFactory> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivacyConfiguration(combinedResult.T5, subFactoryAction).T2);
}
