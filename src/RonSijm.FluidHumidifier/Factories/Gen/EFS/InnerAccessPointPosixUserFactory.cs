// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EFS;

public class InnerAccessPointPosixUserFactory(Action<Humidifier.EFS.AccessPointTypes.PosixUser> factoryAction = null) : SubResourceFactory<Humidifier.EFS.AccessPointTypes.PosixUser>
{

    protected override Humidifier.EFS.AccessPointTypes.PosixUser Create()
    {
        var posixUserResult = CreatePosixUser();
        factoryAction?.Invoke(posixUserResult);

        return posixUserResult;
    }

    private Humidifier.EFS.AccessPointTypes.PosixUser CreatePosixUser()
    {
        var posixUserResult = new Humidifier.EFS.AccessPointTypes.PosixUser();

        return posixUserResult;
    }

} // End Of Class

public static class InnerAccessPointPosixUserFactoryExtensions
{
}
