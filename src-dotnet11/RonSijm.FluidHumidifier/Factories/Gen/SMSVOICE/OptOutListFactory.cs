// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SMSVOICE;

public class OptOutListFactory(string resourceName = null, Action<Humidifier.SMSVOICE.OptOutList> factoryAction = null) : ResourceFactory<Humidifier.SMSVOICE.OptOutList>(resourceName)
{

    protected override Humidifier.SMSVOICE.OptOutList Create()
    {
        var optOutListResult = CreateOptOutList();
        factoryAction?.Invoke(optOutListResult);

        return optOutListResult;
    }

    private Humidifier.SMSVOICE.OptOutList CreateOptOutList()
    {
        var optOutListResult = new Humidifier.SMSVOICE.OptOutList
        {
            GivenName = InputResourceName,
        };

        return optOutListResult;
    }

} // End Of Class

public static class OptOutListFactoryExtensions
{
}
