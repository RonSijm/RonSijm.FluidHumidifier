// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Location;

public class InnerJobValidateAddressActionOptionsFactory(Action<Humidifier.Location.JobTypes.ValidateAddressActionOptions> factoryAction = null) : SubResourceFactory<Humidifier.Location.JobTypes.ValidateAddressActionOptions>
{

    protected override Humidifier.Location.JobTypes.ValidateAddressActionOptions Create()
    {
        var validateAddressActionOptionsResult = CreateValidateAddressActionOptions();
        factoryAction?.Invoke(validateAddressActionOptionsResult);

        return validateAddressActionOptionsResult;
    }

    private Humidifier.Location.JobTypes.ValidateAddressActionOptions CreateValidateAddressActionOptions()
    {
        var validateAddressActionOptionsResult = new Humidifier.Location.JobTypes.ValidateAddressActionOptions();

        return validateAddressActionOptionsResult;
    }

} // End Of Class

public static class InnerJobValidateAddressActionOptionsFactoryExtensions
{
}
