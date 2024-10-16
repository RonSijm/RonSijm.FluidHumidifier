// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RAM;

public class ResourceShareFactory(string resourceName = null, Action<Humidifier.RAM.ResourceShare> factoryAction = null) : ResourceFactory<Humidifier.RAM.ResourceShare>(resourceName)
{

    protected override Humidifier.RAM.ResourceShare Create()
    {
        var resourceShareResult = CreateResourceShare();
        factoryAction?.Invoke(resourceShareResult);

        return resourceShareResult;
    }

    private Humidifier.RAM.ResourceShare CreateResourceShare()
    {
        var resourceShareResult = new Humidifier.RAM.ResourceShare
        {
            GivenName = InputResourceName,
        };

        return resourceShareResult;
    }

} // End Of Class

public static class ResourceShareFactoryExtensions
{
}
