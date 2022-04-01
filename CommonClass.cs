using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Net.Mail;
using System.Web;
using WasteManagementAPIJob.ErrorLog;

namespace CommonClass
{

 
    public class ticketSummary
    {
        public string id { get; set; }
        public string date { get; set; }

        public string status { get; set; }
        public string amount { get; set; }
        public string site_name { get; set; }

    }

    public class TicketsSummery
    {
        public string Request { get; set; }
        public List<ticketSummary> tickets { get; set; }



    }

    public class ticketID
    {
        public string id { get; set; }

    }


    public class Weight
    {
        public string gross { get; set; }
        public string tare { get; set; }
        public string net { get; set; }
        public string uom { get; set; }
        public string rounded_net { get; set; }
        public string rounded_net_uom { get; set; }
        public string manual_override { get; set; }
    }

    public class Carrier
    {
        public string id { get; set; }
        public string description { get; set; }
    }

    public class Site
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Seal
    {
        public string number_1 { get; set; }
        public string number_2 { get; set; }
    }

    public class Address
    {
        public string street_text_1 { get; set; }
        public string street_text_2 { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string zip4 { get; set; }
    }

    public class Customer
    {
        public string name { get; set; }
        public string business_name { get; set; }
        public Address address { get; set; }
    }

    public class AuditInfo
    {
        public string created_by { get; set; }
        public string created_date_time { get; set; }
        public string modified_by { get; set; }
        public string modified_date_time { get; set; }
    }

    public class Vehicle
    {
        public string number { get; set; }
        public string description { get; set; }
        public string driver_name { get; set; }
    }

    public class Profile
    {
        public string id { get; set; }
        public string description { get; set; }
    }

    public class Origin
    {
        public string id { get; set; }
        public string description { get; set; }
    }

    public class Detail
    {
        public string sequence_number { get; set; }
        public string operator_in_id { get; set; }
        public string operator_out_id { get; set; }
        public string material_name { get; set; }
        public string surcharge_name { get; set; }
        public string description { get; set; }
        public string volume { get; set; }
        public Profile profile { get; set; }
        public string generator_name { get; set; }
        public string rounded_net_weight { get; set; }
        public string rounded_net_uom { get; set; }
        public string billed_quantity { get; set; }
        public string rate_per_unit { get; set; }
        public string rate_uom { get; set; }
        public Origin origin { get; set; }
        public string amount { get; set; }
        public string total_tax_amount { get; set; }
        public string total_amount { get; set; }
        public string purchase_order_number { get; set; }
        public string manifest_id { get; set; }
        public string container_id { get; set; }
    }

    public class Ticket
    {
        public string request_tracking_id { get; set; }
        public string id { get; set; }
        public string hauling_ticket_id { get; set; }
        public string replace_ticket_id { get; set; }
        public string void_ticket_id { get; set; }
        public string time_in { get; set; }
        public string time_out { get; set; }
        public string status { get; set; }
        public Weight weight { get; set; }
        public string operation_type { get; set; }
        public string scale_in { get; set; }
        public string scale_out { get; set; }
        public string swipe_card_id { get; set; }
        public string volume { get; set; }
        public string material_subtotal { get; set; }
        public string surcharge { get; set; }
        public string tax { get; set; }
        public string amount { get; set; }
        public string currency { get; set; }
        public Carrier carrier { get; set; }
        public Site site { get; set; }
        public string destination { get; set; }
        public string route_id { get; set; }
        public string notes { get; set; }
        public Seal seal { get; set; }
        public Customer customer { get; set; }
        public AuditInfo audit_info { get; set; }
        public Vehicle vehicle { get; set; }
        public List<Detail> details { get; set; }
    }

    public class RootObject
    {
        public string request_tracking_id { get; set; }
        public List<Ticket> tickets { get; set; }
    }

    public class ImportHistory
    {
        #region "Properties"
        private Int32 _importHistory_id;
        /// <summary>
        ///
        /// </summary>
        public Int32 ImportHistoryId
        {
            get { return _importHistory_id; }
            set { _importHistory_id = value; }
        }

        private String _name;
        /// <summary>
        ///
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private long _size;
        /// <summary>
        ///
        /// </summary>
        public long Size
        {
            get { return _size; }
            set { _size = value; }
        }

        private String _contentType;
        /// <summary>
        ///
        /// </summary>
        public String ContentType
        {
            get { return _contentType; }
            set { _contentType = value; }
        }

        private String _saveLocation;
        /// <summary>
        ///
        /// </summary>
        public String SaveLocation
        {
            get { return _saveLocation; }
            set { _saveLocation = value; }
        }

        private String _readLocation;
        /// <summary>
        ///
        /// </summary>
        public String ReadLocation
        {
            get { return _readLocation; }
            set { _readLocation = value; }
        }

