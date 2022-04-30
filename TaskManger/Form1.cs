using System.Diagnostics;

namespace TaskManger
{
    public partial class SimpleTaskManger : Form
    {
        public SimpleTaskManger()
        {
            InitializeComponent();
        }
        Process[] proc;
        void GetAllProcess()
        {
            proc = Process.GetProcesses();
            listBox1.Items.Clear();
            foreach (Process p in proc)
            {
                listBox1.Items.Add(p.ProcessName);

            }
        }

        private void End_Click(object sender, EventArgs e)
        {
            try
            {
                proc[listBox1.SelectedIndex].Kill();
                GetAllProcess();

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllProcess();
        }

        private void runNewFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(RunTaskForm form= new RunTaskForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                    GetAllProcess();
            }
        }
    }
}