using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceStack.Text;
using System.Web.Script.Serialization;
using System.Collections;
namespace Configurator
{

    public partial class Configurator : Form
    {
        public Configurator()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            IdSlot.Value = 0;
            XSlot.Value = 0;
            YSlot.Value = 0;
            ZSlot.Value = 0;
            DateLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            ComSlot.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (var p in ports)
            {
                ComSlot.Items.Add(p);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ComSlot_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Configurator_Load(object sender, EventArgs e)
        {
            radioX.Checked = true;
            DateLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            string[] ports = SerialPort.GetPortNames();
            foreach (var p in ports)
            {
                ComSlot.Items.Add(p);
            }
            ComSlot.SelectedIndex = 0;

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            int x = (int)XSlot.Value;
            int y = (int)YSlot.Value;
            int z = (int)ZSlot.Value;
            int id = (int)IdSlot.Value;
            String H = DateTime.Now.ToString("HH");
            String M = DateTime.Now.ToString("mm");
            String S = DateTime.Now.ToString("ss");

            int hh = Int32.Parse(H);
            int mm = Int32.Parse(M);
            int ss = Int32.Parse(S);
            int date = hh * 3600 + (60 * mm) + ss;
            int radio = 0;
            if (radioX.Checked)
            {
                radio = 0;
            }
            else if (radioY.Checked)
            {
                radio = 1;
            }



            Params p = new Params(x, y, z, id, date, radio);


            DateLabel.Text = DateTime.Now.ToString("HH:mm:ss");

            SerialPort sp = new SerialPort();
            sp.BaudRate = 9600;

            sp.PortName = ComSlot.SelectedItem.ToString();

            try
            {
                sp.Open();
                sp.WriteLine(p.ToJson());
                sp.Close();
                Console.WriteLine(p.ToJson());
                MessageBox.Show("Module configured successfully.");

            }
            catch (Exception)
            {

                MessageBox.Show("Serial Port unavailable");

            }




        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {

            Params p = new Params();
            SerialPort sp = new SerialPort();
            sp.BaudRate = 9600;
            //   sp.ReadBufferSize = 80;
            sp.ReadTimeout = 500;
            sp.WriteTimeout = 500;
            if (!(ComSlot.SelectedIndex >= 0))
            {
                ComSlot.SelectedIndex = 0;
            }
            sp.PortName = ComSlot.SelectedItem.ToString();
            //   string r = "{'id':1,'x':2,'y':3,'z':1,'t':79138,'r':1 ,'c':6}";

            try
            {
                sp.Open();
                if (sp.IsOpen)
                {
                    sp.Write("r");
                    for (int i = 0; i < 10000; i++)
                    {

                    }
                    string r = sp.ReadLine();
                    sp.Close();
                    //////
                    IDictionary dico = new JavaScriptSerializer().DeserializeObject(r) as IDictionary;

                    foreach (string k in dico.Keys)
                    {
                        if (k.Equals("id"))
                        {
                            IdSlot.Value = Int32.Parse(dico[k].ToString());
                            readValues.Text = "Module ID: " + dico[k] + "\n";
                        }
                        else if (k.Equals("x"))
                        {
                            readValues.Text += "X: " + dico[k] + "\n";

                            XSlot.Value = Int32.Parse(dico[k].ToString());
                        }
                        else if (k.Equals("y"))
                        {
                            readValues.Text += "Y: " + dico[k] + "\n";

                            YSlot.Value = Int32.Parse(dico[k].ToString());
                        }
                        else if (k.Equals("z"))
                        {
                            readValues.Text += "Z: " + dico[k] + "\n";

                            ZSlot.Value = Int32.Parse(dico[k].ToString());
                        }
                        else if (k.Equals("t"))
                        {
                            readValues.Text += "TimeStamp: " + dico[k] + "\n";
                            String H = DateTime.Now.ToString("HH");
                            String M = DateTime.Now.ToString("mm");
                            String S = DateTime.Now.ToString("ss");
                            int hh = Int32.Parse(H);
                            int mm = Int32.Parse(M);
                            int ss = Int32.Parse(S);
                            int date = hh * 3600 + (60 * mm) + ss;
                            int old = Int32.Parse(dico[k].ToString());
                            readValues.Text += "Local Time: " + date + "\n";
                            readValues.Text += "Diffrence: " + (date - old) + "\n";
                        }
                        else if (k.Equals("r"))
                        {
                            if (Int32.Parse(dico[k].ToString()) == 0)
                            {
                                readValues.Text += "Incrementing X";
                                radioX.Checked = true;
                                radioY.Checked = false;
                            }
                            else if (Int32.Parse(dico[k].ToString()) == 1)
                            {
                                readValues.Text += "Incrementing Y ";
                                radioX.Checked = false;
                                radioY.Checked = true;
                            }

                        }
                    }

                }
                //////
            }
            catch (Exception a)
            {
                MessageBox.Show("Serial Port unavailable | " + a.Message);
            }

        }

    }
}
