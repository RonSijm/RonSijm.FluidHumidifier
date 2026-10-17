// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRServerless;

public class InnerJobRunHiveFactory(Action<Humidifier.EMRServerless.JobRunTypes.Hive> factoryAction = null) : SubResourceFactory<Humidifier.EMRServerless.JobRunTypes.Hive>
{

    protected override Humidifier.EMRServerless.JobRunTypes.Hive Create()
    {
        var hiveResult = CreateHive();
        factoryAction?.Invoke(hiveResult);

        return hiveResult;
    }

    private Humidifier.EMRServerless.JobRunTypes.Hive CreateHive()
    {
        var hiveResult = new Humidifier.EMRServerless.JobRunTypes.Hive();

        return hiveResult;
    }

} // End Of Class

public static class InnerJobRunHiveFactoryExtensions
{
}
