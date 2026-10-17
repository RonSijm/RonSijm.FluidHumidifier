// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class InnerResourceScanScanFilterFactory(Action<Humidifier.CloudFormation.ResourceScanTypes.ScanFilter> factoryAction = null) : SubResourceFactory<Humidifier.CloudFormation.ResourceScanTypes.ScanFilter>
{

    protected override Humidifier.CloudFormation.ResourceScanTypes.ScanFilter Create()
    {
        var scanFilterResult = CreateScanFilter();
        factoryAction?.Invoke(scanFilterResult);

        return scanFilterResult;
    }

    private Humidifier.CloudFormation.ResourceScanTypes.ScanFilter CreateScanFilter()
    {
        var scanFilterResult = new Humidifier.CloudFormation.ResourceScanTypes.ScanFilter();

        return scanFilterResult;
    }

} // End Of Class

public static class InnerResourceScanScanFilterFactoryExtensions
{
}
