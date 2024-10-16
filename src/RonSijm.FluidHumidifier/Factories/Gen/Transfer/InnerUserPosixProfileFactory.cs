// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transfer;

public class InnerUserPosixProfileFactory(Action<Humidifier.Transfer.UserTypes.PosixProfile> factoryAction = null) : SubResourceFactory<Humidifier.Transfer.UserTypes.PosixProfile>
{

    protected override Humidifier.Transfer.UserTypes.PosixProfile Create()
    {
        var posixProfileResult = CreatePosixProfile();
        factoryAction?.Invoke(posixProfileResult);

        return posixProfileResult;
    }

    private Humidifier.Transfer.UserTypes.PosixProfile CreatePosixProfile()
    {
        var posixProfileResult = new Humidifier.Transfer.UserTypes.PosixProfile();

        return posixProfileResult;
    }

} // End Of Class

public static class InnerUserPosixProfileFactoryExtensions
{
}
