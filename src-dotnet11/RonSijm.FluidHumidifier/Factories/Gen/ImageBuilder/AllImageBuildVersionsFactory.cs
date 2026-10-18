// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class AllImageBuildVersionsFactory(string resourceName = null, Action<Humidifier.ImageBuilder.AllImageBuildVersions> factoryAction = null) : ResourceFactory<Humidifier.ImageBuilder.AllImageBuildVersions>(resourceName)
{

    protected override Humidifier.ImageBuilder.AllImageBuildVersions Create()
    {
        var allImageBuildVersionsResult = CreateAllImageBuildVersions();
        factoryAction?.Invoke(allImageBuildVersionsResult);

        return allImageBuildVersionsResult;
    }

    private Humidifier.ImageBuilder.AllImageBuildVersions CreateAllImageBuildVersions()
    {
        var allImageBuildVersionsResult = new Humidifier.ImageBuilder.AllImageBuildVersions
        {
            GivenName = InputResourceName,
        };

        return allImageBuildVersionsResult;
    }

} // End Of Class

public static class AllImageBuildVersionsFactoryExtensions
{
}
