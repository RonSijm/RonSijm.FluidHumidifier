// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class DataMigrationFactory(string resourceName = null, Action<Humidifier.DMS.DataMigration> factoryAction = null) : ResourceFactory<Humidifier.DMS.DataMigration>(resourceName)
{

    internal List<InnerDataMigrationSourceDataSettingsFactory> SourceDataSettingsFactories { get; set; } = [];

    internal InnerDataMigrationDataMigrationSettingsFactory DataMigrationSettingsFactory { get; set; }

    protected override Humidifier.DMS.DataMigration Create()
    {
        var dataMigrationResult = CreateDataMigration();
        factoryAction?.Invoke(dataMigrationResult);

        return dataMigrationResult;
    }

    private Humidifier.DMS.DataMigration CreateDataMigration()
    {
        var dataMigrationResult = new Humidifier.DMS.DataMigration
        {
            GivenName = InputResourceName,
        };

        return dataMigrationResult;
    }
    public override void CreateChildren(Humidifier.DMS.DataMigration result)
    {
        base.CreateChildren(result);

        result.SourceDataSettings = SourceDataSettingsFactories.Any() ? SourceDataSettingsFactories.Select(x => x.Build()).ToList() : null;
        result.DataMigrationSettings ??= DataMigrationSettingsFactory?.Build();
    }

} // End Of Class

public static class DataMigrationFactoryExtensions
{
    public static CombinedResult<DataMigrationFactory, InnerDataMigrationSourceDataSettingsFactory> WithSourceDataSettings(this DataMigrationFactory parentFactory, Action<Humidifier.DMS.DataMigrationTypes.SourceDataSettings> subFactoryAction = null)
    {
        var factory = new InnerDataMigrationSourceDataSettingsFactory(subFactoryAction);
        parentFactory.SourceDataSettingsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<DataMigrationFactory, InnerDataMigrationDataMigrationSettingsFactory> WithDataMigrationSettings(this DataMigrationFactory parentFactory, Action<Humidifier.DMS.DataMigrationTypes.DataMigrationSettings> subFactoryAction = null)
    {
        parentFactory.DataMigrationSettingsFactory = new InnerDataMigrationDataMigrationSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DataMigrationSettingsFactory);
    }

