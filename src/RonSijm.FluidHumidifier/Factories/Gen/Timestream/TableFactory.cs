// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Timestream;

public class TableFactory(string resourceName = null, Action<Humidifier.Timestream.Table> factoryAction = null) : ResourceFactory<Humidifier.Timestream.Table>(resourceName)
{

    internal InnerTableRetentionPropertiesFactory RetentionPropertiesFactory { get; set; }

    internal InnerTableSchemaFactory SchemaFactory { get; set; }

    internal InnerTableMagneticStoreWritePropertiesFactory MagneticStoreWritePropertiesFactory { get; set; }

    protected override Humidifier.Timestream.Table Create()
    {
        var tableResult = CreateTable();
        factoryAction?.Invoke(tableResult);

        return tableResult;
    }

    private Humidifier.Timestream.Table CreateTable()
    {
        var tableResult = new Humidifier.Timestream.Table
        {
            GivenName = InputResourceName,
        };

        return tableResult;
    }
    public override void CreateChildren(Humidifier.Timestream.Table result)
    {
        base.CreateChildren(result);

        result.RetentionProperties ??= RetentionPropertiesFactory?.Build();
        result.Schema ??= SchemaFactory?.Build();
        result.MagneticStoreWriteProperties ??= MagneticStoreWritePropertiesFactory?.Build();
    }

} // End Of Class

