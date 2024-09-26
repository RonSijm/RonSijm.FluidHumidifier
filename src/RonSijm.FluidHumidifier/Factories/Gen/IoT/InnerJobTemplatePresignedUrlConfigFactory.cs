// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerJobTemplatePresignedUrlConfigFactory(Action<Humidifier.IoT.JobTemplateTypes.PresignedUrlConfig> factoryAction = null) : SubResourceFactory<Humidifier.IoT.JobTemplateTypes.PresignedUrlConfig>
{

    protected override Humidifier.IoT.JobTemplateTypes.PresignedUrlConfig Create()
    {
        var presignedUrlConfigResult = CreatePresignedUrlConfig();
        factoryAction?.Invoke(presignedUrlConfigResult);

        return presignedUrlConfigResult;
    }

    private Humidifier.IoT.JobTemplateTypes.PresignedUrlConfig CreatePresignedUrlConfig()
    {
        var presignedUrlConfigResult = new Humidifier.IoT.JobTemplateTypes.PresignedUrlConfig();

        return presignedUrlConfigResult;
    }

} // End Of Class

public static class InnerJobTemplatePresignedUrlConfigFactoryExtensions
{
}
