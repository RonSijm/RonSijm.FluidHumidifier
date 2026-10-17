// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerContainerFleetGameSessionCreationLimitPolicyFactory(Action<Humidifier.GameLift.ContainerFleetTypes.GameSessionCreationLimitPolicy> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.ContainerFleetTypes.GameSessionCreationLimitPolicy>
{

    protected override Humidifier.GameLift.ContainerFleetTypes.GameSessionCreationLimitPolicy Create()
    {
        var gameSessionCreationLimitPolicyResult = CreateGameSessionCreationLimitPolicy();
        factoryAction?.Invoke(gameSessionCreationLimitPolicyResult);

        return gameSessionCreationLimitPolicyResult;
    }

    private Humidifier.GameLift.ContainerFleetTypes.GameSessionCreationLimitPolicy CreateGameSessionCreationLimitPolicy()
    {
        var gameSessionCreationLimitPolicyResult = new Humidifier.GameLift.ContainerFleetTypes.GameSessionCreationLimitPolicy();

        return gameSessionCreationLimitPolicyResult;
    }

} // End Of Class

public static class InnerContainerFleetGameSessionCreationLimitPolicyFactoryExtensions
{
}
