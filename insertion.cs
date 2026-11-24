using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace project_ecommerce
{
    public class insertion
    {

       Connection obj=new Connection();
        public int insert_Fn(string nm, int ag, string ad, string ph,string em, string un, string pw)
        {
            string ns = "insert into ecom values ('" + nm + "'," + ag + ",'" + ad + "','" + ph + "','"+em+"','" + un + "','" + pw + "')";
            int i = obj.Fn_NonQuery(ns);
            return i;
        }
        public int insert_fn(string nam, string eml, string una, string pwd)
        {
            string sn = "insert into adminreg values('" + nam + "','" + eml + "','" + una + "','" + pwd + "')";
            int i= obj.Fn_NonQuery(sn);
            return i;
        }

    }
}