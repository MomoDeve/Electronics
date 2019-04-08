namespace Electronic
{
    partial class MainForm
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
            this.mainGrid = new System.Windows.Forms.PictureBox();
            this.gridContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FiltersLabel = new System.Windows.Forms.Label();
            this.NorElementSelectButton = new System.Windows.Forms.RadioButton();
            this.NandElementSelectButton = new System.Windows.Forms.RadioButton();
            this.DownFilterSelectButton = new System.Windows.Forms.RadioButton();
            this.UpFilterSelectButton = new System.Windows.Forms.RadioButton();
            this.LeftFilterSelectButton = new System.Windows.Forms.RadioButton();
            this.RightFilterSelectButton = new System.Windows.Forms.RadioButton();
            this.EqElementSelectButton = new System.Windows.Forms.RadioButton();
            this.XorElementSelectButton = new System.Windows.Forms.RadioButton();
            this.OrElementSelectButton = new System.Windows.Forms.RadioButton();
            this.AndElementSelectButton = new System.Windows.Forms.RadioButton();
            this.NotElementSelectButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.radioButton16 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton17 = new System.Windows.Forms.RadioButton();
            this.radioButton18 = new System.Windows.Forms.RadioButton();
            this.radioButton19 = new System.Windows.Forms.RadioButton();
            this.radioButton20 = new System.Windows.Forms.RadioButton();
            this.radioButton21 = new System.Windows.Forms.RadioButton();
            this.radioButton22 = new System.Windows.Forms.RadioButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.FilterSelectButton = new System.Windows.Forms.RadioButton();
            this.NotSelectButton = new System.Windows.Forms.RadioButton();
            this.LogicalElementsLabel = new System.Windows.Forms.Label();
            this.TimerSelectButton = new System.Windows.Forms.RadioButton();
            this.BridgeSelectButton = new System.Windows.Forms.RadioButton();
            this.PowerElementsLabel = new System.Windows.Forms.Label();
            this.BasicElementsLabel = new System.Windows.Forms.Label();
            this.SwitcherSelectButton = new System.Windows.Forms.RadioButton();
            this.BulbSelectButton = new System.Windows.Forms.RadioButton();
            this.TickGeneratorSelectButton = new System.Windows.Forms.RadioButton();
            this.EraserSelectButton = new System.Windows.Forms.RadioButton();
            this.GeneratorSelectButton = new System.Windows.Forms.RadioButton();
            this.WireSelectButton = new System.Windows.Forms.RadioButton();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.MenuItems = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).BeginInit();
            this.gridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainGrid
            // 
            this.mainGrid.BackColor = System.Drawing.Color.DimGray;
            this.mainGrid.Location = new System.Drawing.Point(3, 3);
            this.mainGrid.Name = "mainGrid";
            this.mainGrid.Size = new System.Drawing.Size(2048, 2048);
            this.mainGrid.TabIndex = 0;
            this.mainGrid.TabStop = false;
            this.mainGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.mainGrid_Paint);
            this.mainGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainGrid_MouseDown);
            this.mainGrid.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainGrid_MouseMove);
            // 
            // gridContainer
            // 
            this.gridContainer.AutoScroll = true;
            this.gridContainer.AutoSize = true;
            this.gridContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gridContainer.Controls.Add(this.mainGrid);
            this.gridContainer.Location = new System.Drawing.Point(3, 3);
            this.gridContainer.Name = "gridContainer";
            this.gridContainer.Size = new System.Drawing.Size(2054, 2054);
            this.gridContainer.TabIndex = 1;
            // 
            // splitContainer
            // 
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(2, 27);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.AutoScroll = true;
            this.splitContainer.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer.Panel1.Controls.Add(this.groupBox);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.AutoScroll = true;
            this.splitContainer.Panel2.Controls.Add(this.gridContainer);
            this.splitContainer.Size = new System.Drawing.Size(1835, 968);
            this.splitContainer.SplitterDistance = 174;
            this.splitContainer.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FiltersLabel);
            this.groupBox1.Controls.Add(this.NorElementSelectButton);
            this.groupBox1.Controls.Add(this.NandElementSelectButton);
            this.groupBox1.Controls.Add(this.DownFilterSelectButton);
            this.groupBox1.Controls.Add(this.UpFilterSelectButton);
            this.groupBox1.Controls.Add(this.LeftFilterSelectButton);
            this.groupBox1.Controls.Add(this.RightFilterSelectButton);
            this.groupBox1.Controls.Add(this.EqElementSelectButton);
            this.groupBox1.Controls.Add(this.XorElementSelectButton);
            this.groupBox1.Controls.Add(this.OrElementSelectButton);
            this.groupBox1.Controls.Add(this.AndElementSelectButton);
            this.groupBox1.Controls.Add(this.NotElementSelectButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButton15);
            this.groupBox1.Controls.Add(this.radioButton16);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.radioButton17);
            this.groupBox1.Controls.Add(this.radioButton18);
            this.groupBox1.Controls.Add(this.radioButton19);
            this.groupBox1.Controls.Add(this.radioButton20);
            this.groupBox1.Controls.Add(this.radioButton21);
            this.groupBox1.Controls.Add(this.radioButton22);
            this.groupBox1.Location = new System.Drawing.Point(10, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 610);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elements";
            // 
            // FiltersLabel
            // 
            this.FiltersLabel.AutoSize = true;
            this.FiltersLabel.Location = new System.Drawing.Point(3, 427);
            this.FiltersLabel.Name = "FiltersLabel";
            this.FiltersLabel.Size = new System.Drawing.Size(34, 13);
            this.FiltersLabel.TabIndex = 13;
            this.FiltersLabel.Text = "Filters";
            // 
            // NorElementSelectButton
            // 
            this.NorElementSelectButton.AutoSize = true;
            this.NorElementSelectButton.Location = new System.Drawing.Point(6, 395);
            this.NorElementSelectButton.Name = "NorElementSelectButton";
            this.NorElementSelectButton.Size = new System.Drawing.Size(90, 17);
            this.NorElementSelectButton.TabIndex = 12;
            this.NorElementSelectButton.TabStop = true;
            this.NorElementSelectButton.Tag = "NorElement";
            this.NorElementSelectButton.Text = "NOR Element";
            this.NorElementSelectButton.UseVisualStyleBackColor = true;
            this.NorElementSelectButton.CheckedChanged += new System.EventHandler(this.ElementSelectButton_click);
            // 
            // NandElementSelectButton
            // 
            this.NandElementSelectButton.AutoSize = true;
            this.NandElementSelectButton.Location = new System.Drawing.Point(6, 372);
            this.NandElementSelectButton.Name = "NandElementSelectButton";
            this.NandElementSelectButton.Size = new System.Drawing.Size(97, 17);
            this.NandElementSelectButton.TabIndex = 12;
            this.NandElementSelectButton.TabStop = true;
            this.NandElementSelectButton.Tag = "NandElement";
            this.NandElementSelectButton.Text = "NAND Element";
            this.NandElementSelectButton.UseVisualStyleBackColor = true;
            this.NandElementSelectButton.CheckedChanged += new System.EventHandler(this.ElementSelectButton_click);
            // 
            // DownFilterSelectButton
            // 
            this.DownFilterSelectButton.AutoSize = true;
            this.DownFilterSelectButton.Location = new System.Drawing.Point(6, 512);
            this.DownFilterSelectButton.Name = "DownFilterSelectButton";
            this.DownFilterSelectButton.Size = new System.Drawing.Size(78, 17);
            this.DownFilterSelectButton.TabIndex = 12;
            this.DownFilterSelectButton.TabStop = true;
            this.DownFilterSelectButton.Tag = "DownFilter";
            this.DownFilterSelectButton.Text = "Down Filter";
            this.DownFilterSelectButton.UseVisualStyleBackColor = true;
            this.DownFilterSelectButton.CheckedChanged += new System.EventHandler(this.ElementSelectButton_click);
            // 
            // UpFilterSelectButton
            // 
            this.UpFilterSelectButton.AutoSize = true;
            this.UpFilterSelectButton.Location = new System.Drawing.Point(6, 489);
            this.UpFilterSelectButton.Name = "UpFilterSelectButton";
            this.UpFilterSelectButton.Size = new System.Drawing.Size(64, 17);
            this.UpFilterSelectButton.TabIndex = 12;
            this.UpFilterSelectButton.TabStop = true;
            this.UpFilterSelectButton.Tag = "UpFilter";
            this.UpFilterSelectButton.Text = "Up Filter";
            this.UpFilterSelectButton.UseVisualStyleBackColor = true;
            this.UpFilterSelectButton.CheckedChanged += new System.EventHandler(this.ElementSelectButton_click);
            // 
            // LeftFilterSelectButton
            // 
            this.LeftFilterSelectButton.AutoSize = true;
            this.LeftFilterSelectButton.Location = new System.Drawing.Point(6, 443);
            this.LeftFilterSelectButton.Name = "LeftFilterSelectButton";
            this.LeftFilterSelectButton.Size = new System.Drawing.Size(68, 17);
            this.LeftFilterSelectButton.TabIndex = 12;
            this.LeftFilterSelectButton.TabStop = true;
            this.LeftFilterSelectButton.Tag = "LeftFilter";
            this.LeftFilterSelectButton.Text = "Left Filter";
            this.LeftFilterSelectButton.UseVisualStyleBackColor = true;
            this.LeftFilterSelectButton.CheckedChanged += new System.EventHandler(this.ElementSelectButton_click);
            // 
            // RightFilterSelectButton
            // 
            this.RightFilterSelectButton.AutoSize = true;
            this.RightFilterSelectButton.Location = new System.Drawing.Point(6, 466);
            this.RightFilterSelectButton.Name = "RightFilterSelectButton";
            this.RightFilterSelectButton.Size = new System.Drawing.Size(75, 17);
            this.RightFilterSelectButton.TabIndex = 11;
            this.RightFilterSelectButton.TabStop = true;
            this.RightFilterSelectButton.Tag = "RightFilter";
            this.RightFilterSelectButton.Text = "Right Filter";
            this.RightFilterSelectButton.UseVisualStyleBackColor = true;
            this.RightFilterSelectButton.CheckedChanged += new System.EventHandler(this.ElementSelectButton_click);
            // 
            // EqElementSelectButton
            // 
            this.EqElementSelectButton.AutoSize = true;
            this.EqElementSelectButton.Location = new System.Drawing.Point(6, 349);
            this.EqElementSelectButton.Name = "EqElementSelectButton";
            this.EqElementSelectButton.Size = new System.Drawing.Size(81, 17);
            this.EqElementSelectButton.TabIndex = 12;
            this.EqElementSelectButton.TabStop = true;
            this.EqElementSelectButton.Tag = "EqElement";
            this.EqElementSelectButton.Text = "EQ Element";
            this.EqElementSelectButton.UseVisualStyleBackColor = true;
            this.EqElementSelectButton.CheckedChanged += new System.EventHandler(this.ElementSelectButton_click);
            // 
            // XorElementSelectButton
            // 
            this.XorElementSelectButton.AutoSize = true;
            this.XorElementSelectButton.Location = new System.Drawing.Point(6, 326);
            this.XorElementSelectButton.Name = "XorElementSelectButton";
            this.XorElementSelectButton.Size = new System.Drawing.Size(89, 17);
            this.XorElementSelectButton.TabIndex = 12;
            this.XorElementSelectButton.TabStop = true;
            this.XorElementSelectButton.Tag = "XorElement";
            this.XorElementSelectButton.Text = "XOR Element";
            this.XorElementSelectButton.UseVisualStyleBackColor = true;
            this.XorElementSelectButton.CheckedChanged += new System.EventHandler(this.ElementSelectButton_click);
            // 
            // OrElementSelectButton
            // 
            this.OrElementSelectButton.AutoSize = true;
            this.OrElementSelectButton.Location = new System.Drawing.Point(6, 303);
            this.OrElementSelectButton.Name = "OrElementSelectButton";
            this.OrElementSelectButton.Size = new System.Drawing.Size(82, 17);
            this.OrElementSelectButton.TabIndex = 12;
            this.OrElementSelectButton.TabStop = true;
            this.OrElementSelectButton.Tag = "OrElement";
            this.OrElementSelectButton.Text = "OR Element";
            this.OrElementSelectButton.UseVisualStyleBackColor = true;
            this.OrElementSelectButton.CheckedChanged += new System.EventHandler(this.ElementSelectButton_click);
            // 
            // AndElementSelectButton
            // 
            this.AndElementSelectButton.AutoSize = true;
            this.AndElementSelectButton.Location = new System.Drawing.Point(6, 280);
            this.AndElementSelectButton.Name = "AndElementSelectButton";
            this.AndElementSelectButton.Size = new System.Drawing.Size(89, 17);
            this.AndElementSelectButton.TabIndex = 12;
            this.AndElementSelectButton.TabStop = true;
            this.AndElementSelectButton.Tag = "AndElement";
            this.AndElementSelectButton.Text = "AND Element";
            this.AndElementSelectButton.UseVisualStyleBackColor = true;
            this.AndElementSelectButton.CheckedChanged += new System.EventHandler(this.ElementSelectButton_click);
            // 
            // NotElementSelectButton
            // 
            this.NotElementSelectButton.AutoSize = true;
            this.NotElementSelectButton.Location = new System.Drawing.Point(6, 257);
            this.NotElementSelectButton.Name = "NotElementSelectButton";
            this.NotElementSelectButton.Size = new System.Drawing.Size(89, 17);
            this.NotElementSelectButton.TabIndex = 10;
            this.NotElementSelectButton.TabStop = true;
            this.NotElementSelectButton.Tag = "NotElement";
            this.NotElementSelectButton.Text = "NOT Element";
            this.NotElementSelectButton.UseVisualStyleBackColor = true;
            this.NotElementSelectButton.CheckedChanged += new System.EventHandler(this.ElementSelectButton_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Logical Elements";
            // 
            // radioButton15
            // 
            this.radioButton15.AutoSize = true;
            this.radioButton15.Location = new System.Drawing.Point(6, 145);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(51, 17);
            this.radioButton15.TabIndex = 8;
            this.radioButton15.TabStop = true;
            this.radioButton15.Tag = "Timer";
            this.radioButton15.Text = "Timer";
            this.radioButton15.UseVisualStyleBackColor = true;
            this.radioButton15.CheckedChanged += new System.EventHandler(this.ElementSelectButton_click);
            // 
            // radioButton16
            // 
            this.radioButton16.AutoSize = true;
            this.radioButton16.Location = new System.Drawing.Point(6, 101);
            this.radioButton16.Name = "radioButton16";
            this.radioButton16.Size = new System.Drawing.Size(55, 17);
            this.radioButton16.TabIndex = 7;
            this.radioButton16.TabStop = true;
            this.radioButton16.Tag = "Bridge";
            this.radioButton16.Text = "Bridge";
            this.radioButton16.UseVisualStyleBackColor = true;
            this.radioButton16.CheckedChanged += new System.EventHandler(this.ElementSelectButton_click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Power Elements";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Basic Elements";
            // 
            // radioButton17
            // 
            this.radioButton17.AutoSize = true;
            this.radioButton17.Location = new System.Drawing.Point(6, 214);
            this.radioButton17.Name = "radioButton17";
            this.radioButton17.Size = new System.Drawing.Size(66, 17);
            this.radioButton17.TabIndex = 4;
            this.radioButton17.TabStop = true;
            this.radioButton17.Tag = "Switcher";
            this.radioButton17.Text = "Switcher";
            this.radioButton17.UseVisualStyleBackColor = true;
            this.radioButton17.CheckedChanged += new System.EventHandler(this.ElementSelectButton_click);
            // 
            // radioButton18
            // 
            this.radioButton18.AutoSize = true;
            this.radioButton18.Location = new System.Drawing.Point(6, 78);
            this.radioButton18.Name = "radioButton18";
            this.radioButton18.Size = new System.Drawing.Size(46, 17);
            this.radioButton18.TabIndex = 3;
            this.radioButton18.TabStop = true;
            this.radioButton18.Tag = "Bulb";
            this.radioButton18.Text = "Bulb";
            this.radioButton18.UseVisualStyleBackColor = true;
            this.radioButton18.CheckedChanged += new System.EventHandler(this.ElementSelectButton_click);
            // 
            // radioButton19
            // 
            this.radioButton19.AutoSize = true;
            this.radioButton19.Location = new System.Drawing.Point(6, 191);
            this.radioButton19.Name = "radioButton19";
            this.radioButton19.Size = new System.Drawing.Size(96, 17);
            this.radioButton19.TabIndex = 3;
            this.radioButton19.TabStop = true;
            this.radioButton19.Tag = "TickGenerator";
            this.radioButton19.Text = "Tick Generator";
            this.radioButton19.UseVisualStyleBackColor = true;
            this.radioButton19.CheckedChanged += new System.EventHandler(this.ElementSelectButton_click);
            // 
            // radioButton20
            // 
            this.radioButton20.AutoSize = true;
            this.radioButton20.Location = new System.Drawing.Point(6, 32);
            this.radioButton20.Name = "radioButton20";
            this.radioButton20.Size = new System.Drawing.Size(55, 17);
            this.radioButton20.TabIndex = 2;
            this.radioButton20.Text = "Eraser";
            this.radioButton20.UseVisualStyleBackColor = true;
            this.radioButton20.CheckedChanged += new System.EventHandler(this.ElementSelectButton_click);
            // 
            // radioButton21
            // 
            this.radioButton21.AutoSize = true;
            this.radioButton21.Location = new System.Drawing.Point(6, 168);
            this.radioButton21.Name = "radioButton21";
            this.radioButton21.Size = new System.Drawing.Size(72, 17);
            this.radioButton21.TabIndex = 1;
            this.radioButton21.Tag = "Generator";
            this.radioButton21.Text = "Generator";
            this.radioButton21.UseVisualStyleBackColor = true;
            this.radioButton21.CheckedChanged += new System.EventHandler(this.ElementSelectButton_click);
            // 
            // radioButton22
            // 
            this.radioButton22.AutoSize = true;
            this.radioButton22.Checked = true;
            this.radioButton22.Location = new System.Drawing.Point(6, 55);
            this.radioButton22.Name = "radioButton22";
            this.radioButton22.Size = new System.Drawing.Size(47, 17);
            this.radioButton22.TabIndex = 0;
            this.radioButton22.TabStop = true;
            this.radioButton22.Tag = "Wire";
            this.radioButton22.Text = "Wire";
            this.radioButton22.UseVisualStyleBackColor = true;
            this.radioButton22.CheckedChanged += new System.EventHandler(this.ElementSelectButton_click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radioButton6);
            this.groupBox.Controls.Add(this.radioButton5);
            this.groupBox.Controls.Add(this.radioButton4);
            this.groupBox.Controls.Add(this.radioButton3);
            this.groupBox.Controls.Add(this.radioButton2);
            this.groupBox.Controls.Add(this.radioButton1);
            this.groupBox.Controls.Add(this.FilterSelectButton);
            this.groupBox.Controls.Add(this.NotSelectButton);
            this.groupBox.Controls.Add(this.LogicalElementsLabel);
            this.groupBox.Controls.Add(this.TimerSelectButton);
            this.groupBox.Controls.Add(this.BridgeSelectButton);
            this.groupBox.Controls.Add(this.PowerElementsLabel);
            this.groupBox.Controls.Add(this.BasicElementsLabel);
            this.groupBox.Controls.Add(this.SwitcherSelectButton);
            this.groupBox.Controls.Add(this.BulbSelectButton);
            this.groupBox.Controls.Add(this.TickGeneratorSelectButton);
            this.groupBox.Controls.Add(this.EraserSelectButton);
            this.groupBox.Controls.Add(this.GeneratorSelectButton);
            this.groupBox.Controls.Add(this.WireSelectButton);
            this.groupBox.Location = new System.Drawing.Point(10, 6);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(160, 460);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Elements";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 407);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(85, 17);
            this.radioButton6.TabIndex = 12;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "radioButton1";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 384);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(85, 17);
            this.radioButton5.TabIndex = 12;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "radioButton1";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 361);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 12;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton1";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 338);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton1";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 338);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton1";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 315);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // FilterSelectButton
            // 
            this.FilterSelectButton.AutoSize = true;
            this.FilterSelectButton.Location = new System.Drawing.Point(6, 125);
            this.FilterSelectButton.Name = "FilterSelectButton";
            this.FilterSelectButton.Size = new System.Drawing.Size(47, 17);
            this.FilterSelectButton.TabIndex = 11;
            this.FilterSelectButton.TabStop = true;
            this.FilterSelectButton.Tag = "Filter";
            this.FilterSelectButton.Text = "Filter";
            this.FilterSelectButton.UseVisualStyleBackColor = true;
            this.FilterSelectButton.CheckedChanged += new System.EventHandler(this.ElementSelectButton_click);
            // 
            // NotSelectButton
            // 
            this.NotSelectButton.AutoSize = true;
            this.NotSelectButton.Location = new System.Drawing.Point(6, 292);
            this.NotSelectButton.Name = "NotSelectButton";
            this.NotSelectButton.Size = new System.Drawing.Size(83, 17);
            this.NotSelectButton.TabIndex = 10;
            this.NotSelectButton.TabStop = true;
            this.NotSelectButton.Tag = "NotElement";
            this.NotSelectButton.Text = "Not Element";
            this.NotSelectButton.UseVisualStyleBackColor = true;
            this.NotSelectButton.CheckedChanged += new System.EventHandler(this.ElementSelectButton_click);
            // 
            // LogicalElementsLabel
            // 
            this.LogicalElementsLabel.AutoSize = true;
            this.LogicalElementsLabel.Location = new System.Drawing.Point(3, 276);
            this.LogicalElementsLabel.Name = "LogicalElementsLabel";
            this.LogicalElementsLabel.Size = new System.Drawing.Size(87, 13);
            this.LogicalElementsLabel.TabIndex = 9;
            this.LogicalElementsLabel.Text = "Logical Elements";
            // 
            // TimerSelectButton
            // 
            this.TimerSelectButton.AutoSize = true;
            this.TimerSelectButton.Location = new System.Drawing.Point(6, 177);
            this.TimerSelectButton.Name = "TimerSelectButton";
            this.TimerSelectButton.Size = new System.Drawing.Size(51, 17);
            this.TimerSelectButton.TabIndex = 8;
            this.TimerSelectButton.TabStop = true;
            this.TimerSelectButton.Tag = "Timer";
            this.TimerSelectButton.Text = "Timer";
            this.TimerSelectButton.UseVisualStyleBackColor = true;
            this.TimerSelectButton.CheckedChanged += new System.EventHandler(this.ElementSelectButton_click);
            // 
            // BridgeSelectButton
            // 
            this.BridgeSelectButton.AutoSize = true;
            this.BridgeSelectButton.Location = new System.Drawing.Point(6, 101);
            this.BridgeSelectButton.Name = "BridgeSelectButton";
            this.BridgeSelectButton.Size = new System.Drawing.Size(55, 17);
            this.BridgeSelectButton.TabIndex = 7;
            this.BridgeSelectButton.TabStop = true;
            this.BridgeSelectButton.Tag = "Bridge";
            this.BridgeSelectButton.Text = "Bridge";
            this.BridgeSelectButton.UseVisualStyleBackColor = true;
            this.BridgeSelectButton.CheckedChanged += new System.EventHandler(this.ElementSelectButton_click);
            // 
            // PowerElementsLabel
            // 
            this.PowerElementsLabel.AutoSize = true;
            this.PowerElementsLabel.Location = new System.Drawing.Point(6, 161);
            this.PowerElementsLabel.Name = "PowerElementsLabel";
            this.PowerElementsLabel.Size = new System.Drawing.Size(83, 13);
            this.PowerElementsLabel.TabIndex = 6;
            this.PowerElementsLabel.Text = "Power Elements";
            // 
            // BasicElementsLabel
            // 
            this.BasicElementsLabel.AutoSize = true;
            this.BasicElementsLabel.Location = new System.Drawing.Point(3, 16);
            this.BasicElementsLabel.Name = "BasicElementsLabel";
            this.BasicElementsLabel.Size = new System.Drawing.Size(79, 13);
            this.BasicElementsLabel.TabIndex = 5;
            this.BasicElementsLabel.Text = "Basic Elements";
            // 
            // SwitcherSelectButton
            // 
            this.SwitcherSelectButton.AutoSize = true;
            this.SwitcherSelectButton.Location = new System.Drawing.Point(6, 244);
            this.SwitcherSelectButton.Name = "SwitcherSelectButton";
            this.SwitcherSelectButton.Size = new System.Drawing.Size(66, 17);
            this.SwitcherSelectButton.TabIndex = 4;
            this.SwitcherSelectButton.TabStop = true;
            this.SwitcherSelectButton.Tag = "Switcher";
            this.SwitcherSelectButton.Text = "Switcher";
            this.SwitcherSelectButton.UseVisualStyleBackColor = true;
            this.SwitcherSelectButton.CheckedChanged += new System.EventHandler(this.ElementSelectButton_click);
            // 
            // BulbSelectButton
            // 
            this.BulbSelectButton.AutoSize = true;
            this.BulbSelectButton.Location = new System.Drawing.Point(6, 78);
            this.BulbSelectButton.Name = "BulbSelectButton";
            this.BulbSelectButton.Size = new System.Drawing.Size(46, 17);
            this.BulbSelectButton.TabIndex = 3;
            this.BulbSelectButton.TabStop = true;
            this.BulbSelectButton.Tag = "Bulb";
            this.BulbSelectButton.Text = "Bulb";
            this.BulbSelectButton.UseVisualStyleBackColor = true;
            this.BulbSelectButton.CheckedChanged += new System.EventHandler(this.ElementSelectButton_click);
            // 
            // TickGeneratorSelectButton
            // 
            this.TickGeneratorSelectButton.AutoSize = true;
            this.TickGeneratorSelectButton.Location = new System.Drawing.Point(6, 221);
            this.TickGeneratorSelectButton.Name = "TickGeneratorSelectButton";
            this.TickGeneratorSelectButton.Size = new System.Drawing.Size(96, 17);
            this.TickGeneratorSelectButton.TabIndex = 3;
            this.TickGeneratorSelectButton.TabStop = true;
            this.TickGeneratorSelectButton.Tag = "TickGenerator";
            this.TickGeneratorSelectButton.Text = "Tick Generator";
            this.TickGeneratorSelectButton.UseVisualStyleBackColor = true;
            this.TickGeneratorSelectButton.CheckedChanged += new System.EventHandler(this.ElementSelectButton_click);
            // 
            // EraserSelectButton
            // 
            this.EraserSelectButton.AutoSize = true;
            this.EraserSelectButton.Location = new System.Drawing.Point(6, 32);
            this.EraserSelectButton.Name = "EraserSelectButton";
            this.EraserSelectButton.Size = new System.Drawing.Size(55, 17);
            this.EraserSelectButton.TabIndex = 2;
            this.EraserSelectButton.Text = "Eraser";
            this.EraserSelectButton.UseVisualStyleBackColor = true;
            this.EraserSelectButton.CheckedChanged += new System.EventHandler(this.ElementSelectButton_click);
            // 
            // GeneratorSelectButton
            // 
            this.GeneratorSelectButton.AutoSize = true;
            this.GeneratorSelectButton.Location = new System.Drawing.Point(6, 198);
            this.GeneratorSelectButton.Name = "GeneratorSelectButton";
            this.GeneratorSelectButton.Size = new System.Drawing.Size(72, 17);
            this.GeneratorSelectButton.TabIndex = 1;
            this.GeneratorSelectButton.Tag = "Generator";
            this.GeneratorSelectButton.Text = "Generator";
            this.GeneratorSelectButton.UseVisualStyleBackColor = true;
            this.GeneratorSelectButton.CheckedChanged += new System.EventHandler(this.ElementSelectButton_click);
            // 
            // WireSelectButton
            // 
            this.WireSelectButton.AutoSize = true;
            this.WireSelectButton.Checked = true;
            this.WireSelectButton.Location = new System.Drawing.Point(6, 55);
            this.WireSelectButton.Name = "WireSelectButton";
            this.WireSelectButton.Size = new System.Drawing.Size(47, 17);
            this.WireSelectButton.TabIndex = 0;
            this.WireSelectButton.TabStop = true;
            this.WireSelectButton.Tag = "Wire";
            this.WireSelectButton.Text = "Wire";
            this.WireSelectButton.UseVisualStyleBackColor = true;
            this.WireSelectButton.CheckedChanged += new System.EventHandler(this.ElementSelectButton_click);
            // 
            // mainTimer
            // 
            this.mainTimer.Enabled = true;
            this.mainTimer.Interval = 500;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // MenuItems
            // 
            this.MenuItems.Location = new System.Drawing.Point(0, 0);
            this.MenuItems.Name = "MenuItems";
            this.MenuItems.Size = new System.Drawing.Size(1904, 24);
            this.MenuItems.TabIndex = 4;
            this.MenuItems.Text = "menuStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.MenuItems);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MainMenuStrip = this.MenuItems;
            this.Name = "MainForm";
            this.Text = "Electronic app";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).EndInit();
            this.gridContainer.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainGrid;
        private System.Windows.Forms.FlowLayoutPanel gridContainer;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.RadioButton GeneratorSelectButton;
        private System.Windows.Forms.RadioButton WireSelectButton;
        private System.Windows.Forms.RadioButton EraserSelectButton;
        private System.Windows.Forms.RadioButton TickGeneratorSelectButton;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.RadioButton SwitcherSelectButton;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton BulbSelectButton;
        private System.Windows.Forms.MenuStrip MenuItems;
        private System.Windows.Forms.Label PowerElementsLabel;
        private System.Windows.Forms.Label BasicElementsLabel;
        private System.Windows.Forms.RadioButton BridgeSelectButton;
        private System.Windows.Forms.RadioButton TimerSelectButton;
        private System.Windows.Forms.RadioButton NotSelectButton;
        private System.Windows.Forms.Label LogicalElementsLabel;
        private System.Windows.Forms.RadioButton FilterSelectButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton NorElementSelectButton;
        private System.Windows.Forms.RadioButton NandElementSelectButton;
        private System.Windows.Forms.RadioButton EqElementSelectButton;
        private System.Windows.Forms.RadioButton XorElementSelectButton;
        private System.Windows.Forms.RadioButton OrElementSelectButton;
        private System.Windows.Forms.RadioButton LeftFilterSelectButton;
        private System.Windows.Forms.RadioButton AndElementSelectButton;
        private System.Windows.Forms.RadioButton RightFilterSelectButton;
        private System.Windows.Forms.RadioButton NotElementSelectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton15;
        private System.Windows.Forms.RadioButton radioButton16;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton17;
        private System.Windows.Forms.RadioButton radioButton18;
        private System.Windows.Forms.RadioButton radioButton19;
        private System.Windows.Forms.RadioButton radioButton20;
        private System.Windows.Forms.RadioButton radioButton21;
        private System.Windows.Forms.RadioButton radioButton22;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton DownFilterSelectButton;
        private System.Windows.Forms.RadioButton UpFilterSelectButton;
        private System.Windows.Forms.Label FiltersLabel;
    }
}

