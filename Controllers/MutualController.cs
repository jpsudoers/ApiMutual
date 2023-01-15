using Microsoft.Ajax.Utilities;
using MutualApi.Models.Business;
using MutualApi.Models.Entity;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Mvc;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;

namespace MutualApi.Controllers
{
    public class MutualController : ApiController
    {
        B_Mutual bm = new B_Mutual();


        [HttpGet]
        public JArray Datos(float mes, float ano, string rut)
        {
            
           
            //var json = GlobalConfiguration.Configuration.Formatters.JsonFormatter;
            //json.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
            //json.UseDataContractJsonSerializer = true;
            JArray resultado = bm.DatosContables(ano, mes, rut);
            //var x = JSON.stringify();
            return  resultado;
            //return new JsonResult { Data = resultado, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }


        
        public IHttpActionResult Datos2(float mes, float ano, string rut)
        {


            //var json = GlobalConfiguration.Configuration.Formatters.JsonFormatter;
            //json.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
            //json.UseDataContractJsonSerializer = true;
            List<E_CentralizacionContable> resultado = bm.DatosContables2(ano, mes, rut);
            //var x = JSON.stringify();
            return Json(new { Data = resultado });
            //return new JsonResult { Data = resultado, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}
