// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ObservabilityAdmin;

public class TelemetryPipelinesFactory(string resourceName = null, Action<Humidifier.ObservabilityAdmin.TelemetryPipelines> factoryAction = null) : ResourceFactory<Humidifier.ObservabilityAdmin.TelemetryPipelines>(resourceName)
{

    internal InnerTelemetryPipelinesTelemetryPipelineConfigurationFactory ConfigurationFactory { get; set; }

    protected override Humidifier.ObservabilityAdmin.TelemetryPipelines Create()
    {
        var telemetryPipelinesResult = CreateTelemetryPipelines();
        factoryAction?.Invoke(telemetryPipelinesResult);

        return telemetryPipelinesResult;
    }

    private Humidifier.ObservabilityAdmin.TelemetryPipelines CreateTelemetryPipelines()
    {
        var telemetryPipelinesResult = new Humidifier.ObservabilityAdmin.TelemetryPipelines
        {
            GivenName = InputResourceName,
        };

        return telemetryPipelinesResult;
    }
    public override void CreateChildren(Humidifier.ObservabilityAdmin.TelemetryPipelines result)
    {
        base.CreateChildren(result);

        result.Configuration ??= ConfigurationFactory?.Build();
    }

} // End Of Class

public static class TelemetryPipelinesFactoryExtensions
{
    public static CombinedResult<TelemetryPipelinesFactory, InnerTelemetryPipelinesTelemetryPipelineConfigurationFactory> WithConfiguration(this TelemetryPipelinesFactory parentFactory, Action<Humidifier.ObservabilityAdmin.TelemetryPipelinesTypes.TelemetryPipelineConfiguration> subFactoryAction = null)
    {
        parentFactory.ConfigurationFactory = new InnerTelemetryPipelinesTelemetryPipelineConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigurationFactory);
    }

    public static CombinedResult<TelemetryPipelinesFactory, T1, InnerTelemetryPipelinesTelemetryPipelineConfigurationFactory> WithConfiguration<T1>(this CombinedResult<TelemetryPipelinesFactory, T1> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryPipelinesTypes.TelemetryPipelineConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TelemetryPipelinesFactory, InnerTelemetryPipelinesTelemetryPipelineConfigurationFactory> WithConfiguration<T1>(this CombinedResult<T1, TelemetryPipelinesFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryPipelinesTypes.TelemetryPipelineConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<TelemetryPipelinesFactory, T1, T2, InnerTelemetryPipelinesTelemetryPipelineConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<TelemetryPipelinesFactory, T1, T2> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryPipelinesTypes.TelemetryPipelineConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TelemetryPipelinesFactory, T2, InnerTelemetryPipelinesTelemetryPipelineConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, TelemetryPipelinesFactory, T2> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryPipelinesTypes.TelemetryPipelineConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TelemetryPipelinesFactory, InnerTelemetryPipelinesTelemetryPipelineConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, T2, TelemetryPipelinesFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryPipelinesTypes.TelemetryPipelineConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<TelemetryPipelinesFactory, T1, T2, T3, InnerTelemetryPipelinesTelemetryPipelineConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<TelemetryPipelinesFactory, T1, T2, T3> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryPipelinesTypes.TelemetryPipelineConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TelemetryPipelinesFactory, T2, T3, InnerTelemetryPipelinesTelemetryPipelineConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, TelemetryPipelinesFactory, T2, T3> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryPipelinesTypes.TelemetryPipelineConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TelemetryPipelinesFactory, T3, InnerTelemetryPipelinesTelemetryPipelineConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, TelemetryPipelinesFactory, T3> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryPipelinesTypes.TelemetryPipelineConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TelemetryPipelinesFactory, InnerTelemetryPipelinesTelemetryPipelineConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, TelemetryPipelinesFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryPipelinesTypes.TelemetryPipelineConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<TelemetryPipelinesFactory, T1, T2, T3, T4, InnerTelemetryPipelinesTelemetryPipelineConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<TelemetryPipelinesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryPipelinesTypes.TelemetryPipelineConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TelemetryPipelinesFactory, T2, T3, T4, InnerTelemetryPipelinesTelemetryPipelineConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, TelemetryPipelinesFactory, T2, T3, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryPipelinesTypes.TelemetryPipelineConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TelemetryPipelinesFactory, T3, T4, InnerTelemetryPipelinesTelemetryPipelineConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, TelemetryPipelinesFactory, T3, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryPipelinesTypes.TelemetryPipelineConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TelemetryPipelinesFactory, T4, InnerTelemetryPipelinesTelemetryPipelineConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TelemetryPipelinesFactory, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryPipelinesTypes.TelemetryPipelineConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, TelemetryPipelinesFactory, InnerTelemetryPipelinesTelemetryPipelineConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TelemetryPipelinesFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryPipelinesTypes.TelemetryPipelineConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T5, subFactoryAction).T2);
}
