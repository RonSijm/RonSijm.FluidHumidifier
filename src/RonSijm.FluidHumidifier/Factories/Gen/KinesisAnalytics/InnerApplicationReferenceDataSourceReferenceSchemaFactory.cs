// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalytics;

public class InnerApplicationReferenceDataSourceReferenceSchemaFactory(Action<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.ReferenceSchema> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.ReferenceSchema>
{

    internal InnerApplicationReferenceDataSourceRecordFormatFactory RecordFormatFactory { get; set; }

    protected override Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.ReferenceSchema Create()
    {
        var referenceSchemaResult = CreateReferenceSchema();
        factoryAction?.Invoke(referenceSchemaResult);

        return referenceSchemaResult;
    }

    private Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.ReferenceSchema CreateReferenceSchema()
    {
        var referenceSchemaResult = new Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.ReferenceSchema();

        return referenceSchemaResult;
    }
    public override void CreateChildren(Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.ReferenceSchema result)
    {
        base.CreateChildren(result);

        result.RecordFormat ??= RecordFormatFactory?.Build();
    }

} // End Of Class

public static class InnerApplicationReferenceDataSourceReferenceSchemaFactoryExtensions
{
    public static CombinedResult<InnerApplicationReferenceDataSourceReferenceSchemaFactory, InnerApplicationReferenceDataSourceRecordFormatFactory> WithRecordFormat(this InnerApplicationReferenceDataSourceReferenceSchemaFactory parentFactory, Action<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.RecordFormat> subFactoryAction = null)
    {
        parentFactory.RecordFormatFactory = new InnerApplicationReferenceDataSourceRecordFormatFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RecordFormatFactory);
    }

    public static CombinedResult<InnerApplicationReferenceDataSourceReferenceSchemaFactory, T1, InnerApplicationReferenceDataSourceRecordFormatFactory> WithRecordFormat<T1>(this CombinedResult<InnerApplicationReferenceDataSourceReferenceSchemaFactory, T1> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.RecordFormat> subFactoryAction = null) => new (combinedResult, combinedResult, WithRecordFormat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationReferenceDataSourceReferenceSchemaFactory, InnerApplicationReferenceDataSourceRecordFormatFactory> WithRecordFormat<T1>(this CombinedResult<T1, InnerApplicationReferenceDataSourceReferenceSchemaFactory> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.RecordFormat> subFactoryAction = null) => new (combinedResult, combinedResult, WithRecordFormat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerApplicationReferenceDataSourceReferenceSchemaFactory, T1, T2, InnerApplicationReferenceDataSourceRecordFormatFactory> WithRecordFormat<T1, T2>(this CombinedResult<InnerApplicationReferenceDataSourceReferenceSchemaFactory, T1, T2> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.RecordFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecordFormat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationReferenceDataSourceReferenceSchemaFactory, T2, InnerApplicationReferenceDataSourceRecordFormatFactory> WithRecordFormat<T1, T2>(this CombinedResult<T1, InnerApplicationReferenceDataSourceReferenceSchemaFactory, T2> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.RecordFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecordFormat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationReferenceDataSourceReferenceSchemaFactory, InnerApplicationReferenceDataSourceRecordFormatFactory> WithRecordFormat<T1, T2>(this CombinedResult<T1, T2, InnerApplicationReferenceDataSourceReferenceSchemaFactory> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.RecordFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecordFormat(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerApplicationReferenceDataSourceReferenceSchemaFactory, T1, T2, T3, InnerApplicationReferenceDataSourceRecordFormatFactory> WithRecordFormat<T1, T2, T3>(this CombinedResult<InnerApplicationReferenceDataSourceReferenceSchemaFactory, T1, T2, T3> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.RecordFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordFormat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationReferenceDataSourceReferenceSchemaFactory, T2, T3, InnerApplicationReferenceDataSourceRecordFormatFactory> WithRecordFormat<T1, T2, T3>(this CombinedResult<T1, InnerApplicationReferenceDataSourceReferenceSchemaFactory, T2, T3> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.RecordFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordFormat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationReferenceDataSourceReferenceSchemaFactory, T3, InnerApplicationReferenceDataSourceRecordFormatFactory> WithRecordFormat<T1, T2, T3>(this CombinedResult<T1, T2, InnerApplicationReferenceDataSourceReferenceSchemaFactory, T3> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.RecordFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordFormat(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerApplicationReferenceDataSourceReferenceSchemaFactory, InnerApplicationReferenceDataSourceRecordFormatFactory> WithRecordFormat<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerApplicationReferenceDataSourceReferenceSchemaFactory> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.RecordFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordFormat(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerApplicationReferenceDataSourceReferenceSchemaFactory, T1, T2, T3, T4, InnerApplicationReferenceDataSourceRecordFormatFactory> WithRecordFormat<T1, T2, T3, T4>(this CombinedResult<InnerApplicationReferenceDataSourceReferenceSchemaFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.RecordFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordFormat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationReferenceDataSourceReferenceSchemaFactory, T2, T3, T4, InnerApplicationReferenceDataSourceRecordFormatFactory> WithRecordFormat<T1, T2, T3, T4>(this CombinedResult<T1, InnerApplicationReferenceDataSourceReferenceSchemaFactory, T2, T3, T4> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.RecordFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordFormat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationReferenceDataSourceReferenceSchemaFactory, T3, T4, InnerApplicationReferenceDataSourceRecordFormatFactory> WithRecordFormat<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerApplicationReferenceDataSourceReferenceSchemaFactory, T3, T4> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.RecordFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordFormat(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerApplicationReferenceDataSourceReferenceSchemaFactory, T4, InnerApplicationReferenceDataSourceRecordFormatFactory> WithRecordFormat<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerApplicationReferenceDataSourceReferenceSchemaFactory, T4> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.RecordFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordFormat(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerApplicationReferenceDataSourceReferenceSchemaFactory, InnerApplicationReferenceDataSourceRecordFormatFactory> WithRecordFormat<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerApplicationReferenceDataSourceReferenceSchemaFactory> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.RecordFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordFormat(combinedResult.T5, subFactoryAction));
}
