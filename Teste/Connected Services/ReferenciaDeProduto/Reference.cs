﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Teste.ReferenciaDeProduto {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProdutoViewModel", Namespace="http://schemas.datacontract.org/2004/07/GerenciarProduto.Modelo")]
    [System.SerializableAttribute()]
    public partial class ProdutoViewModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BandeiraField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategoriaProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImagemProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PrecoProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuantidadeProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idProdutoField;
        
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
        public string Bandeira {
            get {
                return this.BandeiraField;
            }
            set {
                if ((object.ReferenceEquals(this.BandeiraField, value) != true)) {
                    this.BandeiraField = value;
                    this.RaisePropertyChanged("Bandeira");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CategoriaProduto {
            get {
                return this.CategoriaProdutoField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoriaProdutoField, value) != true)) {
                    this.CategoriaProdutoField = value;
                    this.RaisePropertyChanged("CategoriaProduto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ImagemProduto {
            get {
                return this.ImagemProdutoField;
            }
            set {
                if ((object.ReferenceEquals(this.ImagemProdutoField, value) != true)) {
                    this.ImagemProdutoField = value;
                    this.RaisePropertyChanged("ImagemProduto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NomeProduto {
            get {
                return this.NomeProdutoField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeProdutoField, value) != true)) {
                    this.NomeProdutoField = value;
                    this.RaisePropertyChanged("NomeProduto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PrecoProduto {
            get {
                return this.PrecoProdutoField;
            }
            set {
                if ((object.ReferenceEquals(this.PrecoProdutoField, value) != true)) {
                    this.PrecoProdutoField = value;
                    this.RaisePropertyChanged("PrecoProduto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int QuantidadeProduto {
            get {
                return this.QuantidadeProdutoField;
            }
            set {
                if ((this.QuantidadeProdutoField.Equals(value) != true)) {
                    this.QuantidadeProdutoField = value;
                    this.RaisePropertyChanged("QuantidadeProduto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idProduto {
            get {
                return this.idProdutoField;
            }
            set {
                if ((this.idProdutoField.Equals(value) != true)) {
                    this.idProdutoField = value;
                    this.RaisePropertyChanged("idProduto");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Produto", Namespace="http://schemas.datacontract.org/2004/07/DomainLoja")]
    [System.SerializableAttribute()]
    public partial class Produto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategoriaProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImagemProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PrecoProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuantidadeProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Teste.ReferenciaDeProduto.Pedido pedidoField;
        
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
        public string CategoriaProduto {
            get {
                return this.CategoriaProdutoField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoriaProdutoField, value) != true)) {
                    this.CategoriaProdutoField = value;
                    this.RaisePropertyChanged("CategoriaProduto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ImagemProduto {
            get {
                return this.ImagemProdutoField;
            }
            set {
                if ((object.ReferenceEquals(this.ImagemProdutoField, value) != true)) {
                    this.ImagemProdutoField = value;
                    this.RaisePropertyChanged("ImagemProduto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NomeProduto {
            get {
                return this.NomeProdutoField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeProdutoField, value) != true)) {
                    this.NomeProdutoField = value;
                    this.RaisePropertyChanged("NomeProduto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PrecoProduto {
            get {
                return this.PrecoProdutoField;
            }
            set {
                if ((object.ReferenceEquals(this.PrecoProdutoField, value) != true)) {
                    this.PrecoProdutoField = value;
                    this.RaisePropertyChanged("PrecoProduto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int QuantidadeProduto {
            get {
                return this.QuantidadeProdutoField;
            }
            set {
                if ((this.QuantidadeProdutoField.Equals(value) != true)) {
                    this.QuantidadeProdutoField = value;
                    this.RaisePropertyChanged("QuantidadeProduto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idProduto {
            get {
                return this.idProdutoField;
            }
            set {
                if ((this.idProdutoField.Equals(value) != true)) {
                    this.idProdutoField = value;
                    this.RaisePropertyChanged("idProduto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Teste.ReferenciaDeProduto.Pedido pedido {
            get {
                return this.pedidoField;
            }
            set {
                if ((object.ReferenceEquals(this.pedidoField, value) != true)) {
                    this.pedidoField = value;
                    this.RaisePropertyChanged("pedido");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Pedido", Namespace="http://schemas.datacontract.org/2004/07/DomainLoja")]
    [System.SerializableAttribute()]
    public partial class Pedido : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool PedidoEnviadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool PedidoSalvoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Teste.ReferenciaDeProduto.Produto[] ProdutosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idPedidoField;
        
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
        public bool PedidoEnviado {
            get {
                return this.PedidoEnviadoField;
            }
            set {
                if ((this.PedidoEnviadoField.Equals(value) != true)) {
                    this.PedidoEnviadoField = value;
                    this.RaisePropertyChanged("PedidoEnviado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool PedidoSalvo {
            get {
                return this.PedidoSalvoField;
            }
            set {
                if ((this.PedidoSalvoField.Equals(value) != true)) {
                    this.PedidoSalvoField = value;
                    this.RaisePropertyChanged("PedidoSalvo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Teste.ReferenciaDeProduto.Produto[] Produtos {
            get {
                return this.ProdutosField;
            }
            set {
                if ((object.ReferenceEquals(this.ProdutosField, value) != true)) {
                    this.ProdutosField = value;
                    this.RaisePropertyChanged("Produtos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idPedido {
            get {
                return this.idPedidoField;
            }
            set {
                if ((this.idPedidoField.Equals(value) != true)) {
                    this.idPedidoField = value;
                    this.RaisePropertyChanged("idPedido");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://localhost:50115/v1", ConfigurationName="ReferenciaDeProduto.Produtos")]
    public interface Produtos {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:50115/v1/Produtos/AdicionarNaFila", ReplyAction="http://localhost:50115/v1/Produtos/AdicionarNaFilaResponse")]
        bool AdicionarNaFila(Teste.ReferenciaDeProduto.ProdutoViewModel produto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:50115/v1/Produtos/AdicionarNaFila", ReplyAction="http://localhost:50115/v1/Produtos/AdicionarNaFilaResponse")]
        System.Threading.Tasks.Task<bool> AdicionarNaFilaAsync(Teste.ReferenciaDeProduto.ProdutoViewModel produto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:50115/v1/Produtos/ProcessarFila", ReplyAction="http://localhost:50115/v1/Produtos/ProcessarFilaResponse")]
        bool ProcessarFila();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:50115/v1/Produtos/ProcessarFila", ReplyAction="http://localhost:50115/v1/Produtos/ProcessarFilaResponse")]
        System.Threading.Tasks.Task<bool> ProcessarFilaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:50115/v1/Produtos/ListarProduto", ReplyAction="http://localhost:50115/v1/Produtos/ListarProdutoResponse")]
        string ListarProduto();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:50115/v1/Produtos/ListarProduto", ReplyAction="http://localhost:50115/v1/Produtos/ListarProdutoResponse")]
        System.Threading.Tasks.Task<string> ListarProdutoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:50115/v1/Produtos/Cadastro", ReplyAction="http://localhost:50115/v1/Produtos/CadastroResponse")]
        bool Cadastro(Teste.ReferenciaDeProduto.Produto produto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:50115/v1/Produtos/Cadastro", ReplyAction="http://localhost:50115/v1/Produtos/CadastroResponse")]
        System.Threading.Tasks.Task<bool> CadastroAsync(Teste.ReferenciaDeProduto.Produto produto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:50115/v1/Produtos/Editar", ReplyAction="http://localhost:50115/v1/Produtos/EditarResponse")]
        bool Editar(Teste.ReferenciaDeProduto.Produto produto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:50115/v1/Produtos/Editar", ReplyAction="http://localhost:50115/v1/Produtos/EditarResponse")]
        System.Threading.Tasks.Task<bool> EditarAsync(Teste.ReferenciaDeProduto.Produto produto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:50115/v1/Produtos/Deletar", ReplyAction="http://localhost:50115/v1/Produtos/DeletarResponse")]
        bool Deletar(int idProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:50115/v1/Produtos/Deletar", ReplyAction="http://localhost:50115/v1/Produtos/DeletarResponse")]
        System.Threading.Tasks.Task<bool> DeletarAsync(int idProduto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ProdutosChannel : Teste.ReferenciaDeProduto.Produtos, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProdutosClient : System.ServiceModel.ClientBase<Teste.ReferenciaDeProduto.Produtos>, Teste.ReferenciaDeProduto.Produtos {
        
        public ProdutosClient() {
        }
        
        public ProdutosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProdutosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProdutosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProdutosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AdicionarNaFila(Teste.ReferenciaDeProduto.ProdutoViewModel produto) {
            return base.Channel.AdicionarNaFila(produto);
        }
        
        public System.Threading.Tasks.Task<bool> AdicionarNaFilaAsync(Teste.ReferenciaDeProduto.ProdutoViewModel produto) {
            return base.Channel.AdicionarNaFilaAsync(produto);
        }
        
        public bool ProcessarFila() {
            return base.Channel.ProcessarFila();
        }
        
        public System.Threading.Tasks.Task<bool> ProcessarFilaAsync() {
            return base.Channel.ProcessarFilaAsync();
        }
        
        public string ListarProduto() {
            return base.Channel.ListarProduto();
        }
        
        public System.Threading.Tasks.Task<string> ListarProdutoAsync() {
            return base.Channel.ListarProdutoAsync();
        }
        
        public bool Cadastro(Teste.ReferenciaDeProduto.Produto produto) {
            return base.Channel.Cadastro(produto);
        }
        
        public System.Threading.Tasks.Task<bool> CadastroAsync(Teste.ReferenciaDeProduto.Produto produto) {
            return base.Channel.CadastroAsync(produto);
        }
        
        public bool Editar(Teste.ReferenciaDeProduto.Produto produto) {
            return base.Channel.Editar(produto);
        }
        
        public System.Threading.Tasks.Task<bool> EditarAsync(Teste.ReferenciaDeProduto.Produto produto) {
            return base.Channel.EditarAsync(produto);
        }
        
        public bool Deletar(int idProduto) {
            return base.Channel.Deletar(idProduto);
        }
        
        public System.Threading.Tasks.Task<bool> DeletarAsync(int idProduto) {
            return base.Channel.DeletarAsync(idProduto);
        }
    }
}