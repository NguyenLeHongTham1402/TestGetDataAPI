using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Transactions;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft;

namespace TestGetDataAPI
{
    public partial class Form1 : Form
    {
        private const string url = @"https://192.168.1.207/SRV07KineticTrain/api/v1/Erp.BO.CustomerSvc/";
        private const string userName = "INTERN.THAMNLH";
        private const string password = "12345";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testAPIEpicorDataSet.CustomerBAQ' table. You can move, or remove it, as needed.
            this.customerBAQTableAdapter.Fill(this.testAPIEpicorDataSet.CustomerBAQ);
            //// TODO: This line of code loads data into the 'testAPIEpicorDataSet.CustEpicor' table. You can move, or remove it, as needed.
            //this.custEpicorTableAdapter.Fill(this.testAPIEpicorDataSet.CustEpicor);

            #region API Table
            /*var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";
                ServicePointManager.ServerCertificateValidationCallback +=
                    delegate (object sen, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
                    {
                        return true;
                    };

                string encoded = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes($"{userName}:{password}"));
                httpWebRequest.Headers.Add("Authorization", "Basic " + encoded);

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                string result = string.Empty;
                using(var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }
                var data = JObject.Parse(result)["value"];

               foreach(var d in data)
                {
                    InsertData(d["name"].ToString(), d["url"].ToString());
                }*/
            #endregion

            #region API BAQ
            /*string url1 = @"https://192.168.1.207/SRV07KineticProd/api/v2/odata/EPIC06/BaqSvc/NNH_GetDataCustomer/Data";
                string key = "Rn69RMgo9lnkBV6HusIJ2cokdYgyhgidQaKol8HpPpFbn";

                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url1);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                ServicePointManager.ServerCertificateValidationCallback +=
                    delegate (object send, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
                    {
                        return true;
                    };

                string credentials = string.Format("{0}:{1}", userName, password);
                string encoded = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(credentials));

                httpWebRequest.Headers.Add("Authorization", "Basic " + encoded);
                httpWebRequest.Headers.Add("X-API-Key", key);

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                string result = string.Empty;
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }

                var data = JObject.Parse(result)["value"];
                foreach(var i in data)
                {
                    Customer customer = new Customer();
                    customer.CustID = i["Customer_CustID"].ToString();
                    customer.CustNum = (int)i["Customer_CustNum"];
                    customer.Name = i["Customer_Name"].ToString();
                    customer.Address1 = i["Customer_Address1"].ToString();
                    customer.Address2 = i["Customer_Address2"].ToString();
                    customer.Address3 = i["Customer_Address3"].ToString();
                    customer.City = i["Customer_City"].ToString();
                    customer.State = i["Customer_State"].ToString();
                    customer.Zip = i["Customer_Zip"].ToString();
                    customer.Country = i["Customer_Country"].ToString();
                    InsertDataBAQ(customer);
                }*/
            #endregion

            GetData();
            GetDataBAQ();

        }

        private void InsertData(string v1, string v2)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["TestAPIEpicorConn"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            using (var trans = new TransactionScope())
            {
                using (conn)
                {
                    try
                    {
                        string query = string.Format("INSERT INTO CustEpicor VALUES('{0}', '{1}')", v1, v2);
                        conn.Open();
                        SqlCommand com = new SqlCommand(query, conn);
                        int i = com.ExecuteNonQuery();
                        trans.Complete();
                    }
                    catch (Exception)
                    {
                        trans.Dispose();
                    }
                    finally
                    {
                        conn.Close();
                    }
                }

            }
        }

