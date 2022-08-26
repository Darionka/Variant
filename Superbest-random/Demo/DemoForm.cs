using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Demo
{
    public partial class DemoForm : Form
    {

        public static int N;
        static public double ssigma = 1d;
        static public double mu = 0d;
        static public double ssigma2 = 1d;
        static public double mu2 = 0d;
        double[] a;
        double[] b;
        public DemoForm()
        {
            InitializeComponent();
            demo_picker.SelectedItem = demo_picker.Items[0];

        }
        
        private void DemoRequested(object sender, EventArgs e)
        {
            demo_picker.Enabled = false;
            btn_execute.Enabled = false;

            var i = demo_picker.SelectedItem;
            var s = (string)i;

            if (s == "Нормальное распределение") GaussianDistributionDemo();
            else if (s == "Матожидание, дисперсия и СКО") MathWaitSolve();
            else if (s == "Полная вероятность") FullPropabilitySolve();
            else
            {
                MessageBox.Show("Выбери чонить");
                demo_picker.Enabled = true;
                btn_execute.Enabled = true;
            }
        }

        private void FullPropabilitySolve()
        {
            for (int i = 0; i < N; i++)
            {
                a[i] = double.Parse(dataGridView1.Rows[0].Cells[i].Value.ToString());
                b[i] = double.Parse(dataGridView1.Rows[1].Cells[i].Value.ToString());
            }

            demo_picker.Enabled = true;
            btn_execute.Enabled = true;
            FullPropabilityRes.Text = MathWaiting.MX(a, b).ToString();
        }

        private void GaussianDistributionDemo()
        {
            
            var n_bins = 1000;

            if (Double.TryParse(sigma.Text, out double sig)) { ssigma = sig; } else { MessageBox.Show("Введите нормальные значения"); }
            if (Double.TryParse(Waiting.Text, out double m)) { mu = m; } else { MessageBox.Show("Введите нормальные значения"); }
            if (Double.TryParse(sigma2.Text, out double sig2)) { ssigma2 = sig2; } else { MessageBox.Show("Введите нормальные значения"); }
            if (Double.TryParse(Waiting2.Text, out double m2)) { mu2 = m2; } else { MessageBox.Show("Введите нормальные значения"); }
            try
            {
                var f = new Series("Histogram");
                var f2 = new Series("Histogram2");

                graph.Series.Clear();
                graph.Series.Add(f);
                graph.Series.Add(f2);
                graph.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
                graph.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
                
                graph.ChartAreas[0].AxisX.Minimum = mu - 3 * ssigma;
                graph.ChartAreas[0].AxisX.Title = "Значение";
                graph.ChartAreas[0].AxisY.Title = "Плотность Вероятности";

                graph.ChartAreas[0].AxisX.LabelStyle.Interval = 0;
                //graph.ChartAreas[0].AxisX.LabelStyle.Format = "{0:0.##}";
                graph.Legends.Clear();

                for (var i = 0; i < n_bins; i++)
                {
                    var x = (i * 2d / n_bins - 1) * 3 * ssigma + mu; 
                    var y = Gaussian_distribution.f(x);
                    f.Points.AddXY(x, y);
                }
                for (var i = 0; i < n_bins; i++)
                {
                    var x = (i * 2d / n_bins - 1) * 3 * ssigma2 + mu2;
                    var y = Gaussian_distribution.f2(x);
                    f2.Points.AddXY(x, y);
                }
            }
            catch (IndexOutOfRangeException) { };
            demo_picker.Enabled = true;
            btn_execute.Enabled = true;
        }
        private void MathWaitSolve()
        {
            for (int i = 0; i < N; i++)
            {
                a[i] = double.Parse(dataGridView1.Rows[0].Cells[i].Value.ToString());
                b[i] = double.Parse(dataGridView1.Rows[1].Cells[i].Value.ToString());
            }

            demo_picker.Enabled = true;
            btn_execute.Enabled = true;
            Result.Text = MathWaiting.MX(a, b).ToString();
            DispersionResult.Text = MathWaiting.DX(a, b).ToString();
            NQDResult.Text = Math.Sqrt(MathWaiting.DX(a, b)).ToString();
        }

        private void demo_picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = demo_picker.SelectedItem;
            var s = (string)i;
            if (s == "Нормальное распределение") { 
                graph.Show(); 
                sigma.Show(); 
                Waiting.Show(); 
                DeviationListElement.Hide(); 
                dataGridView1.Hide();
                button1.Hide();
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                sigma2.Show();
                Waiting2.Show();
                pictureBox1.Show();
                pictureBox2.Show();
                color1.Show();
                color3.Show();
                Result.Hide();
                NQDResult.Hide();
                DispersionResult.Hide();
                pictureBox1_1.Hide();
                pictureBox1_3.Hide();
                pictureBox1_2.Hide();
                labelFor2_1.Hide();
                LabelFor2.Hide();
                labelFor2_2.Hide();
                FullPropabilityRes.Hide();
                FullPropMainDesc.Hide();
                FullPropPicFormula.Hide();
                FullPropTitle.Hide();
            }
            else if (s == "Матожидание, дисперсия и СКО") { 
                graph.Hide(); 
                sigma.Hide(); 
                Waiting.Hide();
                DeviationListElement.Show(); 
                dataGridView1.Show();
                button1.Show();
                label1.Hide();
                label2.Hide();
                label3.Hide();
                label4.Hide();
                sigma2.Hide();
                Waiting2.Hide();
                pictureBox1.Hide();
                pictureBox2.Hide();
                color1.Hide();
                color3.Hide();
                Result.Show();
                NQDResult.Show();
                DispersionResult.Show();
                pictureBox1_1.Show();
                pictureBox1_3.Show();
                pictureBox1_2.Show();
                labelFor2_1.Show();
                LabelFor2.Show();
                labelFor2_2.Show();
                FullPropabilityRes.Hide();
                FullPropMainDesc.Hide();
                FullPropPicFormula.Hide();
                FullPropTitle.Hide();
            }
            else if(s == "Полная вероятность")
            {
                graph.Hide();
                sigma.Hide();
                Waiting.Hide();
                DeviationListElement.Show();
                dataGridView1.Show();
                button1.Show();
                label1.Hide();
                label2.Hide();
                label3.Hide();
                label4.Hide();
                sigma2.Hide();
                Waiting2.Hide();
                pictureBox1.Hide();
                pictureBox2.Hide();
                color1.Hide();
                color3.Hide();
                Result.Hide();
                NQDResult.Hide();
                DispersionResult.Hide();
                pictureBox1_1.Hide();
                pictureBox1_3.Hide();
                pictureBox1_2.Hide();
                labelFor2_1.Hide();
                LabelFor2.Hide();
                labelFor2_2.Hide();
                FullPropabilityRes.Show();
                FullPropMainDesc.Show();
                FullPropPicFormula.Show();
                FullPropTitle.Show();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        { 
            N = int.Parse(DeviationListElement.Text);
            a = new double[N];
            b = new double[N];
            var ii = demo_picker.SelectedItem;
            var s = (string)ii;
            Random rand = new Random();
            dataGridView1.Rows.Clear();
            dataGridView1.RowCount = 2;
            dataGridView1.ColumnCount = N + 1;
            if (s == "Матожидание, дисперсия и СКО")
            {
                
                dataGridView1.Rows[0].Cells[N].Value = "Значение x";
                dataGridView1.Rows[1].Cells[N].Value = "Значение p";

                for (int i = 0; i < N; i++)
                {
                    try
                    {
                        a[i] = rand.Next(0, 10);
                        dataGridView1.Rows[0].Cells[i].Value = a[i];
                    }
                    catch (IndexOutOfRangeException) { break; }
                }
            }
            else if(s == "Полная вероятность")
            {
                dataGridView1.Rows[0].Cells[N].Value = "Значение P(Bi)";
                dataGridView1.Rows[1].Cells[N].Value = "Значение p(Bi|A)";
            }
        }
    }
}
