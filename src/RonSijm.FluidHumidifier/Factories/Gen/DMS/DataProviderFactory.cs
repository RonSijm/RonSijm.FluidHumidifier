// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class DataProviderFactory(string resourceName = null, Action<Humidifier.DMS.DataProvider> factoryAction = null) : ResourceFactory<Humidifier.DMS.DataProvider>(resourceName)
{

    internal InnerDataProviderSettingsFactory SettingsFactory { get; set; }

    protected override Humidifier.DMS.DataProvider Create()
    {
        var dataProviderResult = CreateDataProvider();
        factoryAction?.Invoke(dataProviderResult);

        return dataProviderResult;
    }

    private Humidifier.DMS.DataProvider CreateDataProvider()
    {
        var dataProviderResult = new Humidifier.DMS.DataProvider
        {
            GivenName = InputResourceName,
        };

        return dataProviderResult;
    }
    public override void CreateChildren(Humidifier.DMS.DataProvider result)
    {
        base.CreateChildren(result);

        result.Settings ??= SettingsFactory?.Build();
    }

} // End Of Class

public static class DataProviderFactoryExtensions
{
    public static CombinedResult<DataProviderFactory, InnerDataProviderSettingsFactory> WithSettings(this DataProviderFactory parentFactory, Action<Humidifier.DMS.DataProviderTypes.Settings> subFactoryAction = null)
    {
        parentFactory.SettingsFactory = new InnerDataProviderSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SettingsFactory);
    }

    public static CombinedResult<DataProviderFactory, T1, InnerDataProviderSettingsFactory> WithSettings<T1>(this CombinedResult<DataProviderFactory, T1> combinedResult, Action<Humidifier.DMS.DataProviderTypes.Settings> subFactoryAction = null) => new (combinedResult, combinedResult, WithSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataProviderFactory, InnerDataProviderSettingsFactory> WithSettings<T1>(this CombinedResult<T1, DataProviderFactory> combinedResult, Action<Humidifier.DMS.DataProviderTypes.Settings> subFactoryAction = null) => new (combinedResult, combinedResult, WithSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DataProviderFactory, T1, T2, InnerDataProviderSettingsFactory> WithSettings<T1, T2>(this CombinedResult<DataProviderFactory, T1, T2> combinedResult, Action<Humidifier.DMS.DataProviderTypes.Settings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataProviderFactory, T2, InnerDataProviderSettingsFactory> WithSettings<T1, T2>(this CombinedResult<T1, DataProviderFactory, T2> combinedResult, Action<Humidifier.DMS.DataProviderTypes.Settings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataProviderFactory, InnerDataProviderSettingsFactory> WithSettings<T1, T2>(this CombinedResult<T1, T2, DataProviderFactory> combinedResult, Action<Humidifier.DMS.DataProviderTypes.Settings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DataProviderFactory, T1, T2, T3, InnerDataProviderSettingsFactory> WithSettings<T1, T2, T3>(this CombinedResult<DataProviderFactory, T1, T2, T3> combinedResult, Action<Humidifier.DMS.DataProviderTypes.Settings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataProviderFactory, T2, T3, InnerDataProviderSettingsFactory> WithSettings<T1, T2, T3>(this CombinedResult<T1, DataProviderFactory, T2, T3> combinedResult, Action<Humidifier.DMS.DataProviderTypes.Settings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataProviderFactory, T3, InnerDataProviderSettingsFactory> WithSettings<T1, T2, T3>(this CombinedResult<T1, T2, DataProviderFactory, T3> combinedResult, Action<Humidifier.DMS.DataProviderTypes.Settings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataProviderFactory, InnerDataProviderSettingsFactory> WithSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, DataProviderFactory> combinedResult, Action<Humidifier.DMS.DataProviderTypes.Settings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DataProviderFactory, T1, T2, T3, T4, InnerDataProviderSettingsFactory> WithSettings<T1, T2, T3, T4>(this CombinedResult<DataProviderFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DMS.DataProviderTypes.Settings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataProviderFactory, T2, T3, T4, InnerDataProviderSettingsFactory> WithSettings<T1, T2, T3, T4>(this CombinedResult<T1, DataProviderFactory, T2, T3, T4> combinedResult, Action<Humidifier.DMS.DataProviderTypes.Settings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataProviderFactory, T3, T4, InnerDataProviderSettingsFactory> WithSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, DataProviderFactory, T3, T4> combinedResult, Action<Humidifier.DMS.DataProviderTypes.Settings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataProviderFactory, T4, InnerDataProviderSettingsFactory> WithSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DataProviderFactory, T4> combinedResult, Action<Humidifier.DMS.DataProviderTypes.Settings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DataProviderFactory, InnerDataProviderSettingsFactory> WithSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DataProviderFactory> combinedResult, Action<Humidifier.DMS.DataProviderTypes.Settings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSettings(combinedResult.T5, subFactoryAction));
}
