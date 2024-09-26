// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerInstanceLicenseSpecificationFactory(Action<Humidifier.EC2.InstanceTypes.LicenseSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EC2.InstanceTypes.LicenseSpecification>
{

    protected override Humidifier.EC2.InstanceTypes.LicenseSpecification Create()
    {
        var licenseSpecificationResult = CreateLicenseSpecification();
        factoryAction?.Invoke(licenseSpecificationResult);

        return licenseSpecificationResult;
    }

    private Humidifier.EC2.InstanceTypes.LicenseSpecification CreateLicenseSpecification()
    {
        var licenseSpecificationResult = new Humidifier.EC2.InstanceTypes.LicenseSpecification();

        return licenseSpecificationResult;
    }

} // End Of Class

public static class InnerInstanceLicenseSpecificationFactoryExtensions
{
}
