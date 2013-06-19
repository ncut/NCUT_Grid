using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace demo
{
    public class DataAccess
    {
        private SqlConnection connect;
        private SqlCommand command;

        public DataAccess(string connectString)
        {
            this.connect = new SqlConnection(connectString);
        }


        public SqlDataReader ReadDataFromTable(string TableName)
        {
            string CommandString = "select * from "+TableName +"where [传感器类型] = '二氧化碳'";
            command = new SqlCommand(CommandString, connect);
            command.Connection.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }
        public SqlDataReader ReadDataFromTable(string TableName,string Acc,string timeRegion,string senorID)
        {
            string format = "SELECT [传感器编号],avg([数据值]) as [数值],[传感器类型],{0} FROM {1}  where [传感器编号] ={2} and {3} group by {0} ,[传感器类型],[传感器编号]";
            string CommandString = string.Format(format,Acc,TableName,senorID,timeRegion);
            //string CommandString = "select [传感器编号],avg([数据值]) as [数值],[传感器类型]," + Acc + " from " + TableName + "where [传感器编号] =" + senorID + "and " + timeRegion + " group by " + Acc + ",[传感器类型],[传感器编号]";
            command = new SqlCommand(CommandString, connect);
            command.Connection.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }

        SqlDataReader ReadDataFromTable(string TableName,string Col)
        {
            string CommandString = "select " + Col + " from " + TableName;
            command = new SqlCommand(CommandString, connect);
            command.Connection.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }

    }
}
/*
SELECT [传感器编号],avg([数据值]) as [数值],[传感器类型],{0} FROM {1}  where [传感器编号] ={2} and {3} group by {0} ,[传感器类型],[传感器编号] 
 */