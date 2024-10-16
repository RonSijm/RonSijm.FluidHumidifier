// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class FaqFactory(string resourceName = null, Action<Humidifier.Kendra.Faq> factoryAction = null) : ResourceFactory<Humidifier.Kendra.Faq>(resourceName)
{

    internal InnerFaqS3PathFactory S3PathFactory { get; set; }

    protected override Humidifier.Kendra.Faq Create()
    {
        var faqResult = CreateFaq();
        factoryAction?.Invoke(faqResult);

        return faqResult;
    }

    private Humidifier.Kendra.Faq CreateFaq()
    {
        var faqResult = new Humidifier.Kendra.Faq
        {
            GivenName = InputResourceName,
        };

        return faqResult;
    }
    public override void CreateChildren(Humidifier.Kendra.Faq result)
    {
        base.CreateChildren(result);

        result.S3Path ??= S3PathFactory?.Build();
    }

} // End Of Class

public static class FaqFactoryExtensions
{
    public static CombinedResult<FaqFactory, InnerFaqS3PathFactory> WithS3Path(this FaqFactory parentFactory, Action<Humidifier.Kendra.FaqTypes.S3Path> subFactoryAction = null)
    {
        parentFactory.S3PathFactory = new InnerFaqS3PathFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3PathFactory);
    }

    public static CombinedResult<FaqFactory, T1, InnerFaqS3PathFactory> WithS3Path<T1>(this CombinedResult<FaqFactory, T1> combinedResult, Action<Humidifier.Kendra.FaqTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Path(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FaqFactory, InnerFaqS3PathFactory> WithS3Path<T1>(this CombinedResult<T1, FaqFactory> combinedResult, Action<Humidifier.Kendra.FaqTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Path(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FaqFactory, T1, T2, InnerFaqS3PathFactory> WithS3Path<T1, T2>(this CombinedResult<FaqFactory, T1, T2> combinedResult, Action<Humidifier.Kendra.FaqTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Path(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FaqFactory, T2, InnerFaqS3PathFactory> WithS3Path<T1, T2>(this CombinedResult<T1, FaqFactory, T2> combinedResult, Action<Humidifier.Kendra.FaqTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Path(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FaqFactory, InnerFaqS3PathFactory> WithS3Path<T1, T2>(this CombinedResult<T1, T2, FaqFactory> combinedResult, Action<Humidifier.Kendra.FaqTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Path(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FaqFactory, T1, T2, T3, InnerFaqS3PathFactory> WithS3Path<T1, T2, T3>(this CombinedResult<FaqFactory, T1, T2, T3> combinedResult, Action<Humidifier.Kendra.FaqTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Path(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FaqFactory, T2, T3, InnerFaqS3PathFactory> WithS3Path<T1, T2, T3>(this CombinedResult<T1, FaqFactory, T2, T3> combinedResult, Action<Humidifier.Kendra.FaqTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Path(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FaqFactory, T3, InnerFaqS3PathFactory> WithS3Path<T1, T2, T3>(this CombinedResult<T1, T2, FaqFactory, T3> combinedResult, Action<Humidifier.Kendra.FaqTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Path(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FaqFactory, InnerFaqS3PathFactory> WithS3Path<T1, T2, T3>(this CombinedResult<T1, T2, T3, FaqFactory> combinedResult, Action<Humidifier.Kendra.FaqTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Path(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FaqFactory, T1, T2, T3, T4, InnerFaqS3PathFactory> WithS3Path<T1, T2, T3, T4>(this CombinedResult<FaqFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Kendra.FaqTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Path(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FaqFactory, T2, T3, T4, InnerFaqS3PathFactory> WithS3Path<T1, T2, T3, T4>(this CombinedResult<T1, FaqFactory, T2, T3, T4> combinedResult, Action<Humidifier.Kendra.FaqTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Path(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FaqFactory, T3, T4, InnerFaqS3PathFactory> WithS3Path<T1, T2, T3, T4>(this CombinedResult<T1, T2, FaqFactory, T3, T4> combinedResult, Action<Humidifier.Kendra.FaqTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Path(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FaqFactory, T4, InnerFaqS3PathFactory> WithS3Path<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FaqFactory, T4> combinedResult, Action<Humidifier.Kendra.FaqTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Path(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FaqFactory, InnerFaqS3PathFactory> WithS3Path<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FaqFactory> combinedResult, Action<Humidifier.Kendra.FaqTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Path(combinedResult.T5, subFactoryAction));
}
