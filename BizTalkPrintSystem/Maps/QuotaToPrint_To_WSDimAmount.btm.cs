namespace BizTalkPrintSystem.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkPrintSystem.Schemas.QuotaToPrint", typeof(global::BizTalkPrintSystem.Schemas.QuotaToPrint))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkPrintSystem.Schemas.ServiceAccount_tempuri_org+dimAmount", typeof(global::BizTalkPrintSystem.Schemas.ServiceAccount_tempuri_org.dimAmount))]
    public sealed class QuotaToPrint_To_WSDimAmount : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://tempuri.org/"" xmlns:ns1=""http://schemas.datacontract.org/2004/07/DTO"" xmlns:s0=""http://BizTalkPrintSystem.Schemas.quotaToPrint"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Print"" />
  </xsl:template>
  <xsl:template match=""/s0:Print"">
    <ns0:dimAmount>
      <ns0:Username>
        <xsl:value-of select=""Username/text()"" />
      </ns0:Username>
      <ns0:QuotaToPrint>
        <xsl:value-of select=""Quota/text()"" />
      </ns0:QuotaToPrint>
    </ns0:dimAmount>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BizTalkPrintSystem.Schemas.QuotaToPrint";
        
        private const global::BizTalkPrintSystem.Schemas.QuotaToPrint _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BizTalkPrintSystem.Schemas.ServiceAccount_tempuri_org+dimAmount";
        
        private const global::BizTalkPrintSystem.Schemas.ServiceAccount_tempuri_org.dimAmount _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"BizTalkPrintSystem.Schemas.QuotaToPrint";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BizTalkPrintSystem.Schemas.ServiceAccount_tempuri_org+dimAmount";
                return _TrgSchemas;
            }
        }
    }
}
