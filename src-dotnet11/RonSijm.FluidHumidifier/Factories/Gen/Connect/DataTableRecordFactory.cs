// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class DataTableRecordFactory(string resourceName = null, Action<Humidifier.Connect.DataTableRecord> factoryAction = null) : ResourceFactory<Humidifier.Connect.DataTableRecord>(resourceName)
{

    internal InnerDataTableRecordDataTableRecordFactory DataTableRecord_Factory { get; set; }

    protected override Humidifier.Connect.DataTableRecord Create()
    {
        var dataTableRecordResult = CreateDataTableRecord();
        factoryAction?.Invoke(dataTableRecordResult);

        return dataTableRecordResult;
    }

    private Humidifier.Connect.DataTableRecord CreateDataTableRecord()
    {
        var dataTableRecordResult = new Humidifier.Connect.DataTableRecord
        {
            GivenName = InputResourceName,
        };

        return dataTableRecordResult;
    }
    public override void CreateChildren(Humidifier.Connect.DataTableRecord result)
    {
        base.CreateChildren(result);

        result.DataTableRecord_ ??= DataTableRecord_Factory?.Build();
    }

} // End Of Class

public static class DataTableRecordFactoryExtensions
{
    public static CombinedResult<DataTableRecordFactory, InnerDataTableRecordDataTableRecordFactory> WithDataTableRecord_(this DataTableRecordFactory parentFactory, Action<Humidifier.Connect.DataTableRecordTypes.DataTableRecord> subFactoryAction = null)
    {
        parentFactory.DataTableRecord_Factory = new InnerDataTableRecordDataTableRecordFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DataTableRecord_Factory);
    }

    public static CombinedResult<DataTableRecordFactory, T1, InnerDataTableRecordDataTableRecordFactory> WithDataTableRecord_<T1>(this CombinedResult<DataTableRecordFactory, T1> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.DataTableRecord> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataTableRecord_(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DataTableRecordFactory, InnerDataTableRecordDataTableRecordFactory> WithDataTableRecord_<T1>(this CombinedResult<T1, DataTableRecordFactory> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.DataTableRecord> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataTableRecord_(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<DataTableRecordFactory, T1, T2, InnerDataTableRecordDataTableRecordFactory> WithDataTableRecord_<T1, T2>(this CombinedResult<DataTableRecordFactory, T1, T2> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.DataTableRecord> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataTableRecord_(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DataTableRecordFactory, T2, InnerDataTableRecordDataTableRecordFactory> WithDataTableRecord_<T1, T2>(this CombinedResult<T1, DataTableRecordFactory, T2> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.DataTableRecord> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataTableRecord_(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DataTableRecordFactory, InnerDataTableRecordDataTableRecordFactory> WithDataTableRecord_<T1, T2>(this CombinedResult<T1, T2, DataTableRecordFactory> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.DataTableRecord> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataTableRecord_(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<DataTableRecordFactory, T1, T2, T3, InnerDataTableRecordDataTableRecordFactory> WithDataTableRecord_<T1, T2, T3>(this CombinedResult<DataTableRecordFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.DataTableRecord> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataTableRecord_(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DataTableRecordFactory, T2, T3, InnerDataTableRecordDataTableRecordFactory> WithDataTableRecord_<T1, T2, T3>(this CombinedResult<T1, DataTableRecordFactory, T2, T3> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.DataTableRecord> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataTableRecord_(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DataTableRecordFactory, T3, InnerDataTableRecordDataTableRecordFactory> WithDataTableRecord_<T1, T2, T3>(this CombinedResult<T1, T2, DataTableRecordFactory, T3> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.DataTableRecord> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataTableRecord_(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DataTableRecordFactory, InnerDataTableRecordDataTableRecordFactory> WithDataTableRecord_<T1, T2, T3>(this CombinedResult<T1, T2, T3, DataTableRecordFactory> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.DataTableRecord> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataTableRecord_(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<DataTableRecordFactory, T1, T2, T3, T4, InnerDataTableRecordDataTableRecordFactory> WithDataTableRecord_<T1, T2, T3, T4>(this CombinedResult<DataTableRecordFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.DataTableRecord> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataTableRecord_(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DataTableRecordFactory, T2, T3, T4, InnerDataTableRecordDataTableRecordFactory> WithDataTableRecord_<T1, T2, T3, T4>(this CombinedResult<T1, DataTableRecordFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.DataTableRecord> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataTableRecord_(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DataTableRecordFactory, T3, T4, InnerDataTableRecordDataTableRecordFactory> WithDataTableRecord_<T1, T2, T3, T4>(this CombinedResult<T1, T2, DataTableRecordFactory, T3, T4> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.DataTableRecord> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataTableRecord_(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DataTableRecordFactory, T4, InnerDataTableRecordDataTableRecordFactory> WithDataTableRecord_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DataTableRecordFactory, T4> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.DataTableRecord> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataTableRecord_(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, DataTableRecordFactory, InnerDataTableRecordDataTableRecordFactory> WithDataTableRecord_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DataTableRecordFactory> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.DataTableRecord> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataTableRecord_(combinedResult.T5, subFactoryAction).T2);
}
