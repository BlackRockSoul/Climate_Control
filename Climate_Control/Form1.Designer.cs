namespace Climate_Control
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SrTemp = new System.Windows.Forms.Label();
            this.WindowTemp = new System.Windows.Forms.Label();
            this.HotTemp = new System.Windows.Forms.Label();
            this.SrTempV = new System.Windows.Forms.Label();
            this.WindowTempV = new System.Windows.Forms.Label();
            this.HotTempV = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Angle = new System.Windows.Forms.Label();
            this.AngleV = new System.Windows.Forms.Label();
            this.Closed = new System.Windows.Forms.Label();
            this.ClosedV = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CyclesV = new System.Windows.Forms.Label();
            this.NeedTempV = new System.Windows.Forms.Label();
            this.Cycles = new System.Windows.Forms.Label();
            this.NeedTemp = new System.Windows.Forms.Label();
            this.CycleV = new System.Windows.Forms.Label();
            this.HumiditySrV = new System.Windows.Forms.Label();
            this.Cycle = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.TurnOn = new System.Windows.Forms.Button();
            this.TurnOff = new System.Windows.Forms.Button();
            this.CyclePlus = new System.Windows.Forms.Button();
            this.CycleMinus = new System.Windows.Forms.Button();
            this.CloseWindow = new System.Windows.Forms.CheckBox();
            this.TempPlus = new System.Windows.Forms.Button();
            this.TempMinus = new System.Windows.Forms.Button();
            this.Opened = new System.Windows.Forms.Label();
            this.OpenedV = new System.Windows.Forms.Label();
            this.CycleCompl = new System.Windows.Forms.Label();
            this.CycleComplV = new System.Windows.Forms.Label();
            this.CycleAll = new System.Windows.Forms.Label();
            this.CycleAllV = new System.Windows.Forms.Label();
            this.OpenWindow = new System.Windows.Forms.CheckBox();
            this.HumidityHot = new System.Windows.Forms.Label();
            this.HumiditySr = new System.Windows.Forms.Label();
            this.HumidityWindow = new System.Windows.Forms.Label();
            this.HumidityWindowV = new System.Windows.Forms.Label();
            this.HumidityHotV = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Температура:";
            // 
            // SrTemp
            // 
            this.SrTemp.AutoSize = true;
            this.SrTemp.Location = new System.Drawing.Point(41, 47);
            this.SrTemp.Name = "SrTemp";
            this.SrTemp.Size = new System.Drawing.Size(56, 13);
            this.SrTemp.TabIndex = 1;
            this.SrTemp.Text = "Средняя: ";
            // 
            // WindowTemp
            // 
            this.WindowTemp.AutoSize = true;
            this.WindowTemp.Location = new System.Drawing.Point(41, 68);
            this.WindowTemp.Name = "WindowTemp";
            this.WindowTemp.Size = new System.Drawing.Size(39, 13);
            this.WindowTemp.TabIndex = 2;
            this.WindowTemp.Text = "Окно: ";
            // 
            // HotTemp
            // 
            this.HotTemp.AutoSize = true;
            this.HotTemp.Location = new System.Drawing.Point(41, 89);
            this.HotTemp.Name = "HotTemp";
            this.HotTemp.Size = new System.Drawing.Size(75, 13);
            this.HotTemp.TabIndex = 3;
            this.HotTemp.Text = "Подоконник: ";
            // 
            // SrTempV
            // 
            this.SrTempV.AutoSize = true;
            this.SrTempV.Location = new System.Drawing.Point(124, 47);
            this.SrTempV.Name = "SrTempV";
            this.SrTempV.Size = new System.Drawing.Size(23, 13);
            this.SrTempV.TabIndex = 4;
            this.SrTempV.Text = "null";
            // 
            // WindowTempV
            // 
            this.WindowTempV.AutoSize = true;
            this.WindowTempV.Location = new System.Drawing.Point(124, 68);
            this.WindowTempV.Name = "WindowTempV";
            this.WindowTempV.Size = new System.Drawing.Size(23, 13);
            this.WindowTempV.TabIndex = 5;
            this.WindowTempV.Text = "null";
            // 
            // HotTempV
            // 
            this.HotTempV.AutoSize = true;
            this.HotTempV.Location = new System.Drawing.Point(124, 89);
            this.HotTempV.Name = "HotTempV";
            this.HotTempV.Size = new System.Drawing.Size(23, 13);
            this.HotTempV.TabIndex = 6;
            this.HotTempV.Text = "null";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(191, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Окно: ";
            // 
            // Angle
            // 
            this.Angle.AutoSize = true;
            this.Angle.Location = new System.Drawing.Point(217, 47);
            this.Angle.Name = "Angle";
            this.Angle.Size = new System.Drawing.Size(89, 13);
            this.Angle.TabIndex = 8;
            this.Angle.Text = "Угол открытия: ";
            // 
            // AngleV
            // 
            this.AngleV.AutoSize = true;
            this.AngleV.Location = new System.Drawing.Point(327, 47);
            this.AngleV.Name = "AngleV";
            this.AngleV.Size = new System.Drawing.Size(23, 13);
            this.AngleV.TabIndex = 9;
            this.AngleV.Text = "null";
            // 
            // Closed
            // 
            this.Closed.AutoSize = true;
            this.Closed.Location = new System.Drawing.Point(217, 69);
            this.Closed.Name = "Closed";
            this.Closed.Size = new System.Drawing.Size(57, 13);
            this.Closed.TabIndex = 10;
            this.Closed.Text = "Закрыто: ";
            // 
            // ClosedV
            // 
            this.ClosedV.AutoSize = true;
            this.ClosedV.Location = new System.Drawing.Point(327, 67);
            this.ClosedV.Name = "ClosedV";
            this.ClosedV.Size = new System.Drawing.Size(23, 13);
            this.ClosedV.TabIndex = 11;
            this.ClosedV.Text = "null";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HumidityHotV);
            this.groupBox1.Controls.Add(this.HumidityWindowV);
            this.groupBox1.Controls.Add(this.CycleAllV);
            this.groupBox1.Controls.Add(this.CycleAll);
            this.groupBox1.Controls.Add(this.CycleComplV);
            this.groupBox1.Controls.Add(this.CycleCompl);
            this.groupBox1.Controls.Add(this.OpenedV);
            this.groupBox1.Controls.Add(this.Opened);
            this.groupBox1.Controls.Add(this.CyclesV);
            this.groupBox1.Controls.Add(this.NeedTempV);
            this.groupBox1.Controls.Add(this.Cycles);
            this.groupBox1.Controls.Add(this.NeedTemp);
            this.groupBox1.Controls.Add(this.CycleV);
            this.groupBox1.Controls.Add(this.HumiditySrV);
            this.groupBox1.Controls.Add(this.Cycle);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.ClosedV);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.AngleV);
            this.groupBox1.Controls.Add(this.HotTempV);
            this.groupBox1.Controls.Add(this.WindowTempV);
            this.groupBox1.Controls.Add(this.HumidityWindow);
            this.groupBox1.Controls.Add(this.Closed);
            this.groupBox1.Controls.Add(this.HumiditySr);
            this.groupBox1.Controls.Add(this.WindowTemp);
            this.groupBox1.Controls.Add(this.HumidityHot);
            this.groupBox1.Controls.Add(this.SrTemp);
            this.groupBox1.Controls.Add(this.HotTemp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SrTempV);
            this.groupBox1.Controls.Add(this.Angle);
            this.groupBox1.Location = new System.Drawing.Point(15, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 272);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация";
            // 
            // CyclesV
            // 
            this.CyclesV.AutoSize = true;
            this.CyclesV.Location = new System.Drawing.Point(327, 127);
            this.CyclesV.Name = "CyclesV";
            this.CyclesV.Size = new System.Drawing.Size(23, 13);
            this.CyclesV.TabIndex = 27;
            this.CyclesV.Text = "null";
            // 
            // NeedTempV
            // 
            this.NeedTempV.AutoSize = true;
            this.NeedTempV.Location = new System.Drawing.Point(124, 110);
            this.NeedTempV.Name = "NeedTempV";
            this.NeedTempV.Size = new System.Drawing.Size(23, 13);
            this.NeedTempV.TabIndex = 26;
            this.NeedTempV.Text = "null";
            // 
            // Cycles
            // 
            this.Cycles.AutoSize = true;
            this.Cycles.Location = new System.Drawing.Point(217, 129);
            this.Cycles.Name = "Cycles";
            this.Cycles.Size = new System.Drawing.Size(93, 13);
            this.Cycles.TabIndex = 21;
            this.Cycles.Text = "Рабочих циклов: ";
            // 
            // NeedTemp
            // 
            this.NeedTemp.AutoSize = true;
            this.NeedTemp.Location = new System.Drawing.Point(41, 110);
            this.NeedTemp.Name = "NeedTemp";
            this.NeedTemp.Size = new System.Drawing.Size(62, 13);
            this.NeedTemp.TabIndex = 15;
            this.NeedTemp.Text = "Заданная: ";
            // 
            // CycleV
            // 
            this.CycleV.AutoSize = true;
            this.CycleV.Location = new System.Drawing.Point(327, 107);
            this.CycleV.Name = "CycleV";
            this.CycleV.Size = new System.Drawing.Size(23, 13);
            this.CycleV.TabIndex = 2;
            this.CycleV.Text = "null";
            // 
            // HumiditySrV
            // 
            this.HumiditySrV.AutoSize = true;
            this.HumiditySrV.Location = new System.Drawing.Point(124, 159);
            this.HumiditySrV.Name = "HumiditySrV";
            this.HumiditySrV.Size = new System.Drawing.Size(23, 13);
            this.HumiditySrV.TabIndex = 14;
            this.HumiditySrV.Text = "null";
            // 
            // Cycle
            // 
            this.Cycle.AutoSize = true;
            this.Cycle.Location = new System.Drawing.Point(217, 109);
            this.Cycle.Name = "Cycle";
            this.Cycle.Size = new System.Drawing.Size(102, 13);
            this.Cycle.TabIndex = 1;
            this.Cycle.Text = "Циклов пройдено: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Влажность: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OpenWindow);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.TurnOn);
            this.groupBox2.Controls.Add(this.TurnOff);
            this.groupBox2.Controls.Add(this.CyclePlus);
            this.groupBox2.Controls.Add(this.CycleMinus);
            this.groupBox2.Controls.Add(this.CloseWindow);
            this.groupBox2.Controls.Add(this.TempPlus);
            this.groupBox2.Controls.Add(this.TempMinus);
            this.groupBox2.Location = new System.Drawing.Point(393, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 269);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 75);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(117, 13);
            this.label23.TabIndex = 27;
            this.label23.Text = "Общее кол-во циклов";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 48);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(124, 13);
            this.label22.TabIndex = 26;
            this.label22.Text = "Заданная температура";
            // 
            // TurnOn
            // 
            this.TurnOn.Location = new System.Drawing.Point(123, 240);
            this.TurnOn.Name = "TurnOn";
            this.TurnOn.Size = new System.Drawing.Size(75, 23);
            this.TurnOn.TabIndex = 16;
            this.TurnOn.Text = "Включить";
            this.TurnOn.UseVisualStyleBackColor = true;
            this.TurnOn.Click += new System.EventHandler(this.button2_Click);
            // 
            // TurnOff
            // 
            this.TurnOff.Location = new System.Drawing.Point(204, 240);
            this.TurnOff.Name = "TurnOff";
            this.TurnOff.Size = new System.Drawing.Size(75, 23);
            this.TurnOff.TabIndex = 15;
            this.TurnOff.Text = "Выключить";
            this.TurnOff.UseVisualStyleBackColor = true;
            this.TurnOff.Click += new System.EventHandler(this.button1_Click);
            // 
            // CyclePlus
            // 
            this.CyclePlus.Location = new System.Drawing.Point(135, 71);
            this.CyclePlus.Name = "CyclePlus";
            this.CyclePlus.Size = new System.Drawing.Size(22, 21);
            this.CyclePlus.TabIndex = 25;
            this.CyclePlus.Text = "+";
            this.CyclePlus.UseVisualStyleBackColor = true;
            this.CyclePlus.Click += new System.EventHandler(this.button6_Click);
            // 
            // CycleMinus
            // 
            this.CycleMinus.Location = new System.Drawing.Point(163, 71);
            this.CycleMinus.Name = "CycleMinus";
            this.CycleMinus.Size = new System.Drawing.Size(22, 21);
            this.CycleMinus.TabIndex = 24;
            this.CycleMinus.Text = "-";
            this.CycleMinus.UseVisualStyleBackColor = true;
            this.CycleMinus.Click += new System.EventHandler(this.button5_Click);
            // 
            // CloseWindow
            // 
            this.CloseWindow.AutoSize = true;
            this.CloseWindow.Location = new System.Drawing.Point(6, 22);
            this.CloseWindow.Name = "CloseWindow";
            this.CloseWindow.Size = new System.Drawing.Size(97, 17);
            this.CloseWindow.TabIndex = 0;
            this.CloseWindow.Text = "Закрыть окно";
            this.CloseWindow.UseVisualStyleBackColor = true;
            this.CloseWindow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBox1_MouseClick);
            // 
            // TempPlus
            // 
            this.TempPlus.Location = new System.Drawing.Point(135, 44);
            this.TempPlus.Name = "TempPlus";
            this.TempPlus.Size = new System.Drawing.Size(22, 21);
            this.TempPlus.TabIndex = 22;
            this.TempPlus.Text = "+";
            this.TempPlus.UseVisualStyleBackColor = true;
            this.TempPlus.Click += new System.EventHandler(this.button3_Click);
            // 
            // TempMinus
            // 
            this.TempMinus.Location = new System.Drawing.Point(163, 44);
            this.TempMinus.Name = "TempMinus";
            this.TempMinus.Size = new System.Drawing.Size(22, 21);
            this.TempMinus.TabIndex = 23;
            this.TempMinus.Text = "-";
            this.TempMinus.UseVisualStyleBackColor = true;
            this.TempMinus.Click += new System.EventHandler(this.button4_Click);
            // 
            // Opened
            // 
            this.Opened.AutoSize = true;
            this.Opened.Location = new System.Drawing.Point(217, 89);
            this.Opened.Name = "Opened";
            this.Opened.Size = new System.Drawing.Size(57, 13);
            this.Opened.TabIndex = 28;
            this.Opened.Text = "Открыто: ";
            // 
            // OpenedV
            // 
            this.OpenedV.AutoSize = true;
            this.OpenedV.Location = new System.Drawing.Point(327, 87);
            this.OpenedV.Name = "OpenedV";
            this.OpenedV.Size = new System.Drawing.Size(23, 13);
            this.OpenedV.TabIndex = 29;
            this.OpenedV.Text = "null";
            // 
            // CycleCompl
            // 
            this.CycleCompl.AutoSize = true;
            this.CycleCompl.Location = new System.Drawing.Point(217, 149);
            this.CycleCompl.Name = "CycleCompl";
            this.CycleCompl.Size = new System.Drawing.Size(66, 13);
            this.CycleCompl.TabIndex = 30;
            this.CycleCompl.Text = "Успешных: ";
            // 
            // CycleComplV
            // 
            this.CycleComplV.AutoSize = true;
            this.CycleComplV.Location = new System.Drawing.Point(327, 147);
            this.CycleComplV.Name = "CycleComplV";
            this.CycleComplV.Size = new System.Drawing.Size(23, 13);
            this.CycleComplV.TabIndex = 31;
            this.CycleComplV.Text = "null";
            // 
            // CycleAll
            // 
            this.CycleAll.AutoSize = true;
            this.CycleAll.Location = new System.Drawing.Point(217, 169);
            this.CycleAll.Name = "CycleAll";
            this.CycleAll.Size = new System.Drawing.Size(43, 13);
            this.CycleAll.TabIndex = 32;
            this.CycleAll.Text = "Всего: ";
            // 
            // CycleAllV
            // 
            this.CycleAllV.AutoSize = true;
            this.CycleAllV.Location = new System.Drawing.Point(327, 167);
            this.CycleAllV.Name = "CycleAllV";
            this.CycleAllV.Size = new System.Drawing.Size(23, 13);
            this.CycleAllV.TabIndex = 33;
            this.CycleAllV.Text = "null";
            // 
            // OpenWindow
            // 
            this.OpenWindow.AutoSize = true;
            this.OpenWindow.Location = new System.Drawing.Point(118, 22);
            this.OpenWindow.Name = "OpenWindow";
            this.OpenWindow.Size = new System.Drawing.Size(97, 17);
            this.OpenWindow.TabIndex = 28;
            this.OpenWindow.Text = "Открыть окно";
            this.OpenWindow.UseVisualStyleBackColor = true;
            this.OpenWindow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OpenWindow_MouseClick);
            // 
            // HumidityHot
            // 
            this.HumidityHot.AutoSize = true;
            this.HumidityHot.Location = new System.Drawing.Point(41, 201);
            this.HumidityHot.Name = "HumidityHot";
            this.HumidityHot.Size = new System.Drawing.Size(75, 13);
            this.HumidityHot.TabIndex = 3;
            this.HumidityHot.Text = "Подоконник: ";
            // 
            // HumiditySr
            // 
            this.HumiditySr.AutoSize = true;
            this.HumiditySr.Location = new System.Drawing.Point(41, 159);
            this.HumiditySr.Name = "HumiditySr";
            this.HumiditySr.Size = new System.Drawing.Size(56, 13);
            this.HumiditySr.TabIndex = 1;
            this.HumiditySr.Text = "Средняя: ";
            // 
            // HumidityWindow
            // 
            this.HumidityWindow.AutoSize = true;
            this.HumidityWindow.Location = new System.Drawing.Point(41, 180);
            this.HumidityWindow.Name = "HumidityWindow";
            this.HumidityWindow.Size = new System.Drawing.Size(39, 13);
            this.HumidityWindow.TabIndex = 2;
            this.HumidityWindow.Text = "Окно: ";
            // 
            // HumidityWindowV
            // 
            this.HumidityWindowV.AutoSize = true;
            this.HumidityWindowV.Location = new System.Drawing.Point(124, 180);
            this.HumidityWindowV.Name = "HumidityWindowV";
            this.HumidityWindowV.Size = new System.Drawing.Size(23, 13);
            this.HumidityWindowV.TabIndex = 34;
            this.HumidityWindowV.Text = "null";
            // 
            // HumidityHotV
            // 
            this.HumidityHotV.AutoSize = true;
            this.HumidityHotV.Location = new System.Drawing.Point(124, 201);
            this.HumidityHotV.Name = "HumidityHotV";
            this.HumidityHotV.Size = new System.Drawing.Size(23, 13);
            this.HumidityHotV.TabIndex = 35;
            this.HumidityHotV.Text = "null";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 293);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Climate Control for Arduino";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label HotTempV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Angle;
        private System.Windows.Forms.Label AngleV;
        private System.Windows.Forms.Label Closed;
        private System.Windows.Forms.Label ClosedV;
        private System.Windows.Forms.Label HotTemp;
        private System.Windows.Forms.Label WindowTemp;
        private System.Windows.Forms.Label SrTemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox CloseWindow;
        private System.Windows.Forms.Label HumiditySrV;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label WindowTempV;
        public System.Windows.Forms.Label SrTempV;
        private System.Windows.Forms.Label CycleV;
        private System.Windows.Forms.Label Cycle;
        private System.Windows.Forms.Button TurnOn;
        private System.Windows.Forms.Button TurnOff;
        private System.Windows.Forms.Label NeedTemp;
        private System.Windows.Forms.Label Cycles;
        private System.Windows.Forms.Label CyclesV;
        private System.Windows.Forms.Label NeedTempV;
        private System.Windows.Forms.Button TempPlus;
        private System.Windows.Forms.Button TempMinus;
        private System.Windows.Forms.Button CycleMinus;
        private System.Windows.Forms.Button CyclePlus;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label CycleAllV;
        private System.Windows.Forms.Label CycleAll;
        private System.Windows.Forms.Label CycleComplV;
        private System.Windows.Forms.Label CycleCompl;
        private System.Windows.Forms.Label OpenedV;
        private System.Windows.Forms.Label Opened;
        private System.Windows.Forms.CheckBox OpenWindow;
        private System.Windows.Forms.Label HumidityHotV;
        private System.Windows.Forms.Label HumidityWindowV;
        private System.Windows.Forms.Label HumidityWindow;
        private System.Windows.Forms.Label HumiditySr;
        private System.Windows.Forms.Label HumidityHot;
    }
}

