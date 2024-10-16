// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VpcLattice;

public class InnerListenerFixedResponseFactory(Action<Humidifier.VpcLattice.ListenerTypes.FixedResponse> factoryAction = null) : SubResourceFactory<Humidifier.VpcLattice.ListenerTypes.FixedResponse>
{

    protected override Humidifier.VpcLattice.ListenerTypes.FixedResponse Create()
    {
        var fixedResponseResult = CreateFixedResponse();
        factoryAction?.Invoke(fixedResponseResult);

        return fixedResponseResult;
    }

    private Humidifier.VpcLattice.ListenerTypes.FixedResponse CreateFixedResponse()
    {
        var fixedResponseResult = new Humidifier.VpcLattice.ListenerTypes.FixedResponse();

        return fixedResponseResult;
    }

} // End Of Class

public static class InnerListenerFixedResponseFactoryExtensions
{
}
