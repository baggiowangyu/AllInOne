﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XbapClient.DataCenterServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DataCenter", Namespace="http://schemas.datacontract.org/2004/07/WCFServiceWebRole")]
    [System.SerializableAttribute()]
    public partial class DataCenter : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private XbapClient.DataCenterServiceReference.Rect BoundField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public XbapClient.DataCenterServiceReference.Rect Bound {
            get {
                return this.BoundField;
            }
            set {
                if ((object.ReferenceEquals(this.BoundField, value) != true)) {
                    this.BoundField = value;
                    this.RaisePropertyChanged("Bound");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Rect", Namespace="http://schemas.datacontract.org/2004/07/WCFServiceWebRole")]
    [System.SerializableAttribute()]
    public partial class Rect : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double HeightField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double WidthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double XField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double YField;
        
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
        public double Height {
            get {
                return this.HeightField;
            }
            set {
                if ((this.HeightField.Equals(value) != true)) {
                    this.HeightField = value;
                    this.RaisePropertyChanged("Height");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Width {
            get {
                return this.WidthField;
            }
            set {
                if ((this.WidthField.Equals(value) != true)) {
                    this.WidthField = value;
                    this.RaisePropertyChanged("Width");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double X {
            get {
                return this.XField;
            }
            set {
                if ((this.XField.Equals(value) != true)) {
                    this.XField = value;
                    this.RaisePropertyChanged("X");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Y {
            get {
                return this.YField;
            }
            set {
                if ((this.YField.Equals(value) != true)) {
                    this.YField = value;
                    this.RaisePropertyChanged("Y");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DataCenterServiceReference.IDataCenterService")]
    public interface IDataCenterService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataCenterService/GetDataCenters", ReplyAction="http://tempuri.org/IDataCenterService/GetDataCentersResponse")]
        XbapClient.DataCenterServiceReference.DataCenter[] GetDataCenters();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IDataCenterService/GetDataCenters", ReplyAction="http://tempuri.org/IDataCenterService/GetDataCentersResponse")]
        System.IAsyncResult BeginGetDataCenters(System.AsyncCallback callback, object asyncState);
        
        XbapClient.DataCenterServiceReference.DataCenter[] EndGetDataCenters(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDataCenterServiceChannel : XbapClient.DataCenterServiceReference.IDataCenterService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetDataCentersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetDataCentersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public XbapClient.DataCenterServiceReference.DataCenter[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((XbapClient.DataCenterServiceReference.DataCenter[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DataCenterServiceClient : System.ServiceModel.ClientBase<XbapClient.DataCenterServiceReference.IDataCenterService>, XbapClient.DataCenterServiceReference.IDataCenterService {
        
        private BeginOperationDelegate onBeginGetDataCentersDelegate;
        
        private EndOperationDelegate onEndGetDataCentersDelegate;
        
        private System.Threading.SendOrPostCallback onGetDataCentersCompletedDelegate;
        
        public DataCenterServiceClient() {
        }
        
        public DataCenterServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DataCenterServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataCenterServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataCenterServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<GetDataCentersCompletedEventArgs> GetDataCentersCompleted;
        
        public XbapClient.DataCenterServiceReference.DataCenter[] GetDataCenters() {
            return base.Channel.GetDataCenters();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetDataCenters(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetDataCenters(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public XbapClient.DataCenterServiceReference.DataCenter[] EndGetDataCenters(System.IAsyncResult result) {
            return base.Channel.EndGetDataCenters(result);
        }
        
        private System.IAsyncResult OnBeginGetDataCenters(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetDataCenters(callback, asyncState);
        }
        
        private object[] OnEndGetDataCenters(System.IAsyncResult result) {
            XbapClient.DataCenterServiceReference.DataCenter[] retVal = this.EndGetDataCenters(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetDataCentersCompleted(object state) {
            if ((this.GetDataCentersCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetDataCentersCompleted(this, new GetDataCentersCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetDataCentersAsync() {
            this.GetDataCentersAsync(null);
        }
        
        public void GetDataCentersAsync(object userState) {
            if ((this.onBeginGetDataCentersDelegate == null)) {
                this.onBeginGetDataCentersDelegate = new BeginOperationDelegate(this.OnBeginGetDataCenters);
            }
            if ((this.onEndGetDataCentersDelegate == null)) {
                this.onEndGetDataCentersDelegate = new EndOperationDelegate(this.OnEndGetDataCenters);
            }
            if ((this.onGetDataCentersCompletedDelegate == null)) {
                this.onGetDataCentersCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetDataCentersCompleted);
            }
            base.InvokeAsync(this.onBeginGetDataCentersDelegate, null, this.onEndGetDataCentersDelegate, this.onGetDataCentersCompletedDelegate, userState);
        }
    }
}