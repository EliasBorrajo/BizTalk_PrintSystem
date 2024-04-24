namespace BizTalkPrintSystem.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkPrintSystem.Schemas.Auth", typeof(global::BizTalkPrintSystem.Schemas.Auth))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkPrintSystem.Schemas.AuthResult", typeof(global::BizTalkPrintSystem.Schemas.AuthResult))]
    public sealed class Auth_TO_AuthResult : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://BizTalkPrintSystem.Schemas.auth"" xmlns:ns0=""http://BizTalkPrintSystem.Schemas.AuthResult"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Auth"" />
  </xsl:template>
  <xsl:template match=""/s0:Auth"">
    <ns0:AuthResponse>
      <username>
        <xsl:value-of select=""username/text()"" />
      </username>
      <xsl:variable name=""var:v1"" select=""userCSharp:RandomTrueFalse()"" />
      <result>
        <xsl:value-of select=""$var:v1"" />
      </result>
    </ns0:AuthResponse>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string RandomTrueFalse()
{
    Random rnd = new Random();
    return rnd.NextDouble() < 0.7 ? ""true"" : ""false"";
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BizTalkPrintSystem.Schemas.Auth";
        
        private const global::BizTalkPrintSystem.Schemas.Auth _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BizTalkPrintSystem.Schemas.AuthResult";
        
        private const global::BizTalkPrintSystem.Schemas.AuthResult _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"BizTalkPrintSystem.Schemas.Auth";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BizTalkPrintSystem.Schemas.AuthResult";
                return _TrgSchemas;
            }
        }
    }
}
