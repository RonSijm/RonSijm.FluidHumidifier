// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class InnerGeneratedTemplateTemplateConfigurationFactory(Action<Humidifier.CloudFormation.GeneratedTemplateTypes.TemplateConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.CloudFormation.GeneratedTemplateTypes.TemplateConfiguration>
{

    protected override Humidifier.CloudFormation.GeneratedTemplateTypes.TemplateConfiguration Create()
    {
        var templateConfigurationResult = CreateTemplateConfiguration();
        factoryAction?.Invoke(templateConfigurationResult);

        return templateConfigurationResult;
    }

    private Humidifier.CloudFormation.GeneratedTemplateTypes.TemplateConfiguration CreateTemplateConfiguration()
    {
        var templateConfigurationResult = new Humidifier.CloudFormation.GeneratedTemplateTypes.TemplateConfiguration();

        return templateConfigurationResult;
    }

} // End Of Class

public static class InnerGeneratedTemplateTemplateConfigurationFactoryExtensions
{
}
