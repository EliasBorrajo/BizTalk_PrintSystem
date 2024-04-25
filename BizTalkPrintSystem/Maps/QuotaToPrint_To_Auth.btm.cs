namespace BizTalkPrintSystem.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkPrintSystem.Schemas.QuotaToPrint", typeof(global::BizTalkPrintSystem.Schemas.QuotaToPrint))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkPrintSystem.Schemas.Auth", typeof(global::BizTalkPrintSystem.Schemas.Auth))]
    public sealed class QuotaToPrint_To_Auth : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://BizTalkPrintSystem.Schemas.auth"" xmlns:s0=""http://BizTalkPrintSystem.Schemas.quotaToPrint"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Print"" />
  </xsl:template>
  <xsl:template match=""/s0:Print"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot; &quot;)"" />
    <ns0:Auth>
      <username>
        <xsl:value-of select=""Username/text()"" />
      </username>
      <password>
        <xsl:value-of select=""Password/text()"" />
      </password>
      <CorrelationId>
        <xsl:value-of select=""$var:v1"" />
      </CorrelationId>
    </ns0:Auth>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BizTalkPrintSystem.Schemas.QuotaToPrint";
        
        private const global::BizTalkPrintSystem.Schemas.QuotaToPrint _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BizTalkPrintSystem.Schemas.Auth";
        
        private const global::BizTalkPrintSystem.Schemas.Auth _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"BizTalkPrintSystem.Schemas.Auth";
                return _TrgSchemas;
            }
        }
    }
}
