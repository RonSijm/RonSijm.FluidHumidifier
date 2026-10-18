// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Outposts;

public class InnerSiteAddressFactory(Action<Humidifier.Outposts.SiteTypes.Address> factoryAction = null) : SubResourceFactory<Humidifier.Outposts.SiteTypes.Address>
{

    protected override Humidifier.Outposts.SiteTypes.Address Create()
    {
        var addressResult = CreateAddress();
        factoryAction?.Invoke(addressResult);

        return addressResult;
    }

    private Humidifier.Outposts.SiteTypes.Address CreateAddress()
    {
        var addressResult = new Humidifier.Outposts.SiteTypes.Address();

        return addressResult;
    }

} // End Of Class

public static class InnerSiteAddressFactoryExtensions
{
}
