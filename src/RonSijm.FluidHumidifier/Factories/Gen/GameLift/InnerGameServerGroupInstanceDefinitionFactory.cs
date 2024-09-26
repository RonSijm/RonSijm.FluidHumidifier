// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerGameServerGroupInstanceDefinitionFactory(Action<Humidifier.GameLift.GameServerGroupTypes.InstanceDefinition> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.GameServerGroupTypes.InstanceDefinition>
{

    protected override Humidifier.GameLift.GameServerGroupTypes.InstanceDefinition Create()
    {
        var instanceDefinitionResult = CreateInstanceDefinition();
        factoryAction?.Invoke(instanceDefinitionResult);

        return instanceDefinitionResult;
    }

    private Humidifier.GameLift.GameServerGroupTypes.InstanceDefinition CreateInstanceDefinition()
    {
        var instanceDefinitionResult = new Humidifier.GameLift.GameServerGroupTypes.InstanceDefinition();

        return instanceDefinitionResult;
    }

} // End Of Class

public static class InnerGameServerGroupInstanceDefinitionFactoryExtensions
{
}
