// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerInstanceEnclaveOptionsFactory(Action<Humidifier.EC2.InstanceTypes.EnclaveOptions> factoryAction = null) : SubResourceFactory<Humidifier.EC2.InstanceTypes.EnclaveOptions>
{

    protected override Humidifier.EC2.InstanceTypes.EnclaveOptions Create()
    {
        var enclaveOptionsResult = CreateEnclaveOptions();
        factoryAction?.Invoke(enclaveOptionsResult);

        return enclaveOptionsResult;
    }

    private Humidifier.EC2.InstanceTypes.EnclaveOptions CreateEnclaveOptions()
    {
        var enclaveOptionsResult = new Humidifier.EC2.InstanceTypes.EnclaveOptions();

        return enclaveOptionsResult;
    }

} // End Of Class

public static class InnerInstanceEnclaveOptionsFactoryExtensions
{
}
