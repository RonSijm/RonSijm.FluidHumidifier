// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EVS;

public class InnerEnvironmentHostInfoForCreateFactory(Action<Humidifier.EVS.EnvironmentTypes.HostInfoForCreate> factoryAction = null) : SubResourceFactory<Humidifier.EVS.EnvironmentTypes.HostInfoForCreate>
{

    protected override Humidifier.EVS.EnvironmentTypes.HostInfoForCreate Create()
    {
        var hostInfoForCreateResult = CreateHostInfoForCreate();
        factoryAction?.Invoke(hostInfoForCreateResult);

        return hostInfoForCreateResult;
    }

    private Humidifier.EVS.EnvironmentTypes.HostInfoForCreate CreateHostInfoForCreate()
    {
        var hostInfoForCreateResult = new Humidifier.EVS.EnvironmentTypes.HostInfoForCreate();

        return hostInfoForCreateResult;
    }

} // End Of Class

public static class InnerEnvironmentHostInfoForCreateFactoryExtensions
{
}
