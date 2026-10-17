// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerDataTableRecordDataTableRecordFactory(Action<Humidifier.Connect.DataTableRecordTypes.DataTableRecord> factoryAction = null) : SubResourceFactory<Humidifier.Connect.DataTableRecordTypes.DataTableRecord>
{

    internal List<InnerDataTableRecordValueFactory> PrimaryValuesFactories { get; set; } = [];

    internal List<InnerDataTableRecordValueFactory> ValuesFactories { get; set; } = [];

    protected override Humidifier.Connect.DataTableRecordTypes.DataTableRecord Create()
    {
        var dataTableRecordResult = CreateDataTableRecord();
        factoryAction?.Invoke(dataTableRecordResult);

        return dataTableRecordResult;
    }

    private Humidifier.Connect.DataTableRecordTypes.DataTableRecord CreateDataTableRecord()
    {
        var dataTableRecordResult = new Humidifier.Connect.DataTableRecordTypes.DataTableRecord();

        return dataTableRecordResult;
    }
    public override void CreateChildren(Humidifier.Connect.DataTableRecordTypes.DataTableRecord result)
    {
        base.CreateChildren(result);

        result.PrimaryValues = PrimaryValuesFactories.Any() ? PrimaryValuesFactories.Select(x => x.Build()).ToList() : null;
        result.Values = ValuesFactories.Any() ? ValuesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class InnerDataTableRecordDataTableRecordFactoryExtensions
{
    public static CombinedResult<InnerDataTableRecordDataTableRecordFactory, InnerDataTableRecordValueFactory> WithPrimaryValues(this InnerDataTableRecordDataTableRecordFactory parentFactory, Action<Humidifier.Connect.DataTableRecordTypes.Value> subFactoryAction = null)
    {
        var factory = new InnerDataTableRecordValueFactory(subFactoryAction);
        parentFactory.PrimaryValuesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<InnerDataTableRecordDataTableRecordFactory, InnerDataTableRecordValueFactory> WithValues(this InnerDataTableRecordDataTableRecordFactory parentFactory, Action<Humidifier.Connect.DataTableRecordTypes.Value> subFactoryAction = null)
    {
        var factory = new InnerDataTableRecordValueFactory(subFactoryAction);
        parentFactory.ValuesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<InnerDataTableRecordDataTableRecordFactory, T1, InnerDataTableRecordValueFactory> WithPrimaryValues<T1>(this CombinedResult<InnerDataTableRecordDataTableRecordFactory, T1> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.Value> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrimaryValues(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataTableRecordDataTableRecordFactory, InnerDataTableRecordValueFactory> WithPrimaryValues<T1>(this CombinedResult<T1, InnerDataTableRecordDataTableRecordFactory> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.Value> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrimaryValues(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDataTableRecordDataTableRecordFactory, T1, T2, InnerDataTableRecordValueFactory> WithPrimaryValues<T1, T2>(this CombinedResult<InnerDataTableRecordDataTableRecordFactory, T1, T2> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.Value> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrimaryValues(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataTableRecordDataTableRecordFactory, T2, InnerDataTableRecordValueFactory> WithPrimaryValues<T1, T2>(this CombinedResult<T1, InnerDataTableRecordDataTableRecordFactory, T2> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.Value> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrimaryValues(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataTableRecordDataTableRecordFactory, InnerDataTableRecordValueFactory> WithPrimaryValues<T1, T2>(this CombinedResult<T1, T2, InnerDataTableRecordDataTableRecordFactory> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.Value> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrimaryValues(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDataTableRecordDataTableRecordFactory, T1, T2, T3, InnerDataTableRecordValueFactory> WithPrimaryValues<T1, T2, T3>(this CombinedResult<InnerDataTableRecordDataTableRecordFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.Value> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrimaryValues(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataTableRecordDataTableRecordFactory, T2, T3, InnerDataTableRecordValueFactory> WithPrimaryValues<T1, T2, T3>(this CombinedResult<T1, InnerDataTableRecordDataTableRecordFactory, T2, T3> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.Value> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrimaryValues(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataTableRecordDataTableRecordFactory, T3, InnerDataTableRecordValueFactory> WithPrimaryValues<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataTableRecordDataTableRecordFactory, T3> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.Value> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrimaryValues(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataTableRecordDataTableRecordFactory, InnerDataTableRecordValueFactory> WithPrimaryValues<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataTableRecordDataTableRecordFactory> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.Value> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrimaryValues(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDataTableRecordDataTableRecordFactory, T1, T2, T3, T4, InnerDataTableRecordValueFactory> WithPrimaryValues<T1, T2, T3, T4>(this CombinedResult<InnerDataTableRecordDataTableRecordFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.Value> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrimaryValues(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataTableRecordDataTableRecordFactory, T2, T3, T4, InnerDataTableRecordValueFactory> WithPrimaryValues<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataTableRecordDataTableRecordFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.Value> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrimaryValues(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataTableRecordDataTableRecordFactory, T3, T4, InnerDataTableRecordValueFactory> WithPrimaryValues<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataTableRecordDataTableRecordFactory, T3, T4> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.Value> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrimaryValues(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataTableRecordDataTableRecordFactory, T4, InnerDataTableRecordValueFactory> WithPrimaryValues<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataTableRecordDataTableRecordFactory, T4> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.Value> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrimaryValues(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDataTableRecordDataTableRecordFactory, InnerDataTableRecordValueFactory> WithPrimaryValues<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataTableRecordDataTableRecordFactory> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.Value> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrimaryValues(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerDataTableRecordDataTableRecordFactory, T1, InnerDataTableRecordValueFactory> WithValues<T1>(this CombinedResult<InnerDataTableRecordDataTableRecordFactory, T1> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.Value> subFactoryAction = null) => new (combinedResult, combinedResult, WithValues(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataTableRecordDataTableRecordFactory, InnerDataTableRecordValueFactory> WithValues<T1>(this CombinedResult<T1, InnerDataTableRecordDataTableRecordFactory> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.Value> subFactoryAction = null) => new (combinedResult, combinedResult, WithValues(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDataTableRecordDataTableRecordFactory, T1, T2, InnerDataTableRecordValueFactory> WithValues<T1, T2>(this CombinedResult<InnerDataTableRecordDataTableRecordFactory, T1, T2> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.Value> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValues(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataTableRecordDataTableRecordFactory, T2, InnerDataTableRecordValueFactory> WithValues<T1, T2>(this CombinedResult<T1, InnerDataTableRecordDataTableRecordFactory, T2> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.Value> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValues(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataTableRecordDataTableRecordFactory, InnerDataTableRecordValueFactory> WithValues<T1, T2>(this CombinedResult<T1, T2, InnerDataTableRecordDataTableRecordFactory> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.Value> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValues(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDataTableRecordDataTableRecordFactory, T1, T2, T3, InnerDataTableRecordValueFactory> WithValues<T1, T2, T3>(this CombinedResult<InnerDataTableRecordDataTableRecordFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.Value> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValues(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataTableRecordDataTableRecordFactory, T2, T3, InnerDataTableRecordValueFactory> WithValues<T1, T2, T3>(this CombinedResult<T1, InnerDataTableRecordDataTableRecordFactory, T2, T3> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.Value> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValues(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataTableRecordDataTableRecordFactory, T3, InnerDataTableRecordValueFactory> WithValues<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataTableRecordDataTableRecordFactory, T3> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.Value> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValues(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataTableRecordDataTableRecordFactory, InnerDataTableRecordValueFactory> WithValues<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataTableRecordDataTableRecordFactory> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.Value> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValues(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDataTableRecordDataTableRecordFactory, T1, T2, T3, T4, InnerDataTableRecordValueFactory> WithValues<T1, T2, T3, T4>(this CombinedResult<InnerDataTableRecordDataTableRecordFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.Value> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValues(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataTableRecordDataTableRecordFactory, T2, T3, T4, InnerDataTableRecordValueFactory> WithValues<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataTableRecordDataTableRecordFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.Value> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValues(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataTableRecordDataTableRecordFactory, T3, T4, InnerDataTableRecordValueFactory> WithValues<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataTableRecordDataTableRecordFactory, T3, T4> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.Value> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValues(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataTableRecordDataTableRecordFactory, T4, InnerDataTableRecordValueFactory> WithValues<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataTableRecordDataTableRecordFactory, T4> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.Value> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValues(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDataTableRecordDataTableRecordFactory, InnerDataTableRecordValueFactory> WithValues<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataTableRecordDataTableRecordFactory> combinedResult, Action<Humidifier.Connect.DataTableRecordTypes.Value> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValues(combinedResult.T5, subFactoryAction).T2);
}
