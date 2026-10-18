// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transfer;

public class InnerWebAppWebAppCustomizationFactory(Action<Humidifier.Transfer.WebAppTypes.WebAppCustomization> factoryAction = null) : SubResourceFactory<Humidifier.Transfer.WebAppTypes.WebAppCustomization>
{

    protected override Humidifier.Transfer.WebAppTypes.WebAppCustomization Create()
    {
        var webAppCustomizationResult = CreateWebAppCustomization();
        factoryAction?.Invoke(webAppCustomizationResult);

        return webAppCustomizationResult;
    }

    private Humidifier.Transfer.WebAppTypes.WebAppCustomization CreateWebAppCustomization()
    {
        var webAppCustomizationResult = new Humidifier.Transfer.WebAppTypes.WebAppCustomization();

        return webAppCustomizationResult;
    }

} // End Of Class

public static class InnerWebAppWebAppCustomizationFactoryExtensions
{
}
