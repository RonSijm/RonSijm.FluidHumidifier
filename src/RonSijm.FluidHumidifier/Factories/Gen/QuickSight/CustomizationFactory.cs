// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class CustomizationFactory(string resourceName = null, Action<Humidifier.QuickSight.Customization> factoryAction = null) : ResourceFactory<Humidifier.QuickSight.Customization>(resourceName)
{

    protected override Humidifier.QuickSight.Customization Create()
    {
        var customizationResult = CreateCustomization();
        factoryAction?.Invoke(customizationResult);

        return customizationResult;
    }

    private Humidifier.QuickSight.Customization CreateCustomization()
    {
        var customizationResult = new Humidifier.QuickSight.Customization
        {
            GivenName = InputResourceName,
        };

        return customizationResult;
    }

} // End Of Class

public static class CustomizationFactoryExtensions
{
}
