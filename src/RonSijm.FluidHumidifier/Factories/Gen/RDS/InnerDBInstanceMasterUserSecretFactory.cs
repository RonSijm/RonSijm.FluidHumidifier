// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class InnerDBInstanceMasterUserSecretFactory(Action<Humidifier.RDS.DBInstanceTypes.MasterUserSecret> factoryAction = null) : SubResourceFactory<Humidifier.RDS.DBInstanceTypes.MasterUserSecret>
{

    protected override Humidifier.RDS.DBInstanceTypes.MasterUserSecret Create()
    {
        var masterUserSecretResult = CreateMasterUserSecret();
        factoryAction?.Invoke(masterUserSecretResult);

        return masterUserSecretResult;
    }

    private Humidifier.RDS.DBInstanceTypes.MasterUserSecret CreateMasterUserSecret()
    {
        var masterUserSecretResult = new Humidifier.RDS.DBInstanceTypes.MasterUserSecret();

        return masterUserSecretResult;
    }

} // End Of Class

public static class InnerDBInstanceMasterUserSecretFactoryExtensions
{
}
