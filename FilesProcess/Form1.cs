namespace FilesProcess
{
    public partial class Form1 : Form
    {
        public Thread CopiedThread { get; set; }
        public bool IsSuspended { get; set; }
        public bool IsAborted { get; set; }
        public Form1()
        {
            InitializeComponent();
        }
        private void CopyFile(string sourceFilePath, string destinationFilePath)
        {
            try
            {
                using (FileStream sourceStream = new FileStream(sourceFilePath, FileMode.Open))
                {
                    using (FileStream destinationStream = new FileStream(destinationFilePath, FileMode.Create))
                    {
                        byte[] buffer = new byte[1024];
                        int bytesRead;
                        long totalBytesRead = 0;
                        long totalBytes = sourceStream.Length;

                        while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            if (IsSuspended) {
                                Thread.Sleep(100);
                                continue;
                            }
                            if (IsAborted) {
                                IsAborted = !IsAborted;
                                return;
                            }
                            destinationStream.Write(buffer, 0, bytesRead);
                            totalBytesRead += bytesRead;
                            int progress = (int)(((double)totalBytesRead / totalBytes) * 100);
                            SetProgressBarValue(progress);
                            Thread.Sleep(5000);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SetProgressBarValue(int value)
        {
            if (progressBar1.InvokeRequired) progressBar1.Invoke(new Action<int>(SetProgressBarValue), value);
            else progressBar1.Value = value;
        }



        private void FromButton_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                FromTextBox.Text = selectedFilePath;
            }
        }

        private void ToButton_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                ToTextBox.Text = selectedFilePath;
            }
        }

        private void SuspendButton_Click_1(object sender, EventArgs e)
        {
            if (CopiedThread != null && CopiedThread.ThreadState == ThreadState.Running) CopiedThread.Suspend();

        }

        private void ResumeButton_Click_1(object sender, EventArgs e)
        {
            if (CopiedThread != null && CopiedThread.ThreadState == ThreadState.Suspended) CopiedThread.Resume();

        }

        private void AbortButton_Click_1(object sender, EventArgs e)
        {
            if (CopiedThread != null && CopiedThread.ThreadState != ThreadState.Stopped) CopiedThread.Abort();

        }

        private void CopyButton_Click_1(object sender, EventArgs e)
        {
            string filePath = FromTextBox.Text;
            string destionationPath = ToTextBox.Text;
            if (!string.IsNullOrEmpty(filePath) && !string.IsNullOrEmpty(destionationPath))
            {
                CopiedThread = new Thread(() => CopyFile(filePath, destionationPath));
                CopiedThread.Start();
            }
        }
    }
}