// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FMS;

public class ResourceSetFactory(string resourceName = null, Action<Humidifier.FMS.ResourceSet> factoryAction = null) : ResourceFactory<Humidifier.FMS.ResourceSet>(resourceName)
{

    protected override Humidifier.FMS.ResourceSet Create()
    {
        var resourceSetResult = CreateResourceSet();
        factoryAction?.Invoke(resourceSetResult);

        return resourceSetResult;
    }

    private Humidifier.FMS.ResourceSet CreateResourceSet()
    {
        var resourceSetResult = new Humidifier.FMS.ResourceSet
        {
            GivenName = InputResourceName,
        };

        return resourceSetResult;
    }

} // End Of Class

public static class ResourceSetFactoryExtensions
{
}
