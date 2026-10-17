// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerCapabilityAwsIdcFactory(Action<Humidifier.EKS.CapabilityTypes.AwsIdc> factoryAction = null) : SubResourceFactory<Humidifier.EKS.CapabilityTypes.AwsIdc>
{

    protected override Humidifier.EKS.CapabilityTypes.AwsIdc Create()
    {
        var awsIdcResult = CreateAwsIdc();
        factoryAction?.Invoke(awsIdcResult);

        return awsIdcResult;
    }

    private Humidifier.EKS.CapabilityTypes.AwsIdc CreateAwsIdc()
    {
        var awsIdcResult = new Humidifier.EKS.CapabilityTypes.AwsIdc();

        return awsIdcResult;
    }

} // End Of Class

public static class InnerCapabilityAwsIdcFactoryExtensions
{
}
