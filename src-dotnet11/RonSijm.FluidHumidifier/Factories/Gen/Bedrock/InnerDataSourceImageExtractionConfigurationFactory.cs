// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataSourceImageExtractionConfigurationFactory(Action<Humidifier.Bedrock.DataSourceTypes.ImageExtractionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataSourceTypes.ImageExtractionConfiguration>
{

    protected override Humidifier.Bedrock.DataSourceTypes.ImageExtractionConfiguration Create()
    {
        var imageExtractionConfigurationResult = CreateImageExtractionConfiguration();
        factoryAction?.Invoke(imageExtractionConfigurationResult);

        return imageExtractionConfigurationResult;
    }

    private Humidifier.Bedrock.DataSourceTypes.ImageExtractionConfiguration CreateImageExtractionConfiguration()
    {
        var imageExtractionConfigurationResult = new Humidifier.Bedrock.DataSourceTypes.ImageExtractionConfiguration();

        return imageExtractionConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceImageExtractionConfigurationFactoryExtensions
{
}
