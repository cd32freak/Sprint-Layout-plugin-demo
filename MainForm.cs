using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SprintLayoutPluginDemo
{
    public partial class MainForm : Form
    {
        // Dictionary to store descriptions for automatic groundplane values
        private Dictionary<int, string> automaticGroundplaneDescriptions = new Dictionary<int, string>();

        // Flag to track whether the "/A" parameter was encountered
        private bool isBoardTransferred = false; // Track whether "/A" was encountered

        // Default exit code is 0 (Abort / no action)
        private int exitCode = 0; // Default exit code is 0 (Abort / no action)

        // Constructor with command line arguments
        public MainForm(string[] args)
        {
            InitializeComponent();

            // Initialize the dictionary with descriptions
            InitializeDescriptions();

            // Process the actual command line arguments
            ProcessParameters(args);
        }

        // Initialize descriptions for automatic groundplane values
        private void InitializeDescriptions()
        {
            // Map values to descriptions for the /M parameter
            automaticGroundplaneDescriptions.Add(0, "No Automatic Groundplane, No Multilayer board");
            automaticGroundplaneDescriptions.Add(2, "Automatic Groundplane C2, No Multilayer board");
            automaticGroundplaneDescriptions.Add(3, "Automatic Groundplane C1 and C2, No Multilayer board");
            automaticGroundplaneDescriptions.Add(16, "No Automatic Groundplane, Multilayer board");
            automaticGroundplaneDescriptions.Add(31, "Automatic Groundplane C1, C2, I1, and I2, Multilayer board");
            // Add more descriptions as needed
        }

        // Process command line parameters
        private void ProcessParameters(string[] args)
        {
            StringBuilder output = new StringBuilder();

            // Loop through each command line argument
            for (int i = 0; i < args.Length; i++)
            {
                string arg = args[i];

                // Split the argument into parameter and value
                string[] parts = arg.Split(':');

                txtPath.Text = args[0];

                if (parts.Length == 2 || parts.Length == 1)
                {
                    string parameter = parts[0];
                    string value = parts.Length == 2 ? parts[1] : null;

                    // Process each parameter
                    switch (parameter.ToUpper())
                    {
                        case "/L":
                            txtLanguage.Text = value;
                            break;

                        case "/P":
                            txtProcessID.Text = value;
                            break;

                        case "/W":
                            if (double.TryParse(value, out double widthValue))
                            {
                                // Convert the width value to mm by dividing it by 1000
                                double widthInMm = widthValue / 10000.0;
                                txtWidthmm.Text = widthInMm.ToString("F2"); // Display with two decimal places
                            }
                            else
                            {
                                txtWidthmm.Text = "Invalid /W value";
                            }
                            break;

                        case "/H":
                            if (double.TryParse(value, out double heightValue))
                            {
                                // Convert the height value to mm by dividing it by 1000
                                double heightInMm = heightValue / 10000.0;
                                txtHeightmm.Text = heightInMm.ToString("F2"); // Display with two decimal places
                            }
                            else
                            {
                                txtHeightmm.Text = "Invalid /H value";
                            }
                            break;

                        case "/M":
                            if (int.TryParse(value, out int mValue) && automaticGroundplaneDescriptions.ContainsKey(mValue))
                            {
                                toolStripStatusLabel2.Text = automaticGroundplaneDescriptions[mValue];
                            }
                            else
                            {
                                toolStripStatusLabel2.Text = "Invalid /M value";
                            }
                            break;

                        case "/R":
                            if (double.TryParse(value, out double GridSettingValue))
                            {
                                // Convert the X origin value to mm by dividing it by 1000
                                double gridsettingInMm = GridSettingValue / 10000.0;
                                txtGridSettingmm.Text = gridsettingInMm.ToString("F2"); // Display with two decimal places
                            }
                            else
                            {
                                txtOriginXmm.Text = "Invalid /X value";
                            }
                            break;

                        case "/X":
                            if (double.TryParse(value, out double originXValue))
                            {
                                // Convert the X origin value to mm by dividing it by 1000
                                double originXInMm = originXValue / 10000.0;
                                txtOriginXmm.Text = originXInMm.ToString("F2"); // Display with two decimal places
                            }
                            else
                            {
                                txtOriginXmm.Text = "Invalid /X value";
                            }
                            break;

                        case "/Y":
                            if (double.TryParse(value, out double originYValue))
                            {
                                // Convert the Y origin value to mm by dividing it by 1000
                                double originYInMm = originYValue / 10000.0;
                                txtOriginYmm.Text = originYInMm.ToString("F2"); // Display with two decimal places
                            }
                            else
                            {
                                txtOriginYmm.Text = "Invalid /Y value";
                            }
                            break;

                        case "/A":
                            toolStripStatusLabel1.Text = "Complete board transferred.";
                            isBoardTransferred = true; // Set the flag to true
                            break;
                    }
                }
                output.AppendLine(arg);
            }

            // Display the output in the rtbDebug RichTextBox
            rtbDebug.Text = output.ToString();

            // Load the content of the first parameter (file) into the rtbFileContent RichTextBox
            if (args.Length > 0)
            {
                string filePath = args[0];

                if (File.Exists(filePath))
                {
                    string fileContent = File.ReadAllText(filePath);
                    rtbFileContent.Text = fileContent;

                    // Update the txtPath TextBox with the selected file path
                    txtPath.Text = filePath;
                }
                else
                {
                    MessageBox.Show($"Error: File does not exist - {filePath}", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Check the flag and display a different message if "/A" was not encountered
            if (!isBoardTransferred)
            {
                toolStripStatusLabel1.Text = "Complete board is not transferred.";
            }

        }

        // Save content to an output file
        private void SaveToOutputFile(string filePath, string content)
        {
            try
            {
                // Get the directory of the file
                string directory = Path.GetDirectoryName(filePath);

                // Create the output file name based on the specified convention
                string outputFileName = Path.GetFileNameWithoutExtension(filePath) + "_out" + Path.GetExtension(filePath);
                string outputPath = Path.Combine(directory, outputFileName);

                // Save the content to the output file
                File.WriteAllText(outputPath, content);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving content: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for Save button click
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Get the content from the richTextBoxContent RichTextBox
            string richTextBoxContent = rtbFileContent.Text;

            // Get the file path of txtPath Tex tBox
            string filePath = txtPath.Text;

            // Save the content to the output file
            SaveToOutputFile(filePath, richTextBoxContent);

            // Set the exit code based on the selected value from the cmbExitCodes ComboBox
            exitCode = (int)cmbExitCodes.SelectedIndex;

            // Set the exit code before exiting
            Environment.ExitCode = exitCode;

            // Close the application
            Close();
        }

        // Event handler for Cancel button click
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Event handler for form load
        private void MainForm_Load(object sender, EventArgs e)
        {
            cmbExitCodes.SelectedIndex = 0;
        }

        // Event handler for About menu item click
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        // Event handler for KeyDown event
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the pressed key is Escape
            if (e.KeyCode == Keys.Escape)
            {
                // Call the Close() method to exit the program
                Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Call the Close() method to exit the program
            Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Get the content from the richTextBoxContent RichTextBox
            string richTextBoxContent = rtbFileContent.Text;

            // Get the file path of txtPath TextBox
            string filePath = txtPath.Text;

            // Save the content to the output file
            SaveToOutputFile(filePath, richTextBoxContent);

            // Set the exit code based on the selected value from the cmbExitCodes ComboBox
            exitCode = (int)cmbExitCodes.SelectedIndex;

            // Set the exit code before exiting
            Environment.ExitCode = exitCode;

            // Close the application
            Close();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //// Create an instance of OpenFileDialog
            //OpenFileDialog openFileDialog = new OpenFileDialog();

            //// Set the initial directory (optional)
            //openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //// Set the filter for the file dialog (you can customize this based on the file types you want to allow)
            //openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            //// Show the file dialog and check if the user clicked OK
            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    // Get the selected file path
            //    string filePath = openFileDialog.FileName;

            //    try
            //    {
            //        // Read the content of the selected file
            //        string fileContent = File.ReadAllText(filePath);

            //        // Display the content in the rtbFileContent RichTextBox
            //        rtbFileContent.Text = fileContent;

            //        // Optionally, update the txtPath TextBox with the selected file path
            //        txtPath.Text = filePath;
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Error loading file: {ex.Message}", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }
    }
}