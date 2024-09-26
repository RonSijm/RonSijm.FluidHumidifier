// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeBuild;

public class InnerProjectArtifactsFactory(Action<Humidifier.CodeBuild.ProjectTypes.Artifacts> factoryAction = null) : SubResourceFactory<Humidifier.CodeBuild.ProjectTypes.Artifacts>
{

    protected override Humidifier.CodeBuild.ProjectTypes.Artifacts Create()
    {
        var artifactsResult = CreateArtifacts();
        factoryAction?.Invoke(artifactsResult);

        return artifactsResult;
    }

    private Humidifier.CodeBuild.ProjectTypes.Artifacts CreateArtifacts()
    {
        var artifactsResult = new Humidifier.CodeBuild.ProjectTypes.Artifacts();

        return artifactsResult;
    }

} // End Of Class

public static class InnerProjectArtifactsFactoryExtensions
{
}
