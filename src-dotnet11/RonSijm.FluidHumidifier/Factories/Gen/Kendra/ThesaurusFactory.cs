// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class ThesaurusFactory(string resourceName = null, Action<Humidifier.Kendra.Thesaurus> factoryAction = null) : ResourceFactory<Humidifier.Kendra.Thesaurus>(resourceName)
{

    internal InnerThesaurusS3PathFactory SourceS3PathFactory { get; set; }

    protected override Humidifier.Kendra.Thesaurus Create()
    {
        var thesaurusResult = CreateThesaurus();
        factoryAction?.Invoke(thesaurusResult);

        return thesaurusResult;
    }

    private Humidifier.Kendra.Thesaurus CreateThesaurus()
    {
        var thesaurusResult = new Humidifier.Kendra.Thesaurus
        {
            GivenName = InputResourceName,
        };

        return thesaurusResult;
    }
    public override void CreateChildren(Humidifier.Kendra.Thesaurus result)
    {
        base.CreateChildren(result);

        result.SourceS3Path ??= SourceS3PathFactory?.Build();
    }

} // End Of Class

public static class ThesaurusFactoryExtensions
{
    public static CombinedResult<ThesaurusFactory, InnerThesaurusS3PathFactory> WithSourceS3Path(this ThesaurusFactory parentFactory, Action<Humidifier.Kendra.ThesaurusTypes.S3Path> subFactoryAction = null)
    {
        parentFactory.SourceS3PathFactory = new InnerThesaurusS3PathFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceS3PathFactory);
    }

    public static CombinedResult<ThesaurusFactory, T1, InnerThesaurusS3PathFactory> WithSourceS3Path<T1>(this CombinedResult<ThesaurusFactory, T1> combinedResult, Action<Humidifier.Kendra.ThesaurusTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceS3Path(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ThesaurusFactory, InnerThesaurusS3PathFactory> WithSourceS3Path<T1>(this CombinedResult<T1, ThesaurusFactory> combinedResult, Action<Humidifier.Kendra.ThesaurusTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceS3Path(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ThesaurusFactory, T1, T2, InnerThesaurusS3PathFactory> WithSourceS3Path<T1, T2>(this CombinedResult<ThesaurusFactory, T1, T2> combinedResult, Action<Humidifier.Kendra.ThesaurusTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceS3Path(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ThesaurusFactory, T2, InnerThesaurusS3PathFactory> WithSourceS3Path<T1, T2>(this CombinedResult<T1, ThesaurusFactory, T2> combinedResult, Action<Humidifier.Kendra.ThesaurusTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceS3Path(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ThesaurusFactory, InnerThesaurusS3PathFactory> WithSourceS3Path<T1, T2>(this CombinedResult<T1, T2, ThesaurusFactory> combinedResult, Action<Humidifier.Kendra.ThesaurusTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceS3Path(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ThesaurusFactory, T1, T2, T3, InnerThesaurusS3PathFactory> WithSourceS3Path<T1, T2, T3>(this CombinedResult<ThesaurusFactory, T1, T2, T3> combinedResult, Action<Humidifier.Kendra.ThesaurusTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceS3Path(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ThesaurusFactory, T2, T3, InnerThesaurusS3PathFactory> WithSourceS3Path<T1, T2, T3>(this CombinedResult<T1, ThesaurusFactory, T2, T3> combinedResult, Action<Humidifier.Kendra.ThesaurusTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceS3Path(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ThesaurusFactory, T3, InnerThesaurusS3PathFactory> WithSourceS3Path<T1, T2, T3>(this CombinedResult<T1, T2, ThesaurusFactory, T3> combinedResult, Action<Humidifier.Kendra.ThesaurusTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceS3Path(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ThesaurusFactory, InnerThesaurusS3PathFactory> WithSourceS3Path<T1, T2, T3>(this CombinedResult<T1, T2, T3, ThesaurusFactory> combinedResult, Action<Humidifier.Kendra.ThesaurusTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceS3Path(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ThesaurusFactory, T1, T2, T3, T4, InnerThesaurusS3PathFactory> WithSourceS3Path<T1, T2, T3, T4>(this CombinedResult<ThesaurusFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Kendra.ThesaurusTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceS3Path(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ThesaurusFactory, T2, T3, T4, InnerThesaurusS3PathFactory> WithSourceS3Path<T1, T2, T3, T4>(this CombinedResult<T1, ThesaurusFactory, T2, T3, T4> combinedResult, Action<Humidifier.Kendra.ThesaurusTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceS3Path(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ThesaurusFactory, T3, T4, InnerThesaurusS3PathFactory> WithSourceS3Path<T1, T2, T3, T4>(this CombinedResult<T1, T2, ThesaurusFactory, T3, T4> combinedResult, Action<Humidifier.Kendra.ThesaurusTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceS3Path(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ThesaurusFactory, T4, InnerThesaurusS3PathFactory> WithSourceS3Path<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ThesaurusFactory, T4> combinedResult, Action<Humidifier.Kendra.ThesaurusTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceS3Path(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ThesaurusFactory, InnerThesaurusS3PathFactory> WithSourceS3Path<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ThesaurusFactory> combinedResult, Action<Humidifier.Kendra.ThesaurusTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceS3Path(combinedResult.T5, subFactoryAction).T2);
}
