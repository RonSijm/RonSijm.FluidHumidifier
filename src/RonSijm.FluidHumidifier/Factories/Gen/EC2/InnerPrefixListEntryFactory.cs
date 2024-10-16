// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerPrefixListEntryFactory(Action<Humidifier.EC2.PrefixListTypes.Entry> factoryAction = null) : SubResourceFactory<Humidifier.EC2.PrefixListTypes.Entry>
{

    protected override Humidifier.EC2.PrefixListTypes.Entry Create()
    {
        var entryResult = CreateEntry();
        factoryAction?.Invoke(entryResult);

        return entryResult;
    }

    private Humidifier.EC2.PrefixListTypes.Entry CreateEntry()
    {
        var entryResult = new Humidifier.EC2.PrefixListTypes.Entry();

        return entryResult;
    }

} // End Of Class

public static class InnerPrefixListEntryFactoryExtensions
{
}
