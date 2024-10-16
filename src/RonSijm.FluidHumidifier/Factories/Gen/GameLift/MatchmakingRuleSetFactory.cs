// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class MatchmakingRuleSetFactory(string resourceName = null, Action<Humidifier.GameLift.MatchmakingRuleSet> factoryAction = null) : ResourceFactory<Humidifier.GameLift.MatchmakingRuleSet>(resourceName)
{

    protected override Humidifier.GameLift.MatchmakingRuleSet Create()
    {
        var matchmakingRuleSetResult = CreateMatchmakingRuleSet();
        factoryAction?.Invoke(matchmakingRuleSetResult);

        return matchmakingRuleSetResult;
    }

    private Humidifier.GameLift.MatchmakingRuleSet CreateMatchmakingRuleSet()
    {
        var matchmakingRuleSetResult = new Humidifier.GameLift.MatchmakingRuleSet
        {
            GivenName = InputResourceName,
        };

        return matchmakingRuleSetResult;
    }

} // End Of Class

public static class MatchmakingRuleSetFactoryExtensions
{
}
