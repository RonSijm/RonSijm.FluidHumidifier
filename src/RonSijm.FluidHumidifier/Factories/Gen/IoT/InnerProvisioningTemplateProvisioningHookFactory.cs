// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerProvisioningTemplateProvisioningHookFactory(Action<Humidifier.IoT.ProvisioningTemplateTypes.ProvisioningHook> factoryAction = null) : SubResourceFactory<Humidifier.IoT.ProvisioningTemplateTypes.ProvisioningHook>
{

    protected override Humidifier.IoT.ProvisioningTemplateTypes.ProvisioningHook Create()
    {
        var provisioningHookResult = CreateProvisioningHook();
        factoryAction?.Invoke(provisioningHookResult);

        return provisioningHookResult;
    }

    private Humidifier.IoT.ProvisioningTemplateTypes.ProvisioningHook CreateProvisioningHook()
    {
        var provisioningHookResult = new Humidifier.IoT.ProvisioningTemplateTypes.ProvisioningHook();

        return provisioningHookResult;
    }

} // End Of Class

public static class InnerProvisioningTemplateProvisioningHookFactoryExtensions
{
}
