// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53RecoveryReadiness;

public class ReadinessCheckFactory(string resourceName = null, Action<Humidifier.Route53RecoveryReadiness.ReadinessCheck> factoryAction = null) : ResourceFactory<Humidifier.Route53RecoveryReadiness.ReadinessCheck>(resourceName)
{

    protected override Humidifier.Route53RecoveryReadiness.ReadinessCheck Create()
    {
        var readinessCheckResult = CreateReadinessCheck();
        factoryAction?.Invoke(readinessCheckResult);

        return readinessCheckResult;
    }

    private Humidifier.Route53RecoveryReadiness.ReadinessCheck CreateReadinessCheck()
    {
        var readinessCheckResult = new Humidifier.Route53RecoveryReadiness.ReadinessCheck
        {
            GivenName = InputResourceName,
        };

        return readinessCheckResult;
    }

} // End Of Class

public static class ReadinessCheckFactoryExtensions
{
}
