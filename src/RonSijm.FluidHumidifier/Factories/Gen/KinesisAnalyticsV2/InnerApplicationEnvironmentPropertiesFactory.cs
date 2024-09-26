// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalyticsV2;

public class InnerApplicationEnvironmentPropertiesFactory(Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.EnvironmentProperties> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalyticsV2.ApplicationTypes.EnvironmentProperties>
{

    protected override Humidifier.KinesisAnalyticsV2.ApplicationTypes.EnvironmentProperties Create()
    {
        var environmentPropertiesResult = CreateEnvironmentProperties();
        factoryAction?.Invoke(environmentPropertiesResult);

        return environmentPropertiesResult;
    }

    private Humidifier.KinesisAnalyticsV2.ApplicationTypes.EnvironmentProperties CreateEnvironmentProperties()
    {
        var environmentPropertiesResult = new Humidifier.KinesisAnalyticsV2.ApplicationTypes.EnvironmentProperties();

        return environmentPropertiesResult;
    }

} // End Of Class

public static class InnerApplicationEnvironmentPropertiesFactoryExtensions
{
}
