using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebCrawler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_start_Click(object sender, EventArgs e)
        {
            using (IWebDriver driver = new ChromeDriver()) {
                driver.Url = "https://www.naver.com";
                driver.Manage().Window.Maximize();
                Thread.Sleep(500);
                List<WebElement> temp = new List<WebElement>();
                temp.Add((WebElement)driver.FindElement(By.Id("NM_FAVORITE")));
                Console.WriteLine("TEST");
                Console.WriteLine("temp[0] : "+temp[0].GetDomProperty("value"));

            }
        }
    }
}
