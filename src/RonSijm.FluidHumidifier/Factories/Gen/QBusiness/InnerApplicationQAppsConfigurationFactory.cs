// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class InnerApplicationQAppsConfigurationFactory(Action<Humidifier.QBusiness.ApplicationTypes.QAppsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QBusiness.ApplicationTypes.QAppsConfiguration>
{

    protected override Humidifier.QBusiness.ApplicationTypes.QAppsConfiguration Create()
    {
        var qAppsConfigurationResult = CreateQAppsConfiguration();
        factoryAction?.Invoke(qAppsConfigurationResult);

        return qAppsConfigurationResult;
    }

    private Humidifier.QBusiness.ApplicationTypes.QAppsConfiguration CreateQAppsConfiguration()
    {
        var qAppsConfigurationResult = new Humidifier.QBusiness.ApplicationTypes.QAppsConfiguration();

        return qAppsConfigurationResult;
    }

} // End Of Class

public static class InnerApplicationQAppsConfigurationFactoryExtensions
{
}
