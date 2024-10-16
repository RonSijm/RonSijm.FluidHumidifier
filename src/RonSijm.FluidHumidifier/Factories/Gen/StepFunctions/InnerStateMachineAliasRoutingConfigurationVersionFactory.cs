// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.StepFunctions;

public class InnerStateMachineAliasRoutingConfigurationVersionFactory(Action<Humidifier.StepFunctions.StateMachineAliasTypes.RoutingConfigurationVersion> factoryAction = null) : SubResourceFactory<Humidifier.StepFunctions.StateMachineAliasTypes.RoutingConfigurationVersion>
{

    protected override Humidifier.StepFunctions.StateMachineAliasTypes.RoutingConfigurationVersion Create()
    {
        var routingConfigurationVersionResult = CreateRoutingConfigurationVersion();
        factoryAction?.Invoke(routingConfigurationVersionResult);

        return routingConfigurationVersionResult;
    }

    private Humidifier.StepFunctions.StateMachineAliasTypes.RoutingConfigurationVersion CreateRoutingConfigurationVersion()
    {
        var routingConfigurationVersionResult = new Humidifier.StepFunctions.StateMachineAliasTypes.RoutingConfigurationVersion();

        return routingConfigurationVersionResult;
    }

} // End Of Class

public static class InnerStateMachineAliasRoutingConfigurationVersionFactoryExtensions
{
}
