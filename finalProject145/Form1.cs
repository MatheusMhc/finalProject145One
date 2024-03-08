using SortingAlgorithm.SortingAlgorithms;

namespace finalProject145
{
    public partial class Form1 : Form
    {
        int[] nois = new int[30];
        TableLayoutPanel a;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < nois.Length; i++)
            {
                Random random = new Random();
                nois[i] = random.Next(0, 100);
            }

            a = createTable(nois.Length);
            for (int i = 0; i < nois.Length; i++)
            {
                Label label = new Label();
                label.Size = new Size(this.ClientSize.Width / nois.Length, 50);
                label.Text = nois[i].ToString();
                label.TextAlign = ContentAlignment.MiddleCenter;
                a.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0F));
                a.Controls.Add(label, i, 0);
            }


        }

        private TableLayoutPanel createTable(int col)
        {
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Location = new Point(1, this.ClientSize.Height / 2);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.TabIndex = 0;
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.ColumnCount = col;
            tableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            this.Controls.Add(tableLayoutPanel);

            return tableLayoutPanel;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SelectionSort selectionSort = new SelectionSort();
            selectionSort.sort(a);
        }
    }
}