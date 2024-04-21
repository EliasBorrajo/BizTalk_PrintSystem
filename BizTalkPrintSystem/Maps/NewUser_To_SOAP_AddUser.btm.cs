namespace BizTalkPrintSystem.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkPrintSystem.Schemas.NewUser", typeof(global::BizTalkPrintSystem.Schemas.NewUser))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkPrintSystem.Schemas.SOAP_AddUser", typeof(global::BizTalkPrintSystem.Schemas.SOAP_AddUser))]
    public sealed class NewUser_To_SOAP_AddUser : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var"" version=""1.0"" xmlns:ns0=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:tem=""http://tempuri.org/"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/NewUser"" />
  </xsl:template>
  <xsl:template match=""/NewUser"">
    <ns0:Envelope>
      <ns0:Body>
        <tem:AddUser>
          <tem:Username>
            <xsl:value-of select=""Username/text()"" />
          </tem:Username>
          <tem:CardID>
            <xsl:value-of select=""CardID/text()"" />
          </tem:CardID>
        </tem:AddUser>
      </ns0:Body>
    </ns0:Envelope>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BizTalkPrintSystem.Schemas.NewUser";
        
        private const global::BizTalkPrintSystem.Schemas.NewUser _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BizTalkPrintSystem.Schemas.SOAP_AddUser";
        
        private const global::BizTalkPrintSystem.Schemas.SOAP_AddUser _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"BizTalkPrintSystem.Schemas.SOAP_AddUser";
                return _TrgSchemas;
            }
        }
    }
}
