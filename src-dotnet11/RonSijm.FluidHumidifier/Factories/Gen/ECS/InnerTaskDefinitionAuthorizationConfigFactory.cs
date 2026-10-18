// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerTaskDefinitionAuthorizationConfigFactory(Action<Humidifier.ECS.TaskDefinitionTypes.AuthorizationConfig> factoryAction = null) : SubResourceFactory<Humidifier.ECS.TaskDefinitionTypes.AuthorizationConfig>
{

    protected override Humidifier.ECS.TaskDefinitionTypes.AuthorizationConfig Create()
    {
        var authorizationConfigResult = CreateAuthorizationConfig();
        factoryAction?.Invoke(authorizationConfigResult);

        return authorizationConfigResult;
    }

    private Humidifier.ECS.TaskDefinitionTypes.AuthorizationConfig CreateAuthorizationConfig()
    {
        var authorizationConfigResult = new Humidifier.ECS.TaskDefinitionTypes.AuthorizationConfig();

        return authorizationConfigResult;
    }

} // End Of Class

public static class InnerTaskDefinitionAuthorizationConfigFactoryExtensions
{
}
