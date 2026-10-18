// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transfer;

public class InnerWebAppVpcFactory(Action<Humidifier.Transfer.WebAppTypes.Vpc> factoryAction = null) : SubResourceFactory<Humidifier.Transfer.WebAppTypes.Vpc>
{

    protected override Humidifier.Transfer.WebAppTypes.Vpc Create()
    {
        var vpcResult = CreateVpc();
        factoryAction?.Invoke(vpcResult);

        return vpcResult;
    }

    private Humidifier.Transfer.WebAppTypes.Vpc CreateVpc()
    {
        var vpcResult = new Humidifier.Transfer.WebAppTypes.Vpc();

        return vpcResult;
    }

} // End Of Class

public static class InnerWebAppVpcFactoryExtensions
{
}
