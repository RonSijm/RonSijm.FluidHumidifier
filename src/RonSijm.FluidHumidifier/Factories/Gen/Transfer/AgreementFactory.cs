// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transfer;

public class AgreementFactory(string resourceName = null, Action<Humidifier.Transfer.Agreement> factoryAction = null) : ResourceFactory<Humidifier.Transfer.Agreement>(resourceName)
{

    protected override Humidifier.Transfer.Agreement Create()
    {
        var agreementResult = CreateAgreement();
        factoryAction?.Invoke(agreementResult);

        return agreementResult;
    }

    private Humidifier.Transfer.Agreement CreateAgreement()
    {
        var agreementResult = new Humidifier.Transfer.Agreement
        {
            GivenName = InputResourceName,
        };

        return agreementResult;
    }

} // End Of Class

public static class AgreementFactoryExtensions
{
}
