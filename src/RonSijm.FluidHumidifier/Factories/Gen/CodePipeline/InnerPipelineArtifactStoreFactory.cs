// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodePipeline;

public class InnerPipelineArtifactStoreFactory(Action<Humidifier.CodePipeline.PipelineTypes.ArtifactStore> factoryAction = null) : SubResourceFactory<Humidifier.CodePipeline.PipelineTypes.ArtifactStore>
{

    internal InnerPipelineEncryptionKeyFactory EncryptionKeyFactory { get; set; }

    protected override Humidifier.CodePipeline.PipelineTypes.ArtifactStore Create()
    {
        var artifactStoreResult = CreateArtifactStore();
        factoryAction?.Invoke(artifactStoreResult);

        return artifactStoreResult;
    }

    private Humidifier.CodePipeline.PipelineTypes.ArtifactStore CreateArtifactStore()
    {
        var artifactStoreResult = new Humidifier.CodePipeline.PipelineTypes.ArtifactStore();

        return artifactStoreResult;
    }
    public override void CreateChildren(Humidifier.CodePipeline.PipelineTypes.ArtifactStore result)
    {
        base.CreateChildren(result);

        result.EncryptionKey ??= EncryptionKeyFactory?.Build();
    }

} // End Of Class

public static class InnerPipelineArtifactStoreFactoryExtensions
{
    public static CombinedResult<InnerPipelineArtifactStoreFactory, InnerPipelineEncryptionKeyFactory> WithEncryptionKey(this InnerPipelineArtifactStoreFactory parentFactory, Action<Humidifier.CodePipeline.PipelineTypes.EncryptionKey> subFactoryAction = null)
    {
        parentFactory.EncryptionKeyFactory = new InnerPipelineEncryptionKeyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionKeyFactory);
    }

    public static CombinedResult<InnerPipelineArtifactStoreFactory, T1, InnerPipelineEncryptionKeyFactory> WithEncryptionKey<T1>(this CombinedResult<InnerPipelineArtifactStoreFactory, T1> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionKey(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipelineArtifactStoreFactory, InnerPipelineEncryptionKeyFactory> WithEncryptionKey<T1>(this CombinedResult<T1, InnerPipelineArtifactStoreFactory> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionKey(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPipelineArtifactStoreFactory, T1, T2, InnerPipelineEncryptionKeyFactory> WithEncryptionKey<T1, T2>(this CombinedResult<InnerPipelineArtifactStoreFactory, T1, T2> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipelineArtifactStoreFactory, T2, InnerPipelineEncryptionKeyFactory> WithEncryptionKey<T1, T2>(this CombinedResult<T1, InnerPipelineArtifactStoreFactory, T2> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipelineArtifactStoreFactory, InnerPipelineEncryptionKeyFactory> WithEncryptionKey<T1, T2>(this CombinedResult<T1, T2, InnerPipelineArtifactStoreFactory> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPipelineArtifactStoreFactory, T1, T2, T3, InnerPipelineEncryptionKeyFactory> WithEncryptionKey<T1, T2, T3>(this CombinedResult<InnerPipelineArtifactStoreFactory, T1, T2, T3> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipelineArtifactStoreFactory, T2, T3, InnerPipelineEncryptionKeyFactory> WithEncryptionKey<T1, T2, T3>(this CombinedResult<T1, InnerPipelineArtifactStoreFactory, T2, T3> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipelineArtifactStoreFactory, T3, InnerPipelineEncryptionKeyFactory> WithEncryptionKey<T1, T2, T3>(this CombinedResult<T1, T2, InnerPipelineArtifactStoreFactory, T3> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPipelineArtifactStoreFactory, InnerPipelineEncryptionKeyFactory> WithEncryptionKey<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPipelineArtifactStoreFactory> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPipelineArtifactStoreFactory, T1, T2, T3, T4, InnerPipelineEncryptionKeyFactory> WithEncryptionKey<T1, T2, T3, T4>(this CombinedResult<InnerPipelineArtifactStoreFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipelineArtifactStoreFactory, T2, T3, T4, InnerPipelineEncryptionKeyFactory> WithEncryptionKey<T1, T2, T3, T4>(this CombinedResult<T1, InnerPipelineArtifactStoreFactory, T2, T3, T4> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipelineArtifactStoreFactory, T3, T4, InnerPipelineEncryptionKeyFactory> WithEncryptionKey<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPipelineArtifactStoreFactory, T3, T4> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPipelineArtifactStoreFactory, T4, InnerPipelineEncryptionKeyFactory> WithEncryptionKey<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPipelineArtifactStoreFactory, T4> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPipelineArtifactStoreFactory, InnerPipelineEncryptionKeyFactory> WithEncryptionKey<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPipelineArtifactStoreFactory> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T5, subFactoryAction));
}
