// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class InnerContainerEcrImagePullerRoleFactory(Action<Humidifier.Lightsail.ContainerTypes.EcrImagePullerRole> factoryAction = null) : SubResourceFactory<Humidifier.Lightsail.ContainerTypes.EcrImagePullerRole>
{

    protected override Humidifier.Lightsail.ContainerTypes.EcrImagePullerRole Create()
    {
        var ecrImagePullerRoleResult = CreateEcrImagePullerRole();
        factoryAction?.Invoke(ecrImagePullerRoleResult);

        return ecrImagePullerRoleResult;
    }

    private Humidifier.Lightsail.ContainerTypes.EcrImagePullerRole CreateEcrImagePullerRole()
    {
        var ecrImagePullerRoleResult = new Humidifier.Lightsail.ContainerTypes.EcrImagePullerRole();

        return ecrImagePullerRoleResult;
    }

} // End Of Class

public static class InnerContainerEcrImagePullerRoleFactoryExtensions
{
}
