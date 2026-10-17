// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PartnerCentral;

public class PartnerFactory(string resourceName = null, Action<Humidifier.PartnerCentral.Partner> factoryAction = null) : ResourceFactory<Humidifier.PartnerCentral.Partner>(resourceName)
{

    protected override Humidifier.PartnerCentral.Partner Create()
    {
        var partnerResult = CreatePartner();
        factoryAction?.Invoke(partnerResult);

        return partnerResult;
    }

    private Humidifier.PartnerCentral.Partner CreatePartner()
    {
        var partnerResult = new Humidifier.PartnerCentral.Partner
        {
            GivenName = InputResourceName,
        };

        return partnerResult;
    }

} // End Of Class

public static class PartnerFactoryExtensions
{
}
