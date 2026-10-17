// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class ArtifactFactory(string resourceName = null, Action<Humidifier.SageMaker.Artifact> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.Artifact>(resourceName)
{

    internal InnerArtifactMetadataPropertiesFactory MetadataPropertiesFactory { get; set; }

    internal InnerArtifactArtifactSourceFactory SourceFactory { get; set; }

    protected override Humidifier.SageMaker.Artifact Create()
    {
        var artifactResult = CreateArtifact();
        factoryAction?.Invoke(artifactResult);

        return artifactResult;
    }

    private Humidifier.SageMaker.Artifact CreateArtifact()
    {
        var artifactResult = new Humidifier.SageMaker.Artifact
        {
            GivenName = InputResourceName,
        };

        return artifactResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.Artifact result)
    {
        base.CreateChildren(result);

        result.MetadataProperties ??= MetadataPropertiesFactory?.Build();
        result.Source ??= SourceFactory?.Build();
    }

} // End Of Class

public static class ArtifactFactoryExtensions
{
    public static CombinedResult<ArtifactFactory, InnerArtifactMetadataPropertiesFactory> WithMetadataProperties(this ArtifactFactory parentFactory, Action<Humidifier.SageMaker.ArtifactTypes.MetadataProperties> subFactoryAction = null)
    {
        parentFactory.MetadataPropertiesFactory = new InnerArtifactMetadataPropertiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MetadataPropertiesFactory);
    }

    public static CombinedResult<ArtifactFactory, InnerArtifactArtifactSourceFactory> WithSource(this ArtifactFactory parentFactory, Action<Humidifier.SageMaker.ArtifactTypes.ArtifactSource> subFactoryAction = null)
    {
        parentFactory.SourceFactory = new InnerArtifactArtifactSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceFactory);
    }

    public static CombinedResult<ArtifactFactory, T1, InnerArtifactMetadataPropertiesFactory> WithMetadataProperties<T1>(this CombinedResult<ArtifactFactory, T1> combinedResult, Action<Humidifier.SageMaker.ArtifactTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetadataProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ArtifactFactory, InnerArtifactMetadataPropertiesFactory> WithMetadataProperties<T1>(this CombinedResult<T1, ArtifactFactory> combinedResult, Action<Humidifier.SageMaker.ArtifactTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetadataProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ArtifactFactory, T1, T2, InnerArtifactMetadataPropertiesFactory> WithMetadataProperties<T1, T2>(this CombinedResult<ArtifactFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ArtifactTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetadataProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ArtifactFactory, T2, InnerArtifactMetadataPropertiesFactory> WithMetadataProperties<T1, T2>(this CombinedResult<T1, ArtifactFactory, T2> combinedResult, Action<Humidifier.SageMaker.ArtifactTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetadataProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ArtifactFactory, InnerArtifactMetadataPropertiesFactory> WithMetadataProperties<T1, T2>(this CombinedResult<T1, T2, ArtifactFactory> combinedResult, Action<Humidifier.SageMaker.ArtifactTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetadataProperties(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ArtifactFactory, T1, T2, T3, InnerArtifactMetadataPropertiesFactory> WithMetadataProperties<T1, T2, T3>(this CombinedResult<ArtifactFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ArtifactTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ArtifactFactory, T2, T3, InnerArtifactMetadataPropertiesFactory> WithMetadataProperties<T1, T2, T3>(this CombinedResult<T1, ArtifactFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ArtifactTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ArtifactFactory, T3, InnerArtifactMetadataPropertiesFactory> WithMetadataProperties<T1, T2, T3>(this CombinedResult<T1, T2, ArtifactFactory, T3> combinedResult, Action<Humidifier.SageMaker.ArtifactTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataProperties(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ArtifactFactory, InnerArtifactMetadataPropertiesFactory> WithMetadataProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, ArtifactFactory> combinedResult, Action<Humidifier.SageMaker.ArtifactTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataProperties(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ArtifactFactory, T1, T2, T3, T4, InnerArtifactMetadataPropertiesFactory> WithMetadataProperties<T1, T2, T3, T4>(this CombinedResult<ArtifactFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ArtifactTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ArtifactFactory, T2, T3, T4, InnerArtifactMetadataPropertiesFactory> WithMetadataProperties<T1, T2, T3, T4>(this CombinedResult<T1, ArtifactFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ArtifactTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ArtifactFactory, T3, T4, InnerArtifactMetadataPropertiesFactory> WithMetadataProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, ArtifactFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ArtifactTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataProperties(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ArtifactFactory, T4, InnerArtifactMetadataPropertiesFactory> WithMetadataProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ArtifactFactory, T4> combinedResult, Action<Humidifier.SageMaker.ArtifactTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataProperties(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ArtifactFactory, InnerArtifactMetadataPropertiesFactory> WithMetadataProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ArtifactFactory> combinedResult, Action<Humidifier.SageMaker.ArtifactTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataProperties(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<ArtifactFactory, T1, InnerArtifactArtifactSourceFactory> WithSource<T1>(this CombinedResult<ArtifactFactory, T1> combinedResult, Action<Humidifier.SageMaker.ArtifactTypes.ArtifactSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ArtifactFactory, InnerArtifactArtifactSourceFactory> WithSource<T1>(this CombinedResult<T1, ArtifactFactory> combinedResult, Action<Humidifier.SageMaker.ArtifactTypes.ArtifactSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ArtifactFactory, T1, T2, InnerArtifactArtifactSourceFactory> WithSource<T1, T2>(this CombinedResult<ArtifactFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ArtifactTypes.ArtifactSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ArtifactFactory, T2, InnerArtifactArtifactSourceFactory> WithSource<T1, T2>(this CombinedResult<T1, ArtifactFactory, T2> combinedResult, Action<Humidifier.SageMaker.ArtifactTypes.ArtifactSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ArtifactFactory, InnerArtifactArtifactSourceFactory> WithSource<T1, T2>(this CombinedResult<T1, T2, ArtifactFactory> combinedResult, Action<Humidifier.SageMaker.ArtifactTypes.ArtifactSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ArtifactFactory, T1, T2, T3, InnerArtifactArtifactSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<ArtifactFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ArtifactTypes.ArtifactSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ArtifactFactory, T2, T3, InnerArtifactArtifactSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, ArtifactFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ArtifactTypes.ArtifactSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ArtifactFactory, T3, InnerArtifactArtifactSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, T2, ArtifactFactory, T3> combinedResult, Action<Humidifier.SageMaker.ArtifactTypes.ArtifactSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ArtifactFactory, InnerArtifactArtifactSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, ArtifactFactory> combinedResult, Action<Humidifier.SageMaker.ArtifactTypes.ArtifactSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ArtifactFactory, T1, T2, T3, T4, InnerArtifactArtifactSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<ArtifactFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ArtifactTypes.ArtifactSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ArtifactFactory, T2, T3, T4, InnerArtifactArtifactSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, ArtifactFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ArtifactTypes.ArtifactSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ArtifactFactory, T3, T4, InnerArtifactArtifactSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, ArtifactFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ArtifactTypes.ArtifactSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ArtifactFactory, T4, InnerArtifactArtifactSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ArtifactFactory, T4> combinedResult, Action<Humidifier.SageMaker.ArtifactTypes.ArtifactSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ArtifactFactory, InnerArtifactArtifactSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ArtifactFactory> combinedResult, Action<Humidifier.SageMaker.ArtifactTypes.ArtifactSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T5, subFactoryAction).T2);
}
