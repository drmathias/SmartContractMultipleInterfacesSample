using Stratis.SmartContracts;

public class SampleContract : SmartContract, ISayHello, ISayWorld
{
    public SampleContract(ISmartContractState contractState) : base(contractState)
    {
    }

    public string SayHello() => "Hello";
    public string SayWorld() => "World";
}