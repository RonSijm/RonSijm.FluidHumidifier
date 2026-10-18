// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerGroupGroupVersionFactory(Action<Humidifier.Greengrass.GroupTypes.GroupVersion> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.GroupTypes.GroupVersion>
{

    protected override Humidifier.Greengrass.GroupTypes.GroupVersion Create()
    {
        var groupVersionResult = CreateGroupVersion();
        factoryAction?.Invoke(groupVersionResult);

        return groupVersionResult;
    }

    private Humidifier.Greengrass.GroupTypes.GroupVersion CreateGroupVersion()
    {
        var groupVersionResult = new Humidifier.Greengrass.GroupTypes.GroupVersion();

        return groupVersionResult;
    }

} // End Of Class

public static class InnerGroupGroupVersionFactoryExtensions
{
}
