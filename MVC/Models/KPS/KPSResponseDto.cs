using System.ComponentModel;
using System.Xml.Serialization;

namespace MVC.Models.KPS.KPS
{
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    [XmlRoot(Namespace = "http://schemas.xmlsoap.org/soap/envelope/", IsNullable = false, ElementName = "Envelope")]
    public partial class KPSResponseDto
    {
        private EnvelopeBody bodyField;

        public EnvelopeBody Body
        {
            get
            {
                return this.bodyField;
            }
            set
            {
                this.bodyField = value;
            }
        }
    }

    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public partial class EnvelopeBody
    {
        private TCKimlikNoDogrulaResponse tCKimlikNoDogrulaResponseField;

        [XmlElementAttribute(Namespace = "http://tckimlik.nvi.gov.tr/WS")]
        public TCKimlikNoDogrulaResponse TCKimlikNoDogrulaResponse
        {
            get
            {
                return this.tCKimlikNoDogrulaResponseField;
            }
            set
            {
                this.tCKimlikNoDogrulaResponseField = value;
            }
        }
    }

    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://tckimlik.nvi.gov.tr/WS")]
    [XmlRoot(Namespace = "http://tckimlik.nvi.gov.tr/WS", IsNullable = false)]
    public partial class TCKimlikNoDogrulaResponse
    {
        private bool tCKimlikNoDogrulaResultField;

        public bool TCKimlikNoDogrulaResult
        {
            get
            {
                return this.tCKimlikNoDogrulaResultField;
            }
            set
            {
                this.tCKimlikNoDogrulaResultField = value;
            }
        }
    }


}
