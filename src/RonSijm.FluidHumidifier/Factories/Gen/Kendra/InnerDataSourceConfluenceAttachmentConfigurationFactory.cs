// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerDataSourceConfluenceAttachmentConfigurationFactory(Action<Humidifier.Kendra.DataSourceTypes.ConfluenceAttachmentConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.DataSourceTypes.ConfluenceAttachmentConfiguration>
{

    protected override Humidifier.Kendra.DataSourceTypes.ConfluenceAttachmentConfiguration Create()
    {
        var confluenceAttachmentConfigurationResult = CreateConfluenceAttachmentConfiguration();
        factoryAction?.Invoke(confluenceAttachmentConfigurationResult);

        return confluenceAttachmentConfigurationResult;
    }

    private Humidifier.Kendra.DataSourceTypes.ConfluenceAttachmentConfiguration CreateConfluenceAttachmentConfiguration()
    {
        var confluenceAttachmentConfigurationResult = new Humidifier.Kendra.DataSourceTypes.ConfluenceAttachmentConfiguration();

        return confluenceAttachmentConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceConfluenceAttachmentConfigurationFactoryExtensions
{
}
