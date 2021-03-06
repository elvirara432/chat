﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18408
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace formChat.referenciachat {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="referenciachat.CHATSoap")]
    public interface CHATSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento mensaje del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/chat", ReplyAction="*")]
        formChat.referenciachat.chatResponse chat(formChat.referenciachat.chatRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/chat", ReplyAction="*")]
        System.Threading.Tasks.Task<formChat.referenciachat.chatResponse> chatAsync(formChat.referenciachat.chatRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class chatRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="chat", Namespace="http://tempuri.org/", Order=0)]
        public formChat.referenciachat.chatRequestBody Body;
        
        public chatRequest() {
        }
        
        public chatRequest(formChat.referenciachat.chatRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class chatRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string mensaje;
        
        public chatRequestBody() {
        }
        
        public chatRequestBody(string mensaje) {
            this.mensaje = mensaje;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class chatResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="chatResponse", Namespace="http://tempuri.org/", Order=0)]
        public formChat.referenciachat.chatResponseBody Body;
        
        public chatResponse() {
        }
        
        public chatResponse(formChat.referenciachat.chatResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class chatResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string chatResult;
        
        public chatResponseBody() {
        }
        
        public chatResponseBody(string chatResult) {
            this.chatResult = chatResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CHATSoapChannel : formChat.referenciachat.CHATSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CHATSoapClient : System.ServiceModel.ClientBase<formChat.referenciachat.CHATSoap>, formChat.referenciachat.CHATSoap {
        
        public CHATSoapClient() {
        }
        
        public CHATSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CHATSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CHATSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CHATSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        formChat.referenciachat.chatResponse formChat.referenciachat.CHATSoap.chat(formChat.referenciachat.chatRequest request) {
            return base.Channel.chat(request);
        }
        
        public string chat(string mensaje) {
            formChat.referenciachat.chatRequest inValue = new formChat.referenciachat.chatRequest();
            inValue.Body = new formChat.referenciachat.chatRequestBody();
            inValue.Body.mensaje = mensaje;
            formChat.referenciachat.chatResponse retVal = ((formChat.referenciachat.CHATSoap)(this)).chat(inValue);
            return retVal.Body.chatResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<formChat.referenciachat.chatResponse> formChat.referenciachat.CHATSoap.chatAsync(formChat.referenciachat.chatRequest request) {
            return base.Channel.chatAsync(request);
        }
        
        public System.Threading.Tasks.Task<formChat.referenciachat.chatResponse> chatAsync(string mensaje) {
            formChat.referenciachat.chatRequest inValue = new formChat.referenciachat.chatRequest();
            inValue.Body = new formChat.referenciachat.chatRequestBody();
            inValue.Body.mensaje = mensaje;
            return ((formChat.referenciachat.CHATSoap)(this)).chatAsync(inValue);
        }
    }
}
