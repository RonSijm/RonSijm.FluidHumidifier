// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerLaunchTemplateIamInstanceProfileFactory(Action<Humidifier.EC2.LaunchTemplateTypes.IamInstanceProfile> factoryAction = null) : SubResourceFactory<Humidifier.EC2.LaunchTemplateTypes.IamInstanceProfile>
{

    protected override Humidifier.EC2.LaunchTemplateTypes.IamInstanceProfile Create()
    {
        var iamInstanceProfileResult = CreateIamInstanceProfile();
        factoryAction?.Invoke(iamInstanceProfileResult);

        return iamInstanceProfileResult;
    }

    private Humidifier.EC2.LaunchTemplateTypes.IamInstanceProfile CreateIamInstanceProfile()
    {
        var iamInstanceProfileResult = new Humidifier.EC2.LaunchTemplateTypes.IamInstanceProfile();

        return iamInstanceProfileResult;
    }

} // End Of Class

public static class InnerLaunchTemplateIamInstanceProfileFactoryExtensions
{
}
