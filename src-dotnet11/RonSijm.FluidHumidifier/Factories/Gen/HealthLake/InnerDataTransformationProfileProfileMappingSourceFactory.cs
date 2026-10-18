// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.HealthLake;

public class InnerDataTransformationProfileProfileMappingSourceFactory(Action<Humidifier.HealthLake.DataTransformationProfileTypes.ProfileMappingSource> factoryAction = null) : SubResourceFactory<Humidifier.HealthLake.DataTransformationProfileTypes.ProfileMappingSource>
{

    protected override Humidifier.HealthLake.DataTransformationProfileTypes.ProfileMappingSource Create()
    {
        var profileMappingSourceResult = CreateProfileMappingSource();
        factoryAction?.Invoke(profileMappingSourceResult);

        return profileMappingSourceResult;
    }

    private Humidifier.HealthLake.DataTransformationProfileTypes.ProfileMappingSource CreateProfileMappingSource()
    {
        var profileMappingSourceResult = new Humidifier.HealthLake.DataTransformationProfileTypes.ProfileMappingSource();

        return profileMappingSourceResult;
    }

} // End Of Class

public static class InnerDataTransformationProfileProfileMappingSourceFactoryExtensions
{
}
