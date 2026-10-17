// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class AWSManagedViewFactory(string resourceName = null, Action<Humidifier.Connect.AWSManagedView> factoryAction = null) : ResourceFactory<Humidifier.Connect.AWSManagedView>(resourceName)
{

    protected override Humidifier.Connect.AWSManagedView Create()
    {
        var aWSManagedViewResult = CreateAWSManagedView();
        factoryAction?.Invoke(aWSManagedViewResult);

        return aWSManagedViewResult;
    }

    private Humidifier.Connect.AWSManagedView CreateAWSManagedView()
    {
        var aWSManagedViewResult = new Humidifier.Connect.AWSManagedView
        {
            GivenName = InputResourceName,
        };

        return aWSManagedViewResult;
    }

} // End Of Class

public static class AWSManagedViewFactoryExtensions
{
}
