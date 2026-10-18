// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ObservabilityAdmin;

public class DatasetIntegrationFactory(string resourceName = null, Action<Humidifier.ObservabilityAdmin.DatasetIntegration> factoryAction = null) : ResourceFactory<Humidifier.ObservabilityAdmin.DatasetIntegration>(resourceName)
{

    protected override Humidifier.ObservabilityAdmin.DatasetIntegration Create()
    {
        var datasetIntegrationResult = CreateDatasetIntegration();
        factoryAction?.Invoke(datasetIntegrationResult);

        return datasetIntegrationResult;
    }

    private Humidifier.ObservabilityAdmin.DatasetIntegration CreateDatasetIntegration()
    {
        var datasetIntegrationResult = new Humidifier.ObservabilityAdmin.DatasetIntegration
        {
            GivenName = InputResourceName,
        };

        return datasetIntegrationResult;
    }

} // End Of Class

public static class DatasetIntegrationFactoryExtensions
{
}
