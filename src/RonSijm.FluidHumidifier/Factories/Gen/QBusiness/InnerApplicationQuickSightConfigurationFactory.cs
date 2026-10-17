// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class InnerApplicationQuickSightConfigurationFactory(Action<Humidifier.QBusiness.ApplicationTypes.QuickSightConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QBusiness.ApplicationTypes.QuickSightConfiguration>
{

    protected override Humidifier.QBusiness.ApplicationTypes.QuickSightConfiguration Create()
    {
        var quickSightConfigurationResult = CreateQuickSightConfiguration();
        factoryAction?.Invoke(quickSightConfigurationResult);

        return quickSightConfigurationResult;
    }

    private Humidifier.QBusiness.ApplicationTypes.QuickSightConfiguration CreateQuickSightConfiguration()
    {
        var quickSightConfigurationResult = new Humidifier.QBusiness.ApplicationTypes.QuickSightConfiguration();

        return quickSightConfigurationResult;
    }

} // End Of Class

public static class InnerApplicationQuickSightConfigurationFactoryExtensions
{
}
