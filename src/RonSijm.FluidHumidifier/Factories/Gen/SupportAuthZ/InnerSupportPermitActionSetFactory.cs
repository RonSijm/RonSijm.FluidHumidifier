// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SupportAuthZ;

public class InnerSupportPermitActionSetFactory(Action<Humidifier.SupportAuthZ.SupportPermitTypes.ActionSet> factoryAction = null) : SubResourceFactory<Humidifier.SupportAuthZ.SupportPermitTypes.ActionSet>
{

    protected override Humidifier.SupportAuthZ.SupportPermitTypes.ActionSet Create()
    {
        var actionSetResult = CreateActionSet();
        factoryAction?.Invoke(actionSetResult);

        return actionSetResult;
    }

    private Humidifier.SupportAuthZ.SupportPermitTypes.ActionSet CreateActionSet()
    {
        var actionSetResult = new Humidifier.SupportAuthZ.SupportPermitTypes.ActionSet();

        return actionSetResult;
    }

} // End Of Class

public static class InnerSupportPermitActionSetFactoryExtensions
{
}
