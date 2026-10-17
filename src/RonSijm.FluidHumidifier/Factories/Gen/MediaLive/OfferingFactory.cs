// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class OfferingFactory(string resourceName = null, Action<Humidifier.MediaLive.Offering> factoryAction = null) : ResourceFactory<Humidifier.MediaLive.Offering>(resourceName)
{

    protected override Humidifier.MediaLive.Offering Create()
    {
        var offeringResult = CreateOffering();
        factoryAction?.Invoke(offeringResult);

        return offeringResult;
    }

    private Humidifier.MediaLive.Offering CreateOffering()
    {
        var offeringResult = new Humidifier.MediaLive.Offering
        {
            GivenName = InputResourceName,
        };

        return offeringResult;
    }

} // End Of Class

public static class OfferingFactoryExtensions
{
}
