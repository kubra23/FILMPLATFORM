using FilmPlatform.Data;
using Microsoft.AspNetCore.Mvc;

namespace FilmPlatform.ViewComponents
{
    public class CategoryMenuViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            if(RouteData.Values["action"].ToString()=="Index")
                 ViewBag.SelectedCategory=RouteData?.Values["id"];
            return View(CategoryRepository.Categories);

        }
        
    }
}