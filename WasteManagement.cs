using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Web;
using System.Web.Script.Serialization;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;



namespace WasteManagementJob
{
    class WasteManagementJob
    {

        // The server base address: Made it Global
        static string baseUrl = System.Configuration.ConfigurationManager.AppSettings["baseURL"].ToString();
        static string Logger = System.Configuration.ConfigurationManager.AppSettings["logger"].ToString();
        public const int TotalAgencies = 6;
        public static int insertCount = 0;
        public static int rejectCount = 0;



        //Call Entry point of the job.

        static void Main(string[] args)
        {
            Console.WriteLine("Starting ...");
            List<CommonClass.ticketID> TodayDBlist = new List<CommonClass.ticketID>();
            //CommonClass.ImportHistory ih = new CommonClass.ImportHistory();
            Connection.DAL objDAL = new Connection.DAL();
            dynamic response = null;

            for (int Agency = 1; Agency <= TotalAgencies; Agency++)
            {
                switch (Agency)
                {
                    case (int)CommonClass.Agency.COR_Dept_Police:

                        response = GetTicketSummeryData(CommonClass.Globals.TicketsSummaryAPILink_COR_Police);
                        if (response != null)
                        {
                            var data = (dynamic)response;
                            if ((data).tickets.Count >= 1)
                            {
                                //Check if it exists on the database on this date
                                TodayDBlist = objDAL.GetTicketIDListCurrentDay();
                                string ImportHistoryId = objDAL.ImportHistoryInsertForToday();
                                ScreenTickets(data, TodayDBlist, CommonClass.Globals.TicketsDetailsAPILink_COR_Police, ImportHistoryId);
                                UpdateImportHistoryTable(ImportHistoryId, (data).tickets.Count);
                            }

                        }

                        response = GetTicketSummeryData(CommonClass.Globals.TicketsSummaryAPILink_Police_COR);
                        if (response != null)
                        {
                            var data = (dynamic)response;
                            if ((data).tickets.Count >= 1)
                            {
                                //Check if it exists on the database on this date
                                TodayDBlist = objDAL.GetTicketIDListCurrentDay();
                                string ImportHistoryId = objDAL.ImportHistoryInsertForToday();
                                ScreenTickets(data, TodayDBlist, CommonClass.Globals.TicketsDetailsAPILink_Police_COR, ImportHistoryId);
                                UpdateImportHistoryTable(ImportHistoryId, (data).tickets.Count);
                            }

                        }

                        break;

                    case (int)CommonClass.Agency.COR_Dept_Public_Works:

                        response = GetTicketSummeryData(CommonClass.Globals.TicketsSummaryAPILink_COR_DPW);
                        if (response != null)
                        {
                            var data = (dynamic)response;
                            if ((data).tickets.Count >= 1)
                            {
                                //Check if it exists on the database on this date
                                TodayDBlist = objDAL.GetTicketIDListCurrentDay();
                                string ImportHistoryId = objDAL.ImportHistoryInsertForToday();
                                ScreenTickets(data, TodayDBlist, CommonClass.Globals.TicketsDetailsAPILink_COR_DPW, ImportHistoryId);
                                UpdateImportHistoryTable(ImportHistoryId, (data).tickets.Count);
                            }

                        }

                        response = GetTicketSummeryData(CommonClass.Globals.TicketsSummaryAPILink_DPW_COR);
                        if (response != null)
                        {
                            var data = (dynamic)response;
                            if ((data).tickets.Count >= 1)
                            {
                                //Check if it exists on the database on this date
                                TodayDBlist = objDAL.GetTicketIDListCurrentDay();
                                string ImportHistoryId = objDAL.ImportHistoryInsertForToday();
                                ScreenTickets(data, TodayDBlist, CommonClass.Globals.TicketsDetailsAPILink_DPW_COR, ImportHistoryId);
                                UpdateImportHistoryTable(ImportHistoryId, (data).tickets.Count);
                                
                            }

                        }

                        break;

                    case (int)CommonClass.Agency.COR_DPW_VCU_Project:

                        response = GetTicketSummeryData(CommonClass.Globals.TicketsSummaryAPILink_COR_VCU);
                        if (response != null)
                        {
                            var data = (dynamic)response;
                            if ((data).tickets.Count >= 1)
                            {
                                //Check if it exists on the database on this date
                                TodayDBlist = objDAL.GetTicketIDListCurrentDay();
                                string ImportHistoryId = objDAL.ImportHistoryInsertForToday();
                                ScreenTickets(data, TodayDBlist, CommonClass.Globals.TicketsDetailsAPILink_COR_VCU, ImportHistoryId);
                                UpdateImportHistoryTable(ImportHistoryId, (data).tickets.Count);
                            }

                        }
                        break;

                    case (int)CommonClass.Agency.COR_Dept_Social_Services:

                        response = GetTicketSummeryData(CommonClass.Globals.TicketsSummaryAPILink_COR_SocialService);
                        if (response != null)
                        {
                            var data = (dynamic)response;
                            if ((data).tickets.Count >= 1)
                            {
                                //Check if it exists on the database on this date
                                TodayDBlist = objDAL.GetTicketIDListCurrentDay();
                                string ImportHistoryId = objDAL.ImportHistoryInsertForToday();
                                ScreenTickets(data, TodayDBlist, CommonClass.Globals.TicketsDetailsAPILink_COR_SocialService, ImportHistoryId);
                                UpdateImportHistoryTable(ImportHistoryId, (data).tickets.Count);
                            }

                        }

                        response = GetTicketSummeryData(CommonClass.Globals.TicketsSummaryAPILink_SocialService_COR);
                        if (response != null)
                        {
                            var data = (dynamic)response;
                            if ((data).tickets.Count >= 1)
                            {
                                //Check if it exists on the database on this date
                                TodayDBlist = objDAL.GetTicketIDListCurrentDay();
                                string ImportHistoryId = objDAL.ImportHistoryInsertForToday();
                                ScreenTickets(data, TodayDBlist, CommonClass.Globals.TicketsDetailsAPILink_SocialService_COR, ImportHistoryId);
                                UpdateImportHistoryTable(ImportHistoryId, (data).tickets.Count);
                            }

                        }

                        break;

                    case (int)CommonClass.Agency.COR_Dept_General_Services:
                        response = GetTicketSummeryData(CommonClass.Globals.TicketsSummaryAPILink_COR_GeneralService);
                        if (response != null)
                        {
                            var data = (dynamic)response;
                            if ((data).tickets.Count >= 1)
                            {
                                //Check if it exists on the database on this date
                                TodayDBlist = objDAL.GetTicketIDListCurrentDay();
                                string ImportHistoryId = objDAL.ImportHistoryInsertForToday();
                                ScreenTickets(data, TodayDBlist, CommonClass.Globals.TicketsDetailsAPILink_COR_GeneralService, ImportHistoryId);
                                UpdateImportHistoryTable(ImportHistoryId, (data).tickets.Count);
                            }

                        }

                        break;


                    case (int)CommonClass.Agency.COR_Dept_Animal_Control:
                        response = GetTicketSummeryData(CommonClass.Globals.TicketsSummaryAPILink_COR_AnimalControl);
                        if (response != null)
                        {
                            var data = (dynamic)response;
                            if ((data).tickets.Count >= 1)
                            {
                                //Check if it exists on the database on this date
                                TodayDBlist = objDAL.GetTicketIDListCurrentDay();
                                string ImportHistoryId = objDAL.ImportHistoryInsertForToday();
                                ScreenTickets(data, TodayDBlist, CommonClass.Globals.TicketsDetailsAPILink_COR_AnimalControl, ImportHistoryId);
                                UpdateImportHistoryTable(ImportHistoryId, (data).tickets.Count);
                            }

                        }

                        break;



                }

            }
        }



