// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerWorkforceWorkforceVpcConfigRequestFactory(Action<Humidifier.SageMaker.WorkforceTypes.WorkforceVpcConfigRequest> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.WorkforceTypes.WorkforceVpcConfigRequest>
{

    protected override Humidifier.SageMaker.WorkforceTypes.WorkforceVpcConfigRequest Create()
    {
        var workforceVpcConfigRequestResult = CreateWorkforceVpcConfigRequest();
        factoryAction?.Invoke(workforceVpcConfigRequestResult);

        return workforceVpcConfigRequestResult;
    }

    private Humidifier.SageMaker.WorkforceTypes.WorkforceVpcConfigRequest CreateWorkforceVpcConfigRequest()
    {
        var workforceVpcConfigRequestResult = new Humidifier.SageMaker.WorkforceTypes.WorkforceVpcConfigRequest();

        return workforceVpcConfigRequestResult;
    }

} // End Of Class

public static class InnerWorkforceWorkforceVpcConfigRequestFactoryExtensions
{
}
