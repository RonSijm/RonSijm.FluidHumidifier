// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class TableFactory(string resourceName = null, Action<Humidifier.Glue.Table> factoryAction = null) : ResourceFactory<Humidifier.Glue.Table>(resourceName)
{

    internal InnerTableTableInputFactory TableInputFactory { get; set; }

    internal InnerTableOpenTableFormatInputFactory OpenTableFormatInputFactory { get; set; }

    protected override Humidifier.Glue.Table Create()
    {
        var tableResult = CreateTable();
        factoryAction?.Invoke(tableResult);

        return tableResult;
    }

    private Humidifier.Glue.Table CreateTable()
    {
        var tableResult = new Humidifier.Glue.Table
        {
            GivenName = InputResourceName,
        };

        return tableResult;
    }
    public override void CreateChildren(Humidifier.Glue.Table result)
    {
        base.CreateChildren(result);

        result.TableInput ??= TableInputFactory?.Build();
        result.OpenTableFormatInput ??= OpenTableFormatInputFactory?.Build();
    }

} // End Of Class

public static class TableFactoryExtensions
{
    public static CombinedResult<TableFactory, InnerTableTableInputFactory> WithTableInput(this TableFactory parentFactory, Action<Humidifier.Glue.TableTypes.TableInput> subFactoryAction = null)
    {
        parentFactory.TableInputFactory = new InnerTableTableInputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TableInputFactory);
    }

    public static CombinedResult<TableFactory, InnerTableOpenTableFormatInputFactory> WithOpenTableFormatInput(this TableFactory parentFactory, Action<Humidifier.Glue.TableTypes.OpenTableFormatInput> subFactoryAction = null)
    {
        parentFactory.OpenTableFormatInputFactory = new InnerTableOpenTableFormatInputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OpenTableFormatInputFactory);
    }

    public static CombinedResult<TableFactory, T1, InnerTableTableInputFactory> WithTableInput<T1>(this CombinedResult<TableFactory, T1> combinedResult, Action<Humidifier.Glue.TableTypes.TableInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithTableInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TableFactory, InnerTableTableInputFactory> WithTableInput<T1>(this CombinedResult<T1, TableFactory> combinedResult, Action<Humidifier.Glue.TableTypes.TableInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithTableInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TableFactory, T1, T2, InnerTableTableInputFactory> WithTableInput<T1, T2>(this CombinedResult<TableFactory, T1, T2> combinedResult, Action<Humidifier.Glue.TableTypes.TableInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTableInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TableFactory, T2, InnerTableTableInputFactory> WithTableInput<T1, T2>(this CombinedResult<T1, TableFactory, T2> combinedResult, Action<Humidifier.Glue.TableTypes.TableInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTableInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TableFactory, InnerTableTableInputFactory> WithTableInput<T1, T2>(this CombinedResult<T1, T2, TableFactory> combinedResult, Action<Humidifier.Glue.TableTypes.TableInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTableInput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TableFactory, T1, T2, T3, InnerTableTableInputFactory> WithTableInput<T1, T2, T3>(this CombinedResult<TableFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.TableTypes.TableInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTableInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TableFactory, T2, T3, InnerTableTableInputFactory> WithTableInput<T1, T2, T3>(this CombinedResult<T1, TableFactory, T2, T3> combinedResult, Action<Humidifier.Glue.TableTypes.TableInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTableInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TableFactory, T3, InnerTableTableInputFactory> WithTableInput<T1, T2, T3>(this CombinedResult<T1, T2, TableFactory, T3> combinedResult, Action<Humidifier.Glue.TableTypes.TableInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTableInput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TableFactory, InnerTableTableInputFactory> WithTableInput<T1, T2, T3>(this CombinedResult<T1, T2, T3, TableFactory> combinedResult, Action<Humidifier.Glue.TableTypes.TableInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTableInput(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TableFactory, T1, T2, T3, T4, InnerTableTableInputFactory> WithTableInput<T1, T2, T3, T4>(this CombinedResult<TableFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.TableTypes.TableInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTableInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TableFactory, T2, T3, T4, InnerTableTableInputFactory> WithTableInput<T1, T2, T3, T4>(this CombinedResult<T1, TableFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.TableTypes.TableInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTableInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TableFactory, T3, T4, InnerTableTableInputFactory> WithTableInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, TableFactory, T3, T4> combinedResult, Action<Humidifier.Glue.TableTypes.TableInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTableInput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TableFactory, T4, InnerTableTableInputFactory> WithTableInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TableFactory, T4> combinedResult, Action<Humidifier.Glue.TableTypes.TableInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTableInput(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TableFactory, InnerTableTableInputFactory> WithTableInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TableFactory> combinedResult, Action<Humidifier.Glue.TableTypes.TableInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTableInput(combinedResult.T5, subFactoryAction));
    public static CombinedResult<TableFactory, T1, InnerTableOpenTableFormatInputFactory> WithOpenTableFormatInput<T1>(this CombinedResult<TableFactory, T1> combinedResult, Action<Humidifier.Glue.TableTypes.OpenTableFormatInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithOpenTableFormatInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TableFactory, InnerTableOpenTableFormatInputFactory> WithOpenTableFormatInput<T1>(this CombinedResult<T1, TableFactory> combinedResult, Action<Humidifier.Glue.TableTypes.OpenTableFormatInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithOpenTableFormatInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TableFactory, T1, T2, InnerTableOpenTableFormatInputFactory> WithOpenTableFormatInput<T1, T2>(this CombinedResult<TableFactory, T1, T2> combinedResult, Action<Humidifier.Glue.TableTypes.OpenTableFormatInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOpenTableFormatInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TableFactory, T2, InnerTableOpenTableFormatInputFactory> WithOpenTableFormatInput<T1, T2>(this CombinedResult<T1, TableFactory, T2> combinedResult, Action<Humidifier.Glue.TableTypes.OpenTableFormatInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOpenTableFormatInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TableFactory, InnerTableOpenTableFormatInputFactory> WithOpenTableFormatInput<T1, T2>(this CombinedResult<T1, T2, TableFactory> combinedResult, Action<Humidifier.Glue.TableTypes.OpenTableFormatInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOpenTableFormatInput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TableFactory, T1, T2, T3, InnerTableOpenTableFormatInputFactory> WithOpenTableFormatInput<T1, T2, T3>(this CombinedResult<TableFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.TableTypes.OpenTableFormatInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOpenTableFormatInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TableFactory, T2, T3, InnerTableOpenTableFormatInputFactory> WithOpenTableFormatInput<T1, T2, T3>(this CombinedResult<T1, TableFactory, T2, T3> combinedResult, Action<Humidifier.Glue.TableTypes.OpenTableFormatInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOpenTableFormatInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TableFactory, T3, InnerTableOpenTableFormatInputFactory> WithOpenTableFormatInput<T1, T2, T3>(this CombinedResult<T1, T2, TableFactory, T3> combinedResult, Action<Humidifier.Glue.TableTypes.OpenTableFormatInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOpenTableFormatInput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TableFactory, InnerTableOpenTableFormatInputFactory> WithOpenTableFormatInput<T1, T2, T3>(this CombinedResult<T1, T2, T3, TableFactory> combinedResult, Action<Humidifier.Glue.TableTypes.OpenTableFormatInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOpenTableFormatInput(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TableFactory, T1, T2, T3, T4, InnerTableOpenTableFormatInputFactory> WithOpenTableFormatInput<T1, T2, T3, T4>(this CombinedResult<TableFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.TableTypes.OpenTableFormatInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOpenTableFormatInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TableFactory, T2, T3, T4, InnerTableOpenTableFormatInputFactory> WithOpenTableFormatInput<T1, T2, T3, T4>(this CombinedResult<T1, TableFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.TableTypes.OpenTableFormatInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOpenTableFormatInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TableFactory, T3, T4, InnerTableOpenTableFormatInputFactory> WithOpenTableFormatInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, TableFactory, T3, T4> combinedResult, Action<Humidifier.Glue.TableTypes.OpenTableFormatInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOpenTableFormatInput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TableFactory, T4, InnerTableOpenTableFormatInputFactory> WithOpenTableFormatInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TableFactory, T4> combinedResult, Action<Humidifier.Glue.TableTypes.OpenTableFormatInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOpenTableFormatInput(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TableFactory, InnerTableOpenTableFormatInputFactory> WithOpenTableFormatInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TableFactory> combinedResult, Action<Humidifier.Glue.TableTypes.OpenTableFormatInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOpenTableFormatInput(combinedResult.T5, subFactoryAction));
}
