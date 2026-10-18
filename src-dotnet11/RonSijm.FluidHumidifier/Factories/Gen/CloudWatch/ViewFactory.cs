// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class ViewFactory(string resourceName = null, Action<Humidifier.CloudWatch.View> factoryAction = null) : ResourceFactory<Humidifier.CloudWatch.View>(resourceName)
{

    protected override Humidifier.CloudWatch.View Create()
    {
        var viewResult = CreateView();
        factoryAction?.Invoke(viewResult);

        return viewResult;
    }

    private Humidifier.CloudWatch.View CreateView()
    {
        var viewResult = new Humidifier.CloudWatch.View
        {
            GivenName = InputResourceName,
        };

        return viewResult;
    }

} // End Of Class

public static class ViewFactoryExtensions
{
}
