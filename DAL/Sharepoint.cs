using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Sharepoint
    {
        private OleDbConnection conexion = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; WSS;IMEX=0;RetrieveIds=Yes;DATABASE=https://team.effem.com/sites/DataBaseMer;LIST={958E2BAD-E1DD-4A3A-A9D7-C524F269071E}");
        private OleDbConnection connection;
        private OleDbTransaction transaction;
        private OleDbCommand command;

        private void AbrirConexion()
        {
            conexion.Open();
        }
        private void CerrarConexion()
        {
            conexion.Close();
            conexion.Dispose();
            conexion = null;
            GC.Collect();
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
            catch (OleDbException error)
            {
                transaction.Rollback();
                return false;
                throw error;
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
        public bool EscribirTransaction(string[] query)
        {
            AbrirConexion();
            OleDbTransaction oleDBTransaction;
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;
            oleDBTransaction = conexion.BeginTransaction();
            try
            {
                foreach (string queryItem in query)
                {
                    cmd.CommandText = queryItem;
                    cmd.Transaction = oleDBTransaction;
                    cmd.ExecuteNonQuery();
                }
                oleDBTransaction.Commit();
                return true;
            }
            catch (OleDbException ex)
            {
                oleDBTransaction.Rollback();
                return false;
                throw ex;
            }
            catch (Exception ex)
            {
                oleDBTransaction.Rollback();
                return false;
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
        }
    }
}
