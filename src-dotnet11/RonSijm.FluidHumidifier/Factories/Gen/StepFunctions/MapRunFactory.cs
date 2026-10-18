// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.StepFunctions;

public class MapRunFactory(string resourceName = null, Action<Humidifier.StepFunctions.MapRun> factoryAction = null) : ResourceFactory<Humidifier.StepFunctions.MapRun>(resourceName)
{

    protected override Humidifier.StepFunctions.MapRun Create()
    {
        var mapRunResult = CreateMapRun();
        factoryAction?.Invoke(mapRunResult);

        return mapRunResult;
    }

    private Humidifier.StepFunctions.MapRun CreateMapRun()
    {
        var mapRunResult = new Humidifier.StepFunctions.MapRun
        {
            GivenName = InputResourceName,
        };

        return mapRunResult;
    }

} // End Of Class

public static class MapRunFactoryExtensions
{
}
