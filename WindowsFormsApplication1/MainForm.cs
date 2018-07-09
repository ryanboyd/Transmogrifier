using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Google.Cloud.Translation.V2;
using System.Collections.Generic;
using System.Threading;



namespace WindowsFormsApplication1
{



    public partial class MainForm : Form
    {



        //initialize the space for our dictionary data
        DictionaryData BackgroundWorkerData = new DictionaryData();

        string CredentialFile = "";

        //this is what runs at initialization
        public MainForm()
        {




            if (MessageBox.Show("In order to use this program, you must have a Google Cloud account and a Google Translate API key. " +
                "If you have not done so already, you can set up your \"service account\" and get a key from here:" + Environment.NewLine + Environment.NewLine +
                "https://cloud.google.com/translate/docs/reference/libraries#setting_up_authentication" + Environment.NewLine + Environment.NewLine +

                "You must also enable the Google Translate API from your console, located here:" + Environment.NewLine + Environment.NewLine +
                "https://console.cloud.google.com/apis/library/translate.googleapis.com" + Environment.NewLine + Environment.NewLine +

                "Once you have an account set up, you will need to download your credentials (i.e., your \"private key\" as a JSON file. " +
                "When you have this file, click \"OK\" and you will be prompted to load your credentials in this program. " +
                "Once you have loaded your credential file, this program will start." + Environment.NewLine + Environment.NewLine +
                
                "NOTE: This program does not share your credentials with any entity aside from Google." + Environment.NewLine + Environment.NewLine +
                
                "NOTE: The Google Translate API is *NOT* free. You are responsible for all charges from Google pertaining to your use of their API/cloud services. " +
                "You can read about quotas / charges here:" + Environment.NewLine + Environment.NewLine +
                "https://cloud.google.com/translate/quotas",
                "Credential Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
            {
                System.Environment.Exit(1);
            }

            InitializeComponent();


            if (openPrivateKeyDialog.ShowDialog() == DialogResult.Cancel) System.Environment.Exit(1);

            CredentialFile = openPrivateKeyDialog.FileName;

            System.Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", CredentialFile);




            foreach (var encoding in Encoding.GetEncodings())
            {
                InputEncodingDropdown.Items.Add(encoding.Name);
                OutputEncodingDropdown.Items.Add(encoding.Name);
            }

            try
            {
                InputEncodingDropdown.SelectedIndex = InputEncodingDropdown.FindStringExact("utf-8");

            }
            catch
            {
                InputEncodingDropdown.SelectedIndex = InputEncodingDropdown.FindStringExact(Encoding.Default.BodyName);
            }

            try
            {
                OutputEncodingDropdown.SelectedIndex = OutputEncodingDropdown.FindStringExact("utf-8");
            }
            catch
            {
                OutputEncodingDropdown.SelectedIndex = OutputEncodingDropdown.FindStringExact(Encoding.Default.BodyName);
            }


            //InputTextLanguageBox.Items.Add("Automatically Detect Language");

            try
            {
                TranslationClient client = TranslationClient.Create();

                foreach (var language in client.ListLanguages())
                {
                    InputTextLanguageBox.Items.Add(language.Code.ToString());
                    OutputTextLanguageBox.Items.Add(language.Code.ToString());
                }

                try
                {
                    InputTextLanguageBox.SelectedIndex = InputTextLanguageBox.FindStringExact("de");
                    OutputTextLanguageBox.SelectedIndex = OutputTextLanguageBox.FindStringExact("en");
                }
                catch
                {
                    InputTextLanguageBox.SelectedIndex = 0;
                    OutputTextLanguageBox.SelectedIndex = 0;
                }


                

            }
            catch
            {
                MessageBox.Show("There was an issue with validating your credentials. Please double-check that you have enabled your Google Translate API account and that you have set up your service credentials.", "Client Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(1);
            }

            this.TopMost = true;
            this.Invalidate();
            this.Update();
            this.Refresh();
            this.BringToFront();
            
            Application.DoEvents();

            this.TopMost = false;





        }
        




        private void StartButton_Click(object sender, EventArgs e)
        {




            FolderBrowser.Description = "Please choose the location of your .txt files to process";
            if (FolderBrowser.ShowDialog() != DialogResult.Cancel)
            {

                BackgroundWorkerData.TextFileFolder = FolderBrowser.SelectedPath.ToString();

                if (BackgroundWorkerData.TextFileFolder != "")
                {

                    saveOutputDialog.Description = "Please choose a folder for your output files";
                    saveOutputDialog.SelectedPath = BackgroundWorkerData.TextFileFolder;
                    if (saveOutputDialog.ShowDialog() != DialogResult.Cancel)
                    {


                        if (FolderBrowser.SelectedPath == saveOutputDialog.SelectedPath)
                        {
                            MessageBox.Show("You can not use the same folder for text input and text output. If you do this, your original data would be overwritten. Please use a different folder for your output location.", "Folder selection error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        BackgroundWorkerData.OutputFileLocation = saveOutputDialog.SelectedPath;
                        BackgroundWorkerData.FileExtension = FileTypeTextbox.Text.Trim();

                        try
                        {
                            BackgroundWorkerData.MaxCharsPerRequest = Convert.ToInt32(MaxCharsPerRequestTextbox.Text);
                            BackgroundWorkerData.DurationLength = Convert.ToInt32(DurationLengthTextbox.Text);
                            BackgroundWorkerData.MaxRetries = Convert.ToInt32(MaxRetriesPerRequestTextbox.Text);
                        }
                        catch
                        {
                            BackgroundWorkerData.MaxCharsPerRequest = 5000;
                            BackgroundWorkerData.DurationLength = 100;
                            BackgroundWorkerData.MaxRetries = 3;
                        }

                        BackgroundWorkerData.OutputLang = OutputTextLanguageBox.SelectedItem.ToString();
                        BackgroundWorkerData.InputLang = InputTextLanguageBox.SelectedItem.ToString();
                        

                        if (BackgroundWorkerData.OutputFileLocation != "")
                        {



                            StartButton.Enabled = false;
                            ScanSubfolderCheckbox.Enabled = false;
                            InputEncodingDropdown.Enabled = false;
                            OutputEncodingDropdown.Enabled = false;
                            FileTypeTextbox.Enabled = false;

                            InputTextLanguageBox.Enabled = false;
                            OutputTextLanguageBox.Enabled = false;
                            MaxCharsPerRequestTextbox.Enabled = false;
                            DurationLengthTextbox.Enabled = false;
                            MaxRetriesPerRequestTextbox.Enabled = false;

                            BgWorker.RunWorkerAsync(BackgroundWorkerData);
                        }
                    }
                }

            }



        }






        private void BgWorkerClean_DoWork(object sender, DoWorkEventArgs e)
        {


            DictionaryData BGWorkerData = (DictionaryData)e.Argument;

            TranslationClient client = TranslationClient.Create();


            //selects the text encoding based on user selection
            Encoding InputSelectedEncoding = null;
            Encoding OutputSelectedEncoding = null;
            this.Invoke((MethodInvoker)delegate ()
            {
                InputSelectedEncoding = Encoding.GetEncoding(InputEncodingDropdown.SelectedItem.ToString());
                OutputSelectedEncoding = Encoding.GetEncoding(OutputEncodingDropdown.SelectedItem.ToString());
            });



            //get the list of files
            var SearchDepth = SearchOption.TopDirectoryOnly;
            if (ScanSubfolderCheckbox.Checked)
            {
                SearchDepth = SearchOption.AllDirectories;
            }
            var files = Directory.EnumerateFiles(BGWorkerData.TextFileFolder, BGWorkerData.FileExtension, SearchDepth);



            try {

            foreach (string fileName in files)
            {

                if (e.Cancel) { break; }

                

                //set up our variables to report
                string Filename_Clean = Path.GetFileName(fileName);

                string SubDirStructure = Path.GetDirectoryName(fileName).Replace(BGWorkerData.TextFileFolder, "").TrimStart('\\');


                //creates subdirs if they don't exist
                string Output_Location = BGWorkerData.OutputFileLocation + '\\' + SubDirStructure;

                if (!Directory.Exists(Output_Location))
                {
                    Directory.CreateDirectory(Output_Location);
                }

                Output_Location = Path.Combine(Output_Location, Path.GetFileName(fileName));

                //report what we're working on
                FilenameLabel.Invoke((MethodInvoker)delegate
                {
                    FilenameLabel.Text = "Processing: " + Filename_Clean;
                    FilenameLabel.Invalidate();
                    FilenameLabel.Update();
                    FilenameLabel.Refresh();
                    Application.DoEvents();
                });









                // __        __    _ _          ___        _               _   
                // \ \      / / __(_) |_ ___   / _ \ _   _| |_ _ __  _   _| |_ 
                //  \ \ /\ / / '__| | __/ _ \ | | | | | | | __| '_ \| | | | __|
                //   \ V  V /| |  | | ||  __/ | |_| | |_| | |_| |_) | |_| | |_ 
                //    \_/\_/ |_|  |_|\__\___|  \___/ \__,_|\__| .__/ \__,_|\__|
                //                                            |_|              


                using (StreamReader inputfile = new StreamReader(fileName, InputSelectedEncoding))
                {

                    if (e.Cancel) { break; }

                    string readText = inputfile.ReadToEnd();

                    string[] readText_Chunked = new string[0];

                    if (!string.IsNullOrWhiteSpace(readText))
                    {
                        readText_Chunked = SplitStringByLength(readText, BGWorkerData.MaxCharsPerRequest);
                    }

                    StringBuilder TranslatedText_Output = new StringBuilder();

                    for (int i = 0; i < readText_Chunked.Length; i++)
                    {


                        if (e.Cancel) { break; }

                        try
                        {

                                if (e.Cancel) { break; }

                                StatusLabel.Invoke((MethodInvoker)delegate
                                {
                                    StatusLabel.Text = "Status: Sending request " + (i+1).ToString() + "/" + readText_Chunked.Length.ToString() + " to API...";
                                    StatusLabel.Invalidate();
                                    StatusLabel.Update();
                                    StatusLabel.Refresh();
                                    Application.DoEvents();
                                });

                                var response = client.TranslateText(readText_Chunked[i],
                                                            sourceLanguage: BGWorkerData.InputLang,
                                                            targetLanguage: BGWorkerData.OutputLang);

                            TranslatedText_Output.Append(response.TranslatedText);

                        }
                        catch (Google.GoogleApiException ex)
                        {

                                if (e.Cancel) { break; }

                                if (ex.Error.Code == 403)
                                {

                                    if (ex.Error.Message.Contains("Daily Limit Exceeded")) {
                                        //report what we're working on
                                        StatusLabel.Invoke((MethodInvoker)delegate
                                        {
                                            StatusLabel.Text = "Status: " + ex.Error.Message;
                                            StatusLabel.Invalidate();
                                            StatusLabel.Update();
                                            StatusLabel.Refresh();
                                            Application.DoEvents();
                                        });

                                        MessageBox.Show("The Google Translate API reports that you have exceeded your daily use limit. You will need to visit the \"Quotas\" section of the Google Cloud Dashboard to increase your limits or, alternatively, wait until midnight for your quota to reset.", "Daily Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                        e.Cancel = true;
                                        break;


                                    }

                                    else {

                                        if (e.Cancel) { break; }

                                        int retry_counter = 0;
                                        while (retry_counter < BGWorkerData.MaxRetries) {

                                            retry_counter++;

                                            int TimerCounter = 0;
                                            DateTime d = DateTime.Now;

                                            while (TimerCounter < BGWorkerData.DurationLength + 2)
                                            {
                                                TimeSpan ts = DateTime.Now.Subtract(d);
                                                if (ts.Seconds >= 1)
                                                {
                                                    //do some work 
                                                    TimerCounter += ts.Seconds;
                                                    d = DateTime.Now;

                                                    //report what we're working on
                                                    StatusLabel.Invoke((MethodInvoker)delegate
                                                    {
                                                        StatusLabel.Text = "Status: Rate limit reached. Sleeping for " + (BGWorkerData.DurationLength - TimerCounter + 1).ToString() + "...";
                                                        StatusLabel.Invalidate();
                                                        StatusLabel.Update();
                                                        StatusLabel.Refresh();
                                                        Application.DoEvents();
                                                    });



                                                }

                                            }

                                            try
                                            {

                                                //report what we're working on
                                                StatusLabel.Invoke((MethodInvoker)delegate
                                                {
                                                    StatusLabel.Text = "Status: Sending request " + (i + 1).ToString() + "/" + readText_Chunked.Length.ToString() + " to API... Retry #" + retry_counter.ToString();
                                                    StatusLabel.Invalidate();
                                                    StatusLabel.Update();
                                                    StatusLabel.Refresh();
                                                    Application.DoEvents();
                                                });

                                                var response = client.TranslateText(readText_Chunked[i],
                                                                            sourceLanguage: BGWorkerData.InputLang,
                                                                            targetLanguage: BGWorkerData.OutputLang);

                                                TranslatedText_Output.Append(response.TranslatedText);

                                                retry_counter = BGWorkerData.MaxRetries;

                                            }
                                            catch
                                            {

                                            }


                                    }



                                }

                            }
                            else
                                {
                                    //report what we're working on
                                    StatusLabel.Invoke((MethodInvoker)delegate
                                    {
                                        StatusLabel.Text = "Status: " + ex.Error.Message;
                                        StatusLabel.Invalidate();
                                        StatusLabel.Update();
                                        StatusLabel.Refresh();
                                        Application.DoEvents();
                                    });
                                }


                            }
                    }



                    //open up the output file
                    using (StreamWriter outputFile = new StreamWriter(new FileStream(Output_Location, FileMode.Create), OutputSelectedEncoding))
                    {
                        outputFile.Write(TranslatedText_Output.ToString());
                    }
                }


            }



             }
            catch
            {
                MessageBox.Show("Transmogrifier encountered an issue somewhere while trying to translate your texts. The most common cause of this is trying to open your output file(s) while the program is still running. Did any of your input files move, or is your output file being opened/modified by another application?", "Error while translating", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        //when the bgworker is done running, we want to re-enable user controls and let them know that it's finished
        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            StartButton.Enabled = true;
            ScanSubfolderCheckbox.Enabled = true;
            InputEncodingDropdown.Enabled = true;
            OutputEncodingDropdown.Enabled = true;
            FileTypeTextbox.Enabled = true;

            InputTextLanguageBox.Enabled = true;
            OutputTextLanguageBox.Enabled = true;
            MaxCharsPerRequestTextbox.Enabled = true;
            DurationLengthTextbox.Enabled = true;
            MaxRetriesPerRequestTextbox.Enabled = true;


            FilenameLabel.Text = "Finished!";
            StatusLabel.Text = "Nothing to report.";
            MessageBox.Show("Transmogrifier has finished processing your texts.", "Translation Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }






        public static string[] SplitStringByLength(string str, int maxLength)
        {

            string[] SplitString = str.Split();
            List<string> WordChunks = new List<string>();


            StringBuilder WordChunk = new StringBuilder();
            for (int i = 0; i < SplitString.Length; i++)
            {
                if ((WordChunk.Length + 1 + SplitString[i].Length) > maxLength)
                {
                    WordChunks.Add(WordChunk.ToString());
                    WordChunk.Clear();
                    WordChunk.Append(SplitString[i] + " ");
                }
                else
                {
                    WordChunk.Append(SplitString[i] + " ");
                }
            }


            WordChunks.Add(WordChunk.ToString());


            return WordChunks.ToArray();

        }



        public class DictionaryData
        {

            public string TextFileFolder { get; set; }
            public string OutputFileLocation { get; set; }
            public string FileExtension { get; set; }

            public string InputLang { get; set; }
            public string OutputLang { get; set; }

            public int DurationLength { get; set; }
            public int MaxCharsPerRequest { get; set; }
            public int MaxRetries { get; set; }


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void LanguageCodesLinkLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://cloud.google.com/translate/docs/languages");
        }
    }
}
