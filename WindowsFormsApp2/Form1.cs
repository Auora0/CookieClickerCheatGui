using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Web;
using CefSharp.WinForms;
using CefSharp;
using System.Diagnostics.Eventing.Reader;


namespace WindowsFormsApp2
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            InitBrowser();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange800, Primary.Orange900, Primary.Orange500, Accent.Orange200, TextShade.WHITE);
        }

        public ChromiumWebBrowser browser;

        public void InitBrowser()
        {
            Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser("https://orteil.dashnet.org/cookieclicker/");
            chromiumWebBrowser1.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Currency.Show(Cursor.Position);
        }

        private void cookiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            materialLabel2.Text = "cookies";
            Multi(sender, e);
            materialTextBox2.Text = "Game." + materialLabel2.Text + "=" + Convert.ToString(this.Save.Text);
        }

        private void lumpsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            materialLabel2.Text = "lumps";
            Multi(sender, e);
            materialTextBox2.Text = "Game." + materialLabel2.Text + "=" + Convert.ToString(this.Save.Text);
        }

        private void heavenlyChipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            materialLabel2.Text = "heavenlyChips";
            Multi(sender, e);
            materialTextBox2.Text = "Game." + materialLabel2.Text + "=" + Convert.ToString(this.Save.Text);
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            Stacked.Show(Cursor.Position);
        }

        private void Multi(object sender, EventArgs e)
        {
                
                if (this.materialLabel3.Text == "None")
            {
                    double Amount = Convert.ToDouble(materialTextBox1.Text);
                    Amount *= 1;
                    this.Save.Text = Convert.ToString(Amount);
                }
            else if (this.materialLabel3.Text == "K")
            {
                    double Amount = Convert.ToDouble(materialTextBox1.Text);
                    Amount *= 1000;
                    this.Save.Text = Convert.ToString(Amount);
                }
            else if (this.materialLabel3.Text == "M")
            {
                    double Amount = Convert.ToDouble(materialTextBox1.Text);
                    Amount *= 1000000;
                    this.Save.Text = Convert.ToString(Amount);
                }
            else if (this.materialLabel3.Text == "B")
            {
                    double Amount = Convert.ToDouble(materialTextBox1.Text);
                    Amount *= 1000000000;
                    this.Save.Text = Convert.ToString(Amount);
                }
            else if (this.materialLabel3.Text == "T")
            {
                    double Amount = Convert.ToDouble(materialTextBox1.Text);
                    Amount *= 1000000000000;
                    this.Save.Text = Convert.ToString(Amount);
                }
            else if (this.materialLabel3.Text == "Qa")
            {
                    double Amount = Convert.ToDouble(materialTextBox1.Text);
                    Amount *= 1000000000000000;
                    this.Save.Text = Convert.ToString(Amount);
                }
            else if (this.materialLabel3.Text == "Qd")
            {
                    double Amount = Convert.ToDouble(materialTextBox1.Text);
                    Amount *= 1000000000000000000;
                    this.Save.Text = Convert.ToString(Amount);
                }
        }

        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.materialLabel3.Text = "None";
            Multi(sender, e);
            materialTextBox2.Text = "Game." + materialLabel2.Text + "=" + Convert.ToString(this.Save.Text);
        }

        private void kToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.materialLabel3.Text = "K";
            Multi(sender, e);
            materialTextBox2.Text = "Game." + materialLabel2.Text + "=" + Convert.ToString(this.Save.Text);
        }

        private void mToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.materialLabel3.Text = "M";
            Multi(sender, e);
            materialTextBox2.Text = "Game." + materialLabel2.Text + "=" + Convert.ToString(this.Save.Text);
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.materialLabel3.Text = "B";
            Multi(sender, e);
            materialTextBox2.Text = "Game." + materialLabel2.Text + "=" + Convert.ToString(this.Save.Text);
        }

        private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.materialLabel3.Text = "T";
            Multi(sender, e);
            materialTextBox2.Text = "Game." + materialLabel2.Text + "=" + Convert.ToString(this.Save.Text);
        }

        private void qaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.materialLabel3.Text = "Qa";
            Multi(sender, e);
            materialTextBox2.Text = "Game." + materialLabel2.Text + "=" + Convert.ToString(this.Save.Text);
        }

        private void qdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.materialLabel3.Text = "Qd";
            Multi(sender, e);
            materialTextBox2.Text = "Game." + materialLabel2.Text + "=" + Convert.ToString(this.Save.Text);
        }

        private void chromiumWebBrowser1_LoadingStateChanged(object sender, CefSharp.LoadingStateChangedEventArgs e)
        {
            
        }

        private void chromiumWebBrowser1_LoadingStateChanged_1(object sender, CefSharp.LoadingStateChangedEventArgs e)
        {

        }

        private void Execute_Click(object sender, EventArgs e)
        {
            
            var script = Convert.ToString(materialTextBox2.Text) + ";"; // Replace with your JavaScript command
            browser.ExecuteScriptAsync(script);
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.materialTextBox1.Text == string.Empty)
            {
                materialTextBox1.Text = "1";
            }
            else
            {
                Multi(sender, e);
                materialTextBox2.Text = "Game." + materialLabel2.Text + "=" + Convert.ToString(this.Save.Text);
            }
        }

        private void materialTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            var script = "var autoclicker = setInterval(function(){\r\n  try {\r\n    Game.lastClick -= 1000;\r\n    document.getElementById('bigCookie').click();\r\n  } catch (err) {\r\n    console.error('Stopping auto clicker');\r\n    clearInterval(autoclicker);\r\n  }\r\n}, 1);"; 
            browser.ExecuteScriptAsync(script);
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            var script = "clearInterval(autoclicker);";
            browser.ExecuteScriptAsync(script);
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            var script = "var newShimmer=new Game.shimmer(\"golden\");";
            browser.ExecuteScriptAsync(script);
        }

        private void materialButton6_Click(object sender, EventArgs e)
        {
            var script = "var newShimmer=new Game.shimmer(\"reindeer\");";
            browser.ExecuteScriptAsync(script);

        }

        private void materialButton7_Click(object sender, EventArgs e)
        {
            var script = "var autoGoldenCookie = setInterval(function() { for (var h in Game.shimmers){if(Game.shimmers[h].type==\"golden\"){Game.shimmers[h].pop();}} }, 1000);";
            browser.ExecuteScriptAsync(script);
        }

        private void materialButton8_Click(object sender, EventArgs e)
        {
            var script = "clearInterval(autoGoldenCookie);";
            browser.ExecuteScriptAsync(script);
        }

        private void materialButton9_Click(object sender, EventArgs e)
        {
            var script = "var autoRaeindeer = setInterval(function() { for (var h in Game.shimmers){if(Game.shimmers[h].type==\"reindeer\"){Game.shimmers[h].pop();}} }, 1000);";
            browser.ExecuteScriptAsync(script);
        }

        private void materialButton10_Click(object sender, EventArgs e)
        {
            var script = "clearInterval(autoRaeindeer);";
            browser.ExecuteScriptAsync(script);
        }

        private void materialButton11_Click(object sender, EventArgs e)
        {
            var script = "Game.popups = 0;\r\nGame.SetAllUpgrades(1);\r\nGame.SetAllAchievs(1);\r\nGame.popups = 0;\r\nGame.cookies=1E+302\r\nGame.MaxSpecials();\r\nGame.nextResearch = 0;\r\nGame.researchT = -1;\r\nGame.upgradesToRebuild = 1;\r\nGame.recalculateGains = 1;\r\nGame.popups = 1;";
            browser.ExecuteScriptAsync(script);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton12_Click(object sender, EventArgs e)
        {
            var script = "  Game.cookies=0;\r\n          Game.AchievementsOwned = 0;\r\n            Game.goldenClicks = 0;\r\n            Game.missedGoldenClicks = 0;\r\n            Game.Reset(1);\r\n            Game.resets = 0;\r\n            Game.fullDate = parseInt(Date.now());\r\n            Game.bakeryName = Game.GetBakeryName();\r\n            Game.bakeryNameRefresh();\r\n            Game.cookiesReset = 0;\r\n            Game.prestige = 0;\r\n            Game.heavenlyChips = 0;\r\n            Game.heavenlyChipsSpent = 0;\r\n            Game.heavenlyCookies = 0;\r\n            Game.permanentUpgrades = [-1, -1, -1, -1, -1];\r\n            Game.ascensionMode = 0;\r\n            Game.lumps = -1;\r\n            Game.lumpsTotal = -1;\r\n            Game.lumpT = Date.now();\r\n            Game.lumpRefill = 0;\r\n            Game.removeClass('lumpsOn');";
            browser.ExecuteScriptAsync(script);
        }
    }
    }
