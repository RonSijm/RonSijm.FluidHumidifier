// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalyticsV2;

public class InnerApplicationReferenceDataSourceRecordFormatFactory(Action<Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.RecordFormat> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.RecordFormat>
{

    internal InnerApplicationReferenceDataSourceMappingParametersFactory MappingParametersFactory { get; set; }

    protected override Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.RecordFormat Create()
    {
        var recordFormatResult = CreateRecordFormat();
        factoryAction?.Invoke(recordFormatResult);

        return recordFormatResult;
    }

    private Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.RecordFormat CreateRecordFormat()
    {
        var recordFormatResult = new Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.RecordFormat();

        return recordFormatResult;
    }
    public override void CreateChildren(Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.RecordFormat result)
    {
        base.CreateChildren(result);

        result.MappingParameters ??= MappingParametersFactory?.Build();
    }

} // End Of Class

public static class InnerApplicationReferenceDataSourceRecordFormatFactoryExtensions
{
    public static CombinedResult<InnerApplicationReferenceDataSourceRecordFormatFactory, InnerApplicationReferenceDataSourceMappingParametersFactory> WithMappingParameters(this InnerApplicationReferenceDataSourceRecordFormatFactory parentFactory, Action<Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.MappingParameters> subFactoryAction = null)
    {
        parentFactory.MappingParametersFactory = new InnerApplicationReferenceDataSourceMappingParametersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MappingParametersFactory);
    }

    public static CombinedResult<InnerApplicationReferenceDataSourceRecordFormatFactory, T1, InnerApplicationReferenceDataSourceMappingParametersFactory> WithMappingParameters<T1>(this CombinedResult<InnerApplicationReferenceDataSourceRecordFormatFactory, T1> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.MappingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithMappingParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationReferenceDataSourceRecordFormatFactory, InnerApplicationReferenceDataSourceMappingParametersFactory> WithMappingParameters<T1>(this CombinedResult<T1, InnerApplicationReferenceDataSourceRecordFormatFactory> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.MappingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithMappingParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerApplicationReferenceDataSourceRecordFormatFactory, T1, T2, InnerApplicationReferenceDataSourceMappingParametersFactory> WithMappingParameters<T1, T2>(this CombinedResult<InnerApplicationReferenceDataSourceRecordFormatFactory, T1, T2> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.MappingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMappingParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationReferenceDataSourceRecordFormatFactory, T2, InnerApplicationReferenceDataSourceMappingParametersFactory> WithMappingParameters<T1, T2>(this CombinedResult<T1, InnerApplicationReferenceDataSourceRecordFormatFactory, T2> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.MappingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMappingParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationReferenceDataSourceRecordFormatFactory, InnerApplicationReferenceDataSourceMappingParametersFactory> WithMappingParameters<T1, T2>(this CombinedResult<T1, T2, InnerApplicationReferenceDataSourceRecordFormatFactory> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.MappingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMappingParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerApplicationReferenceDataSourceRecordFormatFactory, T1, T2, T3, InnerApplicationReferenceDataSourceMappingParametersFactory> WithMappingParameters<T1, T2, T3>(this CombinedResult<InnerApplicationReferenceDataSourceRecordFormatFactory, T1, T2, T3> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.MappingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMappingParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationReferenceDataSourceRecordFormatFactory, T2, T3, InnerApplicationReferenceDataSourceMappingParametersFactory> WithMappingParameters<T1, T2, T3>(this CombinedResult<T1, InnerApplicationReferenceDataSourceRecordFormatFactory, T2, T3> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.MappingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMappingParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationReferenceDataSourceRecordFormatFactory, T3, InnerApplicationReferenceDataSourceMappingParametersFactory> WithMappingParameters<T1, T2, T3>(this CombinedResult<T1, T2, InnerApplicationReferenceDataSourceRecordFormatFactory, T3> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.MappingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMappingParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerApplicationReferenceDataSourceRecordFormatFactory, InnerApplicationReferenceDataSourceMappingParametersFactory> WithMappingParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerApplicationReferenceDataSourceRecordFormatFactory> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.MappingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMappingParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerApplicationReferenceDataSourceRecordFormatFactory, T1, T2, T3, T4, InnerApplicationReferenceDataSourceMappingParametersFactory> WithMappingParameters<T1, T2, T3, T4>(this CombinedResult<InnerApplicationReferenceDataSourceRecordFormatFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.MappingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMappingParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationReferenceDataSourceRecordFormatFactory, T2, T3, T4, InnerApplicationReferenceDataSourceMappingParametersFactory> WithMappingParameters<T1, T2, T3, T4>(this CombinedResult<T1, InnerApplicationReferenceDataSourceRecordFormatFactory, T2, T3, T4> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.MappingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMappingParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationReferenceDataSourceRecordFormatFactory, T3, T4, InnerApplicationReferenceDataSourceMappingParametersFactory> WithMappingParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerApplicationReferenceDataSourceRecordFormatFactory, T3, T4> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.MappingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMappingParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerApplicationReferenceDataSourceRecordFormatFactory, T4, InnerApplicationReferenceDataSourceMappingParametersFactory> WithMappingParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerApplicationReferenceDataSourceRecordFormatFactory, T4> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.MappingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMappingParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerApplicationReferenceDataSourceRecordFormatFactory, InnerApplicationReferenceDataSourceMappingParametersFactory> WithMappingParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerApplicationReferenceDataSourceRecordFormatFactory> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.MappingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMappingParameters(combinedResult.T5, subFactoryAction));
}
