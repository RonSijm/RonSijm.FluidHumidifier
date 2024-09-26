// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class ViewVersionFactory(string resourceName = null, Action<Humidifier.Connect.ViewVersion> factoryAction = null) : ResourceFactory<Humidifier.Connect.ViewVersion>(resourceName)
{

    protected override Humidifier.Connect.ViewVersion Create()
    {
        var viewVersionResult = CreateViewVersion();
        factoryAction?.Invoke(viewVersionResult);

        return viewVersionResult;
    }

    private Humidifier.Connect.ViewVersion CreateViewVersion()
    {
        var viewVersionResult = new Humidifier.Connect.ViewVersion
        {
            GivenName = InputResourceName,
        };

        return viewVersionResult;
    }

} // End Of Class

public static class ViewVersionFactoryExtensions
{
}
