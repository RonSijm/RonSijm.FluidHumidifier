// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerComputeEnvironmentEksConfigurationFactory(Action<Humidifier.Batch.ComputeEnvironmentTypes.EksConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Batch.ComputeEnvironmentTypes.EksConfiguration>
{

    protected override Humidifier.Batch.ComputeEnvironmentTypes.EksConfiguration Create()
    {
        var eksConfigurationResult = CreateEksConfiguration();
        factoryAction?.Invoke(eksConfigurationResult);

        return eksConfigurationResult;
    }

    private Humidifier.Batch.ComputeEnvironmentTypes.EksConfiguration CreateEksConfiguration()
    {
        var eksConfigurationResult = new Humidifier.Batch.ComputeEnvironmentTypes.EksConfiguration();

        return eksConfigurationResult;
    }

} // End Of Class

public static class InnerComputeEnvironmentEksConfigurationFactoryExtensions
{
}
