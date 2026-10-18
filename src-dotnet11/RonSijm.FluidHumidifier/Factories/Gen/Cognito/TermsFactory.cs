// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class TermsFactory(string resourceName = null, Action<Humidifier.Cognito.Terms> factoryAction = null) : ResourceFactory<Humidifier.Cognito.Terms>(resourceName)
{

    protected override Humidifier.Cognito.Terms Create()
    {
        var termsResult = CreateTerms();
        factoryAction?.Invoke(termsResult);

        return termsResult;
    }

    private Humidifier.Cognito.Terms CreateTerms()
    {
        var termsResult = new Humidifier.Cognito.Terms
        {
            GivenName = InputResourceName,
        };

        return termsResult;
    }

} // End Of Class

public static class TermsFactoryExtensions
{
}
