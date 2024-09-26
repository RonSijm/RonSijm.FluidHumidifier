// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodePipeline;

public class InnerCustomActionTypeArtifactDetailsFactory(Action<Humidifier.CodePipeline.CustomActionTypeTypes.ArtifactDetails> factoryAction = null) : SubResourceFactory<Humidifier.CodePipeline.CustomActionTypeTypes.ArtifactDetails>
{

    protected override Humidifier.CodePipeline.CustomActionTypeTypes.ArtifactDetails Create()
    {
        var artifactDetailsResult = CreateArtifactDetails();
        factoryAction?.Invoke(artifactDetailsResult);

        return artifactDetailsResult;
    }

    private Humidifier.CodePipeline.CustomActionTypeTypes.ArtifactDetails CreateArtifactDetails()
    {
        var artifactDetailsResult = new Humidifier.CodePipeline.CustomActionTypeTypes.ArtifactDetails();

        return artifactDetailsResult;
    }

} // End Of Class

public static class InnerCustomActionTypeArtifactDetailsFactoryExtensions
{
}
