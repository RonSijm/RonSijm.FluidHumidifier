// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AgentRegistry;

public class InnerRegistryRecordDescriptorSourceFromUrlFactory(Action<Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSourceFromUrl> factoryAction = null) : SubResourceFactory<Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSourceFromUrl>
{

    protected override Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSourceFromUrl Create()
    {
        var descriptorSourceFromUrlResult = CreateDescriptorSourceFromUrl();
        factoryAction?.Invoke(descriptorSourceFromUrlResult);

        return descriptorSourceFromUrlResult;
    }

    private Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSourceFromUrl CreateDescriptorSourceFromUrl()
    {
        var descriptorSourceFromUrlResult = new Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSourceFromUrl();

        return descriptorSourceFromUrlResult;
    }

} // End Of Class

public static class InnerRegistryRecordDescriptorSourceFromUrlFactoryExtensions
{
}
