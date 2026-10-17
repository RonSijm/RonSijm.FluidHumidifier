// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerJobPresignedUrlConfigFactory(Action<Humidifier.IoT.JobTypes.PresignedUrlConfig> factoryAction = null) : SubResourceFactory<Humidifier.IoT.JobTypes.PresignedUrlConfig>
{

    protected override Humidifier.IoT.JobTypes.PresignedUrlConfig Create()
    {
        var presignedUrlConfigResult = CreatePresignedUrlConfig();
        factoryAction?.Invoke(presignedUrlConfigResult);

        return presignedUrlConfigResult;
    }

    private Humidifier.IoT.JobTypes.PresignedUrlConfig CreatePresignedUrlConfig()
    {
        var presignedUrlConfigResult = new Humidifier.IoT.JobTypes.PresignedUrlConfig();

        return presignedUrlConfigResult;
    }

} // End Of Class

public static class InnerJobPresignedUrlConfigFactoryExtensions
{
}
