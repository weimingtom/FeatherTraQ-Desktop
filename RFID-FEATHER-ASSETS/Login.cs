﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.Data.SqlClient;
using RestSharp;
using System.Net;
using RestSharp.Deserializers;
using Microsoft.Win32;
using System.Globalization;
using System.Resources;
using System.Reflection;
using System.Threading;
using System.Net.NetworkInformation;

namespace RFID_FEATHER_ASSETS
{
     
    public partial class LoginActivity : Form
    {
        int companyid;
        string companyName;
		string readerInfo;
        string locationInfo;
        bool save;
        public LoginActivity()//string portnamesource)
        {
            InitializeComponent();
            getLanguageInfo();
			//GetReaderInfo();
            if (locationInfo != null)
            {
                populateLocation();
                txtUserName.Focus();
            }
            //populateLanguage();
        }

        private void populateLocation()
        {
            List<Location> loc = new List<Location>();

            if (locationInfo != null)
            {
                string[] locInfo = locationInfo.Split(',');

                /*if (language == "Japanese")
                {
                    roles.Add(new GlobalClass.GetSetClass() { roleName = rm.GetString("Administrator"), value = "ROLE_ADMIN" });
                    roles.Add(new GlobalClass.GetSetClass() { roleName = rm.GetString("Security"), value = "ROLE_GUARD" });
                    //roles.Add(new Role() { roleName = "User", value = "ROLE_USER" });
                }
                else
                {*/

                for (int i = 0; i < locInfo.Length; i++)
                {
            
                        loc.Add(new Location() { location = locInfo[i], value = "location_" + locInfo[i] });
                }
                //roles.Add(new Role() { roleName = "User", value = "ROLE_USER" });
                /*}*/
                this.cmbLocation.DataSource = loc;
                this.cmbLocation.ValueMember = "value";
                this.cmbLocation.DisplayMember = "location";
                this.cmbLocation.Text = readerInfo;
            }
        }

		private void GetReaderInfo()
        {
            try
            { 
                string LocalIp = string.Empty;
                string Domain = !string.IsNullOrEmpty(System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName) ? System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName : "x";
                string Host = System.Net.Dns.GetHostName();

                if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                {
                    System.Net.IPHostEntry host = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());
                    foreach (System.Net.IPAddress ip in host.AddressList)
                    {
                        if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            LocalIp = ip.ToString();
                            break;
                        }
                    }
                    //string IpWidHost = String.Format("[Domain-{0} : Host-{1} : IP-{2}]", Domain, Host, LocalIp);
                }
                else return;
           
