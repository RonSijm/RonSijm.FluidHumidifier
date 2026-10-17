// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class QueueLimitAssociationFactory(string resourceName = null, Action<Humidifier.Deadline.QueueLimitAssociation> factoryAction = null) : ResourceFactory<Humidifier.Deadline.QueueLimitAssociation>(resourceName)
{

    protected override Humidifier.Deadline.QueueLimitAssociation Create()
    {
        var queueLimitAssociationResult = CreateQueueLimitAssociation();
        factoryAction?.Invoke(queueLimitAssociationResult);

        return queueLimitAssociationResult;
    }

    private Humidifier.Deadline.QueueLimitAssociation CreateQueueLimitAssociation()
    {
        var queueLimitAssociationResult = new Humidifier.Deadline.QueueLimitAssociation
        {
            GivenName = InputResourceName,
        };

        return queueLimitAssociationResult;
    }

} // End Of Class

public static class QueueLimitAssociationFactoryExtensions
{
}
