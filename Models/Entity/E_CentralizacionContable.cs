using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MutualApi.Models.Entity
{
    public class E_CentralizacionContable
    {
        public string CuentaContable__nombre { get; set; }
        public string centroCosto__codigo { get; set; }
        public string centroCosto__nombre { get; set; }
        public string cuentaContable__codigo { get; set; }
        public float debe { get; set; }
        public float haber { get; set; }
        public string item { get; set; }
        public string idEmpl { get; set; }
        public string Trx { get; set; }
        public string numTrx { get; set; }
        public string VencTrx { get; set; }
        public float month { get; set; }
        public string razonSocial { get; set; }
        public float year { get; set; }
    }
}