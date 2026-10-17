// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class OfferingFactory(string resourceName = null, Action<Humidifier.MediaConnect.Offering> factoryAction = null) : ResourceFactory<Humidifier.MediaConnect.Offering>(resourceName)
{

    protected override Humidifier.MediaConnect.Offering Create()
    {
        var offeringResult = CreateOffering();
        factoryAction?.Invoke(offeringResult);

        return offeringResult;
    }

    private Humidifier.MediaConnect.Offering CreateOffering()
    {
        var offeringResult = new Humidifier.MediaConnect.Offering
        {
            GivenName = InputResourceName,
        };

        return offeringResult;
    }

} // End Of Class

public static class OfferingFactoryExtensions
{
}
