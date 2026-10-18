// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerTableSkewedInfoFactory(Action<Humidifier.Glue.TableTypes.SkewedInfo> factoryAction = null) : SubResourceFactory<Humidifier.Glue.TableTypes.SkewedInfo>
{

    protected override Humidifier.Glue.TableTypes.SkewedInfo Create()
    {
        var skewedInfoResult = CreateSkewedInfo();
        factoryAction?.Invoke(skewedInfoResult);

        return skewedInfoResult;
    }

    private Humidifier.Glue.TableTypes.SkewedInfo CreateSkewedInfo()
    {
        var skewedInfoResult = new Humidifier.Glue.TableTypes.SkewedInfo();

        return skewedInfoResult;
    }

} // End Of Class

public static class InnerTableSkewedInfoFactoryExtensions
{
}
