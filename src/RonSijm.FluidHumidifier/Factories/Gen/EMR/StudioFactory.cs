// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class StudioFactory(string resourceName = null, Action<Humidifier.EMR.Studio> factoryAction = null) : ResourceFactory<Humidifier.EMR.Studio>(resourceName)
{

    protected override Humidifier.EMR.Studio Create()
    {
        var studioResult = CreateStudio();
        factoryAction?.Invoke(studioResult);

        return studioResult;
    }

    private Humidifier.EMR.Studio CreateStudio()
    {
        var studioResult = new Humidifier.EMR.Studio
        {
            GivenName = InputResourceName,
        };

        return studioResult;
    }

} // End Of Class

public static class StudioFactoryExtensions
{
}
