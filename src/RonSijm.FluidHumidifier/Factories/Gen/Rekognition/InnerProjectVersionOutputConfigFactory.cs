// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Rekognition;

public class InnerProjectVersionOutputConfigFactory(Action<Humidifier.Rekognition.ProjectVersionTypes.OutputConfig> factoryAction = null) : SubResourceFactory<Humidifier.Rekognition.ProjectVersionTypes.OutputConfig>
{

    protected override Humidifier.Rekognition.ProjectVersionTypes.OutputConfig Create()
    {
        var outputConfigResult = CreateOutputConfig();
        factoryAction?.Invoke(outputConfigResult);

        return outputConfigResult;
    }

    private Humidifier.Rekognition.ProjectVersionTypes.OutputConfig CreateOutputConfig()
    {
        var outputConfigResult = new Humidifier.Rekognition.ProjectVersionTypes.OutputConfig();

        return outputConfigResult;
    }

} // End Of Class

public static class InnerProjectVersionOutputConfigFactoryExtensions
{
}
