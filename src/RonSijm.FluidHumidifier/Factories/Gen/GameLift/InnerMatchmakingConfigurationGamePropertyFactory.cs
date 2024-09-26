// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerMatchmakingConfigurationGamePropertyFactory(Action<Humidifier.GameLift.MatchmakingConfigurationTypes.GameProperty> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.MatchmakingConfigurationTypes.GameProperty>
{

    protected override Humidifier.GameLift.MatchmakingConfigurationTypes.GameProperty Create()
    {
        var gamePropertyResult = CreateGameProperty();
        factoryAction?.Invoke(gamePropertyResult);

        return gamePropertyResult;
    }

    private Humidifier.GameLift.MatchmakingConfigurationTypes.GameProperty CreateGameProperty()
    {
        var gamePropertyResult = new Humidifier.GameLift.MatchmakingConfigurationTypes.GameProperty();

        return gamePropertyResult;
    }

} // End Of Class

public static class InnerMatchmakingConfigurationGamePropertyFactoryExtensions
{
}
