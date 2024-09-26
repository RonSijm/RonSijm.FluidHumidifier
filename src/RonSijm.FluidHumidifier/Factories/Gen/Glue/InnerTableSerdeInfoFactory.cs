// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerTableSerdeInfoFactory(Action<Humidifier.Glue.TableTypes.SerdeInfo> factoryAction = null) : SubResourceFactory<Humidifier.Glue.TableTypes.SerdeInfo>
{

    protected override Humidifier.Glue.TableTypes.SerdeInfo Create()
    {
        var serdeInfoResult = CreateSerdeInfo();
        factoryAction?.Invoke(serdeInfoResult);

        return serdeInfoResult;
    }

    private Humidifier.Glue.TableTypes.SerdeInfo CreateSerdeInfo()
    {
        var serdeInfoResult = new Humidifier.Glue.TableTypes.SerdeInfo();

        return serdeInfoResult;
    }

} // End Of Class

public static class InnerTableSerdeInfoFactoryExtensions
{
}
