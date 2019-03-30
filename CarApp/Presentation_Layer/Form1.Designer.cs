namespace CarApp {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
                }
            base.Dispose(disposing);
            }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblMainLabel = new System.Windows.Forms.Label();
            this.cbVehicleChooser = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDoors = new System.Windows.Forms.Label();
            this.tbDoors = new System.Windows.Forms.TextBox();
            this.lblEngine = new System.Windows.Forms.Label();
            this.tbEngineSize = new System.Windows.Forms.TextBox();
            this.lblShape = new System.Windows.Forms.Label();
            this.lblSeats = new System.Windows.Forms.Label();
            this.lblFuel = new System.Windows.Forms.Label();
            this.lblAutomatic = new System.Windows.Forms.Label();
            this.tbSeats = new System.Windows.Forms.TextBox();
            this.tbBodyShape = new System.Windows.Forms.TextBox();
            this.tbFuel = new System.Windows.Forms.TextBox();
            this.tbAuto = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cbMake = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.btnQuote = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbQuote = new System.Windows.Forms.TextBox();
            this.tbReg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMainLabel
            // 
            this.lblMainLabel.AutoSize = true;
            this.lblMainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblMainLabel.Location = new System.Drawing.Point(160, 0);
            this.lblMainLabel.Name = "lblMainLabel";
            this.lblMainLabel.Size = new System.Drawing.Size(126, 24);
            this.lblMainLabel.TabIndex = 0;
            this.lblMainLabel.Text = "Vehicle Hire";
            this.lblMainLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbVehicleChooser
            // 
            this.cbVehicleChooser.FormattingEnabled = true;
            this.cbVehicleChooser.Items.AddRange(new object[] {
            "Car",
            "Van"});
            this.cbVehicleChooser.Location = new System.Drawing.Point(12, 22);
            this.cbVehicleChooser.Name = "cbVehicleChooser";
            this.cbVehicleChooser.Size = new System.Drawing.Size(88, 21);
            this.cbVehicleChooser.TabIndex = 1;
            this.cbVehicleChooser.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 81);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(88, 147);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(428, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDoors
            // 
            this.lblDoors.AutoSize = true;
            this.lblDoors.Location = new System.Drawing.Point(122, 30);
            this.lblDoors.Name = "lblDoors";
            this.lblDoors.Size = new System.Drawing.Size(35, 13);
            this.lblDoors.TabIndex = 5;
            this.lblDoors.Text = "Doors";
            // 
            // tbDoors
            // 
            this.tbDoors.Location = new System.Drawing.Point(213, 30);
            this.tbDoors.Name = "tbDoors";
            this.tbDoors.Size = new System.Drawing.Size(54, 20);
            this.tbDoors.TabIndex = 6;
            // 
            // lblEngine
            // 
            this.lblEngine.AutoSize = true;
            this.lblEngine.Location = new System.Drawing.Point(122, 107);
            this.lblEngine.Name = "lblEngine";
            this.lblEngine.Size = new System.Drawing.Size(61, 13);
            this.lblEngine.TabIndex = 7;
            this.lblEngine.Text = "Engine size";
            // 
            // tbEngineSize
            // 
            this.tbEngineSize.Location = new System.Drawing.Point(213, 107);
            this.tbEngineSize.Name = "tbEngineSize";
            this.tbEngineSize.Size = new System.Drawing.Size(54, 20);
            this.tbEngineSize.TabIndex = 8;
            // 
            // lblShape
            // 
            this.lblShape.AutoSize = true;
            this.lblShape.Location = new System.Drawing.Point(122, 81);
            this.lblShape.Name = "lblShape";
            this.lblShape.Size = new System.Drawing.Size(63, 13);
            this.lblShape.TabIndex = 9;
            this.lblShape.Text = "Body shape";
            this.lblShape.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblSeats
            // 
            this.lblSeats.AutoSize = true;
            this.lblSeats.Location = new System.Drawing.Point(122, 53);
            this.lblSeats.Name = "lblSeats";
            this.lblSeats.Size = new System.Drawing.Size(34, 13);
            this.lblSeats.TabIndex = 10;
            this.lblSeats.Text = "Seats";
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Location = new System.Drawing.Point(122, 136);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(27, 13);
            this.lblFuel.TabIndex = 11;
            this.lblFuel.Text = "Fuel";
            // 
            // lblAutomatic
            // 
            this.lblAutomatic.AutoSize = true;
            this.lblAutomatic.Location = new System.Drawing.Point(122, 166);
            this.lblAutomatic.Name = "lblAutomatic";
            this.lblAutomatic.Size = new System.Drawing.Size(54, 13);
            this.lblAutomatic.TabIndex = 12;
            this.lblAutomatic.Text = "Automatic";
            // 
            // tbSeats
            // 
            this.tbSeats.Location = new System.Drawing.Point(213, 56);
            this.tbSeats.Name = "tbSeats";
            this.tbSeats.Size = new System.Drawing.Size(54, 20);
            this.tbSeats.TabIndex = 13;
            // 
            // tbBodyShape
            // 
            this.tbBodyShape.Location = new System.Drawing.Point(213, 81);
            this.tbBodyShape.Name = "tbBodyShape";
            this.tbBodyShape.Size = new System.Drawing.Size(54, 20);
            this.tbBodyShape.TabIndex = 14;
            // 
            // tbFuel
            // 
            this.tbFuel.Location = new System.Drawing.Point(213, 133);
            this.tbFuel.Name = "tbFuel";
            this.tbFuel.Size = new System.Drawing.Size(54, 20);
            this.tbFuel.TabIndex = 15;
            // 
            // tbAuto
            // 
            this.tbAuto.Location = new System.Drawing.Point(213, 159);
            this.tbAuto.Name = "tbAuto";
            this.tbAuto.Size = new System.Drawing.Size(54, 20);
            this.tbAuto.TabIndex = 16;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(213, 185);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(54, 20);
            this.tbPrice.TabIndex = 17;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(122, 192);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 18;
            this.lblPrice.Text = "Price";
            // 
            // cbMake
            // 
            this.cbMake.FormattingEnabled = true;
            this.cbMake.Location = new System.Drawing.Point(12, 55);
            this.cbMake.Name = "cbMake";
            this.cbMake.Size = new System.Drawing.Size(88, 21);
            this.cbMake.TabIndex = 19;
            this.cbMake.SelectedIndexChanged += new System.EventHandler(this.cbMake_SelectedIndexChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(322, 30);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 20;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(322, 5);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(100, 20);
            this.tbTotal.TabIndex = 21;
            // 
            // btnQuote
            // 
            this.btnQuote.Location = new System.Drawing.Point(330, 205);
            this.btnQuote.Name = "btnQuote";
            this.btnQuote.Size = new System.Drawing.Size(75, 23);
            this.btnQuote.TabIndex = 22;
            this.btnQuote.Text = "Quote";
            this.btnQuote.UseVisualStyleBackColor = true;
            this.btnQuote.TextChanged += new System.EventHandler(this.Quote);
            this.btnQuote.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(330, 234);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Book";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbQuote
            // 
            this.tbQuote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbQuote.Location = new System.Drawing.Point(428, 207);
            this.tbQuote.Name = "tbQuote";
            this.tbQuote.Size = new System.Drawing.Size(100, 20);
            this.tbQuote.TabIndex = 24;
            // 
            // tbReg
            // 
            this.tbReg.Location = new System.Drawing.Point(12, 249);
            this.tbReg.Name = "tbReg";
            this.tbReg.Size = new System.Drawing.Size(88, 20);
            this.tbReg.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(609, 306);
            this.Controls.Add(this.tbReg);
            this.Controls.Add(this.tbQuote);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnQuote);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.cbMake);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbAuto);
            this.Controls.Add(this.tbFuel);
            this.Controls.Add(this.tbBodyShape);
            this.Controls.Add(this.tbSeats);
            this.Controls.Add(this.lblAutomatic);
            this.Controls.Add(this.lblFuel);
            this.Controls.Add(this.lblSeats);
            this.Controls.Add(this.lblShape);
            this.Controls.Add(this.tbEngineSize);
            this.Controls.Add(this.lblEngine);
            this.Controls.Add(this.tbDoors);
            this.Controls.Add(this.lblDoors);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cbVehicleChooser);
            this.Controls.Add(this.lblMainLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Label lblMainLabel;
        private System.Windows.Forms.ComboBox cbVehicleChooser;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDoors;
        private System.Windows.Forms.TextBox tbDoors;
        private System.Windows.Forms.Label lblEngine;
        private System.Windows.Forms.TextBox tbEngineSize;
        private System.Windows.Forms.Label lblShape;
        private System.Windows.Forms.Label lblSeats;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.Label lblAutomatic;
        private System.Windows.Forms.TextBox tbSeats;
        private System.Windows.Forms.TextBox tbBodyShape;
        private System.Windows.Forms.TextBox tbFuel;
        private System.Windows.Forms.TextBox tbAuto;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cbMake;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Button btnQuote;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbQuote;
        private System.Windows.Forms.TextBox tbReg;
        }
    }

