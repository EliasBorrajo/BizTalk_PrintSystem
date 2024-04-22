namespace BizTalkPrintSystem.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"AddAmountByUsername", @"AddAmountByUsernameResponse", @"AddAmountByUID", @"AddAmountByUIDResponse", @"AddUser", @"AddUserResponse", @"dimAmount", @"dimAmountResponse"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkPrintSystem.Schemas.ServiceAccount_schemas_datacontract_org_2004_07_DTO", typeof(global::BizTalkPrintSystem.Schemas.ServiceAccount_schemas_datacontract_org_2004_07_DTO))]
    public sealed class ServiceAccount_tempuri_org : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://tempuri.org/"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""BizTalkPrintSystem.Schemas.ServiceAccount_schemas_datacontract_org_2004_07_DTO"" namespace=""http://schemas.datacontract.org/2004/07/DTO"" />
  <xs:annotation>
    <xs:appinfo>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""http://schemas.datacontract.org/2004/07/DTO"" />
      </references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""AddAmountByUsername"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""Username"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""QuotaCHF"" type=""xs:double"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AddAmountByUsernameResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q1=""http://schemas.datacontract.org/2004/07/DTO"" minOccurs=""0"" name=""AddAmountByUsernameResult"" nillable=""true"" type=""q1:Account"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AddAmountByUID"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""UID"" type=""xs:int"" />
        <xs:element minOccurs=""0"" name=""QuotaCHF"" type=""xs:double"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AddAmountByUIDResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q2=""http://schemas.datacontract.org/2004/07/DTO"" minOccurs=""0"" name=""AddAmountByUIDResult"" nillable=""true"" type=""q2:Account"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AddUser"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""Username"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""CardID"" type=""xs:int"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AddUserResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q3=""http://schemas.datacontract.org/2004/07/DTO"" minOccurs=""0"" name=""AddUserResult"" nillable=""true"" type=""q3:Account"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""dimAmount"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""Username"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""QuotaToPrint"" type=""xs:int"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""dimAmountResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q4=""http://schemas.datacontract.org/2004/07/DTO"" minOccurs=""0"" name=""dimAmountResult"" nillable=""true"" type=""q4:Account"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public ServiceAccount_tempuri_org() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [8];
                _RootElements[0] = "AddAmountByUsername";
                _RootElements[1] = "AddAmountByUsernameResponse";
                _RootElements[2] = "AddAmountByUID";
                _RootElements[3] = "AddAmountByUIDResponse";
                _RootElements[4] = "AddUser";
                _RootElements[5] = "AddUserResponse";
                _RootElements[6] = "dimAmount";
                _RootElements[7] = "dimAmountResponse";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
        
        [Schema(@"http://tempuri.org/",@"AddAmountByUsername")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AddAmountByUsername"})]
        public sealed class AddAmountByUsername : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AddAmountByUsername() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AddAmountByUsername";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://tempuri.org/",@"AddAmountByUsernameResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AddAmountByUsernameResponse"})]
        public sealed class AddAmountByUsernameResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AddAmountByUsernameResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AddAmountByUsernameResponse";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://tempuri.org/",@"AddAmountByUID")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AddAmountByUID"})]
        public sealed class AddAmountByUID : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AddAmountByUID() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AddAmountByUID";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://tempuri.org/",@"AddAmountByUIDResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AddAmountByUIDResponse"})]
        public sealed class AddAmountByUIDResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AddAmountByUIDResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AddAmountByUIDResponse";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://tempuri.org/",@"AddUser")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AddUser"})]
        public sealed class AddUser : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AddUser() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AddUser";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://tempuri.org/",@"AddUserResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AddUserResponse"})]
        public sealed class AddUserResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AddUserResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AddUserResponse";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://tempuri.org/",@"dimAmount")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"dimAmount"})]
        public sealed class dimAmount : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public dimAmount() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "dimAmount";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://tempuri.org/",@"dimAmountResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"dimAmountResponse"})]
        public sealed class dimAmountResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public dimAmountResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "dimAmountResponse";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
    }
}
