// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCS;

public class InnerQueueSlurmConfigurationFactory(Action<Humidifier.PCS.QueueTypes.SlurmConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.PCS.QueueTypes.SlurmConfiguration>
{

    protected override Humidifier.PCS.QueueTypes.SlurmConfiguration Create()
    {
        var slurmConfigurationResult = CreateSlurmConfiguration();
        factoryAction?.Invoke(slurmConfigurationResult);

        return slurmConfigurationResult;
    }

    private Humidifier.PCS.QueueTypes.SlurmConfiguration CreateSlurmConfiguration()
    {
        var slurmConfigurationResult = new Humidifier.PCS.QueueTypes.SlurmConfiguration();

        return slurmConfigurationResult;
    }

} // End Of Class

public static class InnerQueueSlurmConfigurationFactoryExtensions
{
}
