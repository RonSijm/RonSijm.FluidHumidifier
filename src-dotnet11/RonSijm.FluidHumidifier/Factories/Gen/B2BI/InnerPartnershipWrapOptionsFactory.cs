// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.B2BI;

public class InnerPartnershipWrapOptionsFactory(Action<Humidifier.B2BI.PartnershipTypes.WrapOptions> factoryAction = null) : SubResourceFactory<Humidifier.B2BI.PartnershipTypes.WrapOptions>
{

    protected override Humidifier.B2BI.PartnershipTypes.WrapOptions Create()
    {
        var wrapOptionsResult = CreateWrapOptions();
        factoryAction?.Invoke(wrapOptionsResult);

        return wrapOptionsResult;
    }

    private Humidifier.B2BI.PartnershipTypes.WrapOptions CreateWrapOptions()
    {
        var wrapOptionsResult = new Humidifier.B2BI.PartnershipTypes.WrapOptions();

        return wrapOptionsResult;
    }

} // End Of Class

public static class InnerPartnershipWrapOptionsFactoryExtensions
{
}
