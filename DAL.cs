using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using WasteManagementAPIJob.ErrorLog;



namespace Connection
{
   
    public class DAL
    {
        //string  ImportHistoryId ;
        static string Logger = System.Configuration.ConfigurationManager.AppSettings["logger"].ToString();
        

        public List<CommonClass.ticketID> GetTicketIDListCurrentDay()
        {
            var list = new List<CommonClass.ticketID>();
            SqlConnection con;
            
            try
            {
                con = new SqlConnection(WasteManagementAPIJob.Properties.Settings.Default.Connection);
               
                Console.WriteLine("Database Call for Current Date");
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;
                cmd.CommandText = "usp_SelectWasteManagementImportDetailsByDate";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@BeginDate", DateTime.Today.ToString("MM/dd/yyy")));
                cmd.Parameters.Add(new SqlParameter("@EndDate", DateTime.Now.AddDays(1).ToString("MM/dd/yyy")));
                cmd.Connection = con;
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("Get the Ticket ID already Inserted", reader.GetInt32(6));
                       // reader.GetString(1), reader.GetInt32(2));
                        CommonClass.ticketID objTicketID = new CommonClass.ticketID();
                        objTicketID.id = reader.GetInt32(6).ToString();
                        list.Add(objTicketID);

                    }
                }
                else
                {
                    
                    Console.WriteLine("No rows found.");
                    
                }
                reader.Close();
                con.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CommonClass.logger.WriteToLogFile(ex.Message, Logger);
                CommonClass.ErrorLogging errorLog = new CommonClass.ErrorLogging();
                errorLog.LogError("WasteManagement Job", "WasteManagementJob", "", "", DateTime.Now, true, ex.Message, "", "", "GetTicketIDListCurrentDay", "", 1, true, "", "");
            }
           
