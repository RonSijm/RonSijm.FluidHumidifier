namespace RonSijm.FluidHumidifier.Factories.IAM
{
    public static class ServiceLinkedRoleAsArnExtension
    {
        public static FnSub AsArn(this ServiceLinkedRole role)
        {
            return Fn.Sub($"arn:aws:iam::${{AWS::AccountId}}:role/{role.ResourceName}");
        }
    }
}