        private void InsertDataBAQ(Customer customer)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["TestAPIEpicorConn"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            using (var trans = new TransactionScope())
            {
                using (conn)
                {
                    try
                    {
                        string query = string.Format("INSERT INTO CustomerBAQ VALUES('{0}', {1}, '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')",
                            customer.CustID, customer.CustNum, customer.Name, customer.Address1, customer.Address2, customer.Address3, customer.City, customer.State, customer.Zip, customer.Country);
                        conn.Open();
                        SqlCommand com = new SqlCommand(query, conn);
                        int i = com.ExecuteNonQuery();
                        trans.Complete();
                    }
                    catch (Exception)
                    {
                        trans.Dispose();
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void GetData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["TestAPIEpicorConn"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            DataTable dt = new DataTable();
            string query = "SELECT * FROM CustEpicor";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(dt);
            dgvThongTin.DataSource = dt;
        }

        private void GetDataBAQ()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["TestAPIEpicorConn"].ConnectionString;
            string query = "SELECT * FROM CustomerBAQ";
            SqlDataAdapter sql = new SqlDataAdapter(query, connectionString);
            DataTable dt = new DataTable();
            sql.Fill(dt);
            dgvKhachHang.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string url = @"https://192.168.1.207/SRV07KineticProd/api/v2/odata/EPIC06/BaqSvc/NNH_UpdateCustomer/Data";
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "PATCH";
            ServicePointManager.ServerCertificateValidationCallback +=
                delegate (object sen, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
                {
                    return true;
                };
            string encoded = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes($"{userName}:{password}"));
            httpWebRequest.Headers.Add("Authorization", "Basic " + encoded);
            httpWebRequest.Headers.Add("X-API-Key", "Rn69RMgo9lnkBV6HusIJ2cokdYgyhgidQaKol8HpPpFbn");
            var obj = new
            {
                Customer_CustID = txtCustID.Text,
                Customer_CustNum = int.Parse(txtCustNum.Text),
                Customer_Name = txtName.Text,
                Customer_Address1 = txtAddress1.Text,
                Customer_Address2 = txtAddress2.Text,
                Customer_Address3 = txtAddress3.Text,
                Customer_City = txtCity.Text,
                Customer_State = txtState.Text,
                Customer_Zip = txtZip.Text,
                Customer_Country = txtCountry.Text,
            };
            var json = JsonConvert.SerializeObject(obj);
            Stream dataStream = httpWebRequest.GetRequestStream();
            byte[] buffer = Encoding.GetEncoding("ISO-8859-1").GetBytes(json);
            dataStream.Write(buffer, 0, buffer.Length);
            dataStream.Close();
            var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string result = string.Empty;
            string result1 = httpWebResponse.StatusDescription;
            using (StreamReader reader = new StreamReader(httpWebResponse.GetResponseStream(), System.Text.Encoding.GetEncoding("ISO-8859-1")))
            {
                result = reader.ReadToEnd();
            }
            Customer customer = new Customer();
            customer.CustID = txtCustID.Text;
            customer.CustNum = int.Parse(txtCustNum.Text);
            customer.Name = txtName.Text;
            customer.Address1 = txtAddress1.Text;
            customer.Address2 = txtAddress2.Text;
            customer.Address3 = txtAddress3.Text;

            UpdateCustomer(customer);
            MessageBox.Show(JObject.Parse(result).ToString(), "Thông báo");
            GetDataBAQ();
        }

        private void dgvKhachHang_Click(object sender, EventArgs e)
        {
            txtCustID.Text = dgvKhachHang.SelectedRows[0].Cells[0].Value.ToString();
            txtCustNum.Text = dgvKhachHang.SelectedRows[0].Cells[1].Value.ToString();
            txtName.Text = dgvKhachHang.SelectedRows[0].Cells[2].Value.ToString();
            txtAddress1.Text = dgvKhachHang.SelectedRows[0].Cells[3].Value.ToString();
            txtAddress2.Text = dgvKhachHang.SelectedRows[0].Cells[4].Value.ToString();
            txtAddress3.Text = dgvKhachHang.SelectedRows[0].Cells[5].Value.ToString();
            txtCity.Text = dgvKhachHang.SelectedRows[0].Cells[6].Value.ToString();
            txtState.Text = dgvKhachHang.SelectedRows[0].Cells[7].Value.ToString();
            txtZip.Text = dgvKhachHang.SelectedRows[0].Cells[8].Value.ToString();
            txtCountry.Text = dgvKhachHang.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void UpdateCustomer(Customer customer)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["TestAPIEpicorConn"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);          
            using(var trans = new TransactionScope())
            {
                using (conn)
                {
                    try
                    {
                        string query = string.Format("UPDATE CustomerBAQ SET CustID = '{0}', Name = '{1}', Address1 = '{2}', Address2 = '{3}', Address3 = '{4}' WHERE CustNum = {5}", customer.CustID, customer.Name, customer
                            .Address1, customer.Address2, customer.Address3, customer.CustNum);
                        conn.Open();
                        SqlCommand com = new SqlCommand(query, conn);
                        com.ExecuteNonQuery();
                        trans.Complete();
                    }
                    catch (Exception)
                    {

                        trans.Dispose();
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void btnGetNew_Click(object sender, EventArgs e)
        {
            string url = @"https://192.168.1.207/SRV07KineticProd/api/v2/odata/EPIC06/BaqSvc/NNH_UpdateCustomer/GetNew";
            var httpwebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpwebRequest.ContentType = "application/json";
            httpwebRequest.Method = "GET";
            ServicePointManager.ServerCertificateValidationCallback +=
                delegate (object sen, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
                {
                    return true;
                };
            string encoded = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes($"{userName}:{password}"));
            httpwebRequest.Headers.Add("Authorization", "Basic " + encoded);
            httpwebRequest.Headers.Add("X-API-Key", "Rn69RMgo9lnkBV6HusIJ2cokdYgyhgidQaKol8HpPpFbn");
            string result = string.Empty;
            var httpWebResponse = (HttpWebResponse)httpwebRequest.GetResponse();
            using(StreamReader reader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                result = reader.ReadToEnd();
            }
            if(httpWebResponse.StatusCode.ToString()=="OK")
            {
                string RowIdent = string.Empty;
                string SysRowID = string.Empty;

                var data = JObject.Parse(result)["value"];

                RowIdent = data[0]["RowIdent"].ToString();
                SysRowID = data[0]["SysRowID"].ToString();

                var obj = new
                {
                    Customer_CustID = txtCustID.Text,
                    Customer_Name = txtName.Text,
                    Customer_Address1 = txtAddress1.Text,
                    Customer_Address2 = txtAddress2.Text,
                    Customer_Address3 = txtAddress3.Text,
                    Customer_City = txtCity.Text,
                    Customer_State = txtState.Text,
                    Customer_Zip = txtZip.Text,
                    Customer_Country = txtCountry.Text,
                    RowMod = "A",
                    RowIdent = RowIdent,
                    SysRowID = SysRowID
                };
                var json = JsonConvert.SerializeObject(obj);
                string result1 = UpdateBAQThroughAPI(json);
                InsertDataBAQ(GetNewCustomer(txtCustID.Text));
                GetDataBAQ();
            }           

        }

        private string UpdateBAQThroughAPI(string json)
        {
            string url = @"https://192.168.1.207/SRV07KineticProd/api/v2/odata/EPIC06/BaqSvc/NNH_UpdateCustomer/Data";
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "PATCH";
            ServicePointManager.ServerCertificateValidationCallback +=
                delegate (object sen, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
                {
                    return true;
                };
            string encoded = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes($"{userName}:{password}"));
            httpWebRequest.Headers.Add("Authorization", "Basic " + encoded);
            httpWebRequest.Headers.Add("X-API-Key", "Rn69RMgo9lnkBV6HusIJ2cokdYgyhgidQaKol8HpPpFbn");
            Stream dataStream = httpWebRequest.GetRequestStream();
            byte[] buffer = Encoding.GetEncoding("ISO-8859-1").GetBytes(json);
            dataStream.Write(buffer, 0, buffer.Length);
            dataStream.Close();
            var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string result = string.Empty;
            string result1 = httpWebResponse.StatusDescription;
            using (StreamReader reader = new StreamReader(httpWebResponse.GetResponseStream(), System.Text.Encoding.GetEncoding("ISO-8859-1")))
            {
                result = reader.ReadToEnd();
            }
            return result;
        }

        private Customer GetNewCustomer(string id)
        {
            string url = @"https://192.168.1.207/SRV07KineticProd/api/v2/odata/EPIC06/BaqSvc/NNH_UpdateCustomer/Data?%24filter=Customer_CustID%20eq%20'" + id + "'%20";
            string key = "Rn69RMgo9lnkBV6HusIJ2cokdYgyhgidQaKol8HpPpFbn";
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";
            ServicePointManager.ServerCertificateValidationCallback +=
                delegate (object obj, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
                {
                    return true;
                };
            string encoded = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes($"{userName}:{password}"));
            httpWebRequest.Headers.Add("Authorization", "Basic " + encoded);
            httpWebRequest.Headers.Add("X-API-Key", key);

            var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string result = string.Empty;
            using(StreamReader reader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                result = reader.ReadToEnd();
            }
            var json = JObject.Parse(result)["value"][0];
            Customer customer = new Customer();
            customer.CustID = json["Customer_CustID"].ToString();
            customer.CustNum = int.Parse(json["Customer_CustNum"].ToString());
            customer.Name = json["Customer_Name"].ToString();
            customer.Address1 = json["Customer_Address1"].ToString();
            customer.Address2 = json["Customer_Address2"].ToString();
            customer.Address3 = json["Customer_Address3"].ToString();
            customer.City = json["Customer_City"].ToString();
            customer.State = json["Customer_State"].ToString();
            customer.Zip = json["Customer_Zip"].ToString();
            customer.Country = json["Customer_Country"].ToString();
            return customer;
        }
    }
}