        private Int32 _numRecordsImported;
        /// <summary>
        ///
        /// </summary>
        public Int32 NumRecordsImported
        {
            get { return _numRecordsImported; }
            set { _numRecordsImported = value; }
        }

        private Int32 _numRecordsProcessed;
        /// <summary>
        ///
        /// </summary>
        public Int32 NumRecordsProcessed
        {
            get { return _numRecordsProcessed; }
            set { _numRecordsProcessed = value; }
        }

        private Int32 _numRejects;
        /// <summary>
        ///
        /// </summary>
        public Int32 NumRejects
        {
            get { return _numRejects; }
            set { _numRejects = value; }
        }

        private Int32 _numDuplicates;
        /// <summary>
        ///
        /// </summary>
        public Int32 NumDuplicates
        {
            get { return _numDuplicates; }
            set { _numDuplicates = value; }
        }

        private Int32 _addedById;
        /// <summary>
        ///
        /// </summary>
        public Int32 AddedById
        {
            get { return _addedById; }
            set { _addedById = value; }
        }

        private String _addedByName;
        /// <summary>
        ///
        /// </summary>
        public String AddedByName
        {
            get { return _addedByName; }
            set { _addedByName = value; }
        }

        private DateTime _dateAdded;
        /// <summary>
        ///
        /// </summary>
        public DateTime DateAdded
        {
            get { return _dateAdded; }
            set { _dateAdded = value; }
        }


        #endregion

  
    }


    public static class Globals
    {
        public static string clientId = System.Configuration.ConfigurationManager.AppSettings["clientId"].ToString();
        public static string clientSecretId = System.Configuration.ConfigurationManager.AppSettings["clientSecretId"].ToString();
        public static string RequestId = System.Configuration.ConfigurationManager.AppSettings["Request-Tracking-Id_Dev"].ToString();

        public static string TicketsSummaryAPILink_COR_DPW = System.Configuration.ConfigurationManager.AppSettings["TicketsSummaryAPILink_COR_DPW"].ToString();
        public static string TicketsDetailsAPILink_COR_DPW = System.Configuration.ConfigurationManager.AppSettings["TicketsDetailsAPILink_COR_DPW"].ToString();

        public static string TicketsSummaryAPILink_DPW_COR = System.Configuration.ConfigurationManager.AppSettings["TicketsSummaryAPILink_DPW_COR"].ToString();
        public static string TicketsDetailsAPILink_DPW_COR = System.Configuration.ConfigurationManager.AppSettings["TicketsDetailsAPILink_DPW_COR"].ToString();

        public static string TicketsSummaryAPILink_COR_Police = System.Configuration.ConfigurationManager.AppSettings["TicketsSummaryAPILink_COR_Police"].ToString();
        public static string TicketsDetailsAPILink_COR_Police = System.Configuration.ConfigurationManager.AppSettings["TicketsDetailsAPILink_COR_Police"].ToString();

        public static string TicketsSummaryAPILink_Police_COR = System.Configuration.ConfigurationManager.AppSettings["TicketsSummaryAPILink_Police_COR"].ToString();
        public static string TicketsDetailsAPILink_Police_COR = System.Configuration.ConfigurationManager.AppSettings["TicketsDetailsAPILink_Police_COR"].ToString();


        public static string TicketsSummaryAPILink_COR_VCU = System.Configuration.ConfigurationManager.AppSettings["TicketsSummaryAPILink_COR_VCU"].ToString();
        public static string TicketsDetailsAPILink_COR_VCU = System.Configuration.ConfigurationManager.AppSettings["TicketsDetailsAPILink_COR_VCU"].ToString();


        public static string TicketsSummaryAPILink_COR_SocialService = System.Configuration.ConfigurationManager.AppSettings["TicketsSummaryAPILink_COR_SocialService"].ToString();
        public static string TicketsDetailsAPILink_COR_SocialService = System.Configuration.ConfigurationManager.AppSettings["TicketsDetailsAPILink_COR_SocialService"].ToString();


        public static string TicketsSummaryAPILink_SocialService_COR = System.Configuration.ConfigurationManager.AppSettings["TicketsSummaryAPILink_SocialService_COR"].ToString();
        public static string TicketsDetailsAPILink_SocialService_COR = System.Configuration.ConfigurationManager.AppSettings["TicketsDetailsAPILink_SocialService_COR"].ToString();

        public static string TicketsSummaryAPILink_COR_GeneralService = System.Configuration.ConfigurationManager.AppSettings["TicketsSummaryAPILink_COR_GeneralService"].ToString();
        public static string TicketsDetailsAPILink_COR_GeneralService = System.Configuration.ConfigurationManager.AppSettings["TicketsDetailsAPILink_COR_GeneralService"].ToString();

