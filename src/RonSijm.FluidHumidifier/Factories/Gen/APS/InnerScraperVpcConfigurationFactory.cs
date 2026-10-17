// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.APS;

public class InnerScraperVpcConfigurationFactory(Action<Humidifier.APS.ScraperTypes.VpcConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.APS.ScraperTypes.VpcConfiguration>
{

    protected override Humidifier.APS.ScraperTypes.VpcConfiguration Create()
    {
        var vpcConfigurationResult = CreateVpcConfiguration();
        factoryAction?.Invoke(vpcConfigurationResult);

        return vpcConfigurationResult;
    }

    private Humidifier.APS.ScraperTypes.VpcConfiguration CreateVpcConfiguration()
    {
        var vpcConfigurationResult = new Humidifier.APS.ScraperTypes.VpcConfiguration();

        return vpcConfigurationResult;
    }

} // End Of Class

public static class InnerScraperVpcConfigurationFactoryExtensions
{
}
