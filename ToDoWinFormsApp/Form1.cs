namespace ToDoWinFormsApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e) {
            using (StreamWriter sw = new StreamWriter("tasks.txt")) {
                foreach (string task in lstTasks.Items) {
                    sw.WriteLine(task);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            string newTask = txtTask.Text;
            if (!string.IsNullOrWhiteSpace(newTask)) {
                lstTasks.Items.Add(newTask);
                txtTask.Text = "";
            }
        }

        private void btnDeleteTask_Click(object sender, EventArgs e) {
            if (lstTasks.SelectedIndex != -1) {
                lstTasks.Items.RemoveAt(lstTasks.SelectedIndex);
            }
        }
    }
}