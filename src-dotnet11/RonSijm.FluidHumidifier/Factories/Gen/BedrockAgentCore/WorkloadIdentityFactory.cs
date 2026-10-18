// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class WorkloadIdentityFactory(string resourceName = null, Action<Humidifier.BedrockAgentCore.WorkloadIdentity> factoryAction = null) : ResourceFactory<Humidifier.BedrockAgentCore.WorkloadIdentity>(resourceName)
{

    protected override Humidifier.BedrockAgentCore.WorkloadIdentity Create()
    {
        var workloadIdentityResult = CreateWorkloadIdentity();
        factoryAction?.Invoke(workloadIdentityResult);

        return workloadIdentityResult;
    }

    private Humidifier.BedrockAgentCore.WorkloadIdentity CreateWorkloadIdentity()
    {
        var workloadIdentityResult = new Humidifier.BedrockAgentCore.WorkloadIdentity
        {
            GivenName = InputResourceName,
        };

        return workloadIdentityResult;
    }

} // End Of Class

public static class WorkloadIdentityFactoryExtensions
{
}
