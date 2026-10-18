// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerInstanceEbsFactory(Action<Humidifier.EC2.InstanceTypes.Ebs> factoryAction = null) : SubResourceFactory<Humidifier.EC2.InstanceTypes.Ebs>
{

    protected override Humidifier.EC2.InstanceTypes.Ebs Create()
    {
        var ebsResult = CreateEbs();
        factoryAction?.Invoke(ebsResult);

        return ebsResult;
    }

    private Humidifier.EC2.InstanceTypes.Ebs CreateEbs()
    {
        var ebsResult = new Humidifier.EC2.InstanceTypes.Ebs();

        return ebsResult;
    }

} // End Of Class

public static class InnerInstanceEbsFactoryExtensions
{
}
