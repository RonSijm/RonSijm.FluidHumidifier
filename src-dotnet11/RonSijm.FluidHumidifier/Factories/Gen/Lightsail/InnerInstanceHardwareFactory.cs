// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class InnerInstanceHardwareFactory(Action<Humidifier.Lightsail.InstanceTypes.Hardware> factoryAction = null) : SubResourceFactory<Humidifier.Lightsail.InstanceTypes.Hardware>
{

    protected override Humidifier.Lightsail.InstanceTypes.Hardware Create()
    {
        var hardwareResult = CreateHardware();
        factoryAction?.Invoke(hardwareResult);

        return hardwareResult;
    }

    private Humidifier.Lightsail.InstanceTypes.Hardware CreateHardware()
    {
        var hardwareResult = new Humidifier.Lightsail.InstanceTypes.Hardware();

        return hardwareResult;
    }

} // End Of Class

public static class InnerInstanceHardwareFactoryExtensions
{
}
