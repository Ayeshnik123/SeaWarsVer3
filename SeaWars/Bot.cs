using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace SeaWars
{
    class Bot
    {
        public static void Pole(DataGridView dataGridView2, int rastanovka)
        {
            Random rand = new Random();
            for (int i = 0; i < 1; i++)
            {
                rastanovka = rand.Next(1, 3);
                switch (rastanovka)
                {
                    case (1):
                        dataGridView2[1, 1].Style.BackColor = Color.Transparent;//1
                        dataGridView2[5, 5].Style.BackColor = Color.Transparent;//1
                        dataGridView2[9, 9].Style.BackColor = Color.Transparent;//1
                        dataGridView2[3, 4].Style.BackColor = Color.Transparent;//1
                        dataGridView2[9, 0].Style.BackColor = Color.Transparent;//2
                        dataGridView2[9, 1].Style.BackColor = Color.Transparent;//2
                        dataGridView2[0, 9].Style.BackColor = Color.Transparent;//2
                        dataGridView2[1, 9].Style.BackColor = Color.Transparent;//2
                        dataGridView2[2, 7].Style.BackColor = Color.Transparent;//2
                        dataGridView2[2, 6].Style.BackColor = Color.Transparent;//2
                        dataGridView2[3, 1].Style.BackColor = Color.Transparent;//3
                        dataGridView2[4, 1].Style.BackColor = Color.Transparent;//3
                        dataGridView2[5, 1].Style.BackColor = Color.Transparent;//3
                        dataGridView2[7, 3].Style.BackColor = Color.Transparent;//3
                        dataGridView2[8, 3].Style.BackColor = Color.Transparent;//3
                        dataGridView2[9, 3].Style.BackColor = Color.Transparent;//3
                        dataGridView2[0, 3].Style.BackColor = Color.Transparent;//4
                        dataGridView2[0, 4].Style.BackColor = Color.Transparent;//4
                        dataGridView2[0, 5].Style.BackColor = Color.Transparent;//4
                        dataGridView2[0, 6].Style.BackColor = Color.Transparent;//4
                        break;

                    case (2):
                        dataGridView2[0, 0].Style.BackColor = Color.Transparent;//1
                        dataGridView2[1, 4].Style.BackColor = Color.Transparent;//1
                        dataGridView2[8, 8].Style.BackColor = Color.Transparent;//1
                        dataGridView2[3, 9].Style.BackColor = Color.Transparent;//1
                        dataGridView2[8, 4].Style.BackColor = Color.Transparent;//2
                        dataGridView2[8, 5].Style.BackColor = Color.Transparent;//2
                        dataGridView2[0, 7].Style.BackColor = Color.Transparent;//2
                        dataGridView2[0, 8].Style.BackColor = Color.Transparent;//2
                        dataGridView2[3, 5].Style.BackColor = Color.Transparent;//2
                        dataGridView2[4, 5].Style.BackColor = Color.Transparent;//2
                        dataGridView2[5, 2].Style.BackColor = Color.Transparent;//3
                        dataGridView2[6, 2].Style.BackColor = Color.Transparent;//3
                        dataGridView2[7, 2].Style.BackColor = Color.Transparent;//3
                        dataGridView2[3, 7].Style.BackColor = Color.Transparent;//3
                        dataGridView2[4, 7].Style.BackColor = Color.Transparent;//3
                        dataGridView2[5, 7].Style.BackColor = Color.Transparent;//3
                        dataGridView2[5, 0].Style.BackColor = Color.Transparent;//4
                        dataGridView2[6, 0].Style.BackColor = Color.Transparent;//4
                        dataGridView2[7, 0].Style.BackColor = Color.Transparent;//4
                        dataGridView2[8, 0].Style.BackColor = Color.Transparent;//4
                        break;

                    case (3):
                        dataGridView2[1, 6].Style.BackColor = Color.Transparent;//1
                        dataGridView2[2, 9].Style.BackColor = Color.Transparent;//1
                        dataGridView2[7, 4].Style.BackColor = Color.Transparent;//1
                        dataGridView2[4, 9].Style.BackColor = Color.Transparent;//1
                        dataGridView2[1, 0].Style.BackColor = Color.Transparent;//2
                        dataGridView2[2, 0].Style.BackColor = Color.Transparent;//2
                        dataGridView2[5, 3].Style.BackColor = Color.Transparent;//2
                        dataGridView2[5, 4].Style.BackColor = Color.Transparent;//2
                        dataGridView2[7, 6].Style.BackColor = Color.Transparent;//2
                        dataGridView2[7, 7].Style.BackColor = Color.Transparent;//2
                        dataGridView2[9, 4].Style.BackColor = Color.Transparent;//3
                        dataGridView2[9, 5].Style.BackColor = Color.Transparent;//3
                        dataGridView2[9, 6].Style.BackColor = Color.Transparent;//3
                        dataGridView2[6, 9].Style.BackColor = Color.Transparent;//3
                        dataGridView2[7, 9].Style.BackColor = Color.Transparent;//3
                        dataGridView2[8, 9].Style.BackColor = Color.Transparent;//3
                        dataGridView2[0, 2].Style.BackColor = Color.Transparent;//4
                        dataGridView2[1, 2].Style.BackColor = Color.Transparent;//4
                        dataGridView2[2, 2].Style.BackColor = Color.Transparent;//4
                        dataGridView2[3, 2].Style.BackColor = Color.Transparent;//4
                        break;
                }
            }
        }
        public static void shoot(DataGridView dataGridView1, int abv)
        {
            Random rand = new Random();
            for (int i = 0; i < 1; i++)
            {
                abv = rand.Next(1, 101);
                switch (abv)
                {
                    case (1):
                        if (dataGridView1[0, 0].Style.BackColor == Color.Black) dataGridView1[0, 0].Style.BackColor = Color.Red;
                        if (dataGridView1[0, 0].Style.BackColor == default) dataGridView1[0, 0].Style.BackColor = Color.Aqua;
                        break;
                    case (2):
                        if (dataGridView1[1, 0].Style.BackColor == Color.Black) dataGridView1[1, 0].Style.BackColor = Color.Red;
                        if (dataGridView1[1, 0].Style.BackColor == default) dataGridView1[1, 0].Style.BackColor = Color.Aqua;
                        break;
                    case (3):
                        if (dataGridView1[2, 0].Style.BackColor == Color.Black) dataGridView1[2, 0].Style.BackColor = Color.Red;
                        if (dataGridView1[2, 0].Style.BackColor == default) dataGridView1[2, 0].Style.BackColor = Color.Aqua;
                        break;
                    case (4):
                        if (dataGridView1[3, 0].Style.BackColor == Color.Black) dataGridView1[3, 0].Style.BackColor = Color.Red;
                        if (dataGridView1[3, 0].Style.BackColor == default) dataGridView1[3, 0].Style.BackColor = Color.Aqua;
                        break;
                    case (5):
                        if (dataGridView1[4, 0].Style.BackColor == Color.Black) dataGridView1[4, 0].Style.BackColor = Color.Red;
                        if (dataGridView1[4, 0].Style.BackColor == default) dataGridView1[4, 0].Style.BackColor = Color.Aqua;
                        break;
                    case (6):
                        if (dataGridView1[5, 0].Style.BackColor == Color.Black) dataGridView1[5, 0].Style.BackColor = Color.Red;
                        if (dataGridView1[5, 0].Style.BackColor == default) dataGridView1[5, 0].Style.BackColor = Color.Aqua;
                        break;
                    case (7):
                        if (dataGridView1[6, 0].Style.BackColor == Color.Black) dataGridView1[6, 0].Style.BackColor = Color.Red;
                        if (dataGridView1[6, 0].Style.BackColor == default) dataGridView1[6, 0].Style.BackColor = Color.Aqua;
                        break;
                    case (8):
                        if (dataGridView1[7, 0].Style.BackColor == Color.Black) dataGridView1[7, 0].Style.BackColor = Color.Red;
                        if (dataGridView1[7, 0].Style.BackColor == default) dataGridView1[7, 0].Style.BackColor = Color.Aqua;
                        break;
                    case (9):
                        if (dataGridView1[8, 0].Style.BackColor == Color.Black) dataGridView1[8, 0].Style.BackColor = Color.Red;
                        if (dataGridView1[8, 0].Style.BackColor == default) dataGridView1[8, 0].Style.BackColor = Color.Aqua;
                        break;
                    case (10):
                        if (dataGridView1[9, 0].Style.BackColor == Color.Black) dataGridView1[9, 0].Style.BackColor = Color.Red;
                        if (dataGridView1[9, 0].Style.BackColor == default) dataGridView1[9, 0].Style.BackColor = Color.Aqua;
                        break;
                    case (11):
                        if (dataGridView1[0, 1].Style.BackColor == Color.Black) dataGridView1[0, 1].Style.BackColor = Color.Red;
                        if (dataGridView1[0, 1].Style.BackColor == default) dataGridView1[0, 1].Style.BackColor = Color.Aqua;
                        break;
                    case (12):
                        if (dataGridView1[1, 1].Style.BackColor == Color.Black) dataGridView1[1, 1].Style.BackColor = Color.Red;
                        if (dataGridView1[1, 1].Style.BackColor == default) dataGridView1[1, 1].Style.BackColor = Color.Aqua;
                        break;
                    case (13):
                        if (dataGridView1[2, 1].Style.BackColor == Color.Black) dataGridView1[2, 1].Style.BackColor = Color.Red;
                        if (dataGridView1[2, 1].Style.BackColor == default) dataGridView1[2, 1].Style.BackColor = Color.Aqua;
                        break;
                    case (14):
                        if (dataGridView1[3, 1].Style.BackColor == Color.Black) dataGridView1[3, 1].Style.BackColor = Color.Red;
                        if (dataGridView1[3, 1].Style.BackColor == default) dataGridView1[3, 1].Style.BackColor = Color.Aqua;
                        break;
                    case (15):
                        if (dataGridView1[4, 1].Style.BackColor == Color.Black) dataGridView1[4, 1].Style.BackColor = Color.Red;
                        if (dataGridView1[4, 1].Style.BackColor == default) dataGridView1[4, 1].Style.BackColor = Color.Aqua;
                        break;
                    case (16):
                        if (dataGridView1[5, 1].Style.BackColor == Color.Black) dataGridView1[5, 1].Style.BackColor = Color.Red;
                        if (dataGridView1[5, 1].Style.BackColor == default) dataGridView1[5, 1].Style.BackColor = Color.Aqua;
                        break;
                    case (17):
                        if (dataGridView1[6, 1].Style.BackColor == Color.Black) dataGridView1[6, 1].Style.BackColor = Color.Red;
                        if (dataGridView1[6, 1].Style.BackColor == default) dataGridView1[6, 1].Style.BackColor = Color.Aqua;
                        break;
                    case (18):
                        if (dataGridView1[7, 1].Style.BackColor == Color.Black) dataGridView1[7, 1].Style.BackColor = Color.Red;
                        if (dataGridView1[7, 1].Style.BackColor == default) dataGridView1[7, 1].Style.BackColor = Color.Aqua;
                        break;
                    case (19):
                        if (dataGridView1[8, 1].Style.BackColor == Color.Black) dataGridView1[8, 1].Style.BackColor = Color.Red;
                        if (dataGridView1[8, 1].Style.BackColor == default) dataGridView1[8, 1].Style.BackColor = Color.Aqua;
                        break;
                    case (20):
                        if (dataGridView1[9, 1].Style.BackColor == Color.Black) dataGridView1[9, 1].Style.BackColor = Color.Red;
                        if (dataGridView1[9, 1].Style.BackColor == default) dataGridView1[9, 1].Style.BackColor = Color.Aqua;
                        break;
                    case (21):
                        if (dataGridView1[0, 2].Style.BackColor == Color.Black) dataGridView1[0, 2].Style.BackColor = Color.Red;
                        if (dataGridView1[0, 2].Style.BackColor == default) dataGridView1[0, 2].Style.BackColor = Color.Aqua;
                        break;
                    case (22):
                        if (dataGridView1[1, 2].Style.BackColor == Color.Black) dataGridView1[1, 2].Style.BackColor = Color.Red;
                        if (dataGridView1[1, 2].Style.BackColor == default) dataGridView1[1, 2].Style.BackColor = Color.Aqua;
                        break;
                    case (23):
                        if (dataGridView1[2, 2].Style.BackColor == Color.Black) dataGridView1[2, 2].Style.BackColor = Color.Red;
                        if (dataGridView1[2, 2].Style.BackColor == default) dataGridView1[2, 2].Style.BackColor = Color.Aqua;
                        break;
                    case (24):
                        if (dataGridView1[3, 2].Style.BackColor == Color.Black) dataGridView1[3, 2].Style.BackColor = Color.Red;
                        if (dataGridView1[3, 2].Style.BackColor == default) dataGridView1[3, 2].Style.BackColor = Color.Aqua;
                        break;
                    case (25):
                        if (dataGridView1[4, 2].Style.BackColor == Color.Black) dataGridView1[4, 2].Style.BackColor = Color.Red;
                        if (dataGridView1[4, 2].Style.BackColor == default) dataGridView1[4, 2].Style.BackColor = Color.Aqua;
                        break;
                    case (26):
                        if (dataGridView1[5, 2].Style.BackColor == Color.Black) dataGridView1[5, 2].Style.BackColor = Color.Red;
                        if (dataGridView1[5, 2].Style.BackColor == default) dataGridView1[5, 2].Style.BackColor = Color.Aqua;
                        break;
                    case (27):
                        if (dataGridView1[6, 2].Style.BackColor == Color.Black) dataGridView1[6, 2].Style.BackColor = Color.Red;
                        if (dataGridView1[6, 2].Style.BackColor == default) dataGridView1[6, 2].Style.BackColor = Color.Aqua;
                        break;
                    case (28):
                        if (dataGridView1[7, 2].Style.BackColor == Color.Black) dataGridView1[7, 2].Style.BackColor = Color.Red;
                        if (dataGridView1[7, 2].Style.BackColor == default) dataGridView1[7, 2].Style.BackColor = Color.Aqua;
                        break;
                    case (29):
                        if (dataGridView1[8, 2].Style.BackColor == Color.Black) dataGridView1[8, 2].Style.BackColor = Color.Red;
                        if (dataGridView1[8, 2].Style.BackColor == default) dataGridView1[8, 2].Style.BackColor = Color.Aqua;
                        break;
                    case (30):
                        if (dataGridView1[9, 2].Style.BackColor == Color.Black) dataGridView1[9, 2].Style.BackColor = Color.Red;
                        if (dataGridView1[9, 2].Style.BackColor == default) dataGridView1[9, 2].Style.BackColor = Color.Aqua;
                        break;
                    case (31):
                        if (dataGridView1[0, 3].Style.BackColor == Color.Black) dataGridView1[0, 3].Style.BackColor = Color.Red;
                        if (dataGridView1[0, 3].Style.BackColor == default) dataGridView1[0, 3].Style.BackColor = Color.Aqua;
                        break;
                    case (32):
                        if (dataGridView1[1, 3].Style.BackColor == Color.Black) dataGridView1[1, 3].Style.BackColor = Color.Red;
                        if (dataGridView1[1, 3].Style.BackColor == default) dataGridView1[1, 3].Style.BackColor = Color.Aqua;
                        break;
                    case (33):
                        if (dataGridView1[2, 3].Style.BackColor == Color.Black) dataGridView1[2, 3].Style.BackColor = Color.Red;
                        if (dataGridView1[2, 3].Style.BackColor == default) dataGridView1[2, 3].Style.BackColor = Color.Aqua;
                        break;
                    case (34):
                        if (dataGridView1[3, 3].Style.BackColor == Color.Black) dataGridView1[3, 3].Style.BackColor = Color.Red;
                        if (dataGridView1[3, 3].Style.BackColor == default) dataGridView1[3, 3].Style.BackColor = Color.Aqua;
                        break;
                    case (35):
                        if (dataGridView1[4, 3].Style.BackColor == Color.Black) dataGridView1[4, 3].Style.BackColor = Color.Red;
                        if (dataGridView1[4, 3].Style.BackColor == default) dataGridView1[4, 3].Style.BackColor = Color.Aqua;
                        break;
                    case (36):
                        if (dataGridView1[5, 3].Style.BackColor == Color.Black) dataGridView1[5, 3].Style.BackColor = Color.Red;
                        if (dataGridView1[5, 3].Style.BackColor == default) dataGridView1[5, 3].Style.BackColor = Color.Aqua;
                        break;
                    case (37):
                        if (dataGridView1[6, 3].Style.BackColor == Color.Black) dataGridView1[6, 3].Style.BackColor = Color.Red;
                        if (dataGridView1[6, 3].Style.BackColor == default) dataGridView1[6, 3].Style.BackColor = Color.Aqua;
                        break;
                    case (38):
                        if (dataGridView1[7, 3].Style.BackColor == Color.Black) dataGridView1[7, 3].Style.BackColor = Color.Red;
                        if (dataGridView1[7, 3].Style.BackColor == default) dataGridView1[7, 3].Style.BackColor = Color.Aqua;
                        break;
                    case (39):
                        if (dataGridView1[8, 3].Style.BackColor == Color.Black) dataGridView1[8, 3].Style.BackColor = Color.Red;
                        if (dataGridView1[8, 3].Style.BackColor == default) dataGridView1[8, 3].Style.BackColor = Color.Aqua;
                        break;
                    case (40):
                        if (dataGridView1[9, 3].Style.BackColor == Color.Black) dataGridView1[9, 3].Style.BackColor = Color.Red;
                        if (dataGridView1[9, 3].Style.BackColor == default) dataGridView1[9, 3].Style.BackColor = Color.Aqua;
                        break;
                    case (41):
                        if (dataGridView1[0, 4].Style.BackColor == Color.Black) dataGridView1[0, 4].Style.BackColor = Color.Red;
                        if (dataGridView1[0, 4].Style.BackColor == default) dataGridView1[0, 4].Style.BackColor = Color.Aqua;
                        break;
                    case (42):
                        if (dataGridView1[1, 4].Style.BackColor == Color.Black) dataGridView1[1, 4].Style.BackColor = Color.Red;
                        if (dataGridView1[1, 4].Style.BackColor == default) dataGridView1[1, 4].Style.BackColor = Color.Aqua;
                        break;
                    case (43):
                        if (dataGridView1[2, 4].Style.BackColor == Color.Black) dataGridView1[2, 4].Style.BackColor = Color.Red;
                        if (dataGridView1[2, 4].Style.BackColor == default) dataGridView1[2, 4].Style.BackColor = Color.Aqua;
                        break;
                    case (44):
                        if (dataGridView1[3, 4].Style.BackColor == Color.Black) dataGridView1[3, 4].Style.BackColor = Color.Red;
                        if (dataGridView1[3, 4].Style.BackColor == default) dataGridView1[3, 4].Style.BackColor = Color.Aqua;
                        break;
                    case (45):
                        if (dataGridView1[4, 4].Style.BackColor == Color.Black) dataGridView1[4, 4].Style.BackColor = Color.Red;
                        if (dataGridView1[4, 4].Style.BackColor == default) dataGridView1[4, 4].Style.BackColor = Color.Aqua;
                        break;
                    case (46):
                        if (dataGridView1[5, 4].Style.BackColor == Color.Black) dataGridView1[5, 4].Style.BackColor = Color.Red;
                        if (dataGridView1[5, 4].Style.BackColor == default) dataGridView1[5, 4].Style.BackColor = Color.Aqua;
                        break;
                    case (47):
                        if (dataGridView1[6, 4].Style.BackColor == Color.Black) dataGridView1[6, 4].Style.BackColor = Color.Red;
                        if (dataGridView1[6, 4].Style.BackColor == default) dataGridView1[6, 4].Style.BackColor = Color.Aqua;
                        break;
                    case (48):
                        if (dataGridView1[7, 4].Style.BackColor == Color.Black) dataGridView1[7, 4].Style.BackColor = Color.Red;
                        if (dataGridView1[7, 4].Style.BackColor == default) dataGridView1[7, 4].Style.BackColor = Color.Aqua;
                        break;
                    case (49):
                        if (dataGridView1[8, 4].Style.BackColor == Color.Black) dataGridView1[8, 4].Style.BackColor = Color.Red;
                        if (dataGridView1[8, 4].Style.BackColor == default) dataGridView1[8, 4].Style.BackColor = Color.Aqua;
                        break;
                    case (50):
                        if (dataGridView1[9, 4].Style.BackColor == Color.Black) dataGridView1[9, 4].Style.BackColor = Color.Red;
                        if (dataGridView1[9, 4].Style.BackColor == default) dataGridView1[9, 4].Style.BackColor = Color.Aqua;
                        break;
                    case (51):
                        if (dataGridView1[0, 5].Style.BackColor == Color.Black) dataGridView1[0, 5].Style.BackColor = Color.Red;
                        if (dataGridView1[0, 5].Style.BackColor == default) dataGridView1[0, 5].Style.BackColor = Color.Aqua;
                        break;
                    case (52):
                        if (dataGridView1[1, 5].Style.BackColor == Color.Black) dataGridView1[1, 5].Style.BackColor = Color.Red;
                        if (dataGridView1[1, 5].Style.BackColor == default) dataGridView1[1, 5].Style.BackColor = Color.Aqua;
                        break;
                    case (53):
                        if (dataGridView1[2, 5].Style.BackColor == Color.Black) dataGridView1[2, 5].Style.BackColor = Color.Red;
                        if (dataGridView1[2, 5].Style.BackColor == default) dataGridView1[2, 5].Style.BackColor = Color.Aqua;
                        break;
                    case (54):
                        if (dataGridView1[3, 5].Style.BackColor == Color.Black) dataGridView1[3, 5].Style.BackColor = Color.Red;
                        if (dataGridView1[3, 5].Style.BackColor == default) dataGridView1[3, 5].Style.BackColor = Color.Aqua;
                        break;
                    case (55):
                        if (dataGridView1[4, 5].Style.BackColor == Color.Black) dataGridView1[4, 5].Style.BackColor = Color.Red;
                        if (dataGridView1[4, 5].Style.BackColor == default) dataGridView1[4, 5].Style.BackColor = Color.Aqua;
                        break;
                    case (56):
                        if (dataGridView1[5, 5].Style.BackColor == Color.Black) dataGridView1[5, 5].Style.BackColor = Color.Red;
                        if (dataGridView1[5, 5].Style.BackColor == default) dataGridView1[5, 5].Style.BackColor = Color.Aqua;
                        break;
                    case (57):
                        if (dataGridView1[6, 5].Style.BackColor == Color.Black) dataGridView1[6, 5].Style.BackColor = Color.Red;
                        if (dataGridView1[6, 5].Style.BackColor == default) dataGridView1[6, 5].Style.BackColor = Color.Aqua;
                        break;
                    case (58):
                        if (dataGridView1[7, 5].Style.BackColor == Color.Black) dataGridView1[7, 5].Style.BackColor = Color.Red;
                        if (dataGridView1[7, 5].Style.BackColor == default) dataGridView1[7, 5].Style.BackColor = Color.Aqua;
                        break;
                    case (59):
                        if (dataGridView1[8, 5].Style.BackColor == Color.Black) dataGridView1[8, 5].Style.BackColor = Color.Red;
                        if (dataGridView1[8, 5].Style.BackColor == default) dataGridView1[8, 5].Style.BackColor = Color.Aqua;
                        break;
                    case (60):
                        if (dataGridView1[9, 5].Style.BackColor == Color.Black) dataGridView1[9, 5].Style.BackColor = Color.Red;
                        if (dataGridView1[9, 5].Style.BackColor == default) dataGridView1[9, 5].Style.BackColor = Color.Aqua;
                        break;
                    case (61):
                        if (dataGridView1[0, 6].Style.BackColor == Color.Black) dataGridView1[0, 6].Style.BackColor = Color.Red;
                        if (dataGridView1[0, 6].Style.BackColor == default) dataGridView1[0, 6].Style.BackColor = Color.Aqua;
                        break;
                    case (62):
                        if (dataGridView1[1, 6].Style.BackColor == Color.Black) dataGridView1[1, 6].Style.BackColor = Color.Red;
                        if (dataGridView1[1, 6].Style.BackColor == default) dataGridView1[1, 6].Style.BackColor = Color.Aqua;
                        break;
                    case (63):
                        if (dataGridView1[2, 6].Style.BackColor == Color.Black) dataGridView1[2, 6].Style.BackColor = Color.Red;
                        if (dataGridView1[2, 6].Style.BackColor == default) dataGridView1[2, 6].Style.BackColor = Color.Aqua;
                        break;
                    case (64):
                        if (dataGridView1[3, 6].Style.BackColor == Color.Black) dataGridView1[3, 6].Style.BackColor = Color.Red;
                        if (dataGridView1[3, 6].Style.BackColor == default) dataGridView1[3, 6].Style.BackColor = Color.Aqua;
                        break;
                    case (65):
                        if (dataGridView1[4, 6].Style.BackColor == Color.Black) dataGridView1[4, 6].Style.BackColor = Color.Red;
                        if (dataGridView1[4, 6].Style.BackColor == default) dataGridView1[4, 6].Style.BackColor = Color.Aqua;
                        break;
                    case (66):
                        if (dataGridView1[5, 6].Style.BackColor == Color.Black) dataGridView1[5, 6].Style.BackColor = Color.Red;
                        if (dataGridView1[5, 6].Style.BackColor == default) dataGridView1[5, 6].Style.BackColor = Color.Aqua;
                        break;
                    case (67):
                        if (dataGridView1[6, 6].Style.BackColor == Color.Black) dataGridView1[6, 6].Style.BackColor = Color.Red;
                        if (dataGridView1[6, 6].Style.BackColor == default) dataGridView1[6, 6].Style.BackColor = Color.Aqua;
                        break;
                    case (68):
                        if (dataGridView1[7, 6].Style.BackColor == Color.Black) dataGridView1[7, 6].Style.BackColor = Color.Red;
                        if (dataGridView1[7, 6].Style.BackColor == default) dataGridView1[7, 6].Style.BackColor = Color.Aqua;
                        break;
                    case (69):
                        if (dataGridView1[8, 6].Style.BackColor == Color.Black) dataGridView1[8, 6].Style.BackColor = Color.Red;
                        if (dataGridView1[8, 6].Style.BackColor == default) dataGridView1[8, 6].Style.BackColor = Color.Aqua;
                        break;
                    case (70):
                        if (dataGridView1[9, 6].Style.BackColor == Color.Black) dataGridView1[9, 6].Style.BackColor = Color.Red;
                        if (dataGridView1[9, 6].Style.BackColor == default) dataGridView1[9, 6].Style.BackColor = Color.Aqua;
                        break;
                    case (71):
                        if (dataGridView1[0, 7].Style.BackColor == Color.Black) dataGridView1[0, 7].Style.BackColor = Color.Red;
                        if (dataGridView1[0, 7].Style.BackColor == default) dataGridView1[0, 7].Style.BackColor = Color.Aqua;
                        break;
                    case (72):
                        if (dataGridView1[1, 7].Style.BackColor == Color.Black) dataGridView1[1, 7].Style.BackColor = Color.Red;
                        if (dataGridView1[1, 7].Style.BackColor == default) dataGridView1[1, 7].Style.BackColor = Color.Aqua;
                        break;
                    case (73):
                        if (dataGridView1[2, 7].Style.BackColor == Color.Black) dataGridView1[2, 7].Style.BackColor = Color.Red;
                        if (dataGridView1[2, 7].Style.BackColor == default) dataGridView1[2, 7].Style.BackColor = Color.Aqua;
                        break;
                    case (74):
                        if (dataGridView1[3, 7].Style.BackColor == Color.Black) dataGridView1[3, 7].Style.BackColor = Color.Red;
                        if (dataGridView1[3, 7].Style.BackColor == default) dataGridView1[3, 7].Style.BackColor = Color.Aqua;
                        break;
                    case (75):
                        if (dataGridView1[4, 7].Style.BackColor == Color.Black) dataGridView1[4, 7].Style.BackColor = Color.Red;
                        if (dataGridView1[4, 7].Style.BackColor == default) dataGridView1[4, 7].Style.BackColor = Color.Aqua;
                        break;
                    case (76):
                        if (dataGridView1[5, 7].Style.BackColor == Color.Black) dataGridView1[5, 7].Style.BackColor = Color.Red;
                        if (dataGridView1[5, 7].Style.BackColor == default) dataGridView1[5, 7].Style.BackColor = Color.Aqua;
                        break;
                    case (77):
                        if (dataGridView1[6, 7].Style.BackColor == Color.Black) dataGridView1[6, 7].Style.BackColor = Color.Red;
                        if (dataGridView1[6, 7].Style.BackColor == default) dataGridView1[6, 7].Style.BackColor = Color.Aqua;
                        break;
                    case (78):
                        if (dataGridView1[7, 7].Style.BackColor == Color.Black) dataGridView1[7, 7].Style.BackColor = Color.Red;
                        if (dataGridView1[7, 7].Style.BackColor == default) dataGridView1[7, 7].Style.BackColor = Color.Aqua;
                        break;
                    case (79):
                        if (dataGridView1[8, 7].Style.BackColor == Color.Black) dataGridView1[8, 7].Style.BackColor = Color.Red;
                        if (dataGridView1[8, 7].Style.BackColor == default) dataGridView1[8, 7].Style.BackColor = Color.Aqua;
                        break;
                    case (80):
                        if (dataGridView1[9, 7].Style.BackColor == Color.Black) dataGridView1[9, 7].Style.BackColor = Color.Red;
                        if (dataGridView1[9, 7].Style.BackColor == default) dataGridView1[9, 7].Style.BackColor = Color.Aqua;
                        break;
                    case (81):
                        if (dataGridView1[0, 8].Style.BackColor == Color.Black) dataGridView1[0, 8].Style.BackColor = Color.Red;
                        if (dataGridView1[0, 8].Style.BackColor == default) dataGridView1[0, 8].Style.BackColor = Color.Aqua;
                        break;
                    case (82):
                        if (dataGridView1[1, 8].Style.BackColor == Color.Black) dataGridView1[1, 8].Style.BackColor = Color.Red;
                        if (dataGridView1[1, 8].Style.BackColor == default) dataGridView1[1, 8].Style.BackColor = Color.Aqua;
                        break;
                    case (83):
                        if (dataGridView1[2, 8].Style.BackColor == Color.Black) dataGridView1[2, 8].Style.BackColor = Color.Red;
                        if (dataGridView1[2, 8].Style.BackColor == default) dataGridView1[2, 8].Style.BackColor = Color.Aqua;
                        break;
                    case (84):
                        if (dataGridView1[3, 8].Style.BackColor == Color.Black) dataGridView1[3, 8].Style.BackColor = Color.Red;
                        if (dataGridView1[3, 8].Style.BackColor == default) dataGridView1[3, 8].Style.BackColor = Color.Aqua;
                        break;
                    case (85):
                        if (dataGridView1[4, 8].Style.BackColor == Color.Black) dataGridView1[4, 8].Style.BackColor = Color.Red;
                        if (dataGridView1[4, 8].Style.BackColor == default) dataGridView1[4, 8].Style.BackColor = Color.Aqua;
                        break;
                    case (86):
                        if (dataGridView1[5, 8].Style.BackColor == Color.Black) dataGridView1[5, 8].Style.BackColor = Color.Red;
                        if (dataGridView1[5, 8].Style.BackColor == default) dataGridView1[5, 8].Style.BackColor = Color.Aqua;
                        break;
                    case (87):
                        if (dataGridView1[6, 8].Style.BackColor == Color.Black) dataGridView1[6, 8].Style.BackColor = Color.Red;
                        if (dataGridView1[6, 8].Style.BackColor == default) dataGridView1[6, 8].Style.BackColor = Color.Aqua;
                        break;
                    case (88):
                        if (dataGridView1[7, 8].Style.BackColor == Color.Black) dataGridView1[7, 8].Style.BackColor = Color.Red;
                        if (dataGridView1[7, 8].Style.BackColor == default) dataGridView1[7, 8].Style.BackColor = Color.Aqua;
                        break;
                    case (89):
                        if (dataGridView1[8, 8].Style.BackColor == Color.Black) dataGridView1[8, 8].Style.BackColor = Color.Red;
                        if (dataGridView1[8, 8].Style.BackColor == default) dataGridView1[8, 8].Style.BackColor = Color.Aqua;
                        break;
                    case (90):
                        if (dataGridView1[9, 8].Style.BackColor == Color.Black) dataGridView1[9, 8].Style.BackColor = Color.Red;
                        if (dataGridView1[9, 8].Style.BackColor == default) dataGridView1[9, 8].Style.BackColor = Color.Aqua;
                        break;
                    case (91):
                        if (dataGridView1[0, 9].Style.BackColor == Color.Black) dataGridView1[0, 9].Style.BackColor = Color.Red;
                        if (dataGridView1[0, 9].Style.BackColor == default) dataGridView1[0, 9].Style.BackColor = Color.Aqua;
                        break;
                    case (92):
                        if (dataGridView1[1, 9].Style.BackColor == Color.Black) dataGridView1[1, 9].Style.BackColor = Color.Red;
                        if (dataGridView1[1, 9].Style.BackColor == default) dataGridView1[1, 9].Style.BackColor = Color.Aqua;
                        break;
                    case (93):
                        if (dataGridView1[2, 9].Style.BackColor == Color.Black) dataGridView1[2, 9].Style.BackColor = Color.Red;
                        if (dataGridView1[2, 9].Style.BackColor == default) dataGridView1[2, 9].Style.BackColor = Color.Aqua;
                        break;
                    case (94):
                        if (dataGridView1[3, 9].Style.BackColor == Color.Black) dataGridView1[3, 9].Style.BackColor = Color.Red;
                        if (dataGridView1[3, 9].Style.BackColor == default) dataGridView1[3, 9].Style.BackColor = Color.Aqua;
                        break;
                    case (95):
                        if (dataGridView1[4, 9].Style.BackColor == Color.Black) dataGridView1[4, 9].Style.BackColor = Color.Red;
                        if (dataGridView1[4, 9].Style.BackColor == default) dataGridView1[4, 9].Style.BackColor = Color.Aqua;
                        break;
                    case (96):
                        if (dataGridView1[5, 9].Style.BackColor == Color.Black) dataGridView1[5, 9].Style.BackColor = Color.Red;
                        if (dataGridView1[5, 9].Style.BackColor == default) dataGridView1[5, 9].Style.BackColor = Color.Aqua;
                        break;
                    case (97):
                        if (dataGridView1[6, 9].Style.BackColor == Color.Black) dataGridView1[6, 9].Style.BackColor = Color.Red;
                        if (dataGridView1[6, 9].Style.BackColor == default) dataGridView1[6, 9].Style.BackColor = Color.Aqua;
                        break;
                    case (98):
                        if (dataGridView1[7, 9].Style.BackColor == Color.Black) dataGridView1[7, 9].Style.BackColor = Color.Red;
                        if (dataGridView1[7, 9].Style.BackColor == default) dataGridView1[7, 9].Style.BackColor = Color.Aqua;
                        break;
                    case (99):
                        if (dataGridView1[8, 9].Style.BackColor == Color.Black) dataGridView1[8, 9].Style.BackColor = Color.Red;
                        if (dataGridView1[8, 9].Style.BackColor == default) dataGridView1[8, 9].Style.BackColor = Color.Aqua;
                        break;
                    case (100):
                        if (dataGridView1[9, 9].Style.BackColor == Color.Black) dataGridView1[9, 9].Style.BackColor = Color.Red;
                        if (dataGridView1[9, 9].Style.BackColor == default) dataGridView1[9, 9].Style.BackColor = Color.Aqua;
                        break;
                }
            }
        }
        public static void ubil(DataGridView dataGridView2, TextBox textBox1, TextBox textBox2)
        {
            // Первый вариант
            if (dataGridView2[1, 1].Style.BackColor == Color.Red)
            {
                dataGridView2[0, 0].Style.BackColor = Color.Aqua;
                dataGridView2[1, 0].Style.BackColor = Color.Aqua;
                dataGridView2[2, 0].Style.BackColor = Color.Aqua;
                dataGridView2[2, 1].Style.BackColor = Color.Aqua;
                dataGridView2[2, 2].Style.BackColor = Color.Aqua;
                dataGridView2[1, 2].Style.BackColor = Color.Aqua;
                dataGridView2[0, 2].Style.BackColor = Color.Aqua;
                dataGridView2[0, 1].Style.BackColor = Color.Aqua;
                dataGridView2[1, 1].Style.BackColor = Color.Crimson;
                MessageBox.Show("Потопил");


            }
            if (dataGridView2[5, 5].Style.BackColor == Color.Red)
            {
                dataGridView2[4, 4].Style.BackColor = Color.Aqua;
                dataGridView2[5, 4].Style.BackColor = Color.Aqua;
                dataGridView2[6, 4].Style.BackColor = Color.Aqua;
                dataGridView2[6, 5].Style.BackColor = Color.Aqua;
                dataGridView2[6, 6].Style.BackColor = Color.Aqua;
                dataGridView2[5, 6].Style.BackColor = Color.Aqua;
                dataGridView2[4, 6].Style.BackColor = Color.Aqua;
                dataGridView2[4, 5].Style.BackColor = Color.Aqua;
                dataGridView2[5, 5].Style.BackColor = Color.Crimson;
                MessageBox.Show("Потопил");
            }
            if (dataGridView2[9, 9].Style.BackColor == Color.Red)
            {
                dataGridView2[8, 9].Style.BackColor = Color.Aqua;
                dataGridView2[8, 8].Style.BackColor = Color.Aqua;
                dataGridView2[9, 8].Style.BackColor = Color.Aqua;
                dataGridView2[9, 9].Style.BackColor = Color.Crimson;
                MessageBox.Show("Потопил");
            }
            if (dataGridView2[3, 4].Style.BackColor == Color.Red)
            {
                dataGridView2[2, 3].Style.BackColor = Color.Aqua;
                dataGridView2[3, 3].Style.BackColor = Color.Aqua;
                dataGridView2[4, 3].Style.BackColor = Color.Aqua;
                dataGridView2[4, 4].Style.BackColor = Color.Aqua;
                dataGridView2[4, 5].Style.BackColor = Color.Aqua;
                dataGridView2[3, 5].Style.BackColor = Color.Aqua;
                dataGridView2[2, 5].Style.BackColor = Color.Aqua;
                dataGridView2[2, 4].Style.BackColor = Color.Aqua;
                dataGridView2[3, 4].Style.BackColor = Color.Crimson;
                MessageBox.Show("Потопил");
            }
            if (dataGridView2[2, 6].Style.BackColor == Color.Red && dataGridView2[2, 7].Style.BackColor == Color.Red)
            {
                dataGridView2[1, 5].Style.BackColor = Color.Aqua;
                dataGridView2[2, 5].Style.BackColor = Color.Aqua;
                dataGridView2[3, 5].Style.BackColor = Color.Aqua;
                dataGridView2[3, 6].Style.BackColor = Color.Aqua;
                dataGridView2[3, 7].Style.BackColor = Color.Aqua;
                dataGridView2[3, 8].Style.BackColor = Color.Aqua;
                dataGridView2[2, 8].Style.BackColor = Color.Aqua;
                dataGridView2[1, 8].Style.BackColor = Color.Aqua;
                dataGridView2[1, 7].Style.BackColor = Color.Aqua;
                dataGridView2[1, 6].Style.BackColor = Color.Aqua;
                dataGridView2[2, 6].Style.BackColor = Color.Crimson;
                dataGridView2[2, 7].Style.BackColor = Color.Crimson;
                MessageBox.Show("Потопил");
            }
            if (dataGridView2[0, 9].Style.BackColor == Color.Red && dataGridView2[1, 9].Style.BackColor == Color.Red)
            {
                dataGridView2[0, 8].Style.BackColor = Color.Aqua;
                dataGridView2[1, 8].Style.BackColor = Color.Aqua;
                dataGridView2[2, 8].Style.BackColor = Color.Aqua;
                dataGridView2[2, 9].Style.BackColor = Color.Aqua;
                dataGridView2[0, 9].Style.BackColor = Color.Crimson;
                dataGridView2[1, 9].Style.BackColor = Color.Crimson;
                MessageBox.Show("Потопил");
            }
            if (dataGridView2[9, 0].Style.BackColor == Color.Red && dataGridView2[9, 1].Style.BackColor == Color.Red)
            {
                dataGridView2[8, 0].Style.BackColor = Color.Aqua;
                dataGridView2[8, 1].Style.BackColor = Color.Aqua;
                dataGridView2[8, 2].Style.BackColor = Color.Aqua;
                dataGridView2[9, 2].Style.BackColor = Color.Aqua;
                dataGridView2[9, 0].Style.BackColor = Color.Crimson;
                dataGridView2[9, 1].Style.BackColor = Color.Crimson;
                MessageBox.Show("Потопил");
            }
            if (dataGridView2[3, 1].Style.BackColor == Color.Red && dataGridView2[4, 1].Style.BackColor == Color.Red && dataGridView2[5, 1].Style.BackColor == Color.Red)
            {
                dataGridView2[2, 0].Style.BackColor = Color.Aqua;
                dataGridView2[3, 0].Style.BackColor = Color.Aqua;
                dataGridView2[4, 0].Style.BackColor = Color.Aqua;
                dataGridView2[5, 0].Style.BackColor = Color.Aqua;
                dataGridView2[6, 0].Style.BackColor = Color.Aqua;
                dataGridView2[6, 1].Style.BackColor = Color.Aqua;
                dataGridView2[6, 2].Style.BackColor = Color.Aqua;
                dataGridView2[5, 2].Style.BackColor = Color.Aqua;
                dataGridView2[4, 2].Style.BackColor = Color.Aqua;
                dataGridView2[3, 2].Style.BackColor = Color.Aqua;
                dataGridView2[2, 2].Style.BackColor = Color.Aqua;
                dataGridView2[2, 1].Style.BackColor = Color.Aqua;
                dataGridView2[3, 1].Style.BackColor = Color.Crimson;
                dataGridView2[4, 1].Style.BackColor = Color.Crimson;
                dataGridView2[5, 1].Style.BackColor = Color.Crimson;
                MessageBox.Show("Потопил");
            }
            if (dataGridView2[7, 3].Style.BackColor == Color.Red && dataGridView2[8, 3].Style.BackColor == Color.Red && dataGridView2[9, 3].Style.BackColor == Color.Red)
            {
                dataGridView2[6, 2].Style.BackColor = Color.Aqua;
                dataGridView2[7, 2].Style.BackColor = Color.Aqua;
                dataGridView2[8, 2].Style.BackColor = Color.Aqua;
                dataGridView2[9, 2].Style.BackColor = Color.Aqua;
                dataGridView2[6, 3].Style.BackColor = Color.Aqua;
                dataGridView2[6, 4].Style.BackColor = Color.Aqua;
                dataGridView2[7, 4].Style.BackColor = Color.Aqua;
                dataGridView2[8, 4].Style.BackColor = Color.Aqua;
                dataGridView2[9, 4].Style.BackColor = Color.Aqua;
                dataGridView2[7, 3].Style.BackColor = Color.Crimson;
                dataGridView2[8, 3].Style.BackColor = Color.Crimson;
                dataGridView2[9, 3].Style.BackColor = Color.Crimson;
                MessageBox.Show("Потопил");
            }
            if (dataGridView2[0, 3].Style.BackColor == Color.Red && dataGridView2[0, 4].Style.BackColor == Color.Red && dataGridView2[0, 5].Style.BackColor == Color.Red && dataGridView2[0, 6].Style.BackColor == Color.Red)
            {
                dataGridView2[0, 2].Style.BackColor = Color.Aqua;
                dataGridView2[1, 2].Style.BackColor = Color.Aqua;
                dataGridView2[1, 3].Style.BackColor = Color.Aqua;
                dataGridView2[1, 4].Style.BackColor = Color.Aqua;
                dataGridView2[1, 5].Style.BackColor = Color.Aqua;
                dataGridView2[1, 6].Style.BackColor = Color.Aqua;
                dataGridView2[1, 7].Style.BackColor = Color.Aqua;
                dataGridView2[0, 7].Style.BackColor = Color.Aqua;
                dataGridView2[0, 3].Style.BackColor = Color.Crimson;
                dataGridView2[0, 4].Style.BackColor = Color.Crimson;
                dataGridView2[0, 5].Style.BackColor = Color.Crimson;
                dataGridView2[0, 6].Style.BackColor = Color.Crimson;
                MessageBox.Show("Потопил");
            }
            if (dataGridView2[1, 1].Style.BackColor == Color.Crimson && dataGridView2[5, 5].Style.BackColor == Color.Crimson
                && dataGridView2[9, 9].Style.BackColor == Color.Crimson && dataGridView2[3, 4].Style.BackColor == Color.Crimson
                && dataGridView2[2, 6].Style.BackColor == Color.Crimson && dataGridView2[2, 7].Style.BackColor == Color.Crimson
                && dataGridView2[0, 9].Style.BackColor == Color.Crimson && dataGridView2[1, 9].Style.BackColor == Color.Crimson
                && dataGridView2[9, 0].Style.BackColor == Color.Crimson && dataGridView2[9, 1].Style.BackColor == Color.Crimson
                && dataGridView2[3, 1].Style.BackColor == Color.Crimson && dataGridView2[4, 1].Style.BackColor == Color.Crimson
                && dataGridView2[5, 1].Style.BackColor == Color.Crimson && dataGridView2[7, 3].Style.BackColor == Color.Crimson
                && dataGridView2[8, 3].Style.BackColor == Color.Crimson && dataGridView2[9, 3].Style.BackColor == Color.Crimson
                && dataGridView2[0, 3].Style.BackColor == Color.Crimson && dataGridView2[0, 4].Style.BackColor == Color.Crimson
                && dataGridView2[0, 5].Style.BackColor == Color.Crimson && dataGridView2[0, 6].Style.BackColor == Color.Crimson)
            {
                MessageBox.Show("Вы победили");
                File.AppendAllText("result.txt", Environment.NewLine + textBox1.Text + " " + textBox2.Text);
                dataGridView2.Enabled = false;
            }
            
            // Второй вариант
            if (dataGridView2[0, 0].Style.BackColor == Color.Red)
            {
                dataGridView2[1, 0].Style.BackColor = Color.Aqua;
                dataGridView2[1, 1].Style.BackColor = Color.Aqua;
                dataGridView2[0, 1].Style.BackColor = Color.Aqua;
                dataGridView2[0, 0].Style.BackColor = Color.Crimson;
                MessageBox.Show("Потопил");
            }
            if (dataGridView2[1, 4].Style.BackColor == Color.Red)
            {
                dataGridView2[0, 3].Style.BackColor = Color.Aqua;
                dataGridView2[1, 3].Style.BackColor = Color.Aqua;
                dataGridView2[2, 3].Style.BackColor = Color.Aqua;
                dataGridView2[2, 4].Style.BackColor = Color.Aqua;
                dataGridView2[2, 5].Style.BackColor = Color.Aqua;
                dataGridView2[1, 5].Style.BackColor = Color.Aqua;
                dataGridView2[0, 5].Style.BackColor = Color.Aqua;
                dataGridView2[0, 4].Style.BackColor = Color.Aqua;
                dataGridView2[1, 4].Style.BackColor = Color.Crimson;
                MessageBox.Show("Потопил");
            }
            if (dataGridView2[3, 9].Style.BackColor == Color.Red)
            {
                dataGridView2[2, 9].Style.BackColor = Color.Aqua;
                dataGridView2[2, 8].Style.BackColor = Color.Aqua;
                dataGridView2[3, 8].Style.BackColor = Color.Aqua;
                dataGridView2[4, 8].Style.BackColor = Color.Aqua;
                dataGridView2[4, 9].Style.BackColor = Color.Aqua;
                dataGridView2[3, 9].Style.BackColor = Color.Crimson;
                MessageBox.Show("Потопил");
            }
            if (dataGridView2[8, 8].Style.BackColor == Color.Red)
            {
                dataGridView2[8, 9].Style.BackColor = Color.Aqua;
                dataGridView2[7, 9].Style.BackColor = Color.Aqua;
                dataGridView2[7, 8].Style.BackColor = Color.Aqua;
                dataGridView2[7, 7].Style.BackColor = Color.Aqua;
                dataGridView2[8, 7].Style.BackColor = Color.Aqua;
                dataGridView2[9, 7].Style.BackColor = Color.Aqua;
                dataGridView2[9, 7].Style.BackColor = Color.Aqua;
                dataGridView2[9, 8].Style.BackColor = Color.Aqua;
                dataGridView2[9, 9].Style.BackColor = Color.Aqua;
                dataGridView2[8, 8].Style.BackColor = Color.Crimson;
                MessageBox.Show("Потопил");
            }
            if (dataGridView2[0, 7].Style.BackColor == Color.Red && dataGridView2[0, 8].Style.BackColor == Color.Red)
            {
                dataGridView2[0, 6].Style.BackColor = Color.Aqua;
                dataGridView2[1, 6].Style.BackColor = Color.Aqua;
                dataGridView2[1, 7].Style.BackColor = Color.Aqua;
                dataGridView2[1, 8].Style.BackColor = Color.Aqua;
                dataGridView2[1, 9].Style.BackColor = Color.Aqua;
                dataGridView2[0, 9].Style.BackColor = Color.Aqua;
                dataGridView2[0, 7].Style.BackColor = Color.Crimson;
                dataGridView2[0, 8].Style.BackColor = Color.Crimson;
                MessageBox.Show("Потопил");
            }
            if (dataGridView2[3, 5].Style.BackColor == Color.Red && dataGridView2[4, 5].Style.BackColor == Color.Red)
            {
                dataGridView2[2, 5].Style.BackColor = Color.Aqua;
                dataGridView2[2, 4].Style.BackColor = Color.Aqua;
                dataGridView2[3, 4].Style.BackColor = Color.Aqua;
                dataGridView2[4, 4].Style.BackColor = Color.Aqua;
                dataGridView2[5, 4].Style.BackColor = Color.Aqua;
                dataGridView2[5, 5].Style.BackColor = Color.Aqua;
                dataGridView2[5, 6].Style.BackColor = Color.Aqua;
                dataGridView2[4, 6].Style.BackColor = Color.Aqua;
                dataGridView2[3, 6].Style.BackColor = Color.Aqua;
                dataGridView2[2, 6].Style.BackColor = Color.Aqua;
                dataGridView2[3, 5].Style.BackColor = Color.Crimson;
                dataGridView2[4, 5].Style.BackColor = Color.Crimson;
                MessageBox.Show("Потопил");
            }
            if (dataGridView2[8, 4].Style.BackColor == Color.Red && dataGridView2[8, 5].Style.BackColor == Color.Red)
            {
                dataGridView2[8, 6].Style.BackColor = Color.Aqua;
                dataGridView2[7, 6].Style.BackColor = Color.Aqua;
                dataGridView2[7, 5].Style.BackColor = Color.Aqua;
                dataGridView2[7, 4].Style.BackColor = Color.Aqua;
                dataGridView2[7, 3].Style.BackColor = Color.Aqua;
                dataGridView2[8, 3].Style.BackColor = Color.Aqua;
                dataGridView2[9, 3].Style.BackColor = Color.Aqua;
                dataGridView2[9, 4].Style.BackColor = Color.Aqua;
                dataGridView2[9, 5].Style.BackColor = Color.Aqua;
                dataGridView2[9, 6].Style.BackColor = Color.Aqua;
                dataGridView2[8, 4].Style.BackColor = Color.Crimson;
                dataGridView2[8, 5].Style.BackColor = Color.Crimson;
                MessageBox.Show("Потопил");
            }
            if (dataGridView2[5, 2].Style.BackColor == Color.Red && dataGridView2[6, 2].Style.BackColor == Color.Red && dataGridView2[7, 2].Style.BackColor == Color.Red)
            {
                dataGridView2[7, 3].Style.BackColor = Color.Aqua;
                dataGridView2[6, 3].Style.BackColor = Color.Aqua;
                dataGridView2[5, 3].Style.BackColor = Color.Aqua;
                dataGridView2[4, 3].Style.BackColor = Color.Aqua;
                dataGridView2[4, 2].Style.BackColor = Color.Aqua;
                dataGridView2[4, 1].Style.BackColor = Color.Aqua;
                dataGridView2[5, 1].Style.BackColor = Color.Aqua;
                dataGridView2[6, 1].Style.BackColor = Color.Aqua;
                dataGridView2[7, 1].Style.BackColor = Color.Aqua;
                dataGridView2[8, 1].Style.BackColor = Color.Aqua;
                dataGridView2[8, 2].Style.BackColor = Color.Aqua;
                dataGridView2[8, 3].Style.BackColor = Color.Aqua;
                dataGridView2[5, 2].Style.BackColor = Color.Crimson;
                dataGridView2[6, 2].Style.BackColor = Color.Crimson;
                dataGridView2[7, 2].Style.BackColor = Color.Crimson;
                MessageBox.Show("Потопил");
            }
            if (dataGridView2[3, 7].Style.BackColor == Color.Red && dataGridView2[4, 7].Style.BackColor == Color.Red && dataGridView2[5, 7].Style.BackColor == Color.Red)
            {
                dataGridView2[2, 8].Style.BackColor = Color.Aqua;
                dataGridView2[2, 7].Style.BackColor = Color.Aqua;
                dataGridView2[2, 6].Style.BackColor = Color.Aqua;
                dataGridView2[3, 6].Style.BackColor = Color.Aqua;
                dataGridView2[4, 6].Style.BackColor = Color.Aqua;
                dataGridView2[5, 6].Style.BackColor = Color.Aqua;
                dataGridView2[6, 6].Style.BackColor = Color.Aqua;
                dataGridView2[6, 7].Style.BackColor = Color.Aqua;
                dataGridView2[6, 8].Style.BackColor = Color.Aqua;
                dataGridView2[5, 8].Style.BackColor = Color.Aqua;
                dataGridView2[4, 8].Style.BackColor = Color.Aqua;
                dataGridView2[3, 8].Style.BackColor = Color.Aqua;
                dataGridView2[3, 7].Style.BackColor = Color.Crimson;
                dataGridView2[4, 7].Style.BackColor = Color.Crimson;
                dataGridView2[5, 7].Style.BackColor = Color.Crimson;
                MessageBox.Show("Потопил");
            }
            if (dataGridView2[5, 0].Style.BackColor == Color.Red && dataGridView2[6, 0].Style.BackColor == Color.Red && dataGridView2[7, 0].Style.BackColor == Color.Red && dataGridView2[8, 0].Style.BackColor == Color.Red)
            {
                dataGridView2[4, 0].Style.BackColor = Color.Aqua;
                dataGridView2[4, 1].Style.BackColor = Color.Aqua;
                dataGridView2[5, 1].Style.BackColor = Color.Aqua;
                dataGridView2[6, 1].Style.BackColor = Color.Aqua;
                dataGridView2[7, 1].Style.BackColor = Color.Aqua;
                dataGridView2[8, 1].Style.BackColor = Color.Aqua;
                dataGridView2[9, 1].Style.BackColor = Color.Aqua;
                dataGridView2[9, 0].Style.BackColor = Color.Aqua;
                dataGridView2[5, 0].Style.BackColor = Color.Crimson;
                dataGridView2[6, 0].Style.BackColor = Color.Crimson;
                dataGridView2[7, 0].Style.BackColor = Color.Crimson;
                dataGridView2[8, 0].Style.BackColor = Color.Crimson;
                MessageBox.Show("Потопил");
            }
            if (dataGridView2[0, 0].Style.BackColor == Color.Crimson && dataGridView2[1, 4].Style.BackColor == Color.Crimson
                && dataGridView2[3, 9].Style.BackColor == Color.Crimson && dataGridView2[8, 8].Style.BackColor == Color.Crimson
                && dataGridView2[0, 7].Style.BackColor == Color.Crimson && dataGridView2[0, 8].Style.BackColor == Color.Crimson
                && dataGridView2[3, 5].Style.BackColor == Color.Crimson && dataGridView2[4, 5].Style.BackColor == Color.Crimson
                && dataGridView2[8, 4].Style.BackColor == Color.Crimson && dataGridView2[8, 5].Style.BackColor == Color.Crimson
                && dataGridView2[5, 2].Style.BackColor == Color.Crimson && dataGridView2[6, 2].Style.BackColor == Color.Crimson && dataGridView2[7, 2].Style.BackColor == Color.Crimson
                && dataGridView2[3, 7].Style.BackColor == Color.Crimson && dataGridView2[4, 7].Style.BackColor == Color.Crimson && dataGridView2[5, 7].Style.BackColor == Color.Crimson
                && dataGridView2[5, 0].Style.BackColor == Color.Crimson && dataGridView2[6, 0].Style.BackColor == Color.Crimson && dataGridView2[7, 0].Style.BackColor == Color.Crimson && dataGridView2[8, 0].Style.BackColor == Color.Crimson)
            {
                MessageBox.Show("Вы победили");
                File.AppendAllText("result.txt", Environment.NewLine + textBox1.Text + " " + textBox2.Text);
                dataGridView2.Enabled = false;
            }
            
            // Третий вариант
            if (dataGridView2[1, 6].Style.BackColor == Color.Red) 
            {
                dataGridView2[1, 7].Style.BackColor = Color.Aqua;
                dataGridView2[0, 7].Style.BackColor = Color.Aqua;
                dataGridView2[0, 6].Style.BackColor = Color.Aqua;
                dataGridView2[0, 5].Style.BackColor = Color.Aqua;
                dataGridView2[1, 5].Style.BackColor = Color.Aqua;
                dataGridView2[2, 5].Style.BackColor = Color.Aqua;
                dataGridView2[2, 6].Style.BackColor = Color.Aqua;
                dataGridView2[2, 7].Style.BackColor = Color.Aqua;
                dataGridView2[1, 6].Style.BackColor = Color.Crimson;
                MessageBox.Show("Потопил");
            }
            if (dataGridView2[2, 9].Style.BackColor == Color.Red)
            {
                dataGridView2[1, 9].Style.BackColor = Color.Aqua;
                dataGridView2[1, 8].Style.BackColor = Color.Aqua;
                dataGridView2[2, 8].Style.BackColor = Color.Aqua;
                dataGridView2[3, 8].Style.BackColor = Color.Aqua;
                dataGridView2[3, 9].Style.BackColor = Color.Aqua;
                dataGridView2[2, 9].Style.BackColor = Color.Crimson;
                MessageBox.Show("Потопил");
            }
            if (dataGridView2[7, 4].Style.BackColor == Color.Red)
            {
                dataGridView2[6, 4].Style.BackColor = Color.Aqua;
                dataGridView2[6, 3].Style.BackColor = Color.Aqua;
                dataGridView2[7, 3].Style.BackColor = Color.Aqua;
                dataGridView2[8, 3].Style.BackColor = Color.Aqua;
                dataGridView2[8, 4].Style.BackColor = Color.Aqua;
                dataGridView2[8, 5].Style.BackColor = Color.Aqua;
                dataGridView2[7, 5].Style.BackColor = Color.Aqua;
                dataGridView2[6, 5].Style.BackColor = Color.Aqua;
                dataGridView2[7, 4].Style.BackColor = Color.Crimson;
                MessageBox.Show("Потопил");
            }
            if (dataGridView2[4, 9].Style.BackColor == Color.Red)
            {
                dataGridView2[3, 9].Style.BackColor = Color.Aqua;
                dataGridView2[3, 8].Style.BackColor = Color.Aqua;
                dataGridView2[4, 8].Style.BackColor = Color.Aqua;
                dataGridView2[5, 8].Style.BackColor = Color.Aqua;
                dataGridView2[5, 9].Style.BackColor = Color.Aqua;
                dataGridView2[4, 9].Style.BackColor = Color.Crimson;
                MessageBox.Show("Потопил");
            }
            if (dataGridView2[1, 0].Style.BackColor == Color.Red && dataGridView2[2, 0].Style.BackColor == Color.Red)
            {
                dataGridView2[0, 0].Style.BackColor = Color.Aqua;
                dataGridView2[0, 1].Style.BackColor = Color.Aqua;
                dataGridView2[1, 1].Style.BackColor = Color.Aqua;
                dataGridView2[2, 1].Style.BackColor = Color.Aqua;
                dataGridView2[3, 1].Style.BackColor = Color.Aqua;
                dataGridView2[3, 0].Style.BackColor = Color.Aqua;
                dataGridView2[1, 0].Style.BackColor = Color.Crimson;
                dataGridView2[2, 0].Style.BackColor = Color.Crimson;
                MessageBox.Show("Потопил");
            }
            if (dataGridView2[5, 3].Style.BackColor == Color.Red && dataGridView2[5, 4].Style.BackColor == Color.Red)
            {
                dataGridView2[5, 5].Style.BackColor = Color.Aqua;
                dataGridView2[4, 5].Style.BackColor = Color.Aqua;
                dataGridView2[4, 4].Style.BackColor = Color.Aqua;
                dataGridView2[4, 3].Style.BackColor = Color.Aqua;
                dataGridView2[4, 2].Style.BackColor = Color.Aqua;
                dataGridView2[5, 2].Style.BackColor = Color.Aqua;
                dataGridView2[6, 2].Style.BackColor = Color.Aqua;
                dataGridView2[6, 3].Style.BackColor = Color.Aqua;
                dataGridView2[6, 4].Style.BackColor = Color.Aqua;
                dataGridView2[6, 5].Style.BackColor = Color.Aqua;
                dataGridView2[5, 3].Style.BackColor = Color.Crimson;
                dataGridView2[5, 4].Style.BackColor = Color.Crimson;
                MessageBox.Show("Потопил");
            }
            if (dataGridView2[7, 6].Style.BackColor == Color.Red && dataGridView2[7, 7].Style.BackColor == Color.Red)
            {
                dataGridView2[7, 8].Style.BackColor = Color.Aqua;
                dataGridView2[6, 8].Style.BackColor = Color.Aqua;
                dataGridView2[6, 7].Style.BackColor = Color.Aqua;
                dataGridView2[6, 6].Style.BackColor = Color.Aqua;
                dataGridView2[6, 5].Style.BackColor = Color.Aqua;
                dataGridView2[7, 5].Style.BackColor = Color.Aqua;
                dataGridView2[8, 5].Style.BackColor = Color.Aqua;
                dataGridView2[8, 6].Style.BackColor = Color.Aqua;
                dataGridView2[8, 7].Style.BackColor = Color.Aqua;
                dataGridView2[8, 8].Style.BackColor = Color.Aqua;
                dataGridView2[7, 6].Style.BackColor = Color.Crimson;
                dataGridView2[7, 7].Style.BackColor = Color.Crimson;
                MessageBox.Show("Потопил");
            }
            if (dataGridView2[9, 4].Style.BackColor == Color.Red && dataGridView2[9, 5].Style.BackColor == Color.Red && dataGridView2[9, 6].Style.BackColor == Color.Red)
            {
                dataGridView2[9, 7].Style.BackColor = Color.Aqua;
                dataGridView2[8, 7].Style.BackColor = Color.Aqua;
                dataGridView2[8, 6].Style.BackColor = Color.Aqua;
                dataGridView2[8, 5].Style.BackColor = Color.Aqua;
                dataGridView2[8, 4].Style.BackColor = Color.Aqua;
                dataGridView2[8, 3].Style.BackColor = Color.Aqua;
                dataGridView2[9, 3].Style.BackColor = Color.Aqua;
                dataGridView2[9, 4].Style.BackColor = Color.Crimson;
                dataGridView2[9, 5].Style.BackColor = Color.Crimson;
                dataGridView2[9, 6].Style.BackColor = Color.Crimson;
                MessageBox.Show("Потопил");
            }
            if (dataGridView2[6, 9].Style.BackColor == Color.Red && dataGridView2[7, 9].Style.BackColor == Color.Red && dataGridView2[8, 9].Style.BackColor == Color.Red)
            {
                dataGridView2[5, 9].Style.BackColor = Color.Aqua;
                dataGridView2[5, 8].Style.BackColor = Color.Aqua;
                dataGridView2[6, 8].Style.BackColor = Color.Aqua;
                dataGridView2[7, 8].Style.BackColor = Color.Aqua;
                dataGridView2[8, 8].Style.BackColor = Color.Aqua;
                dataGridView2[9, 8].Style.BackColor = Color.Aqua;
                dataGridView2[9, 9].Style.BackColor = Color.Aqua;
                dataGridView2[6, 9].Style.BackColor = Color.Crimson;
                dataGridView2[7, 9].Style.BackColor = Color.Crimson;
                dataGridView2[8, 9].Style.BackColor = Color.Crimson;
                MessageBox.Show("Потопил");
            }
            if (dataGridView2[0, 2].Style.BackColor == Color.Red && dataGridView2[1, 2].Style.BackColor == Color.Red && dataGridView2[2, 2].Style.BackColor == Color.Red && dataGridView2[3, 2].Style.BackColor == Color.Red)
            {
                dataGridView2[0, 1].Style.BackColor = Color.Aqua;
                dataGridView2[1, 1].Style.BackColor = Color.Aqua;
                dataGridView2[2, 1].Style.BackColor = Color.Aqua;
                dataGridView2[3, 1].Style.BackColor = Color.Aqua;
                dataGridView2[4, 1].Style.BackColor = Color.Aqua;
                dataGridView2[4, 2].Style.BackColor = Color.Aqua;
                dataGridView2[4, 3].Style.BackColor = Color.Aqua;
                dataGridView2[3, 3].Style.BackColor = Color.Aqua;
                dataGridView2[2, 3].Style.BackColor = Color.Aqua;
                dataGridView2[1, 3].Style.BackColor = Color.Aqua;
                dataGridView2[0, 3].Style.BackColor = Color.Aqua;
                dataGridView2[0, 2].Style.BackColor = Color.Crimson;
                dataGridView2[1, 2].Style.BackColor = Color.Crimson;
                dataGridView2[2, 2].Style.BackColor = Color.Crimson;
                dataGridView2[3, 2].Style.BackColor = Color.Crimson;
                MessageBox.Show("Потопил");
            }
            if (dataGridView2[7, 4].Style.BackColor == Color.Crimson && dataGridView2[4, 9].Style.BackColor == Color.Crimson
                && dataGridView2[2, 9].Style.BackColor == Color.Crimson && dataGridView2[1, 6].Style.BackColor == Color.Crimson
                && dataGridView2[7, 6].Style.BackColor == Color.Crimson && dataGridView2[7, 7].Style.BackColor == Color.Crimson
                && dataGridView2[5, 3].Style.BackColor == Color.Crimson && dataGridView2[5, 4].Style.BackColor == Color.Crimson
                && dataGridView2[1, 0].Style.BackColor == Color.Crimson && dataGridView2[2, 0].Style.BackColor == Color.Crimson
                && dataGridView2[9, 4].Style.BackColor == Color.Crimson && dataGridView2[9, 5].Style.BackColor == Color.Crimson && dataGridView2[9, 6].Style.BackColor == Color.Crimson
                && dataGridView2[6, 9].Style.BackColor == Color.Crimson && dataGridView2[7, 9].Style.BackColor == Color.Crimson && dataGridView2[8, 9].Style.BackColor == Color.Crimson
                && dataGridView2[0, 2].Style.BackColor == Color.Crimson && dataGridView2[1, 2].Style.BackColor == Color.Crimson && dataGridView2[2, 2].Style.BackColor == Color.Crimson && dataGridView2[3, 2].Style.BackColor == Color.Crimson)
            {
                MessageBox.Show("Вы победили");
                File.AppendAllText("result.txt", Environment.NewLine + textBox1.Text + " " + textBox2.Text);
                dataGridView2.Enabled = false;
            }
        }
    }
}
