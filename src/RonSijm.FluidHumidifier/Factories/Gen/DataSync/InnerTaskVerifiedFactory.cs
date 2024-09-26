// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerTaskVerifiedFactory(Action<Humidifier.DataSync.TaskTypes.Verified> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.TaskTypes.Verified>
{

    protected override Humidifier.DataSync.TaskTypes.Verified Create()
    {
        var verifiedResult = CreateVerified();
        factoryAction?.Invoke(verifiedResult);

        return verifiedResult;
    }

    private Humidifier.DataSync.TaskTypes.Verified CreateVerified()
    {
        var verifiedResult = new Humidifier.DataSync.TaskTypes.Verified();

        return verifiedResult;
    }

} // End Of Class

public static class InnerTaskVerifiedFactoryExtensions
{
}
