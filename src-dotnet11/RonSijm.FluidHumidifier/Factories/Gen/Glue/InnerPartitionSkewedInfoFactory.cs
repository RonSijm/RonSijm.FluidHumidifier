// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerPartitionSkewedInfoFactory(Action<Humidifier.Glue.PartitionTypes.SkewedInfo> factoryAction = null) : SubResourceFactory<Humidifier.Glue.PartitionTypes.SkewedInfo>
{

    protected override Humidifier.Glue.PartitionTypes.SkewedInfo Create()
    {
        var skewedInfoResult = CreateSkewedInfo();
        factoryAction?.Invoke(skewedInfoResult);

        return skewedInfoResult;
    }

    private Humidifier.Glue.PartitionTypes.SkewedInfo CreateSkewedInfo()
    {
        var skewedInfoResult = new Humidifier.Glue.PartitionTypes.SkewedInfo();

        return skewedInfoResult;
    }

} // End Of Class

public static class InnerPartitionSkewedInfoFactoryExtensions
{
}
