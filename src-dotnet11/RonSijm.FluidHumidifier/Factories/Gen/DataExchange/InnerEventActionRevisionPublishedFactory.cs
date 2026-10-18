// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataExchange;

public class InnerEventActionRevisionPublishedFactory(Action<Humidifier.DataExchange.EventActionTypes.RevisionPublished> factoryAction = null) : SubResourceFactory<Humidifier.DataExchange.EventActionTypes.RevisionPublished>
{

    protected override Humidifier.DataExchange.EventActionTypes.RevisionPublished Create()
    {
        var revisionPublishedResult = CreateRevisionPublished();
        factoryAction?.Invoke(revisionPublishedResult);

        return revisionPublishedResult;
    }

    private Humidifier.DataExchange.EventActionTypes.RevisionPublished CreateRevisionPublished()
    {
        var revisionPublishedResult = new Humidifier.DataExchange.EventActionTypes.RevisionPublished();

        return revisionPublishedResult;
    }

} // End Of Class

public static class InnerEventActionRevisionPublishedFactoryExtensions
{
}
