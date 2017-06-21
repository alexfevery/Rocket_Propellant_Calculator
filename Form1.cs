using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Propellant_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Oxdensity.Text = "0";
            oxratiovolume.Text = "0";
            oxratiomass.Text = "0";
            thrust.Text = "0";
            oxmass.Text = "0";
            totalmass.Text = "0";
            oxvolume.Text = "0";
            totalvolume.Text = "0";
            isp.Text = "0";
            fueldensity.Text = "0";
            fuelratiovolume.Text = "0";
            fuelratiomass.Text = "0";
            fuelmass.Text = "0";
            fuelvolume.Text = "0";
            selector.SelectedIndex = 0;
            Oxtype.SelectedIndex = 1;
            fueltype.SelectedIndex = 1;
        }



        private void value_KeyUp(object sender, EventArgs e)
        {
            try
            {
                if (value.Text.Length > 1 && (value.Text[value.Text.Length - 1] == '.')) return;
                if (Convert.ToDouble(value.Text) < 0) { value.Text = ("0"); }
                if (Convert.ToDouble(value.Text) > 1000000000000) { value.Text = ("0"); }

                if (selector.SelectedIndex == 0)
                {

                    Double oxdensity1 = Convert.ToDouble(Oxdensity.Text);
                    Double oxratiovolume1 = Convert.ToDouble(oxratiovolume.Text);
                    Double oxratiomass1 = Convert.ToDouble(oxratiomass.Text);
                    Double thrust1 = Convert.ToDouble(thrust.Text);
                    Double fueldensity1 = Convert.ToDouble(fueldensity.Text);
                    Double fuelratiovolume1 = Convert.ToDouble(fuelratiovolume.Text);
                    Double fuelratiomass1 = Convert.ToDouble(fuelratiomass.Text);

                    totalmass.Text = (value.Text);
                    oxvolume.Text = Convert.ToString(((Convert.ToDouble(totalmass.Text) * oxratiomass1) / oxdensity1));
                    oxmass.Text = Convert.ToString((Convert.ToDouble(oxvolume.Text) * oxdensity1));

                    totalvolume.Text = Convert.ToString((Convert.ToDouble(oxvolume.Text) + ((Convert.ToDouble(oxvolume.Text) * fuelratiovolume1) / oxratiovolume1)));


                    fuelmass.Text = Convert.ToString((Convert.ToDouble(totalmass.Text) * fuelratiomass1));


                    fuelvolume.Text = Convert.ToString((Convert.ToDouble(totalvolume.Text) * fuelratiovolume1));
                    isp.Text = Convert.ToString((Convert.ToDouble(thrust.Text) * 1000) / (9.80665 * Convert.ToDouble(totalmass.Text)));

                    totalvolume.Text = Convert.ToString(Math.Round(Convert.ToDouble(totalvolume.Text), 2));
                    totalmass.Text = Convert.ToString(Math.Round(Convert.ToDouble(totalmass.Text), 2));
                    oxmass.Text = Convert.ToString(Math.Round(Convert.ToDouble(oxmass.Text), 2));
                    oxvolume.Text = Convert.ToString(Math.Round(Convert.ToDouble(oxvolume.Text), 2));
                    fuelmass.Text = Convert.ToString(Math.Round(Convert.ToDouble(fuelmass.Text), 2));
                    fuelvolume.Text = Convert.ToString(Math.Round(Convert.ToDouble(fuelvolume.Text), 2));
                    isp.Text = Convert.ToString(Math.Round(Convert.ToDouble(isp.Text), 2));

                }


                if (selector.SelectedIndex == 1)
                {
                    Double oxdensity1 = Convert.ToDouble(Oxdensity.Text);
                    Double oxratiovolume1 = Convert.ToDouble(oxratiovolume.Text);
                    Double oxratiomass1 = Convert.ToDouble(oxratiomass.Text);
                    Double thrust1 = Convert.ToDouble(thrust.Text);
                    Double fueldensity1 = Convert.ToDouble(fueldensity.Text);
                    Double fuelratiovolume1 = Convert.ToDouble(fuelratiovolume.Text);
                    Double fuelratiomass1 = Convert.ToDouble(fuelratiomass.Text);

                    totalvolume.Text = (value.Text);
                    totalmass.Text = Convert.ToString(((Convert.ToDouble(totalvolume.Text) * fuelratiovolume1) * fueldensity1) + ((Convert.ToDouble(totalvolume.Text) * oxratiovolume1)) * oxdensity1);


                    oxmass.Text = Convert.ToString((Convert.ToDouble(totalvolume.Text) * oxratiovolume1) * oxdensity1);
                    oxvolume.Text = Convert.ToString((Convert.ToDouble(totalvolume.Text) * oxratiovolume1));

                    fuelmass.Text = Convert.ToString(((Convert.ToDouble(totalvolume.Text) * fuelratiovolume1)) * fueldensity1);

                    fuelvolume.Text = Convert.ToString((Convert.ToDouble(totalvolume.Text) * fuelratiovolume1));
                    isp.Text = Convert.ToString((Convert.ToDouble(thrust.Text) * 1000) / (9.80665 * Convert.ToDouble(totalmass.Text)));
                    isp.Text = Convert.ToString(Math.Round(Convert.ToDouble(isp.Text), 2));

                    totalvolume.Text = Convert.ToString(Math.Round(Convert.ToDouble(totalvolume.Text), 2));
                    totalmass.Text = Convert.ToString(Math.Round(Convert.ToDouble(totalmass.Text), 2));
                    oxmass.Text = Convert.ToString(Math.Round(Convert.ToDouble(oxmass.Text), 2));
                    oxvolume.Text = Convert.ToString(Math.Round(Convert.ToDouble(oxvolume.Text), 2));
                    fuelmass.Text = Convert.ToString(Math.Round(Convert.ToDouble(fuelmass.Text), 2));
                    fuelvolume.Text = Convert.ToString(Math.Round(Convert.ToDouble(fuelvolume.Text), 2));
                }


                if (selector.SelectedIndex == 2)
                {

                    Double oxdensity1 = Convert.ToDouble(Oxdensity.Text);
                    Double oxratiovolume1 = Convert.ToDouble(oxratiovolume.Text);
                    Double oxratiomass1 = Convert.ToDouble(oxratiomass.Text);
                    Double thrust1 = Convert.ToDouble(thrust.Text);
                    Double fueldensity1 = Convert.ToDouble(fueldensity.Text);
                    Double fuelratiovolume1 = Convert.ToDouble(fuelratiovolume.Text);
                    Double fuelratiomass1 = Convert.ToDouble(fuelratiomass.Text);


                    fuelvolume.Text = value.Text;
                    oxmass.Text = Convert.ToString((((Convert.ToDouble(fuelvolume.Text) * oxratiovolume1) / fuelratiovolume1) * oxdensity1));
                    totalmass.Text = Convert.ToString((Convert.ToDouble(fuelvolume.Text) * fueldensity1) + ((Convert.ToDouble(fuelvolume.Text)) * (oxratiovolume1 / fuelratiovolume1)) * oxdensity1);



                    oxvolume.Text = Convert.ToString((Convert.ToDouble(oxmass.Text) / oxdensity1));
                    totalvolume.Text = Convert.ToString(((Convert.ToDouble(totalmass.Text) * oxratiomass1) / oxdensity1));
                    fuelmass.Text = Convert.ToString((Convert.ToDouble(fuelvolume.Text) * fueldensity1));
                    isp.Text = Convert.ToString((Convert.ToDouble(thrust.Text) * 1000) / (9.80665 * Convert.ToDouble(totalmass.Text)));
                    isp.Text = Convert.ToString(Math.Round(Convert.ToDouble(isp.Text), 2));

                    totalvolume.Text = Convert.ToString(Math.Round(Convert.ToDouble(totalvolume.Text), 2));
                    totalmass.Text = Convert.ToString(Math.Round(Convert.ToDouble(totalmass.Text), 2));
                    oxmass.Text = Convert.ToString(Math.Round(Convert.ToDouble(oxmass.Text), 2));
                    oxvolume.Text = Convert.ToString(Math.Round(Convert.ToDouble(oxvolume.Text), 2));
                    fuelmass.Text = Convert.ToString(Math.Round(Convert.ToDouble(fuelmass.Text), 2));
                    fuelvolume.Text = Convert.ToString(Math.Round(Convert.ToDouble(fuelvolume.Text), 2));

                }

                if (selector.SelectedIndex == 3)
                {
                    Double oxdensity1 = Convert.ToDouble(Oxdensity.Text);
                    Double oxratiovolume1 = Convert.ToDouble(oxratiovolume.Text);
                    Double oxratiomass1 = Convert.ToDouble(oxratiomass.Text);
                    Double thrust1 = Convert.ToDouble(thrust.Text);
                    Double fueldensity1 = Convert.ToDouble(fueldensity.Text);
                    Double fuelratiovolume1 = Convert.ToDouble(fuelratiovolume.Text);
                    Double fuelratiomass1 = Convert.ToDouble(fuelratiomass.Text);

                    fuelmass.Text = value.Text;
                    fuelvolume.Text = Convert.ToString((Convert.ToDouble(fuelmass.Text) / fueldensity1));
                    oxvolume.Text = Convert.ToString((((Convert.ToDouble(fuelmass.Text) / fuelratiomass1) - (Convert.ToDouble(fuelmass.Text))) / oxdensity1));
                    oxmass.Text = Convert.ToString((Convert.ToDouble(oxvolume.Text) * oxdensity1));
                    totalvolume.Text = Convert.ToString((((Convert.ToDouble(fuelmass.Text) / fuelratiomass1) - (Convert.ToDouble(fuelmass.Text))) / oxdensity1) + (Convert.ToDouble(fuelmass.Text) / fueldensity1));

                    totalmass.Text = Convert.ToString(Convert.ToDouble(fuelmass.Text) + Convert.ToDouble(oxmass.Text));



                    isp.Text = Convert.ToString((Convert.ToDouble(thrust.Text) * 1000) / (9.80665 * Convert.ToDouble(totalmass.Text)));
                    isp.Text = Convert.ToString(Math.Round(Convert.ToDouble(isp.Text), 2));

                    totalvolume.Text = Convert.ToString(Math.Round(Convert.ToDouble(totalvolume.Text), 2));
                    totalmass.Text = Convert.ToString(Math.Round(Convert.ToDouble(totalmass.Text), 2));
                    oxmass.Text = Convert.ToString(Math.Round(Convert.ToDouble(oxmass.Text), 2));
                    oxvolume.Text = Convert.ToString(Math.Round(Convert.ToDouble(oxvolume.Text), 2));
                    fuelmass.Text = Convert.ToString(Math.Round(Convert.ToDouble(fuelmass.Text), 2));
                    fuelvolume.Text = Convert.ToString(Math.Round(Convert.ToDouble(fuelvolume.Text), 2));

                }

                if (selector.SelectedIndex == 4)
                {
                    Double oxdensity1 = Convert.ToDouble(Oxdensity.Text);
                    Double oxratiovolume1 = Convert.ToDouble(oxratiovolume.Text);
                    Double oxratiomass1 = Convert.ToDouble(oxratiomass.Text);
                    Double thrust1 = Convert.ToDouble(thrust.Text);
                    Double fueldensity1 = Convert.ToDouble(fueldensity.Text);
                    Double fuelratiovolume1 = Convert.ToDouble(fuelratiovolume.Text);
                    Double fuelratiomass1 = Convert.ToDouble(fuelratiomass.Text);

                    oxvolume.Text = value.Text;
                    oxmass.Text = Convert.ToString((Convert.ToDouble(oxvolume.Text) * oxdensity1));
                    fuelmass.Text = Convert.ToString(((Convert.ToDouble(oxmass.Text) / oxratiomass1) - Convert.ToDouble(oxmass.Text)));

                    totalmass.Text = Convert.ToString((Convert.ToDouble(oxmass.Text) + ((Convert.ToDouble(oxmass.Text) * fuelratiomass1) / oxratiomass1)));
                    totalvolume.Text = Convert.ToString((Convert.ToDouble(oxvolume.Text) + ((Convert.ToDouble(oxvolume.Text) * fuelratiovolume1) / oxratiovolume1)));
                    fuelvolume.Text = Convert.ToString((Convert.ToDouble(fuelmass.Text) / fueldensity1));
                    isp.Text = Convert.ToString((Convert.ToDouble(thrust.Text) * 1000) / (9.80665 * Convert.ToDouble(totalmass.Text)));
                    isp.Text = Convert.ToString(Math.Round(Convert.ToDouble(isp.Text), 2));

                    totalvolume.Text = Convert.ToString(Math.Round(Convert.ToDouble(totalvolume.Text), 2));
                    totalmass.Text = Convert.ToString(Math.Round(Convert.ToDouble(totalmass.Text), 2));
                    oxmass.Text = Convert.ToString(Math.Round(Convert.ToDouble(oxmass.Text), 2));
                    oxvolume.Text = Convert.ToString(Math.Round(Convert.ToDouble(oxvolume.Text), 2));
                    fuelmass.Text = Convert.ToString(Math.Round(Convert.ToDouble(fuelmass.Text), 2));
                    fuelvolume.Text = Convert.ToString(Math.Round(Convert.ToDouble(fuelvolume.Text), 2));

                }

                if (selector.SelectedIndex == 5)
                {
                    Double oxdensity1 = Convert.ToDouble(Oxdensity.Text);
                    Double oxratiovolume1 = Convert.ToDouble(oxratiovolume.Text);
                    Double oxratiomass1 = Convert.ToDouble(oxratiomass.Text);
                    Double thrust1 = Convert.ToDouble(thrust.Text);
                    Double fueldensity1 = Convert.ToDouble(fueldensity.Text);
                    Double fuelratiovolume1 = Convert.ToDouble(fuelratiovolume.Text);
                    Double fuelratiomass1 = Convert.ToDouble(fuelratiomass.Text);

                    oxmass.Text = value.Text;
                    totalmass.Text = Convert.ToString((Convert.ToDouble(oxmass.Text) + (((Convert.ToDouble(oxmass.Text) * fuelratiomass1) / oxratiomass1))));
                    oxvolume.Text = Convert.ToString((Convert.ToDouble(oxmass.Text) / oxdensity1));

                    fuelmass.Text = Convert.ToString(((Convert.ToDouble(oxmass.Text) * oxratiomass1) / fuelratiomass1));
                    fuelvolume.Text = Convert.ToString(((Convert.ToDouble(oxmass.Text) / oxratiomass1) - Convert.ToDouble(oxmass.Text)) / fueldensity1);
                    totalvolume.Text = Convert.ToString(Convert.ToDouble(oxvolume.Text) + Convert.ToDouble(fuelvolume.Text));

                    isp.Text = Convert.ToString((Convert.ToDouble(thrust.Text) * 1000) / (9.80665 * Convert.ToDouble(totalmass.Text)));
                    isp.Text = Convert.ToString(Math.Round(Convert.ToDouble(isp.Text), 2));

                    totalvolume.Text = Convert.ToString(Math.Round(Convert.ToDouble(totalvolume.Text), 2));
                    totalmass.Text = Convert.ToString(Math.Round(Convert.ToDouble(totalmass.Text), 2));
                    oxmass.Text = Convert.ToString(Math.Round(Convert.ToDouble(oxmass.Text), 2));
                    oxvolume.Text = Convert.ToString(Math.Round(Convert.ToDouble(oxvolume.Text), 2));
                    fuelmass.Text = Convert.ToString(Math.Round(Convert.ToDouble(fuelmass.Text), 2));
                    fuelvolume.Text = Convert.ToString(Math.Round(Convert.ToDouble(fuelvolume.Text), 2));

                }

                if (selector.SelectedIndex == 6)
                {
                    try
                    {

                        Double oxdensity1 = Convert.ToDouble(Oxdensity.Text);
                        Double oxratiovolume1 = Convert.ToDouble(oxratiovolume.Text);
                        Double oxratiomass1 = Convert.ToDouble(oxratiomass.Text);
                        Double thrust1 = Convert.ToDouble(thrust.Text);
                        Double fueldensity1 = Convert.ToDouble(fueldensity.Text);
                        Double fuelratiovolume1 = Convert.ToDouble(fuelratiovolume.Text);
                        Double fuelratiomass1 = Convert.ToDouble(fuelratiomass.Text);


                        if (thrust1 < 0)
                        {
                            thrust.Text = Convert.ToString(0);
                            return;
                        }
                        thrust.Text = value.Text;
                        isp.Text = Convert.ToString((Convert.ToDouble(thrust.Text) * 1000) / (9.80665 * Convert.ToDouble(totalmass.Text)));

                        isp.Text = Convert.ToString(Math.Round(Convert.ToDouble(isp.Text), 2));
                        thrust.Text = Convert.ToString(Math.Round(Convert.ToDouble(thrust.Text), 2));

                    }
                    catch (System.FormatException)
                    {
                        thrust.Text = Convert.ToString(0);
                        return;
                    }


                }

                value.Text = Convert.ToString(Convert.ToDouble(value.Text));

                value.Select(value.Text.Length, 0);
            }
            catch
            {
                totalvolume.Text = "0";
                totalmass.Text = "0";
                oxmass.Text = "0";
                oxvolume.Text = "0";
                fuelmass.Text = "0";
                fuelvolume.Text = "0";
                thrust.Text = "0";
            }
        }



        private void selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            value.Text = "";
        }

        private void oxratiovolume_KeyUp(object sender, KeyEventArgs e)
        {

            try
            {
                if (oxratiovolume.TextLength > 0 && (oxratiovolume.Text[oxratiovolume.Text.Length - 1] == '.' | oxratiovolume.Text[oxratiovolume.Text.Length - 1] == '0')) { return; };

                if (Convert.ToDouble(oxratiovolume.Text) > 1) { oxratiovolume.Text = ("1"); }
                if (Convert.ToDouble(oxratiovolume.Text) < 0) { oxratiovolume.Text = ("0"); }

                Double oxdensity1 = Convert.ToDouble(Oxdensity.Text);
                Double oxratiovolume1 = Convert.ToDouble(oxratiovolume.Text);
                Double oxratiomass1 = Convert.ToDouble(oxratiomass.Text);
                Double thrust1 = Convert.ToDouble(thrust.Text);
                Double fueldensity1 = Convert.ToDouble(fueldensity.Text);
                Double fuelratiovolume1 = Convert.ToDouble(fuelratiovolume.Text);
                Double fuelratiomass1 = Convert.ToDouble(fuelratiomass.Text);



                fuelratiovolume.Text = Convert.ToString(1 - oxratiovolume1);
                fuelratiovolume1 = Convert.ToDouble(fuelratiovolume.Text);

                Double oxmass1 = Convert.ToDouble(oxmass.Text);
                Double totalmass1 = Convert.ToDouble(totalmass.Text);
                Double oxvolume1 = Convert.ToDouble(oxvolume.Text);
                Double totalvolume1 = Convert.ToDouble(totalvolume.Text);
                Double isp1 = Convert.ToDouble(isp.Text);
                Double fuelmass1 = Convert.ToDouble(fuelmass.Text);
                Double fuelvolume1 = Convert.ToDouble(fuelvolume.Text);



                totalmass.Text = Convert.ToString((Convert.ToDouble(oxmass.Text) + (((Convert.ToDouble(oxmass.Text) * fuelratiomass1) / oxratiomass1))));
                oxvolume.Text = Convert.ToString((Convert.ToDouble(oxmass.Text) / oxdensity1));
                oxmass.Text = Convert.ToString((Convert.ToDouble(oxvolume.Text) * oxdensity1));
                fuelmass.Text = Convert.ToString(((Convert.ToDouble(oxmass.Text) * oxratiomass1) / fuelratiomass1));
                fuelvolume.Text = Convert.ToString(((Convert.ToDouble(oxmass.Text) / oxratiomass1) - Convert.ToDouble(oxmass.Text)) / fueldensity1);
                totalvolume.Text = Convert.ToString(Convert.ToDouble(oxvolume.Text) + Convert.ToDouble(fuelvolume.Text));

                oxratiomass.Text = Convert.ToString((oxratiovolume1 * oxdensity1) / ((oxratiovolume1 * oxdensity1) + (fuelratiovolume1 * fueldensity1)));
                fuelratiomass.Text = Convert.ToString(1 - Convert.ToDouble(oxratiomass.Text));


                decimal num1 = Convert.ToDecimal(oxratiovolume.Text);
                int count = BitConverter.GetBytes(decimal.GetBits(num1)[3])[2];

                totalvolume.Text = Convert.ToString(Math.Round(Convert.ToDouble(totalvolume.Text), 2));
                totalmass.Text = Convert.ToString(Math.Round(Convert.ToDouble(totalmass.Text), 2));
                oxmass.Text = Convert.ToString(Math.Round(Convert.ToDouble(oxmass.Text), 2));
                oxvolume.Text = Convert.ToString(Math.Round(Convert.ToDouble(oxvolume.Text), 2));
                fuelmass.Text = Convert.ToString(Math.Round(Convert.ToDouble(fuelmass.Text), 2));
                fuelvolume.Text = Convert.ToString(Math.Round(Convert.ToDouble(fuelvolume.Text), 2));

                double value = Convert.ToDouble(oxratiomass.Text);
                for (int places = count; places < 10; ++places)
                {
                    if ((Math.Round(value, places) != 0) && (Math.Round(value, places) != 1))
                    {
                        oxratiomass.Text = Convert.ToString(Math.Round(Convert.ToDouble(oxratiomass.Text), (places)));
                        break;
                    }

                }

                value = Convert.ToDouble(fuelratiomass.Text);
                for (int places = count; places < 10; ++places)
                {
                    if ((Math.Round(value, places) != 0) && (Math.Round(value, places) != 1))
                    {
                        fuelratiomass.Text = Convert.ToString(Math.Round(Convert.ToDouble(fuelratiomass.Text), (places)));
                        break;
                    }

                }


                oxratiovolume.Text = Convert.ToString(Convert.ToDouble(oxratiovolume.Text));
                oxratiovolume.Select(oxratiovolume.Text.Length, 0);

            }
            catch { }
        }

        private void fuelratiovolume_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (fuelratiovolume.Text.Length > 0 && (fuelratiovolume.Text[fuelratiovolume.Text.Length - 1] == '.' || fuelratiovolume.Text[fuelratiovolume.Text.Length - 1] == '0')) return;
                if (Convert.ToDouble(fuelratiovolume.Text) > 1) { fuelratiovolume.Text = ("1"); }
                if (Convert.ToDouble(fuelratiovolume.Text) < 0) { fuelratiovolume.Text = ("0"); }

                Double oxdensity1 = Convert.ToDouble(Oxdensity.Text);
                Double oxratiovolume1 = Convert.ToDouble(oxratiovolume.Text);
                Double oxratiomass1 = Convert.ToDouble(oxratiomass.Text);
                Double thrust1 = Convert.ToDouble(thrust.Text);
                Double fueldensity1 = Convert.ToDouble(fueldensity.Text);
                Double fuelratiovolume1 = Convert.ToDouble(fuelratiovolume.Text);
                Double fuelratiomass1 = Convert.ToDouble(fuelratiomass.Text);


                oxratiovolume.Text = Convert.ToString(1 - fuelratiovolume1);
                oxratiovolume1 = Convert.ToDouble(oxratiovolume.Text);

                Double oxmass1 = Convert.ToDouble(oxmass.Text);
                Double totalmass1 = Convert.ToDouble(totalmass.Text);
                Double oxvolume1 = Convert.ToDouble(oxvolume.Text);
                Double totalvolume1 = Convert.ToDouble(totalvolume.Text);
                Double isp1 = Convert.ToDouble(isp.Text);
                Double fuelmass1 = Convert.ToDouble(fuelmass.Text);
                Double fuelvolume1 = Convert.ToDouble(fuelvolume.Text);

                totalmass.Text = Convert.ToString((Convert.ToDouble(oxmass.Text) + (((Convert.ToDouble(oxmass.Text) * fuelratiomass1) / oxratiomass1))));
                oxvolume.Text = Convert.ToString((Convert.ToDouble(oxmass.Text) / oxdensity1));
                oxmass.Text = Convert.ToString((Convert.ToDouble(oxvolume.Text) * oxdensity1));
                fuelmass.Text = Convert.ToString(((Convert.ToDouble(oxmass.Text) * oxratiomass1) / fuelratiomass1));
                fuelvolume.Text = Convert.ToString(((Convert.ToDouble(oxmass.Text) / oxratiomass1) - Convert.ToDouble(oxmass.Text)) / fueldensity1);
                totalvolume.Text = Convert.ToString(Convert.ToDouble(oxvolume.Text) + Convert.ToDouble(fuelvolume.Text));

                oxratiomass.Text = Convert.ToString((oxratiovolume1 * oxdensity1) / ((oxratiovolume1 * oxdensity1) + (fuelratiovolume1 * fueldensity1)));
                fuelratiomass.Text = Convert.ToString(1 - Convert.ToDouble(oxratiomass.Text));

                decimal num1 = Convert.ToDecimal(fuelratiovolume.Text);
                int count = BitConverter.GetBytes(decimal.GetBits(num1)[3])[2];


                totalvolume.Text = Convert.ToString(Math.Round(Convert.ToDouble(totalvolume.Text), 2));
                totalmass.Text = Convert.ToString(Math.Round(Convert.ToDouble(totalmass.Text), 2));
                oxmass.Text = Convert.ToString(Math.Round(Convert.ToDouble(oxmass.Text), 2));
                oxvolume.Text = Convert.ToString(Math.Round(Convert.ToDouble(oxvolume.Text), 2));
                fuelmass.Text = Convert.ToString(Math.Round(Convert.ToDouble(fuelmass.Text), 2));
                fuelvolume.Text = Convert.ToString(Math.Round(Convert.ToDouble(fuelvolume.Text), 2));

                double value = Convert.ToDouble(oxratiomass.Text);
                for (int places = count; places < 10; ++places)
                {
                    if ((Math.Round(value, places) != 0) && (Math.Round(value, places) != 1))
                    {
                        oxratiomass.Text = Convert.ToString(Math.Round(Convert.ToDouble(oxratiomass.Text), (places)));
                        break;
                    }

                }

                value = Convert.ToDouble(fuelratiomass.Text);
                for (int places = count; places < 10; ++places)
                {
                    if ((Math.Round(value, places) != 0) && (Math.Round(value, places) != 1))
                    {
                        fuelratiomass.Text = Convert.ToString(Math.Round(Convert.ToDouble(fuelratiomass.Text), (places)));
                        break;
                    }
                }
                fuelratiovolume.Text = Convert.ToString(Convert.ToDouble(fuelratiovolume.Text));
                fuelratiovolume.Select(fuelratiovolume.Text.Length, 0);

            }
            catch { }
        }

        private void oxratiomass_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (oxratiomass.Text.Length > 0 && (oxratiomass.Text[oxratiomass.Text.Length - 1] == '.' || oxratiomass.Text[oxratiomass.Text.Length - 1] == '0')) return;
                if (Convert.ToDouble(oxratiomass.Text) > 1) { oxratiomass.Text = ("1"); }
                if (Convert.ToDouble(oxratiomass.Text) < 0) { oxratiomass.Text = ("0"); }

                Double oxdensity1 = Convert.ToDouble(Oxdensity.Text);
                Double oxratiovolume1 = Convert.ToDouble(oxratiovolume.Text);
                Double oxratiomass1 = Convert.ToDouble(oxratiomass.Text);
                Double thrust1 = Convert.ToDouble(thrust.Text);
                Double fueldensity1 = Convert.ToDouble(fueldensity.Text);
                Double fuelratiovolume1 = Convert.ToDouble(fuelratiovolume.Text);
                Double fuelratiomass1 = Convert.ToDouble(fuelratiomass.Text);


                fuelratiomass.Text = Convert.ToString(1 - oxratiomass1);
                fuelratiomass1 = Convert.ToDouble(fuelratiomass.Text);

                Double oxmass1 = Convert.ToDouble(oxmass.Text);
                Double totalmass1 = Convert.ToDouble(totalmass.Text);
                Double oxvolume1 = Convert.ToDouble(oxvolume.Text);
                Double totalvolume1 = Convert.ToDouble(totalvolume.Text);
                Double isp1 = Convert.ToDouble(isp.Text);
                Double fuelmass1 = Convert.ToDouble(fuelmass.Text);
                Double fuelvolume1 = Convert.ToDouble(fuelvolume.Text);

                totalmass.Text = Convert.ToString((Convert.ToDouble(oxmass.Text) + (((Convert.ToDouble(oxmass.Text) * fuelratiomass1) / oxratiomass1))));
                oxvolume.Text = Convert.ToString((Convert.ToDouble(oxmass.Text) / oxdensity1));
                oxmass.Text = Convert.ToString((Convert.ToDouble(oxvolume.Text) * oxdensity1));
                fuelmass.Text = Convert.ToString(((Convert.ToDouble(oxmass.Text) * oxratiomass1) / fuelratiomass1));
                fuelvolume.Text = Convert.ToString(((Convert.ToDouble(oxmass.Text) / oxratiomass1) - Convert.ToDouble(oxmass.Text)) / fueldensity1);
                totalvolume.Text = Convert.ToString(Convert.ToDouble(oxvolume.Text) + Convert.ToDouble(fuelvolume.Text));

                oxratiovolume.Text = Convert.ToString((oxratiomass1 / oxdensity1) / ((oxratiomass1 / oxdensity1) + (fuelratiomass1 / fueldensity1)));
                fuelratiovolume.Text = Convert.ToString(1 - Convert.ToDouble(oxratiovolume.Text));

                decimal num1 = Convert.ToDecimal(oxratiomass.Text);
                int count = BitConverter.GetBytes(decimal.GetBits(num1)[3])[2];


                totalvolume.Text = Convert.ToString(Math.Round(Convert.ToDouble(totalvolume.Text), 2));
                totalmass.Text = Convert.ToString(Math.Round(Convert.ToDouble(totalmass.Text), 2));
                oxmass.Text = Convert.ToString(Math.Round(Convert.ToDouble(oxmass.Text), 2));
                oxvolume.Text = Convert.ToString(Math.Round(Convert.ToDouble(oxvolume.Text), 2));
                fuelmass.Text = Convert.ToString(Math.Round(Convert.ToDouble(fuelmass.Text), 2));
                fuelvolume.Text = Convert.ToString(Math.Round(Convert.ToDouble(fuelvolume.Text), 2));

                double value = Convert.ToDouble(oxratiovolume.Text);
                for (int places = count; places < 10; ++places)
                {
                    if ((Math.Round(value, places) != 0) && (Math.Round(value, places) != 1))
                    {
                        oxratiovolume.Text = Convert.ToString(Math.Round(Convert.ToDouble(oxratiovolume.Text), (places)));
                        break;
                    }

                }

                value = Convert.ToDouble(fuelratiovolume.Text);
                for (int places = count; places < 10; ++places)
                {
                    if ((Math.Round(value, places) != 0) && (Math.Round(value, places) != 1))
                    {
                        fuelratiovolume.Text = Convert.ToString(Math.Round(Convert.ToDouble(fuelratiovolume.Text), (places)));
                        break;
                    }

                }

                oxratiomass.Text = Convert.ToString(Convert.ToDouble(oxratiomass.Text));

                oxratiomass.Select(oxratiomass.Text.Length, 0);


            }
            catch { }
        }

        private void fuelratiomass_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                if (fuelratiomass.Text.Length > 0 && (fuelratiomass.Text[fuelratiomass.Text.Length - 1] == '.' || fuelratiomass.Text[fuelratiomass.Text.Length - 1] == '0')) { return; }
                if (Convert.ToDouble(fuelratiomass.Text) > 1) { fuelratiomass.Text = ("1"); }
                if (Convert.ToDouble(fuelratiomass.Text) < 0) { fuelratiomass.Text = ("0"); }

                Double oxdensity1 = Convert.ToDouble(Oxdensity.Text);
                Double oxratiovolume1 = Convert.ToDouble(oxratiovolume.Text);
                Double oxratiomass1 = Convert.ToDouble(oxratiomass.Text);
                Double thrust1 = Convert.ToDouble(thrust.Text);
                Double fueldensity1 = Convert.ToDouble(fueldensity.Text);
                Double fuelratiovolume1 = Convert.ToDouble(fuelratiovolume.Text);
                Double fuelratiomass1 = Convert.ToDouble(fuelratiomass.Text);


                oxratiomass.Text = Convert.ToString(1 - fuelratiomass1);
                oxratiomass1 = Convert.ToDouble(oxratiomass.Text);


                Double oxmass1 = Convert.ToDouble(oxmass.Text);
                Double totalmass1 = Convert.ToDouble(totalmass.Text);
                Double oxvolume1 = Convert.ToDouble(oxvolume.Text);
                Double totalvolume1 = Convert.ToDouble(totalvolume.Text);
                Double isp1 = Convert.ToDouble(isp.Text);
                Double fuelmass1 = Convert.ToDouble(fuelmass.Text);
                Double fuelvolume1 = Convert.ToDouble(fuelvolume.Text);

                totalmass.Text = Convert.ToString((Convert.ToDouble(oxmass.Text) + (((Convert.ToDouble(oxmass.Text) * fuelratiomass1) / oxratiomass1))));
                oxvolume.Text = Convert.ToString((Convert.ToDouble(oxmass.Text) / oxdensity1));
                oxmass.Text = Convert.ToString((Convert.ToDouble(oxvolume.Text) * oxdensity1));
                fuelmass.Text = Convert.ToString(((Convert.ToDouble(oxmass.Text) * oxratiomass1) / fuelratiomass1));
                fuelvolume.Text = Convert.ToString(((Convert.ToDouble(oxmass.Text) / oxratiomass1) - Convert.ToDouble(oxmass.Text)) / fueldensity1);
                totalvolume.Text = Convert.ToString(Convert.ToDouble(oxvolume.Text) + Convert.ToDouble(fuelvolume.Text));

                oxratiovolume.Text = Convert.ToString((oxratiomass1 / oxdensity1) / ((oxratiomass1 / oxdensity1) + (fuelratiomass1 / fueldensity1)));
                fuelratiovolume.Text = Convert.ToString(1 - Convert.ToDouble(oxratiovolume.Text));

                decimal num1 = Convert.ToDecimal(fuelratiomass.Text);
                int count = BitConverter.GetBytes(decimal.GetBits(num1)[3])[2];

                totalvolume.Text = Convert.ToString(Math.Round(Convert.ToDouble(totalvolume.Text), 2));
                totalmass.Text = Convert.ToString(Math.Round(Convert.ToDouble(totalmass.Text), 2));
                oxmass.Text = Convert.ToString(Math.Round(Convert.ToDouble(oxmass.Text), 2));
                oxvolume.Text = Convert.ToString(Math.Round(Convert.ToDouble(oxvolume.Text), 2));
                fuelmass.Text = Convert.ToString(Math.Round(Convert.ToDouble(fuelmass.Text), 2));
                fuelvolume.Text = Convert.ToString(Math.Round(Convert.ToDouble(fuelvolume.Text), 2));

                double value = Convert.ToDouble(oxratiovolume.Text);
                for (int places = count; places < 10; ++places)
                {
                    if ((Math.Round(value, places) != 0) && (Math.Round(value, places) != 1))
                    {
                        oxratiovolume.Text = Convert.ToString(Math.Round(Convert.ToDouble(oxratiovolume.Text), (places)));
                        break;
                    }
                }

                value = Convert.ToDouble(fuelratiovolume.Text);
                for (int places = count; places < 10; ++places)
                {
                    if ((Math.Round(value, places) != 0) && (Math.Round(value, places) != 1))
                    {
                        fuelratiovolume.Text = Convert.ToString(Math.Round(Convert.ToDouble(fuelratiovolume.Text), (places)));
                        break;
                    }

                }


                fuelratiomass.Text = Convert.ToString(Convert.ToDouble(fuelratiomass.Text));

                fuelratiomass.Select(fuelratiomass.Text.Length, 0);

            }
            catch { }
        }

        private void selector_TextChanged(object sender, EventArgs e)
        {
            value.Text = ("");
        }


        private void Oxtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            Oxdensity.ReadOnly = true;
            if (Oxtype.SelectedIndex == 0)
            {
                Oxtype.Text = "";
                Oxdensity.Text = "0";
                Oxdensity.ReadOnly = false;
            }
            if (Oxtype.SelectedIndex == 1)
            {
                Oxtype.Text = "LOX";
                Oxdensity.Text = "1.141";

            }
            if (Oxtype.SelectedIndex == 2)
            {
                Oxtype.Text = "N2O4";
                Oxdensity.Text = "1.44";

            }
            if (Oxtype.SelectedIndex == 3)
            {
                Oxtype.Text = "H2O2";
                Oxdensity.Text = "1.45";

            }
            if (Oxtype.SelectedIndex == 4)
            {
                Oxtype.Text = "N2O";
                Oxdensity.Text = "1.98";

            }


            value.Text = "0";
            totalvolume.Text = "0";
            totalmass.Text = "0";
            oxmass.Text = "0";
            oxvolume.Text = "0";
            fuelmass.Text = "0";
            fuelvolume.Text = "0";
            oxratiomass.Text = "0";
            fuelratiomass.Text = "0";
            oxratiovolume.Text = "0";
            fuelratiovolume.Text = "0";



        }

        private void fueltype_SelectedIndexChanged(object sender, EventArgs e)
        {
            fueldensity.ReadOnly = true;
            if (fueltype.SelectedIndex == 0)
            {
                fueltype.Text = "";
                fueldensity.Text = "0";
                fueldensity.ReadOnly = false;
            }
            if (fueltype.SelectedIndex == 1)
            {
                fueltype.Text = "RP-1";
                fueldensity.Text = "0.81";
            }
            if (fueltype.SelectedIndex == 2)
            {
                fueltype.Text = "LH2";
                fueldensity.Text = "0.07085";
            }
            if (fueltype.SelectedIndex == 3)
            {
                fueltype.Text = "Hydrazine";
                fueldensity.Text = "1.02";
            }
            if (fueltype.SelectedIndex == 4)
            {
                fueltype.Text = "MMH";
                fueldensity.Text = "0.88";
            }
            if (fueltype.SelectedIndex == 5)
            {
                fueltype.Text = "UDMH";
                fueldensity.Text = "0.793";
            }
            if (fueltype.SelectedIndex == 6)
            {
                fueltype.Text = "Aerozine 50";
                fueldensity.Text = "0.903";
            }

            value.Text = "0";
            totalvolume.Text = "0";
            totalmass.Text = "0";
            oxmass.Text = "0";
            oxvolume.Text = "0";
            fuelmass.Text = "0";
            fuelvolume.Text = "0";
            oxratiomass.Text = "0";
            fuelratiomass.Text = "0";
            oxratiovolume.Text = "0";
            fuelratiovolume.Text = "0";


        }

        private void Oxdensity_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Oxdensity.Text.Length > 0 && (Oxdensity.Text[Oxdensity.Text.Length - 1] == '.' || Oxdensity.Text[Oxdensity.Text.Length - 1] == '0')) { return; }
                Double oxdensity1 = Convert.ToDouble(Oxdensity.Text);
                Double oxratiovolume1 = Convert.ToDouble(oxratiovolume.Text);
                Double oxratiomass1 = Convert.ToDouble(oxratiomass.Text);
                Double thrust1 = Convert.ToDouble(thrust.Text);
                Double fueldensity1 = Convert.ToDouble(fueldensity.Text);
                Double fuelratiovolume1 = Convert.ToDouble(fuelratiovolume.Text);
                Double fuelratiomass1 = Convert.ToDouble(fuelratiomass.Text);
                if (oxdensity1 == 0) { return; }
                totalvolume.Text = "0";
                totalmass.Text = "0";
                oxmass.Text = "0";
                oxvolume.Text = "0";
                fuelmass.Text = "0";
                fuelvolume.Text = "0";
                isp.Text = "0";
                thrust.Text = "0";
                Oxdensity.Text = Convert.ToString(Convert.ToDouble(Oxdensity.Text));

                value.Text = "0";
                oxratiomass.Text = "0";
                fuelratiomass.Text = "0";
                oxratiovolume.Text = "0";
                fuelratiovolume.Text = "0";
                Oxdensity.Select(Oxdensity.Text.Length, 0);
            }
            catch { }
        }

        private void fueldensity_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (fueldensity.Text.Length > 0 && (fueldensity.Text[fueldensity.Text.Length - 1] == '.' || fueldensity.Text[fueldensity.Text.Length - 1] == '0')) return;
                Double oxdensity1 = Convert.ToDouble(Oxdensity.Text);
                Double oxratiovolume1 = Convert.ToDouble(oxratiovolume.Text);
                Double oxratiomass1 = Convert.ToDouble(oxratiomass.Text);
                Double thrust1 = Convert.ToDouble(thrust.Text);
                Double fueldensity1 = Convert.ToDouble(fueldensity.Text);
                Double fuelratiovolume1 = Convert.ToDouble(fuelratiovolume.Text);
                Double fuelratiomass1 = Convert.ToDouble(fuelratiomass.Text);

                if (fueldensity1 == 0) { return; }

                totalvolume.Text = "0";
                totalmass.Text = "0";
                oxmass.Text = "0";
                oxvolume.Text = "0";
                fuelmass.Text = "0";
                fuelvolume.Text = "0";
                isp.Text = "0";
                thrust.Text = "0";

                fueldensity.Text = Convert.ToString(Convert.ToDouble(fueldensity.Text));
                value.Text = "0";
                oxratiomass.Text = "0";
                fuelratiomass.Text = "0";
                oxratiovolume.Text = "0";
                fuelratiovolume.Text = "0";
                fueldensity.Select(fueldensity.Text.Length, 0);
            }
            catch { }
        }
    }
}
