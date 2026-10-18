// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SCN;

public class InnerDataIntegrationFlowDatasetSourceConfigurationFactory(Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetSourceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.SCN.DataIntegrationFlowTypes.DatasetSourceConfiguration>
{

    internal InnerDataIntegrationFlowDatasetOptionsFactory OptionsFactory { get; set; }

    protected override Humidifier.SCN.DataIntegrationFlowTypes.DatasetSourceConfiguration Create()
    {
        var datasetSourceConfigurationResult = CreateDatasetSourceConfiguration();
        factoryAction?.Invoke(datasetSourceConfigurationResult);

        return datasetSourceConfigurationResult;
    }

    private Humidifier.SCN.DataIntegrationFlowTypes.DatasetSourceConfiguration CreateDatasetSourceConfiguration()
    {
        var datasetSourceConfigurationResult = new Humidifier.SCN.DataIntegrationFlowTypes.DatasetSourceConfiguration();

        return datasetSourceConfigurationResult;
    }
    public override void CreateChildren(Humidifier.SCN.DataIntegrationFlowTypes.DatasetSourceConfiguration result)
    {
        base.CreateChildren(result);

        result.Options ??= OptionsFactory?.Build();
    }

} // End Of Class

public static class InnerDataIntegrationFlowDatasetSourceConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDataIntegrationFlowDatasetSourceConfigurationFactory, InnerDataIntegrationFlowDatasetOptionsFactory> WithOptions(this InnerDataIntegrationFlowDatasetSourceConfigurationFactory parentFactory, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions> subFactoryAction = null)
    {
        parentFactory.OptionsFactory = new InnerDataIntegrationFlowDatasetOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OptionsFactory);
    }

    public static CombinedResult<InnerDataIntegrationFlowDatasetSourceConfigurationFactory, T1, InnerDataIntegrationFlowDatasetOptionsFactory> WithOptions<T1>(this CombinedResult<InnerDataIntegrationFlowDatasetSourceConfigurationFactory, T1> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataIntegrationFlowDatasetSourceConfigurationFactory, InnerDataIntegrationFlowDatasetOptionsFactory> WithOptions<T1>(this CombinedResult<T1, InnerDataIntegrationFlowDatasetSourceConfigurationFactory> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDataIntegrationFlowDatasetSourceConfigurationFactory, T1, T2, InnerDataIntegrationFlowDatasetOptionsFactory> WithOptions<T1, T2>(this CombinedResult<InnerDataIntegrationFlowDatasetSourceConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataIntegrationFlowDatasetSourceConfigurationFactory, T2, InnerDataIntegrationFlowDatasetOptionsFactory> WithOptions<T1, T2>(this CombinedResult<T1, InnerDataIntegrationFlowDatasetSourceConfigurationFactory, T2> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataIntegrationFlowDatasetSourceConfigurationFactory, InnerDataIntegrationFlowDatasetOptionsFactory> WithOptions<T1, T2>(this CombinedResult<T1, T2, InnerDataIntegrationFlowDatasetSourceConfigurationFactory> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDataIntegrationFlowDatasetSourceConfigurationFactory, T1, T2, T3, InnerDataIntegrationFlowDatasetOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<InnerDataIntegrationFlowDatasetSourceConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataIntegrationFlowDatasetSourceConfigurationFactory, T2, T3, InnerDataIntegrationFlowDatasetOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<T1, InnerDataIntegrationFlowDatasetSourceConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataIntegrationFlowDatasetSourceConfigurationFactory, T3, InnerDataIntegrationFlowDatasetOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataIntegrationFlowDatasetSourceConfigurationFactory, T3> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataIntegrationFlowDatasetSourceConfigurationFactory, InnerDataIntegrationFlowDatasetOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataIntegrationFlowDatasetSourceConfigurationFactory> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDataIntegrationFlowDatasetSourceConfigurationFactory, T1, T2, T3, T4, InnerDataIntegrationFlowDatasetOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<InnerDataIntegrationFlowDatasetSourceConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataIntegrationFlowDatasetSourceConfigurationFactory, T2, T3, T4, InnerDataIntegrationFlowDatasetOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataIntegrationFlowDatasetSourceConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataIntegrationFlowDatasetSourceConfigurationFactory, T3, T4, InnerDataIntegrationFlowDatasetOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataIntegrationFlowDatasetSourceConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataIntegrationFlowDatasetSourceConfigurationFactory, T4, InnerDataIntegrationFlowDatasetOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataIntegrationFlowDatasetSourceConfigurationFactory, T4> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDataIntegrationFlowDatasetSourceConfigurationFactory, InnerDataIntegrationFlowDatasetOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataIntegrationFlowDatasetSourceConfigurationFactory> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T5, subFactoryAction).T2);
}
