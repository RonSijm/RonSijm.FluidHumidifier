// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53RecoveryReadiness;

public class InnerResourceSetNLBResourceFactory(Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.NLBResource> factoryAction = null) : SubResourceFactory<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.NLBResource>
{

    protected override Humidifier.Route53RecoveryReadiness.ResourceSetTypes.NLBResource Create()
    {
        var nLBResourceResult = CreateNLBResource();
        factoryAction?.Invoke(nLBResourceResult);

        return nLBResourceResult;
    }

    private Humidifier.Route53RecoveryReadiness.ResourceSetTypes.NLBResource CreateNLBResource()
    {
        var nLBResourceResult = new Humidifier.Route53RecoveryReadiness.ResourceSetTypes.NLBResource();

        return nLBResourceResult;
    }

} // End Of Class

public static class InnerResourceSetNLBResourceFactoryExtensions
{
}
