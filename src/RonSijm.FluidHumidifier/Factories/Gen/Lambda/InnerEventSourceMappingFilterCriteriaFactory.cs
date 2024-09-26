// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerEventSourceMappingFilterCriteriaFactory(Action<Humidifier.Lambda.EventSourceMappingTypes.FilterCriteria> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.EventSourceMappingTypes.FilterCriteria>
{

    protected override Humidifier.Lambda.EventSourceMappingTypes.FilterCriteria Create()
    {
        var filterCriteriaResult = CreateFilterCriteria();
        factoryAction?.Invoke(filterCriteriaResult);

        return filterCriteriaResult;
    }

    private Humidifier.Lambda.EventSourceMappingTypes.FilterCriteria CreateFilterCriteria()
    {
        var filterCriteriaResult = new Humidifier.Lambda.EventSourceMappingTypes.FilterCriteria();

        return filterCriteriaResult;
    }

} // End Of Class

public static class InnerEventSourceMappingFilterCriteriaFactoryExtensions
{
}
