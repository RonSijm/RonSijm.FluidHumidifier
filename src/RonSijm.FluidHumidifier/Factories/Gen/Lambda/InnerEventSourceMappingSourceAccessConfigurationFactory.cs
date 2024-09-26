// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerEventSourceMappingSourceAccessConfigurationFactory(Action<Humidifier.Lambda.EventSourceMappingTypes.SourceAccessConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.EventSourceMappingTypes.SourceAccessConfiguration>
{

    protected override Humidifier.Lambda.EventSourceMappingTypes.SourceAccessConfiguration Create()
    {
        var sourceAccessConfigurationResult = CreateSourceAccessConfiguration();
        factoryAction?.Invoke(sourceAccessConfigurationResult);

        return sourceAccessConfigurationResult;
    }

    private Humidifier.Lambda.EventSourceMappingTypes.SourceAccessConfiguration CreateSourceAccessConfiguration()
    {
        var sourceAccessConfigurationResult = new Humidifier.Lambda.EventSourceMappingTypes.SourceAccessConfiguration();

        return sourceAccessConfigurationResult;
    }

} // End Of Class

public static class InnerEventSourceMappingSourceAccessConfigurationFactoryExtensions
{
}
