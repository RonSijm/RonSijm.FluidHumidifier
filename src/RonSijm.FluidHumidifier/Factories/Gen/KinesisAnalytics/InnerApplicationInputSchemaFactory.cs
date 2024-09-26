// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalytics;

public class InnerApplicationInputSchemaFactory(Action<Humidifier.KinesisAnalytics.ApplicationTypes.InputSchema> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalytics.ApplicationTypes.InputSchema>
{

    internal InnerApplicationRecordFormatFactory RecordFormatFactory { get; set; }

    protected override Humidifier.KinesisAnalytics.ApplicationTypes.InputSchema Create()
    {
        var inputSchemaResult = CreateInputSchema();
        factoryAction?.Invoke(inputSchemaResult);

        return inputSchemaResult;
    }

    private Humidifier.KinesisAnalytics.ApplicationTypes.InputSchema CreateInputSchema()
    {
        var inputSchemaResult = new Humidifier.KinesisAnalytics.ApplicationTypes.InputSchema();

        return inputSchemaResult;
    }
    public override void CreateChildren(Humidifier.KinesisAnalytics.ApplicationTypes.InputSchema result)
    {
        base.CreateChildren(result);

        result.RecordFormat ??= RecordFormatFactory?.Build();
    }

} // End Of Class

public static class InnerApplicationInputSchemaFactoryExtensions
{
    public static CombinedResult<InnerApplicationInputSchemaFactory, InnerApplicationRecordFormatFactory> WithRecordFormat(this InnerApplicationInputSchemaFactory parentFactory, Action<Humidifier.KinesisAnalytics.ApplicationTypes.RecordFormat> subFactoryAction = null)
    {
        parentFactory.RecordFormatFactory = new InnerApplicationRecordFormatFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RecordFormatFactory);
    }

    public static CombinedResult<InnerApplicationInputSchemaFactory, T1, InnerApplicationRecordFormatFactory> WithRecordFormat<T1>(this CombinedResult<InnerApplicationInputSchemaFactory, T1> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.RecordFormat> subFactoryAction = null) => new (combinedResult, combinedResult, WithRecordFormat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationInputSchemaFactory, InnerApplicationRecordFormatFactory> WithRecordFormat<T1>(this CombinedResult<T1, InnerApplicationInputSchemaFactory> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.RecordFormat> subFactoryAction = null) => new (combinedResult, combinedResult, WithRecordFormat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerApplicationInputSchemaFactory, T1, T2, InnerApplicationRecordFormatFactory> WithRecordFormat<T1, T2>(this CombinedResult<InnerApplicationInputSchemaFactory, T1, T2> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.RecordFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecordFormat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationInputSchemaFactory, T2, InnerApplicationRecordFormatFactory> WithRecordFormat<T1, T2>(this CombinedResult<T1, InnerApplicationInputSchemaFactory, T2> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.RecordFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecordFormat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationInputSchemaFactory, InnerApplicationRecordFormatFactory> WithRecordFormat<T1, T2>(this CombinedResult<T1, T2, InnerApplicationInputSchemaFactory> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.RecordFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecordFormat(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerApplicationInputSchemaFactory, T1, T2, T3, InnerApplicationRecordFormatFactory> WithRecordFormat<T1, T2, T3>(this CombinedResult<InnerApplicationInputSchemaFactory, T1, T2, T3> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.RecordFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordFormat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationInputSchemaFactory, T2, T3, InnerApplicationRecordFormatFactory> WithRecordFormat<T1, T2, T3>(this CombinedResult<T1, InnerApplicationInputSchemaFactory, T2, T3> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.RecordFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordFormat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationInputSchemaFactory, T3, InnerApplicationRecordFormatFactory> WithRecordFormat<T1, T2, T3>(this CombinedResult<T1, T2, InnerApplicationInputSchemaFactory, T3> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.RecordFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordFormat(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerApplicationInputSchemaFactory, InnerApplicationRecordFormatFactory> WithRecordFormat<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerApplicationInputSchemaFactory> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.RecordFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordFormat(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerApplicationInputSchemaFactory, T1, T2, T3, T4, InnerApplicationRecordFormatFactory> WithRecordFormat<T1, T2, T3, T4>(this CombinedResult<InnerApplicationInputSchemaFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.RecordFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordFormat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationInputSchemaFactory, T2, T3, T4, InnerApplicationRecordFormatFactory> WithRecordFormat<T1, T2, T3, T4>(this CombinedResult<T1, InnerApplicationInputSchemaFactory, T2, T3, T4> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.RecordFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordFormat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationInputSchemaFactory, T3, T4, InnerApplicationRecordFormatFactory> WithRecordFormat<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerApplicationInputSchemaFactory, T3, T4> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.RecordFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordFormat(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerApplicationInputSchemaFactory, T4, InnerApplicationRecordFormatFactory> WithRecordFormat<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerApplicationInputSchemaFactory, T4> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.RecordFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordFormat(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerApplicationInputSchemaFactory, InnerApplicationRecordFormatFactory> WithRecordFormat<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerApplicationInputSchemaFactory> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.RecordFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordFormat(combinedResult.T5, subFactoryAction));
}
