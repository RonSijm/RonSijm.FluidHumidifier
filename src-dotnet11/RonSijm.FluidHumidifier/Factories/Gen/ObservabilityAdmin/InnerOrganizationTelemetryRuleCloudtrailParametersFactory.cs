// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ObservabilityAdmin;

public class InnerOrganizationTelemetryRuleCloudtrailParametersFactory(Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.CloudtrailParameters> factoryAction = null) : SubResourceFactory<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.CloudtrailParameters>
{

    protected override Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.CloudtrailParameters Create()
    {
        var cloudtrailParametersResult = CreateCloudtrailParameters();
        factoryAction?.Invoke(cloudtrailParametersResult);

        return cloudtrailParametersResult;
    }

    private Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.CloudtrailParameters CreateCloudtrailParameters()
    {
        var cloudtrailParametersResult = new Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.CloudtrailParameters();

        return cloudtrailParametersResult;
    }

} // End Of Class

public static class InnerOrganizationTelemetryRuleCloudtrailParametersFactoryExtensions
{
}
