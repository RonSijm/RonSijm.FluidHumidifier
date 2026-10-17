// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SCN;

public class InnerDataIntegrationFlowDatasetTargetConfigurationFactory(Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetTargetConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.SCN.DataIntegrationFlowTypes.DatasetTargetConfiguration>
{

    internal InnerDataIntegrationFlowDatasetOptionsFactory OptionsFactory { get; set; }

    protected override Humidifier.SCN.DataIntegrationFlowTypes.DatasetTargetConfiguration Create()
    {
        var datasetTargetConfigurationResult = CreateDatasetTargetConfiguration();
        factoryAction?.Invoke(datasetTargetConfigurationResult);

        return datasetTargetConfigurationResult;
    }

    private Humidifier.SCN.DataIntegrationFlowTypes.DatasetTargetConfiguration CreateDatasetTargetConfiguration()
    {
        var datasetTargetConfigurationResult = new Humidifier.SCN.DataIntegrationFlowTypes.DatasetTargetConfiguration();

        return datasetTargetConfigurationResult;
    }
    public override void CreateChildren(Humidifier.SCN.DataIntegrationFlowTypes.DatasetTargetConfiguration result)
    {
        base.CreateChildren(result);

        result.Options ??= OptionsFactory?.Build();
    }

} // End Of Class

public static class InnerDataIntegrationFlowDatasetTargetConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDataIntegrationFlowDatasetTargetConfigurationFactory, InnerDataIntegrationFlowDatasetOptionsFactory> WithOptions(this InnerDataIntegrationFlowDatasetTargetConfigurationFactory parentFactory, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions> subFactoryAction = null)
    {
        parentFactory.OptionsFactory = new InnerDataIntegrationFlowDatasetOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OptionsFactory);
    }

    public static CombinedResult<InnerDataIntegrationFlowDatasetTargetConfigurationFactory, T1, InnerDataIntegrationFlowDatasetOptionsFactory> WithOptions<T1>(this CombinedResult<InnerDataIntegrationFlowDatasetTargetConfigurationFactory, T1> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataIntegrationFlowDatasetTargetConfigurationFactory, InnerDataIntegrationFlowDatasetOptionsFactory> WithOptions<T1>(this CombinedResult<T1, InnerDataIntegrationFlowDatasetTargetConfigurationFactory> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDataIntegrationFlowDatasetTargetConfigurationFactory, T1, T2, InnerDataIntegrationFlowDatasetOptionsFactory> WithOptions<T1, T2>(this CombinedResult<InnerDataIntegrationFlowDatasetTargetConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataIntegrationFlowDatasetTargetConfigurationFactory, T2, InnerDataIntegrationFlowDatasetOptionsFactory> WithOptions<T1, T2>(this CombinedResult<T1, InnerDataIntegrationFlowDatasetTargetConfigurationFactory, T2> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataIntegrationFlowDatasetTargetConfigurationFactory, InnerDataIntegrationFlowDatasetOptionsFactory> WithOptions<T1, T2>(this CombinedResult<T1, T2, InnerDataIntegrationFlowDatasetTargetConfigurationFactory> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDataIntegrationFlowDatasetTargetConfigurationFactory, T1, T2, T3, InnerDataIntegrationFlowDatasetOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<InnerDataIntegrationFlowDatasetTargetConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataIntegrationFlowDatasetTargetConfigurationFactory, T2, T3, InnerDataIntegrationFlowDatasetOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<T1, InnerDataIntegrationFlowDatasetTargetConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataIntegrationFlowDatasetTargetConfigurationFactory, T3, InnerDataIntegrationFlowDatasetOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataIntegrationFlowDatasetTargetConfigurationFactory, T3> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataIntegrationFlowDatasetTargetConfigurationFactory, InnerDataIntegrationFlowDatasetOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataIntegrationFlowDatasetTargetConfigurationFactory> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDataIntegrationFlowDatasetTargetConfigurationFactory, T1, T2, T3, T4, InnerDataIntegrationFlowDatasetOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<InnerDataIntegrationFlowDatasetTargetConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataIntegrationFlowDatasetTargetConfigurationFactory, T2, T3, T4, InnerDataIntegrationFlowDatasetOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataIntegrationFlowDatasetTargetConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataIntegrationFlowDatasetTargetConfigurationFactory, T3, T4, InnerDataIntegrationFlowDatasetOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataIntegrationFlowDatasetTargetConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataIntegrationFlowDatasetTargetConfigurationFactory, T4, InnerDataIntegrationFlowDatasetOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataIntegrationFlowDatasetTargetConfigurationFactory, T4> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDataIntegrationFlowDatasetTargetConfigurationFactory, InnerDataIntegrationFlowDatasetOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataIntegrationFlowDatasetTargetConfigurationFactory> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T5, subFactoryAction).T2);
}