        public static string TicketsSummaryAPILink_COR_AnimalControl = System.Configuration.ConfigurationManager.AppSettings["TicketsSummaryAPILink_COR_GeneralService"].ToString();
        public static string TicketsDetailsAPILink_COR_AnimalControl = System.Configuration.ConfigurationManager.AppSettings["TicketsDetailsAPILink_COR_GeneralService"].ToString();



        
    }

    public enum Agency
    {
        COR_Dept_Police  = 1,
        COR_Dept_Social_Services = 2,
        COR_Dept_Public_Works=3,
        COR_DPW_VCU_Project = 4,
        COR_Dept_General_Services = 5,
        COR_Dept_Animal_Control= 6,
       
    }





    public static class logger
    {
        public static void WriteToLogFile(string strMessage, string outputFile)
        {
            string line = DateTime.Now.ToString() + " | ";

            line += strMessage;
            System.IO.FileInfo file = new System.IO.FileInfo(outputFile);
            file.Directory.Create();
            System.IO.FileStream fs = new FileStream(outputFile, FileMode.Append, FileAccess.Write, FileShare.None);

            StreamWriter swFromFileStream = new StreamWriter(fs);

            swFromFileStream.WriteLine(line);

            swFromFileStream.Flush();

            swFromFileStream.Close();

        }
    }


    public class ErrorLogging
    {

        

        public void LogError(string strApplicationName,
            string strApplicationNamespace,
            string strClassName,
            string strErrorCode,
            DateTime dteErrorDate,
            bool bErrorDateSpecified,
            string strErrorMessage,
            string strUser,
            string strHostServer,
            string strMethodName,
            string strOtherData,
            int nSeverity,
            bool bSeveritySpecified,
            string strSource,
            string strTrace
            )
        {
            try
            {
                //bool bLogErrorResult = false;
                //bool bLogErrorResultSpecified = true;

                var errorLog = new WasteManagementAPIJob.ErrorLog.ErrorLog();
                errorLog.ApplicationNamespace = strApplicationNamespace;
                errorLog.ClassName = strClassName;
                errorLog.ErrorCode = strErrorCode;
                errorLog.ErrorDate = dteErrorDate;
                //errorLog.ErrorDateSpecified = bErrorDateSpecified;
                errorLog.ErrorMessage = strErrorMessage;
                errorLog.ErrorUser = strUser;
                errorLog.HostServer = strHostServer;
                errorLog.MethodName = strMethodName;
                errorLog.OtherData = strOtherData;
                errorLog.Severity = nSeverity;
                //errorLog.SeveritySpecified = bSeveritySpecified;
                errorLog.Source = strSource;
                errorLog.Trace = strTrace;
                //using (WasteManagementAPIJob.ErrorLog.LogErrorClient LogError = new WasteManagementAPIJob.ErrorLog.LogErrorClient())
                //{
                    Email.EmailErrorMessage(errorLog);
                //}
            }
            catch
            {
                throw;

            }
        }
    }
    public class Email
    {
        public static void EmailErrorMessage(ErrorLog exp)
        {
            var errorMsg = "";
            var errorSubject = "";

            if (exp != null)
            {

                errorSubject = "Error from " + "WastManagement Job";
                var newLine = Environment.NewLine + "<br/>" + Environment.NewLine + "<br/>";
                errorMsg = errorSubject + newLine;
                errorMsg += "Error Type: " + exp.GetType().ToString() + newLine;
                errorMsg += "Error: " + exp.ErrorMessage + newLine + "Trace: " + exp.Trace + "Method: " + exp.MethodName;
            }
            else
            {
                errorMsg = "Error: UNKNOWN";
            }

                SendEmailMessage(errorMsg, ConfigurationManager.AppSettings["ErrorEmail"], ConfigurationManager.AppSettings["ErrorEmail"], errorSubject);
            
        }

        public static void SendEmailMessage(string strMessage, string emailTo, string emailFrom, string emailSubject, bool isBodyHtml = true)
        {

            try
            {
                using (MailMessage mailMessage = new MailMessage())
                {
                    mailMessage.Subject = emailSubject;
                    mailMessage.To.Add(emailTo);
                    mailMessage.IsBodyHtml = isBodyHtml;
                    mailMessage.From = new MailAddress(emailFrom);
                    mailMessage.Body = strMessage;
                    using (SmtpClient smtpSmtpClient = new SmtpClient(ConfigurationManager.AppSettings["emailhostserver"].ToString()))
                    {
                        smtpSmtpClient.Send(mailMessage); 
                      
                    }
                }

            }
            catch
            {
                throw;
            }
        }
    }



}

