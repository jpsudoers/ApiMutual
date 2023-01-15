using MutualApi.Models.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace MutualApi.Models.Data
{

    public class D_Mutual
    {
        private string ConnBD = ConfigurationManager.ConnectionStrings["ApiMutualContext"].ConnectionString;
        public List<E_CentralizacionContable> ListE_CC (float mes, float año, string RS)
        {
            E_CentralizacionContable cc =  new E_CentralizacionContable();
            List<E_CentralizacionContable> Listcc = new List<E_CentralizacionContable>();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnBD))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_CC_Listado", con))
                    {
                        
                        cmd.Parameters.Add("@mes", SqlDbType.Float).Value= mes;
                        cmd.Parameters.Add("@ano", SqlDbType.Float).Value= año;
                        cmd.Parameters.Add("@razonSocial", SqlDbType.NVarChar).Value = RS;
                        cmd.CommandType = CommandType.StoredProcedure;
                        con.Open();
                        using (SqlDataReader data = cmd.ExecuteReader())
                        {
                            while (data.Read())
                            {
                                cc.CuentaContable__nombre = data["CuentaC_nombre"].ToString();
                                cc.centroCosto__codigo = data["CentroC_codigo"].ToString();
                                cc.centroCosto__nombre = data["CentroC_nombre"].ToString();
                                cc.cuentaContable__codigo = data["CuentaC_codigo"].ToString();
                                cc.debe = float.Parse(data["Debe"].ToString());
                                cc.haber = float.Parse(data["Haber"].ToString());
                                cc.item = data["Item"].ToString();
                                cc.idEmpl = data["IdClient"].ToString();
                                cc.Trx = data["Trx"].ToString();
                                cc.numTrx = data["numTrx"].ToString();
                                cc.VencTrx = data["VencTrx"].ToString();
                                cc.month = float.Parse(data["Mes"].ToString());
                                cc.razonSocial = data["RS"].ToString();
                                cc.year = float.Parse(data["ano"].ToString());
                                Listcc.Add(cc);
                                cc = new E_CentralizacionContable();

                            }
                        }
                        con.Close();
                    }
                }
                return Listcc;
            }catch(Exception e)
            {
                return null;
            }
        }
    }
}