// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerSourceLocationHttpConfigurationFactory(Action<Humidifier.MediaTailor.SourceLocationTypes.HttpConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.SourceLocationTypes.HttpConfiguration>
{

    protected override Humidifier.MediaTailor.SourceLocationTypes.HttpConfiguration Create()
    {
        var httpConfigurationResult = CreateHttpConfiguration();
        factoryAction?.Invoke(httpConfigurationResult);

        return httpConfigurationResult;
    }

    private Humidifier.MediaTailor.SourceLocationTypes.HttpConfiguration CreateHttpConfiguration()
    {
        var httpConfigurationResult = new Humidifier.MediaTailor.SourceLocationTypes.HttpConfiguration();

        return httpConfigurationResult;
    }

} // End Of Class

public static class InnerSourceLocationHttpConfigurationFactoryExtensions
{
}
