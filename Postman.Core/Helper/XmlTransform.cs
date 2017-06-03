using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace Postman.Core.Helper
{
    public static class XmlTransform
    {
        
        private const string RUTA_XSL_MENSAJE_CUERPO = "~/App_Include/XSL/EmailPlantilla/MensajeCuerpo.xslt";

        public const string Ampersand = "&amp;";
        public const string Lsaquo = "&lt;";//single left-pointing angle quotation mark
        public const string Rsaquo = "&gt;";//single right-pointing angle quotation mark
        public const string Nbsp = "&#160;";
        public const string XSL_DEFINICION_ABRIR = @"<?xml version=""1.0"" encoding=""utf-8""?><xsl:stylesheet version=""1.0"" xmlns:xsl=""http://www.w3.org/1999/XSL/Transform""><xsl:output method=""html""/><xsl:template match=""/"">";
        public const string XSL_DEFINICION_CERRAR = @"</xsl:template></xsl:stylesheet>";
        public const string XSL_TAGS_URL = "LINK,LINK_DOCUMENTO,URL_REPORTE_CONSOLIDADO";

        /// <summary>
        /// Enumeracion para obtener los nombres de los parametros que se deben enviar en una transformacion de plantillas de mensajes
        /// </summary>
        public enum ParamsXSLPlantillaEnum
        {
            URL_ROOT,
            URL_LINK_TRACKING,
            URL_IMG_TRACKING,
            PARAM_KEY,
            URL_LINK_PREF
        }

        /// <summary>
        /// Realiza la transformacion de un xml aplicandole un xsl
        /// </summary>
        /// <param name="xml">cadena xml a transformar</param>
        /// <param name="xsl">cadena xsl que se aplica al xml</param>
        /// <param name="Arguments">parametros del xsl</param>
        /// <returns>string resultado de la transformacion</returns>
        public static string Transform(string xml, string xsl, Dictionary<string, string> Arguments)
        {
            //the outputs
            string result = "";

            try
            {
                //read XML
                TextReader txtReader4Xml = new StringReader(xml);
                XmlTextReader xmlReader4Xml = new XmlTextReader(txtReader4Xml);
                XPathDocument xPathDocument = new XPathDocument(xmlReader4Xml);

                //read XSLT
                TextReader txtReader4Xsl = new StringReader(xsl);
                XmlTextReader xmlReader4Xsl = new XmlTextReader(txtReader4Xsl);
                XslCompiledTransform xslt = new XslCompiledTransform();

                xslt.Load(xmlReader4Xsl);

                //create the output stream
                StringBuilder sb = new StringBuilder();
                TextWriter tw = new StringWriter(sb);

                XsltArgumentList args = new XsltArgumentList();
                if (Arguments != null)
                {
                    foreach (KeyValuePair<string, string> item in Arguments)
                    {
                        if (item.Value != null)
                        {
                            args.AddParam(item.Key, "", item.Value);
                        }
                    }
                }

                xslt.Transform(xPathDocument, args, tw);

                tw.Close();

                //get result
                result = sb.ToString();
            }
            // error handling
            catch (XsltException e) { throw DetailedException(e.LineNumber, e.LinePosition, e.InnerException, e.Message, xsl); }
            catch (XmlException e) { throw DetailedException(e.LineNumber, e.LinePosition, e.InnerException, e.Message, xsl); }
            catch (XPathException e) { throw DetailedException(0, 0, e.InnerException, e.Message, xsl); }

            return result;
        }

        /// <summary>
        /// Realiza la transformacion de un xml aplicandole un xsl
        /// </summary>
        /// <param name="Arguments">parametros del xsl</param>
        /// <param name="xml">cadena xml a transformar</param>
        /// <param name="xslUrl">Url donde esta alojado el archivo xsl</param>
        /// <returns>string resultado de la transformacion</returns>
        public static string Transform(Dictionary<string, string> Arguments, string xml, string xslUrl)
        {
            //the outputs
            string result = "";

            try
            {
                //read XML
                TextReader txtReader4Xml = new StringReader(xml);
                XmlTextReader xmlReader4Xml = new XmlTextReader(txtReader4Xml);
                XPathDocument xPathDocument = new XPathDocument(xmlReader4Xml);

                using (XmlTextReader xmlReader4Xsl = new XmlTextReader(xslUrl))
                {
                    XslCompiledTransform xslt = new XslCompiledTransform();

                    xslt.Load(xmlReader4Xsl);
                    //create the output stream
                    StringBuilder sb = new StringBuilder();
                    TextWriter tw = new StringWriter(sb);

                    XsltArgumentList args = new XsltArgumentList();
                    if (Arguments != null)
                    {
                        foreach (KeyValuePair<string, string> item in Arguments)
                        {
                            if (item.Value != null)
                            {
                                args.AddParam(item.Key, "", item.Value);
                            }
                        }
                    }

                    xslt.Transform(xPathDocument, args, tw);

                    tw.Close();
                    xmlReader4Xml.Close();
                    txtReader4Xml.Close();

                    //get result
                    result = sb.ToString();
                }
            }
            // error handling
            catch (XsltException e) { throw DetailedException(e.LineNumber, e.LinePosition, e.InnerException, e.Message, xslUrl); }
            catch (XmlException e) { throw DetailedException(e.LineNumber, e.LinePosition, e.InnerException, e.Message, xslUrl); }
            catch (XPathException e) { throw DetailedException(0, 0, e.InnerException, e.Message, xslUrl); }

            return result;
        }

        /// <summary>
        /// Helper del metodo Transform encargado de generar una exception de transformacion incluyendo la linea y posicion del error en el xsl
        /// </summary>
        /// <param name="LineNumber">Numero de la linea donde ocurrio el error</param>
        /// <param name="LinePosition">Posicion dentro de la linea donde ocurrio el error</param>
        /// <param name="InnerException">objeto para obtener el mensaje de error</param>
        /// <param name="Message">Mensaje de error</param>
        /// <param name="XslPath">Ruta del xsl</param>
        /// <returns></returns>
        private static Exception DetailedException(int LineNumber, int LinePosition, Exception InnerException, string Message, string XslPath)
        {
            return new Exception(string.Format("[Ln {0}, Col {1}] {2}\n{3}",
                                    LineNumber, LinePosition,
                                    InnerException != null ? InnerException.Message : Message,
                                    XslPath));
        }

        /// <summary>
        /// Arma una XSL a partir de las XSL de la plantilla y de su plantilla master en caso de tenerla
        /// </summary>
        /// <param name="xslPlantilla">XSL de la plantilla</param>
        /// <param name="xslMaster">XSL de la plantilla master</param>
        /// <returns>XSL completo</returns>
        public static string BuildXSL(string xslPlantilla, string xslMaster, bool bAddDefinition = false, String contentTemplate = "{CONTENT_TEMPLATE}")
        {
            string plantilla;

            // une la plantilla con la plantilla master en de que esta exista
            if (!string.IsNullOrEmpty(xslMaster))
            {
                plantilla = xslMaster.Replace(contentTemplate, xslPlantilla);
            }
            else
            {
                plantilla = xslPlantilla;
            }

            // agrega una definicion basica para que la plantilla se pueda usar (util cuando se quiere visualizar sin aplicar la master)
            if (bAddDefinition)
            {
                plantilla = string.Format("{0}{1}{2}", XSL_DEFINICION_ABRIR, plantilla, XSL_DEFINICION_CERRAR);
            }

            return plantilla;
        }

        

        /// <summary>
        /// Convierte los caracteres especiales xml a sus equivalentes naturales , por ejemplo (&amp;) = &
        /// </summary>
        /// <param name="data">Xml String</param>
        /// <returns>String convertida</returns>
        public static string DecodeString(string data)
        {
            data = data.Replace(Lsaquo, "<");
            data = data.Replace(Rsaquo, ">");
            data = data.Replace(Ampersand, "&");

            return data;
        }

        public static string EncodeString(string data)
        {
            data = data.Replace("&", Ampersand);
            data = data.Replace("<", Lsaquo);
            data = data.Replace(">", Rsaquo);

            return data;
        }

        /// <summary>
        /// Formats the provided XML so it's indented and humanly-readable.
        /// </summary>
        /// <param name="inputXml">The input XML to format.</param>
        /// <returns></returns>
        public static string FormatXml(string inputXml)
        {
            try
            {
                XmlDocument document = new XmlDocument();
                document.Load(new StringReader(inputXml));

                StringBuilder builder = new StringBuilder();
                using (XmlTextWriter writer = new XmlTextWriter(new StringWriter(builder)))
                {
                    writer.Formatting = Formatting.Indented;
                    document.Save(writer);
                }

                return builder.ToString();
            }
            catch
            {
                return inputXml;
            }
        }

        public static bool ValidarXmlConEsquema(string Xml, string Xsd, ref string Errores)
        {
            bool bIsValid = false;

            XmlReader xmlreader = new XmlTextReader(new MemoryStream(ASCIIEncoding.Default.GetBytes(Xsd)));
            StringCollection xml_errores = new StringCollection();
            bIsValid = new XmlSchemaValidator().ValidXmlDoc(Xml, "", xmlreader, ref xml_errores);
            if (xml_errores.Count > 0)
            {
                string errores = string.Empty;
                foreach (string s in xml_errores)
                { errores = string.Concat(errores, s, "  "); }
                Errores = errores.Trim();
            }

            return bIsValid;
        }

        /// <summary>
        /// Devuelve el innertext de un xpath
        /// </summary>
        /// <param name="xmlDoc"></param>
        /// <param name="FindXPathElements"></param>
        /// <returns></returns>
        public static string SelectXmlNode(XmlDocument xmlDoc, params string[] FindXPathElements)
        {
            foreach (string XPathElement in FindXPathElements)
            {
                if (xmlDoc.DocumentElement.SelectSingleNode(XPathElement) != null)
                { return xmlDoc.DocumentElement.SelectSingleNode(XPathElement).InnerText; }
            }
            return null;
        }

    }
}
