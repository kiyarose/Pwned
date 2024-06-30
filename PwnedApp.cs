using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Text.RegularExpressions;


namespace Pwned
{
    public partial class PwnedApp : Form
    {
        public PwnedApp()
        {
            InitializeComponent();
        }

        private void PwnedApp_Load(object sender, EventArgs e)
        {
            passVistoggle.BackColor = Color.White;
            passGenlength.Minimum = 8;
            passGenlength.Maximum = 35;
            statusPwned.BackColor = Color.Beige;
            statusSecure.BackColor = Color.Beige;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            passInput.PasswordChar = passInput.PasswordChar == '*' ? '\0' : '*';
            if (passVistoggle.BackColor == Color.White)
            {
                passVistoggle.BackColor = Color.Yellow;
            }
            else
            {
                passVistoggle.BackColor = Color.White;
            }
        }

        private void passGenS_Click(object sender, EventArgs e)
        {
            int passwordLength = passGenlength.Value;
            int complexity = passGencomplex.Value;
            string password = "";

            if (passStyleRan.Checked)
            {
                password = GenerateRandomPassword(passwordLength, complexity);
            }
            else
            {
                password = GenerateWordPassword(passwordLength, complexity);
            }

            passGen.Text = password;
        }

        private string GenerateRandomPassword(int length, int complexity)
        {
            string uppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercaseChars = "abcdefghijklmnopqrstuvwxyz";
            string numericChars = "0123456789";
            string specialChars = "!@#$%^&*()_+";

            string allChars = "";

            // Add character sets based on complexity level
            if (complexity >= 1)
            {
                allChars += uppercaseChars;
            }
            if (complexity >= 2)
            {
                allChars += lowercaseChars;
            }
            if (complexity >= 3)
            {
                allChars += numericChars;
            }
            if (complexity >= 4)
            {
                allChars += specialChars;
            }

            Random random = new Random();
            string password = "";

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(0, allChars.Length);
                password += allChars[index];
            }

            return password;
        }

        private string GenerateWordPassword(int length, int complexity)
        {
            string[] words = { "Apple", "Banana", "Carrot", "Dog", "Elephant", "Flower", "Grape", "Honey", "Ice cream", "Jungle", "Kiwi", "Lemon", "Mango", "Nut", "Orange", "Pear", "Quince", "Raspberry", "Strawberry", "Tomato" };
            string[] symbols = { "@", "#", "$", "%", "&", "*", "+", "-", "=", "?", "!" };

            Random random = new Random();
            StringBuilder passwordBuilder = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                int wordIndex = random.Next(0, words.Length);
                int symbolIndex = random.Next(0, symbols.Length);

                passwordBuilder.Append(words[wordIndex]);
                passwordBuilder.Append(symbols[symbolIndex]);


            }

