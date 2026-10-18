// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class FarmFactory(string resourceName = null, Action<Humidifier.Deadline.Farm> factoryAction = null) : ResourceFactory<Humidifier.Deadline.Farm>(resourceName)
{

    protected override Humidifier.Deadline.Farm Create()
    {
        var farmResult = CreateFarm();
        factoryAction?.Invoke(farmResult);

        return farmResult;
    }

    private Humidifier.Deadline.Farm CreateFarm()
    {
        var farmResult = new Humidifier.Deadline.Farm
        {
            GivenName = InputResourceName,
        };

        return farmResult;
    }

} // End Of Class

public static class FarmFactoryExtensions
{
}
