using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Net;
using System.Net.Http.Json;

namespace downImg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        label3.Text = "Đang tải.......";
        //        SaveFileDialog save = new SaveFileDialog();
        //        save.Filter = "All Files|*.*";
        //        if (save.ShowDialog() == DialogResult.OK)
        //        {
        //            // Thiết lập ChromeDriverService và ChromeOptions
        //            var service = ChromeDriverService.CreateDefaultService();
        //            service.HideCommandPromptWindow = true;

        //            ChromeOptions options = new ChromeOptions();
        //            options.AddArgument("user-agent=Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/92.0.4515.107 Safari/537.36");
        //            options.AddArgument("--disable-infobars");
        //            options.AddArgument("--disable-gpu");
        //            options.AddArgument("--no-sandbox");
        //            options.AddArgument("--disable-dev-shm-usage");
        //            options.AddArgument("--disable-blink-features");
        //            options.AddArgument("--disable-blink-features=AutomationControlled");
        //            options.AddArgument("--window-size=1920,1080");


        //            TimeSpan timeout = TimeSpan.FromSeconds(120); // Tăng thời gian chờ
        //            using (ChromeDriver driver = new ChromeDriver(service, options, timeout))
        //            {
        //                int a = 0;
        //                string basePath = save.FileName;

        //                // Tạo thư mục lưu ảnh nếu chưa tồn tại
        //                if (!Directory.Exists(basePath))
        //                {
        //                    Directory.CreateDirectory(basePath);
        //                }

        //                // Vòng lặp để tải ảnh từ các chương theo URL
        //                for (int i = int.Parse(numericUpDown1.Value.ToString()); i <= int.Parse(numericUpDown2.Value.ToString()); i++)
        //                {

        //                    driver.Navigate().GoToUrl(textBox1.Text + $"/chuong-{i}");

        //                    var imgElements = driver.FindElements(By.TagName("img"));

        //                    string chapterPath = $@"{basePath}\chapter {a + 1}";

        //                    // Tạo thư mục chapter nếu chưa tồn tại
        //                    if (!Directory.Exists(chapterPath))
        //                    {
        //                        Directory.CreateDirectory(chapterPath);
        //                    }

        //                    // Tải từng ảnh trong chapter
        //                    for (int k = 0; k < imgElements.Count; k++)
        //                    {
        //                        var imgPageChapter = imgElements[k];
        //                        var imgUrl = imgPageChapter.GetAttribute("src");
        //                        var imgName = imgPageChapter.GetAttribute("alt") ?? $"image{k + 1}";

        //                        // Tải ảnh với kiểm tra lỗi
        //                        try
        //                        {
        //                            using (WebClient client = new WebClient())
        //                            {
        //                                client.DownloadFile(new Uri(imgUrl), $@"{chapterPath}\{imgName}.png");
        //                            }
        //                        }
        //                        catch (Exception imgEx)
        //                        {
        //                            MessageBox.Show($"Lỗi khi tải ảnh {imgName}: {imgEx.Message}");
        //                        }
        //                    }
        //                    a++;
        //                }
        //                driver.Quit();
        //            }
        //            label3.Text = "Tải hoàn tất!";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //    MessageBox.Show("Tải hoàn tất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}
        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ChromeDriver driver = new ChromeDriver();
                for (int i = int.Parse(numericUpDown1.Value.ToString()); i <= int.Parse(numericUpDown1.Value.ToString()); i++)
                {
                    driver.Navigate().GoToUrl(textBox1.Text);
                    var find = driver.FindElements(By.ClassName(""));
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
