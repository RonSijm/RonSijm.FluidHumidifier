// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.B2BI;

public class PartnershipFactory(string resourceName = null, Action<Humidifier.B2BI.Partnership> factoryAction = null) : ResourceFactory<Humidifier.B2BI.Partnership>(resourceName)
{

    protected override Humidifier.B2BI.Partnership Create()
    {
        var partnershipResult = CreatePartnership();
        factoryAction?.Invoke(partnershipResult);

        return partnershipResult;
    }

    private Humidifier.B2BI.Partnership CreatePartnership()
    {
        var partnershipResult = new Humidifier.B2BI.Partnership
        {
            GivenName = InputResourceName,
        };

        return partnershipResult;
    }

} // End Of Class

public static class PartnershipFactoryExtensions
{
}
