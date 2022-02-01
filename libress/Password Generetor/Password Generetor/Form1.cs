using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generetor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] defould_characters = {"a","b","c","d","e","f","g","h","o","p","r","s","t","u","v","y","z","x","q","w","0","1","2","3","4","5","6","7","8","9","!","#","*","<",">","@"}; //36
            var number_of_digits = numericUpDown1.Value;
            var password = "Unknow";
            Random rnd = new Random();
            var random_t = rnd.Next(36);

            var ttd = "of";
            var digit_1 = "of";
            var digit_2 = "of";
            var digit_3 = "of";
            var digit_4 = "of";
            var digit_5 = "of";
            var digit_6 = "of";
            var digit_7 = "of";
            var digit_8 = "of";
            var digit_9 = "of";
            var digit_10 = "of";
            var digit_11 = "of";
            var digit_12 = "of";
            var digit_13 = "of";
            var digit_14 = "of";
            var digit_15 = "of";
            var digit_16 = "of";
            var digit_17 = "of";
            var digit_18 = "of";
            var digit_19 = "of";
            var digit_20 = "of";

            // digit_1
            random_t = rnd.Next(36);
            if (random_t == 0)
            {
                ttd = defould_characters[0];
            }
            else if (random_t == 1)
            {
                ttd = defould_characters[1];
            }
            else if (random_t == 2)
            {
                ttd = defould_characters[2];
            }
            else if (random_t == 3)
            {
                ttd = defould_characters[3];
            }
            else if (random_t == 4)
            {
                ttd = defould_characters[4];
            }
            else if (random_t == 5)
            {
                ttd = defould_characters[5];
            }
            else if (random_t == 6)
            {
                ttd = defould_characters[6];
            }
            else if (random_t == 7)
            {
                ttd = defould_characters[7];
            }
            else if (random_t == 8)
            {
                ttd = defould_characters[8];
            }
            else if (random_t == 9)
            {
                ttd = defould_characters[9];
            }
            else if (random_t == 10)
            {
                ttd = defould_characters[10];
            }
            else if (random_t == 11)
            {
                ttd = defould_characters[11];
            }
            else if (random_t == 12)
            {
                ttd = defould_characters[12];
            }
            else if (random_t == 13)
            {
                ttd = defould_characters[13];
            }
            else if (random_t == 14)
            {
                ttd = defould_characters[14];
            }
            else if (random_t == 15)
            {
                ttd = defould_characters[15];
            }
            else if (random_t == 16)
            {
                ttd = defould_characters[16];
            }
            else if (random_t == 17)
            {
                ttd = defould_characters[17];
            }
            else if (random_t == 18)
            {
                ttd = defould_characters[18];
            }
            else if (random_t == 19)
            {
                ttd = defould_characters[19];
            }
            else if (random_t == 20)
            {
                ttd = defould_characters[20];
            }
            else if (random_t == 21)
            {
                ttd = defould_characters[21];
            }
            else if (random_t == 22)
            {
                ttd = defould_characters[22];
            }
            else if (random_t == 23)
            {
                ttd = defould_characters[23];
            }
            else if (random_t == 24)
            {
                ttd = defould_characters[24];
            }
            else if (random_t == 25)
            {
                ttd = defould_characters[25];
            }
            else if (random_t == 26)
            {
                ttd = defould_characters[26];
            }
            else if (random_t == 27)
            {
                ttd = defould_characters[27];
            }
            else if (random_t == 28)
            {
                ttd = defould_characters[28];
            }
            else if (random_t == 29)
            {
                ttd = defould_characters[29];
            }
            else if (random_t == 30)
            {
                ttd = defould_characters[30];
            }
            else if (random_t == 31)
            {
                ttd = defould_characters[31];
            }
            else if (random_t == 32)
            {
                ttd = defould_characters[32];
            }
            else if (random_t == 33)
            {
                ttd = defould_characters[33];
            }
            else if (random_t == 34)
            {
                ttd = defould_characters[34];
            }
            else if (random_t == 35)
            {
                ttd = defould_characters[35];
            }
            else if (random_t == 36)
            {
                ttd = defould_characters[36];
            }
            digit_1 = ttd;

            // digit_2
            random_t = rnd.Next(36);
            if (random_t == 0)
            {
                ttd = defould_characters[0];
            }
            else if (random_t == 1)
            {
                ttd = defould_characters[1];
            }
            else if (random_t == 2)
            {
                ttd = defould_characters[2];
            }
            else if (random_t == 3)
            {
                ttd = defould_characters[3];
            }
            else if (random_t == 4)
            {
                ttd = defould_characters[4];
            }
            else if (random_t == 5)
            {
                ttd = defould_characters[5];
            }
            else if (random_t == 6)
            {
                ttd = defould_characters[6];
            }
            else if (random_t == 7)
            {
                ttd = defould_characters[7];
            }
            else if (random_t == 8)
            {
                ttd = defould_characters[8];
            }
            else if (random_t == 9)
            {
                ttd = defould_characters[9];
            }
            else if (random_t == 10)
            {
                ttd = defould_characters[10];
            }
            else if (random_t == 11)
            {
                ttd = defould_characters[11];
            }
            else if (random_t == 12)
            {
                ttd = defould_characters[12];
            }
            else if (random_t == 13)
            {
                ttd = defould_characters[13];
            }
            else if (random_t == 14)
            {
                ttd = defould_characters[14];
            }
            else if (random_t == 15)
            {
                ttd = defould_characters[15];
            }
            else if (random_t == 16)
            {
                ttd = defould_characters[16];
            }
            else if (random_t == 17)
            {
                ttd = defould_characters[17];
            }
            else if (random_t == 18)
            {
                ttd = defould_characters[18];
            }
            else if (random_t == 19)
            {
                ttd = defould_characters[19];
            }
            else if (random_t == 20)
            {
                ttd = defould_characters[20];
            }
            else if (random_t == 21)
            {
                ttd = defould_characters[21];
            }
            else if (random_t == 22)
            {
                ttd = defould_characters[22];
            }
            else if (random_t == 23)
            {
                ttd = defould_characters[23];
            }
            else if (random_t == 24)
            {
                ttd = defould_characters[24];
            }
            else if (random_t == 25)
            {
                ttd = defould_characters[25];
            }
            else if (random_t == 26)
            {
                ttd = defould_characters[26];
            }
            else if (random_t == 27)
            {
                ttd = defould_characters[27];
            }
            else if (random_t == 28)
            {
                ttd = defould_characters[28];
            }
            else if (random_t == 29)
            {
                ttd = defould_characters[29];
            }
            else if (random_t == 30)
            {
                ttd = defould_characters[30];
            }
            else if (random_t == 31)
            {
                ttd = defould_characters[31];
            }
            else if (random_t == 32)
            {
                ttd = defould_characters[32];
            }
            else if (random_t == 33)
            {
                ttd = defould_characters[33];
            }
            else if (random_t == 34)
            {
                ttd = defould_characters[34];
            }
            else if (random_t == 35)
            {
                ttd = defould_characters[35];
            }
            else if (random_t == 36)
            {
                ttd = defould_characters[36];
            }
            digit_2 = ttd;

            // digit_3
            random_t = rnd.Next(36);
            if (random_t == 0)
            {
                ttd = defould_characters[0];
            }
            else if (random_t == 1)
            {
                ttd = defould_characters[1];
            }
            else if (random_t == 2)
            {
                ttd = defould_characters[2];
            }
            else if (random_t == 3)
            {
                ttd = defould_characters[3];
            }
            else if (random_t == 4)
            {
                ttd = defould_characters[4];
            }
            else if (random_t == 5)
            {
                ttd = defould_characters[5];
            }
            else if (random_t == 6)
            {
                ttd = defould_characters[6];
            }
            else if (random_t == 7)
            {
                ttd = defould_characters[7];
            }
            else if (random_t == 8)
            {
                ttd = defould_characters[8];
            }
            else if (random_t == 9)
            {
                ttd = defould_characters[9];
            }
            else if (random_t == 10)
            {
                ttd = defould_characters[10];
            }
            else if (random_t == 11)
            {
                ttd = defould_characters[11];
            }
            else if (random_t == 12)
            {
                ttd = defould_characters[12];
            }
            else if (random_t == 13)
            {
                ttd = defould_characters[13];
            }
            else if (random_t == 14)
            {
                ttd = defould_characters[14];
            }
            else if (random_t == 15)
            {
                ttd = defould_characters[15];
            }
            else if (random_t == 16)
            {
                ttd = defould_characters[16];
            }
            else if (random_t == 17)
            {
                ttd = defould_characters[17];
            }
            else if (random_t == 18)
            {
                ttd = defould_characters[18];
            }
            else if (random_t == 19)
            {
                ttd = defould_characters[19];
            }
            else if (random_t == 20)
            {
                ttd = defould_characters[20];
            }
            else if (random_t == 21)
            {
                ttd = defould_characters[21];
            }
            else if (random_t == 22)
            {
                ttd = defould_characters[22];
            }
            else if (random_t == 23)
            {
                ttd = defould_characters[23];
            }
            else if (random_t == 24)
            {
                ttd = defould_characters[24];
            }
            else if (random_t == 25)
            {
                ttd = defould_characters[25];
            }
            else if (random_t == 26)
            {
                ttd = defould_characters[26];
            }
            else if (random_t == 27)
            {
                ttd = defould_characters[27];
            }
            else if (random_t == 28)
            {
                ttd = defould_characters[28];
            }
            else if (random_t == 29)
            {
                ttd = defould_characters[29];
            }
            else if (random_t == 30)
            {
                ttd = defould_characters[30];
            }
            else if (random_t == 31)
            {
                ttd = defould_characters[31];
            }
            else if (random_t == 32)
            {
                ttd = defould_characters[32];
            }
            else if (random_t == 33)
            {
                ttd = defould_characters[33];
            }
            else if (random_t == 34)
            {
                ttd = defould_characters[34];
            }
            else if (random_t == 35)
            {
                ttd = defould_characters[35];
            }
            else if (random_t == 36)
            {
                ttd = defould_characters[36];
            }
            digit_3 = ttd;

            // digit_4
            random_t = rnd.Next(36);
            if (random_t == 0)
            {
                ttd = defould_characters[0];
            }
            else if (random_t == 1)
            {
                ttd = defould_characters[1];
            }
            else if (random_t == 2)
            {
                ttd = defould_characters[2];
            }
            else if (random_t == 3)
            {
                ttd = defould_characters[3];
            }
            else if (random_t == 4)
            {
                ttd = defould_characters[4];
            }
            else if (random_t == 5)
            {
                ttd = defould_characters[5];
            }
            else if (random_t == 6)
            {
                ttd = defould_characters[6];
            }
            else if (random_t == 7)
            {
                ttd = defould_characters[7];
            }
            else if (random_t == 8)
            {
                ttd = defould_characters[8];
            }
            else if (random_t == 9)
            {
                ttd = defould_characters[9];
            }
            else if (random_t == 10)
            {
                ttd = defould_characters[10];
            }
            else if (random_t == 11)
            {
                ttd = defould_characters[11];
            }
            else if (random_t == 12)
            {
                ttd = defould_characters[12];
            }
            else if (random_t == 13)
            {
                ttd = defould_characters[13];
            }
            else if (random_t == 14)
            {
                ttd = defould_characters[14];
            }
            else if (random_t == 15)
            {
                ttd = defould_characters[15];
            }
            else if (random_t == 16)
            {
                ttd = defould_characters[16];
            }
            else if (random_t == 17)
            {
                ttd = defould_characters[17];
            }
            else if (random_t == 18)
            {
                ttd = defould_characters[18];
            }
            else if (random_t == 19)
            {
                ttd = defould_characters[19];
            }
            else if (random_t == 20)
            {
                ttd = defould_characters[20];
            }
            else if (random_t == 21)
            {
                ttd = defould_characters[21];
            }
            else if (random_t == 22)
            {
                ttd = defould_characters[22];
            }
            else if (random_t == 23)
            {
                ttd = defould_characters[23];
            }
            else if (random_t == 24)
            {
                ttd = defould_characters[24];
            }
            else if (random_t == 25)
            {
                ttd = defould_characters[25];
            }
            else if (random_t == 26)
            {
                ttd = defould_characters[26];
            }
            else if (random_t == 27)
            {
                ttd = defould_characters[27];
            }
            else if (random_t == 28)
            {
                ttd = defould_characters[28];
            }
            else if (random_t == 29)
            {
                ttd = defould_characters[29];
            }
            else if (random_t == 30)
            {
                ttd = defould_characters[30];
            }
            else if (random_t == 31)
            {
                ttd = defould_characters[31];
            }
            else if (random_t == 32)
            {
                ttd = defould_characters[32];
            }
            else if (random_t == 33)
            {
                ttd = defould_characters[33];
            }
            else if (random_t == 34)
            {
                ttd = defould_characters[34];
            }
            else if (random_t == 35)
            {
                ttd = defould_characters[35];
            }
            else if (random_t == 36)
            {
                ttd = defould_characters[36];
            }
            digit_4 = ttd;

            // digit_5
            random_t = rnd.Next(36);
            if (random_t == 0)
            {
                ttd = defould_characters[0];
            }
            else if (random_t == 1)
            {
                ttd = defould_characters[1];
            }
            else if (random_t == 2)
            {
                ttd = defould_characters[2];
            }
            else if (random_t == 3)
            {
                ttd = defould_characters[3];
            }
            else if (random_t == 4)
            {
                ttd = defould_characters[4];
            }
            else if (random_t == 5)
            {
                ttd = defould_characters[5];
            }
            else if (random_t == 6)
            {
                ttd = defould_characters[6];
            }
            else if (random_t == 7)
            {
                ttd = defould_characters[7];
            }
            else if (random_t == 8)
            {
                ttd = defould_characters[8];
            }
            else if (random_t == 9)
            {
                ttd = defould_characters[9];
            }
            else if (random_t == 10)
            {
                ttd = defould_characters[10];
            }
            else if (random_t == 11)
            {
                ttd = defould_characters[11];
            }
            else if (random_t == 12)
            {
                ttd = defould_characters[12];
            }
            else if (random_t == 13)
            {
                ttd = defould_characters[13];
            }
            else if (random_t == 14)
            {
                ttd = defould_characters[14];
            }
            else if (random_t == 15)
            {
                ttd = defould_characters[15];
            }
            else if (random_t == 16)
            {
                ttd = defould_characters[16];
            }
            else if (random_t == 17)
            {
                ttd = defould_characters[17];
            }
            else if (random_t == 18)
            {
                ttd = defould_characters[18];
            }
            else if (random_t == 19)
            {
                ttd = defould_characters[19];
            }
            else if (random_t == 20)
            {
                ttd = defould_characters[20];
            }
            else if (random_t == 21)
            {
                ttd = defould_characters[21];
            }
            else if (random_t == 22)
            {
                ttd = defould_characters[22];
            }
            else if (random_t == 23)
            {
                ttd = defould_characters[23];
            }
            else if (random_t == 24)
            {
                ttd = defould_characters[24];
            }
            else if (random_t == 25)
            {
                ttd = defould_characters[25];
            }
            else if (random_t == 26)
            {
                ttd = defould_characters[26];
            }
            else if (random_t == 27)
            {
                ttd = defould_characters[27];
            }
            else if (random_t == 28)
            {
                ttd = defould_characters[28];
            }
            else if (random_t == 29)
            {
                ttd = defould_characters[29];
            }
            else if (random_t == 30)
            {
                ttd = defould_characters[30];
            }
            else if (random_t == 31)
            {
                ttd = defould_characters[31];
            }
            else if (random_t == 32)
            {
                ttd = defould_characters[32];
            }
            else if (random_t == 33)
            {
                ttd = defould_characters[33];
            }
            else if (random_t == 34)
            {
                ttd = defould_characters[34];
            }
            else if (random_t == 35)
            {
                ttd = defould_characters[35];
            }
            else if (random_t == 36)
            {
                ttd = defould_characters[36];
            }
            digit_5 = ttd;

            // digit_6
            random_t = rnd.Next(36);
            if (random_t == 0)
            {
                ttd = defould_characters[0];
            }
            else if (random_t == 1)
            {
                ttd = defould_characters[1];
            }
            else if (random_t == 2)
            {
                ttd = defould_characters[2];
            }
            else if (random_t == 3)
            {
                ttd = defould_characters[3];
            }
            else if (random_t == 4)
            {
                ttd = defould_characters[4];
            }
            else if (random_t == 5)
            {
                ttd = defould_characters[5];
            }
            else if (random_t == 6)
            {
                ttd = defould_characters[6];
            }
            else if (random_t == 7)
            {
                ttd = defould_characters[7];
            }
            else if (random_t == 8)
            {
                ttd = defould_characters[8];
            }
            else if (random_t == 9)
            {
                ttd = defould_characters[9];
            }
            else if (random_t == 10)
            {
                ttd = defould_characters[10];
            }
            else if (random_t == 11)
            {
                ttd = defould_characters[11];
            }
            else if (random_t == 12)
            {
                ttd = defould_characters[12];
            }
            else if (random_t == 13)
            {
                ttd = defould_characters[13];
            }
            else if (random_t == 14)
            {
                ttd = defould_characters[14];
            }
            else if (random_t == 15)
            {
                ttd = defould_characters[15];
            }
            else if (random_t == 16)
            {
                ttd = defould_characters[16];
            }
            else if (random_t == 17)
            {
                ttd = defould_characters[17];
            }
            else if (random_t == 18)
            {
                ttd = defould_characters[18];
            }
            else if (random_t == 19)
            {
                ttd = defould_characters[19];
            }
            else if (random_t == 20)
            {
                ttd = defould_characters[20];
            }
            else if (random_t == 21)
            {
                ttd = defould_characters[21];
            }
            else if (random_t == 22)
            {
                ttd = defould_characters[22];
            }
            else if (random_t == 23)
            {
                ttd = defould_characters[23];
            }
            else if (random_t == 24)
            {
                ttd = defould_characters[24];
            }
            else if (random_t == 25)
            {
                ttd = defould_characters[25];
            }
            else if (random_t == 26)
            {
                ttd = defould_characters[26];
            }
            else if (random_t == 27)
            {
                ttd = defould_characters[27];
            }
            else if (random_t == 28)
            {
                ttd = defould_characters[28];
            }
            else if (random_t == 29)
            {
                ttd = defould_characters[29];
            }
            else if (random_t == 30)
            {
                ttd = defould_characters[30];
            }
            else if (random_t == 31)
            {
                ttd = defould_characters[31];
            }
            else if (random_t == 32)
            {
                ttd = defould_characters[32];
            }
            else if (random_t == 33)
            {
                ttd = defould_characters[33];
            }
            else if (random_t == 34)
            {
                ttd = defould_characters[34];
            }
            else if (random_t == 35)
            {
                ttd = defould_characters[35];
            }
            else if (random_t == 36)
            {
                ttd = defould_characters[36];
            }
            digit_6 = ttd;

            // digit_7
            random_t = rnd.Next(36);
            if (random_t == 0)
            {
                ttd = defould_characters[0];
            }
            else if (random_t == 1)
            {
                ttd = defould_characters[1];
            }
            else if (random_t == 2)
            {
                ttd = defould_characters[2];
            }
            else if (random_t == 3)
            {
                ttd = defould_characters[3];
            }
            else if (random_t == 4)
            {
                ttd = defould_characters[4];
            }
            else if (random_t == 5)
            {
                ttd = defould_characters[5];
            }
            else if (random_t == 6)
            {
                ttd = defould_characters[6];
            }
            else if (random_t == 7)
            {
                ttd = defould_characters[7];
            }
            else if (random_t == 8)
            {
                ttd = defould_characters[8];
            }
            else if (random_t == 9)
            {
                ttd = defould_characters[9];
            }
            else if (random_t == 10)
            {
                ttd = defould_characters[10];
            }
            else if (random_t == 11)
            {
                ttd = defould_characters[11];
            }
            else if (random_t == 12)
            {
                ttd = defould_characters[12];
            }
            else if (random_t == 13)
            {
                ttd = defould_characters[13];
            }
            else if (random_t == 14)
            {
                ttd = defould_characters[14];
            }
            else if (random_t == 15)
            {
                ttd = defould_characters[15];
            }
            else if (random_t == 16)
            {
                ttd = defould_characters[16];
            }
            else if (random_t == 17)
            {
                ttd = defould_characters[17];
            }
            else if (random_t == 18)
            {
                ttd = defould_characters[18];
            }
            else if (random_t == 19)
            {
                ttd = defould_characters[19];
            }
            else if (random_t == 20)
            {
                ttd = defould_characters[20];
            }
            else if (random_t == 21)
            {
                ttd = defould_characters[21];
            }
            else if (random_t == 22)
            {
                ttd = defould_characters[22];
            }
            else if (random_t == 23)
            {
                ttd = defould_characters[23];
            }
            else if (random_t == 24)
            {
                ttd = defould_characters[24];
            }
            else if (random_t == 25)
            {
                ttd = defould_characters[25];
            }
            else if (random_t == 26)
            {
                ttd = defould_characters[26];
            }
            else if (random_t == 27)
            {
                ttd = defould_characters[27];
            }
            else if (random_t == 28)
            {
                ttd = defould_characters[28];
            }
            else if (random_t == 29)
            {
                ttd = defould_characters[29];
            }
            else if (random_t == 30)
            {
                ttd = defould_characters[30];
            }
            else if (random_t == 31)
            {
                ttd = defould_characters[31];
            }
            else if (random_t == 32)
            {
                ttd = defould_characters[32];
            }
            else if (random_t == 33)
            {
                ttd = defould_characters[33];
            }
            else if (random_t == 34)
            {
                ttd = defould_characters[34];
            }
            else if (random_t == 35)
            {
                ttd = defould_characters[35];
            }
            else if (random_t == 36)
            {
                ttd = defould_characters[36];
            }
            digit_7 = ttd;

            // digit_8
            random_t = rnd.Next(36);
            if (random_t == 0)
            {
                ttd = defould_characters[0];
            }
            else if (random_t == 1)
            {
                ttd = defould_characters[1];
            }
            else if (random_t == 2)
            {
                ttd = defould_characters[2];
            }
            else if (random_t == 3)
            {
                ttd = defould_characters[3];
            }
            else if (random_t == 4)
            {
                ttd = defould_characters[4];
            }
            else if (random_t == 5)
            {
                ttd = defould_characters[5];
            }
            else if (random_t == 6)
            {
                ttd = defould_characters[6];
            }
            else if (random_t == 7)
            {
                ttd = defould_characters[7];
            }
            else if (random_t == 8)
            {
                ttd = defould_characters[8];
            }
            else if (random_t == 9)
            {
                ttd = defould_characters[9];
            }
            else if (random_t == 10)
            {
                ttd = defould_characters[10];
            }
            else if (random_t == 11)
            {
                ttd = defould_characters[11];
            }
            else if (random_t == 12)
            {
                ttd = defould_characters[12];
            }
            else if (random_t == 13)
            {
                ttd = defould_characters[13];
            }
            else if (random_t == 14)
            {
                ttd = defould_characters[14];
            }
            else if (random_t == 15)
            {
                ttd = defould_characters[15];
            }
            else if (random_t == 16)
            {
                ttd = defould_characters[16];
            }
            else if (random_t == 17)
            {
                ttd = defould_characters[17];
            }
            else if (random_t == 18)
            {
                ttd = defould_characters[18];
            }
            else if (random_t == 19)
            {
                ttd = defould_characters[19];
            }
            else if (random_t == 20)
            {
                ttd = defould_characters[20];
            }
            else if (random_t == 21)
            {
                ttd = defould_characters[21];
            }
            else if (random_t == 22)
            {
                ttd = defould_characters[22];
            }
            else if (random_t == 23)
            {
                ttd = defould_characters[23];
            }
            else if (random_t == 24)
            {
                ttd = defould_characters[24];
            }
            else if (random_t == 25)
            {
                ttd = defould_characters[25];
            }
            else if (random_t == 26)
            {
                ttd = defould_characters[26];
            }
            else if (random_t == 27)
            {
                ttd = defould_characters[27];
            }
            else if (random_t == 28)
            {
                ttd = defould_characters[28];
            }
            else if (random_t == 29)
            {
                ttd = defould_characters[29];
            }
            else if (random_t == 30)
            {
                ttd = defould_characters[30];
            }
            else if (random_t == 31)
            {
                ttd = defould_characters[31];
            }
            else if (random_t == 32)
            {
                ttd = defould_characters[32];
            }
            else if (random_t == 33)
            {
                ttd = defould_characters[33];
            }
            else if (random_t == 34)
            {
                ttd = defould_characters[34];
            }
            else if (random_t == 35)
            {
                ttd = defould_characters[35];
            }
            else if (random_t == 36)
            {
                ttd = defould_characters[36];
            }
            digit_8 = ttd;

            // digit_9
            random_t = rnd.Next(36);
            if (random_t == 0)
            {
                ttd = defould_characters[0];
            }
            else if (random_t == 1)
            {
                ttd = defould_characters[1];
            }
            else if (random_t == 2)
            {
                ttd = defould_characters[2];
            }
            else if (random_t == 3)
            {
                ttd = defould_characters[3];
            }
            else if (random_t == 4)
            {
                ttd = defould_characters[4];
            }
            else if (random_t == 5)
            {
                ttd = defould_characters[5];
            }
            else if (random_t == 6)
            {
                ttd = defould_characters[6];
            }
            else if (random_t == 7)
            {
                ttd = defould_characters[7];
            }
            else if (random_t == 8)
            {
                ttd = defould_characters[8];
            }
            else if (random_t == 9)
            {
                ttd = defould_characters[9];
            }
            else if (random_t == 10)
            {
                ttd = defould_characters[10];
            }
            else if (random_t == 11)
            {
                ttd = defould_characters[11];
            }
            else if (random_t == 12)
            {
                ttd = defould_characters[12];
            }
            else if (random_t == 13)
            {
                ttd = defould_characters[13];
            }
            else if (random_t == 14)
            {
                ttd = defould_characters[14];
            }
            else if (random_t == 15)
            {
                ttd = defould_characters[15];
            }
            else if (random_t == 16)
            {
                ttd = defould_characters[16];
            }
            else if (random_t == 17)
            {
                ttd = defould_characters[17];
            }
            else if (random_t == 18)
            {
                ttd = defould_characters[18];
            }
            else if (random_t == 19)
            {
                ttd = defould_characters[19];
            }
            else if (random_t == 20)
            {
                ttd = defould_characters[20];
            }
            else if (random_t == 21)
            {
                ttd = defould_characters[21];
            }
            else if (random_t == 22)
            {
                ttd = defould_characters[22];
            }
            else if (random_t == 23)
            {
                ttd = defould_characters[23];
            }
            else if (random_t == 24)
            {
                ttd = defould_characters[24];
            }
            else if (random_t == 25)
            {
                ttd = defould_characters[25];
            }
            else if (random_t == 26)
            {
                ttd = defould_characters[26];
            }
            else if (random_t == 27)
            {
                ttd = defould_characters[27];
            }
            else if (random_t == 28)
            {
                ttd = defould_characters[28];
            }
            else if (random_t == 29)
            {
                ttd = defould_characters[29];
            }
            else if (random_t == 30)
            {
                ttd = defould_characters[30];
            }
            else if (random_t == 31)
            {
                ttd = defould_characters[31];
            }
            else if (random_t == 32)
            {
                ttd = defould_characters[32];
            }
            else if (random_t == 33)
            {
                ttd = defould_characters[33];
            }
            else if (random_t == 34)
            {
                ttd = defould_characters[34];
            }
            else if (random_t == 35)
            {
                ttd = defould_characters[35];
            }
            else if (random_t == 36)
            {
                ttd = defould_characters[36];
            }
            digit_9 = ttd;

            // digit_10
            random_t = rnd.Next(36);
            if (random_t == 0)
            {
                ttd = defould_characters[0];
            }
            else if (random_t == 1)
            {
                ttd = defould_characters[1];
            }
            else if (random_t == 2)
            {
                ttd = defould_characters[2];
            }
            else if (random_t == 3)
            {
                ttd = defould_characters[3];
            }
            else if (random_t == 4)
            {
                ttd = defould_characters[4];
            }
            else if (random_t == 5)
            {
                ttd = defould_characters[5];
            }
            else if (random_t == 6)
            {
                ttd = defould_characters[6];
            }
            else if (random_t == 7)
            {
                ttd = defould_characters[7];
            }
            else if (random_t == 8)
            {
                ttd = defould_characters[8];
            }
            else if (random_t == 9)
            {
                ttd = defould_characters[9];
            }
            else if (random_t == 10)
            {
                ttd = defould_characters[10];
            }
            else if (random_t == 11)
            {
                ttd = defould_characters[11];
            }
            else if (random_t == 12)
            {
                ttd = defould_characters[12];
            }
            else if (random_t == 13)
            {
                ttd = defould_characters[13];
            }
            else if (random_t == 14)
            {
                ttd = defould_characters[14];
            }
            else if (random_t == 15)
            {
                ttd = defould_characters[15];
            }
            else if (random_t == 16)
            {
                ttd = defould_characters[16];
            }
            else if (random_t == 17)
            {
                ttd = defould_characters[17];
            }
            else if (random_t == 18)
            {
                ttd = defould_characters[18];
            }
            else if (random_t == 19)
            {
                ttd = defould_characters[19];
            }
            else if (random_t == 20)
            {
                ttd = defould_characters[20];
            }
            else if (random_t == 21)
            {
                ttd = defould_characters[21];
            }
            else if (random_t == 22)
            {
                ttd = defould_characters[22];
            }
            else if (random_t == 23)
            {
                ttd = defould_characters[23];
            }
            else if (random_t == 24)
            {
                ttd = defould_characters[24];
            }
            else if (random_t == 25)
            {
                ttd = defould_characters[25];
            }
            else if (random_t == 26)
            {
                ttd = defould_characters[26];
            }
            else if (random_t == 27)
            {
                ttd = defould_characters[27];
            }
            else if (random_t == 28)
            {
                ttd = defould_characters[28];
            }
            else if (random_t == 29)
            {
                ttd = defould_characters[29];
            }
            else if (random_t == 30)
            {
                ttd = defould_characters[30];
            }
            else if (random_t == 31)
            {
                ttd = defould_characters[31];
            }
            else if (random_t == 32)
            {
                ttd = defould_characters[32];
            }
            else if (random_t == 33)
            {
                ttd = defould_characters[33];
            }
            else if (random_t == 34)
            {
                ttd = defould_characters[34];
            }
            else if (random_t == 35)
            {
                ttd = defould_characters[35];
            }
            else if (random_t == 36)
            {
                ttd = defould_characters[36];
            }
            digit_10 = ttd;

            // digit_11
            random_t = rnd.Next(36);
            if (random_t == 0)
            {
                ttd = defould_characters[0];
            }
            else if (random_t == 1)
            {
                ttd = defould_characters[1];
            }
            else if (random_t == 2)
            {
                ttd = defould_characters[2];
            }
            else if (random_t == 3)
            {
                ttd = defould_characters[3];
            }
            else if (random_t == 4)
            {
                ttd = defould_characters[4];
            }
            else if (random_t == 5)
            {
                ttd = defould_characters[5];
            }
            else if (random_t == 6)
            {
                ttd = defould_characters[6];
            }
            else if (random_t == 7)
            {
                ttd = defould_characters[7];
            }
            else if (random_t == 8)
            {
                ttd = defould_characters[8];
            }
            else if (random_t == 9)
            {
                ttd = defould_characters[9];
            }
            else if (random_t == 10)
            {
                ttd = defould_characters[10];
            }
            else if (random_t == 11)
            {
                ttd = defould_characters[11];
            }
            else if (random_t == 12)
            {
                ttd = defould_characters[12];
            }
            else if (random_t == 13)
            {
                ttd = defould_characters[13];
            }
            else if (random_t == 14)
            {
                ttd = defould_characters[14];
            }
            else if (random_t == 15)
            {
                ttd = defould_characters[15];
            }
            else if (random_t == 16)
            {
                ttd = defould_characters[16];
            }
            else if (random_t == 17)
            {
                ttd = defould_characters[17];
            }
            else if (random_t == 18)
            {
                ttd = defould_characters[18];
            }
            else if (random_t == 19)
            {
                ttd = defould_characters[19];
            }
            else if (random_t == 20)
            {
                ttd = defould_characters[20];
            }
            else if (random_t == 21)
            {
                ttd = defould_characters[21];
            }
            else if (random_t == 22)
            {
                ttd = defould_characters[22];
            }
            else if (random_t == 23)
            {
                ttd = defould_characters[23];
            }
            else if (random_t == 24)
            {
                ttd = defould_characters[24];
            }
            else if (random_t == 25)
            {
                ttd = defould_characters[25];
            }
            else if (random_t == 26)
            {
                ttd = defould_characters[26];
            }
            else if (random_t == 27)
            {
                ttd = defould_characters[27];
            }
            else if (random_t == 28)
            {
                ttd = defould_characters[28];
            }
            else if (random_t == 29)
            {
                ttd = defould_characters[29];
            }
            else if (random_t == 30)
            {
                ttd = defould_characters[30];
            }
            else if (random_t == 31)
            {
                ttd = defould_characters[31];
            }
            else if (random_t == 32)
            {
                ttd = defould_characters[32];
            }
            else if (random_t == 33)
            {
                ttd = defould_characters[33];
            }
            else if (random_t == 34)
            {
                ttd = defould_characters[34];
            }
            else if (random_t == 35)
            {
                ttd = defould_characters[35];
            }
            else if (random_t == 36)
            {
                ttd = defould_characters[36];
            }
            digit_11 = ttd;

            // digit_12
            random_t = rnd.Next(36);
            if (random_t == 0)
            {
                ttd = defould_characters[0];
            }
            else if (random_t == 1)
            {
                ttd = defould_characters[1];
            }
            else if (random_t == 2)
            {
                ttd = defould_characters[2];
            }
            else if (random_t == 3)
            {
                ttd = defould_characters[3];
            }
            else if (random_t == 4)
            {
                ttd = defould_characters[4];
            }
            else if (random_t == 5)
            {
                ttd = defould_characters[5];
            }
            else if (random_t == 6)
            {
                ttd = defould_characters[6];
            }
            else if (random_t == 7)
            {
                ttd = defould_characters[7];
            }
            else if (random_t == 8)
            {
                ttd = defould_characters[8];
            }
            else if (random_t == 9)
            {
                ttd = defould_characters[9];
            }
            else if (random_t == 10)
            {
                ttd = defould_characters[10];
            }
            else if (random_t == 11)
            {
                ttd = defould_characters[11];
            }
            else if (random_t == 12)
            {
                ttd = defould_characters[12];
            }
            else if (random_t == 13)
            {
                ttd = defould_characters[13];
            }
            else if (random_t == 14)
            {
                ttd = defould_characters[14];
            }
            else if (random_t == 15)
            {
                ttd = defould_characters[15];
            }
            else if (random_t == 16)
            {
                ttd = defould_characters[16];
            }
            else if (random_t == 17)
            {
                ttd = defould_characters[17];
            }
            else if (random_t == 18)
            {
                ttd = defould_characters[18];
            }
            else if (random_t == 19)
            {
                ttd = defould_characters[19];
            }
            else if (random_t == 20)
            {
                ttd = defould_characters[20];
            }
            else if (random_t == 21)
            {
                ttd = defould_characters[21];
            }
            else if (random_t == 22)
            {
                ttd = defould_characters[22];
            }
            else if (random_t == 23)
            {
                ttd = defould_characters[23];
            }
            else if (random_t == 24)
            {
                ttd = defould_characters[24];
            }
            else if (random_t == 25)
            {
                ttd = defould_characters[25];
            }
            else if (random_t == 26)
            {
                ttd = defould_characters[26];
            }
            else if (random_t == 27)
            {
                ttd = defould_characters[27];
            }
            else if (random_t == 28)
            {
                ttd = defould_characters[28];
            }
            else if (random_t == 29)
            {
                ttd = defould_characters[29];
            }
            else if (random_t == 30)
            {
                ttd = defould_characters[30];
            }
            else if (random_t == 31)
            {
                ttd = defould_characters[31];
            }
            else if (random_t == 32)
            {
                ttd = defould_characters[32];
            }
            else if (random_t == 33)
            {
                ttd = defould_characters[33];
            }
            else if (random_t == 34)
            {
                ttd = defould_characters[34];
            }
            else if (random_t == 35)
            {
                ttd = defould_characters[35];
            }
            else if (random_t == 36)
            {
                ttd = defould_characters[36];
            }
            digit_12 = ttd;

            // digit_14
            random_t = rnd.Next(36);
            if (random_t == 0)
            {
                ttd = defould_characters[0];
            }
            else if (random_t == 1)
            {
                ttd = defould_characters[1];
            }
            else if (random_t == 2)
            {
                ttd = defould_characters[2];
            }
            else if (random_t == 3)
            {
                ttd = defould_characters[3];
            }
            else if (random_t == 4)
            {
                ttd = defould_characters[4];
            }
            else if (random_t == 5)
            {
                ttd = defould_characters[5];
            }
            else if (random_t == 6)
            {
                ttd = defould_characters[6];
            }
            else if (random_t == 7)
            {
                ttd = defould_characters[7];
            }
            else if (random_t == 8)
            {
                ttd = defould_characters[8];
            }
            else if (random_t == 9)
            {
                ttd = defould_characters[9];
            }
            else if (random_t == 10)
            {
                ttd = defould_characters[10];
            }
            else if (random_t == 11)
            {
                ttd = defould_characters[11];
            }
            else if (random_t == 12)
            {
                ttd = defould_characters[12];
            }
            else if (random_t == 13)
            {
                ttd = defould_characters[13];
            }
            else if (random_t == 14)
            {
                ttd = defould_characters[14];
            }
            else if (random_t == 15)
            {
                ttd = defould_characters[15];
            }
            else if (random_t == 16)
            {
                ttd = defould_characters[16];
            }
            else if (random_t == 17)
            {
                ttd = defould_characters[17];
            }
            else if (random_t == 18)
            {
                ttd = defould_characters[18];
            }
            else if (random_t == 19)
            {
                ttd = defould_characters[19];
            }
            else if (random_t == 20)
            {
                ttd = defould_characters[20];
            }
            else if (random_t == 21)
            {
                ttd = defould_characters[21];
            }
            else if (random_t == 22)
            {
                ttd = defould_characters[22];
            }
            else if (random_t == 23)
            {
                ttd = defould_characters[23];
            }
            else if (random_t == 24)
            {
                ttd = defould_characters[24];
            }
            else if (random_t == 25)
            {
                ttd = defould_characters[25];
            }
            else if (random_t == 26)
            {
                ttd = defould_characters[26];
            }
            else if (random_t == 27)
            {
                ttd = defould_characters[27];
            }
            else if (random_t == 28)
            {
                ttd = defould_characters[28];
            }
            else if (random_t == 29)
            {
                ttd = defould_characters[29];
            }
            else if (random_t == 30)
            {
                ttd = defould_characters[30];
            }
            else if (random_t == 31)
            {
                ttd = defould_characters[31];
            }
            else if (random_t == 32)
            {
                ttd = defould_characters[32];
            }
            else if (random_t == 33)
            {
                ttd = defould_characters[33];
            }
            else if (random_t == 34)
            {
                ttd = defould_characters[34];
            }
            else if (random_t == 35)
            {
                ttd = defould_characters[35];
            }
            else if (random_t == 36)
            {
                ttd = defould_characters[36];
            }
            digit_14 = ttd;

            // digit_13
            random_t = rnd.Next(36);
            if (random_t == 0)
            {
                ttd = defould_characters[0];
            }
            else if (random_t == 1)
            {
                ttd = defould_characters[1];
            }
            else if (random_t == 2)
            {
                ttd = defould_characters[2];
            }
            else if (random_t == 3)
            {
                ttd = defould_characters[3];
            }
            else if (random_t == 4)
            {
                ttd = defould_characters[4];
            }
            else if (random_t == 5)
            {
                ttd = defould_characters[5];
            }
            else if (random_t == 6)
            {
                ttd = defould_characters[6];
            }
            else if (random_t == 7)
            {
                ttd = defould_characters[7];
            }
            else if (random_t == 8)
            {
                ttd = defould_characters[8];
            }
            else if (random_t == 9)
            {
                ttd = defould_characters[9];
            }
            else if (random_t == 10)
            {
                ttd = defould_characters[10];
            }
            else if (random_t == 11)
            {
                ttd = defould_characters[11];
            }
            else if (random_t == 12)
            {
                ttd = defould_characters[12];
            }
            else if (random_t == 13)
            {
                ttd = defould_characters[13];
            }
            else if (random_t == 14)
            {
                ttd = defould_characters[14];
            }
            else if (random_t == 15)
            {
                ttd = defould_characters[15];
            }
            else if (random_t == 16)
            {
                ttd = defould_characters[16];
            }
            else if (random_t == 17)
            {
                ttd = defould_characters[17];
            }
            else if (random_t == 18)
            {
                ttd = defould_characters[18];
            }
            else if (random_t == 19)
            {
                ttd = defould_characters[19];
            }
            else if (random_t == 20)
            {
                ttd = defould_characters[20];
            }
            else if (random_t == 21)
            {
                ttd = defould_characters[21];
            }
            else if (random_t == 22)
            {
                ttd = defould_characters[22];
            }
            else if (random_t == 23)
            {
                ttd = defould_characters[23];
            }
            else if (random_t == 24)
            {
                ttd = defould_characters[24];
            }
            else if (random_t == 25)
            {
                ttd = defould_characters[25];
            }
            else if (random_t == 26)
            {
                ttd = defould_characters[26];
            }
            else if (random_t == 27)
            {
                ttd = defould_characters[27];
            }
            else if (random_t == 28)
            {
                ttd = defould_characters[28];
            }
            else if (random_t == 29)
            {
                ttd = defould_characters[29];
            }
            else if (random_t == 30)
            {
                ttd = defould_characters[30];
            }
            else if (random_t == 31)
            {
                ttd = defould_characters[31];
            }
            else if (random_t == 32)
            {
                ttd = defould_characters[32];
            }
            else if (random_t == 33)
            {
                ttd = defould_characters[33];
            }
            else if (random_t == 34)
            {
                ttd = defould_characters[34];
            }
            else if (random_t == 35)
            {
                ttd = defould_characters[35];
            }
            else if (random_t == 36)
            {
                ttd = defould_characters[36];
            }
            digit_13 = ttd;

            // digit_14
            random_t = rnd.Next(36);
            if (random_t == 0)
            {
                ttd = defould_characters[0];
            }
            else if (random_t == 1)
            {
                ttd = defould_characters[1];
            }
            else if (random_t == 2)
            {
                ttd = defould_characters[2];
            }
            else if (random_t == 3)
            {
                ttd = defould_characters[3];
            }
            else if (random_t == 4)
            {
                ttd = defould_characters[4];
            }
            else if (random_t == 5)
            {
                ttd = defould_characters[5];
            }
            else if (random_t == 6)
            {
                ttd = defould_characters[6];
            }
            else if (random_t == 7)
            {
                ttd = defould_characters[7];
            }
            else if (random_t == 8)
            {
                ttd = defould_characters[8];
            }
            else if (random_t == 9)
            {
                ttd = defould_characters[9];
            }
            else if (random_t == 10)
            {
                ttd = defould_characters[10];
            }
            else if (random_t == 11)
            {
                ttd = defould_characters[11];
            }
            else if (random_t == 12)
            {
                ttd = defould_characters[12];
            }
            else if (random_t == 13)
            {
                ttd = defould_characters[13];
            }
            else if (random_t == 14)
            {
                ttd = defould_characters[14];
            }
            else if (random_t == 15)
            {
                ttd = defould_characters[15];
            }
            else if (random_t == 16)
            {
                ttd = defould_characters[16];
            }
            else if (random_t == 17)
            {
                ttd = defould_characters[17];
            }
            else if (random_t == 18)
            {
                ttd = defould_characters[18];
            }
            else if (random_t == 19)
            {
                ttd = defould_characters[19];
            }
            else if (random_t == 20)
            {
                ttd = defould_characters[20];
            }
            else if (random_t == 21)
            {
                ttd = defould_characters[21];
            }
            else if (random_t == 22)
            {
                ttd = defould_characters[22];
            }
            else if (random_t == 23)
            {
                ttd = defould_characters[23];
            }
            else if (random_t == 24)
            {
                ttd = defould_characters[24];
            }
            else if (random_t == 25)
            {
                ttd = defould_characters[25];
            }
            else if (random_t == 26)
            {
                ttd = defould_characters[26];
            }
            else if (random_t == 27)
            {
                ttd = defould_characters[27];
            }
            else if (random_t == 28)
            {
                ttd = defould_characters[28];
            }
            else if (random_t == 29)
            {
                ttd = defould_characters[29];
            }
            else if (random_t == 30)
            {
                ttd = defould_characters[30];
            }
            else if (random_t == 31)
            {
                ttd = defould_characters[31];
            }
            else if (random_t == 32)
            {
                ttd = defould_characters[32];
            }
            else if (random_t == 33)
            {
                ttd = defould_characters[33];
            }
            else if (random_t == 34)
            {
                ttd = defould_characters[34];
            }
            else if (random_t == 35)
            {
                ttd = defould_characters[35];
            }
            else if (random_t == 36)
            {
                ttd = defould_characters[36];
            }
            digit_14 = ttd;

            // digit_15
            random_t = rnd.Next(36);
            if (random_t == 0)
            {
                ttd = defould_characters[0];
            }
            else if (random_t == 1)
            {
                ttd = defould_characters[1];
            }
            else if (random_t == 2)
            {
                ttd = defould_characters[2];
            }
            else if (random_t == 3)
            {
                ttd = defould_characters[3];
            }
            else if (random_t == 4)
            {
                ttd = defould_characters[4];
            }
            else if (random_t == 5)
            {
                ttd = defould_characters[5];
            }
            else if (random_t == 6)
            {
                ttd = defould_characters[6];
            }
            else if (random_t == 7)
            {
                ttd = defould_characters[7];
            }
            else if (random_t == 8)
            {
                ttd = defould_characters[8];
            }
            else if (random_t == 9)
            {
                ttd = defould_characters[9];
            }
            else if (random_t == 10)
            {
                ttd = defould_characters[10];
            }
            else if (random_t == 11)
            {
                ttd = defould_characters[11];
            }
            else if (random_t == 12)
            {
                ttd = defould_characters[12];
            }
            else if (random_t == 13)
            {
                ttd = defould_characters[13];
            }
            else if (random_t == 14)
            {
                ttd = defould_characters[14];
            }
            else if (random_t == 15)
            {
                ttd = defould_characters[15];
            }
            else if (random_t == 16)
            {
                ttd = defould_characters[16];
            }
            else if (random_t == 17)
            {
                ttd = defould_characters[17];
            }
            else if (random_t == 18)
            {
                ttd = defould_characters[18];
            }
            else if (random_t == 19)
            {
                ttd = defould_characters[19];
            }
            else if (random_t == 20)
            {
                ttd = defould_characters[20];
            }
            else if (random_t == 21)
            {
                ttd = defould_characters[21];
            }
            else if (random_t == 22)
            {
                ttd = defould_characters[22];
            }
            else if (random_t == 23)
            {
                ttd = defould_characters[23];
            }
            else if (random_t == 24)
            {
                ttd = defould_characters[24];
            }
            else if (random_t == 25)
            {
                ttd = defould_characters[25];
            }
            else if (random_t == 26)
            {
                ttd = defould_characters[26];
            }
            else if (random_t == 27)
            {
                ttd = defould_characters[27];
            }
            else if (random_t == 28)
            {
                ttd = defould_characters[28];
            }
            else if (random_t == 29)
            {
                ttd = defould_characters[29];
            }
            else if (random_t == 30)
            {
                ttd = defould_characters[30];
            }
            else if (random_t == 31)
            {
                ttd = defould_characters[31];
            }
            else if (random_t == 32)
            {
                ttd = defould_characters[32];
            }
            else if (random_t == 33)
            {
                ttd = defould_characters[33];
            }
            else if (random_t == 34)
            {
                ttd = defould_characters[34];
            }
            else if (random_t == 35)
            {
                ttd = defould_characters[35];
            }
            else if (random_t == 36)
            {
                ttd = defould_characters[36];
            }
            digit_15 = ttd;

            // digit_16
            random_t = rnd.Next(36);
            if (random_t == 0)
            {
                ttd = defould_characters[0];
            }
            else if (random_t == 1)
            {
                ttd = defould_characters[1];
            }
            else if (random_t == 2)
            {
                ttd = defould_characters[2];
            }
            else if (random_t == 3)
            {
                ttd = defould_characters[3];
            }
            else if (random_t == 4)
            {
                ttd = defould_characters[4];
            }
            else if (random_t == 5)
            {
                ttd = defould_characters[5];
            }
            else if (random_t == 6)
            {
                ttd = defould_characters[6];
            }
            else if (random_t == 7)
            {
                ttd = defould_characters[7];
            }
            else if (random_t == 8)
            {
                ttd = defould_characters[8];
            }
            else if (random_t == 9)
            {
                ttd = defould_characters[9];
            }
            else if (random_t == 10)
            {
                ttd = defould_characters[10];
            }
            else if (random_t == 11)
            {
                ttd = defould_characters[11];
            }
            else if (random_t == 12)
            {
                ttd = defould_characters[12];
            }
            else if (random_t == 13)
            {
                ttd = defould_characters[13];
            }
            else if (random_t == 14)
            {
                ttd = defould_characters[14];
            }
            else if (random_t == 15)
            {
                ttd = defould_characters[15];
            }
            else if (random_t == 16)
            {
                ttd = defould_characters[16];
            }
            else if (random_t == 17)
            {
                ttd = defould_characters[17];
            }
            else if (random_t == 18)
            {
                ttd = defould_characters[18];
            }
            else if (random_t == 19)
            {
                ttd = defould_characters[19];
            }
            else if (random_t == 20)
            {
                ttd = defould_characters[20];
            }
            else if (random_t == 21)
            {
                ttd = defould_characters[21];
            }
            else if (random_t == 22)
            {
                ttd = defould_characters[22];
            }
            else if (random_t == 23)
            {
                ttd = defould_characters[23];
            }
            else if (random_t == 24)
            {
                ttd = defould_characters[24];
            }
            else if (random_t == 25)
            {
                ttd = defould_characters[25];
            }
            else if (random_t == 26)
            {
                ttd = defould_characters[26];
            }
            else if (random_t == 27)
            {
                ttd = defould_characters[27];
            }
            else if (random_t == 28)
            {
                ttd = defould_characters[28];
            }
            else if (random_t == 29)
            {
                ttd = defould_characters[29];
            }
            else if (random_t == 30)
            {
                ttd = defould_characters[30];
            }
            else if (random_t == 31)
            {
                ttd = defould_characters[31];
            }
            else if (random_t == 32)
            {
                ttd = defould_characters[32];
            }
            else if (random_t == 33)
            {
                ttd = defould_characters[33];
            }
            else if (random_t == 34)
            {
                ttd = defould_characters[34];
            }
            else if (random_t == 35)
            {
                ttd = defould_characters[35];
            }
            else if (random_t == 36)
            {
                ttd = defould_characters[36];
            }
            digit_16 = ttd;

            // digit_17
            random_t = rnd.Next(36);
            if (random_t == 0)
            {
                ttd = defould_characters[0];
            }
            else if (random_t == 1)
            {
                ttd = defould_characters[1];
            }
            else if (random_t == 2)
            {
                ttd = defould_characters[2];
            }
            else if (random_t == 3)
            {
                ttd = defould_characters[3];
            }
            else if (random_t == 4)
            {
                ttd = defould_characters[4];
            }
            else if (random_t == 5)
            {
                ttd = defould_characters[5];
            }
            else if (random_t == 6)
            {
                ttd = defould_characters[6];
            }
            else if (random_t == 7)
            {
                ttd = defould_characters[7];
            }
            else if (random_t == 8)
            {
                ttd = defould_characters[8];
            }
            else if (random_t == 9)
            {
                ttd = defould_characters[9];
            }
            else if (random_t == 10)
            {
                ttd = defould_characters[10];
            }
            else if (random_t == 11)
            {
                ttd = defould_characters[11];
            }
            else if (random_t == 12)
            {
                ttd = defould_characters[12];
            }
            else if (random_t == 13)
            {
                ttd = defould_characters[13];
            }
            else if (random_t == 14)
            {
                ttd = defould_characters[14];
            }
            else if (random_t == 15)
            {
                ttd = defould_characters[15];
            }
            else if (random_t == 16)
            {
                ttd = defould_characters[16];
            }
            else if (random_t == 17)
            {
                ttd = defould_characters[17];
            }
            else if (random_t == 18)
            {
                ttd = defould_characters[18];
            }
            else if (random_t == 19)
            {
                ttd = defould_characters[19];
            }
            else if (random_t == 20)
            {
                ttd = defould_characters[20];
            }
            else if (random_t == 21)
            {
                ttd = defould_characters[21];
            }
            else if (random_t == 22)
            {
                ttd = defould_characters[22];
            }
            else if (random_t == 23)
            {
                ttd = defould_characters[23];
            }
            else if (random_t == 24)
            {
                ttd = defould_characters[24];
            }
            else if (random_t == 25)
            {
                ttd = defould_characters[25];
            }
            else if (random_t == 26)
            {
                ttd = defould_characters[26];
            }
            else if (random_t == 27)
            {
                ttd = defould_characters[27];
            }
            else if (random_t == 28)
            {
                ttd = defould_characters[28];
            }
            else if (random_t == 29)
            {
                ttd = defould_characters[29];
            }
            else if (random_t == 30)
            {
                ttd = defould_characters[30];
            }
            else if (random_t == 31)
            {
                ttd = defould_characters[31];
            }
            else if (random_t == 32)
            {
                ttd = defould_characters[32];
            }
            else if (random_t == 33)
            {
                ttd = defould_characters[33];
            }
            else if (random_t == 34)
            {
                ttd = defould_characters[34];
            }
            else if (random_t == 35)
            {
                ttd = defould_characters[35];
            }
            else if (random_t == 36)
            {
                ttd = defould_characters[36];
            }
            digit_17 = ttd;

            // digit_18
            random_t = rnd.Next(36);
            if (random_t == 0)
            {
                ttd = defould_characters[0];
            }
            else if (random_t == 1)
            {
                ttd = defould_characters[1];
            }
            else if (random_t == 2)
            {
                ttd = defould_characters[2];
            }
            else if (random_t == 3)
            {
                ttd = defould_characters[3];
            }
            else if (random_t == 4)
            {
                ttd = defould_characters[4];
            }
            else if (random_t == 5)
            {
                ttd = defould_characters[5];
            }
            else if (random_t == 6)
            {
                ttd = defould_characters[6];
            }
            else if (random_t == 7)
            {
                ttd = defould_characters[7];
            }
            else if (random_t == 8)
            {
                ttd = defould_characters[8];
            }
            else if (random_t == 9)
            {
                ttd = defould_characters[9];
            }
            else if (random_t == 10)
            {
                ttd = defould_characters[10];
            }
            else if (random_t == 11)
            {
                ttd = defould_characters[11];
            }
            else if (random_t == 12)
            {
                ttd = defould_characters[12];
            }
            else if (random_t == 13)
            {
                ttd = defould_characters[13];
            }
            else if (random_t == 14)
            {
                ttd = defould_characters[14];
            }
            else if (random_t == 15)
            {
                ttd = defould_characters[15];
            }
            else if (random_t == 16)
            {
                ttd = defould_characters[16];
            }
            else if (random_t == 17)
            {
                ttd = defould_characters[17];
            }
            else if (random_t == 18)
            {
                ttd = defould_characters[18];
            }
            else if (random_t == 19)
            {
                ttd = defould_characters[19];
            }
            else if (random_t == 20)
            {
                ttd = defould_characters[20];
            }
            else if (random_t == 21)
            {
                ttd = defould_characters[21];
            }
            else if (random_t == 22)
            {
                ttd = defould_characters[22];
            }
            else if (random_t == 23)
            {
                ttd = defould_characters[23];
            }
            else if (random_t == 24)
            {
                ttd = defould_characters[24];
            }
            else if (random_t == 25)
            {
                ttd = defould_characters[25];
            }
            else if (random_t == 26)
            {
                ttd = defould_characters[26];
            }
            else if (random_t == 27)
            {
                ttd = defould_characters[27];
            }
            else if (random_t == 28)
            {
                ttd = defould_characters[28];
            }
            else if (random_t == 29)
            {
                ttd = defould_characters[29];
            }
            else if (random_t == 30)
            {
                ttd = defould_characters[30];
            }
            else if (random_t == 31)
            {
                ttd = defould_characters[31];
            }
            else if (random_t == 32)
            {
                ttd = defould_characters[32];
            }
            else if (random_t == 33)
            {
                ttd = defould_characters[33];
            }
            else if (random_t == 34)
            {
                ttd = defould_characters[34];
            }
            else if (random_t == 35)
            {
                ttd = defould_characters[35];
            }
            else if (random_t == 36)
            {
                ttd = defould_characters[36];
            }
            digit_18 = ttd;

            // digit_19
            random_t = rnd.Next(36);
            if (random_t == 0)
            {
                ttd = defould_characters[0];
            }
            else if (random_t == 1)
            {
                ttd = defould_characters[1];
            }
            else if (random_t == 2)
            {
                ttd = defould_characters[2];
            }
            else if (random_t == 3)
            {
                ttd = defould_characters[3];
            }
            else if (random_t == 4)
            {
                ttd = defould_characters[4];
            }
            else if (random_t == 5)
            {
                ttd = defould_characters[5];
            }
            else if (random_t == 6)
            {
                ttd = defould_characters[6];
            }
            else if (random_t == 7)
            {
                ttd = defould_characters[7];
            }
            else if (random_t == 8)
            {
                ttd = defould_characters[8];
            }
            else if (random_t == 9)
            {
                ttd = defould_characters[9];
            }
            else if (random_t == 10)
            {
                ttd = defould_characters[10];
            }
            else if (random_t == 11)
            {
                ttd = defould_characters[11];
            }
            else if (random_t == 12)
            {
                ttd = defould_characters[12];
            }
            else if (random_t == 13)
            {
                ttd = defould_characters[13];
            }
            else if (random_t == 14)
            {
                ttd = defould_characters[14];
            }
            else if (random_t == 15)
            {
                ttd = defould_characters[15];
            }
            else if (random_t == 16)
            {
                ttd = defould_characters[16];
            }
            else if (random_t == 17)
            {
                ttd = defould_characters[17];
            }
            else if (random_t == 18)
            {
                ttd = defould_characters[18];
            }
            else if (random_t == 19)
            {
                ttd = defould_characters[19];
            }
            else if (random_t == 20)
            {
                ttd = defould_characters[20];
            }
            else if (random_t == 21)
            {
                ttd = defould_characters[21];
            }
            else if (random_t == 22)
            {
                ttd = defould_characters[22];
            }
            else if (random_t == 23)
            {
                ttd = defould_characters[23];
            }
            else if (random_t == 24)
            {
                ttd = defould_characters[24];
            }
            else if (random_t == 25)
            {
                ttd = defould_characters[25];
            }
            else if (random_t == 26)
            {
                ttd = defould_characters[26];
            }
            else if (random_t == 27)
            {
                ttd = defould_characters[27];
            }
            else if (random_t == 28)
            {
                ttd = defould_characters[28];
            }
            else if (random_t == 29)
            {
                ttd = defould_characters[29];
            }
            else if (random_t == 30)
            {
                ttd = defould_characters[30];
            }
            else if (random_t == 31)
            {
                ttd = defould_characters[31];
            }
            else if (random_t == 32)
            {
                ttd = defould_characters[32];
            }
            else if (random_t == 33)
            {
                ttd = defould_characters[33];
            }
            else if (random_t == 34)
            {
                ttd = defould_characters[34];
            }
            else if (random_t == 35)
            {
                ttd = defould_characters[35];
            }
            else if (random_t == 36)
            {
                ttd = defould_characters[36];
            }
            digit_19 = ttd;

            // digit_20
            random_t = rnd.Next(36);
            if (random_t == 0)
            {
                ttd = defould_characters[0];
            }
            else if (random_t == 1)
            {
                ttd = defould_characters[1];
            }
            else if (random_t == 2)
            {
                ttd = defould_characters[2];
            }
            else if (random_t == 3)
            {
                ttd = defould_characters[3];
            }
            else if (random_t == 4)
            {
                ttd = defould_characters[4];
            }
            else if (random_t == 5)
            {
                ttd = defould_characters[5];
            }
            else if (random_t == 6)
            {
                ttd = defould_characters[6];
            }
            else if (random_t == 7)
            {
                ttd = defould_characters[7];
            }
            else if (random_t == 8)
            {
                ttd = defould_characters[8];
            }
            else if (random_t == 9)
            {
                ttd = defould_characters[9];
            }
            else if (random_t == 10)
            {
                ttd = defould_characters[10];
            }
            else if (random_t == 11)
            {
                ttd = defould_characters[11];
            }
            else if (random_t == 12)
            {
                ttd = defould_characters[12];
            }
            else if (random_t == 13)
            {
                ttd = defould_characters[13];
            }
            else if (random_t == 14)
            {
                ttd = defould_characters[14];
            }
            else if (random_t == 15)
            {
                ttd = defould_characters[15];
            }
            else if (random_t == 16)
            {
                ttd = defould_characters[16];
            }
            else if (random_t == 17)
            {
                ttd = defould_characters[17];
            }
            else if (random_t == 18)
            {
                ttd = defould_characters[18];
            }
            else if (random_t == 19)
            {
                ttd = defould_characters[19];
            }
            else if (random_t == 20)
            {
                ttd = defould_characters[20];
            }
            else if (random_t == 21)
            {
                ttd = defould_characters[21];
            }
            else if (random_t == 22)
            {
                ttd = defould_characters[22];
            }
            else if (random_t == 23)
            {
                ttd = defould_characters[23];
            }
            else if (random_t == 24)
            {
                ttd = defould_characters[24];
            }
            else if (random_t == 25)
            {
                ttd = defould_characters[25];
            }
            else if (random_t == 26)
            {
                ttd = defould_characters[26];
            }
            else if (random_t == 27)
            {
                ttd = defould_characters[27];
            }
            else if (random_t == 28)
            {
                ttd = defould_characters[28];
            }
            else if (random_t == 29)
            {
                ttd = defould_characters[29];
            }
            else if (random_t == 30)
            {
                ttd = defould_characters[30];
            }
            else if (random_t == 31)
            {
                ttd = defould_characters[31];
            }
            else if (random_t == 32)
            {
                ttd = defould_characters[32];
            }
            else if (random_t == 33)
            {
                ttd = defould_characters[33];
            }
            else if (random_t == 34)
            {
                ttd = defould_characters[34];
            }
            else if (random_t == 35)
            {
                ttd = defould_characters[35];
            }
            else if (random_t == 36)
            {
                ttd = defould_characters[36];
            }
            digit_20 = ttd;

            var ıquı = "on";

            // number_of_digits
            if (number_of_digits == 5)
            {
                password = digit_1 + digit_2 + digit_3 + digit_4 + digit_5;
            }
            else if (number_of_digits == 6)
            {
                password = digit_1 + digit_2 + digit_3 + digit_4 + digit_5 + digit_6;
            }
            else if (number_of_digits == 7)
            {
                password = digit_1 + digit_2 + digit_3 + digit_4 + digit_5 + digit_6 + digit_7;
            }
            else if (number_of_digits == 8)
            {
                password = digit_1 + digit_2 + digit_3 + digit_4 + digit_5 + digit_6 + digit_7 + digit_8;
            }
            else if (number_of_digits == 9)
            {
                password = digit_1 + digit_2 + digit_3 + digit_4 + digit_5 + digit_6 + digit_7 + digit_8 + digit_9;
            }
            else if (number_of_digits == 10)
            {
                password = digit_1 + digit_2 + digit_3 + digit_4 + digit_5 + digit_6 + digit_7 + digit_8 + digit_9 + digit_10;
            }
            else if (number_of_digits == 11)
            {
                password = digit_1 + digit_2 + digit_3 + digit_4 + digit_5 + digit_6 + digit_7 + digit_8 + digit_9 + digit_10 + digit_11;
            }
            else if (number_of_digits == 12)
            {
                password = digit_1 + digit_2 + digit_3 + digit_4 + digit_5 + digit_6 + digit_7 + digit_8 + digit_9 + digit_10 + digit_11 + digit_12;
            }
            else if (number_of_digits == 13)
            {
                password = digit_1 + digit_2 + digit_3 + digit_4 + digit_5 + digit_6 + digit_7 + digit_8 + digit_9 + digit_10 + digit_11 + digit_12 + digit_13;
            }
            else if (number_of_digits == 14)
            {
                password = digit_1 + digit_2 + digit_3 + digit_4 + digit_5 + digit_6 + digit_7 + digit_8 + digit_9 + digit_10 + digit_11 + digit_12 + digit_13 + digit_14;
            }
            else if (number_of_digits == 15)
            {
                password = digit_1 + digit_2 + digit_3 + digit_4 + digit_5 + digit_6 + digit_7 + digit_8 + digit_9 + digit_10 + digit_11 + digit_12 + digit_13 + digit_14 + digit_15;
            }
            else if (number_of_digits == 16)
            {
                password = digit_1 + digit_2 + digit_3 + digit_4 + digit_5 + digit_6 + digit_7 + digit_8 + digit_9 + digit_10 + digit_11 + digit_12 + digit_13 + digit_14 + digit_15 + digit_16;
            }
            else if (number_of_digits == 17)
            {
                password = digit_1 + digit_2 + digit_3 + digit_4 + digit_5 + digit_6 + digit_7 + digit_8 + digit_9 + digit_10 + digit_11 + digit_12 + digit_13 + digit_14 + digit_15 + digit_16 + digit_17;
            }
            else if (number_of_digits == 18)
            {
                password = digit_1 + digit_2 + digit_3 + digit_4 + digit_5 + digit_6 + digit_7 + digit_8 + digit_9 + digit_10 + digit_11 + digit_12 + digit_13 + digit_14 + digit_15 + digit_16 + digit_17 + digit_18;
            }
            else if (number_of_digits == 19)
            {
                password = digit_1 + digit_2 + digit_3 + digit_4 + digit_5 + digit_6 + digit_7 + digit_8 + digit_9 + digit_10 + digit_11 + digit_12 + digit_13 + digit_14 + digit_15 + digit_16 + digit_17 + digit_18 + digit_19;
            }
            else if (number_of_digits == 20)
            {
                password = digit_1 + digit_2 + digit_3 + digit_4 + digit_5 + digit_6 + digit_7 + digit_8 + digit_9 + digit_10 + digit_11 + digit_12 + digit_13 + digit_14 + digit_15 + digit_16 + digit_17 + digit_18 + digit_19 + digit_20;
            }

            MessageBox.Show(password,"Password Generator");

        }
    }
}
