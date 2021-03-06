﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 
namespace CoreAngular.AdventureWorks.SqliteModel {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/sqlserver/2004/07/adventure-works/ContactInfo")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.microsoft.com/sqlserver/2004/07/adventure-works/ContactInfo", IsNullable=false)]
    public partial class AdditionalContactInfo {
        
        private telephoneNumber telephoneNumberField;
        
        private homePostalAddress homePostalAddressField;
        
        private eMail eMailField;
        
        private ContactRecord contactRecordField;
        
        private string[] textField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/sqlserver/2004/07/adventure-works/ContactTypes")]
        public telephoneNumber telephoneNumber {
            get {
                return this.telephoneNumberField;
            }
            set {
                this.telephoneNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/sqlserver/2004/07/adventure-works/ContactTypes")]
        public homePostalAddress homePostalAddress {
            get {
                return this.homePostalAddressField;
            }
            set {
                this.homePostalAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/sqlserver/2004/07/adventure-works/ContactTypes")]
        public eMail eMail {
            get {
                return this.eMailField;
            }
            set {
                this.eMailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/sqlserver/2004/07/adventure-works/ContactRecord")]
        public ContactRecord ContactRecord {
            get {
                return this.contactRecordField;
            }
            set {
                this.contactRecordField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/sqlserver/2004/07/adventure-works/ContactTypes")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.microsoft.com/sqlserver/2004/07/adventure-works/ContactTypes", IsNullable=false)]
    public partial class telephoneNumber {
        
        private string numberField;
        
        private string specialInstructionsField;
        
        /// <remarks/>
        public string number {
            get {
                return this.numberField;
            }
            set {
                this.numberField = value;
            }
        }
        
        /// <remarks/>
        public string SpecialInstructions {
            get {
                return this.specialInstructionsField;
            }
            set {
                this.specialInstructionsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/sqlserver/2004/07/adventure-works/ContactTypes")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.microsoft.com/sqlserver/2004/07/adventure-works/ContactTypes", IsNullable=false)]
    public partial class homePostalAddress {
        
        private string streetField;
        
        private string cityField;
        
        private string stateProvinceField;
        
        private uint postalCodeField;
        
        private string countryRegionField;
        
        private string specialInstructionsField;
        
        /// <remarks/>
        public string Street {
            get {
                return this.streetField;
            }
            set {
                this.streetField = value;
            }
        }
        
        /// <remarks/>
        public string City {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
            }
        }
        
        /// <remarks/>
        public string StateProvince {
            get {
                return this.stateProvinceField;
            }
            set {
                this.stateProvinceField = value;
            }
        }
        
        /// <remarks/>
        public uint PostalCode {
            get {
                return this.postalCodeField;
            }
            set {
                this.postalCodeField = value;
            }
        }
        
        /// <remarks/>
        public string CountryRegion {
            get {
                return this.countryRegionField;
            }
            set {
                this.countryRegionField = value;
            }
        }
        
        /// <remarks/>
        public string SpecialInstructions {
            get {
                return this.specialInstructionsField;
            }
            set {
                this.specialInstructionsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/sqlserver/2004/07/adventure-works/ContactTypes")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.microsoft.com/sqlserver/2004/07/adventure-works/ContactTypes", IsNullable=false)]
    public partial class eMail {
        
        private string eMailAddressField;
        
        private eMailSpecialInstructions specialInstructionsField;
        
        /// <remarks/>
        public string eMailAddress {
            get {
                return this.eMailAddressField;
            }
            set {
                this.eMailAddressField = value;
            }
        }
        
        /// <remarks/>
        public eMailSpecialInstructions SpecialInstructions {
            get {
                return this.specialInstructionsField;
            }
            set {
                this.specialInstructionsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/sqlserver/2004/07/adventure-works/ContactTypes")]
    public partial class eMailSpecialInstructions {
        
        private eMailSpecialInstructionsTelephoneNumber telephoneNumberField;
        
        private string[] textField;
        
        /// <remarks/>
        public eMailSpecialInstructionsTelephoneNumber telephoneNumber {
            get {
                return this.telephoneNumberField;
            }
            set {
                this.telephoneNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/sqlserver/2004/07/adventure-works/ContactTypes")]
    public partial class eMailSpecialInstructionsTelephoneNumber {
        
        private string numberField;
        
        /// <remarks/>
        public string number {
            get {
                return this.numberField;
            }
            set {
                this.numberField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/sqlserver/2004/07/adventure-works/ContactRecord")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.microsoft.com/sqlserver/2004/07/adventure-works/ContactRecord", IsNullable=false)]
    public partial class ContactRecord {
        
        private System.DateTime dateField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime date {
            get {
                return this.dateField;
            }
            set {
                this.dateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
}
