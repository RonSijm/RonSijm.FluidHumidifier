// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodePipeline;

public class InnerPipelineArtifactStoreMapFactory(Action<Humidifier.CodePipeline.PipelineTypes.ArtifactStoreMap> factoryAction = null) : SubResourceFactory<Humidifier.CodePipeline.PipelineTypes.ArtifactStoreMap>
{

    internal InnerPipelineArtifactStoreFactory ArtifactStoreFactory { get; set; }

    protected override Humidifier.CodePipeline.PipelineTypes.ArtifactStoreMap Create()
    {
        var artifactStoreMapResult = CreateArtifactStoreMap();
        factoryAction?.Invoke(artifactStoreMapResult);

        return artifactStoreMapResult;
    }

    private Humidifier.CodePipeline.PipelineTypes.ArtifactStoreMap CreateArtifactStoreMap()
    {
        var artifactStoreMapResult = new Humidifier.CodePipeline.PipelineTypes.ArtifactStoreMap();

        return artifactStoreMapResult;
    }
    public override void CreateChildren(Humidifier.CodePipeline.PipelineTypes.ArtifactStoreMap result)
    {
        base.CreateChildren(result);

        result.ArtifactStore ??= ArtifactStoreFactory?.Build();
    }

} // End Of Class

public static class InnerPipelineArtifactStoreMapFactoryExtensions
{
    public static CombinedResult<InnerPipelineArtifactStoreMapFactory, InnerPipelineArtifactStoreFactory> WithArtifactStore(this InnerPipelineArtifactStoreMapFactory parentFactory, Action<Humidifier.CodePipeline.PipelineTypes.ArtifactStore> subFactoryAction = null)
    {
        parentFactory.ArtifactStoreFactory = new InnerPipelineArtifactStoreFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ArtifactStoreFactory);
    }

    public static CombinedResult<InnerPipelineArtifactStoreMapFactory, T1, InnerPipelineArtifactStoreFactory> WithArtifactStore<T1>(this CombinedResult<InnerPipelineArtifactStoreMapFactory, T1> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.ArtifactStore> subFactoryAction = null) => new (combinedResult, combinedResult, WithArtifactStore(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipelineArtifactStoreMapFactory, InnerPipelineArtifactStoreFactory> WithArtifactStore<T1>(this CombinedResult<T1, InnerPipelineArtifactStoreMapFactory> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.ArtifactStore> subFactoryAction = null) => new (combinedResult, combinedResult, WithArtifactStore(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPipelineArtifactStoreMapFactory, T1, T2, InnerPipelineArtifactStoreFactory> WithArtifactStore<T1, T2>(this CombinedResult<InnerPipelineArtifactStoreMapFactory, T1, T2> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.ArtifactStore> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithArtifactStore(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipelineArtifactStoreMapFactory, T2, InnerPipelineArtifactStoreFactory> WithArtifactStore<T1, T2>(this CombinedResult<T1, InnerPipelineArtifactStoreMapFactory, T2> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.ArtifactStore> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithArtifactStore(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipelineArtifactStoreMapFactory, InnerPipelineArtifactStoreFactory> WithArtifactStore<T1, T2>(this CombinedResult<T1, T2, InnerPipelineArtifactStoreMapFactory> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.ArtifactStore> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithArtifactStore(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPipelineArtifactStoreMapFactory, T1, T2, T3, InnerPipelineArtifactStoreFactory> WithArtifactStore<T1, T2, T3>(this CombinedResult<InnerPipelineArtifactStoreMapFactory, T1, T2, T3> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.ArtifactStore> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithArtifactStore(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipelineArtifactStoreMapFactory, T2, T3, InnerPipelineArtifactStoreFactory> WithArtifactStore<T1, T2, T3>(this CombinedResult<T1, InnerPipelineArtifactStoreMapFactory, T2, T3> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.ArtifactStore> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithArtifactStore(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipelineArtifactStoreMapFactory, T3, InnerPipelineArtifactStoreFactory> WithArtifactStore<T1, T2, T3>(this CombinedResult<T1, T2, InnerPipelineArtifactStoreMapFactory, T3> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.ArtifactStore> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithArtifactStore(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPipelineArtifactStoreMapFactory, InnerPipelineArtifactStoreFactory> WithArtifactStore<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPipelineArtifactStoreMapFactory> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.ArtifactStore> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithArtifactStore(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPipelineArtifactStoreMapFactory, T1, T2, T3, T4, InnerPipelineArtifactStoreFactory> WithArtifactStore<T1, T2, T3, T4>(this CombinedResult<InnerPipelineArtifactStoreMapFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.ArtifactStore> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArtifactStore(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipelineArtifactStoreMapFactory, T2, T3, T4, InnerPipelineArtifactStoreFactory> WithArtifactStore<T1, T2, T3, T4>(this CombinedResult<T1, InnerPipelineArtifactStoreMapFactory, T2, T3, T4> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.ArtifactStore> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArtifactStore(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipelineArtifactStoreMapFactory, T3, T4, InnerPipelineArtifactStoreFactory> WithArtifactStore<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPipelineArtifactStoreMapFactory, T3, T4> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.ArtifactStore> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArtifactStore(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPipelineArtifactStoreMapFactory, T4, InnerPipelineArtifactStoreFactory> WithArtifactStore<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPipelineArtifactStoreMapFactory, T4> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.ArtifactStore> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArtifactStore(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPipelineArtifactStoreMapFactory, InnerPipelineArtifactStoreFactory> WithArtifactStore<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPipelineArtifactStoreMapFactory> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.ArtifactStore> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArtifactStore(combinedResult.T5, subFactoryAction));
}
