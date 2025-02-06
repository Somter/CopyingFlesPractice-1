namespace CopyingFlesPractice_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button3.Enabled = false;
            progressBar1.Minimum = 0;
            progressBar1.Step = 1;
        }

        private void ChooseFile(TextBox textBox)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Выберите файл";
                openFileDialog.Filter = "Все файлы (*.*)|*.*";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox.Text = openFileDialog.FileName;
                    CheckFields();
                }
            }
        }

        private void ChooseFolder(TextBox textBox)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Выберите папку для сохранения";

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox.Text = folderDialog.SelectedPath;
                    CheckFields();
                }
            }
        }

        private void CopyingFiles()
        {
            string sourcePath = textBox1.Text;
            string destinationPath = Path.Combine(textBox2.Text, Path.GetFileName(sourcePath));

            try
            {
                using (FileStream sourceStream = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
                using (FileStream destinationStream = new FileStream(destinationPath, FileMode.Create, FileAccess.Write))
                {
                    byte[] buffer = new byte[4096];
                    int bytesRead;
                    long totalBytes = sourceStream.Length;
                    long copiedBytes = 0;

                    progressBar1.Invoke(new Action(() =>
                    {
                        progressBar1.Maximum = (int)(totalBytes / buffer.Length);
                        progressBar1.Value = 0;
                    }));

                    while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        destinationStream.Write(buffer, 0, bytesRead);
                        copiedBytes += bytesRead;

                        progressBar1.Invoke(new Action(() =>
                        {
                            progressBar1.Value = (int)(copiedBytes / buffer.Length);
                        }));
                    }
                }

                MessageBox.Show("Копирование завершено!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при копировании файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckFields()
        {
            button3.Enabled = !string.IsNullOrWhiteSpace(textBox1.Text) &&
                              !string.IsNullOrWhiteSpace(textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChooseFile(textBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChooseFolder(textBox2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Task copyingTask = new Task(CopyingFiles);
            copyingTask.Start();
        }
    }
}
