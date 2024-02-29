using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS1
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do u want to exit?", "Exit Prompt",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void buttonRecommend_Click(object sender, EventArgs e)
        {
            int price = 0;
            ////фотография
            if (this.comboBoxTypeGraphic.Text == "Фотография")
            {
                if (this.comboBoxProcessor.Text == "AMD")
                {
                    labelCPUout.Text = "AMD Ryzen 5 2600";
                    labelMainboardOutput.Text = "ASRock A320M-HDV R4.0";
                } 
                else
                {
                    labelCPUout.Text = "Intel Core i5 - 9400F OEM";
                    labelMainboardOutput.Text = "GIGABYTE H310 H 2.0";
                }
                if (this.comboBoxYesNoFirma.Text == "Да")
                {
                    labelRAMoutput.Text = "Patriot Viper Elite " + comboBoxRAM.Text;
                    labelHDDoutput.Text = comboBoxHDD.Text + " Seagate 7200 BarraCuda";
                    labelSSDoutput.Text = comboBoxSSD.Text + " A-Data SU650";
                }
                else
                {
                    labelRAMoutput.Text = "Patriot Viper Elite 8 ГБ";
                    labelHDDoutput.Text = "1 ТБ Seagate 7200 BarraCuda";
                    labelSSDoutput.Text = "120 ГБ A-Data SU650";
                }
                labelGPUoutput.Text = "GeForce GT 1030 [GV-N1030D5-2GL]";
                labelCPUcooler.Text = "DEEPCOOL Theta 15 PWM [DP-ICAS-T15P]";
                labelPSUoutput.Text = "Aerocool ECO 500W";
                labelKorpusoutput.Text = "Zalman Z3 Plus";
                price = 38000;
            }
            //3D 
            if (this.comboBoxGraphicLevel.Text == "Начальнай-средний")
            {
                if (this.comboBoxProcessor.Text == "AMD")
                {
                    labelCPUout.Text = "AMD Ryzen 5 2600 OEM";
                    labelMainboardOutput.Text = "GIGABYTE GA-A320M-S2H";
                }
                else
                {
                    labelCPUout.Text = "Intel Core i3-10100F OEM";
                    labelMainboardOutput.Text = "ASRock H410M-HVS";
                }
                if (this.comboBoxYesNoFirma.Text == "Да")
                {
                    labelRAMoutput.Text = "AMD Radeon R9 Gamer Series " + comboBoxRAM.Text;
                    labelHDDoutput.Text = comboBoxHDD.Text + " Seagate 7200 BarraCuda";
                    labelSSDoutput.Text = comboBoxSSD.Text + " A-Data SU650";
                }
                else
                {
                    labelRAMoutput.Text = "AMD Radeon R9 Gamer Series 16 ГБ";
                    labelHDDoutput.Text = "1 ТБ Seagate 7200 BarraCuda";
                    labelSSDoutput.Text = "120 ГБ A-Data SU650";
                }
                labelGPUoutput.Text = "GIGABYTE GeForce GTX 1660 OC";
                labelCPUcooleroutput.Text = "DEEPCOOL Theta 15 PWM";
                labelPSUoutput.Text = "Aerocool VX PLUS 600W";
                labelKorpusoutput.Text = "DEXP DC-101B";
                price = 75000;
            }

            if (this.comboBoxGraphicLevel.Text == "Профессиональный")
            {
                if (this.comboBoxProcessor.Text == "AMD")
                {
                    labelCPUout.Text = "AMD Ryzen 5 3600X OEM";
                    labelMainboardOutput.Text = "ASUS PRIME B450M-K";
                }
                else
                {
                    labelCPUout.Text = "Intel Core i5-10600K OEM";
                    labelMainboardOutput.Text = "MSI B460M-A PRO";
                }
                if (this.comboBoxYesNoFirma.Text == "Да")
                {
                    labelRAMoutput.Text = "A-Data XPG Gammix D10 " + comboBoxRAM.Text;
                    labelHDDoutput.Text = comboBoxHDD.Text + " Seagate 7200 BarraCuda";
                    labelSSDoutput.Text = comboBoxSSD.Text + " A-Data SU650";
                }
                else
                {
                    labelRAMoutput.Text = "A-Data XPG Gammix D10 16 ГБ";
                    labelHDDoutput.Text = "2 ТБ Seagate 7200 BarraCuda";
                    labelSSDoutput.Text = "480 ГБ A-Data SU650";
                }
                labelGPUoutput.Text = "PALIT NVIDIA GeForce RTX 2060SUPER DUAL";
                labelCPUcooleroutput.Text = "PCCooler GI-X4S";
                labelPSUoutput.Text = "Aerocool VX PLUS 700W";
                labelKorpusoutput.Text = "Zalman Z1 NEO";
                price = 140000;
            }

            if (this.comboBoxGraphicLevel.Text == "Профессиональный с учётом работы с тяжёлыми обектами")
            {
                if (this.comboBoxProcessor.Text == "AMD")
                {
                    labelCPUout.Text = "AMD Ryzen 5 3600X OEM";
                    labelMainboardOutput.Text = "ASUS PRIME B450M-K";
                }
                else
                {
                    labelCPUout.Text = "Intel Core i9-10900K OEM";
                    labelMainboardOutput.Text = "GIGABYTE B460 HD3";
                }
                if (this.comboBoxYesNoFirma.Text == "Да")
                {
                    labelRAMoutput.Text = "G.Skill TRIDENT Z RGB " + comboBoxRAM.Text;
                    labelHDDoutput.Text = comboBoxHDD.Text + " Toshiba X300";
                    labelSSDoutput.Text = comboBoxSSD.Text + " SSD M.2 íàêîïèòåëü A-Data XPG SX8200 Pro";
                }
                else
                {
                    labelRAMoutput.Text = "G.Skill TRIDENT Z RGB 64 ГБ";
                    labelHDDoutput.Text = "6 ТБ Toshiba X300";
                    labelSSDoutput.Text = "2048 ГБ SSD M.2 íàêîïèòåëü A-Data XPG SX8200 Pro";
                }
                labelGPUoutput.Text = "PNY Quadro RTX 6000";
                labelCPUcooleroutput.Text = "Xilence M504D";
                labelPSUoutput.Text = "Deepcool DQ ST 800W";
                labelKorpusoutput.Text = "Zalman Z1 NEO";
                price = 450000;
            }

            if (comboBoxSel2.Text == "Работа с музыкой")
            {
                if (this.comboBoxPriceLevel.Text == "Бюджетная")
                {
                    if (this.comboBoxProcessor.Text == "AMD")
                    {
                        labelCPUout.Text = "AMD Ryzen 5 3350G OEM";
                        labelMainboardOutput.Text = "GIGABYTE B450M-H";
                    }
                    else
                    {
                        labelCPUout.Text = "Intel Core i5-10400 OEM";
                        labelMainboardOutput.Text = "ASRock H410M-HVS";
                    }
                    if (this.comboBoxYesNoFirma.Text == "Да")
                    {
                        labelRAMoutput.Text = "Crucial DDR4 " + comboBoxRAM.Text;
                        labelHDDoutput.Text = comboBoxHDD.Text + " Seagate 7200 BarraCuda";
                        labelSSDoutput.Text = comboBoxSSD.Text + " A-Data SU650";
                    }
                    else
                    {
                        labelRAMoutput.Text = "Crucial DDR4 16 ГБ";
                        labelHDDoutput.Text = "2 ТБ Seagate 7200 BarraCuda";
                        labelSSDoutput.Text = "250 ГБ A-Data SU650";
                    }
                    labelGPUoutput.Text = "не требуется";
                    labelCPUcooleroutput.Text = "PCCooler GI-X3B [GI-X3B]";
                    labelPSUoutput.Text = "Seasonic 620W";
                    labelKorpusoutput.Text = "DeepCool Tesseract";
                    labelSoundCardoutput.Text = "ASUS Xonar DGX GX2.5";
                }
                if (this.comboBoxPriceLevel.Text == "Оптимальная")
                {
                    if (this.comboBoxProcessor.Text == "AMD")
                    {
                        labelCPUout.Text = "AMD Ryzen 7 3700X";
                        labelMainboardOutput.Text = "MSI X470 Gaming Pro";
                    }
                    else
                    {
                        labelCPUout.Text = "Intel i7-9700K";
                        labelMainboardOutput.Text = "MSI Z370 PC Pro";
                    }
                    if (this.comboBoxYesNoFirma.Text == "Да")
                    {
                        labelRAMoutput.Text = "Crucial DDR4 " + comboBoxRAM.Text;
                        labelHDDoutput.Text = comboBoxHDD.Text + " Seagate 7200 BarraCuda";
                        labelSSDoutput.Text = comboBoxSSD.Text + " A-Data SU650";
                    }
                    else
                    {
                        labelRAMoutput.Text = "Crucial DDR4 16 ГБ";
                        labelHDDoutput.Text = "2 ТБ Seagate 7200 BarraCuda";
                        labelSSDoutput.Text = "512 ГБ A-Data SU650";
                    }
                    labelGPUoutput.Text = "GigaByte GTX-1050 Ti";
                    labelCPUcooleroutput.Text = "be quiet! Pure Rock";
                    labelPSUoutput.Text = "EVGA 850W";
                    labelKorpusoutput.Text = "Corsair 750D";
                    labelSoundCardoutput.Text = "Creative Sound Blaster Audigy RX";
                }
                if (this.comboBoxPriceLevel.Text == "Профессиональная")
                {
                    if (this.comboBoxProcessor.Text == "AMD")
                    {
                        labelCPUout.Text = "AMD Ryzen 9 3950X";
                        labelMainboardOutput.Text = "MSI X470 Gaming Pro";
                    }
                    else
                    {
                        labelCPUout.Text = "Intel Core i9-10900K OEM";
                        labelMainboardOutput.Text = "GIGABYTE B460 HD3";
                    }
                    if (this.comboBoxYesNoFirma.Text == "Да")
                    {
                        labelRAMoutput.Text = "Corsair Vengeance LPX DDR4-3200 " + comboBoxRAM.Text;
                        labelHDDoutput.Text = comboBoxHDD.Text + " Seagate Exos";
                        labelSSDoutput.Text = comboBoxSSD.Text + " Samsung 970 EVO";
                    }
                    else
                    {
                        labelRAMoutput.Text = "Corsair Vengeance LPX DDR4-3200 16 ГБ";
                        labelHDDoutput.Text = "4 ТБ Seagate Exos";
                        labelSSDoutput.Text = "512 ГБ Samsung 970 EVO";
                    }
                    labelGPUoutput.Text = "Gigabyte NVIDIA GeForce GTX 2060 Super";
                    labelCPUcooleroutput.Text = "Xilence M504D";
                    labelPSUoutput.Text = "SeaSonic 1000W";
                    labelKorpusoutput.Text = "Corsair 760T";
                    labelSoundCardoutput.Text = "Asus Essence STX II";
                }
            }

            if (this.comboBoxTypeGraphic.Text == "Видео")
            {
                if (this.comboBoxPriceLevel.Text == "Бюджетная")
                {
                    labelCPUout.Text = "AMD Ryzen 7 2700X";
                    labelMainboardOutput.Text = "MSI X470 Gaming Pro";
                    if (this.comboBoxYesNoFirma.Text == "Да")
                    {
                        labelRAMoutput.Text = "HyperX Fury Red DDR4-2666 " + comboBoxRAM.Text;
                        labelHDDoutput.Text = comboBoxHDD.Text + " Seagate 7200 BarraCuda";
                        labelSSDoutput.Text = comboBoxSSD.Text + " A-Data SU650";
                    }
                    else
                    {
                        labelRAMoutput.Text = "Crucial DDR4 16 ГБ";
                        labelHDDoutput.Text = "1 ТБ Seagate 7200 BarraCuda";
                        labelSSDoutput.Text = "120 ГБ A-Data SU650";
                    }
                    labelGPUoutput.Text = "INNO3D GeForce GTX1060 Compact 6GB";
                    labelCPUcooleroutput.Text = "be quiet! Pure Rock";
                    labelPSUoutput.Text = "Seasonic 620W";
                    labelKorpusoutput.Text = "Fractal Design Meshify C Black TG";
                }
                if (this.comboBoxPriceLevel.Text == "Оптимальная")
                {

                    labelCPUout.Text = "AMD Ryzen 7 3800X";
                    labelMainboardOutput.Text = "MSI X470 Gaming Pro";
                    if (this.comboBoxYesNoFirma.Text == "Да")
                    {
                        labelRAMoutput.Text = "Crucial DDR4 " + comboBoxRAM.Text;
                        labelHDDoutput.Text = comboBoxHDD.Text + " Seagate 7200 BarraCuda";
                        labelSSDoutput.Text = comboBoxSSD.Text + " A-Data SU650";
                    }
                    else
                    {
                        labelRAMoutput.Text = "Crucial DDR4 16 ГБ";
                        labelHDDoutput.Text = "2 ТБ Seagate 7200 BarraCuda";
                        labelSSDoutput.Text = "512 ГБ A-Data SU650";
                    }
                    labelGPUoutput.Text = "PALIT NVIDIA GeForce RTX 2060SUPER DUALi";
                    labelCPUcooleroutput.Text = "be quiet! Pure Rock";
                    labelPSUoutput.Text = "EVGA 850W";
                    labelKorpusoutput.Text = "Fractal Design Meshify C Black TG";
                }
                if (this.comboBoxPriceLevel.Text == "Профессиональная")
                {
                    labelCPUout.Text = "AMD Ryzen 9 3950X";
                    labelMainboardOutput.Text = "MSI X570 Gaming Pro";
                    if (this.comboBoxYesNoFirma.Text == "Да")
                    {
                        labelRAMoutput.Text = "Corsair Vengeance LPX DDR4-3200 " + comboBoxRAM.Text;
                        labelHDDoutput.Text = comboBoxHDD.Text + " Seagate Exos";
                        labelSSDoutput.Text = comboBoxSSD.Text + " Samsung 970 EVO";
                    }
                    else
                    {
                        labelRAMoutput.Text = "Corsair Vengeance LPX DDR4-3200 16 ГБ";
                        labelHDDoutput.Text = "4 ТБ Seagate Exos";
                        labelSSDoutput.Text = "512 ГБ Samsung 970 EVO";
                    }
                    labelGPUoutput.Text = "NVIDIA GeForce RTX 3090 Open air";
                    labelCPUcooleroutput.Text = "be quiet! Pure Rock";
                    labelPSUoutput.Text = "SeaSonic 1000W";
                    labelKorpusoutput.Text = "Fractal Design Meshify C Black TG";
                }
            }

			if (comboBoxSel2.Text == "Ведение стримов")
			{
				if (this.comboBoxPriceLevel.Text == "Бюджетная")
				{
					labelCPUout.Text = "AMD Ryzen 3 3500 BOX";
					labelMainboardOutput.Text = "MSI B450M-A PRO MAX";
					labelRAMoutput.Text = "Patriot Viper Elite [PVE48G266C6KGY] 8 ГБ (2x4ГБ)";
					labelHDDoutput.Text = "2 ТБ Seagate 7200 BarraCuda";
					labelSSDoutput.Text = "250 ГБ A-Data SU650";
					labelGPUoutput.Text = "PowerColor AMD Radeon RX 580 Red Dragon";
					labelCPUcooleroutput.Text = "в комплекте с процессором";
					labelPSUoutput.Text = "Aerocool ECO 500W";
					labelKorpusoutput.Text = "DeepCool Tesseract";
				}
				if (this.comboBoxPriceLevel.Text == "Средний")
				{
					if (this.comboBoxProcessor.Text == "AMD")
					{
						labelCPUout.Text = "AMD Ryzen 5 3600 OEM";
						labelMainboardOutput.Text = "MSI B450M-A PRO MAX";
					}
					else
					{
						labelCPUout.Text = "Intel Core i5-10400 OEM";
						labelMainboardOutput.Text = "ASRock H410M-HDV/M.2";
					}
					if (this.comboBoxYesNoFirma.Text == "Да")
					{
						labelRAMoutput.Text = "AMD Radeon R9 Gamer Series " + comboBoxRAM.Text;
						labelHDDoutput.Text = comboBoxHDD.Text + " Seagate 7200 BarraCuda";
						labelSSDoutput.Text = comboBoxSSD.Text + " A-Data SU650";
					}
					else
					{
						labelRAMoutput.Text = "AMD Radeon R9 Gamer Series 16 ГБ";
						labelHDDoutput.Text = "2 ТБ Seagate 7200 BarraCuda";
						labelSSDoutput.Text = "512 ГБ A-Data SU650";
					}
					labelGPUoutput.Text = "Palit GeForce GTX 1650 Gaming Pro";
					labelCPUcooleroutput.Text = "PCCooler GI-X3B";
					labelPSUoutput.Text = "Aerocool VX PLUS 700W";
					labelKorpusoutput.Text = "Zalman Z3 Plus";
				}
				if (this.comboBoxPriceLevel.Text == "Оптимальная")
				{
					if (this.comboBoxProcessor.Text == "AMD")
					{
						labelCPUout.Text = "AMD Ryzen 7 3700X";
						labelMainboardOutput.Text = "MSI B450-A PRO MAX";
					}
					else
					{
						labelCPUout.Text = "Intel i7-9700K";
						labelMainboardOutput.Text = "GIGABYTE Z390 D";
					}
					if (this.comboBoxYesNoFirma.Text == "Да")
					{
						labelRAMoutput.Text = "AMD Radeon R9 Gamer Series " + comboBoxRAM.Text;
						labelHDDoutput.Text = comboBoxHDD.Text + " Seagate 7200 BarraCuda";
						labelSSDoutput.Text = comboBoxSSD.Text + " A-Data SU650";
					}
					else
					{
						labelRAMoutput.Text = "AMD Radeon R9 Gamer Series 16 ГБ";
						labelHDDoutput.Text = "2 ТБ Seagate 7200 BarraCuda";
						labelSSDoutput.Text = "512 ГБ A-Data SU650";
					}
					labelGPUoutput.Text = "PALIT NVIDIA GeForce RTX 2060SUPER DUAL";
					labelCPUcooleroutput.Text = "DEEPCOOL GAMMAXX 400 V2";
					labelPSUoutput.Text = "Aerocool VX PLUS 700W";
					labelKorpusoutput.Text = "ZALMAN i3 Edge";
				}
				if (this.comboBoxPriceLevel.Text == "Профессиональная")
				{
					if (this.comboBoxProcessor.Text == "AMD")
					{
						labelCPUout.Text = "AMD Ryzen 9 3950X";
						labelMainboardOutput.Text = "ASUS PRIME X570-P";
						labelGPUoutput.Text = "PowerColor AMD Radeon RX 6900 XT Red Devil";
					}
					else
					{
						labelCPUout.Text = "Intel Core i9-9900K OEM";
						labelMainboardOutput.Text = "MSI Z390 MPG GAMING PLUS";
						labelGPUoutput.Text = "MSI GeForce RTX 2080 Ti GAMING X TRIO";
					}
					if (this.comboBoxYesNoFirma.Text == "Да")
					{
						labelRAMoutput.Text = "Kingston HyperX FURY Black " + comboBoxRAM.Text;
						labelHDDoutput.Text = comboBoxHDD.Text + " Seagate Exos";
						labelSSDoutput.Text = comboBoxSSD.Text + " A-Data SU650";
					}
					else
					{
						labelRAMoutput.Text = "Kingston HyperX FURY Black 32 ГБ";
						labelHDDoutput.Text = "4 ТБ Seagate Exos";
						labelSSDoutput.Text = "512 ГБ A-Data SU650";
					}

					labelCPUcooleroutput.Text = "Xilence M504D";
					labelPSUoutput.Text = "Cougar GEX750";
					labelKorpusoutput.Text = "DEEPCOOL MATREXX 50 ADD-RGB 3F";
					labelSoundCardoutput.Text = "Asus Essence STX II";
				}
				if (this.comboBoxPriceLevel.Text == "Сверхпроизводительный")
				{
					if (this.comboBoxYesNoFirma.Text == "Да")
					{
						labelRAMoutput.Text = "Crucial REG ECC " + comboBoxRAM.Text;
						labelHDDoutput.Text = comboBoxHDD.Text + " Seagate 7200 BarraCuda";
						labelSSDoutput.Text = comboBoxSSD.Text + " A-Data SU650";
					}
					else
					{
						labelRAMoutput.Text = "Crucial 128Gb REG ECC (4x32Gb)";
						labelHDDoutput.Text = "5 ТБ Seagate 7200 BarraCuda";
						labelSSDoutput.Text = "512 ГБ A-Data SU650";
					}
					labelCPUout.Text = "Intel Xeon W-2255";
					labelMainboardOutput.Text = "Asus WS C422 SAGE/10G";
					labelGPUoutput.Text = "NVIDIA GeForce RTX 3090 Open air";
					labelCPUcooleroutput.Text = "Noctua NH-U12DX i4 Socket Cooler";
					labelPSUoutput.Text = "Super Flower Leadex Platinum 1600W";
					labelKorpusoutput.Text = "Fractal Design Define XL R2";
				}
			}
			
			if (comboBoxSel2.Text == "Машинное обучение")
			{
				if (this.comboBoxPriceLevel.Text == "Бюджетная")
				{
					if (this.comboBoxProcessor.Text == "AMD")
					{
						labelCPUout.Text = "AMD Ryzen 7 3700X OEM";
						labelMainboardOutput.Text = "GIGABYTE B550M S2H";
					}
					else
					{
						labelCPUout.Text = "Intel Core i7-10700F OEM";
						labelMainboardOutput.Text = "ASRock B460 Pro4";
					}
					if (this.comboBoxYesNoFirma.Text == "Да")
					{
						labelRAMoutput.Text = "G.Skill AEGIS " + comboBoxRAM.Text;
						labelHDDoutput.Text = comboBoxHDD.Text + " Seagate 7200 BarraCuda";
						labelSSDoutput.Text = comboBoxSSD.Text + " A-Data SU650";
					}
					else
					{
						labelRAMoutput.Text = "G.Skill AEGIS 16 ГБ";
						labelHDDoutput.Text = "2 ТБ Seagate 7200 BarraCuda";
						labelSSDoutput.Text = "250 ГБ A-Data SU650";
					}
					labelGPUoutput.Text = "Palit GeForce GTX 1650 Gaming Pro";
					labelCPUcooleroutput.Text = "DEEPCOOL GAMMAXX 400";
					labelPSUoutput.Text = "Deepcool DA 500W";
					labelKorpusoutput.Text = "Zalman Z3 Plus";
				}
				if (this.comboBoxPriceLevel.Text == "Оптимальная")
				{
					if (this.comboBoxProcessor.Text == "AMD")
					{
						labelCPUout.Text = "AMD Ryzen Threadripper 2950X";
						labelMainboardOutput.Text = "ASUS PRIME X399-A";
					}
					else
					{
						labelCPUout.Text = "Intel Core i9-10920X OEM";
						labelMainboardOutput.Text = "ASUS ROG STRIX X299-E GAMING II";
					}
					if (this.comboBoxYesNoFirma.Text == "Да")
					{
						labelRAMoutput.Text = "Kingston HyperX FURY Black " + comboBoxRAM.Text;
						labelHDDoutput.Text = comboBoxHDD.Text + " Seagate 7200 BarraCuda";
						labelSSDoutput.Text = comboBoxSSD.Text + " A-Data SU650";
					}
					else
					{
						labelRAMoutput.Text = "Kingston HyperX FURY Black 64 ГБ";
						labelHDDoutput.Text = "2 ТБ Seagate 7200 BarraCuda";
						labelSSDoutput.Text = "512 ГБ A-Data SU650";
					}
					labelGPUoutput.Text = "MSI GeForce RTX 3070 GAMING X TRIO";
					labelCPUcooleroutput.Text = "Gamer Storm Fryzen";
					labelPSUoutput.Text = "Áëîê ïèòàíèÿ 850W Chieftec (APS-850CB)";
					labelKorpusoutput.Text = "DeepCool MATREXX 55";
				}
				if (this.comboBoxPriceLevel.Text == "Профессиональная")
				{
					if (this.comboBoxProcessor.Text == "AMD")
					{
						labelCPUout.Text = "AMD Ryzen 9 3950X";
						labelMainboardOutput.Text = "ASUS PRIME X570-P";
						labelGPUoutput.Text = "PowerColor AMD Radeon RX 6900 XT Red Devil";
					}
					else
					{
						labelCPUout.Text = "Intel Core i9-9900K OEM";
						labelMainboardOutput.Text = "MSI Z390 MPG GAMING PLUS";
						labelGPUoutput.Text = "MSI GeForce RTX 2080 Ti GAMING X TRIO";
					}
					if (this.comboBoxYesNoFirma.Text == "Да")
					{
						labelRAMoutput.Text = "Kingston HyperX FURY Black " + comboBoxRAM.Text;
						labelHDDoutput.Text = comboBoxHDD.Text + " Seagate Exos";
						labelSSDoutput.Text = comboBoxSSD.Text + " A-Data SU650";
					}
					else
					{
						labelRAMoutput.Text = "Kingston HyperX FURY Black 32 ГБ";
						labelHDDoutput.Text = "4 ТБ Seagate Exos";
						labelSSDoutput.Text = "512 ГБ A-Data SU650";
					}

					labelCPUcooleroutput.Text = "Xilence M504D";
					labelPSUoutput.Text = "Cougar GEX750";
					labelKorpusoutput.Text = "DEEPCOOL MATREXX 50 ADD-RGB 3F";
					labelSoundCardoutput.Text = "Asus Essence STX II";
				}
				if (this.comboBoxPriceLevel.Text == "Сверхпроизводительный")
				{
					if (this.comboBoxYesNoFirma.Text == "Да")
					{
						labelRAMoutput.Text = "G.Skill TRIDENT Z RGB " + comboBoxRAM.Text;
						labelHDDoutput.Text = comboBoxHDD.Text + " Seagate 7200 BarraCuda";
						labelSSDoutput.Text = comboBoxSSD.Text + " A-Data SU650";
					}
					else
					{
						labelRAMoutput.Text = "G.Skill TRIDENT Z RGB [F4-3200C16D-64GTZR] 64 ГБ (4x16ГБ)";
						labelHDDoutput.Text = "2 ТБ Seagate 7200 BarraCuda";
						labelSSDoutput.Text = "512 ГБ A-Data SU650";
					}
					labelCPUout.Text = "AMD Ryzen Threadripper 3970X";
					labelMainboardOutput.Text = "AsRock TRX40 Taichi";
					labelGPUoutput.Text = "Palit GeForce RTX 3090 GamingPro";
					labelCPUcooleroutput.Text = "Be Quiet Dark Rock Pro TR4";
					labelPSUoutput.Text = "CHIEFTEC A-135 1000W";
					labelKorpusoutput.Text = "Cooler Master Cosmos C700M ARGB Curved Tempered Glass";
				}
			}

			if (this.comboBoxSel.Text == "Офисная работа")
			{
				labelCPUout.Text = "AMD A8-9600 OEM";
				labelMainboardOutput.Text = "ASRock A320M-HDV R4.0";
				labelRAMoutput.Text = "AMD Radeon R7 Performance Series 8 ГБ";
				labelGPUoutput.Text = "не требуется";
				labelHDDoutput.Text = "1 ТБ Seagate 7200 BarraCuda";
				labelCPUcooleroutput.Text = "Xilence A250 PWM ";
				labelPSUoutput.Text = "Aerocool VX PLUS 350W ";
				labelKorpusoutput.Text = "DEXP DC-101B черный ";
				//price = 11650;
				if (this.comboBoxSpeed.Text == "Меньше цена")
				{
					labelRAMoutput.Text = "AMD Radeon R7 Performance Series 4 ГБ";
					price = 13550;
				}
				if (this.comboBoxSpeed.Text == "Больше произвадительность")
				{
					labelRAMoutput.Text = "AMD Radeon R7 Performance Series 8 ГБ";
					labelSSDoutput.Text = "120 ГБ  A-Data SU650";
					price = 16750;
				}
				if (this.comboBoxYesNoFirma.Text == "Да")
				{
					labelRAMoutput.Text = "AMD Radeon R7 Performance Series " + comboBoxRAM.Text;
					labelHDDoutput.Text = comboBoxHDD.Text + " Seagate 7200 BarraCuda";
					if (comboBoxOfficeSSD.Text == "Да")
					{
						labelSSDoutput.Text = "120 ГБ A-Data SU650";
						price = 13550;
					}
					else price = 11650;

				}
			}

			if (comboBoxCPUGPU.Text == "INTEL - NVIDIA" || comboBoxYesNoFirma.Text == "Нет" && this.comboBoxSel.Text == "Игры")
			{
				if (comboBoxGamePrice.Text == "20000")
				{
					labelCPUout.Text = "Intel Celeron G5905 OEM";
					labelMainboardOutput.Text = "ASRock H470M-HDV";
					labelKorpusoutput.Text = "DEXP DC-202M";
					labelGPUoutput.Text = "INNO3D GeForce GT 710 Silent LP";
					labelCPUcooleroutput.Text = "CoolerMaster I50";
					labelRAMoutput.Text = "Goodram[GR2666D464L19S/4G] (1x4ГБ)";
					labelHDDoutput.Text = "500 ГБ Seagate BarraCuda";
					labelSSDoutput.Text = "120 ГБ  A-Data SU650";
					labelPSUoutput.Text = "Aerocool VX PLUS 350W ";
					price = 21793;
				}
				if (comboBoxGamePrice.Text == "30000")
				{
					labelCPUout.Text = "Intel Core i3-10100 F OEM";
					labelMainboardOutput.Text = "ASRock H470M-HDV";
					labelKorpusoutput.Text = "DEXP DC-202M ";
					labelGPUoutput.Text = "ASUS GeForce GT 1030 PHOENIX ";
					labelCPUcooleroutput.Text = "ID-Cooling DK-01S";
					labelRAMoutput.Text = "Goodram[GR2666D464L19S/4G] (1x4ГБ)";
					labelHDDoutput.Text = "1 ТБ WD Blue [WD10EZEX]";
					labelSSDoutput.Text = "120 ГБ  A-Data SU650";
					labelPSUoutput.Text = "Aerocool VX PLUS 350W ";
					price = 32293;
				}
				if (comboBoxGamePrice.Text == "48000")
				{
					labelCPUout.Text = "Intel Core i3-10100 F OEM";
					labelMainboardOutput.Text = "ASRock H470M-HDV";
					labelKorpusoutput.Text = "DEXP DC-202M ";
					labelGPUoutput.Text = "KFA2 GeForce GTX 1050 Ti 1-Click OC";
					labelCPUcooleroutput.Text = "ID-Cooling DK-01S";
					labelRAMoutput.Text = "AMD Radeon R7 Performance Series (2x8ГБ) ";
					labelHDDoutput.Text = "500 ГБ WD Blue [WD5000AZLX]";
					labelSSDoutput.Text = "120 ГБ  A-Data SU650";
					labelPSUoutput.Text = "Aerocool VX PLUS 350W ";
					price = 45992;
				}
				if (comboBoxGamePrice.Text == "60000")
				{
					labelCPUout.Text = "Intel Core i5-10400 F OEM";
					labelMainboardOutput.Text = "ASRock H470M-HDV";
					labelKorpusoutput.Text = "DEXP DC-202M ";
					labelGPUoutput.Text = "MSI GeForce GTX 1650 D6 GAMING X";
					labelCPUcooleroutput.Text = "ID-Cooling DK-01S";
					labelRAMoutput.Text = "AMD Radeon R7 Performance Series (2x8ГБ) ";
					labelHDDoutput.Text = "1 ТБ WD Blue [WD10EZEX]";
					labelSSDoutput.Text = "120 ГБ  A-Data SU650";
					labelPSUoutput.Text = "Aerocool VX PLUS 400W ";
					price = 58190;
				}
				if (comboBoxGamePrice.Text == "80000")
				{
					labelCPUout.Text = "Intel Core i5-10400 OEM";
					labelMainboardOutput.Text = "ASRock H470M-HDV";
					labelKorpusoutput.Text = "DEXP DC-202M ";
					labelGPUoutput.Text = "PALIT GeForce GTX 1660 SUPER Gaming Pro OC ";
					labelCPUcooleroutput.Text = "CoolerMaster I50";
					labelRAMoutput.Text = "AMD Radeon R7 Performance Series (2x8ГБ) ";
					labelHDDoutput.Text = "500 ГБ Seagate BarraCuda ";
					labelSSDoutput.Text = "120 ГБ  A-Data SU650";
					labelPSUoutput.Text = "Dexp DPS-450 ";
					price = 83741;
				}
				if (comboBoxGamePrice.Text == "100000")
				{
					labelCPUout.Text = "Intel Core i7-10700 OEM";
					labelMainboardOutput.Text = "MSI B460M PRO-VDH";
					labelKorpusoutput.Text = "DEXP DC-202M ";
					labelGPUoutput.Text = "MSI GeForce RTX 3070 VENTUS 2X OC Кулер для процессора: Xilence I404T";
					labelCPUcooleroutput.Text = "CoolerMaster I50";
					labelRAMoutput.Text = "AMD Radeon R7 Performance Series (4x8ГБ) ";
					labelHDDoutput.Text = "2 ТБ Toshiba P300";
					labelSSDoutput.Text = "120 ГБ  A-Data SU650";
					labelPSUoutput.Text = "Aerocool VX PLUS 700W";
					price = 185639;
				}
			}

			if (comboBoxCPUGPU.Text == "INTEL - AMD")
			{
				if (comboBoxGamePrice.Text == "20000")
				{
					labelCPUout.Text = "Intel Celeron G5905 OEM";
					labelMainboardOutput.Text = "ASRock H470M-HDV";
					labelKorpusoutput.Text = "DEXP DC-202M";
					labelGPUoutput.Text = "ASUS AMD Radeon 470 Phoenix";
					labelCPUcooleroutput.Text = "CoolerMaster I50";
					labelRAMoutput.Text = "Goodram[GR2666D464L19S/4G] (1x4ГБ)";
					labelHDDoutput.Text = "500 ГБ Seagate BarraCuda";
					labelSSDoutput.Text = "120 ГБ  A-Data SU650";
					labelPSUoutput.Text = "Aerocool VX PLUS 350W ";
					price = 25293;
				}
				if (comboBoxGamePrice.Text == "30000")
				{
					labelCPUout.Text = "Intel Pentium Gold G6500 OEM";
					labelMainboardOutput.Text = "ASRock H470M-HDV";
					labelKorpusoutput.Text = "DEXP DC-202M ";
					labelGPUoutput.Text = "ASUS GeForce GT 1030 PHOENIX ";
					labelCPUcooleroutput.Text = "CoolerMaster I50";
					labelRAMoutput.Text = "Goodram[GR2666D464L19S/4G] (2x4ГБ)";
					labelHDDoutput.Text = "500 ГБ Seagate BarraCuda";
					labelSSDoutput.Text = "120 ГБ  A-Data SU650";
					labelPSUoutput.Text = "Aerocool VX PLUS 350W ";
					price = 34443;
				}
				if (comboBoxGamePrice.Text == "48000")
				{
					labelCPUout.Text = "Intel Core i5-10600 OEM";
					labelMainboardOutput.Text = "ASRock H470M-HDV";
					labelKorpusoutput.Text = "DEXP DC-201M ";
					labelGPUoutput.Text = "MSI AMD Radeon RX 550 AERO ITX OC ";
					labelCPUcooleroutput.Text = "CoolerMaster I50";
					labelRAMoutput.Text = "AMD Radeon R7 Performance Series (2x8ГБ) ";
					labelHDDoutput.Text = "500 ГБ WD Blue [WD5000AZLX]";
					labelSSDoutput.Text = "120 ГБ  A-Data SU650";
					labelPSUoutput.Text = "DEXP DPS-450 ";
					price = 52041;
				}
				if (comboBoxGamePrice.Text == "60000")
				{
					labelCPUout.Text = "Intel Core i5-10600 OEM";
					labelMainboardOutput.Text = "ASRock H470M-HDV";
					labelKorpusoutput.Text = "DEXP DC-202M ";
					labelGPUoutput.Text = "MSI AMD Radeon RX 590 AERO ITX OC ";
					labelCPUcooleroutput.Text = "CoolerMaster I50";
					labelRAMoutput.Text = "AMD Radeon R7 Performance Series (2x8ГБ) ";
					labelHDDoutput.Text = "500 ГБ Seagate BarraCuda";
					labelSSDoutput.Text = "120 ГБ  A-Data SU650";
					labelPSUoutput.Text = "Aerocool VX PLUS 400W ";
					price = 62763;
				}
				if (comboBoxGamePrice.Text == "80000")
				{
					labelCPUout.Text = "Intel Core i5-10600 OEM";
					labelMainboardOutput.Text = "ASRock H470M-HDV";
					labelKorpusoutput.Text = "DEXP DC-202M ";
					labelGPUoutput.Text = "MSI AMD Radeon RX 5500 XT GAMING X";
					labelCPUcooleroutput.Text = "CoolerMaster I50";
					labelRAMoutput.Text = "AMD Radeon R7 Performance Series (2x8ГБ) ";
					labelHDDoutput.Text = "500 ГБ Seagate BarraCuda";
					labelSSDoutput.Text = "120 ГБ  A-Data SU650";
					labelPSUoutput.Text = "Aerocool VX PLUS 400W ";
					price = 89741;
				}
				if (comboBoxGamePrice.Text == "100000")
				{
					labelCPUout.Text = "Intel Core i7-10700 OEM";
					labelMainboardOutput.Text = "MSI B460M PRO-VDH";
					labelKorpusoutput.Text = "DEXP DC-201M ";
					labelGPUoutput.Text = "MSI AMD Radeon RX 5500 XT GAMING X";
					labelCPUcooleroutput.Text = "CoolerMaster I50";
					labelRAMoutput.Text = "AMD Radeon R7 Performance Series (2x8ГБ) ";
					labelHDDoutput.Text = "500 ГБ Seagate BarraCuda";
					labelSSDoutput.Text = "120 ГБ  A-Data SU650";
					labelPSUoutput.Text = "Aerocool VX PLUS 400W ";
					price = 105239;
				}
			}

			if (comboBoxCPUGPU.Text == "AMD - AMD" || comboBoxGPUGame.Text == "AMD")
			{
				if (comboBoxGamePrice.Text == "20000")
				{
					labelCPUout.Text = "AMD Athlon X4 840 OEM";
					labelMainboardOutput.Text = "Biostar A68MHE";
					labelKorpusoutput.Text = "DEXP DC-201M ";
					labelGPUoutput.Text = "ASUS AMD Radeon 550 Phoenix [PH-550-2G] ";
					labelCPUcooleroutput.Text = "ID-Cooling DK-01T ";
					labelRAMoutput.Text = "AMD Radeon R3 Value Series [R334G1339U1S-U] (2x4 ГБ)";
					labelHDDoutput.Text = "500 ГБ Seagate BarraCuda";
					labelSSDoutput.Text = "120 ГБ  A-Data SU650";
					labelPSUoutput.Text = "Aerocool VX PLUS 350W ";
					price = 26941;
				}
				if (comboBoxGamePrice.Text == "30000")
				{
					labelCPUout.Text = "AMD Ryzen 3 3100 OEM ";
					labelMainboardOutput.Text = "MSI A320M PRO-E";
					labelKorpusoutput.Text = "DEXP DC-202M ";
					labelGPUoutput.Text = "MSI AMD Radeon RX 550 AERO ITX OC";
					labelCPUcooleroutput.Text = "AeroCool Verkho A-3P";
					labelRAMoutput.Text = "Kingston ValueRAM [KVR26N19S6/4] (2x4 ГБ)";
					labelHDDoutput.Text = "500 ГБ Seagate BarraCuda";
					labelSSDoutput.Text = "120 ГБ  A-Data SU650";
					labelPSUoutput.Text = "Aerocool VX PLUS 350W ";
					price = 36392;
				}
				if (comboBoxGamePrice.Text == "48000")
				{
					labelCPUout.Text = "AMD Ryzen 7 PRO 2700 OEM";
					labelMainboardOutput.Text = "ASRock A320M PRO4-F";
					labelKorpusoutput.Text = "DEXP DC-201M ";
					labelGPUoutput.Text = "MSI AMD Radeon RX 550 AERO ITX OC ";
					labelCPUcooleroutput.Text = "AeroCool Verkho A-3P ";
					labelRAMoutput.Text = "AMD Radeon R7 Performance Series (2x8ГБ) ";
					labelHDDoutput.Text = "500 ГБ WD Blue [WD5000AZLX]";
					labelSSDoutput.Text = "240 ГБ  A-Data SU650";
					labelPSUoutput.Text = "Aerocool VX PLUS 400W ";
					price = 46792;
				}
				if (comboBoxGamePrice.Text == "60000")
				{
					labelCPUout.Text = "AMD Ryzen 5 3600x OEM";
					labelMainboardOutput.Text = "GIGABYTE B450M H";
					labelKorpusoutput.Text = "DEXP DC-202M ";
					labelGPUoutput.Text = "MSI AMD Radeon RX 590 AERO ITX OC ";
					labelCPUcooleroutput.Text = "CoolerMaster I50";
					labelRAMoutput.Text = "AMD Radeon R7 Performance Series (2x8ГБ) ";
					labelHDDoutput.Text = "500 ГБ WD Blue";
					labelSSDoutput.Text = "240 ГБ A-Data SU650 ";
					labelPSUoutput.Text = "Zalman Z3 Plus ";
					price = 64547;
				}
				if (comboBoxGamePrice.Text == "80000")
				{
					labelCPUout.Text = "AMD Ryzen 7 PRO 2700 OEM ";
					labelMainboardOutput.Text = "GIGABYTE B450M H";
					labelKorpusoutput.Text = "DEXP DC-202M ";
					labelGPUoutput.Text = "MSI AMD Radeon RX 5500 XT GAMING X";
					labelCPUcooleroutput.Text = "CoolerMaster I50";
					labelRAMoutput.Text = "AMD Radeon R7 Performance Series (2x8ГБ) ";
					labelHDDoutput.Text = "500 ГБ Seagate BarraCuda";
					labelSSDoutput.Text = "120 ГБ  A-Data SU650";
					labelPSUoutput.Text = "DEXP DPS-450 ";
					price = 86792;
				}
				if (comboBoxGamePrice.Text == "100000")
				{
					labelCPUout.Text = "AMD Ryzen 9 3900 OEM";
					labelMainboardOutput.Text = "ASRock A320M PRO4-F";
					labelKorpusoutput.Text = "DEXP DC-201M ";
					labelGPUoutput.Text = "MSI AMD Radeon RX 5500 XT GAMING X";
					labelCPUcooleroutput.Text = "AeroCool Verkho A-3P ";
					labelRAMoutput.Text = "AMD Radeon R7 Performance Series (2x8ГБ) ";
					labelHDDoutput.Text = "500 ГБ Seagate BarraCuda";
					labelSSDoutput.Text = "120 ГБ  A-Data SU650";
					labelPSUoutput.Text = "DEXP DPS-450";
					price = 113488;
				}
			}

			if (comboBoxCPUGPU.Text == "AMD - NVIDIA" || comboBoxGPUGame.Text == "NVIDIA" || comboBoxGameWork.Text == "Да")
			{
				if (comboBoxGamePrice.Text == "20000")
				{
					labelCPUout.Text = "AMD A8-9600 OEM ";
					labelMainboardOutput.Text = "MSI A320M PRO-E";
					labelKorpusoutput.Text = "DEXP DC-201M ";
					labelGPUoutput.Text = "INNO3D GeForce GT 710 Silent LP  ";
					labelCPUcooleroutput.Text = "AeroCool Verkho A-3P  ";
					labelRAMoutput.Text = "Goodram [GR2666D464L19S/4G] (1x4 ГБ)";
					labelHDDoutput.Text = "500 ГБ Seagate BarraCuda";
					labelSSDoutput.Text = "120 ГБ  A-Data SU650";
					labelPSUoutput.Text = "Aerocool VX PLUS 350W ";
					price = 21242;
				}
				if (comboBoxGamePrice.Text == "30000")
				{
					labelCPUout.Text = "AMD Athlon 200GE OEM ";
					labelMainboardOutput.Text = "MSI A320M PRO-E";
					labelKorpusoutput.Text = "DEXP DC-202M ";
					labelGPUoutput.Text = "Asus GeForce GT 1030 PHOENIX [PH-GT1030-O2G]";
					labelCPUcooleroutput.Text = "AeroCool Verkho A-3P";
					labelRAMoutput.Text = "Goodram [GR2666D464L19S/4G] (2x4 ГБ)";
					labelHDDoutput.Text = "500 ГБ Seagate BarraCuda";
					labelSSDoutput.Text = "120 ГБ  A-Data SU650";
					labelPSUoutput.Text = "Aerocool VX PLUS 350W ";
					price = 29143;
				}
				if (comboBoxGamePrice.Text == "48000")
				{
					labelCPUout.Text = "AMD Ryzen 5 1600 OEM ";
					labelMainboardOutput.Text = "MSI A320M PRO-E";
					labelKorpusoutput.Text = "DEXP DC-201M ";
					labelGPUoutput.Text = "MSI GeForce GTX 1650 D6 GAMING X ";
					labelCPUcooleroutput.Text = "AeroCool Verkho A-3P ";
					labelRAMoutput.Text = "AMD Radeon R7 Performance Series (2x8ГБ) ";
					labelHDDoutput.Text = "500 ГБ Seagate BarraCuda";
					labelSSDoutput.Text = "120 ГБ  A-Data SU650";
					labelPSUoutput.Text = "Aerocool VX PLUS 400W ";
					price = 54290;
				}
				if (comboBoxGamePrice.Text == "60000")
				{
					labelCPUout.Text = "AMD Ryzen 7 PRO 3700 OEM";
					labelMainboardOutput.Text = "MSI A320M PRO-E";
					labelKorpusoutput.Text = "DEXP DC-202M ";
					labelGPUoutput.Text = "MSI GeForce GTX 1650 D6 GAMING X";
					labelCPUcooleroutput.Text = "CoolerMaster I50";
					labelRAMoutput.Text = "AMD Radeon R7 Performance Series (2x8ГБ) ";
					labelHDDoutput.Text = "500 ГБ Seagate BarraCuda";
					labelSSDoutput.Text = "120 ГБ A-Data SU650 ";
					labelPSUoutput.Text = "Aerocool VX PLUS 400W  ";
					price = 67990;
				}
				if (comboBoxGamePrice.Text == "80000")
				{
					labelCPUout.Text = "AMD Ryzen 5 3600x OEM ";
					labelMainboardOutput.Text = "GIGABYTE B450M H";
					labelKorpusoutput.Text = "DEXP DC-201M ";
					labelGPUoutput.Text = "GIGABYTE GeForce GTX 1660 SUPER OC ";
					labelCPUcooleroutput.Text = "AeroCool Verkho A-3P ";
					labelRAMoutput.Text = "AMD Radeon R7 Performance Series (2x8ГБ) ";
					labelHDDoutput.Text = "500 ГБ Seagate BarraCuda";
					labelSSDoutput.Text = "120 ГБ  A-Data SU650";
					labelPSUoutput.Text = "DEXP DPS-450 ";
					price = 87288;
				}
				if (comboBoxGamePrice.Text == "100000")
				{
					labelCPUout.Text = "AMD Ryzen 9 3900 OEM";
					labelMainboardOutput.Text = "ASRock A320M PRO4-F";
					labelKorpusoutput.Text = "DEXP DC-201M ";
					labelGPUoutput.Text = "MSI GeForce RTX 3070 GAMING X TRIO  ";
					labelCPUcooleroutput.Text = "AeroCool Verkho A-3P ";
					labelRAMoutput.Text = "AMD Radeon R7 Performance Series (4x8ГБ) ";
					labelHDDoutput.Text = "500 ГБ Seagate BarraCuda";
					labelSSDoutput.Text = "120 ГБ  A-Data SU650";
					labelPSUoutput.Text = "Aerocool VX PLUS 650W ";
					price = 194488;
				}
			}

			int ramprice = 0, hddprice = 0, ssdprice = 0;

			if (comboBoxRAM.Text == "8 ГБ") ramprice = 3000;
			if (comboBoxRAM.Text == "16 ГБ") ramprice = 5500;
			if (comboBoxRAM.Text == "32 ГБ") ramprice = 7500;
			if (comboBoxRAM.Text == "48 ГБ") ramprice = 7500;
			if (comboBoxRAM.Text == "128 ГБ") ramprice = 7500;

			if (comboBoxHDD.Text == "500ГБ") hddprice = 2900;
			if (comboBoxHDD.Text == "1ТБ") hddprice = 3200;
			if (comboBoxHDD.Text == "2ТБ") hddprice = 4700;
			if (comboBoxHDD.Text == "4ТБ") hddprice = 13000;
			if (comboBoxHDD.Text == "6ТБ") hddprice = 19000;
			if (comboBoxHDD.Text == "8ТБ") hddprice = 25000;
			if (comboBoxHDD.Text == "10ТБ") hddprice = 32000;

			if (comboBoxSSD.Text == "120ГБ") ssdprice = 1900;
			if (comboBoxSSD.Text == "250ГБ") ssdprice = 3500;
			if (comboBoxSSD.Text == "500ГБ") ssdprice = 8000;
			if (comboBoxSSD.Text == "1ТБ") ssdprice = 14000;
			if (comboBoxSSD.Text == "2ТБ") ssdprice = 25000;

			if (this.comboBoxPriceLevel.Text == "Бюджетная") price = 37000;
			if (this.comboBoxPriceLevel.Text == "Средний") price = 68000;
			if (this.comboBoxPriceLevel.Text == "Оптимальная") price = 130000;
			if (this.comboBoxPriceLevel.Text == "Профессиональная") price = 190000;
			if (this.comboBoxPriceLevel.Text == "Сверхпроизводительный") price = 325000;

			if (this.comboBoxOfficeProgram.Text == "Да (+6000р)") price += 6000;
			if (this.comboBoxWindow.Text == "Да (+10000р)") price += 10000;

			price += ramprice + hddprice + ssdprice;
			labelSumoutput.Text = price.ToString();
		}

        private void comboBoxSel_SelectedIndexChanged(object sender, EventArgs e)
        {
			if (comboBoxSel.Text == "Специализированная работа")
			{
				labelSel2.Visible = true;
				comboBoxSel2.Visible = true;
				labelGamePrice.Visible = false;
				labelGameWork.Visible = false;
				comboBoxGamePrice.Visible = false;
				comboBoxGameWork.Visible = false;
				labelWindow.Visible = false;
				comboBoxWindow.Visible = false;
				labelOfficeProgram.Visible = false;
				comboBoxOfficeProgram.Visible = false;
			}

			else if (comboBoxSel.Text == "Офисная работа")
			{
				labelGamePrice.Visible = false;
				labelGameWork.Visible = false;
				comboBoxGamePrice.Visible = false;
				comboBoxGameWork.Visible = false;
				labelSel2.Visible = false;
				comboBoxSel2.Visible = false;
				labelWindow.Visible = true;
				comboBoxWindow.Visible = true;
				labelOfficeProgram.Visible = true;
				comboBoxOfficeProgram.Visible = true;
			}

			else if (comboBoxSel.Text == "Игры")
			{
				labelWindow.Visible = false;
				comboBoxWindow.Visible = false;
				labelOfficeProgram.Visible = false;
				comboBoxOfficeProgram.Visible = false;
				labelSel2.Visible = false;
				comboBoxSel2.Visible = false;
				labelGamePrice.Visible = true;
				labelGameWork.Visible = true;
				comboBoxGamePrice.Visible = true;
				comboBoxGameWork.Visible = true;
			}
		}

        private void comboBoxSel2_SelectedIndexChanged(object sender, EventArgs e)
        {
			if (comboBoxSel2.Text == "Работа с графикой")
			{
				labelTypeGraphic.Visible = true;
				comboBoxTypeGraphic.Visible = true;
				labelPriceLevel.Visible = false;
				comboBoxPriceLevel.Visible = false;
			}
			else
			{
				labelTypeGraphic.Visible = false;
				comboBoxTypeGraphic.Visible = false;
				labelPriceLevel.Visible = true;
				comboBoxPriceLevel.Visible = true;
			}
			if (comboBoxSel2.Text == "Ведение стримов" || comboBoxSel2.Text == "Машинное обучение")
				comboBoxPriceLevel.Items.Add("Сверхпроизводительный");
			if (comboBoxSel2.Text == "Ведение стримов")
				comboBoxPriceLevel.Items.Add("Cредний");

			if (comboBoxSel2.Text == "Работа с музыкой")
			{
				labelSoundCard.Visible = true;
				labelSoundCardoutput.Visible = true;
			}
			else
            {
				labelSoundCard.Visible = false;
				labelSoundCardoutput.Visible = false;
			}
		}

        private void buttonReset_Click(object sender, EventArgs e)
        {
			this.Controls.Clear();
			this.InitializeComponent();
		}

        private void comboBoxTypeGraphic_SelectedIndexChanged(object sender, EventArgs e)
        {
			if (comboBoxTypeGraphic.Text == "3D - Объекта")
			{
				labelGrapgicLevel.Visible = true;
				comboBoxGraphicLevel.Visible = true;
			}
			if (comboBoxTypeGraphic.Text == "Видео")
			{
				labelPriceLevel.Visible = true;
				comboBoxPriceLevel.Visible = true;
			}
			if (comboBoxTypeGraphic.Text != "3D - Объекта")
			{
				labelGrapgicLevel.Visible = false;
				comboBoxGraphicLevel.Visible = false;
			}
			if (comboBoxTypeGraphic.Text != "Видео")
			{
				labelPriceLevel.Visible = false;
				comboBoxPriceLevel.Visible = false;
			}
		}

        private void comboBoxYesNoFirma_SelectedIndexChanged(object sender, EventArgs e)
        {
			if (comboBoxYesNoFirma.Text == "Да" && comboBoxSel.Text != "Офисная работа" && comboBoxSel.Text != "Игры")
			{
				if (comboBoxPriceLevel.Text != "Сверхпроизводительный" || comboBoxPriceLevel.Text == "Профессиональная")
				{
					labelProcessor.Visible = true;
					comboBoxProcessor.Visible = true;
				}
				labelRAM.Visible = true;
				comboBoxRAM.Visible = true;
				labelHDD.Visible = true;
				comboBoxHDD.Visible = true;
				labelSSD.Visible = true;
				comboBoxSSD.Visible = true;
			}
			if (comboBoxSel.Text == "Офисная работа")
			{
				labelHDD.Visible = true;
				comboBoxHDD.Visible = true;
			}
			if (comboBoxSel.Text == "Офисная работа" && comboBoxYesNoFirma.Text == "Нет")
			{
				comboBoxSpeed.Visible = true;
				labelSpeed.Visible = true;
			}
			if (comboBoxSel.Text == "Офисная работа" && comboBoxYesNoFirma.Text == "Да")
			{
				comboBoxSpeed.Visible = false;
				labelSpeed.Visible = false;
				labelRAM.Visible = true;
				comboBoxRAM.Visible = true;
				comboBoxRAM.Items.Clear();
				comboBoxRAM.Items.Add("4 ГБ");
				comboBoxRAM.Items.Add("8 ГБ");
				labelOfficeSSD.Visible = true;
				comboBoxOfficeSSD.Visible = true;
			}

			if (comboBoxGameWork.Text == "Да")
			{
				if (comboBoxYesNoFirma.Text == "Да")
				{
					labelGPUGame.Visible = true;
					comboBoxGPUGame.Visible = true;
				}
				comboBoxGameWork.Enabled = false;
			}
			if (comboBoxGameWork.Text == "Нет")
			{
				if (comboBoxYesNoFirma.Text == "Да")
				{
					labelCPUGPU.Visible = true;
					comboBoxCPUGPU.Visible = true;
				}
				comboBoxGameWork.Enabled = false;
			}
			if (comboBoxYesNoFirma.Text == "Нет" && comboBoxSel.Text != "Офисная работа")
			{
				labelRecommend.Visible = true;
				buttonRecommend.Visible = true;
			}
			comboBoxYesNoFirma.Enabled = false;

		}

		private void comboBoxPriceLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
			comboBoxPriceLevel.Enabled = false;
		}

        private void comboBoxSSD_SelectedIndexChanged(object sender, EventArgs e)
        {
			buttonRecommend.Visible = true;
			labelRecommend.Visible = true;
		}

        private void comboBoxGPUGame_SelectedIndexChanged(object sender, EventArgs e)
        {
			buttonRecommend.Visible = true;
			labelRecommend.Visible = true;
		}

        private void comboBoxOfficeSSD_SelectedIndexChanged(object sender, EventArgs e)
        {
			labelRecommend.Visible = true;
			buttonRecommend.Visible = true;
		}

        private void comboBoxHDD_SelectedIndexChanged(object sender, EventArgs e)
        {
			buttonRecommend.Visible = true;
			labelRecommend.Visible = true;
			comboBoxHDD.Enabled = true;
		}

        private void comboBoxCPUGPU_SelectedIndexChanged(object sender, EventArgs e)
        {
			buttonRecommend.Visible = true;
			labelRecommend.Visible = true;
			comboBoxCPUGPU.Enabled = false;
		}
    }
}