            return passwordBuilder.ToString();
        }

        private void passStyleRan_CheckedChanged(object sender, EventArgs e)
        {
            passGenlength.Minimum = 8;
            passGenlength.Maximum = 35;
            passGenlength.Value = 8;
        }

        private void passStylePhrase_CheckedChanged(object sender, EventArgs e)
        {
            passGenlength.Minimum = 4;
            passGenlength.Maximum = 10;
            passGenlength.Value = 4;
        }

        private async void checkPwn_Click(object sender, EventArgs e)
        {
            string hashPass = HashGenerator.ToSHA1(passInput.Text);
            Console.WriteLine("Hashed Passkey is: " + hashPass);
            string hashKey = hashPass.Substring(0, 5);
            string hashFall = hashPass.Substring(5);
            Console.WriteLine("Fallback: " + hashFall);
            Console.WriteLine("Hash Key to Post is: " + hashKey);

            await CheckPasswordPwnedAsync(hashKey, hashFall);
            await CalculatePasswordComplexityAsync();
        }
        private async Task CheckPasswordPwnedAsync(string hashKey, string hashPass)
        {
            string url = "https://api.pwnedpasswords.com/range/" + hashKey;
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            string content = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                string[] hashes = content.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                bool isPwned = false;
                int count = 0;
                foreach (string hash in hashes)
                {
                    string[] parts = hash.Split(':');
                    // Compare the hash suffix from the API with hashPass, ensuring case-insensitive comparison
                    if (string.Equals(parts[0], hashPass, StringComparison.OrdinalIgnoreCase))
                    {
                        isPwned = true;
                        count = int.Parse(parts[1]);
                        break;
                    }
                }

                if (isPwned)
                {
                    statusPwned.Text = "ý";
                    statusPwned.BackColor = Color.Crimson;
                    MessageBox.Show($"Password has been pwned {count} time(s)!");
                }
                else
                {
                    statusPwned.Text = "þ";
                    statusPwned.BackColor = Color.LightGreen;
                }
            }
            else
            {
                MessageBox.Show($"Error checking password: {response.StatusCode}");
            }
        }
        private async Task CalculatePasswordComplexityAsync()
        {
            string password = passInput.Text;
            int complexity = 0;
            int taskcounter = 0;

            // Check for uppercase letters
            if (Regex.IsMatch(password, "[A-Z]"))
            {
                complexity += Regex.Matches(password, "[A-Z]").Count;
                taskcounter++;
            }

            // Check for lowercase letters
            if (Regex.IsMatch(password, "[a-z]"))
            {
                complexity += Regex.Matches(password, "[a-z]").Count;
                taskcounter++;
            }

            // Check for numeric characters
            if (Regex.IsMatch(password, "[0-9]"))
            {
                complexity += Regex.Matches(password, "[0-9]").Count;
                taskcounter++;
            }

            // Check for special characters
            if (Regex.IsMatch(password, "[!@#$%^&*()_+]"))
            {
                complexity += Regex.Matches(password, "[!@#$%^&*()_+]").Count;
                taskcounter++;
            }

            Console.WriteLine("COM1:" + complexity);
            // Check for consecutive or progressive characters
            int ogcomplex = complexity;
            complexity -= CountConsecutiveCharacters(password);
            complexity -= CountProgressiveCharacters(password);
            Console.WriteLine("COM2:" + complexity);
            // Calculate the time to crack the password
            double timeToCrack = Math.Pow(26, password.Length) / 2;
            if (statusPwned.Text == "ý")
            {
                complexity = 1;
                taskcounter = 1;
            }
            else
            {
                switch (true)
                {
                    case var count when CountConsecutiveCharacters(password) > 3:
                        int rep = CountConsecutiveCharacters(password);
                        complexity -= rep;
                        taskcounter--;
                        break;
                    case var count when CountProgressiveCharacters(password) > 3:
                        int prog = CountProgressiveCharacters(password);
                        complexity -= prog;
                        taskcounter--;
                        break;
                }
            }
            Console.WriteLine("TSK:" + taskcounter);
            // Display the complexity and time to crack
            Console.WriteLine($"Password Complexity: {complexity}");
            if (complexity < 9)
            {
                statusSecure.BackColor = Color.Crimson;
                statusSecure.Text = "ý";
            }
            else if (complexity >= 9 && taskcounter < 3)
            {
                statusSecure.BackColor = Color.LightYellow;
                statusSecure.Text = "þ";
                MessageBox.Show("Password seems secure, but dosen't meet all the recommended complexity requirements!\n" +
                    "Such as:\n" +
                    "- At least 8 Characters\n" +
                    "- At least one Uppercase and Lowercase character\n" +
                    "- At least one Number\n" +
                    "- At least one Symbol");
            }
            else { statusSecure.BackColor = Color.LightGreen; statusSecure.Text = "þ"; }
        }

        private int CountConsecutiveCharacters(string password)
        {
            int count = 0;
            char previousChar = '\0'; // Initialize previous character with null character

            foreach (char currentChar in password)
            {
                if (previousChar != '\0' && (currentChar == previousChar || currentChar == previousChar + 1 || currentChar == previousChar - 1))
                {
                    count++;
                    Console.WriteLine("CONS:" + count);
                }

                previousChar = currentChar;
            }

            return count;
        }

        private int CountProgressiveCharacters(string password)
        {
            int count = 0;
            for (int i = 0; i < password.Length - 2; i++)
            {
                if (password[i] + 1 == password[i + 1] && password[i + 1] + 1 == password[i + 2])
                {
                    count++;
                    Console.WriteLine("PROG:" + count);
                }
            }
            return count;
        }
        private string[] ReadArrayFromFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            return lines;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Check if the Enter key is pressed
            if (keyData == Keys.Enter)
            {
                // Trigger the checkPwn_Click event programmatically
                // Pass 'null' for both sender and EventArgs since they are not used in the method
                checkPwn_Click(null, null);

                // Return true to indicate that the key press has been handled
                return true;
            }

            // Call the base class method to handle other key presses
            return base.ProcessCmdKey(ref msg, keyData);
        }
        /*
        private async void passInput_TextChanged(object sender, EventArgs e)
        {
            // Create a TaskCompletionSource to track when the TextBox is unfocused
            TaskCompletionSource<bool> unfocusedTask = new TaskCompletionSource<bool>();


            // Attach an event handler to the TextBox's Leave event
            passInput.Leave += (leaveSender, leaveArgs) =>
            {
                // Set the TaskCompletionSource result to true when the TextBox is unfocused
                unfocusedTask.SetResult(true);
            };

            // Wait until the TextBox is unfocused
            await unfocusedTask.Task;

            // Trigger the checkPwn_Click event
            checkPwn_Click(sender, e);
        }
        */
    }



    public class HashGenerator
    {
        public static string ToSHA1(string text)
        {
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] textBytes = Encoding.UTF8.GetBytes(text);
                byte[] hashBytes = sha1.ComputeHash(textBytes);

                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.AppendFormat("{0:x2}", b);
                }
                return sb.ToString();
            }
        }
    }
}
