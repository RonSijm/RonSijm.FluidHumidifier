// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Braket;

public class InnerJobJobCheckpointConfigFactory(Action<Humidifier.Braket.JobTypes.JobCheckpointConfig> factoryAction = null) : SubResourceFactory<Humidifier.Braket.JobTypes.JobCheckpointConfig>
{

    protected override Humidifier.Braket.JobTypes.JobCheckpointConfig Create()
    {
        var jobCheckpointConfigResult = CreateJobCheckpointConfig();
        factoryAction?.Invoke(jobCheckpointConfigResult);

        return jobCheckpointConfigResult;
    }

    private Humidifier.Braket.JobTypes.JobCheckpointConfig CreateJobCheckpointConfig()
    {
        var jobCheckpointConfigResult = new Humidifier.Braket.JobTypes.JobCheckpointConfig();

        return jobCheckpointConfigResult;
    }

} // End Of Class

public static class InnerJobJobCheckpointConfigFactoryExtensions
{
}
