// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Location;

public class PlaceIndexFactory(string resourceName = null, Action<Humidifier.Location.PlaceIndex> factoryAction = null) : ResourceFactory<Humidifier.Location.PlaceIndex>(resourceName)
{

    internal InnerPlaceIndexDataSourceConfigurationFactory DataSourceConfigurationFactory { get; set; }

    protected override Humidifier.Location.PlaceIndex Create()
    {
        var placeIndexResult = CreatePlaceIndex();
        factoryAction?.Invoke(placeIndexResult);

        return placeIndexResult;
    }

    private Humidifier.Location.PlaceIndex CreatePlaceIndex()
    {
        var placeIndexResult = new Humidifier.Location.PlaceIndex
        {
            GivenName = InputResourceName,
        };

        return placeIndexResult;
    }
    public override void CreateChildren(Humidifier.Location.PlaceIndex result)
    {
        base.CreateChildren(result);

        result.DataSourceConfiguration ??= DataSourceConfigurationFactory?.Build();
    }

} // End Of Class

public static class PlaceIndexFactoryExtensions
{
    public static CombinedResult<PlaceIndexFactory, InnerPlaceIndexDataSourceConfigurationFactory> WithDataSourceConfiguration(this PlaceIndexFactory parentFactory, Action<Humidifier.Location.PlaceIndexTypes.DataSourceConfiguration> subFactoryAction = null)
    {
        parentFactory.DataSourceConfigurationFactory = new InnerPlaceIndexDataSourceConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DataSourceConfigurationFactory);
    }

    public static CombinedResult<PlaceIndexFactory, T1, InnerPlaceIndexDataSourceConfigurationFactory> WithDataSourceConfiguration<T1>(this CombinedResult<PlaceIndexFactory, T1> combinedResult, Action<Humidifier.Location.PlaceIndexTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PlaceIndexFactory, InnerPlaceIndexDataSourceConfigurationFactory> WithDataSourceConfiguration<T1>(this CombinedResult<T1, PlaceIndexFactory> combinedResult, Action<Humidifier.Location.PlaceIndexTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PlaceIndexFactory, T1, T2, InnerPlaceIndexDataSourceConfigurationFactory> WithDataSourceConfiguration<T1, T2>(this CombinedResult<PlaceIndexFactory, T1, T2> combinedResult, Action<Humidifier.Location.PlaceIndexTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PlaceIndexFactory, T2, InnerPlaceIndexDataSourceConfigurationFactory> WithDataSourceConfiguration<T1, T2>(this CombinedResult<T1, PlaceIndexFactory, T2> combinedResult, Action<Humidifier.Location.PlaceIndexTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PlaceIndexFactory, InnerPlaceIndexDataSourceConfigurationFactory> WithDataSourceConfiguration<T1, T2>(this CombinedResult<T1, T2, PlaceIndexFactory> combinedResult, Action<Humidifier.Location.PlaceIndexTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PlaceIndexFactory, T1, T2, T3, InnerPlaceIndexDataSourceConfigurationFactory> WithDataSourceConfiguration<T1, T2, T3>(this CombinedResult<PlaceIndexFactory, T1, T2, T3> combinedResult, Action<Humidifier.Location.PlaceIndexTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PlaceIndexFactory, T2, T3, InnerPlaceIndexDataSourceConfigurationFactory> WithDataSourceConfiguration<T1, T2, T3>(this CombinedResult<T1, PlaceIndexFactory, T2, T3> combinedResult, Action<Humidifier.Location.PlaceIndexTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PlaceIndexFactory, T3, InnerPlaceIndexDataSourceConfigurationFactory> WithDataSourceConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, PlaceIndexFactory, T3> combinedResult, Action<Humidifier.Location.PlaceIndexTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PlaceIndexFactory, InnerPlaceIndexDataSourceConfigurationFactory> WithDataSourceConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, PlaceIndexFactory> combinedResult, Action<Humidifier.Location.PlaceIndexTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PlaceIndexFactory, T1, T2, T3, T4, InnerPlaceIndexDataSourceConfigurationFactory> WithDataSourceConfiguration<T1, T2, T3, T4>(this CombinedResult<PlaceIndexFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Location.PlaceIndexTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PlaceIndexFactory, T2, T3, T4, InnerPlaceIndexDataSourceConfigurationFactory> WithDataSourceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, PlaceIndexFactory, T2, T3, T4> combinedResult, Action<Humidifier.Location.PlaceIndexTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PlaceIndexFactory, T3, T4, InnerPlaceIndexDataSourceConfigurationFactory> WithDataSourceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, PlaceIndexFactory, T3, T4> combinedResult, Action<Humidifier.Location.PlaceIndexTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PlaceIndexFactory, T4, InnerPlaceIndexDataSourceConfigurationFactory> WithDataSourceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PlaceIndexFactory, T4> combinedResult, Action<Humidifier.Location.PlaceIndexTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PlaceIndexFactory, InnerPlaceIndexDataSourceConfigurationFactory> WithDataSourceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PlaceIndexFactory> combinedResult, Action<Humidifier.Location.PlaceIndexTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T5, subFactoryAction));
}
