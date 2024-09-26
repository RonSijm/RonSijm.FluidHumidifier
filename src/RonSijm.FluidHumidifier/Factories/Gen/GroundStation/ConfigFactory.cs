// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class ConfigFactory(string resourceName = null, Action<Humidifier.GroundStation.Config> factoryAction = null) : ResourceFactory<Humidifier.GroundStation.Config>(resourceName)
{

    internal InnerConfigConfigDataFactory ConfigDataFactory { get; set; }

    protected override Humidifier.GroundStation.Config Create()
    {
        var configResult = CreateConfig();
        factoryAction?.Invoke(configResult);

        return configResult;
    }

    private Humidifier.GroundStation.Config CreateConfig()
    {
        var configResult = new Humidifier.GroundStation.Config
        {
            GivenName = InputResourceName,
        };

        return configResult;
    }
    public override void CreateChildren(Humidifier.GroundStation.Config result)
    {
        base.CreateChildren(result);

        result.ConfigData ??= ConfigDataFactory?.Build();
    }

} // End Of Class

public static class ConfigFactoryExtensions
{
    public static CombinedResult<ConfigFactory, InnerConfigConfigDataFactory> WithConfigData(this ConfigFactory parentFactory, Action<Humidifier.GroundStation.ConfigTypes.ConfigData> subFactoryAction = null)
    {
        parentFactory.ConfigDataFactory = new InnerConfigConfigDataFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigDataFactory);
    }

    public static CombinedResult<ConfigFactory, T1, InnerConfigConfigDataFactory> WithConfigData<T1>(this CombinedResult<ConfigFactory, T1> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.ConfigData> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfigData(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigFactory, InnerConfigConfigDataFactory> WithConfigData<T1>(this CombinedResult<T1, ConfigFactory> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.ConfigData> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfigData(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ConfigFactory, T1, T2, InnerConfigConfigDataFactory> WithConfigData<T1, T2>(this CombinedResult<ConfigFactory, T1, T2> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.ConfigData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigData(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigFactory, T2, InnerConfigConfigDataFactory> WithConfigData<T1, T2>(this CombinedResult<T1, ConfigFactory, T2> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.ConfigData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigData(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigFactory, InnerConfigConfigDataFactory> WithConfigData<T1, T2>(this CombinedResult<T1, T2, ConfigFactory> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.ConfigData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigData(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ConfigFactory, T1, T2, T3, InnerConfigConfigDataFactory> WithConfigData<T1, T2, T3>(this CombinedResult<ConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.ConfigData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigData(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigFactory, T2, T3, InnerConfigConfigDataFactory> WithConfigData<T1, T2, T3>(this CombinedResult<T1, ConfigFactory, T2, T3> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.ConfigData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigData(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigFactory, T3, InnerConfigConfigDataFactory> WithConfigData<T1, T2, T3>(this CombinedResult<T1, T2, ConfigFactory, T3> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.ConfigData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigData(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfigFactory, InnerConfigConfigDataFactory> WithConfigData<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConfigFactory> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.ConfigData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigData(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ConfigFactory, T1, T2, T3, T4, InnerConfigConfigDataFactory> WithConfigData<T1, T2, T3, T4>(this CombinedResult<ConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.ConfigData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigData(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigFactory, T2, T3, T4, InnerConfigConfigDataFactory> WithConfigData<T1, T2, T3, T4>(this CombinedResult<T1, ConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.ConfigData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigData(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigFactory, T3, T4, InnerConfigConfigDataFactory> WithConfigData<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConfigFactory, T3, T4> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.ConfigData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigData(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfigFactory, T4, InnerConfigConfigDataFactory> WithConfigData<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConfigFactory, T4> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.ConfigData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigData(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ConfigFactory, InnerConfigConfigDataFactory> WithConfigData<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConfigFactory> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.ConfigData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigData(combinedResult.T5, subFactoryAction));
}
