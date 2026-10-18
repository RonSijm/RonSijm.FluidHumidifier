// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Macie;

public class CustomDataIdentifierFactory(string resourceName = null, Action<Humidifier.Macie.CustomDataIdentifier> factoryAction = null) : ResourceFactory<Humidifier.Macie.CustomDataIdentifier>(resourceName)
{

    protected override Humidifier.Macie.CustomDataIdentifier Create()
    {
        var customDataIdentifierResult = CreateCustomDataIdentifier();
        factoryAction?.Invoke(customDataIdentifierResult);

        return customDataIdentifierResult;
    }

    private Humidifier.Macie.CustomDataIdentifier CreateCustomDataIdentifier()
    {
        var customDataIdentifierResult = new Humidifier.Macie.CustomDataIdentifier
        {
            GivenName = InputResourceName,
        };

        return customDataIdentifierResult;
    }

} // End Of Class

public static class CustomDataIdentifierFactoryExtensions
{
}
