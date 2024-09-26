// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Location;

public class MapFactory(string resourceName = null, Action<Humidifier.Location.Map> factoryAction = null) : ResourceFactory<Humidifier.Location.Map>(resourceName)
{

    internal InnerMapMapConfigurationFactory ConfigurationFactory { get; set; }

    protected override Humidifier.Location.Map Create()
    {
        var mapResult = CreateMap();
        factoryAction?.Invoke(mapResult);

        return mapResult;
    }

    private Humidifier.Location.Map CreateMap()
    {
        var mapResult = new Humidifier.Location.Map
        {
            GivenName = InputResourceName,
        };

        return mapResult;
    }
    public override void CreateChildren(Humidifier.Location.Map result)
    {
        base.CreateChildren(result);

        result.Configuration ??= ConfigurationFactory?.Build();
    }

} // End Of Class

public static class MapFactoryExtensions
{
    public static CombinedResult<MapFactory, InnerMapMapConfigurationFactory> WithConfiguration(this MapFactory parentFactory, Action<Humidifier.Location.MapTypes.MapConfiguration> subFactoryAction = null)
    {
        parentFactory.ConfigurationFactory = new InnerMapMapConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigurationFactory);
    }

    public static CombinedResult<MapFactory, T1, InnerMapMapConfigurationFactory> WithConfiguration<T1>(this CombinedResult<MapFactory, T1> combinedResult, Action<Humidifier.Location.MapTypes.MapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MapFactory, InnerMapMapConfigurationFactory> WithConfiguration<T1>(this CombinedResult<T1, MapFactory> combinedResult, Action<Humidifier.Location.MapTypes.MapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<MapFactory, T1, T2, InnerMapMapConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<MapFactory, T1, T2> combinedResult, Action<Humidifier.Location.MapTypes.MapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MapFactory, T2, InnerMapMapConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, MapFactory, T2> combinedResult, Action<Humidifier.Location.MapTypes.MapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MapFactory, InnerMapMapConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, T2, MapFactory> combinedResult, Action<Humidifier.Location.MapTypes.MapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<MapFactory, T1, T2, T3, InnerMapMapConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<MapFactory, T1, T2, T3> combinedResult, Action<Humidifier.Location.MapTypes.MapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MapFactory, T2, T3, InnerMapMapConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, MapFactory, T2, T3> combinedResult, Action<Humidifier.Location.MapTypes.MapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MapFactory, T3, InnerMapMapConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, MapFactory, T3> combinedResult, Action<Humidifier.Location.MapTypes.MapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MapFactory, InnerMapMapConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, MapFactory> combinedResult, Action<Humidifier.Location.MapTypes.MapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<MapFactory, T1, T2, T3, T4, InnerMapMapConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<MapFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Location.MapTypes.MapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MapFactory, T2, T3, T4, InnerMapMapConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, MapFactory, T2, T3, T4> combinedResult, Action<Humidifier.Location.MapTypes.MapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MapFactory, T3, T4, InnerMapMapConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, MapFactory, T3, T4> combinedResult, Action<Humidifier.Location.MapTypes.MapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MapFactory, T4, InnerMapMapConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MapFactory, T4> combinedResult, Action<Humidifier.Location.MapTypes.MapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, MapFactory, InnerMapMapConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MapFactory> combinedResult, Action<Humidifier.Location.MapTypes.MapConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T5, subFactoryAction));
}
