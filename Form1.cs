namespace WinFormApp_2
{
    public partial class Form1 : Form
    {
        Menu menu;
        public Form1()
        {
            InitializeComponent();
            menu = new Menu();
        }

        private void Load_Window(object sender, EventArgs e)
        {
            menu.Items.Add(new MenuItem("����", 0, 57.50));
            menu.Items.Add(new MenuItem("����", 0, 35.00));
            menu.Items.Add(new MenuItem("�������", 0, 45.00));
            menu.Items.Add(new MenuItem("���", 0, 65.00));
            menu.Items.Add(new MenuItem("�����", 0, 55.00));

            menu.Items.Add(new MenuItem("���� ������", 0, 73.50));
            menu.Items.Add(new MenuItem("������� ����", 0, 23.00));
            menu.Items.Add(new MenuItem("��������", 0, 22.00));
            menu.Items.Add(new MenuItem("�����", 0, 28.00));
            menu.Items.Add(new MenuItem("��������� ����", 0, 34.00));
        }

        private void LateChange(object sender, EventArgs e)
        {
            if (cbLate.Checked)
            {
                Count_Late.Enabled = true;
            }
            else
            {
                Count_Late.Enabled = false;
            }
        }

        private void Count_Late_Value_Change(object sender, EventArgs e)
        {
            string mes = (sender as NumericUpDown).Name;
            MessageBox.Show(mes);
            if (Count_Late.Value > 0)
            {
                Late_Price.Enabled = true;
                menu.Items[0].SetCount(Convert.ToInt32(Count_Late.Value));
                Late_Price.Text = menu.Items[0].PriceAll.ToString() + " ���";
            }
            else
            {
                Late_Price.Clear();
                Late_Price.Enabled = false;
            }
        }
    }
}