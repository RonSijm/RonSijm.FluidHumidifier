// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.HealthLake;

public class InnerFHIRDatastoreNlpConfigurationFactory(Action<Humidifier.HealthLake.FHIRDatastoreTypes.NlpConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.HealthLake.FHIRDatastoreTypes.NlpConfiguration>
{

    protected override Humidifier.HealthLake.FHIRDatastoreTypes.NlpConfiguration Create()
    {
        var nlpConfigurationResult = CreateNlpConfiguration();
        factoryAction?.Invoke(nlpConfigurationResult);

        return nlpConfigurationResult;
    }

    private Humidifier.HealthLake.FHIRDatastoreTypes.NlpConfiguration CreateNlpConfiguration()
    {
        var nlpConfigurationResult = new Humidifier.HealthLake.FHIRDatastoreTypes.NlpConfiguration();

        return nlpConfigurationResult;
    }

} // End Of Class

public static class InnerFHIRDatastoreNlpConfigurationFactoryExtensions
{
}
