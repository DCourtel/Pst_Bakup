﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartSingularity.PstBackupAgent.ReportService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Client", Namespace="http://schemas.datacontract.org/2004/07/SmartSingularity.PstBackupReportServer")]
    [System.SerializableAttribute()]
    public partial class Client : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ComputerNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime LastContactDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Version VersionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ComputerName {
            get {
                return this.ComputerNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ComputerNameField, value) != true)) {
                    this.ComputerNameField = value;
                    this.RaisePropertyChanged("ComputerName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime LastContactDate {
            get {
                return this.LastContactDateField;
            }
            set {
                if ((this.LastContactDateField.Equals(value) != true)) {
                    this.LastContactDateField = value;
                    this.RaisePropertyChanged("LastContactDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Version Version {
            get {
                return this.VersionField;
            }
            set {
                if ((object.ReferenceEquals(this.VersionField, value) != true)) {
                    this.VersionField = value;
                    this.RaisePropertyChanged("Version");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PstFile", Namespace="http://schemas.datacontract.org/2004/07/SmartSingularity.PstBackupReportServer")]
    [System.SerializableAttribute()]
    public partial class PstFile : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsSetToBackupField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> LastSuccessfulBackupField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LocalPathField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long SizeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsSetToBackup {
            get {
                return this.IsSetToBackupField;
            }
            set {
                if ((this.IsSetToBackupField.Equals(value) != true)) {
                    this.IsSetToBackupField = value;
                    this.RaisePropertyChanged("IsSetToBackup");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> LastSuccessfulBackup {
            get {
                return this.LastSuccessfulBackupField;
            }
            set {
                if ((this.LastSuccessfulBackupField.Equals(value) != true)) {
                    this.LastSuccessfulBackupField = value;
                    this.RaisePropertyChanged("LastSuccessfulBackup");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LocalPath {
            get {
                return this.LocalPathField;
            }
            set {
                if ((object.ReferenceEquals(this.LocalPathField, value) != true)) {
                    this.LocalPathField = value;
                    this.RaisePropertyChanged("LocalPath");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Size {
            get {
                return this.SizeField;
            }
            set {
                if ((this.SizeField.Equals(value) != true)) {
                    this.SizeField = value;
                    this.RaisePropertyChanged("Size");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BackupSession", Namespace="http://schemas.datacontract.org/2004/07/SmartSingularity.PstBackupReportServer")]
    [System.SerializableAttribute()]
    public partial class BackupSession : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SmartSingularity.PstBackupSettings.ApplicationSettings.BackupMethod BackupMethodField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ChunkCountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long CompressedSizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SmartSingularity.PstBackupSettings.ApplicationSettings.BackupDestinationType DestinationTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime EndTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SmartSingularity.PstBackupEngine.BackupResultInfo.BackupResult ErrorCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsCompressedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsScheduleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RemotePathField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime StartTimeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SmartSingularity.PstBackupSettings.ApplicationSettings.BackupMethod BackupMethod {
            get {
                return this.BackupMethodField;
            }
            set {
                if ((this.BackupMethodField.Equals(value) != true)) {
                    this.BackupMethodField = value;
                    this.RaisePropertyChanged("BackupMethod");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ChunkCount {
            get {
                return this.ChunkCountField;
            }
            set {
                if ((this.ChunkCountField.Equals(value) != true)) {
                    this.ChunkCountField = value;
                    this.RaisePropertyChanged("ChunkCount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long CompressedSize {
            get {
                return this.CompressedSizeField;
            }
            set {
                if ((this.CompressedSizeField.Equals(value) != true)) {
                    this.CompressedSizeField = value;
                    this.RaisePropertyChanged("CompressedSize");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SmartSingularity.PstBackupSettings.ApplicationSettings.BackupDestinationType DestinationType {
            get {
                return this.DestinationTypeField;
            }
            set {
                if ((this.DestinationTypeField.Equals(value) != true)) {
                    this.DestinationTypeField = value;
                    this.RaisePropertyChanged("DestinationType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime EndTime {
            get {
                return this.EndTimeField;
            }
            set {
                if ((this.EndTimeField.Equals(value) != true)) {
                    this.EndTimeField = value;
                    this.RaisePropertyChanged("EndTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SmartSingularity.PstBackupEngine.BackupResultInfo.BackupResult ErrorCode {
            get {
                return this.ErrorCodeField;
            }
            set {
                if ((this.ErrorCodeField.Equals(value) != true)) {
                    this.ErrorCodeField = value;
                    this.RaisePropertyChanged("ErrorCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsCompressed {
            get {
                return this.IsCompressedField;
            }
            set {
                if ((this.IsCompressedField.Equals(value) != true)) {
                    this.IsCompressedField = value;
                    this.RaisePropertyChanged("IsCompressed");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsSchedule {
            get {
                return this.IsScheduleField;
            }
            set {
                if ((this.IsScheduleField.Equals(value) != true)) {
                    this.IsScheduleField = value;
                    this.RaisePropertyChanged("IsSchedule");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RemotePath {
            get {
                return this.RemotePathField;
            }
            set {
                if ((object.ReferenceEquals(this.RemotePathField, value) != true)) {
                    this.RemotePathField = value;
                    this.RaisePropertyChanged("RemotePath");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime StartTime {
            get {
                return this.StartTimeField;
            }
            set {
                if ((this.StartTimeField.Equals(value) != true)) {
                    this.StartTimeField = value;
                    this.RaisePropertyChanged("StartTime");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ReportService.IReportServer")]
    public interface IReportServer {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReportServer/RegisterClient", ReplyAction="http://tempuri.org/IReportServer/RegisterClientResponse")]
        void RegisterClient(SmartSingularity.PstBackupAgent.ReportService.Client client);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReportServer/RegisterClient", ReplyAction="http://tempuri.org/IReportServer/RegisterClientResponse")]
        System.Threading.Tasks.Task RegisterClientAsync(SmartSingularity.PstBackupAgent.ReportService.Client client);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReportServer/RegisterPstFile", ReplyAction="http://tempuri.org/IReportServer/RegisterPstFileResponse")]
        void RegisterPstFile(string clientId, SmartSingularity.PstBackupAgent.ReportService.PstFile pstFile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReportServer/RegisterPstFile", ReplyAction="http://tempuri.org/IReportServer/RegisterPstFileResponse")]
        System.Threading.Tasks.Task RegisterPstFileAsync(string clientId, SmartSingularity.PstBackupAgent.ReportService.PstFile pstFile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReportServer/RegisterBackupResult", ReplyAction="http://tempuri.org/IReportServer/RegisterBackupResultResponse")]
        void RegisterBackupResult(SmartSingularity.PstBackupAgent.ReportService.PstFile pstFile, SmartSingularity.PstBackupAgent.ReportService.BackupSession backupSession);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReportServer/RegisterBackupResult", ReplyAction="http://tempuri.org/IReportServer/RegisterBackupResultResponse")]
        System.Threading.Tasks.Task RegisterBackupResultAsync(SmartSingularity.PstBackupAgent.ReportService.PstFile pstFile, SmartSingularity.PstBackupAgent.ReportService.BackupSession backupSession);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IReportServerChannel : SmartSingularity.PstBackupAgent.ReportService.IReportServer, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ReportServerClient : System.ServiceModel.ClientBase<SmartSingularity.PstBackupAgent.ReportService.IReportServer>, SmartSingularity.PstBackupAgent.ReportService.IReportServer {
        
        public ReportServerClient() {
        }
        
        public ReportServerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ReportServerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReportServerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReportServerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void RegisterClient(SmartSingularity.PstBackupAgent.ReportService.Client client) {
            base.Channel.RegisterClient(client);
        }
        
        public System.Threading.Tasks.Task RegisterClientAsync(SmartSingularity.PstBackupAgent.ReportService.Client client) {
            return base.Channel.RegisterClientAsync(client);
        }
        
        public void RegisterPstFile(string clientId, SmartSingularity.PstBackupAgent.ReportService.PstFile pstFile) {
            base.Channel.RegisterPstFile(clientId, pstFile);
        }
        
        public System.Threading.Tasks.Task RegisterPstFileAsync(string clientId, SmartSingularity.PstBackupAgent.ReportService.PstFile pstFile) {
            return base.Channel.RegisterPstFileAsync(clientId, pstFile);
        }
        
        public void RegisterBackupResult(SmartSingularity.PstBackupAgent.ReportService.PstFile pstFile, SmartSingularity.PstBackupAgent.ReportService.BackupSession backupSession) {
            base.Channel.RegisterBackupResult(pstFile, backupSession);
        }
        
        public System.Threading.Tasks.Task RegisterBackupResultAsync(SmartSingularity.PstBackupAgent.ReportService.PstFile pstFile, SmartSingularity.PstBackupAgent.ReportService.BackupSession backupSession) {
            return base.Channel.RegisterBackupResultAsync(pstFile, backupSession);
        }
    }
}
