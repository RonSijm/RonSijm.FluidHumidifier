// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeBuild;

public class BuildFactory(string resourceName = null, Action<Humidifier.CodeBuild.Build> factoryAction = null) : ResourceFactory<Humidifier.CodeBuild.Build>(resourceName)
{

    protected override Humidifier.CodeBuild.Build Create()
    {
        var buildResult = CreateBuild();
        factoryAction?.Invoke(buildResult);

        return buildResult;
    }

    private Humidifier.CodeBuild.Build CreateBuild()
    {
        var buildResult = new Humidifier.CodeBuild.Build
        {
            GivenName = InputResourceName,
        };

        return buildResult;
    }

} // End Of Class

public static class BuildFactoryExtensions
{
}
