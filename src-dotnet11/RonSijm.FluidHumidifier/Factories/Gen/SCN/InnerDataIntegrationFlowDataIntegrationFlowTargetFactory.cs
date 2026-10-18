// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SCN;

public class InnerDataIntegrationFlowDataIntegrationFlowTargetFactory(Action<Humidifier.SCN.DataIntegrationFlowTypes.DataIntegrationFlowTarget> factoryAction = null) : SubResourceFactory<Humidifier.SCN.DataIntegrationFlowTypes.DataIntegrationFlowTarget>
{

    internal InnerDataIntegrationFlowDatasetTargetConfigurationFactory DatasetTargetFactory { get; set; }

    protected override Humidifier.SCN.DataIntegrationFlowTypes.DataIntegrationFlowTarget Create()
    {
        var dataIntegrationFlowTargetResult = CreateDataIntegrationFlowTarget();
        factoryAction?.Invoke(dataIntegrationFlowTargetResult);

        return dataIntegrationFlowTargetResult;
    }

    private Humidifier.SCN.DataIntegrationFlowTypes.DataIntegrationFlowTarget CreateDataIntegrationFlowTarget()
    {
        var dataIntegrationFlowTargetResult = new Humidifier.SCN.DataIntegrationFlowTypes.DataIntegrationFlowTarget();

        return dataIntegrationFlowTargetResult;
    }
    public override void CreateChildren(Humidifier.SCN.DataIntegrationFlowTypes.DataIntegrationFlowTarget result)
    {
        base.CreateChildren(result);

        result.DatasetTarget ??= DatasetTargetFactory?.Build();
    }

} // End Of Class

public static class InnerDataIntegrationFlowDataIntegrationFlowTargetFactoryExtensions
{
    public static CombinedResult<InnerDataIntegrationFlowDataIntegrationFlowTargetFactory, InnerDataIntegrationFlowDatasetTargetConfigurationFactory> WithDatasetTarget(this InnerDataIntegrationFlowDataIntegrationFlowTargetFactory parentFactory, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetTargetConfiguration> subFactoryAction = null)
    {
        parentFactory.DatasetTargetFactory = new InnerDataIntegrationFlowDatasetTargetConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DatasetTargetFactory);
    }

    public static CombinedResult<InnerDataIntegrationFlowDataIntegrationFlowTargetFactory, T1, InnerDataIntegrationFlowDatasetTargetConfigurationFactory> WithDatasetTarget<T1>(this CombinedResult<InnerDataIntegrationFlowDataIntegrationFlowTargetFactory, T1> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetTargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDatasetTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataIntegrationFlowDataIntegrationFlowTargetFactory, InnerDataIntegrationFlowDatasetTargetConfigurationFactory> WithDatasetTarget<T1>(this CombinedResult<T1, InnerDataIntegrationFlowDataIntegrationFlowTargetFactory> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetTargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDatasetTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDataIntegrationFlowDataIntegrationFlowTargetFactory, T1, T2, InnerDataIntegrationFlowDatasetTargetConfigurationFactory> WithDatasetTarget<T1, T2>(this CombinedResult<InnerDataIntegrationFlowDataIntegrationFlowTargetFactory, T1, T2> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetTargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatasetTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataIntegrationFlowDataIntegrationFlowTargetFactory, T2, InnerDataIntegrationFlowDatasetTargetConfigurationFactory> WithDatasetTarget<T1, T2>(this CombinedResult<T1, InnerDataIntegrationFlowDataIntegrationFlowTargetFactory, T2> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetTargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatasetTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataIntegrationFlowDataIntegrationFlowTargetFactory, InnerDataIntegrationFlowDatasetTargetConfigurationFactory> WithDatasetTarget<T1, T2>(this CombinedResult<T1, T2, InnerDataIntegrationFlowDataIntegrationFlowTargetFactory> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetTargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatasetTarget(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDataIntegrationFlowDataIntegrationFlowTargetFactory, T1, T2, T3, InnerDataIntegrationFlowDatasetTargetConfigurationFactory> WithDatasetTarget<T1, T2, T3>(this CombinedResult<InnerDataIntegrationFlowDataIntegrationFlowTargetFactory, T1, T2, T3> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetTargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataIntegrationFlowDataIntegrationFlowTargetFactory, T2, T3, InnerDataIntegrationFlowDatasetTargetConfigurationFactory> WithDatasetTarget<T1, T2, T3>(this CombinedResult<T1, InnerDataIntegrationFlowDataIntegrationFlowTargetFactory, T2, T3> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetTargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataIntegrationFlowDataIntegrationFlowTargetFactory, T3, InnerDataIntegrationFlowDatasetTargetConfigurationFactory> WithDatasetTarget<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataIntegrationFlowDataIntegrationFlowTargetFactory, T3> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetTargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetTarget(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataIntegrationFlowDataIntegrationFlowTargetFactory, InnerDataIntegrationFlowDatasetTargetConfigurationFactory> WithDatasetTarget<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataIntegrationFlowDataIntegrationFlowTargetFactory> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetTargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetTarget(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDataIntegrationFlowDataIntegrationFlowTargetFactory, T1, T2, T3, T4, InnerDataIntegrationFlowDatasetTargetConfigurationFactory> WithDatasetTarget<T1, T2, T3, T4>(this CombinedResult<InnerDataIntegrationFlowDataIntegrationFlowTargetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetTargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataIntegrationFlowDataIntegrationFlowTargetFactory, T2, T3, T4, InnerDataIntegrationFlowDatasetTargetConfigurationFactory> WithDatasetTarget<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataIntegrationFlowDataIntegrationFlowTargetFactory, T2, T3, T4> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetTargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataIntegrationFlowDataIntegrationFlowTargetFactory, T3, T4, InnerDataIntegrationFlowDatasetTargetConfigurationFactory> WithDatasetTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataIntegrationFlowDataIntegrationFlowTargetFactory, T3, T4> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetTargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetTarget(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataIntegrationFlowDataIntegrationFlowTargetFactory, T4, InnerDataIntegrationFlowDatasetTargetConfigurationFactory> WithDatasetTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataIntegrationFlowDataIntegrationFlowTargetFactory, T4> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetTargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetTarget(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDataIntegrationFlowDataIntegrationFlowTargetFactory, InnerDataIntegrationFlowDatasetTargetConfigurationFactory> WithDatasetTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataIntegrationFlowDataIntegrationFlowTargetFactory> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.DatasetTargetConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetTarget(combinedResult.T5, subFactoryAction).T2);
}
