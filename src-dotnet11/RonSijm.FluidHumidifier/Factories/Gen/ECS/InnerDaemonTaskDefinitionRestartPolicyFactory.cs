// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerDaemonTaskDefinitionRestartPolicyFactory(Action<Humidifier.ECS.DaemonTaskDefinitionTypes.RestartPolicy> factoryAction = null) : SubResourceFactory<Humidifier.ECS.DaemonTaskDefinitionTypes.RestartPolicy>
{

    protected override Humidifier.ECS.DaemonTaskDefinitionTypes.RestartPolicy Create()
    {
        var restartPolicyResult = CreateRestartPolicy();
        factoryAction?.Invoke(restartPolicyResult);

        return restartPolicyResult;
    }

    private Humidifier.ECS.DaemonTaskDefinitionTypes.RestartPolicy CreateRestartPolicy()
    {
        var restartPolicyResult = new Humidifier.ECS.DaemonTaskDefinitionTypes.RestartPolicy();

        return restartPolicyResult;
    }

} // End Of Class

public static class InnerDaemonTaskDefinitionRestartPolicyFactoryExtensions
{
}
