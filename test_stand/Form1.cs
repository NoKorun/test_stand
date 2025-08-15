using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace test_stand
{
    public partial class Form1 : Form
    {
        string[] pids = { "1", "2", "3", "4"}; // Номера известных изделий
        public string productID { get; set; } = ""; // PID (номер оборудования) из PIDBox
        Random rnd = new Random();
        public string programStatus { get; set; } = "AwaitingPid";
        private CancellationTokenSource _cts;
        private readonly string resultsDirectory = Path.Combine(Directory.GetCurrentDirectory(),
            "Results"); // Папка для сохранения результатов тестов

        public Form1()
        {
            if (!Directory.Exists(resultsDirectory)) // Проверяем, существует ли папка Results
            {
                Directory.CreateDirectory(resultsDirectory);
            }

            InitializeComponent();
        }

        // Запись результатов тестов в JSON
        private async void saveToJson<T>(T result, string inputText, string resultsDirectory)
        {
            string fileName = $"TestResult_{productID}_{DateTime.Now:yyyyMMdd_HHmmss}.json";
            string filePath = Path.Combine(resultsDirectory, fileName);

            string json = JsonConvert.SerializeObject(result, Formatting.Indented);
            try
            {
                using (var sw = new StreamWriter(filePath, false, Encoding.UTF8))
                {
                    await sw.WriteAsync(json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка записи результата: {ex.Message}");
            }
        }

        // проверкой статуса программы + вызовом метода тестирования
        private async Task RunTestWithChecks(Func<CancellationToken, Task> testMethod)
        {
            if (programStatus == "Testing")
            {
                MessageBox.Show("Тест уже запущен, пожалуйста, дождитесь его завершения");
                return;
            }
            if (programStatus == "AwaitingPid")
            {
                MessageBox.Show("Пожалуйста, введите идентификатор изделия");
                return;
            }
            programStatus = "Testing";
            label1.Text = "Идет тестирование";

            _cts = new CancellationTokenSource();
            try
            {
                await testMethod(_cts.Token);
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Тест отменен пользователем");
            }
        }
        // Обработчик нажатия кнопки для ввода PID
        private void pid_input_button_Click(object sender, EventArgs e)
        {
            if (programStatus == "Testing")
            {
                MessageBox.Show("Test is already running. Please wait for it to finish.");
                return;
            }
            if (pids.Contains(pidBox.Text))
            {
                //testControl1.Visible = true; // Show the control if PID is valid
                productID = pidBox.Text;
                programStatus = "AwaitingTest";
                label1.Text = "Ожидается начало теста";

                //pid_input_button.Visible = false; // Disable the button after valid input
                //pidBox.Visible = false; // Hide the PID input box after valid input
            }
            else
            {
                MessageBox.Show("Invalid PID. Please enter a valid PID.");
                //testControl1.Visible = false; // Hide the control if PID is invalid
            }
        }

        private void pidBox_TextChanged(object sender, EventArgs e)
        {

        }

        private async void test1_Click(object sender, EventArgs e)
        {
            await RunTestWithChecks(RunTestOne);
        }
        private async Task RunTestOne(CancellationToken token)
        {
            token.ThrowIfCancellationRequested();
            await Task.Delay(10000, token);

            int frequency = rnd.Next(100, 2000);
            int test_result = rnd.Next(10); // Случайный результат теста
            bool isSuccess = test_result < 5;

            // Передача для записи в JSON
            var result = new
            {
                Status = isSuccess ? "Успешно" : "Failure",
                ErrorNumber = isSuccess ? 0 : test_result,
                FrequencyMHz = frequency
            };
            saveToJson(result, productID, resultsDirectory);
            programStatus = "Awaiting test";
            label1.Text = "Ожидается начало теста";
            MessageBox.Show("Тест заврешен");
        }

        private async void test2_Click(object sender, EventArgs e)
        {
            await RunTestWithChecks(RunTestTwo);
        }
        private async Task RunTestTwo(CancellationToken token)
        {
            token.ThrowIfCancellationRequested();
            await Task.Delay(15000, token);

            double resistance = rnd.NextDouble() * 1000;
            int current = rnd.Next(1, 16);
            int test_result = rnd.Next(10); // Случайный результат теста
            bool isSuccess = test_result < 5;

            // Передача для записи в JSON
            var result = new
            {
                Status = isSuccess ? "Успешно" : "Failure",
                ErrorNumber = isSuccess ? 0 : test_result,
                ResistanceOm = resistance,
                CurrentAmps = current
            };
            saveToJson(result, productID, resultsDirectory);
            programStatus = "Awaiting test";
            label1.Text = "Ожидается начало теста";
            MessageBox.Show("Тест заврешен");
        }

        private async void test3_Click(object sender, EventArgs e)
        {
            await RunTestWithChecks(RunTestThree);
        }
        private async Task RunTestThree(CancellationToken token)
        {
            token.ThrowIfCancellationRequested();
            await Task.Delay(20000, token);

            int pressure = rnd.Next(10, 2000);
            int test_result = rnd.Next(10); // Случайный результат теста
            bool isSuccess = test_result < 5;

            // Передача для записи в JSON
            var result = new
            {
                Status = isSuccess ? "Успешно" : "Failure",
                ErrorNumber = isSuccess ? 0 : test_result,
                PressurePa = pressure
            };
            saveToJson(result, productID, resultsDirectory);
            programStatus = "Awaiting test";
            label1.Text = "Ожидается начало теста";
            MessageBox.Show("Тест заврешен");
        }

        private void stop_test_button_Click(object sender, EventArgs e)
        {
            if (programStatus == "Testing")
            {
                _cts?.Cancel();
                programStatus = "AwaitingTest";
                label1.Text = "Ожидается начало теста";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
