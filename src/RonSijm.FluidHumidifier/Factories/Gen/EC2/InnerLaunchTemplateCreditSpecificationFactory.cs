// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerLaunchTemplateCreditSpecificationFactory(Action<Humidifier.EC2.LaunchTemplateTypes.CreditSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EC2.LaunchTemplateTypes.CreditSpecification>
{

    protected override Humidifier.EC2.LaunchTemplateTypes.CreditSpecification Create()
    {
        var creditSpecificationResult = CreateCreditSpecification();
        factoryAction?.Invoke(creditSpecificationResult);

        return creditSpecificationResult;
    }

    private Humidifier.EC2.LaunchTemplateTypes.CreditSpecification CreateCreditSpecification()
    {
        var creditSpecificationResult = new Humidifier.EC2.LaunchTemplateTypes.CreditSpecification();

        return creditSpecificationResult;
    }

} // End Of Class

public static class InnerLaunchTemplateCreditSpecificationFactoryExtensions
{
}
