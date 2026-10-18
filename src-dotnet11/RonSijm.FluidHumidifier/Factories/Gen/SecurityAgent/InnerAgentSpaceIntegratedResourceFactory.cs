// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityAgent;

public class InnerAgentSpaceIntegratedResourceFactory(Action<Humidifier.SecurityAgent.AgentSpaceTypes.IntegratedResource> factoryAction = null) : SubResourceFactory<Humidifier.SecurityAgent.AgentSpaceTypes.IntegratedResource>
{

    protected override Humidifier.SecurityAgent.AgentSpaceTypes.IntegratedResource Create()
    {
        var integratedResourceResult = CreateIntegratedResource();
        factoryAction?.Invoke(integratedResourceResult);

        return integratedResourceResult;
    }

    private Humidifier.SecurityAgent.AgentSpaceTypes.IntegratedResource CreateIntegratedResource()
    {
        var integratedResourceResult = new Humidifier.SecurityAgent.AgentSpaceTypes.IntegratedResource();

        return integratedResourceResult;
    }

} // End Of Class

public static class InnerAgentSpaceIntegratedResourceFactoryExtensions
{
}
