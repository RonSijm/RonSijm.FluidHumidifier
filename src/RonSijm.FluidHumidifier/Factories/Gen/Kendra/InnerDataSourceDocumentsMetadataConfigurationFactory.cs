// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerDataSourceDocumentsMetadataConfigurationFactory(Action<Humidifier.Kendra.DataSourceTypes.DocumentsMetadataConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.DataSourceTypes.DocumentsMetadataConfiguration>
{

    protected override Humidifier.Kendra.DataSourceTypes.DocumentsMetadataConfiguration Create()
    {
        var documentsMetadataConfigurationResult = CreateDocumentsMetadataConfiguration();
        factoryAction?.Invoke(documentsMetadataConfigurationResult);

        return documentsMetadataConfigurationResult;
    }

    private Humidifier.Kendra.DataSourceTypes.DocumentsMetadataConfiguration CreateDocumentsMetadataConfiguration()
    {
        var documentsMetadataConfigurationResult = new Humidifier.Kendra.DataSourceTypes.DocumentsMetadataConfiguration();

        return documentsMetadataConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceDocumentsMetadataConfigurationFactoryExtensions
{
}
