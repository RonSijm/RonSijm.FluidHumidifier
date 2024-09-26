// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class InnerVolumeAggregateConfigurationFactory(Action<Humidifier.FSx.VolumeTypes.AggregateConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.FSx.VolumeTypes.AggregateConfiguration>
{

    protected override Humidifier.FSx.VolumeTypes.AggregateConfiguration Create()
    {
        var aggregateConfigurationResult = CreateAggregateConfiguration();
        factoryAction?.Invoke(aggregateConfigurationResult);

        return aggregateConfigurationResult;
    }

    private Humidifier.FSx.VolumeTypes.AggregateConfiguration CreateAggregateConfiguration()
    {
        var aggregateConfigurationResult = new Humidifier.FSx.VolumeTypes.AggregateConfiguration();

        return aggregateConfigurationResult;
    }

} // End Of Class

public static class InnerVolumeAggregateConfigurationFactoryExtensions
{
}
