// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchService;

public class InnerDomainAIMLOptionsFactory(Action<Humidifier.OpenSearchService.DomainTypes.AIMLOptions> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearchService.DomainTypes.AIMLOptions>
{

    internal InnerDomainS3VectorsEngineFactory S3VectorsEngineFactory { get; set; }

    internal InnerDomainServerlessVectorAccelerationFactory ServerlessVectorAccelerationFactory { get; set; }

    protected override Humidifier.OpenSearchService.DomainTypes.AIMLOptions Create()
    {
        var aIMLOptionsResult = CreateAIMLOptions();
        factoryAction?.Invoke(aIMLOptionsResult);

        return aIMLOptionsResult;
    }

    private Humidifier.OpenSearchService.DomainTypes.AIMLOptions CreateAIMLOptions()
    {
        var aIMLOptionsResult = new Humidifier.OpenSearchService.DomainTypes.AIMLOptions();

        return aIMLOptionsResult;
    }
    public override void CreateChildren(Humidifier.OpenSearchService.DomainTypes.AIMLOptions result)
    {
        base.CreateChildren(result);

        result.S3VectorsEngine ??= S3VectorsEngineFactory?.Build();
        result.ServerlessVectorAcceleration ??= ServerlessVectorAccelerationFactory?.Build();
    }

} // End Of Class

public static class InnerDomainAIMLOptionsFactoryExtensions
{
    public static CombinedResult<InnerDomainAIMLOptionsFactory, InnerDomainS3VectorsEngineFactory> WithS3VectorsEngine(this InnerDomainAIMLOptionsFactory parentFactory, Action<Humidifier.OpenSearchService.DomainTypes.S3VectorsEngine> subFactoryAction = null)
    {
        parentFactory.S3VectorsEngineFactory = new InnerDomainS3VectorsEngineFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3VectorsEngineFactory);
    }

    public static CombinedResult<InnerDomainAIMLOptionsFactory, InnerDomainServerlessVectorAccelerationFactory> WithServerlessVectorAcceleration(this InnerDomainAIMLOptionsFactory parentFactory, Action<Humidifier.OpenSearchService.DomainTypes.ServerlessVectorAcceleration> subFactoryAction = null)
    {
        parentFactory.ServerlessVectorAccelerationFactory = new InnerDomainServerlessVectorAccelerationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ServerlessVectorAccelerationFactory);
    }

    public static CombinedResult<InnerDomainAIMLOptionsFactory, T1, InnerDomainS3VectorsEngineFactory> WithS3VectorsEngine<T1>(this CombinedResult<InnerDomainAIMLOptionsFactory, T1> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.S3VectorsEngine> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3VectorsEngine(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDomainAIMLOptionsFactory, InnerDomainS3VectorsEngineFactory> WithS3VectorsEngine<T1>(this CombinedResult<T1, InnerDomainAIMLOptionsFactory> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.S3VectorsEngine> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3VectorsEngine(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDomainAIMLOptionsFactory, T1, T2, InnerDomainS3VectorsEngineFactory> WithS3VectorsEngine<T1, T2>(this CombinedResult<InnerDomainAIMLOptionsFactory, T1, T2> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.S3VectorsEngine> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3VectorsEngine(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDomainAIMLOptionsFactory, T2, InnerDomainS3VectorsEngineFactory> WithS3VectorsEngine<T1, T2>(this CombinedResult<T1, InnerDomainAIMLOptionsFactory, T2> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.S3VectorsEngine> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3VectorsEngine(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDomainAIMLOptionsFactory, InnerDomainS3VectorsEngineFactory> WithS3VectorsEngine<T1, T2>(this CombinedResult<T1, T2, InnerDomainAIMLOptionsFactory> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.S3VectorsEngine> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3VectorsEngine(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDomainAIMLOptionsFactory, T1, T2, T3, InnerDomainS3VectorsEngineFactory> WithS3VectorsEngine<T1, T2, T3>(this CombinedResult<InnerDomainAIMLOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.S3VectorsEngine> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3VectorsEngine(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDomainAIMLOptionsFactory, T2, T3, InnerDomainS3VectorsEngineFactory> WithS3VectorsEngine<T1, T2, T3>(this CombinedResult<T1, InnerDomainAIMLOptionsFactory, T2, T3> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.S3VectorsEngine> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3VectorsEngine(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDomainAIMLOptionsFactory, T3, InnerDomainS3VectorsEngineFactory> WithS3VectorsEngine<T1, T2, T3>(this CombinedResult<T1, T2, InnerDomainAIMLOptionsFactory, T3> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.S3VectorsEngine> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3VectorsEngine(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDomainAIMLOptionsFactory, InnerDomainS3VectorsEngineFactory> WithS3VectorsEngine<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDomainAIMLOptionsFactory> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.S3VectorsEngine> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3VectorsEngine(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDomainAIMLOptionsFactory, T1, T2, T3, T4, InnerDomainS3VectorsEngineFactory> WithS3VectorsEngine<T1, T2, T3, T4>(this CombinedResult<InnerDomainAIMLOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.S3VectorsEngine> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3VectorsEngine(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDomainAIMLOptionsFactory, T2, T3, T4, InnerDomainS3VectorsEngineFactory> WithS3VectorsEngine<T1, T2, T3, T4>(this CombinedResult<T1, InnerDomainAIMLOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.S3VectorsEngine> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3VectorsEngine(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDomainAIMLOptionsFactory, T3, T4, InnerDomainS3VectorsEngineFactory> WithS3VectorsEngine<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDomainAIMLOptionsFactory, T3, T4> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.S3VectorsEngine> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3VectorsEngine(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDomainAIMLOptionsFactory, T4, InnerDomainS3VectorsEngineFactory> WithS3VectorsEngine<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDomainAIMLOptionsFactory, T4> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.S3VectorsEngine> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3VectorsEngine(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDomainAIMLOptionsFactory, InnerDomainS3VectorsEngineFactory> WithS3VectorsEngine<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDomainAIMLOptionsFactory> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.S3VectorsEngine> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3VectorsEngine(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerDomainAIMLOptionsFactory, T1, InnerDomainServerlessVectorAccelerationFactory> WithServerlessVectorAcceleration<T1>(this CombinedResult<InnerDomainAIMLOptionsFactory, T1> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ServerlessVectorAcceleration> subFactoryAction = null) => new (combinedResult, combinedResult, WithServerlessVectorAcceleration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDomainAIMLOptionsFactory, InnerDomainServerlessVectorAccelerationFactory> WithServerlessVectorAcceleration<T1>(this CombinedResult<T1, InnerDomainAIMLOptionsFactory> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ServerlessVectorAcceleration> subFactoryAction = null) => new (combinedResult, combinedResult, WithServerlessVectorAcceleration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDomainAIMLOptionsFactory, T1, T2, InnerDomainServerlessVectorAccelerationFactory> WithServerlessVectorAcceleration<T1, T2>(this CombinedResult<InnerDomainAIMLOptionsFactory, T1, T2> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ServerlessVectorAcceleration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServerlessVectorAcceleration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDomainAIMLOptionsFactory, T2, InnerDomainServerlessVectorAccelerationFactory> WithServerlessVectorAcceleration<T1, T2>(this CombinedResult<T1, InnerDomainAIMLOptionsFactory, T2> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ServerlessVectorAcceleration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServerlessVectorAcceleration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDomainAIMLOptionsFactory, InnerDomainServerlessVectorAccelerationFactory> WithServerlessVectorAcceleration<T1, T2>(this CombinedResult<T1, T2, InnerDomainAIMLOptionsFactory> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ServerlessVectorAcceleration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServerlessVectorAcceleration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDomainAIMLOptionsFactory, T1, T2, T3, InnerDomainServerlessVectorAccelerationFactory> WithServerlessVectorAcceleration<T1, T2, T3>(this CombinedResult<InnerDomainAIMLOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ServerlessVectorAcceleration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerlessVectorAcceleration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDomainAIMLOptionsFactory, T2, T3, InnerDomainServerlessVectorAccelerationFactory> WithServerlessVectorAcceleration<T1, T2, T3>(this CombinedResult<T1, InnerDomainAIMLOptionsFactory, T2, T3> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ServerlessVectorAcceleration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerlessVectorAcceleration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDomainAIMLOptionsFactory, T3, InnerDomainServerlessVectorAccelerationFactory> WithServerlessVectorAcceleration<T1, T2, T3>(this CombinedResult<T1, T2, InnerDomainAIMLOptionsFactory, T3> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ServerlessVectorAcceleration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerlessVectorAcceleration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDomainAIMLOptionsFactory, InnerDomainServerlessVectorAccelerationFactory> WithServerlessVectorAcceleration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDomainAIMLOptionsFactory> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ServerlessVectorAcceleration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerlessVectorAcceleration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDomainAIMLOptionsFactory, T1, T2, T3, T4, InnerDomainServerlessVectorAccelerationFactory> WithServerlessVectorAcceleration<T1, T2, T3, T4>(this CombinedResult<InnerDomainAIMLOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ServerlessVectorAcceleration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerlessVectorAcceleration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDomainAIMLOptionsFactory, T2, T3, T4, InnerDomainServerlessVectorAccelerationFactory> WithServerlessVectorAcceleration<T1, T2, T3, T4>(this CombinedResult<T1, InnerDomainAIMLOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ServerlessVectorAcceleration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerlessVectorAcceleration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDomainAIMLOptionsFactory, T3, T4, InnerDomainServerlessVectorAccelerationFactory> WithServerlessVectorAcceleration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDomainAIMLOptionsFactory, T3, T4> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ServerlessVectorAcceleration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerlessVectorAcceleration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDomainAIMLOptionsFactory, T4, InnerDomainServerlessVectorAccelerationFactory> WithServerlessVectorAcceleration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDomainAIMLOptionsFactory, T4> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ServerlessVectorAcceleration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerlessVectorAcceleration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDomainAIMLOptionsFactory, InnerDomainServerlessVectorAccelerationFactory> WithServerlessVectorAcceleration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDomainAIMLOptionsFactory> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ServerlessVectorAcceleration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerlessVectorAcceleration(combinedResult.T5, subFactoryAction).T2);
}
