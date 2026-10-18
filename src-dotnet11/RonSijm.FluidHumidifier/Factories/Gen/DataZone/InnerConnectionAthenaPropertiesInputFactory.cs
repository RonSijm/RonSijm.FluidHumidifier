// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerConnectionAthenaPropertiesInputFactory(Action<Humidifier.DataZone.ConnectionTypes.AthenaPropertiesInput> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.ConnectionTypes.AthenaPropertiesInput>
{

    protected override Humidifier.DataZone.ConnectionTypes.AthenaPropertiesInput Create()
    {
        var athenaPropertiesInputResult = CreateAthenaPropertiesInput();
        factoryAction?.Invoke(athenaPropertiesInputResult);

        return athenaPropertiesInputResult;
    }

    private Humidifier.DataZone.ConnectionTypes.AthenaPropertiesInput CreateAthenaPropertiesInput()
    {
        var athenaPropertiesInputResult = new Humidifier.DataZone.ConnectionTypes.AthenaPropertiesInput();

        return athenaPropertiesInputResult;
    }

} // End Of Class

public static class InnerConnectionAthenaPropertiesInputFactoryExtensions
{
}
