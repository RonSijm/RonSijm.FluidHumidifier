// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class ReceiptRuleSetFactory(string resourceName = null, Action<Humidifier.SES.ReceiptRuleSet> factoryAction = null) : ResourceFactory<Humidifier.SES.ReceiptRuleSet>(resourceName)
{

    protected override Humidifier.SES.ReceiptRuleSet Create()
    {
        var receiptRuleSetResult = CreateReceiptRuleSet();
        factoryAction?.Invoke(receiptRuleSetResult);

        return receiptRuleSetResult;
    }

    private Humidifier.SES.ReceiptRuleSet CreateReceiptRuleSet()
    {
        var receiptRuleSetResult = new Humidifier.SES.ReceiptRuleSet
        {
            GivenName = InputResourceName,
        };

        return receiptRuleSetResult;
    }

} // End Of Class

public static class ReceiptRuleSetFactoryExtensions
{
}