                var macAddr = (from nic in NetworkInterface.GetAllNetworkInterfaces()
                               where nic.OperationalStatus == OperationalStatus.Up
                               select nic.GetPhysicalAddress().ToString()).FirstOrDefault();
                //var macAddrs = NetworkInterface.GetAllNetworkInterfaces().Where(nic => nic.OperationalStatus == OperationalStatus.Up).Select(nic => nic.GetPhysicalAddress().ToString()).FirstOrDefault();
                readerInfo = /*"Domain:" + Domain +*/ "Host:" + Host + /*" IP Address:" + LocalIp +*/ " Mac Address:" + macAddr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void getLanguageInfo()
        {
            try
            {
                //opening the subkey  
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\AssetSystemInfo");

                //if it does exist, retrieve the stored values  
                if (key != null)
                {
                    selectLanguage.Text = "English";//(string)(key.GetValue("Language"));
                    locationInfo = (string)(key.GetValue("LocInfo"));
                    readerInfo = (string)(key.GetValue("readerInfo"));
                    key.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ClearFields()
        {
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cmbLocation.Text))
                {
                    lblLocation.Visible = true;
                    cmbLocation.Focus();
                    return;
                }
                else if (txtUserName.TextLength == 0 || txtPassword.TextLength == 0)
                {
                    lblUserPasswordRequired.Visible = true;
                    txtUserName.Focus();
                    return;
                }
                else
                {
                    lblUserPasswordRequired.Visible = false;

                    //picLoading.Visible = true;
                    lblLoggingIn.Visible = true;//btnLogin.Text = "Logging in...";
                    this.Refresh();

                    GlobalClass.GetSetClass loginInfo = new GlobalClass.GetSetClass();
                    //store information to object
                    loginInfo.email = txtUserName.Text;
                    loginInfo.password = txtPassword.Text;

                    //initialize web service
                    //RestClient(request);
                    RestClient client = new RestClient("http://52.163.93.95:8080/FeatherAssets/");//("http://127.0.0.1:8080/");
                    RestRequest login = new RestRequest("/login", Method.POST);


                    //pass information to web service
                    login.AddHeader("Content-Type", "application/json; charset=utf-8");
                    login.RequestFormat = DataFormat.Json;
                    login.AddBody(loginInfo);

                    //retrieve response
                    IRestResponse response = client.Execute(login);
                    lblLoggingIn.Visible = false; 

                    var content = response.Content;

                    //check for errors
                    if (response.StatusCode == HttpStatusCode.OK)
                    {

                        //deserialize JSON -> Object
                        GlobalClass.GetSetClass loginResult = new GlobalClass.GetSetClass();

                        JsonDeserializer deserial = new JsonDeserializer();
                        loginResult = deserial.Deserialize<GlobalClass.GetSetClass>(response);
                        readerInfo = cmbLocation.Text;
                       
                        if (locationInfo == null)
                            locationInfo = cmbLocation.Text;
                        else
                        {
                            string[] loc = locationInfo.Split(',');
                            for (int i = 0; i < loc.Length; i++)
                            {
                                if (loc[i].ToLower() == cmbLocation.Text.ToLower())
                                {
                                    save = false;
                                    break;
                                }
                                else
                                    save = true;

                            }
                                if(save == true)
                                    locationInfo = !string.IsNullOrEmpty(locationInfo) ? locationInfo + ',' + cmbLocation.Text : cmbLocation.Text;
                        }
                        companyid = loginResult.companyId;
                        companyName = loginResult.companyName;
                        SaveAssetSystemInfo(loginResult.authenticationToken, loginResult.roles, loginResult.userId, loginResult.firstName + " " + loginResult.lastName/*txtUserName.Text.Trim()*/, readerInfo, companyName, locationInfo);


                        //check authorities    
                        if (loginResult.roles == "ROLE_SUPERADMIN")
                        {
                            this.Hide();
                            MainMenu MenuForm = new MainMenu(loginResult.authenticationToken, /*cmbComPort.Text,*/ loginResult.roles);
                            MenuForm.ShowDialog();
                        }
                        else if (loginResult.roles == "ROLE_ADMIN")
                        {
                            this.Hide();
                            MainMenu MenuForm = new MainMenu(loginResult.authenticationToken, /*cmbComPort.Text,*/ loginResult.roles);
                            MenuForm.ShowDialog();
                        }
                        else if (loginResult.roles == "ROLE_GUARD")
                        {
                            //TODO RFID SCAN CODE MISSING
                            this.Hide();
                            Verification verification = new Verification();//loginResult.authenticationToken, loginResult.roles);
                            verification.Show();
                        }
                        else if (loginResult.roles == "ROLE_USER")
                        {
                            this.Hide();
                            Assets asset = new Assets(/*loginResult.authenticationToken, loginResult.roles*/);
                            asset.Show();
                        }

                    }
                    else if (response.StatusCode == HttpStatusCode.NotFound)
                    {
                        MessageBox.Show("Error connecting to server.. please try again later");
                    }
                    else
                    {
                        HttpStatusCode statusCode = response.StatusCode;
                        int numericStatusCode = (int)statusCode;

                        if (numericStatusCode == 401)
                        {
                            txtPassword.Text = string.Empty;
                            txtPassword.Focus();
                            MessageBox.Show("Incorrect Username or Password, Please try again.");
                        }
                        else if (numericStatusCode == 500)
                        {
                            MessageBox.Show("Error connecting to server... please try again later");
                        }
                        else
                        {
                            MessageBox.Show("Error connecting to server... Please try again later");
                        }
                    }

                    //picLoading.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             
        }

        private void SaveAssetSystemInfo(string autoken, string roles, int userId, string loginid, string readerInfo, string companyName, string locationInfo)
        {
            try
            {
                //accessing the CurrentUser root element  
                //and adding "AssetSystemInfo" subkey to the "SOFTWARE" subkey  
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AssetSystemInfo");

                //storing the values  
                if (!string.IsNullOrEmpty(autoken)) key.SetValue("authenticationToken", autoken);
                if (!string.IsNullOrEmpty(roles)) key.SetValue("roles", roles);
                key.SetValue("companyId", companyid);
                key.SetValue("UserId", userId);
                key.SetValue("Language", selectLanguage.Text.ToString());
                key.SetValue("LocInfo", locationInfo);
                key.SetValue("companyName", companyName);
                if (!string.IsNullOrEmpty(loginid)) key.SetValue("UserName", loginid);
                if (!string.IsNullOrEmpty(loginid)) key.SetValue("readerInfo", readerInfo);
                key.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                {
                    //btnLogin_Click(sender, e);
                    btnLogin.PerformClick();
                }
          }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void cboCompanyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SaveAssetSystemInfo(string.Empty, string.Empty, cboCompanyList.Text.Trim(), string.Empty, string.Empty);
        }

        private void LoginActivity_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        private void ChangeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(LoginActivity));
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }
        private void selectLanguage_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //SaveAssetSystemInfo(string.Empty, string.Empty, 0,string.Empty, selectLanguage.Text.Trim());
            if (selectLanguage.SelectedItem.ToString() == "English")
            {
                ChangeLanguage("en");
            }
            else if (selectLanguage.SelectedItem.ToString() == "Japanese")
            {
                ResourceManager rm = new ResourceManager("RFID_FEATHER_ASSETS.Languages.login", Assembly.GetExecutingAssembly());
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("ja-JP");
                lblLogin.Text = rm.GetString("lblLogin");
                lblUsername.Text = rm.GetString("lblUsername");
                lblPassword.Text = rm.GetString("lblPassword");
                lblUserPasswordRequired.Text = rm.GetString("lblUserPasswordRequired");
                btnLogin.Text = rm.GetString("btnLogin");
                btnCancel.Text = rm.GetString("btnCancel");
                lblLanguage.Text = rm.GetString("lblLanguage");
                lblLoggingIn.Text = rm.GetString("lblSigningIn");
            }
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void cmbLocation_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbLocation.Text))
                lblLocation.Visible = true;
            else
                lblLocation.Visible = false;
        }
     }

    //Getters and Setters

    public class Location
    {
        public string location { get; set; }
        public string value { get; set; }
    }
    //public class LoginInfo
    //{
    //    public string email {get; set;}
    //    public string password {get; set;}
    //}

    //public class LoginResult
    //{
    //    public int companyId {get; set;}
    //    public string companyName {get; set;}
    //    public int userId {get; set;}
    //    public string firstName {get; set;}
    //    public string lastName{get; set;}
    //    public string authenticationToken {get; set;}
    //    public string roles {get; set;}
    //}
}
