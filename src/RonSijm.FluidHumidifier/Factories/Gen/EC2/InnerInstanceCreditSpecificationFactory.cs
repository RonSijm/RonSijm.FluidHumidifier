// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerInstanceCreditSpecificationFactory(Action<Humidifier.EC2.InstanceTypes.CreditSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EC2.InstanceTypes.CreditSpecification>
{

    protected override Humidifier.EC2.InstanceTypes.CreditSpecification Create()
    {
        var creditSpecificationResult = CreateCreditSpecification();
        factoryAction?.Invoke(creditSpecificationResult);

        return creditSpecificationResult;
    }

    private Humidifier.EC2.InstanceTypes.CreditSpecification CreateCreditSpecification()
    {
        var creditSpecificationResult = new Humidifier.EC2.InstanceTypes.CreditSpecification();

        return creditSpecificationResult;
    }

} // End Of Class

public static class InnerInstanceCreditSpecificationFactoryExtensions
{
}
