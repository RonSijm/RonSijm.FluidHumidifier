// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerPartitionSerdeInfoFactory(Action<Humidifier.Glue.PartitionTypes.SerdeInfo> factoryAction = null) : SubResourceFactory<Humidifier.Glue.PartitionTypes.SerdeInfo>
{

    protected override Humidifier.Glue.PartitionTypes.SerdeInfo Create()
    {
        var serdeInfoResult = CreateSerdeInfo();
        factoryAction?.Invoke(serdeInfoResult);

        return serdeInfoResult;
    }

    private Humidifier.Glue.PartitionTypes.SerdeInfo CreateSerdeInfo()
    {
        var serdeInfoResult = new Humidifier.Glue.PartitionTypes.SerdeInfo();

        return serdeInfoResult;
    }

} // End Of Class

public static class InnerPartitionSerdeInfoFactoryExtensions
{
}
