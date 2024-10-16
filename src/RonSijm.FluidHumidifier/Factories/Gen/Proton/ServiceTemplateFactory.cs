// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Proton;

public class ServiceTemplateFactory(string resourceName = null, Action<Humidifier.Proton.ServiceTemplate> factoryAction = null) : ResourceFactory<Humidifier.Proton.ServiceTemplate>(resourceName)
{

    protected override Humidifier.Proton.ServiceTemplate Create()
    {
        var serviceTemplateResult = CreateServiceTemplate();
        factoryAction?.Invoke(serviceTemplateResult);

        return serviceTemplateResult;
    }

    private Humidifier.Proton.ServiceTemplate CreateServiceTemplate()
    {
        var serviceTemplateResult = new Humidifier.Proton.ServiceTemplate
        {
            GivenName = InputResourceName,
        };

        return serviceTemplateResult;
    }

} // End Of Class

public static class ServiceTemplateFactoryExtensions
{
}
