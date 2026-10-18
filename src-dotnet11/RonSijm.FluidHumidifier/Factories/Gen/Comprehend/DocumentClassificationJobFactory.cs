// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Comprehend;

public class DocumentClassificationJobFactory(string resourceName = null, Action<Humidifier.Comprehend.DocumentClassificationJob> factoryAction = null) : ResourceFactory<Humidifier.Comprehend.DocumentClassificationJob>(resourceName)
{

    internal InnerDocumentClassificationJobInputDataConfigFactory InputDataConfigFactory { get; set; }

    protected override Humidifier.Comprehend.DocumentClassificationJob Create()
    {
        var documentClassificationJobResult = CreateDocumentClassificationJob();
        factoryAction?.Invoke(documentClassificationJobResult);

        return documentClassificationJobResult;
    }

    private Humidifier.Comprehend.DocumentClassificationJob CreateDocumentClassificationJob()
    {
        var documentClassificationJobResult = new Humidifier.Comprehend.DocumentClassificationJob
        {
            GivenName = InputResourceName,
        };

        return documentClassificationJobResult;
    }
    public override void CreateChildren(Humidifier.Comprehend.DocumentClassificationJob result)
    {
        base.CreateChildren(result);

        result.InputDataConfig ??= InputDataConfigFactory?.Build();
    }

} // End Of Class

public static class DocumentClassificationJobFactoryExtensions
{
    public static CombinedResult<DocumentClassificationJobFactory, InnerDocumentClassificationJobInputDataConfigFactory> WithInputDataConfig(this DocumentClassificationJobFactory parentFactory, Action<Humidifier.Comprehend.DocumentClassificationJobTypes.InputDataConfig> subFactoryAction = null)
    {
        parentFactory.InputDataConfigFactory = new InnerDocumentClassificationJobInputDataConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InputDataConfigFactory);
    }

    public static CombinedResult<DocumentClassificationJobFactory, T1, InnerDocumentClassificationJobInputDataConfigFactory> WithInputDataConfig<T1>(this CombinedResult<DocumentClassificationJobFactory, T1> combinedResult, Action<Humidifier.Comprehend.DocumentClassificationJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputDataConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DocumentClassificationJobFactory, InnerDocumentClassificationJobInputDataConfigFactory> WithInputDataConfig<T1>(this CombinedResult<T1, DocumentClassificationJobFactory> combinedResult, Action<Humidifier.Comprehend.DocumentClassificationJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputDataConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<DocumentClassificationJobFactory, T1, T2, InnerDocumentClassificationJobInputDataConfigFactory> WithInputDataConfig<T1, T2>(this CombinedResult<DocumentClassificationJobFactory, T1, T2> combinedResult, Action<Humidifier.Comprehend.DocumentClassificationJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DocumentClassificationJobFactory, T2, InnerDocumentClassificationJobInputDataConfigFactory> WithInputDataConfig<T1, T2>(this CombinedResult<T1, DocumentClassificationJobFactory, T2> combinedResult, Action<Humidifier.Comprehend.DocumentClassificationJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DocumentClassificationJobFactory, InnerDocumentClassificationJobInputDataConfigFactory> WithInputDataConfig<T1, T2>(this CombinedResult<T1, T2, DocumentClassificationJobFactory> combinedResult, Action<Humidifier.Comprehend.DocumentClassificationJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<DocumentClassificationJobFactory, T1, T2, T3, InnerDocumentClassificationJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3>(this CombinedResult<DocumentClassificationJobFactory, T1, T2, T3> combinedResult, Action<Humidifier.Comprehend.DocumentClassificationJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DocumentClassificationJobFactory, T2, T3, InnerDocumentClassificationJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3>(this CombinedResult<T1, DocumentClassificationJobFactory, T2, T3> combinedResult, Action<Humidifier.Comprehend.DocumentClassificationJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DocumentClassificationJobFactory, T3, InnerDocumentClassificationJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3>(this CombinedResult<T1, T2, DocumentClassificationJobFactory, T3> combinedResult, Action<Humidifier.Comprehend.DocumentClassificationJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DocumentClassificationJobFactory, InnerDocumentClassificationJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, DocumentClassificationJobFactory> combinedResult, Action<Humidifier.Comprehend.DocumentClassificationJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<DocumentClassificationJobFactory, T1, T2, T3, T4, InnerDocumentClassificationJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3, T4>(this CombinedResult<DocumentClassificationJobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Comprehend.DocumentClassificationJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DocumentClassificationJobFactory, T2, T3, T4, InnerDocumentClassificationJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3, T4>(this CombinedResult<T1, DocumentClassificationJobFactory, T2, T3, T4> combinedResult, Action<Humidifier.Comprehend.DocumentClassificationJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DocumentClassificationJobFactory, T3, T4, InnerDocumentClassificationJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, DocumentClassificationJobFactory, T3, T4> combinedResult, Action<Humidifier.Comprehend.DocumentClassificationJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DocumentClassificationJobFactory, T4, InnerDocumentClassificationJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DocumentClassificationJobFactory, T4> combinedResult, Action<Humidifier.Comprehend.DocumentClassificationJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, DocumentClassificationJobFactory, InnerDocumentClassificationJobInputDataConfigFactory> WithInputDataConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DocumentClassificationJobFactory> combinedResult, Action<Humidifier.Comprehend.DocumentClassificationJobTypes.InputDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDataConfig(combinedResult.T5, subFactoryAction).T2);
}
