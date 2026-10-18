// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerConnectionLakehousePropertiesInputFactory(Action<Humidifier.DataZone.ConnectionTypes.LakehousePropertiesInput> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.ConnectionTypes.LakehousePropertiesInput>
{

    protected override Humidifier.DataZone.ConnectionTypes.LakehousePropertiesInput Create()
    {
        var lakehousePropertiesInputResult = CreateLakehousePropertiesInput();
        factoryAction?.Invoke(lakehousePropertiesInputResult);

        return lakehousePropertiesInputResult;
    }

    private Humidifier.DataZone.ConnectionTypes.LakehousePropertiesInput CreateLakehousePropertiesInput()
    {
        var lakehousePropertiesInputResult = new Humidifier.DataZone.ConnectionTypes.LakehousePropertiesInput();

        return lakehousePropertiesInputResult;
    }

} // End Of Class

public static class InnerConnectionLakehousePropertiesInputFactoryExtensions
{
}
