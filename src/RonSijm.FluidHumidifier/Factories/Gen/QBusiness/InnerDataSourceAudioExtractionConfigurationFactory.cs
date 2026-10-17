// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class InnerDataSourceAudioExtractionConfigurationFactory(Action<Humidifier.QBusiness.DataSourceTypes.AudioExtractionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QBusiness.DataSourceTypes.AudioExtractionConfiguration>
{

    protected override Humidifier.QBusiness.DataSourceTypes.AudioExtractionConfiguration Create()
    {
        var audioExtractionConfigurationResult = CreateAudioExtractionConfiguration();
        factoryAction?.Invoke(audioExtractionConfigurationResult);

        return audioExtractionConfigurationResult;
    }

    private Humidifier.QBusiness.DataSourceTypes.AudioExtractionConfiguration CreateAudioExtractionConfiguration()
    {
        var audioExtractionConfigurationResult = new Humidifier.QBusiness.DataSourceTypes.AudioExtractionConfiguration();

        return audioExtractionConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceAudioExtractionConfigurationFactoryExtensions
{
}
