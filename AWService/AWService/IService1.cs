using AWService.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AWService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        List<GetAllProductCategoriesAndSubcategories_Result> ListaProductCategoriesAndSubcategoriesResult();
        [OperationContract]
        List<GetProductReviews_Result> ListaProductReviewsResult();
        [OperationContract]
        List<GetProductSalesByYear_Result> ListaProductSalesByYearResult();

        //Credit Card
        [OperationContract]
        List<CreditCardGetAll_Result> ListaCreditCardGetAllResult();
        [OperationContract]
        CreditCardSave_Result CreditCardSave(int CreditCardId, string CardType, string CardNumber, int ExpMonth, int ExpYear);
        [OperationContract]
        CreditCardDelete_Result CreditCardDelete(int CreditCardId);

        //Location
        [OperationContract]
        List<LocationGetAll_Result> ListaLocationGetAllResult();
        [OperationContract]
        LocationSave_Result LocationSave(int LocationId, string Name, decimal CostRate, decimal Availability);
        [OperationContract]
        LocationDelete_Result LocationDelete(int LocationId);
    }
}
