// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerNodegroupRemoteAccessFactory(Action<Humidifier.EKS.NodegroupTypes.RemoteAccess> factoryAction = null) : SubResourceFactory<Humidifier.EKS.NodegroupTypes.RemoteAccess>
{

    protected override Humidifier.EKS.NodegroupTypes.RemoteAccess Create()
    {
        var remoteAccessResult = CreateRemoteAccess();
        factoryAction?.Invoke(remoteAccessResult);

        return remoteAccessResult;
    }

    private Humidifier.EKS.NodegroupTypes.RemoteAccess CreateRemoteAccess()
    {
        var remoteAccessResult = new Humidifier.EKS.NodegroupTypes.RemoteAccess();

        return remoteAccessResult;
    }

} // End Of Class

public static class InnerNodegroupRemoteAccessFactoryExtensions
{
}
