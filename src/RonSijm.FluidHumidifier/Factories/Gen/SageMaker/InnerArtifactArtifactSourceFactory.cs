// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerArtifactArtifactSourceFactory(Action<Humidifier.SageMaker.ArtifactTypes.ArtifactSource> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ArtifactTypes.ArtifactSource>
{

    protected override Humidifier.SageMaker.ArtifactTypes.ArtifactSource Create()
    {
        var artifactSourceResult = CreateArtifactSource();
        factoryAction?.Invoke(artifactSourceResult);

        return artifactSourceResult;
    }

    private Humidifier.SageMaker.ArtifactTypes.ArtifactSource CreateArtifactSource()
    {
        var artifactSourceResult = new Humidifier.SageMaker.ArtifactTypes.ArtifactSource();

        return artifactSourceResult;
    }

} // End Of Class

public static class InnerArtifactArtifactSourceFactoryExtensions
{
}
