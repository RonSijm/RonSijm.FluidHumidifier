// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerAssociationEventChannelConfigurationFactory(Action<Humidifier.DevOpsAgent.AssociationTypes.EventChannelConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.AssociationTypes.EventChannelConfiguration>
{

    protected override Humidifier.DevOpsAgent.AssociationTypes.EventChannelConfiguration Create()
    {
        var eventChannelConfigurationResult = CreateEventChannelConfiguration();
        factoryAction?.Invoke(eventChannelConfigurationResult);

        return eventChannelConfigurationResult;
    }

    private Humidifier.DevOpsAgent.AssociationTypes.EventChannelConfiguration CreateEventChannelConfiguration()
    {
        var eventChannelConfigurationResult = new Humidifier.DevOpsAgent.AssociationTypes.EventChannelConfiguration();

        return eventChannelConfigurationResult;
    }

} // End Of Class

public static class InnerAssociationEventChannelConfigurationFactoryExtensions
{
}
