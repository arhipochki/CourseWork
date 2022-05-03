using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CourseWork
{
    public partial class Form1 : Form
    {
        CalculateModule calculateModule = new CalculateModule();
        FilesModule filesModule = new FilesModule();
        SettingsModule settingsModule = new SettingsModule();

        public Form1()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            InitializeComponent();

            // Загружаем настройки
            string settings = settingsModule.LoadSettings();

            if (settings != null)
            {
                var options = settings.Split('\n');

                foreach (var option in options)
                {
                    var value = option.Split('=');
                    if (value[0] == "grid" && value[1] == "True")
                        this.gridCheckBox.Checked = true;
                    else if (value[0] == "saveSeries" && value[1] == "True")
                        this.saveSeriesCheckBox.Checked = true;
                }
            }

            // Выставляем форматирование по X до 2-го знака после запятой
            this.solveChart.ChartAreas[0].AxisX.LabelStyle.Format = "0.00";
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (this.funcTextBox.Text != "" && this.x0TextBox.Text != "" && this.x1TextBox.Text != "" && this.epsTextBox.Text != "" && this.legendTextBox.Text != "")
            {
                if (!this.saveSeriesCheckBox.Checked)
                    this.solveChart.Series.Clear();

                // Получаем функцию и значения для работы метода Секущих
                calculateModule.Function = this.funcTextBox.Text;
                try
                {
                    double[] vecX0 = { Convert.ToDouble(this.x0TextBox.Text), Convert.ToDouble(this.x1TextBox.Text) };
                    double eps = Convert.ToDouble(this.epsTextBox.Text);

                    // Выставляем путь
                    filesModule.Path = this.pathLabel.Text;

                    // Создаём новую серию данных
                    Series series = new Series($"{this.legendTextBox.Text}");
                    series.ChartType = SeriesChartType.Point;
                    series.MarkerSize = 8;

                    calculateModule.NewtomMethod(vecX0, eps, this.solveChart, series, filesModule);

                    // Выставляем отдельно минимум и максимум оси Y (можно выставить только минимум, только максимум или вместе)
                    if (this.y0TextBox.Text != "")
                        this.solveChart.ChartAreas[0].AxisY.Minimum = Convert.ToDouble(this.y0TextBox.Text);

                    if (this.y1TextBox.Text != "")
                        this.solveChart.ChartAreas[0].AxisY.Maximum = Convert.ToDouble(this.y1TextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Ошибка: проверьте поля X0, X1, Y0, Y1, eps. Там должны быть только числа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ошибка: проверьте поля ввода!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Выставляем сетку, если выбрали
            if (this.gridCheckBox.Checked)
            {
                this.solveChart.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
                this.solveChart.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            }
            else
            {
                this.solveChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                this.solveChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            }
        }

        private void getPathBtn_Click(object sender, EventArgs e)
        {
            // Выбираем путь, куда сохранить файлы
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.pathLabel.Text = dialog.SelectedPath;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Сохраняем файлы по закрытии формы
            settingsModule.SaveSettings($"grid={this.gridCheckBox.Checked}\nsaveSeries={this.saveSeriesCheckBox.Checked}");
        }
    }
}
