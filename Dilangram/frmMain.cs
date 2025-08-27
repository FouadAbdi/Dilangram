using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Diagnostics;
using TL;
using Dilangram.Dialog;
using System.Globalization;
using System.IO;

namespace Dilangram
{
    public partial class frmMain : Form
    {
        private WTelegram.Client tgClient;
        private User currentUser;
        private bool isConnected = false;

        public frmMain()
        {
            InitializeComponent();
            WTelegram.Helpers.Log = (l, s) => Debug.WriteLine(s);
            InitializeUI();
        }

        private void InitializeUI()
        {
            // Initially disable buttons until connected
            btnChannels.Enabled = false;
            btnSendMessages.Enabled = false;
            btnJobs.Enabled = false;
            
            // Setup initial status
            UpdateConnectionStatus(false);
            LogMessage("🚀 Dilangram started. Ready to connect to Telegram.");
        }

        private void LogMessage(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(LogMessage), message);
                return;
            }
            
            string timestamp = DateTime.Now.ToString("HH:mm:ss");
            string logEntry = $"[{timestamp}] {message}";
            
            if (txtLogs.Text.Length > 0)
                txtLogs.AppendText(Environment.NewLine + logEntry);
            else
                txtLogs.Text = logEntry;
                
            txtLogs.SelectionStart = txtLogs.Text.Length;
            txtLogs.ScrollToCaret();
            
            // Update status bar
            statusLabel.Text = message.Replace("🚀", "").Replace("✅", "").Replace("❌", "").Replace("🔌", "").Trim();
        }

        private void UpdateConnectionStatus(bool connected)
        {
            isConnected = connected;
            
            if (connected)
            {
                lblConnectionStatus.Text = "🟢 Connected";
                lblConnectionStatus.ForeColor = Color.LightGreen;
                btnConnect.Text = "🔌 Disconnect";
                btnConnect.BackColor = Color.FromArgb(240, 71, 71);
                
                // Enable other buttons
                btnChannels.Enabled = true;
                btnSendMessages.Enabled = true;
                btnJobs.Enabled = true;
            }
            else
            {
                lblConnectionStatus.Text = "🔴 Disconnected";
                lblConnectionStatus.ForeColor = Color.LightCoral;
                btnConnect.Text = "🔌 Connect to Telegram";
                btnConnect.BackColor = Color.FromArgb(67, 181, 129);
                
                // Disable other buttons
                btnChannels.Enabled = false;
                btnSendMessages.Enabled = false;
                btnJobs.Enabled = false;
                
                lblUserInfo.Text = "Not logged in";
            }
        }

        static string Config(string what)
        {
            switch (what)
            {
                case "api_id": return "20833282";
                case "api_hash": return "6d4517a3e6c32f17e5ac2efe026039e2";

                case "phone_number":
                    new frmInputTextbox(what).ShowDialog();
                    return Program.InputTextDialog;

                case "verification_code":
                    new frmInputTextbox(what).ShowDialog();
                    return Program.InputTextDialog;

                case "first_name": return "John";      // if sign-up is required
                case "last_name": return "Doe";        // if sign-up is required

                case "password":
                    new frmInputTextbox(what).ShowDialog();
                    return Program.InputTextDialog;

                default: return null;                  // let WTelegramClient decide the default config
            }
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                await ConnectToTelegram();
            }
            else
            {
                DisconnectFromTelegram();
            }
        }

        private async Task ConnectToTelegram()
        {
            try
            {
                LogMessage("🔌 Connecting to Telegram...");
                btnConnect.Enabled = false;
                
                tgClient = new WTelegram.Client(Config);
                var user = await tgClient.LoginUserIfNeeded();
                
                if (user != null)
                {
                    currentUser = user;
                    LogMessage($"✅ Successfully connected as: {user.first_name} {user.last_name}");
                    lblUserInfo.Text = $"👤 {user.first_name} {user.last_name}";
                    
                    UpdateConnectionStatus(true);
                    
                    // Load user profile details
                    await LoadUserProfile();
                }
                else
                {
                    LogMessage("❌ Failed to connect to Telegram");
                    UpdateConnectionStatus(false);
                }
            }
            catch (Exception ex)
            {
                LogMessage($"❌ Connection error: {ex.Message}");
                UpdateConnectionStatus(false);
            }
            finally
            {
                btnConnect.Enabled = true;
            }
        }

        private void DisconnectFromTelegram()
        {
            try
            {
                LogMessage("🔌 Disconnecting from Telegram...");
                
                tgClient?.Dispose();
                tgClient = null;
                currentUser = null;
                
                UpdateConnectionStatus(false);
                LogMessage("✅ Disconnected from Telegram");
            }
            catch (Exception ex)
            {
                LogMessage($"❌ Disconnect error: {ex.Message}");
            }
        }

        private async Task LoadUserProfile()
        {
            try
            {
                LogMessage("📄 Loading user profile...");
                
                var users = await tgClient.Users_GetUsers(InputUser.Self);
                var loggedInUser = users[0] as User;
                
                if (loggedInUser != null)
                {
                    LogMessage($"📄 Profile loaded: ID {loggedInUser.id}, Username: @{loggedInUser.username ?? "N/A"}");
                }
            }
            catch (Exception ex)
            {
                LogMessage($"❌ Error loading profile: {ex.Message}");
            }
        }

        private void btnChannels_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Please connect to Telegram first!", "Not Connected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            LogMessage("📺 Opening Channel Management...");
            // TODO: Open channel management form
            MessageBox.Show("Channel Management feature will be implemented here.", "Feature", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSendMessages_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Please connect to Telegram first!", "Not Connected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            LogMessage("💬 Opening Message Sender...");
            // TODO: Open send messages form
            MessageBox.Show("Send Messages feature will be implemented here.", "Feature", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnJobs_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Please connect to Telegram first!", "Not Connected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            LogMessage("📋 Opening Job Management...");
            // TODO: Open job management form
            MessageBox.Show("Job Management feature will be implemented here.", "Feature", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void frmMain_Load(object sender, EventArgs e)
        {
            LogMessage("🚀 Application loaded successfully");
            LogMessage("ℹ️  Click 'Connect to Telegram' to start using the application");
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            LogMessage("🔄 Shutting down...");
            tgClient?.Dispose();
        }
    }
}
