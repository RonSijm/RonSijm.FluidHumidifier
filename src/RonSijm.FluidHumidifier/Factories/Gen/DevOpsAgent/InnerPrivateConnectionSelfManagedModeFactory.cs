// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerPrivateConnectionSelfManagedModeFactory(Action<Humidifier.DevOpsAgent.PrivateConnectionTypes.SelfManagedMode> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.PrivateConnectionTypes.SelfManagedMode>
{

    protected override Humidifier.DevOpsAgent.PrivateConnectionTypes.SelfManagedMode Create()
    {
        var selfManagedModeResult = CreateSelfManagedMode();
        factoryAction?.Invoke(selfManagedModeResult);

        return selfManagedModeResult;
    }

    private Humidifier.DevOpsAgent.PrivateConnectionTypes.SelfManagedMode CreateSelfManagedMode()
    {
        var selfManagedModeResult = new Humidifier.DevOpsAgent.PrivateConnectionTypes.SelfManagedMode();

        return selfManagedModeResult;
    }

} // End Of Class

public static class InnerPrivateConnectionSelfManagedModeFactoryExtensions
{
}