        /// <summary>
        /// This method does all the work to get the ticket details  
        /// </summary>
        /// <returns></returns>
        // private static void GetTicketDetails()
        private static void GetTicketDetails(dynamic ticketId, string endpoints, string ImportHistoryId)
        {


            Connection.DAL objDAL = new Connection.DAL();

            CommonClass.ImportHistory ih = new CommonClass.ImportHistory();
            //Make a change in here if deployed in the different enviorment.
            string Url = string.Format(baseUrl + endpoints + ticketId + "?ticket_type=disposal");
            //string Url = string.Format(baseUrl + "v1/customers/136430122001/tickets/1398194?ticket_type=disposal");
            var webRequest = System.Net.WebRequest.Create(Url);

            if (webRequest != null)
            {
                webRequest.Method = "GET";
                webRequest.Timeout = 30000;
                webRequest.ContentType = "application/json";

                // Add the Authorization header .
                webRequest.Headers.Clear();
                webRequest.Headers.Add("Authorization", "Bearer " + CommonClass.Globals.clientSecretId);
                webRequest.Headers.Add("ClientId", CommonClass.Globals.clientId);
                webRequest.Headers.Add("Request-Tracking-Id", CommonClass.Globals.RequestId);

                // create the URL string for screen tickets.

                // make the request
                using (System.IO.Stream s = webRequest.GetResponse().GetResponseStream())
                {
                    object responseTicketDetails = null;
                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
                    {
                        try
                        {
                            // parse the response and return the data.
                            var jsonResponse = sr.ReadToEnd();
                            responseTicketDetails = serializer.Deserialize<CommonClass.RootObject>(jsonResponse.ToString());
                            //Validate logic for tickets
                            if (ValidateRecord((CommonClass.RootObject)(responseTicketDetails)))
                            {
                                if (objDAL.InsertImportTicketDetail((CommonClass.RootObject)(responseTicketDetails), ImportHistoryId))
                                {
                                    insertCount++;
                                    Console.WriteLine(String.Format("Response: {0}", jsonResponse));
                                }

                            }
                            else
                            {
                                if (objDAL.InsertImportDetailRejects((CommonClass.RootObject)(responseTicketDetails), ImportHistoryId))
                                {
                                    rejectCount++;
                                    Console.WriteLine(String.Format("Response: {0}", jsonResponse));

                                }

                            }




                            //End of Validation

                        }
                        catch (Exception ex)
                        {
                            CommonClass.logger.WriteToLogFile(ex.Message, Logger);
                            CommonClass.ErrorLogging errorLog = new CommonClass.ErrorLogging();
                            errorLog.LogError("WasteManagement Job", "WasteManagementJob", "", "", DateTime.Now, true, ex.Message, "", "", "GetTicketDetails", "", 1, true, "", "");



                        }
                    }

                }
            }

        }

