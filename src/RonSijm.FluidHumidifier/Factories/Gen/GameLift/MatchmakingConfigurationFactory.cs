// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class MatchmakingConfigurationFactory(string resourceName = null, Action<Humidifier.GameLift.MatchmakingConfiguration> factoryAction = null) : ResourceFactory<Humidifier.GameLift.MatchmakingConfiguration>(resourceName)
{

    internal List<InnerMatchmakingConfigurationGamePropertyFactory> GamePropertiesFactories { get; set; } = [];

    protected override Humidifier.GameLift.MatchmakingConfiguration Create()
    {
        var matchmakingConfigurationResult = CreateMatchmakingConfiguration();
        factoryAction?.Invoke(matchmakingConfigurationResult);

        return matchmakingConfigurationResult;
    }

    private Humidifier.GameLift.MatchmakingConfiguration CreateMatchmakingConfiguration()
    {
        var matchmakingConfigurationResult = new Humidifier.GameLift.MatchmakingConfiguration
        {
            GivenName = InputResourceName,
        };

        return matchmakingConfigurationResult;
    }
    public override void CreateChildren(Humidifier.GameLift.MatchmakingConfiguration result)
    {
        base.CreateChildren(result);

        result.GameProperties = GamePropertiesFactories.Any() ? GamePropertiesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class MatchmakingConfigurationFactoryExtensions
{
    public static CombinedResult<MatchmakingConfigurationFactory, InnerMatchmakingConfigurationGamePropertyFactory> WithGameProperties(this MatchmakingConfigurationFactory parentFactory, Action<Humidifier.GameLift.MatchmakingConfigurationTypes.GameProperty> subFactoryAction = null)
    {
        var factory = new InnerMatchmakingConfigurationGamePropertyFactory(subFactoryAction);
        parentFactory.GamePropertiesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<MatchmakingConfigurationFactory, T1, InnerMatchmakingConfigurationGamePropertyFactory> WithGameProperties<T1>(this CombinedResult<MatchmakingConfigurationFactory, T1> combinedResult, Action<Humidifier.GameLift.MatchmakingConfigurationTypes.GameProperty> subFactoryAction = null) => new (combinedResult, combinedResult, WithGameProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MatchmakingConfigurationFactory, InnerMatchmakingConfigurationGamePropertyFactory> WithGameProperties<T1>(this CombinedResult<T1, MatchmakingConfigurationFactory> combinedResult, Action<Humidifier.GameLift.MatchmakingConfigurationTypes.GameProperty> subFactoryAction = null) => new (combinedResult, combinedResult, WithGameProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<MatchmakingConfigurationFactory, T1, T2, InnerMatchmakingConfigurationGamePropertyFactory> WithGameProperties<T1, T2>(this CombinedResult<MatchmakingConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.GameLift.MatchmakingConfigurationTypes.GameProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGameProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MatchmakingConfigurationFactory, T2, InnerMatchmakingConfigurationGamePropertyFactory> WithGameProperties<T1, T2>(this CombinedResult<T1, MatchmakingConfigurationFactory, T2> combinedResult, Action<Humidifier.GameLift.MatchmakingConfigurationTypes.GameProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGameProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MatchmakingConfigurationFactory, InnerMatchmakingConfigurationGamePropertyFactory> WithGameProperties<T1, T2>(this CombinedResult<T1, T2, MatchmakingConfigurationFactory> combinedResult, Action<Humidifier.GameLift.MatchmakingConfigurationTypes.GameProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGameProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<MatchmakingConfigurationFactory, T1, T2, T3, InnerMatchmakingConfigurationGamePropertyFactory> WithGameProperties<T1, T2, T3>(this CombinedResult<MatchmakingConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.GameLift.MatchmakingConfigurationTypes.GameProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGameProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MatchmakingConfigurationFactory, T2, T3, InnerMatchmakingConfigurationGamePropertyFactory> WithGameProperties<T1, T2, T3>(this CombinedResult<T1, MatchmakingConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.GameLift.MatchmakingConfigurationTypes.GameProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGameProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MatchmakingConfigurationFactory, T3, InnerMatchmakingConfigurationGamePropertyFactory> WithGameProperties<T1, T2, T3>(this CombinedResult<T1, T2, MatchmakingConfigurationFactory, T3> combinedResult, Action<Humidifier.GameLift.MatchmakingConfigurationTypes.GameProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGameProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MatchmakingConfigurationFactory, InnerMatchmakingConfigurationGamePropertyFactory> WithGameProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, MatchmakingConfigurationFactory> combinedResult, Action<Humidifier.GameLift.MatchmakingConfigurationTypes.GameProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGameProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<MatchmakingConfigurationFactory, T1, T2, T3, T4, InnerMatchmakingConfigurationGamePropertyFactory> WithGameProperties<T1, T2, T3, T4>(this CombinedResult<MatchmakingConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GameLift.MatchmakingConfigurationTypes.GameProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGameProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MatchmakingConfigurationFactory, T2, T3, T4, InnerMatchmakingConfigurationGamePropertyFactory> WithGameProperties<T1, T2, T3, T4>(this CombinedResult<T1, MatchmakingConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.GameLift.MatchmakingConfigurationTypes.GameProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGameProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MatchmakingConfigurationFactory, T3, T4, InnerMatchmakingConfigurationGamePropertyFactory> WithGameProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, MatchmakingConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.GameLift.MatchmakingConfigurationTypes.GameProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGameProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MatchmakingConfigurationFactory, T4, InnerMatchmakingConfigurationGamePropertyFactory> WithGameProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MatchmakingConfigurationFactory, T4> combinedResult, Action<Humidifier.GameLift.MatchmakingConfigurationTypes.GameProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGameProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, MatchmakingConfigurationFactory, InnerMatchmakingConfigurationGamePropertyFactory> WithGameProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MatchmakingConfigurationFactory> combinedResult, Action<Humidifier.GameLift.MatchmakingConfigurationTypes.GameProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGameProperties(combinedResult.T5, subFactoryAction));
}
