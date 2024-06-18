using System.Media;
using System.Text.RegularExpressions;

namespace Refinery
{
    public partial class Main : Form
    {
        private string schedule = "";
        private Thread timetableThread = new(() => { });

        private void Log(string log)
        {
            if (logBox.InvokeRequired) logBox.Invoke(new Action(() => logBox.Text += log + Environment.NewLine));
            else logBox.Text += log + Environment.NewLine;
        }

        public Main()
        {
            Config.ReadConfigFile();
            InitializeComponent();
            try
            {
                schedule = File.ReadAllText(Config.TimetablePath);
                timetableTextBox.Text = File.ReadAllText(Config.TimetablePath);
            }
            catch { }
            portTextBox.Text = Config.Port;
            baudTextBox.Text = Config.Baud.ToString();
            bitsTextBox.Text = Config.Bits.ToString();
            startAudioTextBox.Text = Config.StartAudioPath;
            endAudioTextBox.Text = Config.EndAudioPath;
            emergencyTextBox.Text = Config.EmergencyAudioPath;
        }

        private void newTimeButton_Click(object sender, EventArgs e)
        {
            using OpenFileDialog fileDialog = new();

            fileDialog.InitialDirectory = "c:\\";
            fileDialog.Filter = "All files (*.*)|*.*";
            fileDialog.FilterIndex = 2;
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                //Read the contents of the file into a stream
                var fileStream = fileDialog.OpenFile();

                using StreamReader reader = new(fileStream);
                schedule = reader.ReadToEnd();
                timetableTextBox.Text = schedule;
                Log("Schedule loaded from file.");
            }
        }

        private void timetableTextBox_TextChange(object sender, EventArgs e)
        {
            schedule = timetableTextBox.Text;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            timetableThread = new(() =>
            {
                Log("Parsing schedule.");
                Lesson[] lessons = [];
                
                try { lessons = Lexer.ParseTimetable(schedule); }
                catch(Exception e) { MessageBox.Show($"The schedule has improper syntax at token {new Regex(@"<+\d+>").Match(e.Message)}."); }

                Log("Starting timetable.");

                foreach (Lesson lesson in lessons)
                {
                    if (lesson.Start > TimeOnly.FromDateTime(DateTime.Now))
                    {
                        Log("Waiting to play start.");
                        Thread.Sleep(lesson.Start - TimeOnly.FromDateTime(DateTime.Now));
                        new SoundPlayer(Config.StartAudioPath).Play();
                        Log("Playing start.");
                    }

                    if (lesson.End > TimeOnly.FromDateTime(DateTime.Now))
                    {
                        Log("Waiting to play end.");
                        Thread.Sleep(lesson.End - TimeOnly.FromDateTime(DateTime.Now));
                        new SoundPlayer(Config.EndAudioPath).Play();
                        Log("Playing end.");
                    }
                }
                Log("Ending timetable.");
            })
            {
                IsBackground = true
            };
            timetableThread.Start();

            startButton.Enabled = true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stopping the current schedule is unsuported in this version. Please restart the application.");
        }

        private void saveConfigButton_Click(object sender, EventArgs e)
        {
            Config.Port = portTextBox.Text;
            Config.Baud = int.Parse(baudTextBox.Text);
            Config.Bits = int.Parse(bitsTextBox.Text);
            Config.StartAudioPath = startAudioTextBox.Text;
            Config.EndAudioPath = endAudioTextBox.Text;
            Config.EmergencyAudioPath = emergencyTextBox.Text;
            Config.DumpToConfigFile();
        }

        private void saveTimetableButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(Config.TimetablePath))
                File.Delete(Config.TimetablePath);

            using StreamWriter sw = File.CreateText(Config.TimetablePath);
            sw.Write(timetableTextBox.Text);
        }
    }
}
