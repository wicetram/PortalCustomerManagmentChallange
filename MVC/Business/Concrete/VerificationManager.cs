﻿using MVC.Models;
using MVC.Models.KPS;
using MVC.Models.KPS.KPS;
using Newtonsoft.Json;
using PortalCustomerManagmentChallangeMVC.Business.Abstract;
using RestSharp;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace MVC.Business.Concrete
{
    public class VerificationManager : IVerificationService
    {
        private readonly string baseUrl = "https://tckimlik.nvi.gov.tr/service/kpspublic.asmx";
        public bool VerifyTCKN(Customer customer)
        {
            try
            {
                var xmlRequest = new KPSRequestDto
                {
                    Header = "",
                    Body = new Models.KPS.EnvelopeBody
                    {
                        TCKimlikNoDogrula = new TCKimlikNoDogrula
                        {
                            Ad = customer.Name,
                            Soyad = customer.Surname,
                            DogumYili = customer.BirthYear,
                            TCKimlikNo = customer.TCKN
                        }
                    }
                };

                var serializer = new XmlSerializer(typeof(KPSRequestDto));
                var settings = new XmlWriterSettings
                {
                    Encoding = Encoding.UTF8,
                    Indent = true,
                    OmitXmlDeclaration = true,
                };

                var builder = new StringBuilder();
                using (var writer = XmlWriter.Create(builder, settings))
                {
                    serializer.Serialize(writer, xmlRequest);
                }

                var body = builder.ToString();

                KPSResponseDto result;

                var request = new RestRequest { Method = Method.Post };
                request.AddHeader("Content-Type", "text/xml; charset=utf-8");
                request.AddParameter("text/xml", body, ParameterType.RequestBody);

                var client = new RestClient(baseUrl);
                var response = client.Execute(request);
                if (response.IsSuccessful)
                {
                    XmlDocument xmlDoc = new();
                    xmlDoc.LoadXml(response.Content);
                    var serializer2 = new XmlSerializer(typeof(KPSResponseDto));
                    using (var reader = new StringReader(xmlDoc.InnerXml))
                    {
                        result = (KPSResponseDto)serializer2.Deserialize(reader);
                    }

                    var responseResult = JsonConvert.SerializeObject(result);
                    if (!string.IsNullOrEmpty(responseResult))
                    {
                        var success = JsonConvert.DeserializeObject<KPSResponseDto>(responseResult);
                        if (success.Body.TCKimlikNoDogrulaResponse.TCKimlikNoDogrulaResult)
                        {
                            return true;
                        }
                    }
                   
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
