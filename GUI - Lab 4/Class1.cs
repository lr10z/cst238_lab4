using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GUI___Lab_4
{
    public partial class Form1 : Form
    {
        Random numberGenerator;
        private int random;
        private bool[] litHour1;   //this stores whether the LED should be lit or not
        private bool[] litHour2;
        private bool[] litMin1;
        private bool[] litMin2; 

        void setupLED()
        {
            litHour1 = new bool[3];
            litHour2 = new bool[9];
            litMin1 = new bool[6];
            litMin2 = new bool[9];
        }

        void clearLED()
        {
            int i = 0;
            int j = 0;
            int count = -1;
            
            //Hour1
            for (i = 0; i < this.HourTable1.ColumnCount; i++)
            {
                for (j = 0; j < this.HourTable1.RowCount; j++)
                {
                    ++count;

                    pict = (PictureBox)HourTable1.GetControlFromPosition(i, j);

                    if (pict != null)
                    {
                        if (litHour1[count])
                        {
                            pict.BackColor = Color.Black;
                            litHour1[count] = false;
                        }
                    }
                }
            }
            
            //Hour2
            count = -1;

            for (i = 0; i < this.HourTable2.ColumnCount; i++)
            {
                for (j = 0; j < this.HourTable2.RowCount; j++)
                {
                    ++count;

                    pict = (PictureBox)HourTable2.GetControlFromPosition(i, j);

                    if (pict != null)
                    {
                        if (litHour2[count])
                        {
                            pict.BackColor = Color.Black;
                            litHour2[count] = false;
                        }
                    }
                }
            }
            
            //Min1
            count = -1;

            for (i = 0; i < this.MinTable1.ColumnCount; i++)
            {
                for (j = 0; j < this.MinTable1.RowCount; j++)
                {
                    ++count;

                    pict = (PictureBox)MinTable1.GetControlFromPosition(i, j);

                    if (pict != null)
                    {
                        if (litMin1[count])
                        {
                            pict.BackColor = Color.Black;
                            litMin1[count] = false;
                        }
                    }
                }
            }

            //Min2
            count = -1;

            for (i = 0; i < this.MinTable2.ColumnCount; i++)
            {
                for (j = 0; j < this.MinTable2.RowCount; j++)
                {
                    ++count;

                    pict = (PictureBox)MinTable2.GetControlFromPosition(i, j);

                    if (pict != null)
                    {
                        if (litMin2[count])
                        {
                            pict.BackColor = Color.Black;
                            litMin2[count] = false;
                        }
                    }
                }
            }
        }

        void lightLED()
        {
            hour1();
            hour2();
            min1();
            min2();
        }

        //Hour1
        private void hour1()
        {
            for (int x = 0; x < digits[0]; x++)
            {
                random = numberGenerator.Next(0, 3);

                if (litHour1[random] == true)
                {
                    --x;
                    continue;
                }
                else
                {
                    litHour1[random] = true;
                }
            }


            for (int y = 0; y < 3; y++)
            {
                pict = (PictureBox)HourTable1.GetControlFromPosition(0, y);

                if (litHour1[y])
                    pict.BackColor = Color.Red;
            }
        }

        //Hour2
        private void hour2()
        {
            for (int x = 0; x < digits[1]; x++)  
            {
                random = numberGenerator.Next(0, 9);
                
                if (litHour2[random] == true)
                {
                    --x;
                    continue;
                }
                else
                {
                    litHour2[random] = true;
                }
            }

            int i = 0;
            int j = 0;
            int count = -1;

            for (i = 0; i < this.HourTable2.ColumnCount; i++)
            {
                for (j = 0; j < this.HourTable2.RowCount; j++)
                {
                    ++count;

                    pict = (PictureBox)HourTable2.GetControlFromPosition(i, j);

                    if (pict != null)
                    {
                        if (litHour2[count])
                            pict.BackColor = Color.Green;
                    }
                }
            }
        }

        // Minute1
        private void min1()
        {
            for (int x = 0; x < digits[2]; x++)
            {
                random = numberGenerator.Next(0, 5);

                if (litMin1[random] == true)
                {
                    --x;
                    continue;
                }
                else
                {
                    litMin1[random] = true;
                }
            }

            int i = 0;
            int j = 0;
            int count = -1;

            for (i = 0; i < this.MinTable1.ColumnCount; i++)
            {
                for (j = 0; j < this.MinTable1.RowCount; j++)
                {
                    ++count;

                    pict = (PictureBox)MinTable1.GetControlFromPosition(i, j);

                    if (pict != null)
                    {
                        if (litMin1[count])
                            pict.BackColor = Color.Blue;
                    }
                }
            }
            
        }

        //Minute2
        private void min2()
        {
            for (int x = 0; x < digits[3]; x++)
            {
                random = numberGenerator.Next(0, 9);

                if (litMin2[random] == true)
                {
                    --x;
                    continue;
                }
                else
                {
                    litMin2[random] = true;
                }
            }

            int i = 0;
            int j = 0;
            int count = -1;

            for (i = 0; i < this.MinTable2.ColumnCount; i++)
            {
                for (j = 0; j < this.MinTable2.RowCount; j++)
                {
                    ++count;

                    pict = (PictureBox)MinTable2.GetControlFromPosition(i, j);

                    if (pict != null)
                    {
                        if (litMin2[count])
                            pict.BackColor = Color.Red;
                    }
                }
            }
        }
    }
}
