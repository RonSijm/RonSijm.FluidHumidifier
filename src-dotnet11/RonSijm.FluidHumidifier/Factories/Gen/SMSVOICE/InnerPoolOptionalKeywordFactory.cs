// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SMSVOICE;

public class InnerPoolOptionalKeywordFactory(Action<Humidifier.SMSVOICE.PoolTypes.OptionalKeyword> factoryAction = null) : SubResourceFactory<Humidifier.SMSVOICE.PoolTypes.OptionalKeyword>
{

    protected override Humidifier.SMSVOICE.PoolTypes.OptionalKeyword Create()
    {
        var optionalKeywordResult = CreateOptionalKeyword();
        factoryAction?.Invoke(optionalKeywordResult);

        return optionalKeywordResult;
    }

    private Humidifier.SMSVOICE.PoolTypes.OptionalKeyword CreateOptionalKeyword()
    {
        var optionalKeywordResult = new Humidifier.SMSVOICE.PoolTypes.OptionalKeyword();

        return optionalKeywordResult;
    }

} // End Of Class

public static class InnerPoolOptionalKeywordFactoryExtensions
{
}
