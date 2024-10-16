// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class GroupVersionFactory(string resourceName = null, Action<Humidifier.Greengrass.GroupVersion> factoryAction = null) : ResourceFactory<Humidifier.Greengrass.GroupVersion>(resourceName)
{

    protected override Humidifier.Greengrass.GroupVersion Create()
    {
        var groupVersionResult = CreateGroupVersion();
        factoryAction?.Invoke(groupVersionResult);

        return groupVersionResult;
    }

    private Humidifier.Greengrass.GroupVersion CreateGroupVersion()
    {
        var groupVersionResult = new Humidifier.Greengrass.GroupVersion
        {
            GivenName = InputResourceName,
        };

        return groupVersionResult;
    }

} // End Of Class

public static class GroupVersionFactoryExtensions
{
}
