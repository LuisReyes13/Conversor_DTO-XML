using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Conversor_XML_DTO__DTO_XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_XMLToDTO_Click(object sender, EventArgs e)
        {
            //var oComprobante = new SYS_DTO_Comprobante();

            //CargarDatos(oComprobante);  
        }

        private void btn_DTOToXML_Click(object sender, EventArgs e)
        {
            //var oComprobante = new SYS_DTO_Comprobante();

            //CargarDatos(oComprobante);

            //string xmlString = ToXml(oComprobante);


            CargarDatos();
        }

        //private void CargarDatos(SYS_DTO_Comprobante oComprobante)
        //{
        //    oComprobante.Version = "4.0";
        //    oComprobante.Serie = "PRUEBA";
        //    oComprobante.Folio = "1";
        //    oComprobante.Fecha = DateTime.Now;
        //    oComprobante.Sello = "fcxoJRVNXLUMClDBUOlPnoA0o2fc0BoL6WS5SsVosxgPm8BrgeFpNv3MWSOTUJDyT90dQdLteVHUNP9wMkN/AklrDz9u5PeSvArogY4UqI5/pEtGZIPAjEhsZzHyBmLOr0FA7r6ROxDPAxBRux4I59vODDc9ckXqOFtmh7PdZoOFZjDKoeEJKLd6/bXCvG7wdZoEpnhCRCCn2P7c3/Zy8q0um6S2iMswY8YRmSjSs/XwrtDucOEjBjNrFQOXx68nbHPwciCmtye/UP9+3QhoGQ1W5RgNITEtK3IKOYJ/dr0AJHuDeJPUfzljQRwUYvKO2Z03yAyO3h/u4R0tL7vg4w==";
        //    oComprobante.FormaPago = "01";
        //    oComprobante.NoCertificado = "00001000000505425099";
        //    oComprobante.Certificado = "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";
        //    oComprobante.Moneda = "MXN";
        //    oComprobante.Total = "1.00";
        //    oComprobante.SubTotal = "1.00";
        //    oComprobante.TipoDeComprobante = "I";
        //    oComprobante.Exportacion = "01";
        //    oComprobante.MetodoPago = "PUE";
        //    oComprobante.LugarExpedicion = "54060";

        //    oComprobante.Emisor.Rfc = "SME980227TP3";
        //    oComprobante.Emisor.Nombre = "SOMFY MEXICO";
        //    oComprobante.Emisor.RegimenFiscal = "601";

        //    oComprobante.Receptor.Rfc = "VESG910818EVA";
        //    oComprobante.Receptor.Nombre = "GUSTAVO VERGARA SANTANA";
        //    oComprobante.Receptor.DomicilioFiscalReceptor = "57300";
        //    oComprobante.Receptor.RegimenFiscalReceptor = "601";
        //    oComprobante.Receptor.UsoCFDI = "S01";

        //    oComprobante.Conceptos.Concepto.ClaveProdServ = "78101500";
        //    oComprobante.Conceptos.Concepto.NoIdentificacion = "A001";
        //    oComprobante.Conceptos.Concepto.Cantidad = "1.00";
        //    oComprobante.Conceptos.Concepto.ClaveUnidad = "H87";
        //    oComprobante.Conceptos.Concepto.Descripcion = "Articulo";
        //    oComprobante.Conceptos.Concepto.ValorUnitario = "1.000000";
        //    oComprobante.Conceptos.Concepto.Importe = "1.00";
        //    oComprobante.Conceptos.Concepto.ObjetoImp = "01";
        //}

        public void CargarDatos()
        {
            Comprobante oComprobante = new Comprobante();
            ComprobanteEmisor oEmisor = new ComprobanteEmisor();
            ComprobanteReceptor oReceptor = new ComprobanteReceptor();
            ComprobanteConcepto oConcepto = new ComprobanteConcepto();

            oComprobante.Version = "4.0";
            oComprobante.Serie = "PRUEBA";
            oComprobante.Folio = "1";
            oComprobante.Fecha = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
            oComprobante.Sello = "fcxoJRVNXLUMClDBUOlPnoA0o2fc0BoL6WS5SsVosxgPm8BrgeFpNv3MWSOTUJDyT90dQdLteVHUNP9wMkN/AklrDz9u5PeSvArogY4UqI5/pEtGZIPAjEhsZzHyBmLOr0FA7r6ROxDPAxBRux4I59vODDc9ckXqOFtmh7PdZoOFZjDKoeEJKLd6/bXCvG7wdZoEpnhCRCCn2P7c3/Zy8q0um6S2iMswY8YRmSjSs/XwrtDucOEjBjNrFQOXx68nbHPwciCmtye/UP9+3QhoGQ1W5RgNITEtK3IKOYJ/dr0AJHuDeJPUfzljQRwUYvKO2Z03yAyO3h/u4R0tL7vg4w==";
            oComprobante.FormaPago = "01";
            oComprobante.NoCertificado = "00001000000505425099";
            oComprobante.Certificado = "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";
            oComprobante.Moneda = "MXN";
            oComprobante.Total = 1;
            oComprobante.SubTotal = 1;
            oComprobante.TipoDeComprobante = "I";
            oComprobante.Exportacion = "01";
            oComprobante.MetodoPago = "PUE";
            oComprobante.LugarExpedicion = "54060";

            oEmisor.Rfc = "SME980227TP3";
            oEmisor.Nombre = "SOMFY MEXICO";
            oEmisor.RegimenFiscal = "601";

            oComprobante.Emisor = oEmisor;

            oReceptor.Rfc = "VESG910818EVA";
            oReceptor.Nombre = "GUSTAVO VERGARA SANTANA";
            oReceptor.DomicilioFiscalReceptor = "57300";
            oReceptor.RegimenFiscalReceptor = "601";
            oReceptor.UsoCFDI = "S01";

            oComprobante.Receptor = oReceptor;

            List<ComprobanteConcepto> listConceptos = new List<ComprobanteConcepto>();
            oConcepto.ClaveProdServ = "78101500";
            oConcepto.NoIdentificacion = "A001";
            oConcepto.Cantidad = 1;
            oConcepto.ClaveUnidad = "H87";
            oConcepto.Descripcion = "Articulo";
            oConcepto.ValorUnitario = 1;
            oConcepto.Importe = 1;
            oConcepto.ObjetoImp = "01";

            listConceptos.Add(oConcepto);

            oComprobante.Conceptos = listConceptos.ToArray();

            // Serializar

            string pathXML = $@"{Directory.GetCurrentDirectory()}\xmlPrueba.xml";

            XmlSerializerNamespaces xmlNameSpace = new XmlSerializerNamespaces();
            xmlNameSpace.Add("cfdi", "http://www.sat.gob.mx/cfd/4");
            xmlNameSpace.Add("tfd", "http://www.sat.gob.mx/TimbreFiscalDigital");
            xmlNameSpace.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");

            XmlSerializer oXMLSerializer = new XmlSerializer(typeof(Comprobante));

            string sXML = "";
            using (var SWW = new StringWriterWithEncoding(Encoding.UTF8))
            {
                using (XmlWriter writer = XmlWriter.Create(SWW))
                {
                    oXMLSerializer.Serialize(writer, oComprobante, xmlNameSpace);
                    sXML = SWW.ToString();
                }
            }

            // Guardar XML
            File.WriteAllText(pathXML, sXML);

        }


        //public static string ToXml(SYS_DTO_Comprobante oComprobante)
        //{
        //    try
        //    {

        //        XDocument doc = new XDocument(
        //        new XDeclaration("1.0", "utf-8", "yes"),
        //        new XElement("Comprobante",
        //            new XAttribute("cfdi", "http://www.sat.gob.mx/cfd/4"),
        //            new XAttribute("xsi", "http://www.w3.org/2001/XMLSchema-instance"),
        //            new XAttribute("schemaLocation", "http://www.sat.gob.mx/cfd/4 http://www.sat.gob.mx/sitio_internet/cfd/4/cfdv40.xsd"),
        //            new XAttribute("Version", oComprobante.Version),
        //            new XAttribute("Serie", oComprobante.Serie),
        //            new XAttribute("Folio", oComprobante.Folio),
        //            new XAttribute("Fecha", oComprobante.Fecha.ToString("yyyy-MM-ddTHH:mm:ss")),
        //            new XAttribute("Sello", oComprobante.Sello),
        //            new XAttribute("FormaPago", oComprobante.FormaPago),
        //            new XAttribute("NoCertificado", oComprobante.NoCertificado),
        //            new XAttribute("Certificado", oComprobante.Certificado),
        //            new XAttribute("Moneda", oComprobante.Moneda),
        //            new XAttribute("Total", oComprobante.Total),
        //            new XAttribute("SubTotal", oComprobante.SubTotal),
        //            new XAttribute("TipoDeComprobante", oComprobante.TipoDeComprobante),
        //            new XAttribute("Exportacion", oComprobante.Exportacion),
        //            new XAttribute("MetodoPago", oComprobante.MetodoPago),
        //            new XAttribute("LugarExpedicion", oComprobante.LugarExpedicion),

        //            new XElement("Emisor",
        //                new XAttribute("Nombre", oComprobante.Emisor.Nombre),
        //                new XAttribute("Rfc", oComprobante.Emisor.Rfc),
        //                new XElement("RegimenFiscal", oComprobante.Emisor.RegimenFiscal)
        //            ),

        //            new XElement("Receptor",
        //                new XAttribute("Nombre", oComprobante.Receptor.Nombre),
        //                new XAttribute("Rfc", oComprobante.Receptor.Rfc),
        //                new XAttribute("DomicilioFiscalReceptor", oComprobante.Receptor.DomicilioFiscalReceptor),
        //                new XAttribute("RegimenFiscalReceptor", oComprobante.Receptor.RegimenFiscalReceptor),
        //                new XAttribute("UsoCFDI", oComprobante.Receptor.UsoCFDI)
        //            ),

        //            new XElement("Conceptos",
        //                new XElement("Concepto",
        //                    new XAttribute("ClaveProdServ", oComprobante.Conceptos.Concepto.ClaveProdServ),
        //                    new XAttribute("NoIdentificacion", oComprobante.Conceptos.Concepto.NoIdentificacion),
        //                    new XAttribute("Cantidad", oComprobante.Conceptos.Concepto.Cantidad),
        //                    new XAttribute("ClaveUnidad", oComprobante.Conceptos.Concepto.ClaveUnidad),
        //                    new XAttribute("Descripcion", oComprobante.Conceptos.Concepto.Descripcion),
        //                    new XAttribute("ValorUnitario", oComprobante.Conceptos.Concepto.ValorUnitario),
        //                    new XAttribute("Importe", oComprobante.Conceptos.Concepto.Importe),
        //                    new XAttribute("ObjetoImp", oComprobante.Conceptos.Concepto.ObjetoImp)
        //                )
        //            )
        //        )
        //    );

        //        return doc.ToString();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return null;
        //    }
        //}
    }

    public class StringWriterWithEncoding : StringWriter
    {
        public StringWriterWithEncoding(Encoding encoding) : base()
        {
            this.m_Encoding = encoding;
        }
        private readonly Encoding m_Encoding;
        public override Encoding Encoding
        {
            get { return m_Encoding; }
        }
    }
}
