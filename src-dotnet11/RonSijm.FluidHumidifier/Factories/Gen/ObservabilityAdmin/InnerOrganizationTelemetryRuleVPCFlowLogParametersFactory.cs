// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ObservabilityAdmin;

public class InnerOrganizationTelemetryRuleVPCFlowLogParametersFactory(Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.VPCFlowLogParameters> factoryAction = null) : SubResourceFactory<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.VPCFlowLogParameters>
{

    protected override Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.VPCFlowLogParameters Create()
    {
        var vPCFlowLogParametersResult = CreateVPCFlowLogParameters();
        factoryAction?.Invoke(vPCFlowLogParametersResult);

        return vPCFlowLogParametersResult;
    }

    private Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.VPCFlowLogParameters CreateVPCFlowLogParameters()
    {
        var vPCFlowLogParametersResult = new Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.VPCFlowLogParameters();

        return vPCFlowLogParametersResult;
    }

} // End Of Class

public static class InnerOrganizationTelemetryRuleVPCFlowLogParametersFactoryExtensions
{
}
