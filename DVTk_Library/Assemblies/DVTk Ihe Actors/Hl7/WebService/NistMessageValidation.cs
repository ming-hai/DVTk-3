﻿// ------------------------------------------------------
// DVTk - The Healthcare Validation Toolkit (www.dvtk.org)
// Copyright © 2009 DVTk
// ------------------------------------------------------
// This file is part of DVTk.
//
// DVTk is free software; you can redistribute it and/or modify it under the terms of the GNU
// Lesser General Public License as published by the Free Software Foundation; either version 3.0
// of the License, or (at your option) any later version. 
// 
// DVTk is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even
// the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU Lesser
// General Public License for more details. 
// 
// You should have received a copy of the GNU Lesser General Public License along with this
// library; if not, see <http://www.gnu.org/licenses/>

//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2032
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by wsdl, Version=1.1.4322.2032.
// 
using System.Diagnostics;
using System.Xml.Serialization;
using System;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Web.Services;

namespace Dvtk.IheActors.Hl7.WebService.Validation
{
	/// <remarks/>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Web.Services.WebServiceBindingAttribute(Name="MessageValidationSOAP11Binding", Namespace="http://MessageValidation.validation.ws.hl7.nist.gov")]
	public class MessageValidation : System.Web.Services.Protocols.SoapHttpClientProtocol 
	{

		/// <remarks/>
		public MessageValidation(System.String url)
		{
			this.Url = url + "/MessageValidation";
		}
    
		/// <remarks/>
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:setValidationContext", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
		[return: System.Xml.Serialization.XmlElementAttribute("setValidationContextResponse", Namespace="http://MessageValidation.validation.ws.hl7.nist.gov/types")]
		public setValidationContextResponse setValidationContext([System.Xml.Serialization.XmlElementAttribute("setValidationContext", Namespace="")] setValidationContext setValidationContext1) 
		{
			object[] results = this.Invoke("setValidationContext", new object[] {
																					setValidationContext1});
			return ((setValidationContextResponse)(results[0]));
		}
    
		/// <remarks/>
		public System.IAsyncResult BeginsetValidationContext(setValidationContext setValidationContext1, System.AsyncCallback callback, object asyncState) 
		{
			return this.BeginInvoke("setValidationContext", new object[] {
																			 setValidationContext1}, callback, asyncState);
		}
    
		/// <remarks/>
		public setValidationContextResponse EndsetValidationContext(System.IAsyncResult asyncResult) 
		{
			object[] results = this.EndInvoke(asyncResult);
			return ((setValidationContextResponse)(results[0]));
		}
    
		/// <remarks/>
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:getErrorDescription", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
		[return: System.Xml.Serialization.XmlElementAttribute("getErrorDescriptionResponse", Namespace="http://MessageValidation.validation.ws.hl7.nist.gov/types")]
		public getErrorDescriptionResponse getErrorDescription([System.Xml.Serialization.XmlElementAttribute("getErrorDescription", Namespace="")] getErrorDescription getErrorDescription1) 
		{
			object[] results = this.Invoke("getErrorDescription", new object[] {
																				   getErrorDescription1});
			return ((getErrorDescriptionResponse)(results[0]));
		}
    
		/// <remarks/>
		public System.IAsyncResult BegingetErrorDescription(getErrorDescription getErrorDescription1, System.AsyncCallback callback, object asyncState) 
		{
			return this.BeginInvoke("getErrorDescription", new object[] {
																			getErrorDescription1}, callback, asyncState);
		}
    
		/// <remarks/>
		public getErrorDescriptionResponse EndgetErrorDescription(System.IAsyncResult asyncResult) 
		{
			object[] results = this.EndInvoke(asyncResult);
			return ((getErrorDescriptionResponse)(results[0]));
		}
    
		/// <remarks/>
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:setMessage", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
		[return: System.Xml.Serialization.XmlElementAttribute("setMessageResponse", Namespace="http://MessageValidation.validation.ws.hl7.nist.gov/types")]
		public setMessageResponse setMessage([System.Xml.Serialization.XmlElementAttribute("setMessage", Namespace="")] setMessage setMessage1) 
		{
			object[] results = this.Invoke("setMessage", new object[] {
																		  setMessage1});
			return ((setMessageResponse)(results[0]));
		}
    
		/// <remarks/>
		public System.IAsyncResult BeginsetMessage(setMessage setMessage1, System.AsyncCallback callback, object asyncState) 
		{
			return this.BeginInvoke("setMessage", new object[] {
																   setMessage1}, callback, asyncState);
		}
    
		/// <remarks/>
		public setMessageResponse EndsetMessage(System.IAsyncResult asyncResult) 
		{
			object[] results = this.EndInvoke(asyncResult);
			return ((setMessageResponse)(results[0]));
		}
    