            return list;

        }


        public bool InsertImportTicketDetail(object TicketItemDetails,string ImportHistoryId)
        {
            //GetImportHistory();
            //ImportHistoryInsertForToday();

            var retVal = false;
            SqlConnection con;

            con = new SqlConnection(WasteManagementAPIJob.Properties.Settings.Default.Connection);
                SqlCommand cmd = new SqlCommand("usp_InsertImportDetail", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@ImportHistoryId", ImportHistoryId);
                cmd.Parameters.AddWithValue("@TicketCreationDate", ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].audit_info.created_date_time);
                cmd.Parameters.AddWithValue("@TimeIn", ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].time_in);
                cmd.Parameters.AddWithValue("@TimeOut", ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].time_out);
                cmd.Parameters.AddWithValue("@OperatorIn", ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].details[0].operator_in_id);
                cmd.Parameters.AddWithValue("@OperatorOut", ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].details[0].operator_out_id);
                cmd.Parameters.AddWithValue("@Ticket", Convert.ToInt32(((CommonClass.RootObject)(TicketItemDetails)).tickets[0].id));
                cmd.Parameters.AddWithValue("@Customer", ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].customer.name);
                cmd.Parameters.AddWithValue("@Carrier", ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].carrier.id);
                cmd.Parameters.AddWithValue("@Vehicle", ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].vehicle.number);
                cmd.Parameters.AddWithValue("@Material", ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].details[0].material_name);
                cmd.Parameters.AddWithValue("@Rate", ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].details[0].rate_per_unit);
                cmd.Parameters.AddWithValue("@RateUnit", ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].details[0].rate_uom);
                cmd.Parameters.AddWithValue("@Tons", ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].weight.rounded_net);
                cmd.Parameters.AddWithValue("@Total", ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].details[0].total_amount);
                cmd.Parameters.AddWithValue("@ManualWt", ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].weight.manual_override);
                cmd.Parameters.AddWithValue("@GrossWt", Convert.ToInt32(((CommonClass.RootObject)(TicketItemDetails)).tickets[0].weight.gross));
                cmd.Parameters.AddWithValue("@TareWt", Convert.ToInt32(((CommonClass.RootObject)(TicketItemDetails)).tickets[0].weight.tare));
                cmd.Parameters.AddWithValue("@NetWt", Convert.ToInt32(((CommonClass.RootObject)(TicketItemDetails)).tickets[0].weight.net));
                cmd.Parameters.AddWithValue("@IBOB", ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].operation_type);
                cmd.Parameters.AddWithValue("@ScaleIn", ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].scale_in);
                cmd.Parameters.AddWithValue("@ScaleOut", ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].scale_out);
                cmd.Parameters.AddWithValue("@Comments", ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].notes);
                cmd.Parameters.AddWithValue("@ST", ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].status);
            try
            {
                con.Open();
                var rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                    retVal = true;

            }
            catch (Exception ex)
            {
                CommonClass.logger.WriteToLogFile(ex.Message, Logger);
                CommonClass.ErrorLogging errorLog = new CommonClass.ErrorLogging();
                errorLog.LogError("WasteManagement Job", "WasteManagementJob", "", "", DateTime.Now, true, ex.Message, "", "", "InsertImportTicketDetail", "", 1, true, "", "");
            
            }
         
            return retVal;
            
        }

        public bool InsertImportDetailRejects(object TicketItemDetails, string ImportHistoryId)
        {
            var retVal = false;
            SqlConnection con;

            con = new SqlConnection(WasteManagementAPIJob.Properties.Settings.Default.Connection);
            SqlCommand cmd = new SqlCommand("usp_InsertImportDetailRejects", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@ImportHistoryId", ImportHistoryId);
            cmd.Parameters.AddWithValue("@TicketCreationDate", ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].audit_info.created_date_time);
            cmd.Parameters.AddWithValue("@TimeIn", ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].time_in);
            cmd.Parameters.AddWithValue("@TimeOut", ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].time_out);
            cmd.Parameters.AddWithValue("@OperatorIn", ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].details[0].operator_in_id);
            cmd.Parameters.AddWithValue("@OperatorOut", ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].details[0].operator_out_id);
            cmd.Parameters.AddWithValue("@Ticket", Convert.ToInt32(((CommonClass.RootObject)(TicketItemDetails)).tickets[0].id));
            cmd.Parameters.AddWithValue("@Customer", ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].customer.name);
            cmd.Parameters.AddWithValue("@Carrier", ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].carrier.id);
            cmd.Parameters.AddWithValue("@Vehicle", ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].vehicle.number);
            cmd.Parameters.AddWithValue("@Material", ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].details[0].material_name);
            cmd.Parameters.AddWithValue("@Rate", ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].details[0].rate_per_unit);
            cmd.Parameters.AddWithValue("@RateUnit", ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].details[0].rate_uom);
            cmd.Parameters.AddWithValue("@Tons", ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].weight.rounded_net);
            cmd.Parameters.AddWithValue("@Total", ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].details[0].total_amount);
            cmd.Parameters.AddWithValue("@ManualWt", ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].weight.manual_override);
            cmd.Parameters.AddWithValue("@GrossWt", Convert.ToInt32(((CommonClass.RootObject)(TicketItemDetails)).tickets[0].weight.gross));
            cmd.Parameters.AddWithValue("@TareWt", Convert.ToInt32(((CommonClass.RootObject)(TicketItemDetails)).tickets[0].weight.tare));
            cmd.Parameters.AddWithValue("@NetWt", Convert.ToInt32(((CommonClass.RootObject)(TicketItemDetails)).tickets[0].weight.net));
            cmd.Parameters.AddWithValue("@IBOB", ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].operation_type);
            cmd.Parameters.AddWithValue("@ScaleIn", ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].scale_in);
            cmd.Parameters.AddWithValue("@ScaleOut", ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].scale_out);
            cmd.Parameters.AddWithValue("@Comments", ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].notes);
            cmd.Parameters.AddWithValue("@ST", ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].status);
            try
            {
                con.Open();
                var rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                    retVal = true;

            }
            catch (Exception ex)
            {
                CommonClass.logger.WriteToLogFile(ex.Message, Logger);
                CommonClass.ErrorLogging errorLog = new CommonClass.ErrorLogging();
                errorLog.LogError("WasteManagement Job", "WasteManagementJob", "", "", DateTime.Now, true, ex.Message, "", "", "InsertImportTicketDetail", "", 1, true, "", "");

            }

            return retVal;
        }

        public bool UpdateImportHistory(CommonClass.ImportHistory ih)
        {
            var retVal = false;
            SqlConnection con;

            con = new SqlConnection(WasteManagementAPIJob.Properties.Settings.Default.Connection);
            SqlCommand cmd = new SqlCommand("usp_UpdateImportHistoryById", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@ImportHistoryId", ih.ImportHistoryId);
            cmd.Parameters.AddWithValue("@NumRecordsImported", ih.NumRecordsImported);
            cmd.Parameters.AddWithValue("@NumRecordsProcessed",ih.NumRecordsProcessed);
            cmd.Parameters.AddWithValue("@NumRejects",  ih.NumRejects);
            cmd.Parameters.AddWithValue("@NumDuplicates",ih.NumDuplicates);
            
            try
            {
                con.Open();
                var rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                    retVal = true;

            }
            catch (Exception ex)
            {
                CommonClass.logger.WriteToLogFile(ex.Message, Logger);
                CommonClass.ErrorLogging errorLog = new CommonClass.ErrorLogging();
                errorLog.LogError("WasteManagement Job", "WasteManagementJob", "", "", DateTime.Now, true, ex.Message, "", "", "InsertImportTicketDetail", "", 1, true, "", "");

            }

            return retVal;
        }

        public void  GetImportHistory()
        {
           
            SqlConnection con;

            try
            {
                con = new SqlConnection(WasteManagementAPIJob.Properties.Settings.Default.Connection);

                //Console.WriteLine("Database Call for Current Date");
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;
                cmd.CommandText = "usp_SelectImportHistoryToday";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                con.Open();
                reader = cmd.ExecuteReader();
                if(!reader.HasRows)
                {
                    reader.Close();
                    con.Close();
                    ImportHistoryInsertForToday();
                }
                //else
                //{
                //    while (reader.Read())
                //    {
                       
                //        ImportHistoryId=Convert.ToInt32(reader["ImportHistoryId"]);
  
                //    }
                //}

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CommonClass.logger.WriteToLogFile(ex.Message, Logger);
                CommonClass.ErrorLogging errorLog = new CommonClass.ErrorLogging();
                errorLog.LogError("WasteManagement Job", "WasteManagementJob", "", "", DateTime.Now, true, ex.Message, "", "", "GetImportHistory", "", 1, true, "", "");
            }

           

        }

        public string   ImportHistoryInsertForToday()
        {
            string importHistoryId = string.Empty;
            SqlConnection con;

            con = new SqlConnection(WasteManagementAPIJob.Properties.Settings.Default.Connection);
            SqlCommand cmd = new SqlCommand("usp_InsertImportHistory", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@Name",  "System");
            cmd.Parameters.AddWithValue("@Size", 0);
            cmd.Parameters.AddWithValue("@ContentType", "No Content Type");
            cmd.Parameters.AddWithValue("@Location",  "System generated");
            cmd.Parameters.AddWithValue("@AddedById", "0");
            cmd.Parameters.AddWithValue("@AddedByName", "System Generated");
            SqlParameter output = new SqlParameter("@ImportHistoryId", SqlDbType.Int, 4) { Direction = ParameterDirection.Output };
            cmd.Parameters.Add(output);
            try
            {
                con.Open();
                var rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    if (cmd.Parameters["@ImportHistoryId"].Value != DBNull.Value)
                        importHistoryId = cmd.Parameters["@ImportHistoryId"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                CommonClass.logger.WriteToLogFile(ex.Message, Logger);
                CommonClass.ErrorLogging errorLog = new CommonClass.ErrorLogging();
                errorLog.LogError("WasteManagement Job", "WasteManagementJob", "", "", DateTime.Now, true, ex.Message, "", "", "ImportHistoryInsertForToday", "", 1, true, "", "");
                 
            }

            con.Close();
            return importHistoryId;

                        
        }
        
           

   }


}
  



