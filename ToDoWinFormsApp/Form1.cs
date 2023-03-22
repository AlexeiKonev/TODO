namespace ToDoWinFormsApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            string newTask = txtTask.Text;
            if (!string.IsNullOrWhiteSpace(newTask)) {
                lstTasks.Items.Add(newTask);
                txtTask.Text = "";
            }
        }
    }
}