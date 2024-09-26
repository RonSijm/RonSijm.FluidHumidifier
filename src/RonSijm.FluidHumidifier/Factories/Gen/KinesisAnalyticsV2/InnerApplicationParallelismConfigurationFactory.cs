// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalyticsV2;

public class InnerApplicationParallelismConfigurationFactory(Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.ParallelismConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalyticsV2.ApplicationTypes.ParallelismConfiguration>
{

    protected override Humidifier.KinesisAnalyticsV2.ApplicationTypes.ParallelismConfiguration Create()
    {
        var parallelismConfigurationResult = CreateParallelismConfiguration();
        factoryAction?.Invoke(parallelismConfigurationResult);

        return parallelismConfigurationResult;
    }

    private Humidifier.KinesisAnalyticsV2.ApplicationTypes.ParallelismConfiguration CreateParallelismConfiguration()
    {
        var parallelismConfigurationResult = new Humidifier.KinesisAnalyticsV2.ApplicationTypes.ParallelismConfiguration();

        return parallelismConfigurationResult;
    }

} // End Of Class

public static class InnerApplicationParallelismConfigurationFactoryExtensions
{
}
