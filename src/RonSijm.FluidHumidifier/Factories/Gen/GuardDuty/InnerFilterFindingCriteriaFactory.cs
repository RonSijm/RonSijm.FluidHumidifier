// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GuardDuty;

public class InnerFilterFindingCriteriaFactory(Action<Humidifier.GuardDuty.FilterTypes.FindingCriteria> factoryAction = null) : SubResourceFactory<Humidifier.GuardDuty.FilterTypes.FindingCriteria>
{

    protected override Humidifier.GuardDuty.FilterTypes.FindingCriteria Create()
    {
        var findingCriteriaResult = CreateFindingCriteria();
        factoryAction?.Invoke(findingCriteriaResult);

        return findingCriteriaResult;
    }

    private Humidifier.GuardDuty.FilterTypes.FindingCriteria CreateFindingCriteria()
    {
        var findingCriteriaResult = new Humidifier.GuardDuty.FilterTypes.FindingCriteria();

        return findingCriteriaResult;
    }

} // End Of Class

public static class InnerFilterFindingCriteriaFactoryExtensions
{
}
