﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataBase
    {
        private OleDbConnection conexion = new OleDbConnection("@Provider=Microsoft.ACE.OLEDB.12.0;Data Source =| DataDirectory | Materiales.accdb; Persist Security Info = False");
        private OleDbConnection connection;
        private OleDbTransaction transaction;
        private OleDbCommand command;
        private void AbrirConexion()
        {
            conexion.Open();
        }
        private void AbrirConexionValidacion()
        {
            connection = new OleDbConnection();
            connection.ConnectionString = "@Provider=Microsoft.ACE.OLEDB.12.0;Data Source =| DataDirectory | Materiales.accdb; Persist Security Info = False";
            connection.Open();
        }
        private void CerrarConexion()
        {
            conexion.Close();
            conexion.Dispose();
            conexion = null;
            GC.Collect();
        }

        private void CerrarConexionValidacion()
        {
            connection.Close();
            connection.Dispose();
            connection = null;
            GC.Collect();
        }
        public DataTable DevolverListado(string query, Hashtable hashtable)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter;
            command = new OleDbCommand(query, conexion);
            command.CommandType = CommandType.Text;

            try
            {
                adapter = new OleDbDataAdapter(command);
                if (hashtable != null)
                {
                    foreach (string key in hashtable.Keys)
                    {
                        command.Parameters.AddWithValue(key, hashtable[key]);
                    }
                }

            }
            catch (SqlException sql)
            {
                throw sql;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            adapter.Fill(dt);
            return dt;

        }
        public bool Escribir(string query, Hashtable hashtable)
        {
            AbrirConexion();

            try
            {
                transaction = conexion.BeginTransaction();
                command = new OleDbCommand(query, conexion, transaction);
                command.CommandType = CommandType.StoredProcedure;

                if (hashtable != null)
                {
                    foreach (string key in hashtable.Keys)
                    {
                        command.Parameters.AddWithValue(key, hashtable[key]);
                    }
                }
                int respuesta = command.ExecuteNonQuery();
                transaction.Commit();
                return true;
            }
            catch (SqlException sql)
            {
                transaction.Rollback();
                return false;
                throw sql;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                return false;
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
        }
        public bool Scalar(string query, Hashtable hashtable)
        {
            AbrirConexionValidacion();
            command = new OleDbCommand(query, connection);
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                if (hashtable != null)
                {
                    foreach (string key in hashtable.Keys)
                    {
                        command.Parameters.AddWithValue(key, hashtable[key]);
                    }
                }
                int respuesta = Convert.ToInt32(command.ExecuteScalar());
                if (respuesta > 0) { return true; }
                else { return false; }
            }
            catch (SqlException sql)
            {
                return false;
                throw sql;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
            finally
            {
                CerrarConexionValidacion();
            }
        }
    }
}
