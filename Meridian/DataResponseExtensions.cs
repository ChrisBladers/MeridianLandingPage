using System.Web.Mvc;
using DataResponses;

namespace Meridian
{
    public static class DataResponseExtensions
    {
            public static JsonResult Result(this DataResponse dataResponse)
            {
                JsonResult jsonData = new JsonResult();
                jsonData.Data = dataResponse;
                return jsonData;
            }
    }
}