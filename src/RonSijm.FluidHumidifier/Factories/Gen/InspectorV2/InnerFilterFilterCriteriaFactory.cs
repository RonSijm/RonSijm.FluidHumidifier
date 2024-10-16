// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.InspectorV2;

public class InnerFilterFilterCriteriaFactory(Action<Humidifier.InspectorV2.FilterTypes.FilterCriteria> factoryAction = null) : SubResourceFactory<Humidifier.InspectorV2.FilterTypes.FilterCriteria>
{

    protected override Humidifier.InspectorV2.FilterTypes.FilterCriteria Create()
    {
        var filterCriteriaResult = CreateFilterCriteria();
        factoryAction?.Invoke(filterCriteriaResult);

        return filterCriteriaResult;
    }

    private Humidifier.InspectorV2.FilterTypes.FilterCriteria CreateFilterCriteria()
    {
        var filterCriteriaResult = new Humidifier.InspectorV2.FilterTypes.FilterCriteria();

        return filterCriteriaResult;
    }

} // End Of Class

public static class InnerFilterFilterCriteriaFactoryExtensions
{
}
