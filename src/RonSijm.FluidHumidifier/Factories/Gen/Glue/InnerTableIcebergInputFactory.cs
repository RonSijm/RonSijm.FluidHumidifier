// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerTableIcebergInputFactory(Action<Humidifier.Glue.TableTypes.IcebergInput> factoryAction = null) : SubResourceFactory<Humidifier.Glue.TableTypes.IcebergInput>
{

    protected override Humidifier.Glue.TableTypes.IcebergInput Create()
    {
        var icebergInputResult = CreateIcebergInput();
        factoryAction?.Invoke(icebergInputResult);

        return icebergInputResult;
    }

    private Humidifier.Glue.TableTypes.IcebergInput CreateIcebergInput()
    {
        var icebergInputResult = new Humidifier.Glue.TableTypes.IcebergInput();

        return icebergInputResult;
    }

} // End Of Class

public static class InnerTableIcebergInputFactoryExtensions
{
}
