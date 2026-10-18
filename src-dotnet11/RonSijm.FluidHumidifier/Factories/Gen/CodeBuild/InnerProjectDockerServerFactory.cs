// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeBuild;

public class InnerProjectDockerServerFactory(Action<Humidifier.CodeBuild.ProjectTypes.DockerServer> factoryAction = null) : SubResourceFactory<Humidifier.CodeBuild.ProjectTypes.DockerServer>
{

    protected override Humidifier.CodeBuild.ProjectTypes.DockerServer Create()
    {
        var dockerServerResult = CreateDockerServer();
        factoryAction?.Invoke(dockerServerResult);

        return dockerServerResult;
    }

    private Humidifier.CodeBuild.ProjectTypes.DockerServer CreateDockerServer()
    {
        var dockerServerResult = new Humidifier.CodeBuild.ProjectTypes.DockerServer();

        return dockerServerResult;
    }

} // End Of Class

public static class InnerProjectDockerServerFactoryExtensions
{
}
