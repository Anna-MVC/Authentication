using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace RESTFull.Controllers
{
    public class ImageController : ApiController
    {
        public HttpResponseMessage Picture()
        {
            //var bitmap = new Bitmap(500, 500);
            //var image = Image.FromHbitmap(bitmap.GetHbitmap());
            //var converter = new ImageConverter();

            var response = new HttpResponseMessage();
            //response.Content = new ByteArrayContent(image.get);
            //response.Content.Headers.ContentType = new MediaTypeHeaderValue("image/jpeg");
            return response;
        }
    }
}
