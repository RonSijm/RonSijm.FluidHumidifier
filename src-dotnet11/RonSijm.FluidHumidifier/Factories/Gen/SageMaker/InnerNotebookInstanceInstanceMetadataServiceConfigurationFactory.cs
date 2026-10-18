// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerNotebookInstanceInstanceMetadataServiceConfigurationFactory(Action<Humidifier.SageMaker.NotebookInstanceTypes.InstanceMetadataServiceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.NotebookInstanceTypes.InstanceMetadataServiceConfiguration>
{

    protected override Humidifier.SageMaker.NotebookInstanceTypes.InstanceMetadataServiceConfiguration Create()
    {
        var instanceMetadataServiceConfigurationResult = CreateInstanceMetadataServiceConfiguration();
        factoryAction?.Invoke(instanceMetadataServiceConfigurationResult);

        return instanceMetadataServiceConfigurationResult;
    }

    private Humidifier.SageMaker.NotebookInstanceTypes.InstanceMetadataServiceConfiguration CreateInstanceMetadataServiceConfiguration()
    {
        var instanceMetadataServiceConfigurationResult = new Humidifier.SageMaker.NotebookInstanceTypes.InstanceMetadataServiceConfiguration();

        return instanceMetadataServiceConfigurationResult;
    }

} // End Of Class

public static class InnerNotebookInstanceInstanceMetadataServiceConfigurationFactoryExtensions
{
}
