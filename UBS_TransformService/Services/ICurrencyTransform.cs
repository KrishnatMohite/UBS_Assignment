using System.ServiceModel;

namespace UBS_TransformService.Services
{
    [ServiceContract]
    interface ICurrencyTransform
    {
        [OperationContract]
        string Humanize(int ammount);
        [OperationContract(Name ="HumanzieDouble")]
        string Humanize(double ammount);
    }
}
