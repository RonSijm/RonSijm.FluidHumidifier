// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transfer;

public class InnerWebAppWebAppUnitsFactory(Action<Humidifier.Transfer.WebAppTypes.WebAppUnits> factoryAction = null) : SubResourceFactory<Humidifier.Transfer.WebAppTypes.WebAppUnits>
{

    protected override Humidifier.Transfer.WebAppTypes.WebAppUnits Create()
    {
        var webAppUnitsResult = CreateWebAppUnits();
        factoryAction?.Invoke(webAppUnitsResult);

        return webAppUnitsResult;
    }

    private Humidifier.Transfer.WebAppTypes.WebAppUnits CreateWebAppUnits()
    {
        var webAppUnitsResult = new Humidifier.Transfer.WebAppTypes.WebAppUnits();

        return webAppUnitsResult;
    }

} // End Of Class

public static class InnerWebAppWebAppUnitsFactoryExtensions
{
}
