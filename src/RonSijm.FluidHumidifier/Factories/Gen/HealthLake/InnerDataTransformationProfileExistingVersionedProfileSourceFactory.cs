// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.HealthLake;

public class InnerDataTransformationProfileExistingVersionedProfileSourceFactory(Action<Humidifier.HealthLake.DataTransformationProfileTypes.ExistingVersionedProfileSource> factoryAction = null) : SubResourceFactory<Humidifier.HealthLake.DataTransformationProfileTypes.ExistingVersionedProfileSource>
{

    protected override Humidifier.HealthLake.DataTransformationProfileTypes.ExistingVersionedProfileSource Create()
    {
        var existingVersionedProfileSourceResult = CreateExistingVersionedProfileSource();
        factoryAction?.Invoke(existingVersionedProfileSourceResult);

        return existingVersionedProfileSourceResult;
    }

    private Humidifier.HealthLake.DataTransformationProfileTypes.ExistingVersionedProfileSource CreateExistingVersionedProfileSource()
    {
        var existingVersionedProfileSourceResult = new Humidifier.HealthLake.DataTransformationProfileTypes.ExistingVersionedProfileSource();

        return existingVersionedProfileSourceResult;
    }

} // End Of Class

public static class InnerDataTransformationProfileExistingVersionedProfileSourceFactoryExtensions
{
}
