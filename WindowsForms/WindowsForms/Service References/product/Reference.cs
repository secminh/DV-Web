﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsForms.product {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/WcfService")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DetailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> PriceField;
        
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
        public string Category {
            get {
                return this.CategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryField, value) != true)) {
                    this.CategoryField = value;
                    this.RaisePropertyChanged("Category");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Detail {
            get {
                return this.DetailField;
            }
            set {
                if ((object.ReferenceEquals(this.DetailField, value) != true)) {
                    this.DetailField = value;
                    this.RaisePropertyChanged("Detail");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Image {
            get {
                return this.ImageField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageField, value) != true)) {
                    this.ImageField = value;
                    this.RaisePropertyChanged("Image");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="product.IProductservice")]
    public interface IProductservice {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductservice/GetAll", ReplyAction="http://tempuri.org/IProductservice/GetAllResponse")]
        WindowsForms.product.Product[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductservice/GetAll", ReplyAction="http://tempuri.org/IProductservice/GetAllResponse")]
        System.Threading.Tasks.Task<WindowsForms.product.Product[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductservice/GetByID", ReplyAction="http://tempuri.org/IProductservice/GetByIDResponse")]
        WindowsForms.product.Product GetByID(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductservice/GetByID", ReplyAction="http://tempuri.org/IProductservice/GetByIDResponse")]
        System.Threading.Tasks.Task<WindowsForms.product.Product> GetByIDAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductservice/AddProduct", ReplyAction="http://tempuri.org/IProductservice/AddProductResponse")]
        void AddProduct(WindowsForms.product.Product p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductservice/AddProduct", ReplyAction="http://tempuri.org/IProductservice/AddProductResponse")]
        System.Threading.Tasks.Task AddProductAsync(WindowsForms.product.Product p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductservice/UpdateProduct", ReplyAction="http://tempuri.org/IProductservice/UpdateProductResponse")]
        void UpdateProduct(WindowsForms.product.Product p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductservice/UpdateProduct", ReplyAction="http://tempuri.org/IProductservice/UpdateProductResponse")]
        System.Threading.Tasks.Task UpdateProductAsync(WindowsForms.product.Product p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductservice/DeleteProduct", ReplyAction="http://tempuri.org/IProductservice/DeleteProductResponse")]
        void DeleteProduct(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductservice/DeleteProduct", ReplyAction="http://tempuri.org/IProductservice/DeleteProductResponse")]
        System.Threading.Tasks.Task DeleteProductAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductserviceChannel : WindowsForms.product.IProductservice, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductserviceClient : System.ServiceModel.ClientBase<WindowsForms.product.IProductservice>, WindowsForms.product.IProductservice {
        
        public ProductserviceClient() {
        }
        
        public ProductserviceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductserviceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductserviceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductserviceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WindowsForms.product.Product[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<WindowsForms.product.Product[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public WindowsForms.product.Product GetByID(int id) {
            return base.Channel.GetByID(id);
        }
        
        public System.Threading.Tasks.Task<WindowsForms.product.Product> GetByIDAsync(int id) {
            return base.Channel.GetByIDAsync(id);
        }
        
        public void AddProduct(WindowsForms.product.Product p) {
            base.Channel.AddProduct(p);
        }
        
        public System.Threading.Tasks.Task AddProductAsync(WindowsForms.product.Product p) {
            return base.Channel.AddProductAsync(p);
        }
        
        public void UpdateProduct(WindowsForms.product.Product p) {
            base.Channel.UpdateProduct(p);
        }
        
        public System.Threading.Tasks.Task UpdateProductAsync(WindowsForms.product.Product p) {
            return base.Channel.UpdateProductAsync(p);
        }
        
        public void DeleteProduct(int id) {
            base.Channel.DeleteProduct(id);
        }
        
        public System.Threading.Tasks.Task DeleteProductAsync(int id) {
            return base.Channel.DeleteProductAsync(id);
        }
    }
}