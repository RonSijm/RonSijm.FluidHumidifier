// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalyticsV2;

public class InnerApplicationCodeContentFactory(Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.CodeContent> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalyticsV2.ApplicationTypes.CodeContent>
{

    internal InnerApplicationS3ContentLocationFactory S3ContentLocationFactory { get; set; }

    protected override Humidifier.KinesisAnalyticsV2.ApplicationTypes.CodeContent Create()
    {
        var codeContentResult = CreateCodeContent();
        factoryAction?.Invoke(codeContentResult);

        return codeContentResult;
    }

    private Humidifier.KinesisAnalyticsV2.ApplicationTypes.CodeContent CreateCodeContent()
    {
        var codeContentResult = new Humidifier.KinesisAnalyticsV2.ApplicationTypes.CodeContent();

        return codeContentResult;
    }
    public override void CreateChildren(Humidifier.KinesisAnalyticsV2.ApplicationTypes.CodeContent result)
    {
        base.CreateChildren(result);

        result.S3ContentLocation ??= S3ContentLocationFactory?.Build();
    }

} // End Of Class

public static class InnerApplicationCodeContentFactoryExtensions
{
    public static CombinedResult<InnerApplicationCodeContentFactory, InnerApplicationS3ContentLocationFactory> WithS3ContentLocation(this InnerApplicationCodeContentFactory parentFactory, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentLocation> subFactoryAction = null)
    {
        parentFactory.S3ContentLocationFactory = new InnerApplicationS3ContentLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3ContentLocationFactory);
    }

    public static CombinedResult<InnerApplicationCodeContentFactory, T1, InnerApplicationS3ContentLocationFactory> WithS3ContentLocation<T1>(this CombinedResult<InnerApplicationCodeContentFactory, T1> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3ContentLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationCodeContentFactory, InnerApplicationS3ContentLocationFactory> WithS3ContentLocation<T1>(this CombinedResult<T1, InnerApplicationCodeContentFactory> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3ContentLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerApplicationCodeContentFactory, T1, T2, InnerApplicationS3ContentLocationFactory> WithS3ContentLocation<T1, T2>(this CombinedResult<InnerApplicationCodeContentFactory, T1, T2> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3ContentLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationCodeContentFactory, T2, InnerApplicationS3ContentLocationFactory> WithS3ContentLocation<T1, T2>(this CombinedResult<T1, InnerApplicationCodeContentFactory, T2> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3ContentLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationCodeContentFactory, InnerApplicationS3ContentLocationFactory> WithS3ContentLocation<T1, T2>(this CombinedResult<T1, T2, InnerApplicationCodeContentFactory> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3ContentLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerApplicationCodeContentFactory, T1, T2, T3, InnerApplicationS3ContentLocationFactory> WithS3ContentLocation<T1, T2, T3>(this CombinedResult<InnerApplicationCodeContentFactory, T1, T2, T3> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3ContentLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationCodeContentFactory, T2, T3, InnerApplicationS3ContentLocationFactory> WithS3ContentLocation<T1, T2, T3>(this CombinedResult<T1, InnerApplicationCodeContentFactory, T2, T3> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3ContentLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationCodeContentFactory, T3, InnerApplicationS3ContentLocationFactory> WithS3ContentLocation<T1, T2, T3>(this CombinedResult<T1, T2, InnerApplicationCodeContentFactory, T3> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3ContentLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerApplicationCodeContentFactory, InnerApplicationS3ContentLocationFactory> WithS3ContentLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerApplicationCodeContentFactory> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3ContentLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerApplicationCodeContentFactory, T1, T2, T3, T4, InnerApplicationS3ContentLocationFactory> WithS3ContentLocation<T1, T2, T3, T4>(this CombinedResult<InnerApplicationCodeContentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3ContentLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationCodeContentFactory, T2, T3, T4, InnerApplicationS3ContentLocationFactory> WithS3ContentLocation<T1, T2, T3, T4>(this CombinedResult<T1, InnerApplicationCodeContentFactory, T2, T3, T4> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3ContentLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationCodeContentFactory, T3, T4, InnerApplicationS3ContentLocationFactory> WithS3ContentLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerApplicationCodeContentFactory, T3, T4> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3ContentLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerApplicationCodeContentFactory, T4, InnerApplicationS3ContentLocationFactory> WithS3ContentLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerApplicationCodeContentFactory, T4> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3ContentLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerApplicationCodeContentFactory, InnerApplicationS3ContentLocationFactory> WithS3ContentLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerApplicationCodeContentFactory> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3ContentLocation(combinedResult.T5, subFactoryAction));
}
