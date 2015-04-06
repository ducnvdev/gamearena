using System.Web.Mvc;

namespace GameArena.Areas.KimCuong
{
    public class KimCuongAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "KimCuong";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "KimCuong_default",
                "KimCuong/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
