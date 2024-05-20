using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Conversor_XML_DTO__DTO_XML
{
    // Definición de la clase Comprobante para representar el XML
    [XmlRoot(ElementName = "Comprobante", Namespace = "cfdi")]
    public class SYS_DTO_Comprobante
    {
        public SYS_DTO_Comprobante()
        {
            Emisor = new SYS_DTO_Emisor();
            Receptor = new SYS_DTO_Receptor();
                Conceptos = new SYS_DTO_Conceptos
                {
                    Concepto = new SYS_DTO_Concepto()
                };
        }

        [XmlAttribute(AttributeName = "Version")]
        public string Version { get; set; }

        [XmlAttribute(AttributeName = "Serie")]
        public string Serie { get; set; }

        [XmlAttribute(AttributeName = "Folio")]
        public string Folio { get; set; }

        [XmlAttribute(AttributeName = "Fecha")]
        public DateTime Fecha { get; set; }

        [XmlAttribute(AttributeName = "Sello")]
        public string Sello { get; set; }

        [XmlAttribute(AttributeName = "FormaPago")]
        public string FormaPago { get; set; }

        [XmlAttribute(AttributeName = "NoCertificado")]
        public string NoCertificado { get; set; }

        [XmlAttribute(AttributeName = "Certificado")]
        public string Certificado { get; set; }

        [XmlAttribute(AttributeName = "Moneda")]
        public string Moneda { get; set; }

        [XmlAttribute(AttributeName = "Total")]
        public string Total { get; set; }

        [XmlAttribute(AttributeName = "SubTotal")]
        public string SubTotal { get; set; }

        [XmlAttribute(AttributeName = "TipoDeComprobante")]
        public string TipoDeComprobante { get; set; }

        [XmlAttribute(AttributeName = "Exportacion")]
        public string Exportacion { get; set; }

        [XmlAttribute(AttributeName = "MetodoPago")]
        public string MetodoPago { get; set; }

        [XmlAttribute(AttributeName = "LugarExpedicion")]
        public string LugarExpedicion { get; set; }

        [XmlElement(ElementName = "Emisor")]
        public SYS_DTO_Emisor Emisor { get; set; }

        [XmlElement(ElementName = "Receptor")]
        public SYS_DTO_Receptor Receptor { get; set; }

        [XmlElement(ElementName = "Conceptos")]
        public SYS_DTO_Conceptos Conceptos { get; set; }

    }

    // Definición de la clase Emisor para representar el emisor del XML
    [XmlRoot(ElementName = "Emisor", Namespace = "http://www.sat.gob.mx/cfd/4")]
    public class SYS_DTO_Emisor
    {
        [XmlAttribute(AttributeName = "Nombre")]
        public string Nombre { get; set; }

        [XmlAttribute(AttributeName = "Rfc")]
        public string Rfc { get; set; }

        [XmlElement(ElementName = "RegimenFiscal")]
        public string RegimenFiscal { get; set; }
    }

    // Definición de la clase Receptor para representar el receptor del XML
    [XmlRoot(ElementName = "Receptor", Namespace = "http://www.sat.gob.mx/cfd/4")]
    public class SYS_DTO_Receptor
    {
        [XmlAttribute(AttributeName = "Nombre")]
        public string Nombre { get; set; }

        [XmlAttribute(AttributeName = "Rfc")]
        public string Rfc { get; set; }

        [XmlAttribute(AttributeName = "DomicilioFiscalReceptor")]
        public string DomicilioFiscalReceptor { get; set; }

        [XmlAttribute(AttributeName = "RegimenFiscalReceptor")]
        public string RegimenFiscalReceptor { get; set; }

        [XmlAttribute(AttributeName = "UsoCFDI")]
        public string UsoCFDI { get; set; }


    }

    // Definición de la clase Conceptos para representar los conceptos del XML
    [XmlRoot(ElementName = "Conceptos", Namespace = "http://www.sat.gob.mx/cfd/4")]
    public class SYS_DTO_Conceptos
    {
        [XmlElement(ElementName = "Concepto")]
        public SYS_DTO_Concepto Concepto { get; set; }
    }

    // Definición de la clase Concepto para representar un concepto del XML
    [XmlRoot(ElementName = "Concepto", Namespace = "http://www.sat.gob.mx/cfd/4")]
    public class SYS_DTO_Concepto
    {
        [XmlAttribute(AttributeName = "ClaveProdServ")]
        public string ClaveProdServ { get; set; }

        [XmlAttribute(AttributeName = "NoIdentificacion")]
        public string NoIdentificacion { get; set; }

        [XmlAttribute(AttributeName = "Cantidad")]
        public string Cantidad { get; set; }

        [XmlAttribute(AttributeName = "ClaveUnidad")]
        public string ClaveUnidad { get; set; }

        [XmlAttribute(AttributeName = "Descripcion")]
        public string Descripcion { get; set; }

        [XmlAttribute(AttributeName = "ValorUnitario")]
        public string ValorUnitario { get; set; }

        [XmlAttribute(AttributeName = "Importe")]
        public string Importe { get; set; }

        [XmlAttribute(AttributeName = "ObjetoImp")]
        public string ObjetoImp { get; set; }

    }
}
