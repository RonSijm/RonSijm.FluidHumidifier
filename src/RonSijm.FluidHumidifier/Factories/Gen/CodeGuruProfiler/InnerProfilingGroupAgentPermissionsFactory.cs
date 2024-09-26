// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeGuruProfiler;

public class InnerProfilingGroupAgentPermissionsFactory(Action<Humidifier.CodeGuruProfiler.ProfilingGroupTypes.AgentPermissions> factoryAction = null) : SubResourceFactory<Humidifier.CodeGuruProfiler.ProfilingGroupTypes.AgentPermissions>
{

    protected override Humidifier.CodeGuruProfiler.ProfilingGroupTypes.AgentPermissions Create()
    {
        var agentPermissionsResult = CreateAgentPermissions();
        factoryAction?.Invoke(agentPermissionsResult);

        return agentPermissionsResult;
    }

    private Humidifier.CodeGuruProfiler.ProfilingGroupTypes.AgentPermissions CreateAgentPermissions()
    {
        var agentPermissionsResult = new Humidifier.CodeGuruProfiler.ProfilingGroupTypes.AgentPermissions();

        return agentPermissionsResult;
    }

} // End Of Class

public static class InnerProfilingGroupAgentPermissionsFactoryExtensions
{
}
