//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WasteManagementAPIJob.ErrorLog {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ErrorLog", Namespace="http://www.ci.richmond.va.us/CORServices/CORApplicationLogging/ErrorLog/2008/10/C" +
        "ontracts")]
    [System.SerializableAttribute()]
    public partial class ErrorLog : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string ApplicationNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApplicationNamespaceField;
        
        private string HostServerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SourceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClassNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MethodNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SeverityField;
        
        private string ErrorMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TraceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OtherDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorUserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ErrorDateField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string ApplicationName {
            get {
                return this.ApplicationNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ApplicationNameField, value) != true)) {
                    this.ApplicationNameField = value;
                    this.RaisePropertyChanged("ApplicationName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApplicationNamespace {
            get {
                return this.ApplicationNamespaceField;
            }
            set {
                if ((object.ReferenceEquals(this.ApplicationNamespaceField, value) != true)) {
                    this.ApplicationNamespaceField = value;
                    this.RaisePropertyChanged("ApplicationNamespace");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string HostServer {
            get {
                return this.HostServerField;
            }
            set {
                if ((object.ReferenceEquals(this.HostServerField, value) != true)) {
                    this.HostServerField = value;
                    this.RaisePropertyChanged("HostServer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Source {
            get {
                return this.SourceField;
            }
            set {
                if ((object.ReferenceEquals(this.SourceField, value) != true)) {
                    this.SourceField = value;
                    this.RaisePropertyChanged("Source");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public string ClassName {
            get {
                return this.ClassNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ClassNameField, value) != true)) {
                    this.ClassNameField = value;
                    this.RaisePropertyChanged("ClassName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public string MethodName {
            get {
                return this.MethodNameField;
            }
            set {
                if ((object.ReferenceEquals(this.MethodNameField, value) != true)) {
                    this.MethodNameField = value;
                    this.RaisePropertyChanged("MethodName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public string ErrorCode {
            get {
                return this.ErrorCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorCodeField, value) != true)) {
                    this.ErrorCodeField = value;
                    this.RaisePropertyChanged("ErrorCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=7)]
        public int Severity {
            get {
                return this.SeverityField;
            }
            set {
                if ((this.SeverityField.Equals(value) != true)) {
                    this.SeverityField = value;
                    this.RaisePropertyChanged("Severity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=8)]
        public string ErrorMessage {
            get {
                return this.ErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMessageField, value) != true)) {
                    this.ErrorMessageField = value;
                    this.RaisePropertyChanged("ErrorMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=9)]
        public string Trace {
            get {
                return this.TraceField;
            }
            set {
                if ((object.ReferenceEquals(this.TraceField, value) != true)) {
                    this.TraceField = value;
                    this.RaisePropertyChanged("Trace");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=10)]
        public string OtherData {
            get {
                return this.OtherDataField;
            }
            set {
                if ((object.ReferenceEquals(this.OtherDataField, value) != true)) {
                    this.OtherDataField = value;
                    this.RaisePropertyChanged("OtherData");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=11)]
        public string ErrorUser {
            get {
                return this.ErrorUserField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorUserField, value) != true)) {
                    this.ErrorUserField = value;
                    this.RaisePropertyChanged("ErrorUser");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=12)]
        public System.DateTime ErrorDate {
            get {
                return this.ErrorDateField;
            }
            set {
                if ((this.ErrorDateField.Equals(value) != true)) {
                    this.ErrorDateField = value;
                    this.RaisePropertyChanged("ErrorDate");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.ci.richmond.va.us/CORServices/CORApplicationLogging/ErrorLog/2008/11/C" +
        "ontracts", ConfigurationName="ErrorLog.ILogError")]
    public interface ILogError {
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://www.ci.richmond.va.us/CORServices/CORApplicationLogging/ErrorLog/2008/10/Contracts) of message LogErrorRequest does not match the default value (http://www.ci.richmond.va.us/CORServices/CORApplicationLogging/ErrorLog/2008/11/Contracts)
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ci.richmond.va.us/CORServices/CORApplicationLogging/ErrorLog/2008/10/C" +
            "ontracts/ILogError/LogError", ReplyAction="http://www.ci.richmond.va.us/CORServices/CORApplicationLogging/ErrorLog/2008/10/C" +
            "ontracts/ILogError/LogErrorResponse")]
        WasteManagementAPIJob.ErrorLog.LogErrorResponse LogError(WasteManagementAPIJob.ErrorLog.LogErrorRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://www.ci.richmond.va.us/CORServices/CORApplicationLogging/ErrorLog/2008/10/Contracts) of message LogSimpleErrorRequest does not match the default value (http://www.ci.richmond.va.us/CORServices/CORApplicationLogging/ErrorLog/2008/11/Contracts)
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ci.richmond.va.us/CORServices/CORApplicationLogging/ErrorLog/2008/10/C" +
            "ontracts/ILogError/LogSimpleError", ReplyAction="http://www.ci.richmond.va.us/CORServices/CORApplicationLogging/ErrorLog/2008/10/C" +
            "ontracts/ILogError/LogSimpleErrorResponse")]
        WasteManagementAPIJob.ErrorLog.LogSimpleErrorResponse LogSimpleError(WasteManagementAPIJob.ErrorLog.LogSimpleErrorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ci.richmond.va.us/CORServices/CORApplicationLogging/ErrorLog/2008/11/C" +
            "ontracts/ILogError/LogErrorWithReturn", ReplyAction="http://www.ci.richmond.va.us/CORServices/CORApplicationLogging/ErrorLog/2008/11/C" +
            "ontracts/ILogError/LogErrorWithReturnResponse")]
        string LogErrorWithReturn(WasteManagementAPIJob.ErrorLog.ErrorLog errorLog);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ci.richmond.va.us/CORServices/CORApplicationLogging/ErrorLog/2008/11/C" +
            "ontracts/ILogError/LogSimpleErrorWithReturn", ReplyAction="http://www.ci.richmond.va.us/CORServices/CORApplicationLogging/ErrorLog/2008/11/C" +
            "ontracts/ILogError/LogSimpleErrorWithReturnResponse")]
        string LogSimpleErrorWithReturn(string applicationName, string hostServer, string message, string user, System.DateTime errorDate);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="LogError", WrapperNamespace="http://www.ci.richmond.va.us/CORServices/CORApplicationLogging/ErrorLog/2008/10/C" +
        "ontracts", IsWrapped=true)]
    public partial class LogErrorRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.ci.richmond.va.us/CORServices/CORApplicationLogging/ErrorLog/2008/10/C" +
            "ontracts", Order=0)]
        public WasteManagementAPIJob.ErrorLog.ErrorLog errorLog;
        
        public LogErrorRequest() {
        }
        
        public LogErrorRequest(WasteManagementAPIJob.ErrorLog.ErrorLog errorLog) {
            this.errorLog = errorLog;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="LogErrorResponse", WrapperNamespace="http://www.ci.richmond.va.us/CORServices/CORApplicationLogging/ErrorLog/2008/10/C" +
        "ontracts", IsWrapped=true)]
    public partial class LogErrorResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.ci.richmond.va.us/CORServices/CORApplicationLogging/ErrorLog/2008/10/C" +
            "ontracts", Order=0)]
        public bool LogErrorResult;
        
        public LogErrorResponse() {
        }
        
        public LogErrorResponse(bool LogErrorResult) {
            this.LogErrorResult = LogErrorResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="LogSimpleError", WrapperNamespace="http://www.ci.richmond.va.us/CORServices/CORApplicationLogging/ErrorLog/2008/10/C" +
        "ontracts", IsWrapped=true)]
    public partial class LogSimpleErrorRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.ci.richmond.va.us/CORServices/CORApplicationLogging/ErrorLog/2008/10/C" +
            "ontracts", Order=0)]
        public string applicationName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.ci.richmond.va.us/CORServices/CORApplicationLogging/ErrorLog/2008/10/C" +
            "ontracts", Order=1)]
        public string hostServer;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.ci.richmond.va.us/CORServices/CORApplicationLogging/ErrorLog/2008/10/C" +
            "ontracts", Order=2)]
        public string message;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.ci.richmond.va.us/CORServices/CORApplicationLogging/ErrorLog/2008/10/C" +
            "ontracts", Order=3)]
        public string user;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.ci.richmond.va.us/CORServices/CORApplicationLogging/ErrorLog/2008/10/C" +
            "ontracts", Order=4)]
        public System.DateTime errorDate;
        
        public LogSimpleErrorRequest() {
        }
        
        public LogSimpleErrorRequest(string applicationName, string hostServer, string message, string user, System.DateTime errorDate) {
            this.applicationName = applicationName;
            this.hostServer = hostServer;
            this.message = message;
            this.user = user;
            this.errorDate = errorDate;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="LogSimpleErrorResponse", WrapperNamespace="http://www.ci.richmond.va.us/CORServices/CORApplicationLogging/ErrorLog/2008/10/C" +
        "ontracts", IsWrapped=true)]
    public partial class LogSimpleErrorResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.ci.richmond.va.us/CORServices/CORApplicationLogging/ErrorLog/2008/10/C" +
            "ontracts", Order=0)]
        public bool LogSimpleErrorResult;
        
        public LogSimpleErrorResponse() {
        }
        
        public LogSimpleErrorResponse(bool LogSimpleErrorResult) {
            this.LogSimpleErrorResult = LogSimpleErrorResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILogErrorChannel : WasteManagementAPIJob.ErrorLog.ILogError, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LogErrorClient : System.ServiceModel.ClientBase<WasteManagementAPIJob.ErrorLog.ILogError>, WasteManagementAPIJob.ErrorLog.ILogError {
        
        public LogErrorClient() {
        }
        
        public LogErrorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LogErrorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LogErrorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LogErrorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WasteManagementAPIJob.ErrorLog.LogErrorResponse WasteManagementAPIJob.ErrorLog.ILogError.LogError(WasteManagementAPIJob.ErrorLog.LogErrorRequest request) {
            return base.Channel.LogError(request);
        }
        
        public bool LogError(WasteManagementAPIJob.ErrorLog.ErrorLog errorLog) {
            WasteManagementAPIJob.ErrorLog.LogErrorRequest inValue = new WasteManagementAPIJob.ErrorLog.LogErrorRequest();
            inValue.errorLog = errorLog;
            WasteManagementAPIJob.ErrorLog.LogErrorResponse retVal = ((WasteManagementAPIJob.ErrorLog.ILogError)(this)).LogError(inValue);
            return retVal.LogErrorResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WasteManagementAPIJob.ErrorLog.LogSimpleErrorResponse WasteManagementAPIJob.ErrorLog.ILogError.LogSimpleError(WasteManagementAPIJob.ErrorLog.LogSimpleErrorRequest request) {
            return base.Channel.LogSimpleError(request);
        }
        
        public bool LogSimpleError(string applicationName, string hostServer, string message, string user, System.DateTime errorDate) {
            WasteManagementAPIJob.ErrorLog.LogSimpleErrorRequest inValue = new WasteManagementAPIJob.ErrorLog.LogSimpleErrorRequest();
            inValue.applicationName = applicationName;
            inValue.hostServer = hostServer;
            inValue.message = message;
            inValue.user = user;
            inValue.errorDate = errorDate;
            WasteManagementAPIJob.ErrorLog.LogSimpleErrorResponse retVal = ((WasteManagementAPIJob.ErrorLog.ILogError)(this)).LogSimpleError(inValue);
            return retVal.LogSimpleErrorResult;
        }
        
        public string LogErrorWithReturn(WasteManagementAPIJob.ErrorLog.ErrorLog errorLog) {
            return base.Channel.LogErrorWithReturn(errorLog);
        }
        
        public string LogSimpleErrorWithReturn(string applicationName, string hostServer, string message, string user, System.DateTime errorDate) {
            return base.Channel.LogSimpleErrorWithReturn(applicationName, hostServer, message, user, errorDate);
        }
    }
}
