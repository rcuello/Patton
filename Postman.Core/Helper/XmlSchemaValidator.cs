using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace Postman.Core.Helper
{
    public class XmlSchemaValidator
    {
        private bool isValidXml = true;
        private string validationError = "";

        /// <SUMMARY>
        /// Empty Constructor.
        /// </SUMMARY>
        public XmlSchemaValidator()
        {

        }


        /// <SUMMARY>
        /// Public get/set access to the validation error.
        /// </SUMMARY>
        public String ValidationError
        {
            get
            {
                return "<VALIDATIONERROR>" + this.validationError
                       + "</VALIDATIONERROR>";
            }
            set
            {
                this.validationError = value;
            }
        }

        /// <SUMMARY>
        /// Public get access to the isValidXml attribute.
        /// </SUMMARY>
        public bool IsValidXml
        {
            get
            {
                return this.isValidXml;
            }
        }


        /// <SUMMARY>
        /// This method validates an xml string against an xml schema.
        /// </SUMMARY>
        /// <PARAM name="xml">XML string</PARAM>
        /// <PARAM name="schemaNamespace">XML Schema Namespace</PARAM>
        /// <PARAM name="schemaUri">XML Schema Uri</PARAM>
        /// <RETURNS>bool</RETURNS>
        public bool ValidXmlDoc(string xml, string schemaNamespace, string schemaUri, ref StringCollection xml_error)
        {
            try
            {
                // Is the xml string valid?
                if (xml == null || xml.Length < 1)
                {
                    return false;
                }

                StringReader srXml = new StringReader(xml);
                return ValidXmlDoc(srXml, schemaNamespace, schemaUri, ref xml_error);
            }
            catch (Exception ex)
            {
                xml_error.Add(ex.Message);
                this.ValidationError = ex.Message;
                return false;
            }
        }

        public bool ValidXmlDoc(string xml, string schemaNamespace, XmlReader schemaReader, ref StringCollection xml_error)
        {
            try
            {
                // Is the xml string valid?
                if (xml == null || xml.Length < 1)
                {
                    return false;
                }

                // Is the xsd string valid?
                if (schemaReader == null)
                {
                    return false;
                }

                StringReader srXml = new StringReader(xml);
                return ValidXmlDoc(srXml, schemaNamespace, null, ref xml_error, schemaReader);
            }
            catch (Exception ex)
            {
                xml_error.Add(ex.Message);
                this.ValidationError = ex.Message;
                return false;
            }
        }

        /// <SUMMARY>
        /// This method validates an xml document against an xml 
        /// schema.
        public bool ValidXmlDoc(XmlDocument xml, string schemaNamespace, string schemaUri, ref StringCollection xml_error)
        {
            try
            {
                // Is the xml object valid?
                if (xml == null)
                {
                    return false;
                }

                // Create a new string writer.
                StringWriter sw = new StringWriter();
                // Set the string writer as the text writer 
                // to write to.
                XmlTextWriter xw = new XmlTextWriter(sw);
                // Write to the text writer.
                xml.WriteTo(xw);
                // Get 
                string strXml = sw.ToString();

                StringReader srXml = new StringReader(strXml);
                return ValidXmlDoc(srXml, schemaNamespace, schemaUri, ref xml_error);
            }
            catch (Exception ex)
            {
                xml_error.Add(ex.Message);
                this.ValidationError = ex.Message;
                return false;
            }
        }

        /// <SUMMARY>
        /// This method validates an xml string against an xml schema.
        /// </SUMMARY>
        /// <PARAM name="xml">StringReader containing xml</PARAM>
        /// <PARAM name="schemaNamespace">XML Schema Namespace</PARAM>
        /// <PARAM name="schemaUri">XML Schema Uri</PARAM>
        /// <RETURNS>bool</RETURNS>
        public bool ValidXmlDoc(StringReader xml, string schemaNamespace, string schemaUri, ref StringCollection xml_error, XmlReader schemaReader = null)
        {
            // Continue?
            if (xml == null || schemaNamespace == null || (schemaUri == null && schemaReader == null))
            {
                return false;
            }

            isValidXml = true;
            var schemaCol = new XmlSchemaSet();
            if (schemaUri != null)
            { schemaCol.Add(schemaNamespace, schemaUri); }
            else
            { schemaCol.Add(schemaNamespace, schemaReader); }


            var errores = new StringCollection();

            try
            {
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.ValidationType = ValidationType.Schema;
                if (schemaCol != null) { settings.Schemas.Add(schemaCol); }
                settings.ValidationEventHandler +=
                    (sender, args) =>
                    {
                        isValidXml = false;
                        // WARNING: este metodo es llamado una vez por cada error encontrado. ValidationError almacenaría el ultimo error de la lista
                        this.ValidationError = args.Message;
                        errores.Add(args.Message);
                    };

                // Read xml and validate with schema.
                using (XmlReader vr = XmlReader.Create(new XmlTextReader(xml), settings))
                {
                    while (vr.Read()) { }
                }

                xml_error = errores;
                return isValidXml;
            }
            catch (Exception ex)
            {
                xml_error.Add(ex.Message);
                this.ValidationError = ex.Message;
                return false;
            }
        }

        public bool ValidXmlDoc(string xml, string xsd, out string error)
        {
            error = null;

            try
            {
                // build XSD schema

                StringReader _XsdStream;
                _XsdStream = new StringReader(xsd);

                XmlSchema _XmlSchema;
                _XmlSchema = XmlSchema.Read(_XsdStream, null);

                // build settings (this replaces XmlValidatingReader)

                XmlReaderSettings _XmlReaderSettings;
                _XmlReaderSettings = new XmlReaderSettings()
                {
                    ValidationType = ValidationType.Schema
                };
                _XmlReaderSettings.Schemas.Add(_XmlSchema);

                // build XML reader

                StringReader _XmlStream;
                _XmlStream = new StringReader(xml);

                XmlReader _XmlReader;
                _XmlReader = XmlReader.Create(_XmlStream, _XmlReaderSettings);

                // validate

                using (_XmlReader)
                {
                    while (_XmlReader.Read())
                        ;
                }

                // validation succeeded

                return true;
            }
            catch (Exception ex)
            {
                // validation failed
                error = ex.Message;
                return false;
            }
        }
    }
}
