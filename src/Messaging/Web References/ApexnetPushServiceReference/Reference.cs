﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.34209.
// 
#pragma warning disable 1591

namespace Apexnet.Messaging.ApexnetPushServiceReference {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="NotificatoreSoap", Namespace="http://www.progamma.com")]
    public partial class Notificatore : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ID_DOExecuteOperationCompleted;
        
        private System.Threading.SendOrPostCallback ID_ReceiveFileOperationCompleted;
        
        private System.Threading.SendOrPostCallback ID_SendFileOperationCompleted;
        
        private System.Threading.SendOrPostCallback SendNotificationOperationCompleted;
        
        private System.Threading.SendOrPostCallback SendNotificationWithLangOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Notificatore() {
            this.Url = global::Apexnet.Messaging.Properties.Settings.Default.Apexnet_Messaging_ApexnetPushServiceReference1_Notificatore;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event ID_DOExecuteCompletedEventHandler ID_DOExecuteCompleted;
        
        /// <remarks/>
        public event ID_ReceiveFileCompletedEventHandler ID_ReceiveFileCompleted;
        
        /// <remarks/>
        public event ID_SendFileCompletedEventHandler ID_SendFileCompleted;
        
        /// <remarks/>
        public event SendNotificationCompletedEventHandler SendNotificationCompleted;
        
        /// <remarks/>
        public event SendNotificationWithLangCompletedEventHandler SendNotificationWithLangCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://www.progamma.com/ID_DOExecute", RequestNamespace="http://www.progamma.com", ResponseNamespace="http://www.progamma.com")]
        public object ID_DOExecute(string DOXML, string MethodName, string ClassName, object[] Params, bool RetDoc, ref string RetDocXML) {
            object[] results = this.Invoke("ID_DOExecute", new object[] {
                        DOXML,
                        MethodName,
                        ClassName,
                        Params,
                        RetDoc,
                        RetDocXML});
            RetDocXML = ((string)(results[1]));
            return ((object)(results[0]));
        }
        
        /// <remarks/>
        public void ID_DOExecuteAsync(string DOXML, string MethodName, string ClassName, object[] Params, bool RetDoc, string RetDocXML) {
            this.ID_DOExecuteAsync(DOXML, MethodName, ClassName, Params, RetDoc, RetDocXML, null);
        }
        
        /// <remarks/>
        public void ID_DOExecuteAsync(string DOXML, string MethodName, string ClassName, object[] Params, bool RetDoc, string RetDocXML, object userState) {
            if ((this.ID_DOExecuteOperationCompleted == null)) {
                this.ID_DOExecuteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnID_DOExecuteOperationCompleted);
            }
            this.InvokeAsync("ID_DOExecute", new object[] {
                        DOXML,
                        MethodName,
                        ClassName,
                        Params,
                        RetDoc,
                        RetDocXML}, this.ID_DOExecuteOperationCompleted, userState);
        }
        
        private void OnID_DOExecuteOperationCompleted(object arg) {
            if ((this.ID_DOExecuteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ID_DOExecuteCompleted(this, new ID_DOExecuteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://www.progamma.com/ID_ReceiveFile", RequestNamespace="http://www.progamma.com", ResponseNamespace="http://www.progamma.com")]
        public string ID_ReceiveFile([System.Xml.Serialization.SoapElementAttribute(DataType="base64Binary")] byte[] FileData, string Extension) {
            object[] results = this.Invoke("ID_ReceiveFile", new object[] {
                        FileData,
                        Extension});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void ID_ReceiveFileAsync(byte[] FileData, string Extension) {
            this.ID_ReceiveFileAsync(FileData, Extension, null);
        }
        
        /// <remarks/>
        public void ID_ReceiveFileAsync(byte[] FileData, string Extension, object userState) {
            if ((this.ID_ReceiveFileOperationCompleted == null)) {
                this.ID_ReceiveFileOperationCompleted = new System.Threading.SendOrPostCallback(this.OnID_ReceiveFileOperationCompleted);
            }
            this.InvokeAsync("ID_ReceiveFile", new object[] {
                        FileData,
                        Extension}, this.ID_ReceiveFileOperationCompleted, userState);
        }
        
        private void OnID_ReceiveFileOperationCompleted(object arg) {
            if ((this.ID_ReceiveFileCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ID_ReceiveFileCompleted(this, new ID_ReceiveFileCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://www.progamma.com/ID_SendFile", RequestNamespace="http://www.progamma.com", ResponseNamespace="http://www.progamma.com")]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType="base64Binary")]
        public byte[] ID_SendFile(string FileName) {
            object[] results = this.Invoke("ID_SendFile", new object[] {
                        FileName});
            return ((byte[])(results[0]));
        }
        
        /// <remarks/>
        public void ID_SendFileAsync(string FileName) {
            this.ID_SendFileAsync(FileName, null);
        }
        
        /// <remarks/>
        public void ID_SendFileAsync(string FileName, object userState) {
            if ((this.ID_SendFileOperationCompleted == null)) {
                this.ID_SendFileOperationCompleted = new System.Threading.SendOrPostCallback(this.OnID_SendFileOperationCompleted);
            }
            this.InvokeAsync("ID_SendFile", new object[] {
                        FileName}, this.ID_SendFileOperationCompleted, userState);
        }
        
        private void OnID_SendFileOperationCompleted(object arg) {
            if ((this.ID_SendFileCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ID_SendFileCompleted(this, new ID_SendFileCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://www.progamma.com/SendNotification", RequestNamespace="http://www.progamma.com", ResponseNamespace="http://www.progamma.com")]
        public string SendNotification(string pAuthKey, string pApplicationKey, string pMessage, string pUserName, string pSound, int pBadge) {
            object[] results = this.Invoke("SendNotification", new object[] {
                        pAuthKey,
                        pApplicationKey,
                        pMessage,
                        pUserName,
                        pSound,
                        pBadge});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SendNotificationAsync(string pAuthKey, string pApplicationKey, string pMessage, string pUserName, string pSound, int pBadge) {
            this.SendNotificationAsync(pAuthKey, pApplicationKey, pMessage, pUserName, pSound, pBadge, null);
        }
        
        /// <remarks/>
        public void SendNotificationAsync(string pAuthKey, string pApplicationKey, string pMessage, string pUserName, string pSound, int pBadge, object userState) {
            if ((this.SendNotificationOperationCompleted == null)) {
                this.SendNotificationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendNotificationOperationCompleted);
            }
            this.InvokeAsync("SendNotification", new object[] {
                        pAuthKey,
                        pApplicationKey,
                        pMessage,
                        pUserName,
                        pSound,
                        pBadge}, this.SendNotificationOperationCompleted, userState);
        }
        
        private void OnSendNotificationOperationCompleted(object arg) {
            if ((this.SendNotificationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendNotificationCompleted(this, new SendNotificationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://www.progamma.com/SendNotificationWithLang", RequestNamespace="http://www.progamma.com", ResponseNamespace="http://www.progamma.com")]
        public string SendNotificationWithLang(string pAuthKey, string pApplicationKey, string pMessage, string pUserName, string pSound, int pBadge) {
            object[] results = this.Invoke("SendNotificationWithLang", new object[] {
                        pAuthKey,
                        pApplicationKey,
                        pMessage,
                        pUserName,
                        pSound,
                        pBadge});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SendNotificationWithLangAsync(string pAuthKey, string pApplicationKey, string pMessage, string pUserName, string pSound, int pBadge) {
            this.SendNotificationWithLangAsync(pAuthKey, pApplicationKey, pMessage, pUserName, pSound, pBadge, null);
        }
        
        /// <remarks/>
        public void SendNotificationWithLangAsync(string pAuthKey, string pApplicationKey, string pMessage, string pUserName, string pSound, int pBadge, object userState) {
            if ((this.SendNotificationWithLangOperationCompleted == null)) {
                this.SendNotificationWithLangOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendNotificationWithLangOperationCompleted);
            }
            this.InvokeAsync("SendNotificationWithLang", new object[] {
                        pAuthKey,
                        pApplicationKey,
                        pMessage,
                        pUserName,
                        pSound,
                        pBadge}, this.SendNotificationWithLangOperationCompleted, userState);
        }
        
        private void OnSendNotificationWithLangOperationCompleted(object arg) {
            if ((this.SendNotificationWithLangCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendNotificationWithLangCompleted(this, new SendNotificationWithLangCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void ID_DOExecuteCompletedEventHandler(object sender, ID_DOExecuteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ID_DOExecuteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ID_DOExecuteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public object Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((object)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string RetDocXML {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void ID_ReceiveFileCompletedEventHandler(object sender, ID_ReceiveFileCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ID_ReceiveFileCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ID_ReceiveFileCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void ID_SendFileCompletedEventHandler(object sender, ID_SendFileCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ID_SendFileCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ID_SendFileCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public byte[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((byte[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void SendNotificationCompletedEventHandler(object sender, SendNotificationCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SendNotificationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SendNotificationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void SendNotificationWithLangCompletedEventHandler(object sender, SendNotificationWithLangCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SendNotificationWithLangCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SendNotificationWithLangCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591