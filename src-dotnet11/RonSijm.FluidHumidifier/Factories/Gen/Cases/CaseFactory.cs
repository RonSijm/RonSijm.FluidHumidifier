// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cases;

public class CaseFactory(string resourceName = null, Action<Humidifier.Cases.Case> factoryAction = null) : ResourceFactory<Humidifier.Cases.Case>(resourceName)
{

    protected override Humidifier.Cases.Case Create()
    {
        var caseResult = CreateCase();
        factoryAction?.Invoke(caseResult);

        return caseResult;
    }

    private Humidifier.Cases.Case CreateCase()
    {
        var caseResult = new Humidifier.Cases.Case
        {
            GivenName = InputResourceName,
        };

        return caseResult;
    }

} // End Of Class

public static class CaseFactoryExtensions
{
}