    public static CombinedResult<DataMigrationFactory, T1, InnerDataMigrationSourceDataSettingsFactory> WithSourceDataSettings<T1>(this CombinedResult<DataMigrationFactory, T1> combinedResult, Action<Humidifier.DMS.DataMigrationTypes.SourceDataSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceDataSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataMigrationFactory, InnerDataMigrationSourceDataSettingsFactory> WithSourceDataSettings<T1>(this CombinedResult<T1, DataMigrationFactory> combinedResult, Action<Humidifier.DMS.DataMigrationTypes.SourceDataSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceDataSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DataMigrationFactory, T1, T2, InnerDataMigrationSourceDataSettingsFactory> WithSourceDataSettings<T1, T2>(this CombinedResult<DataMigrationFactory, T1, T2> combinedResult, Action<Humidifier.DMS.DataMigrationTypes.SourceDataSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceDataSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataMigrationFactory, T2, InnerDataMigrationSourceDataSettingsFactory> WithSourceDataSettings<T1, T2>(this CombinedResult<T1, DataMigrationFactory, T2> combinedResult, Action<Humidifier.DMS.DataMigrationTypes.SourceDataSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceDataSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataMigrationFactory, InnerDataMigrationSourceDataSettingsFactory> WithSourceDataSettings<T1, T2>(this CombinedResult<T1, T2, DataMigrationFactory> combinedResult, Action<Humidifier.DMS.DataMigrationTypes.SourceDataSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceDataSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DataMigrationFactory, T1, T2, T3, InnerDataMigrationSourceDataSettingsFactory> WithSourceDataSettings<T1, T2, T3>(this CombinedResult<DataMigrationFactory, T1, T2, T3> combinedResult, Action<Humidifier.DMS.DataMigrationTypes.SourceDataSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceDataSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataMigrationFactory, T2, T3, InnerDataMigrationSourceDataSettingsFactory> WithSourceDataSettings<T1, T2, T3>(this CombinedResult<T1, DataMigrationFactory, T2, T3> combinedResult, Action<Humidifier.DMS.DataMigrationTypes.SourceDataSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceDataSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataMigrationFactory, T3, InnerDataMigrationSourceDataSettingsFactory> WithSourceDataSettings<T1, T2, T3>(this CombinedResult<T1, T2, DataMigrationFactory, T3> combinedResult, Action<Humidifier.DMS.DataMigrationTypes.SourceDataSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceDataSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataMigrationFactory, InnerDataMigrationSourceDataSettingsFactory> WithSourceDataSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, DataMigrationFactory> combinedResult, Action<Humidifier.DMS.DataMigrationTypes.SourceDataSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceDataSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DataMigrationFactory, T1, T2, T3, T4, InnerDataMigrationSourceDataSettingsFactory> WithSourceDataSettings<T1, T2, T3, T4>(this CombinedResult<DataMigrationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DMS.DataMigrationTypes.SourceDataSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceDataSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataMigrationFactory, T2, T3, T4, InnerDataMigrationSourceDataSettingsFactory> WithSourceDataSettings<T1, T2, T3, T4>(this CombinedResult<T1, DataMigrationFactory, T2, T3, T4> combinedResult, Action<Humidifier.DMS.DataMigrationTypes.SourceDataSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceDataSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataMigrationFactory, T3, T4, InnerDataMigrationSourceDataSettingsFactory> WithSourceDataSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, DataMigrationFactory, T3, T4> combinedResult, Action<Humidifier.DMS.DataMigrationTypes.SourceDataSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceDataSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataMigrationFactory, T4, InnerDataMigrationSourceDataSettingsFactory> WithSourceDataSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DataMigrationFactory, T4> combinedResult, Action<Humidifier.DMS.DataMigrationTypes.SourceDataSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceDataSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DataMigrationFactory, InnerDataMigrationSourceDataSettingsFactory> WithSourceDataSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DataMigrationFactory> combinedResult, Action<Humidifier.DMS.DataMigrationTypes.SourceDataSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceDataSettings(combinedResult.T5, subFactoryAction));
    public static CombinedResult<DataMigrationFactory, T1, InnerDataMigrationDataMigrationSettingsFactory> WithDataMigrationSettings<T1>(this CombinedResult<DataMigrationFactory, T1> combinedResult, Action<Humidifier.DMS.DataMigrationTypes.DataMigrationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataMigrationSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataMigrationFactory, InnerDataMigrationDataMigrationSettingsFactory> WithDataMigrationSettings<T1>(this CombinedResult<T1, DataMigrationFactory> combinedResult, Action<Humidifier.DMS.DataMigrationTypes.DataMigrationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataMigrationSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DataMigrationFactory, T1, T2, InnerDataMigrationDataMigrationSettingsFactory> WithDataMigrationSettings<T1, T2>(this CombinedResult<DataMigrationFactory, T1, T2> combinedResult, Action<Humidifier.DMS.DataMigrationTypes.DataMigrationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataMigrationSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataMigrationFactory, T2, InnerDataMigrationDataMigrationSettingsFactory> WithDataMigrationSettings<T1, T2>(this CombinedResult<T1, DataMigrationFactory, T2> combinedResult, Action<Humidifier.DMS.DataMigrationTypes.DataMigrationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataMigrationSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataMigrationFactory, InnerDataMigrationDataMigrationSettingsFactory> WithDataMigrationSettings<T1, T2>(this CombinedResult<T1, T2, DataMigrationFactory> combinedResult, Action<Humidifier.DMS.DataMigrationTypes.DataMigrationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataMigrationSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DataMigrationFactory, T1, T2, T3, InnerDataMigrationDataMigrationSettingsFactory> WithDataMigrationSettings<T1, T2, T3>(this CombinedResult<DataMigrationFactory, T1, T2, T3> combinedResult, Action<Humidifier.DMS.DataMigrationTypes.DataMigrationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataMigrationSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataMigrationFactory, T2, T3, InnerDataMigrationDataMigrationSettingsFactory> WithDataMigrationSettings<T1, T2, T3>(this CombinedResult<T1, DataMigrationFactory, T2, T3> combinedResult, Action<Humidifier.DMS.DataMigrationTypes.DataMigrationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataMigrationSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataMigrationFactory, T3, InnerDataMigrationDataMigrationSettingsFactory> WithDataMigrationSettings<T1, T2, T3>(this CombinedResult<T1, T2, DataMigrationFactory, T3> combinedResult, Action<Humidifier.DMS.DataMigrationTypes.DataMigrationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataMigrationSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataMigrationFactory, InnerDataMigrationDataMigrationSettingsFactory> WithDataMigrationSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, DataMigrationFactory> combinedResult, Action<Humidifier.DMS.DataMigrationTypes.DataMigrationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataMigrationSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DataMigrationFactory, T1, T2, T3, T4, InnerDataMigrationDataMigrationSettingsFactory> WithDataMigrationSettings<T1, T2, T3, T4>(this CombinedResult<DataMigrationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DMS.DataMigrationTypes.DataMigrationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataMigrationSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataMigrationFactory, T2, T3, T4, InnerDataMigrationDataMigrationSettingsFactory> WithDataMigrationSettings<T1, T2, T3, T4>(this CombinedResult<T1, DataMigrationFactory, T2, T3, T4> combinedResult, Action<Humidifier.DMS.DataMigrationTypes.DataMigrationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataMigrationSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataMigrationFactory, T3, T4, InnerDataMigrationDataMigrationSettingsFactory> WithDataMigrationSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, DataMigrationFactory, T3, T4> combinedResult, Action<Humidifier.DMS.DataMigrationTypes.DataMigrationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataMigrationSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataMigrationFactory, T4, InnerDataMigrationDataMigrationSettingsFactory> WithDataMigrationSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DataMigrationFactory, T4> combinedResult, Action<Humidifier.DMS.DataMigrationTypes.DataMigrationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataMigrationSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DataMigrationFactory, InnerDataMigrationDataMigrationSettingsFactory> WithDataMigrationSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DataMigrationFactory> combinedResult, Action<Humidifier.DMS.DataMigrationTypes.DataMigrationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataMigrationSettings(combinedResult.T5, subFactoryAction));
}
