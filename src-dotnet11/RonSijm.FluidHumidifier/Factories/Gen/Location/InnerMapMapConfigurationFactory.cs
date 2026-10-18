// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Location;

public class InnerMapMapConfigurationFactory(Action<Humidifier.Location.MapTypes.MapConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Location.MapTypes.MapConfiguration>
{

    protected override Humidifier.Location.MapTypes.MapConfiguration Create()
    {
        var mapConfigurationResult = CreateMapConfiguration();
        factoryAction?.Invoke(mapConfigurationResult);

        return mapConfigurationResult;
    }

    private Humidifier.Location.MapTypes.MapConfiguration CreateMapConfiguration()
    {
        var mapConfigurationResult = new Humidifier.Location.MapTypes.MapConfiguration();

        return mapConfigurationResult;
    }

} // End Of Class

public static class InnerMapMapConfigurationFactoryExtensions
{
}
