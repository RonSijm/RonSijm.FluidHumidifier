// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpacesWeb;

public class InnerSessionLoggerEventFilterFactory(Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.EventFilter> factoryAction = null) : SubResourceFactory<Humidifier.WorkSpacesWeb.SessionLoggerTypes.EventFilter>
{

    protected override Humidifier.WorkSpacesWeb.SessionLoggerTypes.EventFilter Create()
    {
        var eventFilterResult = CreateEventFilter();
        factoryAction?.Invoke(eventFilterResult);

        return eventFilterResult;
    }

    private Humidifier.WorkSpacesWeb.SessionLoggerTypes.EventFilter CreateEventFilter()
    {
        var eventFilterResult = new Humidifier.WorkSpacesWeb.SessionLoggerTypes.EventFilter();

        return eventFilterResult;
    }

} // End Of Class

public static class InnerSessionLoggerEventFilterFactoryExtensions
{
}
