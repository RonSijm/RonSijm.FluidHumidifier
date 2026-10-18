// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GlobalAccelerator;

public class AcceleratorFactory(string resourceName = null, Action<Humidifier.GlobalAccelerator.Accelerator> factoryAction = null) : ResourceFactory<Humidifier.GlobalAccelerator.Accelerator>(resourceName)
{

    protected override Humidifier.GlobalAccelerator.Accelerator Create()
    {
        var acceleratorResult = CreateAccelerator();
        factoryAction?.Invoke(acceleratorResult);

        return acceleratorResult;
    }

    private Humidifier.GlobalAccelerator.Accelerator CreateAccelerator()
    {
        var acceleratorResult = new Humidifier.GlobalAccelerator.Accelerator
        {
            GivenName = InputResourceName,
        };

        return acceleratorResult;
    }

} // End Of Class

public static class AcceleratorFactoryExtensions
{
}
