﻿using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Mi_Libreria;

namespace Mi_Libreria
{
    public class Class1
    {
        public static DataSet Ejecutar(string cmd)
        {
            SqlConnection com = new SqlConnection(@"Data Source=.;Initial Catalog=BD_sistema;Integrated Security=true");
            com.Open();
            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, com);
            DP.Fill(DS);
            com.Close();
            return DS;
        }
        public static void Insert(string c)
        {
            DataSet ds = Class1.Ejecutar(c);

        }
        public static DataSet llenarT(string a, string tabla)
        {
            string cmd = string.Format("select " + a + " from " + tabla);
            DataSet ds = Class1.Ejecutar(cmd);
            return ds;
        }
        public static DataSet llenarTA(string a, string tabla, string f)
        {
            string cmd = string.Format("select " + a + " from " + tabla + " Where m.fecha = " + f);
            DataSet ds = Class1.Ejecutar(cmd);
            return ds;
        }
        public static string Password(string c)
        {
            string cmd = string.Format("Select * from Usuario WHERE id='{0}'", c);
            DataSet ds = Class1.Ejecutar(cmd);
            string pasword = ds.Tables[0].Rows[0][3].ToString();
            return pasword;
        }
    }
}