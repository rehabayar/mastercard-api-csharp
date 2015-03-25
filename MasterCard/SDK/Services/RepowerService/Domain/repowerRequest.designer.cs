// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.37595
//    <NameSpace>Repower</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net40</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace MasterCard.SDK.Services.RepowerService.Domain
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class RepowerRequest
    {

        private string transactionReferenceField;

        private long cardNumberField;

        private RepowerRequestTransactionAmount transactionAmountField;

        private string localDateField;

        private string localTimeField;

        private string channelField;

        private string iCAField;

        private long processorIdField;

        private int routingAndTransitNumberField;

        private short merchantTypeField;

        private RepowerRequestCardAcceptor cardAcceptorField;

        public RepowerRequest()
        {
            this.cardAcceptorField = new RepowerRequestCardAcceptor();
            this.transactionAmountField = new RepowerRequestTransactionAmount();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string TransactionReference
        {
            get
            {
                return this.transactionReferenceField;
            }
            set
            {
                this.transactionReferenceField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public long CardNumber
        {
            get
            {
                return this.cardNumberField;
            }
            set
            {
                this.cardNumberField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public RepowerRequestTransactionAmount TransactionAmount
        {
            get
            {
                return this.transactionAmountField;
            }
            set
            {
                this.transactionAmountField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string LocalDate
        {
            get
            {
                return this.localDateField;
            }
            set
            {
                this.localDateField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string LocalTime
        {
            get
            {
                return this.localTimeField;
            }
            set
            {
                this.localTimeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string Channel
        {
            get
            {
                return this.channelField;
            }
            set
            {
                this.channelField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string ICA
        {
            get
            {
                return this.iCAField;
            }
            set
            {
                this.iCAField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public long ProcessorId
        {
            get
            {
                return this.processorIdField;
            }
            set
            {
                this.processorIdField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public int RoutingAndTransitNumber
        {
            get
            {
                return this.routingAndTransitNumberField;
            }
            set
            {
                this.routingAndTransitNumberField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public short MerchantType
        {
            get
            {
                return this.merchantTypeField;
            }
            set
            {
                this.merchantTypeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public RepowerRequestCardAcceptor CardAcceptor
        {
            get
            {
                return this.cardAcceptorField;
            }
            set
            {
                this.cardAcceptorField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RepowerRequestTransactionAmount
    {

        private long valueField;

        private string currencyField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public long Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RepowerRequestCardAcceptor
    {

        private string nameField;

        private string cityField;

        private string stateField;

        private string postalCodeField;

        private string countryField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string State
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string PostalCode
        {
            get
            {
                return this.postalCodeField;
            }
            set
            {
                this.postalCodeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }
    }
}