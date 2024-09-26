// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class ViewFactory(string resourceName = null, Action<Humidifier.Connect.View> factoryAction = null) : ResourceFactory<Humidifier.Connect.View>(resourceName)
{

    protected override Humidifier.Connect.View Create()
    {
        var viewResult = CreateView();
        factoryAction?.Invoke(viewResult);

        return viewResult;
    }

    private Humidifier.Connect.View CreateView()
    {
        var viewResult = new Humidifier.Connect.View
        {
            GivenName = InputResourceName,
        };

        return viewResult;
    }

} // End Of Class

public static class ViewFactoryExtensions
{
}
