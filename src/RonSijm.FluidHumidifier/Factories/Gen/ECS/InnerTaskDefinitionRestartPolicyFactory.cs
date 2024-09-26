// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerTaskDefinitionRestartPolicyFactory(Action<Humidifier.ECS.TaskDefinitionTypes.RestartPolicy> factoryAction = null) : SubResourceFactory<Humidifier.ECS.TaskDefinitionTypes.RestartPolicy>
{

    protected override Humidifier.ECS.TaskDefinitionTypes.RestartPolicy Create()
    {
        var restartPolicyResult = CreateRestartPolicy();
        factoryAction?.Invoke(restartPolicyResult);

        return restartPolicyResult;
    }

    private Humidifier.ECS.TaskDefinitionTypes.RestartPolicy CreateRestartPolicy()
    {
        var restartPolicyResult = new Humidifier.ECS.TaskDefinitionTypes.RestartPolicy();

        return restartPolicyResult;
    }

} // End Of Class

public static class InnerTaskDefinitionRestartPolicyFactoryExtensions
{
}
