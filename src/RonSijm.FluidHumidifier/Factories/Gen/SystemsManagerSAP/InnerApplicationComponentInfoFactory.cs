// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SystemsManagerSAP;

public class InnerApplicationComponentInfoFactory(Action<Humidifier.SystemsManagerSAP.ApplicationTypes.ComponentInfo> factoryAction = null) : SubResourceFactory<Humidifier.SystemsManagerSAP.ApplicationTypes.ComponentInfo>
{

    protected override Humidifier.SystemsManagerSAP.ApplicationTypes.ComponentInfo Create()
    {
        var componentInfoResult = CreateComponentInfo();
        factoryAction?.Invoke(componentInfoResult);

        return componentInfoResult;
    }

    private Humidifier.SystemsManagerSAP.ApplicationTypes.ComponentInfo CreateComponentInfo()
    {
        var componentInfoResult = new Humidifier.SystemsManagerSAP.ApplicationTypes.ComponentInfo();

        return componentInfoResult;
    }

} // End Of Class

public static class InnerApplicationComponentInfoFactoryExtensions
{
}
