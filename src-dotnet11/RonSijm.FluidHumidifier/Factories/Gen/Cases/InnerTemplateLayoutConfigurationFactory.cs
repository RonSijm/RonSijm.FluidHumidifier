// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cases;

public class InnerTemplateLayoutConfigurationFactory(Action<Humidifier.Cases.TemplateTypes.LayoutConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Cases.TemplateTypes.LayoutConfiguration>
{

    protected override Humidifier.Cases.TemplateTypes.LayoutConfiguration Create()
    {
        var layoutConfigurationResult = CreateLayoutConfiguration();
        factoryAction?.Invoke(layoutConfigurationResult);

        return layoutConfigurationResult;
    }

    private Humidifier.Cases.TemplateTypes.LayoutConfiguration CreateLayoutConfiguration()
    {
        var layoutConfigurationResult = new Humidifier.Cases.TemplateTypes.LayoutConfiguration();

        return layoutConfigurationResult;
    }

} // End Of Class

public static class InnerTemplateLayoutConfigurationFactoryExtensions
{
}
