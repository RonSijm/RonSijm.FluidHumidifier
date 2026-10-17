// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ObservabilityAdmin;

public class InnerTelemetryRuleELBLoadBalancerLoggingParametersFactory(Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.ELBLoadBalancerLoggingParameters> factoryAction = null) : SubResourceFactory<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.ELBLoadBalancerLoggingParameters>
{

    protected override Humidifier.ObservabilityAdmin.TelemetryRuleTypes.ELBLoadBalancerLoggingParameters Create()
    {
        var eLBLoadBalancerLoggingParametersResult = CreateELBLoadBalancerLoggingParameters();
        factoryAction?.Invoke(eLBLoadBalancerLoggingParametersResult);

        return eLBLoadBalancerLoggingParametersResult;
    }

    private Humidifier.ObservabilityAdmin.TelemetryRuleTypes.ELBLoadBalancerLoggingParameters CreateELBLoadBalancerLoggingParameters()
    {
        var eLBLoadBalancerLoggingParametersResult = new Humidifier.ObservabilityAdmin.TelemetryRuleTypes.ELBLoadBalancerLoggingParameters();

        return eLBLoadBalancerLoggingParametersResult;
    }

} // End Of Class

public static class InnerTelemetryRuleELBLoadBalancerLoggingParametersFactoryExtensions
{
}
