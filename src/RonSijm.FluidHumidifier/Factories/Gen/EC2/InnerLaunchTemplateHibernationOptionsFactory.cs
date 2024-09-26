// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerLaunchTemplateHibernationOptionsFactory(Action<Humidifier.EC2.LaunchTemplateTypes.HibernationOptions> factoryAction = null) : SubResourceFactory<Humidifier.EC2.LaunchTemplateTypes.HibernationOptions>
{

    protected override Humidifier.EC2.LaunchTemplateTypes.HibernationOptions Create()
    {
        var hibernationOptionsResult = CreateHibernationOptions();
        factoryAction?.Invoke(hibernationOptionsResult);

        return hibernationOptionsResult;
    }

    private Humidifier.EC2.LaunchTemplateTypes.HibernationOptions CreateHibernationOptions()
    {
        var hibernationOptionsResult = new Humidifier.EC2.LaunchTemplateTypes.HibernationOptions();

        return hibernationOptionsResult;
    }

} // End Of Class

public static class InnerLaunchTemplateHibernationOptionsFactoryExtensions
{
}
