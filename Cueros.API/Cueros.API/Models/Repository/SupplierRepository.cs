using Cueros.API.Controllers.API.ErrorHandler;
using Cueros.API.Models.APIFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cueros.API.Models.Repository
{
    public class SupplierRepository
    {
        public object Get()
        {
            try
            {
                return APIFunctions.SuccessResult(CuerosContext.DB.Suppliers.ToList(), JsonMessage.Success);
            }
            catch (Exception e)
            {
                return APIFunctions.ErrorResult(e.Message);
            }
        }
        public object Get(int supplierID)
        {
            try
            {
                var supplier = CuerosContext.DB.Suppliers.Find(supplierID);
                if (supplier == null)
                {
                    return APIFunctions.ErrorResult(string.Format(JsonMessage.NotFound, "proveedor"));
                }
                return APIFunctions.SuccessResult(supplier, JsonMessage.Success);
            }
            catch (Exception e)
            {
                return APIFunctions.ErrorResult(e.Message);
            }
        }
        public object Add(Supplier supplier)
        {
            try 
	        {
                if (!ValidateSupplier(supplier))
                {
                    return APIFunctions.ErrorResult("Error en los datos");
                }
                var newSupplier = CuerosContext.DB.Suppliers.Add(supplier);
                CuerosContext.DB.SaveChanges();
                return APIFunctions.SuccessResult(newSupplier.SupplierID, JsonMessage.Success);
	        }
	        catch (Exception e)
	        {
		        return APIFunctions.ErrorResult(e.Message);
	        }
        }

        private bool ValidateSupplier(Supplier supplier)
        {
            return true;
        }
    }
}