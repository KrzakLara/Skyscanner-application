using ClientApplication.Models;
using ClientApplication.SearchCarriers;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace ClientApplication
{
    public partial class Carriers : Form
    {
        const string xsd = "file:///C:/Users/larak/Desktop/IIS/Projekt_Lara/ClientApplication/ClientApplication/Air_carriers_XSD.xsd";
        const string rng = "file:///C:/Users/larak/Desktop/IIS/Projekt_Lara/ClientApplication/ClientApplication/Air_carriers_RGN.rgn";

        List<Models.Carrier> returnedValues = new List<Models.Carrier>();
        Models.Carrier c;
        string key;
        string value;

        public Carriers()
        {
            InitializeComponent();
            populateComboBox();
        }

        private void populateComboBox()
        {
            cbNode.Items.Add("Name");
            cbNode.Items.Add("IATA");
            cbNode.SelectedIndex = 0;
        }

        // 1. i 2. Novi entitet - POST - Validacija XSD i RNG
        // ...
        private async void Add_ClickAsync(object sender, EventArgs e)
        {
            bool check = validation();

            if (check)
            {
                c = createNew();
                DataContractSerializer serializer = new DataContractSerializer(typeof(Models.Carrier));
                using (MemoryStream stream = new MemoryStream())
                {
                    using (XmlWriter xmlWriter = XmlWriter.Create(stream))
                    {
                        serializer.WriteObject(xmlWriter, c);
                    }

                    byte[] data = stream.ToArray();

                    using (HttpClient client = new HttpClient())
                    {
                        HttpResponseMessage response;

                        if (rbXSD.Checked)
                        {
                            using (OpenFileDialog openFileDialog = new OpenFileDialog())
                            {
                                openFileDialog.Filter = "XSD Files (*.xsd)|*.xsd";
                                if (openFileDialog.ShowDialog() == DialogResult.OK)
                                {
                                    string xsdFilePath = openFileDialog.FileName;
                                    string xmlContent = Encoding.UTF8.GetString(data);
                                    if (ValidateXmlAgainstXsd(xmlContent, xsdFilePath))
                                    {
                                        using (var formData = new MultipartFormDataContent())
                                        {
                                            formData.Add(new ByteArrayContent(data), "file", "Air_carriers.xml");
                                            response = await client.PostAsync("https://skyscanner-api.p.rapidapi.com/v3/flights/carriers", formData);
                                        }
                                    }
                                    else
                                    {
                                        lblInfo.Visible = true;
                                        lblInfo.ForeColor = Color.Red;
                                        lblInfo.Text = "Error: XML validation failed against XSD!";
                                        return;
                                    }
                                }
                                else
                                {
                                    return;
                                }
                            }
                        }
                        else
                        {
                            using (OpenFileDialog openFileDialog = new OpenFileDialog())
                            {
                                openFileDialog.Filter = "RNG Files (*.rng)|*.rng";
                                if (openFileDialog.ShowDialog() == DialogResult.OK)
                                {
                                    string rngFilePath = openFileDialog.FileName;
                                    string xmlContent = Encoding.UTF8.GetString(data);
                                    if (ValidateXmlAgainstRng(xmlContent, rngFilePath))
                                    {
                                        using (var formData = new MultipartFormDataContent())
                                        {
                                            formData.Add(new ByteArrayContent(data), "file", "Air_carriers.xml");
                                            response = await client.PostAsync("https://skyscanner-api.p.rapidapi.com/v3/flights/carriers", formData);
                                        }
                                    }
                                    else
                                    {
                                        lblInfo.Visible = true;
                                        lblInfo.ForeColor = Color.Red;
                                        lblInfo.Text = "Error: XML validation failed against RNG!";
                                        return;
                                    }
                                }
                                else
                                {
                                    return;
                                }
                            }
                        }

                        if (response.IsSuccessStatusCode)
                        {
                            lblInfo.Visible = true;
                            lblInfo.ForeColor = Color.Green;
                            lblInfo.Text = "Success: Validation passed!!";
                        }
                        else
                        {
                            lblInfo.Visible = true;
                            lblInfo.ForeColor = Color.Red;
                            lblInfo.Text = "Error: Validation failed!!";
                        }
                    }
                }
            }
            else
            {
                lblInfo.Visible = true;
                lblInfo.ForeColor = Color.Red;
                lblInfo.Text = "All fields are required!!";
            }
        }

        private bool validation()
        {
            List<TextBox> boxes = new List<TextBox>() { txtName, txtIATA };
            foreach (var item in boxes)
            {
                if (String.IsNullOrEmpty(item.Text.Trim()))
                {
                    return false;
                }
            }
            return true;
        }

        private bool ValidateXmlAgainstXsd(string xmlContent, string xsdFilePath)
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.Schemas.Add(null, xsdFilePath);
            settings.ValidationType = ValidationType.Schema;
            settings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;

            using (StringReader stringReader = new StringReader(xmlContent))
            {
                using (XmlReader xmlReader = XmlReader.Create(stringReader, settings))
                {
                    try
                    {
                        while (xmlReader.Read()) { }
                        return true;
                    }
                    catch (XmlException ex)
                    {
                        Console.WriteLine($"XML validation error: {ex.Message}");
                        return false;
                    }
                }
            }
        }

        private bool ValidateXmlAgainstRng(string xmlContent, string rngFilePath)
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ValidationType = ValidationType.Schema;
            settings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;

            using (StringReader stringReader = new StringReader(xmlContent))
            {
                using (XmlReader xmlReader = XmlReader.Create(stringReader, settings))
                {
                    try
                    {
                        // Učitajte RNG shemu iz datoteke rngFilePath
                        XmlSchemaSet schemas = new XmlSchemaSet();
                        schemas.Add(null, rngFilePath);

                        // Povežite sheme s postavkama XmlReader-a
                        settings.Schemas = schemas;

                        // Provjerite valjanost XML-a pomoću XmlReader-a i stvorenih postavki
                        while (xmlReader.Read()) { }

                        return true; // XML je valjan prema RNG shemi
                    }
                    catch (XmlException ex)
                    {
                        Console.WriteLine($"XML validation error: {ex.Message}");
                        return false; // XML nije valjan prema RNG shemi
                    }
                }
            }
        }


        private Models.Carrier createNew()
        {
            Models.Carrier carrier = new Models.Carrier(
                txtName.Text.Trim(),
                txtIATA.Text.Trim()
            );
            return carrier;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lbCarriers.Items.Clear();
            txtName.Text = "";
            txtIATA.Text = "";
            lblInfo.Visible = false;
            lblSearchInfo.Text = "";

        }


        // 6. Pronaći proizvoljan javni REST API
        private async void btnGetApi_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "3d572af981msh76feb8b882f1476p14410fjsn6e986425424a");
                client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "skyscanner-api.p.rapidapi.com");

                HttpResponseMessage response = await client.GetAsync("https://skyscanner-api.p.rapidapi.com/v3/flights/carriers");
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();

                    Models.Carriers carriers = JsonConvert.DeserializeObject<Models.Carriers>(responseBody);
                    lbCarriers.Items.Clear();
                    foreach (var item in carriers.CarrierDictionary.Values)
                    {
                        lbCarriers.Items.Add(item.Name + " - " + item.IATA);
                    }

                }
            }
        }

        // 3. Soap - Search
        private async void btnSerach_Click(object sender, EventArgs e)
        {
            lbSearched.Items.Clear();
            lblSearchInfo.Visible = false;
            string key = cbNode.SelectedItem.ToString();
            string value = txtSearchedValue.Text.Trim();

            try
            {
                var client = new SearchCarriers.AirCarriersSearchServiceSoapClient();
                var request = new SearchCarriers.SearchCarriersRequest
                {
                    Body = new SearchCarriers.SearchCarriersRequestBody
                    {
                        key = key,
                        value = value
                    }
                };
                var result = await client.SearchCarriersAsync(request);

                if (result != null && result.Body.SearchCarriersResult.Length > 0)
                {
                    foreach (var item in result.Body.SearchCarriersResult)
                    {
                        Models.Carrier c = new Models.Carrier(
                            item.name,
                            item.iata);
                        lbSearched.Items.Add(c);
                    }
                }
                else
                {
                    lblSearchInfo.Visible = true;
                    lblSearchInfo.ForeColor = Color.Red;
                    lblSearchInfo.Text = "Nothing found! Try another search...";
                }
            }
            catch (Exception ex)
            {
                // Handle exception
                lblSearchInfo.Visible = true;
                lblSearchInfo.ForeColor = Color.Red;
                lblSearchInfo.Text = "Error occurred: " + ex.Message;
            }
        }




        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbNode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedNode = cbNode.SelectedItem.ToString();

            List<string> carrierList = lbCarriers.Items.Cast<string>().ToList();

            switch (selectedNode)
            {
                case "Name":
                    carrierList.Sort();
                    break;
                case "IATA":
                    carrierList.Sort((x, y) =>
                    {
                        bool xHasIATA = x.Contains("IATA");
                        bool yHasIATA = y.Contains("IATA");

                        if (xHasIATA && !yHasIATA)
                            return -1;
                        else if (!xHasIATA && yHasIATA)
                            return 1;
                        else if (x.Contains("- ") && !y.Contains("- "))
                            return -1;
                        else if (!x.Contains("- ") && y.Contains("- "))
                            return 1;
                        else if (x.Contains("- ") && y.Contains("- "))
                        {
                            int xIndex = x.IndexOf("- ") + 2;
                            int yIndex = y.IndexOf("- ") + 2;

                            string xIATA = x.Substring(xIndex);
                            string yIATA = y.Substring(yIndex);

                            return xIATA.CompareTo(yIATA);
                        }
                        else
                            return x.CompareTo(y);
                    });
                    break;
                default:
                    // Ako nije odabran valjan kriterij, izlazi iz metode
                    return;
            }

            lbCarriers.Items.Clear();
            lbCarriers.Items.AddRange(carrierList.ToArray());
        }



    }
}
