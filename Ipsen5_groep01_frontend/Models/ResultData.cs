namespace Ipsen5_groep01_frontend.Models
{
    public class ResultData
{
    public object ContractDto { get; set; }
    public List<Contract> Contracts { get; set; }
    public ResultError ResultError { get; set; }
}
}