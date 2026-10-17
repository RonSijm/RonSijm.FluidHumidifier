// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerDataSourceTemplateConfigurationFactory(Action<Humidifier.Kendra.DataSourceTypes.TemplateConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.DataSourceTypes.TemplateConfiguration>
{

    protected override Humidifier.Kendra.DataSourceTypes.TemplateConfiguration Create()
    {
        var templateConfigurationResult = CreateTemplateConfiguration();
        factoryAction?.Invoke(templateConfigurationResult);

        return templateConfigurationResult;
    }

    private Humidifier.Kendra.DataSourceTypes.TemplateConfiguration CreateTemplateConfiguration()
    {
        var templateConfigurationResult = new Humidifier.Kendra.DataSourceTypes.TemplateConfiguration();

        return templateConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceTemplateConfigurationFactoryExtensions
{
}
