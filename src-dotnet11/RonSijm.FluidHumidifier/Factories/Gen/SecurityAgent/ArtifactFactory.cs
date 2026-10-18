// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityAgent;

public class ArtifactFactory(string resourceName = null, Action<Humidifier.SecurityAgent.Artifact> factoryAction = null) : ResourceFactory<Humidifier.SecurityAgent.Artifact>(resourceName)
{

    protected override Humidifier.SecurityAgent.Artifact Create()
    {
        var artifactResult = CreateArtifact();
        factoryAction?.Invoke(artifactResult);

        return artifactResult;
    }

    private Humidifier.SecurityAgent.Artifact CreateArtifact()
    {
        var artifactResult = new Humidifier.SecurityAgent.Artifact
        {
            GivenName = InputResourceName,
        };

        return artifactResult;
    }

} // End Of Class

public static class ArtifactFactoryExtensions
{
}
