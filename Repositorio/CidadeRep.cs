using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ProjetoCidades.Models;

namespace ProjetoCidades.Repositorio
{
    public class CidadeRep
    {
        string connectionstrig = @"Data Source= .\sqlexpress; Initial Catalog = ProjetoCidades; User ID = sa; Password = senai@123;"; 
        public List<Cidade> Listar()
        {
            var listacidades = new List <Cidade>();
            SqlConnection con = new SqlConnection(connectionstrig);
            string select = "Select * from Cidades";
            con.Open();
            SqlCommand cmd = new SqlCommand(select, con);
            SqlDataReader drd = cmd.ExecuteReader();
            while(drd.Read())
            {
                Cidade cidade = new Cidade();
                cidade.id=Convert.ToInt16(drd["id"]);
                cidade.nome = drd["nome"].ToString();
                cidade.uf = drd["uf"].ToString();
                cidade.habitantes = Convert.ToInt16(drd["habitantes"]);

                listacidades.Add(cidade);
            }
            con.Close();
            return listacidades;
        }

        public void Cadastrar(Cidade cidade)
        {
            SqlConnection con = new SqlConnection(connectionstrig);
            string insert = "INSERT INTO Cidades (nome, uf, habitantes) values('" + cidade.nome +"','" + cidade.uf + "','" + cidade.habitantes+")";
            SqlCommand cmd = new SqlCommand(insert, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}