using System.Drawing;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private int resolution;
        private bool[,] field;
        private int rows;
        private int columns;
        private int generations;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Generations: 0";
        }
        private void startSimulation()
        {
            if (timer1.Enabled) return;

            numDensity.Enabled = false;
            numResolution.Enabled = false;

            resolution = (int)numResolution.Value;
            rows = pictureBox1.Height / resolution;
            columns = pictureBox1.Width / resolution;
            field = new bool[columns, rows];

            Random random = new Random();
            for (int x = 0; x < columns; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    field[x, y] = random.Next((int)numDensity.Value) == 0;
                }
            }

            pictureBox1.Image = new Bitmap(pictureBox1.Height, pictureBox1.Width);
            graphics = Graphics.FromImage(pictureBox1.Image);
            timer1.Start();
        }
        private void stopSimulation()
        {
            if (!timer1.Enabled) return;
            timer1.Stop();
            numDensity.Enabled = true;
            numResolution.Enabled = true;
        }
        private void nextGeneration()
        {
            graphics.Clear(Color.Black);
            var newField = new bool[columns, rows];
            for (int x = 0; x < columns; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    var neighborsCount = countNeighbors(x, y);
                    var hasLife = field[x, y];
                    if (!hasLife && neighborsCount == 3)
                        newField[x, y] = true;
                    else if (hasLife && (neighborsCount < 2 || neighborsCount > 3))
                        newField[x, y] = false;
                    else
                        newField[x, y] = field[x, y];
                    if (hasLife)
                        graphics.FillRectangle(Brushes.OrangeRed, x * resolution,
                            y * resolution, resolution, resolution);
                }
            }
            field = newField;
            pictureBox1.Refresh();
            generations++;
            this.Text = "Generations: " + generations.ToString();
        }
        private int countNeighbors(int x, int y)
        {
            int count = 0;
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    var col = (x + i + columns) % columns;
                    var row = (y + j + rows) % rows;

                    var isSelfChecking = col == x && row == y;
                    var hasLife = field[col, row];

                    if (hasLife && !isSelfChecking)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            startSimulation();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nextGeneration();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stopSimulation();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!timer1.Enabled) return;
            if (e.Button == MouseButtons.Left)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                bool validation = validateMousePosition(x, y);
                if (validation)
                    field[x, y] = true;
            }
            if (e.Button == MouseButtons.Right)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                bool validation = validateMousePosition(x, y);
                if (validation)
                    field[x, y] = false;
            }
        }
        private bool validateMousePosition(int x, int y)
        {
            return x >= 0 && y >= 0 && x < columns && y < rows;
        }
    }
}
