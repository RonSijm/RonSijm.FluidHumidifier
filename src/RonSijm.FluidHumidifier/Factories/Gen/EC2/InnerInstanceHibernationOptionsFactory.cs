// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerInstanceHibernationOptionsFactory(Action<Humidifier.EC2.InstanceTypes.HibernationOptions> factoryAction = null) : SubResourceFactory<Humidifier.EC2.InstanceTypes.HibernationOptions>
{

    protected override Humidifier.EC2.InstanceTypes.HibernationOptions Create()
    {
        var hibernationOptionsResult = CreateHibernationOptions();
        factoryAction?.Invoke(hibernationOptionsResult);

        return hibernationOptionsResult;
    }

    private Humidifier.EC2.InstanceTypes.HibernationOptions CreateHibernationOptions()
    {
        var hibernationOptionsResult = new Humidifier.EC2.InstanceTypes.HibernationOptions();

        return hibernationOptionsResult;
    }

} // End Of Class

public static class InnerInstanceHibernationOptionsFactoryExtensions
{
}
