// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.HealthLake;

public class InnerDataTransformationProfileStarterProfileSourceFactory(Action<Humidifier.HealthLake.DataTransformationProfileTypes.StarterProfileSource> factoryAction = null) : SubResourceFactory<Humidifier.HealthLake.DataTransformationProfileTypes.StarterProfileSource>
{

    protected override Humidifier.HealthLake.DataTransformationProfileTypes.StarterProfileSource Create()
    {
        var starterProfileSourceResult = CreateStarterProfileSource();
        factoryAction?.Invoke(starterProfileSourceResult);

        return starterProfileSourceResult;
    }

    private Humidifier.HealthLake.DataTransformationProfileTypes.StarterProfileSource CreateStarterProfileSource()
    {
        var starterProfileSourceResult = new Humidifier.HealthLake.DataTransformationProfileTypes.StarterProfileSource();

        return starterProfileSourceResult;
    }

} // End Of Class

public static class InnerDataTransformationProfileStarterProfileSourceFactoryExtensions
{
}
