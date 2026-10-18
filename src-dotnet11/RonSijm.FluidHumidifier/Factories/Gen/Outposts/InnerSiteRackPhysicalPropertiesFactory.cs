// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Outposts;

public class InnerSiteRackPhysicalPropertiesFactory(Action<Humidifier.Outposts.SiteTypes.RackPhysicalProperties> factoryAction = null) : SubResourceFactory<Humidifier.Outposts.SiteTypes.RackPhysicalProperties>
{

    protected override Humidifier.Outposts.SiteTypes.RackPhysicalProperties Create()
    {
        var rackPhysicalPropertiesResult = CreateRackPhysicalProperties();
        factoryAction?.Invoke(rackPhysicalPropertiesResult);

        return rackPhysicalPropertiesResult;
    }

    private Humidifier.Outposts.SiteTypes.RackPhysicalProperties CreateRackPhysicalProperties()
    {
        var rackPhysicalPropertiesResult = new Humidifier.Outposts.SiteTypes.RackPhysicalProperties();

        return rackPhysicalPropertiesResult;
    }

} // End Of Class

public static class InnerSiteRackPhysicalPropertiesFactoryExtensions
{
}
