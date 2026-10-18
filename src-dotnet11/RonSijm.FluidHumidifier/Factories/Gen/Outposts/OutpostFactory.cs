// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Outposts;

public class OutpostFactory(string resourceName = null, Action<Humidifier.Outposts.Outpost> factoryAction = null) : ResourceFactory<Humidifier.Outposts.Outpost>(resourceName)
{

    protected override Humidifier.Outposts.Outpost Create()
    {
        var outpostResult = CreateOutpost();
        factoryAction?.Invoke(outpostResult);

        return outpostResult;
    }

    private Humidifier.Outposts.Outpost CreateOutpost()
    {
        var outpostResult = new Humidifier.Outposts.Outpost
        {
            GivenName = InputResourceName,
        };

        return outpostResult;
    }

} // End Of Class

public static class OutpostFactoryExtensions
{
}
