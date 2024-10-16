// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationInsights;

public class InnerApplicationCustomComponentFactory(Action<Humidifier.ApplicationInsights.ApplicationTypes.CustomComponent> factoryAction = null) : SubResourceFactory<Humidifier.ApplicationInsights.ApplicationTypes.CustomComponent>
{

    protected override Humidifier.ApplicationInsights.ApplicationTypes.CustomComponent Create()
    {
        var customComponentResult = CreateCustomComponent();
        factoryAction?.Invoke(customComponentResult);

        return customComponentResult;
    }

    private Humidifier.ApplicationInsights.ApplicationTypes.CustomComponent CreateCustomComponent()
    {
        var customComponentResult = new Humidifier.ApplicationInsights.ApplicationTypes.CustomComponent();

        return customComponentResult;
    }

} // End Of Class

public static class InnerApplicationCustomComponentFactoryExtensions
{
}
