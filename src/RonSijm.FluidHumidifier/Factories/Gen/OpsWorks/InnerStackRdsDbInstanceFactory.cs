// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpsWorks;

public class InnerStackRdsDbInstanceFactory(Action<Humidifier.OpsWorks.StackTypes.RdsDbInstance> factoryAction = null) : SubResourceFactory<Humidifier.OpsWorks.StackTypes.RdsDbInstance>
{

    protected override Humidifier.OpsWorks.StackTypes.RdsDbInstance Create()
    {
        var rdsDbInstanceResult = CreateRdsDbInstance();
        factoryAction?.Invoke(rdsDbInstanceResult);

        return rdsDbInstanceResult;
    }

    private Humidifier.OpsWorks.StackTypes.RdsDbInstance CreateRdsDbInstance()
    {
        var rdsDbInstanceResult = new Humidifier.OpsWorks.StackTypes.RdsDbInstance();

        return rdsDbInstanceResult;
    }

} // End Of Class

public static class InnerStackRdsDbInstanceFactoryExtensions
{
}
