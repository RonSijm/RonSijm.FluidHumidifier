// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VpcLattice;

public class InnerListenerForwardFactory(Action<Humidifier.VpcLattice.ListenerTypes.Forward> factoryAction = null) : SubResourceFactory<Humidifier.VpcLattice.ListenerTypes.Forward>
{

    protected override Humidifier.VpcLattice.ListenerTypes.Forward Create()
    {
        var forwardResult = CreateForward();
        factoryAction?.Invoke(forwardResult);

        return forwardResult;
    }

    private Humidifier.VpcLattice.ListenerTypes.Forward CreateForward()
    {
        var forwardResult = new Humidifier.VpcLattice.ListenerTypes.Forward();

        return forwardResult;
    }

} // End Of Class

public static class InnerListenerForwardFactoryExtensions
{
}
