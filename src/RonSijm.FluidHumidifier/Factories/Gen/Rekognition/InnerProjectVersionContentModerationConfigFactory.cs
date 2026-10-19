// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Rekognition;

public class InnerProjectVersionContentModerationConfigFactory(Action<Humidifier.Rekognition.ProjectVersionTypes.ContentModerationConfig> factoryAction = null) : SubResourceFactory<Humidifier.Rekognition.ProjectVersionTypes.ContentModerationConfig>
{

    protected override Humidifier.Rekognition.ProjectVersionTypes.ContentModerationConfig Create()
    {
        var contentModerationConfigResult = CreateContentModerationConfig();
        factoryAction?.Invoke(contentModerationConfigResult);

        return contentModerationConfigResult;
    }

    private Humidifier.Rekognition.ProjectVersionTypes.ContentModerationConfig CreateContentModerationConfig()
    {
        var contentModerationConfigResult = new Humidifier.Rekognition.ProjectVersionTypes.ContentModerationConfig();

        return contentModerationConfigResult;
    }

} // End Of Class

public static class InnerProjectVersionContentModerationConfigFactoryExtensions
{
}
