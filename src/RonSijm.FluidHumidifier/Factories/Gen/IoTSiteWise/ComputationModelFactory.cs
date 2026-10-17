// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class ComputationModelFactory(string resourceName = null, Action<Humidifier.IoTSiteWise.ComputationModel> factoryAction = null) : ResourceFactory<Humidifier.IoTSiteWise.ComputationModel>(resourceName)
{

    internal InnerComputationModelComputationModelConfigurationFactory ComputationModelConfigurationFactory { get; set; }

    protected override Humidifier.IoTSiteWise.ComputationModel Create()
    {
        var computationModelResult = CreateComputationModel();
        factoryAction?.Invoke(computationModelResult);

        return computationModelResult;
    }

    private Humidifier.IoTSiteWise.ComputationModel CreateComputationModel()
    {
        var computationModelResult = new Humidifier.IoTSiteWise.ComputationModel
        {
            GivenName = InputResourceName,
        };

        return computationModelResult;
    }
    public override void CreateChildren(Humidifier.IoTSiteWise.ComputationModel result)
    {
        base.CreateChildren(result);

        result.ComputationModelConfiguration ??= ComputationModelConfigurationFactory?.Build();
    }

} // End Of Class

public static class ComputationModelFactoryExtensions
{
    public static CombinedResult<ComputationModelFactory, InnerComputationModelComputationModelConfigurationFactory> WithComputationModelConfiguration(this ComputationModelFactory parentFactory, Action<Humidifier.IoTSiteWise.ComputationModelTypes.ComputationModelConfiguration> subFactoryAction = null)
    {
        parentFactory.ComputationModelConfigurationFactory = new InnerComputationModelComputationModelConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ComputationModelConfigurationFactory);
    }

    public static CombinedResult<ComputationModelFactory, T1, InnerComputationModelComputationModelConfigurationFactory> WithComputationModelConfiguration<T1>(this CombinedResult<ComputationModelFactory, T1> combinedResult, Action<Humidifier.IoTSiteWise.ComputationModelTypes.ComputationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithComputationModelConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ComputationModelFactory, InnerComputationModelComputationModelConfigurationFactory> WithComputationModelConfiguration<T1>(this CombinedResult<T1, ComputationModelFactory> combinedResult, Action<Humidifier.IoTSiteWise.ComputationModelTypes.ComputationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithComputationModelConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ComputationModelFactory, T1, T2, InnerComputationModelComputationModelConfigurationFactory> WithComputationModelConfiguration<T1, T2>(this CombinedResult<ComputationModelFactory, T1, T2> combinedResult, Action<Humidifier.IoTSiteWise.ComputationModelTypes.ComputationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComputationModelConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ComputationModelFactory, T2, InnerComputationModelComputationModelConfigurationFactory> WithComputationModelConfiguration<T1, T2>(this CombinedResult<T1, ComputationModelFactory, T2> combinedResult, Action<Humidifier.IoTSiteWise.ComputationModelTypes.ComputationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComputationModelConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ComputationModelFactory, InnerComputationModelComputationModelConfigurationFactory> WithComputationModelConfiguration<T1, T2>(this CombinedResult<T1, T2, ComputationModelFactory> combinedResult, Action<Humidifier.IoTSiteWise.ComputationModelTypes.ComputationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComputationModelConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ComputationModelFactory, T1, T2, T3, InnerComputationModelComputationModelConfigurationFactory> WithComputationModelConfiguration<T1, T2, T3>(this CombinedResult<ComputationModelFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.ComputationModelTypes.ComputationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputationModelConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ComputationModelFactory, T2, T3, InnerComputationModelComputationModelConfigurationFactory> WithComputationModelConfiguration<T1, T2, T3>(this CombinedResult<T1, ComputationModelFactory, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.ComputationModelTypes.ComputationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputationModelConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ComputationModelFactory, T3, InnerComputationModelComputationModelConfigurationFactory> WithComputationModelConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, ComputationModelFactory, T3> combinedResult, Action<Humidifier.IoTSiteWise.ComputationModelTypes.ComputationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputationModelConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ComputationModelFactory, InnerComputationModelComputationModelConfigurationFactory> WithComputationModelConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, ComputationModelFactory> combinedResult, Action<Humidifier.IoTSiteWise.ComputationModelTypes.ComputationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputationModelConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ComputationModelFactory, T1, T2, T3, T4, InnerComputationModelComputationModelConfigurationFactory> WithComputationModelConfiguration<T1, T2, T3, T4>(this CombinedResult<ComputationModelFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.ComputationModelTypes.ComputationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputationModelConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ComputationModelFactory, T2, T3, T4, InnerComputationModelComputationModelConfigurationFactory> WithComputationModelConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, ComputationModelFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.ComputationModelTypes.ComputationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputationModelConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ComputationModelFactory, T3, T4, InnerComputationModelComputationModelConfigurationFactory> WithComputationModelConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, ComputationModelFactory, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.ComputationModelTypes.ComputationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputationModelConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ComputationModelFactory, T4, InnerComputationModelComputationModelConfigurationFactory> WithComputationModelConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ComputationModelFactory, T4> combinedResult, Action<Humidifier.IoTSiteWise.ComputationModelTypes.ComputationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputationModelConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ComputationModelFactory, InnerComputationModelComputationModelConfigurationFactory> WithComputationModelConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ComputationModelFactory> combinedResult, Action<Humidifier.IoTSiteWise.ComputationModelTypes.ComputationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputationModelConfiguration(combinedResult.T5, subFactoryAction).T2);
}
