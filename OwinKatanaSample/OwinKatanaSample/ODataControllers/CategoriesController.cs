using OwinKatanaSample.Model;
using System.Web.Http;
using System.Web.OData;

namespace OwinKatanaSample.ODataControllers
{
    public class CategoriesController : ODataController
    {
        [HttpGet]
        public Category GetBestCategory()
        {
            return new Category { Id = 1, Name = "Test" };
        }
    }
}