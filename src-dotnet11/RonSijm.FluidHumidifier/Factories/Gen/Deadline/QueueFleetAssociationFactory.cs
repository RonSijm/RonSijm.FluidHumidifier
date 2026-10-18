// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class QueueFleetAssociationFactory(string resourceName = null, Action<Humidifier.Deadline.QueueFleetAssociation> factoryAction = null) : ResourceFactory<Humidifier.Deadline.QueueFleetAssociation>(resourceName)
{

    protected override Humidifier.Deadline.QueueFleetAssociation Create()
    {
        var queueFleetAssociationResult = CreateQueueFleetAssociation();
        factoryAction?.Invoke(queueFleetAssociationResult);

        return queueFleetAssociationResult;
    }

    private Humidifier.Deadline.QueueFleetAssociation CreateQueueFleetAssociation()
    {
        var queueFleetAssociationResult = new Humidifier.Deadline.QueueFleetAssociation
        {
            GivenName = InputResourceName,
        };

        return queueFleetAssociationResult;
    }

} // End Of Class

public static class QueueFleetAssociationFactoryExtensions
{
}
