// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Macie;

public class InnerFindingsFilterFindingCriteriaFactory(Action<Humidifier.Macie.FindingsFilterTypes.FindingCriteria> factoryAction = null) : SubResourceFactory<Humidifier.Macie.FindingsFilterTypes.FindingCriteria>
{

    protected override Humidifier.Macie.FindingsFilterTypes.FindingCriteria Create()
    {
        var findingCriteriaResult = CreateFindingCriteria();
        factoryAction?.Invoke(findingCriteriaResult);

        return findingCriteriaResult;
    }

    private Humidifier.Macie.FindingsFilterTypes.FindingCriteria CreateFindingCriteria()
    {
        var findingCriteriaResult = new Humidifier.Macie.FindingsFilterTypes.FindingCriteria();

        return findingCriteriaResult;
    }

} // End Of Class

public static class InnerFindingsFilterFindingCriteriaFactoryExtensions
{
}
