// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTFleetWise;

public class InnerSignalCatalogBranchFactory(Action<Humidifier.IoTFleetWise.SignalCatalogTypes.Branch> factoryAction = null) : SubResourceFactory<Humidifier.IoTFleetWise.SignalCatalogTypes.Branch>
{

    protected override Humidifier.IoTFleetWise.SignalCatalogTypes.Branch Create()
    {
        var branchResult = CreateBranch();
        factoryAction?.Invoke(branchResult);

        return branchResult;
    }

    private Humidifier.IoTFleetWise.SignalCatalogTypes.Branch CreateBranch()
    {
        var branchResult = new Humidifier.IoTFleetWise.SignalCatalogTypes.Branch();

        return branchResult;
    }

} // End Of Class

public static class InnerSignalCatalogBranchFactoryExtensions
{
}
