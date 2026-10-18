// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerTaskDefinitionFSxAuthorizationConfigFactory(Action<Humidifier.ECS.TaskDefinitionTypes.FSxAuthorizationConfig> factoryAction = null) : SubResourceFactory<Humidifier.ECS.TaskDefinitionTypes.FSxAuthorizationConfig>
{

    protected override Humidifier.ECS.TaskDefinitionTypes.FSxAuthorizationConfig Create()
    {
        var fSxAuthorizationConfigResult = CreateFSxAuthorizationConfig();
        factoryAction?.Invoke(fSxAuthorizationConfigResult);

        return fSxAuthorizationConfigResult;
    }

    private Humidifier.ECS.TaskDefinitionTypes.FSxAuthorizationConfig CreateFSxAuthorizationConfig()
    {
        var fSxAuthorizationConfigResult = new Humidifier.ECS.TaskDefinitionTypes.FSxAuthorizationConfig();

        return fSxAuthorizationConfigResult;
    }

} // End Of Class

public static class InnerTaskDefinitionFSxAuthorizationConfigFactoryExtensions
{
}
