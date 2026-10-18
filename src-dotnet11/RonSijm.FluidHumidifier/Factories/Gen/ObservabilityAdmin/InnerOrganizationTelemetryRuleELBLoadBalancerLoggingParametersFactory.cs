// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ObservabilityAdmin;

public class InnerOrganizationTelemetryRuleELBLoadBalancerLoggingParametersFactory(Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.ELBLoadBalancerLoggingParameters> factoryAction = null) : SubResourceFactory<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.ELBLoadBalancerLoggingParameters>
{

    protected override Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.ELBLoadBalancerLoggingParameters Create()
    {
        var eLBLoadBalancerLoggingParametersResult = CreateELBLoadBalancerLoggingParameters();
        factoryAction?.Invoke(eLBLoadBalancerLoggingParametersResult);

        return eLBLoadBalancerLoggingParametersResult;
    }

    private Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.ELBLoadBalancerLoggingParameters CreateELBLoadBalancerLoggingParameters()
    {
        var eLBLoadBalancerLoggingParametersResult = new Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.ELBLoadBalancerLoggingParameters();

        return eLBLoadBalancerLoggingParametersResult;
    }

} // End Of Class

public static class InnerOrganizationTelemetryRuleELBLoadBalancerLoggingParametersFactoryExtensions
{
}
