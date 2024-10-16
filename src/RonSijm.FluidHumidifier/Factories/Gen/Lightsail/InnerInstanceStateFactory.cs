// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class InnerInstanceStateFactory(Action<Humidifier.Lightsail.InstanceTypes.State> factoryAction = null) : SubResourceFactory<Humidifier.Lightsail.InstanceTypes.State>
{

    protected override Humidifier.Lightsail.InstanceTypes.State Create()
    {
        var stateResult = CreateState();
        factoryAction?.Invoke(stateResult);

        return stateResult;
    }

    private Humidifier.Lightsail.InstanceTypes.State CreateState()
    {
        var stateResult = new Humidifier.Lightsail.InstanceTypes.State();

        return stateResult;
    }

} // End Of Class

public static class InnerInstanceStateFactoryExtensions
{
}
