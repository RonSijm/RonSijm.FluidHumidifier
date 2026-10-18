// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerConnectionIamPropertiesInputFactory(Action<Humidifier.DataZone.ConnectionTypes.IamPropertiesInput> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.ConnectionTypes.IamPropertiesInput>
{

    protected override Humidifier.DataZone.ConnectionTypes.IamPropertiesInput Create()
    {
        var iamPropertiesInputResult = CreateIamPropertiesInput();
        factoryAction?.Invoke(iamPropertiesInputResult);

        return iamPropertiesInputResult;
    }

    private Humidifier.DataZone.ConnectionTypes.IamPropertiesInput CreateIamPropertiesInput()
    {
        var iamPropertiesInputResult = new Humidifier.DataZone.ConnectionTypes.IamPropertiesInput();

        return iamPropertiesInputResult;
    }

} // End Of Class

public static class InnerConnectionIamPropertiesInputFactoryExtensions
{
}