		/// <remarks/>
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:validate", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
		[return: System.Xml.Serialization.XmlElementAttribute("validateResponse", Namespace="http://MessageValidation.validation.ws.hl7.nist.gov/types")]
		public validateResponse validate([System.Xml.Serialization.XmlElementAttribute("validate", Namespace="")] validate validate1) 
		{
			object[] results = this.Invoke("validate", new object[] {
																		validate1});
			return ((validateResponse)(results[0]));
		}
    
		/// <remarks/>
		public System.IAsyncResult Beginvalidate(validate validate1, System.AsyncCallback callback, object asyncState) 
		{
			return this.BeginInvoke("validate", new object[] {
																 validate1}, callback, asyncState);
		}
    
		/// <remarks/>
		public validateResponse Endvalidate(System.IAsyncResult asyncResult) 
		{
			object[] results = this.EndInvoke(asyncResult);
			return ((validateResponse)(results[0]));
		}
    
		/// <remarks/>
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:getValidationReport", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
		[return: System.Xml.Serialization.XmlElementAttribute("getValidationReportResponse", Namespace="http://MessageValidation.validation.ws.hl7.nist.gov/types")]
		public getValidationReportResponse getValidationReport([System.Xml.Serialization.XmlElementAttribute("getValidationReport", Namespace="")] getValidationReport getValidationReport1) 
		{
			object[] results = this.Invoke("getValidationReport", new object[] {
																				   getValidationReport1});
			return ((getValidationReportResponse)(results[0]));
		}
    
		/// <remarks/>
		public System.IAsyncResult BegingetValidationReport(getValidationReport getValidationReport1, System.AsyncCallback callback, object asyncState) 
		{
			return this.BeginInvoke("getValidationReport", new object[] {
																			getValidationReport1}, callback, asyncState);
		}
    
		/// <remarks/>
		public getValidationReportResponse EndgetValidationReport(System.IAsyncResult asyncResult) 
		{
			object[] results = this.EndInvoke(asyncResult);
			return ((getValidationReportResponse)(results[0]));
		}
    
		/// <remarks/>
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:setProfile", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
		[return: System.Xml.Serialization.XmlElementAttribute("setProfileResponse", Namespace="http://MessageValidation.validation.ws.hl7.nist.gov/types")]
		public setProfileResponse setProfile([System.Xml.Serialization.XmlElementAttribute("setProfile", Namespace="")] setProfile setProfile1) 
		{
			object[] results = this.Invoke("setProfile", new object[] {
																		  setProfile1});
			return ((setProfileResponse)(results[0]));
		}
    
		/// <remarks/>
		public System.IAsyncResult BeginsetProfile(setProfile setProfile1, System.AsyncCallback callback, object asyncState) 
		{
			return this.BeginInvoke("setProfile", new object[] {
																   setProfile1}, callback, asyncState);
		}
    
		/// <remarks/>
		public setProfileResponse EndsetProfile(System.IAsyncResult asyncResult) 
		{
			object[] results = this.EndInvoke(asyncResult);
			return ((setProfileResponse)(results[0]));
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://MessageValidation.validation.ws.hl7.nist.gov/types")]
	public class setValidationContext 
	{
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string param0;
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://MessageValidation.validation.ws.hl7.nist.gov/types")]
	public class setProfileResponse 
	{
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public bool @return;
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://MessageValidation.validation.ws.hl7.nist.gov/types")]
	public class setProfile 
	{
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string param0;
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://MessageValidation.validation.ws.hl7.nist.gov/types")]
	public class getValidationReportResponse 
	{
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string @return;
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://MessageValidation.validation.ws.hl7.nist.gov/types")]
	public class getValidationReport 
	{
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://MessageValidation.validation.ws.hl7.nist.gov/types")]
	public class validateResponse 
	{
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public bool @return;
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://MessageValidation.validation.ws.hl7.nist.gov/types")]
	public class validate 
	{
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://MessageValidation.validation.ws.hl7.nist.gov/types")]
	public class setMessageResponse 
	{
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public bool @return;
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://MessageValidation.validation.ws.hl7.nist.gov/types")]
	public class setMessage 
	{
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string param0;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public bool param1;
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://MessageValidation.validation.ws.hl7.nist.gov/types")]
	public class getErrorDescriptionResponse 
	{
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string @return;
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://MessageValidation.validation.ws.hl7.nist.gov/types")]
	public class getErrorDescription 
	{
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://MessageValidation.validation.ws.hl7.nist.gov/types")]
	public class setValidationContextResponse 
	{
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public bool @return;
	}
}
