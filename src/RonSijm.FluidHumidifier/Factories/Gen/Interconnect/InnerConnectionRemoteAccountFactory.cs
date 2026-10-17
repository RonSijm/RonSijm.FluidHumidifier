// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Interconnect;

public class InnerConnectionRemoteAccountFactory(Action<Humidifier.Interconnect.ConnectionTypes.RemoteAccount> factoryAction = null) : SubResourceFactory<Humidifier.Interconnect.ConnectionTypes.RemoteAccount>
{

    protected override Humidifier.Interconnect.ConnectionTypes.RemoteAccount Create()
    {
        var remoteAccountResult = CreateRemoteAccount();
        factoryAction?.Invoke(remoteAccountResult);

        return remoteAccountResult;
    }

    private Humidifier.Interconnect.ConnectionTypes.RemoteAccount CreateRemoteAccount()
    {
        var remoteAccountResult = new Humidifier.Interconnect.ConnectionTypes.RemoteAccount();

        return remoteAccountResult;
    }

} // End Of Class

public static class InnerConnectionRemoteAccountFactoryExtensions
{
}
