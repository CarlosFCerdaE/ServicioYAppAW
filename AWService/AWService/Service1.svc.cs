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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        AdventureWorks2019Entities aw = new AdventureWorks2019Entities();

        //Joins
        public List<GetAllProductCategoriesAndSubcategories_Result> ListaProductCategoriesAndSubcategoriesResult()
        {
            return aw.GetAllProductCategoriesAndSubcategories().ToList();
        }
        public List<GetProductReviews_Result> ListaProductReviewsResult()
        {
            return aw.GetProductReviews().ToList();
        }
        public List<GetProductSalesByYear_Result> ListaProductSalesByYearResult()
        {
            return aw.GetProductSalesByYear().ToList();
        }
        //Credit Card
        public List<CreditCardGetAll_Result> ListaCreditCardGetAllResult()
        {
            return aw.CreditCardGetAll().ToList();
        }

        public CreditCardSave_Result CreditCardSave(int CreditCardId, string CardType, string CardNumber, int ExpMonth, int ExpYear)
        {
            return aw.CreditCardSave(CreditCardId, CardType, CardNumber, ExpMonth, ExpYear).FirstOrDefault();
        }

        public CreditCardDelete_Result CreditCardDelete(int CreditCardId)
        {
            return aw.CreditCardDelete(CreditCardId).FirstOrDefault();
        }
        //Location
        public List<LocationGetAll_Result> ListaLocationGetAllResult()
        {
            return aw.LocationGetAll().ToList();
        }

        public LocationSave_Result LocationSave(int LocationId, string Name, decimal CostRate, decimal Availability)
        {
            return aw.LocationSave(LocationId, Name, CostRate, Availability).FirstOrDefault();
        }

        public LocationDelete_Result LocationDelete(int LocationId)
        {
            return aw.LocationDelete(LocationId).FirstOrDefault();
        }
    }
}
