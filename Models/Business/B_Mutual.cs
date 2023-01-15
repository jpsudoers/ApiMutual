using MutualApi.Models.Data;
using MutualApi.Models.Entity;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Mvc;

namespace MutualApi.Models.Business
{
    public class B_Mutual
    {
        private D_Mutual dm = new D_Mutual();
        public JArray DatosContables(float ano, float mes, string rut)

        {
            List<E_CentralizacionContable> listado2 = new List<E_CentralizacionContable>();
            listado2 = dm.ListE_CC(mes, ano, rut);
            //E_CentralizacionContable listado = new E_CentralizacionContable();
            //listado.CuentaContable__nombre="a";
            //listado.centroCosto__codigo = "a";
            //listado.centroCosto__nombre = "a";
            //listado.cuentaContable__codigo = "a";
            //listado.debe = 0;
            //listado.haber = 0;
            //listado.item = "a";
            //listado.idEmpl = "a";
            //listado.Trx = "a";
            //listado.numTrx = "a";
            //listado.VencTrx = "a";
            //listado.month = mes;
            //listado.razonSocial = "a";
            //listado.year = ano;
            //listado2.Add(listado);
            //listado = new E_CentralizacionContable();
            //listado.CuentaContable__nombre = "b";
            //listado.centroCosto__codigo = "b";
            //listado.centroCosto__nombre = "b";
            //listado.cuentaContable__codigo = "b";
            //listado.debe = 0;
            //listado.haber = 0;
            //listado.item = "b";
            //listado.idEmpl = "b";
            //listado.Trx = "b";
            //listado.numTrx = "b";
            //listado.VencTrx = "b";
            //listado.month = mes;
            //listado.razonSocial = "b";
            //listado.year = ano;
            //listado2.Add(listado);
            string datos = JsonConvert.SerializeObject(listado2);             
            var parseado = JArray.Parse(datos);
            return parseado;
        }

        public List<E_CentralizacionContable> DatosContables2(float ano, float mes, string rut)

        {
            List<E_CentralizacionContable> listado2 = new List<E_CentralizacionContable>();
            listado2 = dm.ListE_CC(mes, ano, rut);
            return listado2;
        }
    }
}