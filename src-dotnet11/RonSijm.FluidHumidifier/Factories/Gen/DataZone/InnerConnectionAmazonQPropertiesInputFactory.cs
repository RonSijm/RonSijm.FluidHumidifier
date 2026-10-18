// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerConnectionAmazonQPropertiesInputFactory(Action<Humidifier.DataZone.ConnectionTypes.AmazonQPropertiesInput> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.ConnectionTypes.AmazonQPropertiesInput>
{

    protected override Humidifier.DataZone.ConnectionTypes.AmazonQPropertiesInput Create()
    {
        var amazonQPropertiesInputResult = CreateAmazonQPropertiesInput();
        factoryAction?.Invoke(amazonQPropertiesInputResult);

        return amazonQPropertiesInputResult;
    }

    private Humidifier.DataZone.ConnectionTypes.AmazonQPropertiesInput CreateAmazonQPropertiesInput()
    {
        var amazonQPropertiesInputResult = new Humidifier.DataZone.ConnectionTypes.AmazonQPropertiesInput();

        return amazonQPropertiesInputResult;
    }

} // End Of Class

public static class InnerConnectionAmazonQPropertiesInputFactoryExtensions
{
}
