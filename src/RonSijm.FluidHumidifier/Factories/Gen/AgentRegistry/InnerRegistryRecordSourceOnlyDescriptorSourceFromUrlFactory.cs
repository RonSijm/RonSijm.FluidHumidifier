// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AgentRegistry;

public class InnerRegistryRecordSourceOnlyDescriptorSourceFromUrlFactory(Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSourceFromUrl> factoryAction = null) : SubResourceFactory<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSourceFromUrl>
{

    protected override Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSourceFromUrl Create()
    {
        var sourceOnlyDescriptorSourceFromUrlResult = CreateSourceOnlyDescriptorSourceFromUrl();
        factoryAction?.Invoke(sourceOnlyDescriptorSourceFromUrlResult);

        return sourceOnlyDescriptorSourceFromUrlResult;
    }

    private Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSourceFromUrl CreateSourceOnlyDescriptorSourceFromUrl()
    {
        var sourceOnlyDescriptorSourceFromUrlResult = new Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSourceFromUrl();

        return sourceOnlyDescriptorSourceFromUrlResult;
    }

} // End Of Class

public static class InnerRegistryRecordSourceOnlyDescriptorSourceFromUrlFactoryExtensions
{
}
