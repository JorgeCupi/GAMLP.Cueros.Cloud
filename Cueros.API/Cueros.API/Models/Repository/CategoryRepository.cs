using Cueros.API.Controllers.API.ErrorHandler;
using Cueros.API.Models.APIFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cueros.API.Models.Repository
{
    public class CategoryRepository
    {
        public object Get()
        {
            try
            {
                return APIFunctions.SuccessResult(CuerosContext.DB.Categories.ToList(), JsonMessage.Success);
            }
            catch (Exception e)
            {
                return APIFunctions.ErrorResult(e.Message);
            }
        }
        public object GetByCategoryID(int categoryID)
        {
            try
            {
                return APIFunctions.SuccessResult(CuerosContext.DB.Categories.Find(categoryID), JsonMessage.Success);
            }
            catch (Exception e)
            {
                return APIFunctions.ErrorResult(e.Message);
            }
        }
    }
}