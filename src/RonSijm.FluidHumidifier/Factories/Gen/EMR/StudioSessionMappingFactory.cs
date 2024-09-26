// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class StudioSessionMappingFactory(string resourceName = null, Action<Humidifier.EMR.StudioSessionMapping> factoryAction = null) : ResourceFactory<Humidifier.EMR.StudioSessionMapping>(resourceName)
{

    protected override Humidifier.EMR.StudioSessionMapping Create()
    {
        var studioSessionMappingResult = CreateStudioSessionMapping();
        factoryAction?.Invoke(studioSessionMappingResult);

        return studioSessionMappingResult;
    }

    private Humidifier.EMR.StudioSessionMapping CreateStudioSessionMapping()
    {
        var studioSessionMappingResult = new Humidifier.EMR.StudioSessionMapping
        {
            GivenName = InputResourceName,
        };

        return studioSessionMappingResult;
    }

} // End Of Class

public static class StudioSessionMappingFactoryExtensions
{
}
