// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ObservabilityAdmin;

public class InnerTelemetryRuleCloudtrailParametersFactory(Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.CloudtrailParameters> factoryAction = null) : SubResourceFactory<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.CloudtrailParameters>
{

    protected override Humidifier.ObservabilityAdmin.TelemetryRuleTypes.CloudtrailParameters Create()
    {
        var cloudtrailParametersResult = CreateCloudtrailParameters();
        factoryAction?.Invoke(cloudtrailParametersResult);

        return cloudtrailParametersResult;
    }

    private Humidifier.ObservabilityAdmin.TelemetryRuleTypes.CloudtrailParameters CreateCloudtrailParameters()
    {
        var cloudtrailParametersResult = new Humidifier.ObservabilityAdmin.TelemetryRuleTypes.CloudtrailParameters();

        return cloudtrailParametersResult;
    }

} // End Of Class

public static class InnerTelemetryRuleCloudtrailParametersFactoryExtensions
{
}
