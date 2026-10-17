// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SMSVOICE;

public class VerifiedDestinationNumberFactory(string resourceName = null, Action<Humidifier.SMSVOICE.VerifiedDestinationNumber> factoryAction = null) : ResourceFactory<Humidifier.SMSVOICE.VerifiedDestinationNumber>(resourceName)
{

    protected override Humidifier.SMSVOICE.VerifiedDestinationNumber Create()
    {
        var verifiedDestinationNumberResult = CreateVerifiedDestinationNumber();
        factoryAction?.Invoke(verifiedDestinationNumberResult);

        return verifiedDestinationNumberResult;
    }

    private Humidifier.SMSVOICE.VerifiedDestinationNumber CreateVerifiedDestinationNumber()
    {
        var verifiedDestinationNumberResult = new Humidifier.SMSVOICE.VerifiedDestinationNumber
        {
            GivenName = InputResourceName,
        };

        return verifiedDestinationNumberResult;
    }

} // End Of Class

public static class VerifiedDestinationNumberFactoryExtensions
{
}
