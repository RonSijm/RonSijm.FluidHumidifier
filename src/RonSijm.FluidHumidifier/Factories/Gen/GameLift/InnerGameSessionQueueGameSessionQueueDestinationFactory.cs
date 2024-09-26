// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerGameSessionQueueGameSessionQueueDestinationFactory(Action<Humidifier.GameLift.GameSessionQueueTypes.GameSessionQueueDestination> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.GameSessionQueueTypes.GameSessionQueueDestination>
{

    protected override Humidifier.GameLift.GameSessionQueueTypes.GameSessionQueueDestination Create()
    {
        var gameSessionQueueDestinationResult = CreateGameSessionQueueDestination();
        factoryAction?.Invoke(gameSessionQueueDestinationResult);

        return gameSessionQueueDestinationResult;
    }

    private Humidifier.GameLift.GameSessionQueueTypes.GameSessionQueueDestination CreateGameSessionQueueDestination()
    {
        var gameSessionQueueDestinationResult = new Humidifier.GameLift.GameSessionQueueTypes.GameSessionQueueDestination();

        return gameSessionQueueDestinationResult;
    }

} // End Of Class

public static class InnerGameSessionQueueGameSessionQueueDestinationFactoryExtensions
{
}
