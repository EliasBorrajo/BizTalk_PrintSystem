namespace BizTalkPrintSystem.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BizTalkPrintSystem.Schemas.User",@"User")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"User"})]
    public sealed class User : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BizTalkPrintSystem.Schemas.User"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://BizTalkPrintSystem.Schemas.User"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""User"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Username"" type=""xs:string"" />
        <xs:element name=""Quota"" type=""xs:int"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public User() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "User";
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
