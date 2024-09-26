// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class InnerDBClusterMasterUserSecretFactory(Action<Humidifier.RDS.DBClusterTypes.MasterUserSecret> factoryAction = null) : SubResourceFactory<Humidifier.RDS.DBClusterTypes.MasterUserSecret>
{

    protected override Humidifier.RDS.DBClusterTypes.MasterUserSecret Create()
    {
        var masterUserSecretResult = CreateMasterUserSecret();
        factoryAction?.Invoke(masterUserSecretResult);

        return masterUserSecretResult;
    }

    private Humidifier.RDS.DBClusterTypes.MasterUserSecret CreateMasterUserSecret()
    {
        var masterUserSecretResult = new Humidifier.RDS.DBClusterTypes.MasterUserSecret();

        return masterUserSecretResult;
    }

} // End Of Class

public static class InnerDBClusterMasterUserSecretFactoryExtensions
{
}
