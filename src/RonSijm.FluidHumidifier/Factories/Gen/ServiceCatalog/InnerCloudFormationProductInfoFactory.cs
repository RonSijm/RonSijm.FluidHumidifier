// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceCatalog;

public class InnerCloudFormationProductInfoFactory(Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.Info> factoryAction = null) : SubResourceFactory<Humidifier.ServiceCatalog.CloudFormationProductTypes.Info>
{

    protected override Humidifier.ServiceCatalog.CloudFormationProductTypes.Info Create()
    {
        var infoResult = CreateInfo();
        factoryAction?.Invoke(infoResult);

        return infoResult;
    }

    private Humidifier.ServiceCatalog.CloudFormationProductTypes.Info CreateInfo()
    {
        var infoResult = new Humidifier.ServiceCatalog.CloudFormationProductTypes.Info();

        return infoResult;
    }

} // End Of Class

public static class InnerCloudFormationProductInfoFactoryExtensions
{
}