public static class TableFactoryExtensions
{
    public static CombinedResult<TableFactory, InnerTableRetentionPropertiesFactory> WithRetentionProperties(this TableFactory parentFactory, Action<Humidifier.Timestream.TableTypes.RetentionProperties> subFactoryAction = null)
    {
        parentFactory.RetentionPropertiesFactory = new InnerTableRetentionPropertiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RetentionPropertiesFactory);
    }

    public static CombinedResult<TableFactory, InnerTableSchemaFactory> WithSchema(this TableFactory parentFactory, Action<Humidifier.Timestream.TableTypes.Schema> subFactoryAction = null)
    {
        parentFactory.SchemaFactory = new InnerTableSchemaFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SchemaFactory);
    }

    public static CombinedResult<TableFactory, InnerTableMagneticStoreWritePropertiesFactory> WithMagneticStoreWriteProperties(this TableFactory parentFactory, Action<Humidifier.Timestream.TableTypes.MagneticStoreWriteProperties> subFactoryAction = null)
    {
        parentFactory.MagneticStoreWritePropertiesFactory = new InnerTableMagneticStoreWritePropertiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MagneticStoreWritePropertiesFactory);
    }

    public static CombinedResult<TableFactory, T1, InnerTableRetentionPropertiesFactory> WithRetentionProperties<T1>(this CombinedResult<TableFactory, T1> combinedResult, Action<Humidifier.Timestream.TableTypes.RetentionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithRetentionProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TableFactory, InnerTableRetentionPropertiesFactory> WithRetentionProperties<T1>(this CombinedResult<T1, TableFactory> combinedResult, Action<Humidifier.Timestream.TableTypes.RetentionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithRetentionProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TableFactory, T1, T2, InnerTableRetentionPropertiesFactory> WithRetentionProperties<T1, T2>(this CombinedResult<TableFactory, T1, T2> combinedResult, Action<Humidifier.Timestream.TableTypes.RetentionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRetentionProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TableFactory, T2, InnerTableRetentionPropertiesFactory> WithRetentionProperties<T1, T2>(this CombinedResult<T1, TableFactory, T2> combinedResult, Action<Humidifier.Timestream.TableTypes.RetentionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRetentionProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TableFactory, InnerTableRetentionPropertiesFactory> WithRetentionProperties<T1, T2>(this CombinedResult<T1, T2, TableFactory> combinedResult, Action<Humidifier.Timestream.TableTypes.RetentionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRetentionProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TableFactory, T1, T2, T3, InnerTableRetentionPropertiesFactory> WithRetentionProperties<T1, T2, T3>(this CombinedResult<TableFactory, T1, T2, T3> combinedResult, Action<Humidifier.Timestream.TableTypes.RetentionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TableFactory, T2, T3, InnerTableRetentionPropertiesFactory> WithRetentionProperties<T1, T2, T3>(this CombinedResult<T1, TableFactory, T2, T3> combinedResult, Action<Humidifier.Timestream.TableTypes.RetentionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TableFactory, T3, InnerTableRetentionPropertiesFactory> WithRetentionProperties<T1, T2, T3>(this CombinedResult<T1, T2, TableFactory, T3> combinedResult, Action<Humidifier.Timestream.TableTypes.RetentionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TableFactory, InnerTableRetentionPropertiesFactory> WithRetentionProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, TableFactory> combinedResult, Action<Humidifier.Timestream.TableTypes.RetentionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TableFactory, T1, T2, T3, T4, InnerTableRetentionPropertiesFactory> WithRetentionProperties<T1, T2, T3, T4>(this CombinedResult<TableFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Timestream.TableTypes.RetentionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TableFactory, T2, T3, T4, InnerTableRetentionPropertiesFactory> WithRetentionProperties<T1, T2, T3, T4>(this CombinedResult<T1, TableFactory, T2, T3, T4> combinedResult, Action<Humidifier.Timestream.TableTypes.RetentionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TableFactory, T3, T4, InnerTableRetentionPropertiesFactory> WithRetentionProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, TableFactory, T3, T4> combinedResult, Action<Humidifier.Timestream.TableTypes.RetentionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TableFactory, T4, InnerTableRetentionPropertiesFactory> WithRetentionProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TableFactory, T4> combinedResult, Action<Humidifier.Timestream.TableTypes.RetentionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TableFactory, InnerTableRetentionPropertiesFactory> WithRetentionProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TableFactory> combinedResult, Action<Humidifier.Timestream.TableTypes.RetentionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionProperties(combinedResult.T5, subFactoryAction));
    public static CombinedResult<TableFactory, T1, InnerTableSchemaFactory> WithSchema<T1>(this CombinedResult<TableFactory, T1> combinedResult, Action<Humidifier.Timestream.TableTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchema(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TableFactory, InnerTableSchemaFactory> WithSchema<T1>(this CombinedResult<T1, TableFactory> combinedResult, Action<Humidifier.Timestream.TableTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchema(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TableFactory, T1, T2, InnerTableSchemaFactory> WithSchema<T1, T2>(this CombinedResult<TableFactory, T1, T2> combinedResult, Action<Humidifier.Timestream.TableTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TableFactory, T2, InnerTableSchemaFactory> WithSchema<T1, T2>(this CombinedResult<T1, TableFactory, T2> combinedResult, Action<Humidifier.Timestream.TableTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TableFactory, InnerTableSchemaFactory> WithSchema<T1, T2>(this CombinedResult<T1, T2, TableFactory> combinedResult, Action<Humidifier.Timestream.TableTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TableFactory, T1, T2, T3, InnerTableSchemaFactory> WithSchema<T1, T2, T3>(this CombinedResult<TableFactory, T1, T2, T3> combinedResult, Action<Humidifier.Timestream.TableTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TableFactory, T2, T3, InnerTableSchemaFactory> WithSchema<T1, T2, T3>(this CombinedResult<T1, TableFactory, T2, T3> combinedResult, Action<Humidifier.Timestream.TableTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TableFactory, T3, InnerTableSchemaFactory> WithSchema<T1, T2, T3>(this CombinedResult<T1, T2, TableFactory, T3> combinedResult, Action<Humidifier.Timestream.TableTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TableFactory, InnerTableSchemaFactory> WithSchema<T1, T2, T3>(this CombinedResult<T1, T2, T3, TableFactory> combinedResult, Action<Humidifier.Timestream.TableTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TableFactory, T1, T2, T3, T4, InnerTableSchemaFactory> WithSchema<T1, T2, T3, T4>(this CombinedResult<TableFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Timestream.TableTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TableFactory, T2, T3, T4, InnerTableSchemaFactory> WithSchema<T1, T2, T3, T4>(this CombinedResult<T1, TableFactory, T2, T3, T4> combinedResult, Action<Humidifier.Timestream.TableTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TableFactory, T3, T4, InnerTableSchemaFactory> WithSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, TableFactory, T3, T4> combinedResult, Action<Humidifier.Timestream.TableTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TableFactory, T4, InnerTableSchemaFactory> WithSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TableFactory, T4> combinedResult, Action<Humidifier.Timestream.TableTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TableFactory, InnerTableSchemaFactory> WithSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TableFactory> combinedResult, Action<Humidifier.Timestream.TableTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T5, subFactoryAction));
    public static CombinedResult<TableFactory, T1, InnerTableMagneticStoreWritePropertiesFactory> WithMagneticStoreWriteProperties<T1>(this CombinedResult<TableFactory, T1> combinedResult, Action<Humidifier.Timestream.TableTypes.MagneticStoreWriteProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithMagneticStoreWriteProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TableFactory, InnerTableMagneticStoreWritePropertiesFactory> WithMagneticStoreWriteProperties<T1>(this CombinedResult<T1, TableFactory> combinedResult, Action<Humidifier.Timestream.TableTypes.MagneticStoreWriteProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithMagneticStoreWriteProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TableFactory, T1, T2, InnerTableMagneticStoreWritePropertiesFactory> WithMagneticStoreWriteProperties<T1, T2>(this CombinedResult<TableFactory, T1, T2> combinedResult, Action<Humidifier.Timestream.TableTypes.MagneticStoreWriteProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMagneticStoreWriteProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TableFactory, T2, InnerTableMagneticStoreWritePropertiesFactory> WithMagneticStoreWriteProperties<T1, T2>(this CombinedResult<T1, TableFactory, T2> combinedResult, Action<Humidifier.Timestream.TableTypes.MagneticStoreWriteProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMagneticStoreWriteProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TableFactory, InnerTableMagneticStoreWritePropertiesFactory> WithMagneticStoreWriteProperties<T1, T2>(this CombinedResult<T1, T2, TableFactory> combinedResult, Action<Humidifier.Timestream.TableTypes.MagneticStoreWriteProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMagneticStoreWriteProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TableFactory, T1, T2, T3, InnerTableMagneticStoreWritePropertiesFactory> WithMagneticStoreWriteProperties<T1, T2, T3>(this CombinedResult<TableFactory, T1, T2, T3> combinedResult, Action<Humidifier.Timestream.TableTypes.MagneticStoreWriteProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMagneticStoreWriteProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TableFactory, T2, T3, InnerTableMagneticStoreWritePropertiesFactory> WithMagneticStoreWriteProperties<T1, T2, T3>(this CombinedResult<T1, TableFactory, T2, T3> combinedResult, Action<Humidifier.Timestream.TableTypes.MagneticStoreWriteProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMagneticStoreWriteProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TableFactory, T3, InnerTableMagneticStoreWritePropertiesFactory> WithMagneticStoreWriteProperties<T1, T2, T3>(this CombinedResult<T1, T2, TableFactory, T3> combinedResult, Action<Humidifier.Timestream.TableTypes.MagneticStoreWriteProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMagneticStoreWriteProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TableFactory, InnerTableMagneticStoreWritePropertiesFactory> WithMagneticStoreWriteProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, TableFactory> combinedResult, Action<Humidifier.Timestream.TableTypes.MagneticStoreWriteProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMagneticStoreWriteProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TableFactory, T1, T2, T3, T4, InnerTableMagneticStoreWritePropertiesFactory> WithMagneticStoreWriteProperties<T1, T2, T3, T4>(this CombinedResult<TableFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Timestream.TableTypes.MagneticStoreWriteProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMagneticStoreWriteProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TableFactory, T2, T3, T4, InnerTableMagneticStoreWritePropertiesFactory> WithMagneticStoreWriteProperties<T1, T2, T3, T4>(this CombinedResult<T1, TableFactory, T2, T3, T4> combinedResult, Action<Humidifier.Timestream.TableTypes.MagneticStoreWriteProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMagneticStoreWriteProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TableFactory, T3, T4, InnerTableMagneticStoreWritePropertiesFactory> WithMagneticStoreWriteProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, TableFactory, T3, T4> combinedResult, Action<Humidifier.Timestream.TableTypes.MagneticStoreWriteProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMagneticStoreWriteProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TableFactory, T4, InnerTableMagneticStoreWritePropertiesFactory> WithMagneticStoreWriteProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TableFactory, T4> combinedResult, Action<Humidifier.Timestream.TableTypes.MagneticStoreWriteProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMagneticStoreWriteProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TableFactory, InnerTableMagneticStoreWritePropertiesFactory> WithMagneticStoreWriteProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TableFactory> combinedResult, Action<Humidifier.Timestream.TableTypes.MagneticStoreWriteProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMagneticStoreWriteProperties(combinedResult.T5, subFactoryAction));
}
