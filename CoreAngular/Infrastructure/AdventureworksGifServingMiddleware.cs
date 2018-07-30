using System.Linq;
using System.Threading.Tasks;
using CoreAngular.AdventureWorks.SqliteModel;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace CoreAngular.Infrastructure
{
    public class AdventureworksGifServingMiddleware
    {
        private const string ImageUrl = "/adwimages";
        private readonly RequestDelegate _next;

        public AdventureworksGifServingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, Adventureworks2017Context dbContext)
        {
            var path = context.Request.Path;
            if (!path.StartsWithSegments(ImageUrl))
            {
                await _next(context);
            }
            else
            {
                var name = path.Value.Replace(ImageUrl + "/", "");
                var isSmallImage = name.Contains("small");
                var photo = isSmallImage ? 
                    dbContext.ProductPhoto.FirstOrDefault(p => p.ThumbnailPhotoFileName == name):
                    dbContext.ProductPhoto.FirstOrDefault(p => p.LargePhotoFileName == name);
                if (photo == null)
                {
                    photo = dbContext.ProductPhoto.FirstOrDefault(p => p.ProductPhotoId == 1);
                }

                if (photo != null)
                {
                    await context.Response.Body.WriteAsync(isSmallImage ? photo.ThumbNailPhoto : photo.LargePhoto);
                }
                else
                {
                    await _next(context);
                }
            }
        }
    }

    public static class AdventureworksGifServingMiddlewareExtensions
    {
        public static IApplicationBuilder UseAdventureworksGifServingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AdventureworksGifServingMiddleware>();
        }
    }
}
