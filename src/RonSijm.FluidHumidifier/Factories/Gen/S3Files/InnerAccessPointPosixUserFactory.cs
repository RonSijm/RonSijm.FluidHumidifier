// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Files;

public class InnerAccessPointPosixUserFactory(Action<Humidifier.S3Files.AccessPointTypes.PosixUser> factoryAction = null) : SubResourceFactory<Humidifier.S3Files.AccessPointTypes.PosixUser>
{

    protected override Humidifier.S3Files.AccessPointTypes.PosixUser Create()
    {
        var posixUserResult = CreatePosixUser();
        factoryAction?.Invoke(posixUserResult);

        return posixUserResult;
    }

    private Humidifier.S3Files.AccessPointTypes.PosixUser CreatePosixUser()
    {
        var posixUserResult = new Humidifier.S3Files.AccessPointTypes.PosixUser();

        return posixUserResult;
    }

} // End Of Class

public static class InnerAccessPointPosixUserFactoryExtensions
{
}
