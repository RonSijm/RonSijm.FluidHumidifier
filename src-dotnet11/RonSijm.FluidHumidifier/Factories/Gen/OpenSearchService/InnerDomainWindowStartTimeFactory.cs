// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchService;

public class InnerDomainWindowStartTimeFactory(Action<Humidifier.OpenSearchService.DomainTypes.WindowStartTime> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearchService.DomainTypes.WindowStartTime>
{

    protected override Humidifier.OpenSearchService.DomainTypes.WindowStartTime Create()
    {
        var windowStartTimeResult = CreateWindowStartTime();
        factoryAction?.Invoke(windowStartTimeResult);

        return windowStartTimeResult;
    }

    private Humidifier.OpenSearchService.DomainTypes.WindowStartTime CreateWindowStartTime()
    {
        var windowStartTimeResult = new Humidifier.OpenSearchService.DomainTypes.WindowStartTime();

        return windowStartTimeResult;
    }

} // End Of Class

public static class InnerDomainWindowStartTimeFactoryExtensions
{
}
