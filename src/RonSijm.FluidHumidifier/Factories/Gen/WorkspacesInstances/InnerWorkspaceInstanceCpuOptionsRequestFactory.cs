// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkspacesInstances;

public class InnerWorkspaceInstanceCpuOptionsRequestFactory(Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CpuOptionsRequest> factoryAction = null) : SubResourceFactory<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CpuOptionsRequest>
{

    protected override Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CpuOptionsRequest Create()
    {
        var cpuOptionsRequestResult = CreateCpuOptionsRequest();
        factoryAction?.Invoke(cpuOptionsRequestResult);

        return cpuOptionsRequestResult;
    }

    private Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CpuOptionsRequest CreateCpuOptionsRequest()
    {
        var cpuOptionsRequestResult = new Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CpuOptionsRequest();

        return cpuOptionsRequestResult;
    }

} // End Of Class

public static class InnerWorkspaceInstanceCpuOptionsRequestFactoryExtensions
{
}
