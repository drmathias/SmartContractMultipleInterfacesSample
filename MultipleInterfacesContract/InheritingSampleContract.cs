using Stratis.SmartContracts;

[Deploy]
public class InheritingSampleContract : BaseSampleContract, ISayHello, ISayWorld
{
    public InheritingSampleContract(ISmartContractState contractState) : base(contractState)
    {
    }
    
    public string SayHello() => "Hello";
    public string SayWorld() => "World";
}