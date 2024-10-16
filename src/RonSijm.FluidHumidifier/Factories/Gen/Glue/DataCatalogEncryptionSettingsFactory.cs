// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class DataCatalogEncryptionSettingsFactory(string resourceName = null, Action<Humidifier.Glue.DataCatalogEncryptionSettings> factoryAction = null) : ResourceFactory<Humidifier.Glue.DataCatalogEncryptionSettings>(resourceName)
{

    internal InnerDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsFactory DataCatalogEncryptionSettings_Factory { get; set; }

    protected override Humidifier.Glue.DataCatalogEncryptionSettings Create()
    {
        var dataCatalogEncryptionSettingsResult = CreateDataCatalogEncryptionSettings();
        factoryAction?.Invoke(dataCatalogEncryptionSettingsResult);

        return dataCatalogEncryptionSettingsResult;
    }

    private Humidifier.Glue.DataCatalogEncryptionSettings CreateDataCatalogEncryptionSettings()
    {
        var dataCatalogEncryptionSettingsResult = new Humidifier.Glue.DataCatalogEncryptionSettings
        {
            GivenName = InputResourceName,
        };

        return dataCatalogEncryptionSettingsResult;
    }
    public override void CreateChildren(Humidifier.Glue.DataCatalogEncryptionSettings result)
    {
        base.CreateChildren(result);

        result.DataCatalogEncryptionSettings_ ??= DataCatalogEncryptionSettings_Factory?.Build();
    }

} // End Of Class

public static class DataCatalogEncryptionSettingsFactoryExtensions
{
    public static CombinedResult<DataCatalogEncryptionSettingsFactory, InnerDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsFactory> WithDataCatalogEncryptionSettings_(this DataCatalogEncryptionSettingsFactory parentFactory, Action<Humidifier.Glue.DataCatalogEncryptionSettingsTypes.DataCatalogEncryptionSettings> subFactoryAction = null)
    {
        parentFactory.DataCatalogEncryptionSettings_Factory = new InnerDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DataCatalogEncryptionSettings_Factory);
    }

    public static CombinedResult<DataCatalogEncryptionSettingsFactory, T1, InnerDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsFactory> WithDataCatalogEncryptionSettings_<T1>(this CombinedResult<DataCatalogEncryptionSettingsFactory, T1> combinedResult, Action<Humidifier.Glue.DataCatalogEncryptionSettingsTypes.DataCatalogEncryptionSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataCatalogEncryptionSettings_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataCatalogEncryptionSettingsFactory, InnerDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsFactory> WithDataCatalogEncryptionSettings_<T1>(this CombinedResult<T1, DataCatalogEncryptionSettingsFactory> combinedResult, Action<Humidifier.Glue.DataCatalogEncryptionSettingsTypes.DataCatalogEncryptionSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataCatalogEncryptionSettings_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DataCatalogEncryptionSettingsFactory, T1, T2, InnerDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsFactory> WithDataCatalogEncryptionSettings_<T1, T2>(this CombinedResult<DataCatalogEncryptionSettingsFactory, T1, T2> combinedResult, Action<Humidifier.Glue.DataCatalogEncryptionSettingsTypes.DataCatalogEncryptionSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataCatalogEncryptionSettings_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataCatalogEncryptionSettingsFactory, T2, InnerDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsFactory> WithDataCatalogEncryptionSettings_<T1, T2>(this CombinedResult<T1, DataCatalogEncryptionSettingsFactory, T2> combinedResult, Action<Humidifier.Glue.DataCatalogEncryptionSettingsTypes.DataCatalogEncryptionSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataCatalogEncryptionSettings_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataCatalogEncryptionSettingsFactory, InnerDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsFactory> WithDataCatalogEncryptionSettings_<T1, T2>(this CombinedResult<T1, T2, DataCatalogEncryptionSettingsFactory> combinedResult, Action<Humidifier.Glue.DataCatalogEncryptionSettingsTypes.DataCatalogEncryptionSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataCatalogEncryptionSettings_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DataCatalogEncryptionSettingsFactory, T1, T2, T3, InnerDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsFactory> WithDataCatalogEncryptionSettings_<T1, T2, T3>(this CombinedResult<DataCatalogEncryptionSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.DataCatalogEncryptionSettingsTypes.DataCatalogEncryptionSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataCatalogEncryptionSettings_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataCatalogEncryptionSettingsFactory, T2, T3, InnerDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsFactory> WithDataCatalogEncryptionSettings_<T1, T2, T3>(this CombinedResult<T1, DataCatalogEncryptionSettingsFactory, T2, T3> combinedResult, Action<Humidifier.Glue.DataCatalogEncryptionSettingsTypes.DataCatalogEncryptionSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataCatalogEncryptionSettings_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataCatalogEncryptionSettingsFactory, T3, InnerDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsFactory> WithDataCatalogEncryptionSettings_<T1, T2, T3>(this CombinedResult<T1, T2, DataCatalogEncryptionSettingsFactory, T3> combinedResult, Action<Humidifier.Glue.DataCatalogEncryptionSettingsTypes.DataCatalogEncryptionSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataCatalogEncryptionSettings_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataCatalogEncryptionSettingsFactory, InnerDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsFactory> WithDataCatalogEncryptionSettings_<T1, T2, T3>(this CombinedResult<T1, T2, T3, DataCatalogEncryptionSettingsFactory> combinedResult, Action<Humidifier.Glue.DataCatalogEncryptionSettingsTypes.DataCatalogEncryptionSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataCatalogEncryptionSettings_(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DataCatalogEncryptionSettingsFactory, T1, T2, T3, T4, InnerDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsFactory> WithDataCatalogEncryptionSettings_<T1, T2, T3, T4>(this CombinedResult<DataCatalogEncryptionSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.DataCatalogEncryptionSettingsTypes.DataCatalogEncryptionSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataCatalogEncryptionSettings_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataCatalogEncryptionSettingsFactory, T2, T3, T4, InnerDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsFactory> WithDataCatalogEncryptionSettings_<T1, T2, T3, T4>(this CombinedResult<T1, DataCatalogEncryptionSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.DataCatalogEncryptionSettingsTypes.DataCatalogEncryptionSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataCatalogEncryptionSettings_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataCatalogEncryptionSettingsFactory, T3, T4, InnerDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsFactory> WithDataCatalogEncryptionSettings_<T1, T2, T3, T4>(this CombinedResult<T1, T2, DataCatalogEncryptionSettingsFactory, T3, T4> combinedResult, Action<Humidifier.Glue.DataCatalogEncryptionSettingsTypes.DataCatalogEncryptionSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataCatalogEncryptionSettings_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataCatalogEncryptionSettingsFactory, T4, InnerDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsFactory> WithDataCatalogEncryptionSettings_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DataCatalogEncryptionSettingsFactory, T4> combinedResult, Action<Humidifier.Glue.DataCatalogEncryptionSettingsTypes.DataCatalogEncryptionSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataCatalogEncryptionSettings_(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DataCatalogEncryptionSettingsFactory, InnerDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsFactory> WithDataCatalogEncryptionSettings_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DataCatalogEncryptionSettingsFactory> combinedResult, Action<Humidifier.Glue.DataCatalogEncryptionSettingsTypes.DataCatalogEncryptionSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataCatalogEncryptionSettings_(combinedResult.T5, subFactoryAction));
}