        /// <summary>
        /// This method does all the work to get the ticket summery
        /// </summary>
        /// <returns></returns>
        // private static void GetTicketSummeryData()

        private static dynamic GetTicketSummeryData(string endpoints)
        {

            object responseSummaryData = null;
            Connection.DAL objDAL = new Connection.DAL();
            //Make a change in here if deployed in the different enviorment.
            string Url = string.Format(baseUrl + endpoints + "&fromDate=2015-01-01&toDate=2015-02-01");
            var webRequest = System.Net.WebRequest.Create(Url);
            if (webRequest != null)
            {
                webRequest.Method = "GET";
                webRequest.Timeout = 60000;
                webRequest.ContentType = "application/json";

                // Add the Authorization header .
                webRequest.Headers.Clear();
                webRequest.Headers.Add("Authorization", "Bearer " + CommonClass.Globals.clientSecretId);
                webRequest.Headers.Add("ClientId", CommonClass.Globals.clientId);
                webRequest.Headers.Add("Request-Tracking-Id", CommonClass.Globals.RequestId);

                // create the URL string for screen tickets.



                // make the request
                using (System.IO.Stream s = webRequest.GetResponse().GetResponseStream())
                {
                    object responseTicketDetails = null;
                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
                    {
                        try
                        {   // parse the response and return the data.
                            var jsonResponse = sr.ReadToEnd();
                            responseSummaryData = serializer.Deserialize<CommonClass.TicketsSummery>(jsonResponse.ToString());
                        }
                        catch (Exception ex)
                        {
                            CommonClass.logger.WriteToLogFile(ex.Message, Logger);
                            CommonClass.ErrorLogging errorLog = new CommonClass.ErrorLogging();
                            errorLog.LogError("WasteManagement Job", "WasteManagementJob", "", "", DateTime.Now, true, ex.Message, "", "", "GetTicketSummeryData", "", 1, true, "", "");

                        }
                    }



                }
            }
            return (dynamic)responseSummaryData;
        }

        private static void ScreenTickets(dynamic screenTickets, List<CommonClass.ticketID> list, string endpoints, string ImportHistoryId)
        {

            try
            {
                if (list.Count > 0)
                {   //Process the ticket which is newly updated in existing day.
                    for (int i = 0; i < ((screenTickets)).tickets.Count; i++)
                    {
                        var item = list.FirstOrDefault(x => x.id == ((screenTickets)).tickets[i].id);
                        if (item == null)

                            GetTicketDetails(((screenTickets)).tickets[i].id, endpoints, ImportHistoryId);
                    }
                }
                else
                { //Fresh start in the day.

                    for (int i = 0; i < ((screenTickets)).tickets.Count; i++)
                    {


                        GetTicketDetails(((screenTickets)).tickets[i].id, endpoints, ImportHistoryId);


                    }
                }
            }
            catch (Exception ex)
            {
                CommonClass.logger.WriteToLogFile(ex.Message, Logger);
                CommonClass.ErrorLogging errorLog = new CommonClass.ErrorLogging();
                errorLog.LogError("WasteManagement Job", "WasteManagementJob", "", "", DateTime.Now, true, ex.Message, "", "", "Screen Tickets", "", 1, true, "", "");


            }



        }

        private static bool ValidateRecord(object TicketItemDetails)
        {
            var retVal = true;
            string datetime = ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].audit_info.created_date_time;
            string TimeIn = ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].time_in;
            string TimeOut = ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].time_out;
            string TicketNo = ((CommonClass.RootObject)(TicketItemDetails)).tickets[0].id;
            if (((Convert.ToDateTime(datetime) == DateTime.MinValue || Convert.ToDateTime(TimeIn) == DateTime.MinValue || Convert.ToDateTime(TimeOut) == DateTime.MinValue || TicketNo == String.Empty)))
                retVal = false;

            return retVal;
        }

        private static void UpdateImportHistoryTable(string ImportHistoryId, dynamic list)
        {
            CommonClass.ImportHistory ih = new CommonClass.ImportHistory();
            Connection.DAL objDAL = new Connection.DAL();
            ih.ImportHistoryId = Convert.ToInt32(ImportHistoryId);
            ih.NumRecordsImported = insertCount;
            ih.NumRecordsProcessed = list;
            ih.NumRejects = rejectCount;
            ih.NumDuplicates = ih.NumRecordsProcessed - ih.NumRecordsImported - ih.NumRejects;
            objDAL.UpdateImportHistory(ih);
            //return ih;
        }


    }
}
  

            
         
    
        
    
        
    
