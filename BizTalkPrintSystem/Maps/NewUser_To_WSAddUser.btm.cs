namespace BizTalkPrintSystem {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkPrintSystem.Schemas.NewUser", typeof(global::BizTalkPrintSystem.Schemas.NewUser))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkPrintSystem.Schemas.ServiceAccount_tempuri_org+AddUser", typeof(global::BizTalkPrintSystem.Schemas.ServiceAccount_tempuri_org.AddUser))]
    public sealed class NewUser_To_WSAddUser : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var"" version=""1.0"" xmlns:ns1=""http://schemas.datacontract.org/2004/07/DTO"" xmlns:ns0=""http://tempuri.org/"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/NewUser"" />
  </xsl:template>
  <xsl:template match=""/NewUser"">
    <ns0:AddUser>
      <ns0:Username>
        <xsl:value-of select=""Username/text()"" />
      </ns0:Username>
      <ns0:CardID>
        <xsl:value-of select=""CardID/text()"" />
      </ns0:CardID>
    </ns0:AddUser>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BizTalkPrintSystem.Schemas.NewUser";
        
        private const global::BizTalkPrintSystem.Schemas.NewUser _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BizTalkPrintSystem.Schemas.ServiceAccount_tempuri_org+AddUser";
        
        private const global::BizTalkPrintSystem.Schemas.ServiceAccount_tempuri_org.AddUser _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"BizTalkPrintSystem.Schemas.NewUser";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BizTalkPrintSystem.Schemas.ServiceAccount_tempuri_org+AddUser";
                return _TrgSchemas;
            }
        }
    }
}
