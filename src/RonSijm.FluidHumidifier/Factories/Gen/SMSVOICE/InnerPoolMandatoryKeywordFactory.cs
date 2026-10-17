// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SMSVOICE;

public class InnerPoolMandatoryKeywordFactory(Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword> factoryAction = null) : SubResourceFactory<Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword>
{

    protected override Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword Create()
    {
        var mandatoryKeywordResult = CreateMandatoryKeyword();
        factoryAction?.Invoke(mandatoryKeywordResult);

        return mandatoryKeywordResult;
    }

    private Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword CreateMandatoryKeyword()
    {
        var mandatoryKeywordResult = new Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword();

        return mandatoryKeywordResult;
    }

} // End Of Class

public static class InnerPoolMandatoryKeywordFactoryExtensions
{
}
