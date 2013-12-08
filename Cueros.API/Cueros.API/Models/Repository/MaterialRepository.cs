using Cueros.API.Controllers.API.ErrorHandler;
using Cueros.API.Models.APIFolder;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Cueros.API.Models.Repository
{
    public class MaterialRepository
    {
        public object Get()
        {
            try
            {
                return APIFunctions.SuccessResult(CuerosContext.DB.Materials.ToList(), JsonMessage.Success);
            }
            catch (Exception e)
            {
                return APIFunctions.ErrorResult(e.Message);
            }
        }
        public object GetByProductID(int productID)
        {
            try
            {
                return APIFunctions.SuccessResult(
                    from x in CuerosContext.DB.Compose.ToList()
                    where x.ProductID == productID
                    select x.Material, JsonMessage.Success);
            }
            catch (Exception e)
            {
                return APIFunctions.ErrorResult(e.Message);
            }
        }
    }
}