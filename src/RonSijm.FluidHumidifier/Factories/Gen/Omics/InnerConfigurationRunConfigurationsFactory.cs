// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Omics;

public class InnerConfigurationRunConfigurationsFactory(Action<Humidifier.Omics.ConfigurationTypes.RunConfigurations> factoryAction = null) : SubResourceFactory<Humidifier.Omics.ConfigurationTypes.RunConfigurations>
{

    internal InnerConfigurationVpcConfigFactory VpcConfigFactory { get; set; }

    protected override Humidifier.Omics.ConfigurationTypes.RunConfigurations Create()
    {
        var runConfigurationsResult = CreateRunConfigurations();
        factoryAction?.Invoke(runConfigurationsResult);

        return runConfigurationsResult;
    }

    private Humidifier.Omics.ConfigurationTypes.RunConfigurations CreateRunConfigurations()
    {
        var runConfigurationsResult = new Humidifier.Omics.ConfigurationTypes.RunConfigurations();

        return runConfigurationsResult;
    }
    public override void CreateChildren(Humidifier.Omics.ConfigurationTypes.RunConfigurations result)
    {
        base.CreateChildren(result);

        result.VpcConfig ??= VpcConfigFactory?.Build();
    }

} // End Of Class

public static class InnerConfigurationRunConfigurationsFactoryExtensions
{
    public static CombinedResult<InnerConfigurationRunConfigurationsFactory, InnerConfigurationVpcConfigFactory> WithVpcConfig(this InnerConfigurationRunConfigurationsFactory parentFactory, Action<Humidifier.Omics.ConfigurationTypes.VpcConfig> subFactoryAction = null)
    {
        parentFactory.VpcConfigFactory = new InnerConfigurationVpcConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcConfigFactory);
    }

    public static CombinedResult<InnerConfigurationRunConfigurationsFactory, T1, InnerConfigurationVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<InnerConfigurationRunConfigurationsFactory, T1> combinedResult, Action<Humidifier.Omics.ConfigurationTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfigurationRunConfigurationsFactory, InnerConfigurationVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<T1, InnerConfigurationRunConfigurationsFactory> combinedResult, Action<Humidifier.Omics.ConfigurationTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerConfigurationRunConfigurationsFactory, T1, T2, InnerConfigurationVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<InnerConfigurationRunConfigurationsFactory, T1, T2> combinedResult, Action<Humidifier.Omics.ConfigurationTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfigurationRunConfigurationsFactory, T2, InnerConfigurationVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, InnerConfigurationRunConfigurationsFactory, T2> combinedResult, Action<Humidifier.Omics.ConfigurationTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConfigurationRunConfigurationsFactory, InnerConfigurationVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, T2, InnerConfigurationRunConfigurationsFactory> combinedResult, Action<Humidifier.Omics.ConfigurationTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerConfigurationRunConfigurationsFactory, T1, T2, T3, InnerConfigurationVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<InnerConfigurationRunConfigurationsFactory, T1, T2, T3> combinedResult, Action<Humidifier.Omics.ConfigurationTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfigurationRunConfigurationsFactory, T2, T3, InnerConfigurationVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, InnerConfigurationRunConfigurationsFactory, T2, T3> combinedResult, Action<Humidifier.Omics.ConfigurationTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConfigurationRunConfigurationsFactory, T3, InnerConfigurationVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerConfigurationRunConfigurationsFactory, T3> combinedResult, Action<Humidifier.Omics.ConfigurationTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConfigurationRunConfigurationsFactory, InnerConfigurationVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConfigurationRunConfigurationsFactory> combinedResult, Action<Humidifier.Omics.ConfigurationTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerConfigurationRunConfigurationsFactory, T1, T2, T3, T4, InnerConfigurationVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<InnerConfigurationRunConfigurationsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Omics.ConfigurationTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfigurationRunConfigurationsFactory, T2, T3, T4, InnerConfigurationVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerConfigurationRunConfigurationsFactory, T2, T3, T4> combinedResult, Action<Humidifier.Omics.ConfigurationTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConfigurationRunConfigurationsFactory, T3, T4, InnerConfigurationVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConfigurationRunConfigurationsFactory, T3, T4> combinedResult, Action<Humidifier.Omics.ConfigurationTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConfigurationRunConfigurationsFactory, T4, InnerConfigurationVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConfigurationRunConfigurationsFactory, T4> combinedResult, Action<Humidifier.Omics.ConfigurationTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerConfigurationRunConfigurationsFactory, InnerConfigurationVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConfigurationRunConfigurationsFactory> combinedResult, Action<Humidifier.Omics.ConfigurationTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T5, subFactoryAction).T2);
}
