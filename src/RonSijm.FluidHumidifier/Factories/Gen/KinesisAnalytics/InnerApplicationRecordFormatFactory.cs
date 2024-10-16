// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalytics;

public class InnerApplicationRecordFormatFactory(Action<Humidifier.KinesisAnalytics.ApplicationTypes.RecordFormat> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalytics.ApplicationTypes.RecordFormat>
{

    internal InnerApplicationMappingParametersFactory MappingParametersFactory { get; set; }

    protected override Humidifier.KinesisAnalytics.ApplicationTypes.RecordFormat Create()
    {
        var recordFormatResult = CreateRecordFormat();
        factoryAction?.Invoke(recordFormatResult);

        return recordFormatResult;
    }

    private Humidifier.KinesisAnalytics.ApplicationTypes.RecordFormat CreateRecordFormat()
    {
        var recordFormatResult = new Humidifier.KinesisAnalytics.ApplicationTypes.RecordFormat();

        return recordFormatResult;
    }
    public override void CreateChildren(Humidifier.KinesisAnalytics.ApplicationTypes.RecordFormat result)
    {
        base.CreateChildren(result);

        result.MappingParameters ??= MappingParametersFactory?.Build();
    }

} // End Of Class

public static class InnerApplicationRecordFormatFactoryExtensions
{
    public static CombinedResult<InnerApplicationRecordFormatFactory, InnerApplicationMappingParametersFactory> WithMappingParameters(this InnerApplicationRecordFormatFactory parentFactory, Action<Humidifier.KinesisAnalytics.ApplicationTypes.MappingParameters> subFactoryAction = null)
    {
        parentFactory.MappingParametersFactory = new InnerApplicationMappingParametersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MappingParametersFactory);
    }

    public static CombinedResult<InnerApplicationRecordFormatFactory, T1, InnerApplicationMappingParametersFactory> WithMappingParameters<T1>(this CombinedResult<InnerApplicationRecordFormatFactory, T1> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.MappingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithMappingParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationRecordFormatFactory, InnerApplicationMappingParametersFactory> WithMappingParameters<T1>(this CombinedResult<T1, InnerApplicationRecordFormatFactory> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.MappingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithMappingParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerApplicationRecordFormatFactory, T1, T2, InnerApplicationMappingParametersFactory> WithMappingParameters<T1, T2>(this CombinedResult<InnerApplicationRecordFormatFactory, T1, T2> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.MappingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMappingParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationRecordFormatFactory, T2, InnerApplicationMappingParametersFactory> WithMappingParameters<T1, T2>(this CombinedResult<T1, InnerApplicationRecordFormatFactory, T2> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.MappingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMappingParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationRecordFormatFactory, InnerApplicationMappingParametersFactory> WithMappingParameters<T1, T2>(this CombinedResult<T1, T2, InnerApplicationRecordFormatFactory> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.MappingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMappingParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerApplicationRecordFormatFactory, T1, T2, T3, InnerApplicationMappingParametersFactory> WithMappingParameters<T1, T2, T3>(this CombinedResult<InnerApplicationRecordFormatFactory, T1, T2, T3> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.MappingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMappingParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationRecordFormatFactory, T2, T3, InnerApplicationMappingParametersFactory> WithMappingParameters<T1, T2, T3>(this CombinedResult<T1, InnerApplicationRecordFormatFactory, T2, T3> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.MappingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMappingParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationRecordFormatFactory, T3, InnerApplicationMappingParametersFactory> WithMappingParameters<T1, T2, T3>(this CombinedResult<T1, T2, InnerApplicationRecordFormatFactory, T3> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.MappingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMappingParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerApplicationRecordFormatFactory, InnerApplicationMappingParametersFactory> WithMappingParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerApplicationRecordFormatFactory> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.MappingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMappingParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerApplicationRecordFormatFactory, T1, T2, T3, T4, InnerApplicationMappingParametersFactory> WithMappingParameters<T1, T2, T3, T4>(this CombinedResult<InnerApplicationRecordFormatFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.MappingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMappingParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationRecordFormatFactory, T2, T3, T4, InnerApplicationMappingParametersFactory> WithMappingParameters<T1, T2, T3, T4>(this CombinedResult<T1, InnerApplicationRecordFormatFactory, T2, T3, T4> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.MappingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMappingParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationRecordFormatFactory, T3, T4, InnerApplicationMappingParametersFactory> WithMappingParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerApplicationRecordFormatFactory, T3, T4> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.MappingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMappingParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerApplicationRecordFormatFactory, T4, InnerApplicationMappingParametersFactory> WithMappingParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerApplicationRecordFormatFactory, T4> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.MappingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMappingParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerApplicationRecordFormatFactory, InnerApplicationMappingParametersFactory> WithMappingParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerApplicationRecordFormatFactory> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.MappingParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMappingParameters(combinedResult.T5, subFactoryAction));
}
