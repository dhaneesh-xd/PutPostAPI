using System;
using System.Windows.Forms;

namespace PutPostAPI
{
    public partial class PutPostAPIMainForm : Form
    {
        private readonly HttpClientMethods httpClientMethods;

        public PutPostAPIMainForm()
        {
            httpClientMethods = new HttpClientMethods();
            InitializeComponent();
        }

        private async void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                string method = null;
                if (getRadioBtn.Checked)
                {
                    method = "GET";
                }
                else if (postRadiobtn.Checked)
                {
                    method = "POST";
                }
                else if (putRadioBtn.Checked)
                {
                    method = "PUT";
                }
                else 
                {
                    method = "DELETE";
                }
                string result = await httpClientMethods.SendRequestAsync(method, urlTextBox.Text, jsonTextBox.Text);
                resultTextBox.Text = result;
            }
            catch (Exception ex)
            { 
                resultTextBox.Text = ex.Message;
            }
        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (getRadioBtn.Checked || deleteRadioBtn.Checked)
            {
                jsonTextBox.Enabled = false;
            }
            else
            {
                jsonTextBox.Enabled = true;
            }
        }
    }
}
