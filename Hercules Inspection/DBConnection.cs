using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Hercules_Inspection
{
    class DBConnection
    {
        public MySqlConnection mySQLConn = null;
        MySqlDataAdapter mysqlDA = null;
        MySqlTransaction mysqlTran = null;
        String mySQLString = "SERVER=localhost;DATABASE=excelagv;UID=root;PASSWORD=abcd1234;";

        public DBConnection()
        {
            mySQLConn = new MySqlConnection(mySQLString);
        }

        ~DBConnection()
        {
            if (mySQLConn != null) mySQLConn.Close();
        }

        public MySqlConnection getConnection()
        {
            return mySQLConn;
        }

        public MySqlDataAdapter getDataAdapter()
        {
            return mysqlDA;
        }

        /***************************************************************************************/
        //Project -Select by status
        public DataTable getAllProjectByStatus(int status)
        {
            DataTable result = new DataTable();
            try
            {
                if (mySQLConn.State != ConnectionState.Open) mySQLConn.Open();

                String sqlQuery = "SELECT code, name, client, description, start_dt, end_dt, status, create_by, create_dt " +
                    " FROM project " +
                    " WHERE status=@status ORDER BY create_dt";
                mysqlDA = new MySqlDataAdapter(sqlQuery, mySQLConn);
                mysqlDA.SelectCommand.Parameters.Add("@status", MySqlDbType.Int32).Value = status;
                mysqlDA.Fill(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (mySQLConn != null) mySQLConn.Close();
            }

            return result;
        }

        //Production - Update status
        public void updateProduction(String productCode, int new_status)
        {
            String sqlQuery = "UPDATE production SET status = @new_status WHERE code = @code";
            try
            {
                if (mySQLConn.State != ConnectionState.Open) mySQLConn.Open();
                mysqlTran = mySQLConn.BeginTransaction();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = mySQLConn;
                cmd.Transaction = mysqlTran;

                cmd.CommandText = sqlQuery;
                cmd.Parameters.AddWithValue("@new_status", new_status);
                cmd.Parameters.AddWithValue("@code", productCode);
                cmd.ExecuteNonQuery();
                mysqlTran.Commit();
            }
            catch (Exception ex)
            {
                mysqlTran.Rollback();
            }
            finally
            {
                if (mySQLConn != null) mySQLConn.Close();
            }

        }


        //Product_Change -Select by status
        public DataTable getInspectingProduct(String projectCode)
        {
            DataTable result = new DataTable();
            try
            {
                if (mySQLConn.State != ConnectionState.Open) mySQLConn.Open();
                String sqlQuery = "SELECT id, production_code, status, process_number, create_dt, project_code, table_number, location_number" +
                    " FROM production_change " +
                    " WHERE project_code=@projectCode " +
                    " AND status IN (12, 13) ORDER BY production_code";
                mysqlDA = new MySqlDataAdapter(sqlQuery, mySQLConn);
                mysqlDA.SelectCommand.Parameters.Add("@projectCode", MySqlDbType.VarChar).Value = projectCode;
                mysqlDA.Fill(result);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                if (mySQLConn != null) mySQLConn.Close();
            }

            return result;
        }

        //Product_Change -Select by status
        public DataTable getInspectingProductDetail(String projectCode)
        {
            DataTable result = new DataTable();
            try
            {
                if (mySQLConn.State != ConnectionState.Open) mySQLConn.Open();
                String sqlQuery = "SELECT a.production_code, a.process_number, a.status, a.location_number, b.name as process_name " +
                    " FROM production_change a  " +
                    " JOIN process b ON a.process_number = b.number AND a.project_code = b.project_code " +
                    " WHERE a.project_code=@projectCode " +
                    " AND a.status IN (12, 13) ORDER BY a.production_code";
                mysqlDA = new MySqlDataAdapter(sqlQuery, mySQLConn);
                mysqlDA.SelectCommand.Parameters.Add("@projectCode", MySqlDbType.VarChar).Value = projectCode;
                mysqlDA.Fill(result);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                if (mySQLConn != null) mySQLConn.Close();
            }

            return result;
        }
    }
}
