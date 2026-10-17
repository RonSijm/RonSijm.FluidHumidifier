// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AgentRegistry;

public class InnerRegistryRecordCustomDescriptorFactory(Action<Humidifier.AgentRegistry.RegistryRecordTypes.CustomDescriptor> factoryAction = null) : SubResourceFactory<Humidifier.AgentRegistry.RegistryRecordTypes.CustomDescriptor>
{

    protected override Humidifier.AgentRegistry.RegistryRecordTypes.CustomDescriptor Create()
    {
        var customDescriptorResult = CreateCustomDescriptor();
        factoryAction?.Invoke(customDescriptorResult);

        return customDescriptorResult;
    }

    private Humidifier.AgentRegistry.RegistryRecordTypes.CustomDescriptor CreateCustomDescriptor()
    {
        var customDescriptorResult = new Humidifier.AgentRegistry.RegistryRecordTypes.CustomDescriptor();

        return customDescriptorResult;
    }

} // End Of Class

public static class InnerRegistryRecordCustomDescriptorFactoryExtensions
{
}
