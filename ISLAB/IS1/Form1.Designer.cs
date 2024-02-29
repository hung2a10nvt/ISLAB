
namespace IS1
{
    partial class MyForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelSel = new System.Windows.Forms.Label();
            this.comboBoxSel = new System.Windows.Forms.ComboBox();
            this.labelSel2 = new System.Windows.Forms.Label();
            this.buttonRecommend = new System.Windows.Forms.Button();
            this.comboBoxSel2 = new System.Windows.Forms.ComboBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelTypeGraphic = new System.Windows.Forms.Label();
            this.comboBoxTypeGraphic = new System.Windows.Forms.ComboBox();
            this.labelGrapgicLevel = new System.Windows.Forms.Label();
            this.comboBoxGraphicLevel = new System.Windows.Forms.ComboBox();
            this.labelYesNoFirma = new System.Windows.Forms.Label();
            this.comboBoxYesNoFirma = new System.Windows.Forms.ComboBox();
            this.labelProcessor = new System.Windows.Forms.Label();
            this.comboBoxProcessor = new System.Windows.Forms.ComboBox();
            this.labelHDD = new System.Windows.Forms.Label();
            this.labelSSD = new System.Windows.Forms.Label();
            this.comboBoxHDD = new System.Windows.Forms.ComboBox();
            this.comboBoxSSD = new System.Windows.Forms.ComboBox();
            this.labelRAM = new System.Windows.Forms.Label();
            this.comboBoxRAM = new System.Windows.Forms.ComboBox();
            this.labelCPU = new System.Windows.Forms.Label();
            this.labelCPUout = new System.Windows.Forms.Label();
            this.labelMainBoard = new System.Windows.Forms.Label();
            this.labelGPU = new System.Windows.Forms.Label();
            this.labelRAMout = new System.Windows.Forms.Label();
            this.labelHDDout = new System.Windows.Forms.Label();
            this.labelSSDout = new System.Windows.Forms.Label();
            this.labelPSU = new System.Windows.Forms.Label();
            this.labelCPUcooler = new System.Windows.Forms.Label();
            this.labelMainboardOutput = new System.Windows.Forms.Label();
            this.labelGPUoutput = new System.Windows.Forms.Label();
            this.labelRAMoutput = new System.Windows.Forms.Label();
            this.labelHDDoutput = new System.Windows.Forms.Label();
            this.labelSSDoutput = new System.Windows.Forms.Label();
            this.labelPSUoutput = new System.Windows.Forms.Label();
            this.labelCPUcooleroutput = new System.Windows.Forms.Label();
            this.labelPriceLevel = new System.Windows.Forms.Label();
            this.comboBoxPriceLevel = new System.Windows.Forms.ComboBox();
            this.labelSoundCard = new System.Windows.Forms.Label();
            this.labelSoundCardoutput = new System.Windows.Forms.Label();
            this.labelOfficeProgram = new System.Windows.Forms.Label();
            this.comboBoxOfficeProgram = new System.Windows.Forms.ComboBox();
            this.labelWindow = new System.Windows.Forms.Label();
            this.comboBoxWindow = new System.Windows.Forms.ComboBox();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.comboBoxSpeed = new System.Windows.Forms.ComboBox();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelSumoutput = new System.Windows.Forms.Label();
            this.labelOfficeSSD = new System.Windows.Forms.Label();
            this.comboBoxOfficeSSD = new System.Windows.Forms.ComboBox();
            this.labelGamePrice = new System.Windows.Forms.Label();
            this.comboBoxGamePrice = new System.Windows.Forms.ComboBox();
            this.labelGameWork = new System.Windows.Forms.Label();
            this.comboBoxGameWork = new System.Windows.Forms.ComboBox();
            this.labelCPUGPU = new System.Windows.Forms.Label();
            this.comboBoxCPUGPU = new System.Windows.Forms.ComboBox();
            this.labelGPUGame = new System.Windows.Forms.Label();
            this.comboBoxGPUGame = new System.Windows.Forms.ComboBox();
            this.labelRecommend = new System.Windows.Forms.Label();
            this.labelKorpus = new System.Windows.Forms.Label();
            this.labelKorpusoutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.AutoSize = true;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.Location = new System.Drawing.Point(1182, 467);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(103, 31);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelSel
            // 
            this.labelSel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSel.Location = new System.Drawing.Point(22, 20);
            this.labelSel.Name = "labelSel";
            this.labelSel.Size = new System.Drawing.Size(493, 20);
            this.labelSel.TabIndex = 1;
            this.labelSel.Text = "Для какого рода деятельности подбирается конфигурация ПК?";
            // 
            // comboBoxSel
            // 
            this.comboBoxSel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSel.FormattingEnabled = true;
            this.comboBoxSel.Items.AddRange(new object[] {
            "Специализированная работа",
            "Офисная работа",
            "Игры"});
            this.comboBoxSel.Location = new System.Drawing.Point(46, 44);
            this.comboBoxSel.Name = "comboBoxSel";
            this.comboBoxSel.Size = new System.Drawing.Size(288, 25);
            this.comboBoxSel.TabIndex = 7;
            this.comboBoxSel.SelectedIndexChanged += new System.EventHandler(this.comboBoxSel_SelectedIndexChanged);
            // 
            // labelSel2
            // 
            this.labelSel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSel2.Location = new System.Drawing.Point(20, 70);
            this.labelSel2.Name = "labelSel2";
            this.labelSel2.Size = new System.Drawing.Size(324, 20);
            this.labelSel2.TabIndex = 12;
            this.labelSel2.Text = "Какой работой Вы планируете заниматься?\r\n";
            this.labelSel2.Visible = false;
            // 
            // buttonRecommend
            // 
            this.buttonRecommend.AutoSize = true;
            this.buttonRecommend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRecommend.Location = new System.Drawing.Point(555, 383);
            this.buttonRecommend.Name = "buttonRecommend";
            this.buttonRecommend.Size = new System.Drawing.Size(126, 31);
            this.buttonRecommend.TabIndex = 0;
            this.buttonRecommend.Text = "Рекомендация";
            this.buttonRecommend.UseVisualStyleBackColor = true;
            this.buttonRecommend.Visible = false;
            this.buttonRecommend.Click += new System.EventHandler(this.buttonRecommend_Click);
            // 
            // comboBoxSel2
            // 
            this.comboBoxSel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSel2.FormattingEnabled = true;
            this.comboBoxSel2.Items.AddRange(new object[] {
            "Машинное обучение",
            "Работа с графикой",
            "Работа с музыкой",
            "Ведение стримов"});
            this.comboBoxSel2.Location = new System.Drawing.Point(361, 70);
            this.comboBoxSel2.Name = "comboBoxSel2";
            this.comboBoxSel2.Size = new System.Drawing.Size(169, 25);
            this.comboBoxSel2.TabIndex = 10;
            this.comboBoxSel2.Visible = false;
            this.comboBoxSel2.SelectedIndexChanged += new System.EventHandler(this.comboBoxSel2_SelectedIndexChanged);
            // 
            // buttonReset
            // 
            this.buttonReset.AutoSize = true;
            this.buttonReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonReset.Location = new System.Drawing.Point(20, 438);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(96, 39);
            this.buttonReset.TabIndex = 17;
            this.buttonReset.Text = "Сбросить";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelTypeGraphic
            // 
            this.labelTypeGraphic.AutoSize = true;
            this.labelTypeGraphic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTypeGraphic.Location = new System.Drawing.Point(20, 99);
            this.labelTypeGraphic.Name = "labelTypeGraphic";
            this.labelTypeGraphic.Size = new System.Drawing.Size(204, 21);
            this.labelTypeGraphic.TabIndex = 21;
            this.labelTypeGraphic.Text = "Тип графического объекта:\r\n";
            this.labelTypeGraphic.Visible = false;
            // 
            // comboBoxTypeGraphic
            // 
            this.comboBoxTypeGraphic.FormattingEnabled = true;
            this.comboBoxTypeGraphic.Items.AddRange(new object[] {
            "Фотография",
            "3D - Объекта",
            "Видео"});
            this.comboBoxTypeGraphic.Location = new System.Drawing.Point(242, 99);
            this.comboBoxTypeGraphic.Name = "comboBoxTypeGraphic";
            this.comboBoxTypeGraphic.Size = new System.Drawing.Size(153, 23);
            this.comboBoxTypeGraphic.TabIndex = 22;
            this.comboBoxTypeGraphic.Visible = false;
            this.comboBoxTypeGraphic.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeGraphic_SelectedIndexChanged);
            // 
            // labelGrapgicLevel
            // 
            this.labelGrapgicLevel.AutoSize = true;
            this.labelGrapgicLevel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGrapgicLevel.Location = new System.Drawing.Point(20, 130);
            this.labelGrapgicLevel.Name = "labelGrapgicLevel";
            this.labelGrapgicLevel.Size = new System.Drawing.Size(580, 21);
            this.labelGrapgicLevel.TabIndex = 23;
            this.labelGrapgicLevel.Text = "На каком уровне Вы планируете организовывать свою рабочую деятельность?";
            this.labelGrapgicLevel.Visible = false;
            // 
            // comboBoxGraphicLevel
            // 
            this.comboBoxGraphicLevel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxGraphicLevel.FormattingEnabled = true;
            this.comboBoxGraphicLevel.Items.AddRange(new object[] {
            "Начальнай-средний",
            "Профессиональный",
            "Профессиональный с учётом работы с тяжёлыми обектами"});
            this.comboBoxGraphicLevel.Location = new System.Drawing.Point(46, 153);
            this.comboBoxGraphicLevel.Name = "comboBoxGraphicLevel";
            this.comboBoxGraphicLevel.Size = new System.Drawing.Size(239, 25);
            this.comboBoxGraphicLevel.TabIndex = 24;
            this.comboBoxGraphicLevel.Visible = false;
            // 
            // labelYesNoFirma
            // 
            this.labelYesNoFirma.AutoSize = true;
            this.labelYesNoFirma.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelYesNoFirma.Location = new System.Drawing.Point(20, 180);
            this.labelYesNoFirma.Name = "labelYesNoFirma";
            this.labelYesNoFirma.Size = new System.Drawing.Size(661, 21);
            this.labelYesNoFirma.TabIndex = 25;
            this.labelYesNoFirma.Text = "Вы имеете какие-либо представления о храктеристиках/производителях комплектующих?" +
    "\r\n";
            // 
            // comboBoxYesNoFirma
            // 
            this.comboBoxYesNoFirma.FormattingEnabled = true;
            this.comboBoxYesNoFirma.Items.AddRange(new object[] {
            "Нет",
            "Да"});
            this.comboBoxYesNoFirma.Location = new System.Drawing.Point(164, 204);
            this.comboBoxYesNoFirma.Name = "comboBoxYesNoFirma";
            this.comboBoxYesNoFirma.Size = new System.Drawing.Size(121, 23);
            this.comboBoxYesNoFirma.TabIndex = 26;
            this.comboBoxYesNoFirma.SelectedIndexChanged += new System.EventHandler(this.comboBoxYesNoFirma_SelectedIndexChanged);
            // 
            // labelProcessor
            // 
            this.labelProcessor.AutoSize = true;
            this.labelProcessor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProcessor.Location = new System.Drawing.Point(20, 230);
            this.labelProcessor.Name = "labelProcessor";
            this.labelProcessor.Size = new System.Drawing.Size(486, 21);
            this.labelProcessor.TabIndex = 27;
            this.labelProcessor.Text = "Имеются ли некоторые предпочтения при подборе процсессора?\r\n";
            this.labelProcessor.Visible = false;
            // 
            // comboBoxProcessor
            // 
            this.comboBoxProcessor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxProcessor.FormattingEnabled = true;
            this.comboBoxProcessor.Items.AddRange(new object[] {
            "AMD",
            "Intel"});
            this.comboBoxProcessor.Location = new System.Drawing.Point(522, 226);
            this.comboBoxProcessor.Name = "comboBoxProcessor";
            this.comboBoxProcessor.Size = new System.Drawing.Size(121, 25);
            this.comboBoxProcessor.TabIndex = 28;
            this.comboBoxProcessor.Visible = false;
            // 
            // labelHDD
            // 
            this.labelHDD.AutoSize = true;
            this.labelHDD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHDD.Location = new System.Drawing.Point(22, 283);
            this.labelHDD.Name = "labelHDD";
            this.labelHDD.Size = new System.Drawing.Size(221, 21);
            this.labelHDD.TabIndex = 29;
            this.labelHDD.Text = "Желаемый объём НDD-диска\r\n";
            this.labelHDD.Visible = false;
            // 
            // labelSSD
            // 
            this.labelSSD.AutoSize = true;
            this.labelSSD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSSD.Location = new System.Drawing.Point(22, 312);
            this.labelSSD.Name = "labelSSD";
            this.labelSSD.Size = new System.Drawing.Size(217, 21);
            this.labelSSD.TabIndex = 30;
            this.labelSSD.Text = "Желаемый объём SSD-диска";
            this.labelSSD.Visible = false;
            // 
            // comboBoxHDD
            // 
            this.comboBoxHDD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxHDD.FormattingEnabled = true;
            this.comboBoxHDD.Items.AddRange(new object[] {
            "500ГБ",
            "1ТБ",
            "2ТБ",
            "4ТБ",
            "6ТБ",
            "8ТБ",
            "10ТБ"});
            this.comboBoxHDD.Location = new System.Drawing.Point(253, 284);
            this.comboBoxHDD.Name = "comboBoxHDD";
            this.comboBoxHDD.Size = new System.Drawing.Size(121, 25);
            this.comboBoxHDD.TabIndex = 31;
            this.comboBoxHDD.Visible = false;
            this.comboBoxHDD.SelectedIndexChanged += new System.EventHandler(this.comboBoxHDD_SelectedIndexChanged);
            // 
            // comboBoxSSD
            // 
            this.comboBoxSSD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSSD.FormattingEnabled = true;
            this.comboBoxSSD.Items.AddRange(new object[] {
            "не нужен",
            "120ГБ",
            "250ГБ",
            "500ГБ",
            "1ТБ",
            "2ТБ"});
            this.comboBoxSSD.Location = new System.Drawing.Point(254, 313);
            this.comboBoxSSD.Name = "comboBoxSSD";
            this.comboBoxSSD.Size = new System.Drawing.Size(121, 25);
            this.comboBoxSSD.TabIndex = 32;
            this.comboBoxSSD.Visible = false;
            this.comboBoxSSD.SelectedIndexChanged += new System.EventHandler(this.comboBoxSSD_SelectedIndexChanged);
            // 
            // labelRAM
            // 
            this.labelRAM.AutoSize = true;
            this.labelRAM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRAM.Location = new System.Drawing.Point(22, 255);
            this.labelRAM.Name = "labelRAM";
            this.labelRAM.Size = new System.Drawing.Size(171, 21);
            this.labelRAM.TabIndex = 33;
            this.labelRAM.Text = "Желаемый объём ОЗУ\r\n";
            this.labelRAM.Visible = false;
            // 
            // comboBoxRAM
            // 
            this.comboBoxRAM.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxRAM.FormattingEnabled = true;
            this.comboBoxRAM.Items.AddRange(new object[] {
            "8ГБ",
            "16ГБ",
            "32ГБ",
            "64ГБ",
            "128ГБ",
            "256ГБ"});
            this.comboBoxRAM.Location = new System.Drawing.Point(253, 255);
            this.comboBoxRAM.Name = "comboBoxRAM";
            this.comboBoxRAM.Size = new System.Drawing.Size(121, 25);
            this.comboBoxRAM.TabIndex = 34;
            this.comboBoxRAM.Visible = false;
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCPU.Location = new System.Drawing.Point(762, 43);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(132, 21);
            this.labelCPU.TabIndex = 35;
            this.labelCPU.Text = "Процессор(CPU):\r\n";
            // 
            // labelCPUout
            // 
            this.labelCPUout.AutoSize = true;
            this.labelCPUout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCPUout.Location = new System.Drawing.Point(941, 43);
            this.labelCPUout.Name = "labelCPUout";
            this.labelCPUout.Size = new System.Drawing.Size(19, 21);
            this.labelCPUout.TabIndex = 36;
            this.labelCPUout.Text = "0";
            // 
            // labelMainBoard
            // 
            this.labelMainBoard.AutoSize = true;
            this.labelMainBoard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMainBoard.Location = new System.Drawing.Point(762, 74);
            this.labelMainBoard.Name = "labelMainBoard";
            this.labelMainBoard.Size = new System.Drawing.Size(152, 21);
            this.labelMainBoard.TabIndex = 37;
            this.labelMainBoard.Text = "Материнская плата:";
            // 
            // labelGPU
            // 
            this.labelGPU.AutoSize = true;
            this.labelGPU.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGPU.Location = new System.Drawing.Point(762, 106);
            this.labelGPU.Name = "labelGPU";
            this.labelGPU.Size = new System.Drawing.Size(138, 21);
            this.labelGPU.TabIndex = 38;
            this.labelGPU.Text = "Видеокарта(GPU):";
            // 
            // labelRAMout
            // 
            this.labelRAMout.AutoSize = true;
            this.labelRAMout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRAMout.Location = new System.Drawing.Point(762, 140);
            this.labelRAMout.Name = "labelRAMout";
            this.labelRAMout.Size = new System.Drawing.Size(163, 21);
            this.labelRAMout.TabIndex = 39;
            this.labelRAMout.Text = "Оперативная память:";
            // 
            // labelHDDout
            // 
            this.labelHDDout.AutoSize = true;
            this.labelHDDout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHDDout.Location = new System.Drawing.Point(762, 170);
            this.labelHDDout.Name = "labelHDDout";
            this.labelHDDout.Size = new System.Drawing.Size(155, 21);
            this.labelHDDout.TabIndex = 40;
            this.labelHDDout.Text = "Жесткий диск(HDD):";
            // 
            // labelSSDout
            // 
            this.labelSSDout.AutoSize = true;
            this.labelSSDout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSSDout.Location = new System.Drawing.Point(762, 204);
            this.labelSSDout.Name = "labelSSDout";
            this.labelSSDout.Size = new System.Drawing.Size(131, 21);
            this.labelSSDout.TabIndex = 41;
            this.labelSSDout.Text = "SSD-накопитель:";
            // 
            // labelPSU
            // 
            this.labelPSU.AutoSize = true;
            this.labelPSU.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPSU.Location = new System.Drawing.Point(762, 237);
            this.labelPSU.Name = "labelPSU";
            this.labelPSU.Size = new System.Drawing.Size(149, 21);
            this.labelPSU.TabIndex = 42;
            this.labelPSU.Text = "Блок питания(PSU):";
            // 
            // labelCPUcooler
            // 
            this.labelCPUcooler.AutoSize = true;
            this.labelCPUcooler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCPUcooler.Location = new System.Drawing.Point(762, 274);
            this.labelCPUcooler.Name = "labelCPUcooler";
            this.labelCPUcooler.Size = new System.Drawing.Size(173, 21);
            this.labelCPUcooler.TabIndex = 43;
            this.labelCPUcooler.Text = "Кулер для процессора:";
            // 
            // labelMainboardOutput
            // 
            this.labelMainboardOutput.AutoSize = true;
            this.labelMainboardOutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMainboardOutput.Location = new System.Drawing.Point(941, 74);
            this.labelMainboardOutput.Name = "labelMainboardOutput";
            this.labelMainboardOutput.Size = new System.Drawing.Size(19, 21);
            this.labelMainboardOutput.TabIndex = 44;
            this.labelMainboardOutput.Text = "0";
            // 
            // labelGPUoutput
            // 
            this.labelGPUoutput.AutoSize = true;
            this.labelGPUoutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGPUoutput.Location = new System.Drawing.Point(941, 106);
            this.labelGPUoutput.Name = "labelGPUoutput";
            this.labelGPUoutput.Size = new System.Drawing.Size(19, 21);
            this.labelGPUoutput.TabIndex = 45;
            this.labelGPUoutput.Text = "0";
            // 
            // labelRAMoutput
            // 
            this.labelRAMoutput.AutoSize = true;
            this.labelRAMoutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRAMoutput.Location = new System.Drawing.Point(941, 140);
            this.labelRAMoutput.Name = "labelRAMoutput";
            this.labelRAMoutput.Size = new System.Drawing.Size(19, 21);
            this.labelRAMoutput.TabIndex = 46;
            this.labelRAMoutput.Text = "0";
            // 
            // labelHDDoutput
            // 
            this.labelHDDoutput.AutoSize = true;
            this.labelHDDoutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHDDoutput.Location = new System.Drawing.Point(941, 170);
            this.labelHDDoutput.Name = "labelHDDoutput";
            this.labelHDDoutput.Size = new System.Drawing.Size(19, 21);
            this.labelHDDoutput.TabIndex = 47;
            this.labelHDDoutput.Text = "0";
            // 
            // labelSSDoutput
            // 
            this.labelSSDoutput.AutoSize = true;
            this.labelSSDoutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSSDoutput.Location = new System.Drawing.Point(941, 206);
            this.labelSSDoutput.Name = "labelSSDoutput";
            this.labelSSDoutput.Size = new System.Drawing.Size(19, 21);
            this.labelSSDoutput.TabIndex = 48;
            this.labelSSDoutput.Text = "0";
            // 
            // labelPSUoutput
            // 
            this.labelPSUoutput.AutoSize = true;
            this.labelPSUoutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPSUoutput.Location = new System.Drawing.Point(941, 237);
            this.labelPSUoutput.Name = "labelPSUoutput";
            this.labelPSUoutput.Size = new System.Drawing.Size(19, 21);
            this.labelPSUoutput.TabIndex = 49;
            this.labelPSUoutput.Text = "0";
            // 
            // labelCPUcooleroutput
            // 
            this.labelCPUcooleroutput.AutoSize = true;
            this.labelCPUcooleroutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCPUcooleroutput.Location = new System.Drawing.Point(941, 274);
            this.labelCPUcooleroutput.Name = "labelCPUcooleroutput";
            this.labelCPUcooleroutput.Size = new System.Drawing.Size(19, 21);
            this.labelCPUcooleroutput.TabIndex = 50;
            this.labelCPUcooleroutput.Text = "0";
            // 
            // labelPriceLevel
            // 
            this.labelPriceLevel.AutoSize = true;
            this.labelPriceLevel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPriceLevel.Location = new System.Drawing.Point(20, 133);
            this.labelPriceLevel.Name = "labelPriceLevel";
            this.labelPriceLevel.Size = new System.Drawing.Size(354, 21);
            this.labelPriceLevel.TabIndex = 51;
            this.labelPriceLevel.Text = "Какую по цене сборку Вы желали бы получить?";
            this.labelPriceLevel.Visible = false;
            // 
            // comboBoxPriceLevel
            // 
            this.comboBoxPriceLevel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxPriceLevel.FormattingEnabled = true;
            this.comboBoxPriceLevel.Items.AddRange(new object[] {
            "Бюджетная",
            "Оптимальная",
            "Профессиональная"});
            this.comboBoxPriceLevel.Location = new System.Drawing.Point(396, 129);
            this.comboBoxPriceLevel.Name = "comboBoxPriceLevel";
            this.comboBoxPriceLevel.Size = new System.Drawing.Size(121, 25);
            this.comboBoxPriceLevel.TabIndex = 52;
            this.comboBoxPriceLevel.Visible = false;
            this.comboBoxPriceLevel.SelectedIndexChanged += new System.EventHandler(this.comboBoxPriceLevel_SelectedIndexChanged);
            // 
            // labelSoundCard
            // 
            this.labelSoundCard.AutoSize = true;
            this.labelSoundCard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSoundCard.Location = new System.Drawing.Point(762, 353);
            this.labelSoundCard.Name = "labelSoundCard";
            this.labelSoundCard.Size = new System.Drawing.Size(208, 21);
            this.labelSoundCard.TabIndex = 53;
            this.labelSoundCard.Text = "Звуковая плата PCI-Express:";
            this.labelSoundCard.Visible = false;
            // 
            // labelSoundCardoutput
            // 
            this.labelSoundCardoutput.AutoSize = true;
            this.labelSoundCardoutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSoundCardoutput.Location = new System.Drawing.Point(1009, 353);
            this.labelSoundCardoutput.Name = "labelSoundCardoutput";
            this.labelSoundCardoutput.Size = new System.Drawing.Size(19, 21);
            this.labelSoundCardoutput.TabIndex = 54;
            this.labelSoundCardoutput.Text = "0";
            this.labelSoundCardoutput.Visible = false;
            // 
            // labelOfficeProgram
            // 
            this.labelOfficeProgram.AutoSize = true;
            this.labelOfficeProgram.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOfficeProgram.Location = new System.Drawing.Point(20, 72);
            this.labelOfficeProgram.Name = "labelOfficeProgram";
            this.labelOfficeProgram.Size = new System.Drawing.Size(333, 21);
            this.labelOfficeProgram.TabIndex = 55;
            this.labelOfficeProgram.Text = "Нужна ли предустановка офисных программ";
            this.labelOfficeProgram.Visible = false;
            // 
            // comboBoxOfficeProgram
            // 
            this.comboBoxOfficeProgram.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxOfficeProgram.FormattingEnabled = true;
            this.comboBoxOfficeProgram.Items.AddRange(new object[] {
            "Да (+6000р)",
            "Нет"});
            this.comboBoxOfficeProgram.Location = new System.Drawing.Point(396, 70);
            this.comboBoxOfficeProgram.Name = "comboBoxOfficeProgram";
            this.comboBoxOfficeProgram.Size = new System.Drawing.Size(121, 25);
            this.comboBoxOfficeProgram.TabIndex = 56;
            this.comboBoxOfficeProgram.Visible = false;
            // 
            // labelWindow
            // 
            this.labelWindow.AutoSize = true;
            this.labelWindow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWindow.Location = new System.Drawing.Point(20, 97);
            this.labelWindow.Name = "labelWindow";
            this.labelWindow.Size = new System.Drawing.Size(342, 21);
            this.labelWindow.TabIndex = 57;
            this.labelWindow.Text = "Нужна ли предустановка ОС Windows 10 Pro?";
            this.labelWindow.Visible = false;
            // 
            // comboBoxWindow
            // 
            this.comboBoxWindow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxWindow.FormattingEnabled = true;
            this.comboBoxWindow.Items.AddRange(new object[] {
            "Да (+10000р)",
            "Нет"});
            this.comboBoxWindow.Location = new System.Drawing.Point(401, 100);
            this.comboBoxWindow.Name = "comboBoxWindow";
            this.comboBoxWindow.Size = new System.Drawing.Size(121, 25);
            this.comboBoxWindow.TabIndex = 58;
            this.comboBoxWindow.Visible = false;
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSpeed.Location = new System.Drawing.Point(22, 230);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(101, 21);
            this.labelSpeed.TabIndex = 59;
            this.labelSpeed.Text = "Что важнее?";
            this.labelSpeed.Visible = false;
            // 
            // comboBoxSpeed
            // 
            this.comboBoxSpeed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSpeed.FormattingEnabled = true;
            this.comboBoxSpeed.Items.AddRange(new object[] {
            "Меньше цена",
            "Больше произвадительность"});
            this.comboBoxSpeed.Location = new System.Drawing.Point(153, 229);
            this.comboBoxSpeed.Name = "comboBoxSpeed";
            this.comboBoxSpeed.Size = new System.Drawing.Size(121, 25);
            this.comboBoxSpeed.TabIndex = 60;
            this.comboBoxSpeed.Visible = false;
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSum.Location = new System.Drawing.Point(762, 388);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(213, 21);
            this.labelSum.TabIndex = 61;
            this.labelSum.Text = "Итоговая стоимость сборки:";
            // 
            // labelSumoutput
            // 
            this.labelSumoutput.AutoSize = true;
            this.labelSumoutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSumoutput.Location = new System.Drawing.Point(1009, 388);
            this.labelSumoutput.Name = "labelSumoutput";
            this.labelSumoutput.Size = new System.Drawing.Size(19, 21);
            this.labelSumoutput.TabIndex = 62;
            this.labelSumoutput.Text = "0";
            // 
            // labelOfficeSSD
            // 
            this.labelOfficeSSD.AutoSize = true;
            this.labelOfficeSSD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOfficeSSD.Location = new System.Drawing.Point(22, 312);
            this.labelOfficeSSD.Name = "labelOfficeSSD";
            this.labelOfficeSSD.Size = new System.Drawing.Size(386, 21);
            this.labelOfficeSSD.TabIndex = 63;
            this.labelOfficeSSD.Text = "Нужен ли Вам SSD - диск для быстрой работы с ОС?";
            this.labelOfficeSSD.Visible = false;
            // 
            // comboBoxOfficeSSD
            // 
            this.comboBoxOfficeSSD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxOfficeSSD.FormattingEnabled = true;
            this.comboBoxOfficeSSD.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.comboBoxOfficeSSD.Location = new System.Drawing.Point(457, 312);
            this.comboBoxOfficeSSD.Name = "comboBoxOfficeSSD";
            this.comboBoxOfficeSSD.Size = new System.Drawing.Size(121, 25);
            this.comboBoxOfficeSSD.TabIndex = 64;
            this.comboBoxOfficeSSD.Visible = false;
            this.comboBoxOfficeSSD.SelectedIndexChanged += new System.EventHandler(this.comboBoxOfficeSSD_SelectedIndexChanged);
            // 
            // labelGamePrice
            // 
            this.labelGamePrice.AutoSize = true;
            this.labelGamePrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGamePrice.Location = new System.Drawing.Point(22, 70);
            this.labelGamePrice.Name = "labelGamePrice";
            this.labelGamePrice.Size = new System.Drawing.Size(345, 21);
            this.labelGamePrice.TabIndex = 65;
            this.labelGamePrice.Text = "Желаемая приблизительная стоимость сборки\r\n";
            this.labelGamePrice.Visible = false;
            // 
            // comboBoxGamePrice
            // 
            this.comboBoxGamePrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxGamePrice.FormattingEnabled = true;
            this.comboBoxGamePrice.Items.AddRange(new object[] {
            "20000",
            "30000",
            "48000",
            "60000",
            "80000",
            "100000"});
            this.comboBoxGamePrice.Location = new System.Drawing.Point(396, 70);
            this.comboBoxGamePrice.Name = "comboBoxGamePrice";
            this.comboBoxGamePrice.Size = new System.Drawing.Size(121, 25);
            this.comboBoxGamePrice.TabIndex = 66;
            this.comboBoxGamePrice.Visible = false;
            // 
            // labelGameWork
            // 
            this.labelGameWork.AutoSize = true;
            this.labelGameWork.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGameWork.Location = new System.Drawing.Point(22, 130);
            this.labelGameWork.Name = "labelGameWork";
            this.labelGameWork.Size = new System.Drawing.Size(455, 21);
            this.labelGameWork.TabIndex = 67;
            this.labelGameWork.Text = "Планируете ли вы дополнительно работать за компьютером?";
            this.labelGameWork.UseWaitCursor = true;
            this.labelGameWork.Visible = false;
            // 
            // comboBoxGameWork
            // 
            this.comboBoxGameWork.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxGameWork.FormattingEnabled = true;
            this.comboBoxGameWork.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.comboBoxGameWork.Location = new System.Drawing.Point(522, 129);
            this.comboBoxGameWork.Name = "comboBoxGameWork";
            this.comboBoxGameWork.Size = new System.Drawing.Size(121, 25);
            this.comboBoxGameWork.TabIndex = 68;
            this.comboBoxGameWork.Visible = false;
            // 
            // labelCPUGPU
            // 
            this.labelCPUGPU.AutoSize = true;
            this.labelCPUGPU.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCPUGPU.Location = new System.Drawing.Point(19, 230);
            this.labelCPUGPU.Name = "labelCPUGPU";
            this.labelCPUGPU.Size = new System.Drawing.Size(498, 21);
            this.labelCPUGPU.TabIndex = 69;
            this.labelCPUGPU.Text = "Имеются ли некоторые предпочтения приподборе пары CPU-GPU?\r\n";
            this.labelCPUGPU.Visible = false;
            // 
            // comboBoxCPUGPU
            // 
            this.comboBoxCPUGPU.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCPUGPU.FormattingEnabled = true;
            this.comboBoxCPUGPU.Items.AddRange(new object[] {
            "INTEL - NVIDIA",
            "INTEL - AMD",
            "AMD - NVIDIA",
            "AMD - AMD"});
            this.comboBoxCPUGPU.Location = new System.Drawing.Point(253, 254);
            this.comboBoxCPUGPU.Name = "comboBoxCPUGPU";
            this.comboBoxCPUGPU.Size = new System.Drawing.Size(121, 25);
            this.comboBoxCPUGPU.TabIndex = 70;
            this.comboBoxCPUGPU.Visible = false;
            this.comboBoxCPUGPU.SelectedIndexChanged += new System.EventHandler(this.comboBoxCPUGPU_SelectedIndexChanged);
            // 
            // labelGPUGame
            // 
            this.labelGPUGame.AutoSize = true;
            this.labelGPUGame.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGPUGame.Location = new System.Drawing.Point(22, 282);
            this.labelGPUGame.Name = "labelGPUGame";
            this.labelGPUGame.Size = new System.Drawing.Size(480, 21);
            this.labelGPUGame.TabIndex = 71;
            this.labelGPUGame.Text = "Имеются ли некоторые предпочтения при подборе видеокарты?";
            this.labelGPUGame.Visible = false;
            // 
            // comboBoxGPUGame
            // 
            this.comboBoxGPUGame.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxGPUGame.FormattingEnabled = true;
            this.comboBoxGPUGame.Items.AddRange(new object[] {
            "NVIDIA",
            "AMD"});
            this.comboBoxGPUGame.Location = new System.Drawing.Point(253, 306);
            this.comboBoxGPUGame.Name = "comboBoxGPUGame";
            this.comboBoxGPUGame.Size = new System.Drawing.Size(121, 25);
            this.comboBoxGPUGame.TabIndex = 72;
            this.comboBoxGPUGame.Visible = false;
            this.comboBoxGPUGame.SelectedIndexChanged += new System.EventHandler(this.comboBoxGPUGame_SelectedIndexChanged);
            // 
            // labelRecommend
            // 
            this.labelRecommend.AutoSize = true;
            this.labelRecommend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRecommend.Location = new System.Drawing.Point(22, 372);
            this.labelRecommend.Name = "labelRecommend";
            this.labelRecommend.Size = new System.Drawing.Size(504, 42);
            this.labelRecommend.TabIndex = 73;
            this.labelRecommend.Text = "Экспертная система закончила сбор информации\r\nНажмите на кнопку для вывода подобр" +
    "аннай Вам конфигурации ПК\r\n";
            this.labelRecommend.Visible = false;
            // 
            // labelKorpus
            // 
            this.labelKorpus.AutoSize = true;
            this.labelKorpus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKorpus.Location = new System.Drawing.Point(762, 312);
            this.labelKorpus.Name = "labelKorpus";
            this.labelKorpus.Size = new System.Drawing.Size(64, 21);
            this.labelKorpus.TabIndex = 74;
            this.labelKorpus.Text = "Корпус:";
            // 
            // labelKorpusoutput
            // 
            this.labelKorpusoutput.AutoSize = true;
            this.labelKorpusoutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKorpusoutput.Location = new System.Drawing.Point(941, 317);
            this.labelKorpusoutput.Name = "labelKorpusoutput";
            this.labelKorpusoutput.Size = new System.Drawing.Size(19, 21);
            this.labelKorpusoutput.TabIndex = 75;
            this.labelKorpusoutput.Text = "0";
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1334, 521);
            this.Controls.Add(this.labelKorpusoutput);
            this.Controls.Add(this.labelKorpus);
            this.Controls.Add(this.labelRecommend);
            this.Controls.Add(this.comboBoxGPUGame);
            this.Controls.Add(this.labelGPUGame);
            this.Controls.Add(this.comboBoxCPUGPU);
            this.Controls.Add(this.labelCPUGPU);
            this.Controls.Add(this.comboBoxGameWork);
            this.Controls.Add(this.labelGameWork);
            this.Controls.Add(this.comboBoxGamePrice);
            this.Controls.Add(this.labelGamePrice);
            this.Controls.Add(this.comboBoxOfficeSSD);
            this.Controls.Add(this.labelOfficeSSD);
            this.Controls.Add(this.labelSumoutput);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.comboBoxSpeed);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.comboBoxWindow);
            this.Controls.Add(this.labelWindow);
            this.Controls.Add(this.comboBoxOfficeProgram);
            this.Controls.Add(this.labelOfficeProgram);
            this.Controls.Add(this.labelSoundCardoutput);
            this.Controls.Add(this.labelSoundCard);
            this.Controls.Add(this.comboBoxPriceLevel);
            this.Controls.Add(this.labelPriceLevel);
            this.Controls.Add(this.labelCPUcooleroutput);
            this.Controls.Add(this.labelPSUoutput);
            this.Controls.Add(this.labelSSDoutput);
            this.Controls.Add(this.labelHDDoutput);
            this.Controls.Add(this.labelRAMoutput);
            this.Controls.Add(this.labelGPUoutput);
            this.Controls.Add(this.labelMainboardOutput);
            this.Controls.Add(this.labelCPUcooler);
            this.Controls.Add(this.labelPSU);
            this.Controls.Add(this.labelSSDout);
            this.Controls.Add(this.labelHDDout);
            this.Controls.Add(this.labelRAMout);
            this.Controls.Add(this.labelGPU);
            this.Controls.Add(this.labelMainBoard);
            this.Controls.Add(this.labelCPUout);
            this.Controls.Add(this.labelCPU);
            this.Controls.Add(this.comboBoxRAM);
            this.Controls.Add(this.labelRAM);
            this.Controls.Add(this.comboBoxSSD);
            this.Controls.Add(this.comboBoxHDD);
            this.Controls.Add(this.labelSSD);
            this.Controls.Add(this.labelHDD);
            this.Controls.Add(this.comboBoxProcessor);
            this.Controls.Add(this.labelProcessor);
            this.Controls.Add(this.comboBoxYesNoFirma);
            this.Controls.Add(this.labelYesNoFirma);
            this.Controls.Add(this.comboBoxGraphicLevel);
            this.Controls.Add(this.labelGrapgicLevel);
            this.Controls.Add(this.comboBoxTypeGraphic);
            this.Controls.Add(this.labelTypeGraphic);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.comboBoxSel2);
            this.Controls.Add(this.buttonRecommend);
            this.Controls.Add(this.labelSel2);
            this.Controls.Add(this.comboBoxSel);
            this.Controls.Add(this.labelSel);
            this.Controls.Add(this.buttonExit);
            this.Name = "MyForm";
            this.Text = "MyForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelSel;
        private System.Windows.Forms.ComboBox comboBoxSel;
        private System.Windows.Forms.Label labelSel2;
        private System.Windows.Forms.Button buttonRecommend;
        private System.Windows.Forms.ComboBox comboBoxSel2;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelTypeGraphic;
        private System.Windows.Forms.ComboBox comboBoxTypeGraphic;
        private System.Windows.Forms.Label labelGrapgicLevel;
        private System.Windows.Forms.ComboBox comboBoxGraphicLevel;
        private System.Windows.Forms.Label labelYesNoFirma;
        private System.Windows.Forms.ComboBox comboBoxYesNoFirma;
        private System.Windows.Forms.Label labelProcessor;
        private System.Windows.Forms.ComboBox comboBoxProcessor;
        private System.Windows.Forms.Label labelHDD;
        private System.Windows.Forms.Label labelSSD;
        private System.Windows.Forms.ComboBox comboBoxHDD;
        private System.Windows.Forms.ComboBox comboBoxSSD;
        private System.Windows.Forms.Label labelRAM;
        private System.Windows.Forms.ComboBox comboBoxRAM;
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.Label labelCPUout;
        private System.Windows.Forms.Label labelMainBoard;
        private System.Windows.Forms.Label labelGPU;
        private System.Windows.Forms.Label labelRAMout;
        private System.Windows.Forms.Label labelHDDout;
        private System.Windows.Forms.Label labelSSDout;
        private System.Windows.Forms.Label labelPSU;
        private System.Windows.Forms.Label labelCPUcooler;
        private System.Windows.Forms.Label labelMainboardOutput;
        private System.Windows.Forms.Label labelGPUoutput;
        private System.Windows.Forms.Label labelRAMoutput;
        private System.Windows.Forms.Label labelHDDoutput;
        private System.Windows.Forms.Label labelSSDoutput;
        private System.Windows.Forms.Label labelPSUoutput;
        private System.Windows.Forms.Label labelCPUcooleroutput;
        private System.Windows.Forms.Label labelPriceLevel;
        private System.Windows.Forms.ComboBox comboBoxPriceLevel;
        private System.Windows.Forms.Label labelSoundCard;
        private System.Windows.Forms.Label labelSoundCardoutput;
        private System.Windows.Forms.Label labelOfficeProgram;
        private System.Windows.Forms.ComboBox comboBoxOfficeProgram;
        private System.Windows.Forms.Label labelWindow;
        private System.Windows.Forms.ComboBox comboBoxWindow;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.ComboBox comboBoxSpeed;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelSumoutput;
        private System.Windows.Forms.Label labelOfficeSSD;
        private System.Windows.Forms.ComboBox comboBoxOfficeSSD;
        private System.Windows.Forms.Label labelGamePrice;
        private System.Windows.Forms.ComboBox comboBoxGamePrice;
        private System.Windows.Forms.Label labelGameWork;
        private System.Windows.Forms.ComboBox comboBoxGameWork;
        private System.Windows.Forms.Label labelCPUGPU;
        private System.Windows.Forms.ComboBox comboBoxCPUGPU;
        private System.Windows.Forms.Label labelGPUGame;
        private System.Windows.Forms.ComboBox comboBoxGPUGame;
        private System.Windows.Forms.Label labelRecommend;
        private System.Windows.Forms.Label labelKorpus;
        private System.Windows.Forms.Label labelKorpusoutput;
    }
}

