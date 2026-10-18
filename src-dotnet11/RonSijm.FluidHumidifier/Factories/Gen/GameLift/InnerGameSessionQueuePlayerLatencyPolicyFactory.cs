// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerGameSessionQueuePlayerLatencyPolicyFactory(Action<Humidifier.GameLift.GameSessionQueueTypes.PlayerLatencyPolicy> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.GameSessionQueueTypes.PlayerLatencyPolicy>
{

    protected override Humidifier.GameLift.GameSessionQueueTypes.PlayerLatencyPolicy Create()
    {
        var playerLatencyPolicyResult = CreatePlayerLatencyPolicy();
        factoryAction?.Invoke(playerLatencyPolicyResult);

        return playerLatencyPolicyResult;
    }

    private Humidifier.GameLift.GameSessionQueueTypes.PlayerLatencyPolicy CreatePlayerLatencyPolicy()
    {
        var playerLatencyPolicyResult = new Humidifier.GameLift.GameSessionQueueTypes.PlayerLatencyPolicy();

        return playerLatencyPolicyResult;
    }

} // End Of Class

public static class InnerGameSessionQueuePlayerLatencyPolicyFactoryExtensions
{
}
