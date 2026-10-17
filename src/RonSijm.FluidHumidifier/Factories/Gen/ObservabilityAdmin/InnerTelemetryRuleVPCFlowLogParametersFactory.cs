// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ObservabilityAdmin;

public class InnerTelemetryRuleVPCFlowLogParametersFactory(Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.VPCFlowLogParameters> factoryAction = null) : SubResourceFactory<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.VPCFlowLogParameters>
{

    protected override Humidifier.ObservabilityAdmin.TelemetryRuleTypes.VPCFlowLogParameters Create()
    {
        var vPCFlowLogParametersResult = CreateVPCFlowLogParameters();
        factoryAction?.Invoke(vPCFlowLogParametersResult);

        return vPCFlowLogParametersResult;
    }

    private Humidifier.ObservabilityAdmin.TelemetryRuleTypes.VPCFlowLogParameters CreateVPCFlowLogParameters()
    {
        var vPCFlowLogParametersResult = new Humidifier.ObservabilityAdmin.TelemetryRuleTypes.VPCFlowLogParameters();

        return vPCFlowLogParametersResult;
    }

} // End Of Class

public static class InnerTelemetryRuleVPCFlowLogParametersFactoryExtensions
{
}
